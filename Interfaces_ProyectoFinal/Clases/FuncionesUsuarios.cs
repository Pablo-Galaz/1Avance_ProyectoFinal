using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal  {

    public class FuncionesUsuarios  {

        //Metodo para registrar un nuevo Usuario en la Base de Datos
        public void insertarusuario(Form rgs, Form lg, string username, string userpassword)  {

            //Variables
            string nombreusuario = username;
            string contrausuario = userpassword;

            //Comando para saber en que tabla de la Base de Datos, insertar los datos
            string sql = "insert into usuarioslogin(user, password) values('" + nombreusuario + "', '" + contrausuario + "')";

            //Llamando al objeto de la conexion para posteriormente, abrir conexion con la base de datos 
            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion();
            conexionBaseDatos.Open();

            try  {

                //Comando para subir los datos a la Base de Datos 
                MySqlCommand comando = new MySqlCommand(sql, conexionBaseDatos);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso", "El Usuario " + nombreusuario + " ha sido registrado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }  catch (MySqlException excep)  {
                MessageBox.Show(excep.Message);    //Mostrar un mensaje de error

            }  finally  {
                conexionBaseDatos.Close();        //Cerrando conexion con la base de datos
            }

        }


        //Metodo para validar si existe el Usuario
        public void ValidarUsuarioExistente(Form regis, Form lg, TextBox username, TextBox userpassword)  {
            //Variables
            string nombreu = username.Text;
            string passu = userpassword.Text;

            //Llamando al objeto de la conexion para posteriormente, abrir conexion con la base de datos 
            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion();
            conexionBaseDatos.Open();

            //Comando
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBaseDatos;
            com.CommandText = ("select user from usuarioslogin where user= '" + nombreu + "'");

            //Reader de la base de datos.
            MySqlDataReader leer = com.ExecuteReader();

            //Condicion para ver si hay algun dato leido.
            if (leer.Read() == true)  {
                MessageBox.Show("El Usuario Ya Existe.\nPor Favor registre un usuario con otro nombre.", "Error al registrar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";         //Vaciando el TextBox
                
            } else  {
                insertarusuario(regis, lg, nombreu, passu); //Invocando al metodo para registrar al usuario en la base de datos.
                username.Text = "";         //Vaciando el TextBox
                userpassword.Text = "";     //Vaciando el TextBox
            }

        }


        //Metodo para validar si existe el usuario y Posteriormente Cambiar la contraseña
        public void actualizarcontra(Form rp, Form login, TextBox usuario, TextBox contraseña)  {
            //Declarar Variables
            string nombreusuario = usuario.Text;

            //Llamando al objeto de la conexion para posteriormente, abrir conexion con la base de datos 
            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion();
            conexionBaseDatos.Open();

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBaseDatos;
            com.CommandText = ("select user from usuarioslogin where user= '" + nombreusuario + "'");

            //Reader de la base de datos
            MySqlDataReader leer = com.ExecuteReader();

            //Condicion para ver si hay algun dato leido.
            if (leer.Read() == true)  {
                cambiarContraseña(rp, login, usuario, contraseña);     //Registrando al usuario en la base de datos

            } else {
                MessageBox.Show("El Usuario Indicado no existe", "Intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.Text = "";
            }

        }


        //Metodo para cambiar la contraseña
        public void cambiarContraseña(Form rp, Form login, TextBox username, TextBox userpassword)  {
            //Variables
            string user = username.Text;
            string password = userpassword.Text;

            //Comando para saber en que tabla insertar que datos.
            string sql = "update usuarioslogin set user= '" + user + "', password='" + password + "' where user='" + user + "'";

            //Llamando al objeto de la conexion para posteriormente, abrir conexion con la base de datos 
            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion();
            conexionBaseDatos.Open();

            try {
                //Comando para abrir los datos 
                MySqlCommand comando = new MySqlCommand(sql, conexionBaseDatos);
                comando.ExecuteNonQuery();
                MessageBox.Show("La Contraseña ha sido modificada Exitosamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (MySqlException error) {
                MessageBox.Show(error.Message);   //Mensaje de error 

            } finally {
                conexionBaseDatos.Close();   //Cerramos la conexion con la base de datos
                rp.Close();         //Cerramos el form de resetear Password
                login.Show();      //Mostramos el login

              }

        }


        //Metodo para validar los datos del formulario del log in
        public void ValidarDatosLogIn(Form fl, Form hm, TextBox tbusuario, TextBox tbcontra)  {
            //Variables
            String nombreusuario = tbusuario.Text;
            String contrausuario = tbcontra.Text;

            //Llamar y abrir la conexion con la base de datos
            MySqlConnection conexionBd = conexion.obteniendoConexion();
            conexionBd.Open();

            //Comando 
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionBd;
            codigo.CommandText = ("select * from usuarioslogin where user ='" + nombreusuario + "'and password = '" + contrausuario + "' ");

            //Reader de la base de datos
            MySqlDataReader leer = codigo.ExecuteReader();

            //Verificando que no falten campos en el formulario por llenar
            if ((tbusuario.Text == String.Empty) || (tbcontra.Text == String.Empty))  {
                MessageBox.Show("Faltan Campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                //Saber si hay algun dato que leer
                if (leer.Read()) {
                    MessageBox.Show("Bienvenido " + nombreusuario, "Inicio de Sesion Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexionBd.Close();    //Cerramos la base de datos
                    fl.Dispose();          //Cerramos el login
                    hm.Show();             //Abrimos el Home

                } else {
                    MessageBox.Show("Usuario o Contraseña Incorrectos", "Problema al iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbusuario.Text = "";    //Dejando en blanco los TextBox
                    tbcontra.Text = "";     //Dejando en blanco los TextBox
                }
            }
        }


        //Metodo para buscar el usuario en la base de datos 
        public void BuscarUsuariobd(TextBox tbu, TextBox tbp1, TextBox tbp2)  {

            //Llamar y abrir la conexion con la base de datos
            MySqlConnection conexionBd = conexion.obteniendoConexion();
            conexionBd.Open();

            //Comando 
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionBd;
            codigo.CommandText = ("select * from usuarioslogin where user= '" + tbu.Text +"'");

            //Reader de la base de datos.
            MySqlDataReader leer = codigo.ExecuteReader();

            //Condicion para ver si hay algun dato leido
            if (leer.Read() == true) {

                //Si las contraseñas coinciden
                if (tbp1.Text == tbp2.Text) {

                    CoincidenciaUsuarioPassword(tbu, tbp1, tbp2);    //Invocando al metodo

                } else {   //Sino

                    MessageBox.Show("Las contraseñas no coindicen", "Intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbp1.Text = "";    //Vaciando el TextBox
                    tbp2.Text = "";    //Vaciando el TextBox

                }

                
            } else {
                MessageBox.Show("El Usuario que desea eliminar no esta registrado", "Problema con el usuario "+tbu.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbu.Text = "";     //Vaciando el TextBox
                tbp1.Text = "";    //Vaciando el TextBox
                tbp2.Text = "";    //Vaciando el TextBox
            }

        }


        //Metodo que comprueba que la contraseña, coincida con el usuario que se quiera eliminar de la base de datos
        public void CoincidenciaUsuarioPassword(TextBox u, TextBox p,  TextBox p2) {

            //Variable
            string sql = "select * from usuarioslogin where user ='" + u.Text + "'and password = '" + p.Text + "' ";

            //Llamar y abrir la conexion con la base de datos
            MySqlConnection conexionBd = conexion.obteniendoConexion();
            conexionBd.Open();

            //Comando 
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionBd;
            codigo.CommandText = (sql);

            //Reader de la base de datos.
            MySqlDataReader leer = codigo.ExecuteReader();

            if(leer.Read() == true) {
                EliminarUsuario(u, p, p2);   //Invocamos al metodo

            } else {
                MessageBox.Show("Las contraseñas y el usuario no coinciden", "Intentelo de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                u.Text = "";     //Vaciando el TextBox
                p.Text = "";    //Vaciando el TextBox
                p2.Text = "";    //Vaciando el TextBox
            }

            conexionBd.Close();     //Cerramos la conexion con la base de datos
             
        }


        //Metodo que elimina al usuario encontrado en el metodo anterior, en la base de datos
        public void EliminarUsuario(TextBox tbusuario, TextBox tbcontra, TextBox tbcontra2)  {
            //Variables
            String nombre = tbusuario.Text;
            String pass1 = tbcontra.Text;

            //Llamar y abrir la conexion con la base de datos
            MySqlConnection conexionBd = conexion.obteniendoConexion();
            conexionBd.Open();

            //Comando 
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conexionBd;
            codigo.CommandText = ("delete from usuarioslogin where user='" + nombre + "'and password = '" + pass1 + "' ");

            //Reader de la base de datos.
            MySqlDataReader leer = codigo.ExecuteReader();

            //Condicion para ver si hay algun dato leido
            if (leer.Read() == true) {
                MessageBox.Show("El usuario " +nombre + " no ha sido eliminado", "Eliminacion Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            } else {
                MessageBox.Show("El usuario " + nombre + " ha sido eliminado exitosamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbusuario.Text = "";      //Vaciando el textBox
                tbcontra.Text = "";       //Vaciando el textBox
                tbcontra2.Text = "";      //Vaciando el textBox
            }


        }



    }
}