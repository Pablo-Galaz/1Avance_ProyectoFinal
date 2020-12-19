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
    public partial class Registrarse : Form
    {
        //Declarar Variables Globales
        string username;
        string userpassword;

        public Registrarse()
        {
            InitializeComponent();
        }

        private void TextBox_RegistroUsuario_TextChanged(object sender, EventArgs e)
        {
            username = TextBox_RegistroUsuario.Text;
        }

        private void TextBox_RegistroContraseña_TextChanged(object sender, EventArgs e)
        {
            userpassword = TextBox_RegistroContraseña.Text;
        }

        private void Boton_Registrar_Click(object sender, EventArgs e)
        {
            FuncionesUsuarios funcion = new FuncionesUsuarios();
            funcion.insertarusuario(username, userpassword);
            TextBox_RegistroUsuario.Text = "";
            TextBox_RegistroContraseña.Text = "";         
        }

        //Metodo para mostrar u ocultar la contraseña
        private void Mostrar_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (Mostrar_Contraseña.Checked == true)           //Validar si el CheckBox esta activado
            {
                if (TextBox_RegistroContraseña.PasswordChar == '*')   //Validamos si lo que esta en el PasswordChar es un asterisco
                {
                    TextBox_RegistroContraseña.PasswordChar = '\0';   //Cambiamos lo que es el PasswordChar a nulo
                }
            }
            else    //Sino
            {
                TextBox_RegistroContraseña.PasswordChar = '*';        //Cambiamos el contenido del PasswordChar a un asterisco
            }
        }


    }
}