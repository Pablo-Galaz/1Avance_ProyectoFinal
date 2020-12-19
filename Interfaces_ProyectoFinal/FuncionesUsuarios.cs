using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interfaces_ProyectoFinal
{
    public class FuncionesUsuarios
    {
        public static List<DatosUsuario> mostrardatos()
        {
            List<DatosUsuario> lista = new List<DatosUsuario>();
            MySqlCommand sentencia = new MySqlCommand(String.Format("select id, user, password from usuarios"), conexion.obteniendoConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            while (lector.Read())
            {
                DatosUsuario ddu = new DatosUsuario();
                ddu.id = lector.GetInt32(0);
                ddu.user = lector.GetString(1);
                ddu.password = lector.GetString(2);
                lista.Add(ddu);
            }

            return lista;
        }

        public static bool login(string usuario, string contraseña)
        {
            bool indicador = false;
            MySqlCommand sentencia = new MySqlCommand(String.Format("select * from usuarios where user='" + usuario + "' and password='" + contraseña + "'"), conexion.obteniendoConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.Read())
            {
                indicador = true;
            }
            else
            {
                indicador = false;
            }

            return indicador;
        }
        public void insertarusuario(string username, string userpassword)
        {
            //Variables
            string nombreusuario = username;
            string contrausuario = userpassword;

            string sql = "insert into usuarioslogin(user, password) values('" + nombreusuario + "', '" + contrausuario + "')";

            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion();
            conexionBaseDatos.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBaseDatos);
                comando.ExecuteNonQuery();
                MessageBox.Show("El Usuario ha sido registrado correctamente");

                Registrarse registrarnos = new Registrarse();
                registrarnos.Hide();
                Interfaz_De_Login login = new Interfaz_De_Login();
                login.Show();
                MessageBox.Show("Ya puedes Iniciar Sesion con tu Nuevo Usuario :) ");

            }
            catch (MySqlException excep)
            {

                MessageBox.Show(excep.Message);

            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        //Metodo para validar si existe el usuario y Posteriormente Cambiar la contraseña
        public void actualizarcontra(string usuario, string contraseña)
        {
            //Declarar Variables
            string nombreusuario = usuario;

            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion(); 
            conexionBaseDatos.Open(); 

            //Comando.
            MySqlCommand com = new MySqlCommand();
            com.Connection = conexionBaseDatos;
            com.CommandText = ("select user From usuarioslogin where user= '" + nombreusuario + "'");

            MySqlDataReader leer = com.ExecuteReader(); 

            //Condicion para ver si hay algun dato leido.
            if (leer.Read() == true) {

                cambiarContraseña(usuario, contraseña); 

            }
            else {

                MessageBox.Show("El Usuario Indicado No Existe");

            }

        }

        //Metodo para cambiar la contraseña
        public void cambiarContraseña(string username, string userpassword)
        {
            //Variables
            String user = username;
            String password = userpassword;

            //Comando de en que tabla insertar que datos.
            String sql = "update usuarioslogin set user= '" + user + "' password='" + password + "' where user='" + user + "'";

            MySqlConnection conexionBaseDatos = conexion.obteniendoConexion(); 
            conexionBaseDatos.Open(); 


            try
            {

                MySqlCommand comando = new MySqlCommand(sql, conexionBaseDatos);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario editado con exito.");

            }
            catch (MySqlException error)
            {

                MessageBox.Show(error.Message); 

            }
            finally
            {

                conexionBaseDatos.Close(); 
                scL.Dispose();
                scH.Show();
            }
        }


        public static string eliminarusuario(int id)
        {
            string mensaje;
            string query = "delete from usuarioslogin where id =" + id + ";";
            MySqlCommand sentencia = new MySqlCommand(String.Format(query), conexion.obteniendoConexion());
            MySqlDataReader lector = sentencia.ExecuteReader();

            if (lector.RecordsAffected > 0)
            {
                mensaje = "Usuario Eliminado con Exito";
            }
            else
            {
                mensaje = "No se elimino el usuario";
            }

            return mensaje;
        }

        public void validarusuario(string username, string userpassword)
        {
            
 
        }




    }

}