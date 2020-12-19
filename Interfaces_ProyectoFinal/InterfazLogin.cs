using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=intertech;Uid=root;pwd=PabloG2017");
            conexion.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectandonos = new MySqlConnection();
            codigo.Connection = conexion;

            codigo.CommandText = ("select *from usuarioslogin where user ='" + TextBox_Usuario.Text + "'and password = '" + TextBox_Contraseña.Text + "' ");
            
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido");
                Opciones abriropciones = new Opciones();    
                abriropciones.Show();                       
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                TextBox_Contraseña.Text = "";
            }

        }

        //Metodo para resetear la contraseña
        private void reset_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetearPassword cambiarcontra = new ResetearPassword();
            cambiarcontra.Show();
            this.Visible = false;
        }

        //Metodo para crear una cuenta
        private void Crear_cuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrar = new Registrarse();
            registrar.Show();
            this.Visible = false;
        }

        //Metodo para salir del Login
        private void SalirPrograma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que desea salir del Programa?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

    }
}