using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal
{
    public partial class Interfaz_De_Login : Form
    {
        public Interfaz_De_Login()
        {
            InitializeComponent();
        }

        //Metodo para mostrar u ocultar la contraseña.
        private void Mostrar_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (Mostrar_Contraseña.Checked == true)           //Validar si el CheckBox esta activado
            {
                if (TextBox_Contraseña.PasswordChar == '*')   //Validamos si lo que esta en el PasswordChar es un asterisco
                {
                    TextBox_Contraseña.PasswordChar = '\0';   //Cambiamos lo que es el PasswordChar a nulo
                }
            }
            else    //Sino
            {
                TextBox_Contraseña.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
            }

        }

        //Metodo para validar los datos del Log In
        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            if ((TextBox_Usuario.Text == "") || (TextBox_Contraseña.Text == ""))  //Si las casillas del usuario o contraseña estan vacias
            {
                MessageBox.Show("FALTAN CAMPOS POR LLENAR");                      //Imprime este mensaje
            }
            

            if ((TextBox_Usuario.Text != "") && (TextBox_Contraseña.Text != ""))  //Si las casillas de contraseña y usuario estan en blanco
            {
                if ((TextBox_Usuario.Text == "Administrador") && (TextBox_Contraseña.Text == "Password123"))   //Si los campos de usuario y contraseña contienen estos datos
                {
                    MessageBox.Show("BIENVENIDO");              //Imprima este mensaje
                    Opciones abriropciones = new Opciones();    //Crea un constructor de la clase Opciones
                    abriropciones.Show();                       //Mostrar el form llamado
                    this.Hide();                                //Deje de mostrar el anterior Form
                }
                else  //Sino
                {
                    MessageBox.Show("DATOS INCORRECTOS, INTENTELO DE NUEVO");   //Imprimir este mensaje
                    TextBox_Usuario.Text = "";                                  //El TextBox del Usuario se vaciara
                    TextBox_Contraseña.Text = "";                               //El TextBox de la contraseña se vaciara
                }
            }

        }


    }
}