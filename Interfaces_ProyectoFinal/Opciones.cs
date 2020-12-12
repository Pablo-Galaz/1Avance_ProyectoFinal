using System;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btn_ReporteVentas_Click(object sender, EventArgs e)
        {
            InterfazReporteVentas reporteventas = new InterfazReporteVentas();
            reporteventas.Show();
            this.Hide();
        }

        private void btn_InterfazPrincipal_Click(object sender, EventArgs e)
        {
            InterfazPrincipal ip = new InterfazPrincipal();
            ip.Show();
            this.Hide();
        }

        private void btn_AgregarArticulos_Click(object sender, EventArgs e)
        {
            InterfazAgregarArticulos articulos = new InterfazAgregarArticulos();
            articulos.Show();
            this.Hide();
        }

        private void btn_ReporteInventario_Click(object sender, EventArgs e)
        {
            InterfazReporteInventario reporte = new InterfazReporteInventario();
            reporte.Show();
            this.Hide();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            
        }

        //Metodo para cerrar sesion
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SESION CERRADA CON EXITO");                 //Imprimir este mensaje
            Interfaz_De_Login interfazlogin = new Interfaz_De_Login();   //Crea un constructor de la clase InterfazLogin
            interfazlogin.Show();                                        //Mostrar el form llamado
            this.Hide();                                                 //Deje de mostrar el anterior Form
        }


    }
}