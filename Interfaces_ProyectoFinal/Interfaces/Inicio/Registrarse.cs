using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal  {
    public partial class Registrarse : Form  {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public Registrarse()  {
            InitializeComponent();
        }

        //Metodo para mostrar u ocultar la contraseña
        private void Mostrar_Contraseña_CheckedChanged(object sender, EventArgs e)  {
            if (Mostrar_Contraseña.Checked == true)  {           //Validar si el CheckBox esta activado

                if (TextBox_CrearPass.PasswordChar == '*')  {   //Validamos si lo que esta en el PasswordChar es un asterisco               
                    TextBox_CrearPass.PasswordChar = '\0';     //Cambiamos lo que es el PasswordChar a nulo
                }

            } else  {   //Sino         
                TextBox_CrearPass.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
            }
        }
        
        //Metodo para guardar al nuevo usuario en la base de datos
        private void Btn_Registrarse_Click(object sender, EventArgs e)  {
            //Objetos
            FuncionesUsuarios usuario = new FuncionesUsuarios();
            Interfaz_De_Login login = new Interfaz_De_Login();

            //Validar si hay otro usuario con el mismo nombre en la base de datos, en caso de no ser asi, se registrara el usuario
            usuario.ValidarUsuarioExistente(this, login, TextBox_Usuario, TextBox_CrearPass);

        }

        //Regresar al log in
        private void Foto_Regresar_Click(object sender, EventArgs e)  {
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