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
    public partial class ResetearPassword : Form
    {
        public ResetearPassword()
        {
            InitializeComponent();
        }

        //Metodo para mostrar u ocultar la Contraseña
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

        //Metodo para Cambiar la Contraseña
        private void Boton_CambiarContra_Click(object sender, EventArgs e)
        {

        }


    }
}