using System;
using InterTech;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal {

    public partial class Interfaz_De_Login : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor de la clase
        public Interfaz_De_Login() {
            InitializeComponent();
        }

        //Metodo para mostrar u ocultar la contraseña.
        private void Mostrar_Contraseña_CheckedChanged(object sender, EventArgs e) {
            if (Mostrar_Contraseña.Checked == true) {           //Validar si el CheckBox esta activado
                if (TextBox_Contraseña.PasswordChar == '*') {   //Validamos si lo que esta en el PasswordChar es un asterisco               
                    TextBox_Contraseña.PasswordChar = '\0';     //Cambiamos lo que es el PasswordChar a nulo
                }

            } else {   //Sino         
                TextBox_Contraseña.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
            }
        }

        //Metodo para validar los datos del Log In
        private void Boton_Ingresar_Click(object sender, EventArgs e) {
            //Objetos
            FuncionesUsuarios fu = new FuncionesUsuarios();
            Home hm = new Home();

            //Validar el usuario y la contraseña
            fu.ValidarDatosLogIn(this, hm, TextBox_Usuario, TextBox_Contraseña);
        }

        //Metodo para cambiar la contraseña
        private void Lb_CambiarContra_Click(object sender, EventArgs e) {
            ResetearPassword cambiarcontra = new ResetearPassword();   //Creando un objeto de la clase ResetearPassword
            cambiarcontra.Show();                                      //Mostrar el form de ResetearPassword
            this.Visible = false;                                      //Ocultar el form del login
        }

        //Metodo para crear una cuenta
        private void Lb_CrearCuenta_Click(object sender, EventArgs e) {
            Registrarse registrar = new Registrarse();                 //Creando un objeto de la clase Registrar
            registrar.Show();                                          //Mostrar el form de Registrar
            this.Visible = false;                                      //Ocultar el form del login
        }

        //Metodo para borrar una cuenta
        private void Lb_BorrarCuenta_Click(object sender, EventArgs e) {
            BorrarCuenta borrar = new BorrarCuenta();                 //Creando un objeto de la clase BorrarCuenta
            borrar.Show();                                            //Mostrar el form de BorrarCuenta
            this.Visible = false;                                     //Ocultar el form del login
        }

        //Metodo para salir del Login
        private void SalirPrograma_Click_1(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea salir del Programa?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Environment.Exit(0);
            }

        }

        //Verificamos que se haya presionado el enter.
        private void TextBox_Contraseña_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)  {

            if (e.KeyData == Keys.Enter)  {
                //Objetos
                FuncionesUsuarios fu = new FuncionesUsuarios();
                Home fh = new Home();

                //Metodo para validar la contraseña y el usuario en la base de datos.
                fu.ValidarDatosLogIn(this, fh, TextBox_Usuario, TextBox_Contraseña);
            }

        }
    

    }
}