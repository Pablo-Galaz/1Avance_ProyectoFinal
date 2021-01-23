using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal {
    public partial class BorrarCuenta : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public BorrarCuenta() {
            InitializeComponent();
        }

        //Metodo para mostrar u ocultar las contraseñas
        private void Mostrar_Contraseña_CheckedChanged(object sender, EventArgs e)  {
            if (Mostrar_Contraseña.Checked == true)   {           //Validar si el CheckBox esta activado

                if (TextBox_Contraseña.PasswordChar == '*' && TextBox_NewContraseña.PasswordChar == '*')  {   //Validamos si lo que esta en el PasswordChar es un asterisco               
                    TextBox_Contraseña.PasswordChar = '\0';     //Cambiamos lo que es el PasswordChar a nulo
                    TextBox_NewContraseña.PasswordChar = '\0';     //Cambiamos lo que es el PasswordChar a nulo
                }

            } else {   //Sino         
                TextBox_Contraseña.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
                TextBox_NewContraseña.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
            }

        }

        //Metodo para borrar al usuario de la base de datos
        private void Btn_BorrarCuenta_Click(object sender, EventArgs e)  {
            //Objetos
            FuncionesUsuarios fu = new FuncionesUsuarios();
            Interfaz_De_Login idl = new Interfaz_De_Login();

            //Llamando al metodo para eliminar el usuario de la base de datos
            fu.BuscarUsuariobd(TextBox_Usuario, TextBox_Contraseña, TextBox_NewContraseña);

        }

        //Regresar al log in 
        private void Foto_Regresar_Click(object sender, EventArgs e) {
            //Objetos
            Interfaz_De_Login login = new Interfaz_De_Login();

            //Preguntar
            if (MessageBox.Show("Desea regresar al log in?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  {
                this.Hide();    //Ocultamos el form
                login.Show();   //Mostramos el login
            }

        }


    }
}