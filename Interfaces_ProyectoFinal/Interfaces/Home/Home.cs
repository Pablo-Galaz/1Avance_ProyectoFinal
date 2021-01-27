using System;
using Interfaces_ProyectoFinal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterTech  {
    public partial class Home : Form  {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }


        //Metodo Constructor
        public Home()  {
            InitializeComponent();
        }

        //Metodo para ir a la Interfaz Principal
        private void btn_IP_Click(object sender, EventArgs e)  {
            //Objeto
            InterfazPrincipal ip = new InterfazPrincipal();

            this.Hide();    //Ocultamos este form
            ip.Show();     //Mostramos la Interfaz Principal
            MessageBox.Show("Bienvenido a la Interfaz Principal de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);               
        }

        //Metodo para ir a la Interfaz para agregar articulos
        private void btn_AgregarArticulos_Click(object sender, EventArgs e)  {
            //Objetos
            InterfazAgregarArticulos agregar = new InterfazAgregarArticulos();

            this.Hide();        //Ocultamos este form
            agregar.Show();     //Mostramos la interfaz para agregar articulos
            MessageBox.Show("Bienvenido a la Interfaz para agregar articulos de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Metodo para ir a la Interfaz de reportes de Inventario
        private void btn_reportesInventario_Click(object sender, EventArgs e)  {
            //Objetos
            InterfazReportesInventario iri = new InterfazReportesInventario();

            this.Hide();    //Ocultamos este form
            iri.Show();     //Mostramos el login
            MessageBox.Show("Bienvenido a la Interfaz de reportes de Inventario de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para ir a la Interfaz de reportes de ventas
        private void btn_reporteventas_Click(object sender, EventArgs e) {
            //Objetos
            InterfazReporteVentas irv = new InterfazReporteVentas();

            this.Hide();    //Ocultamos este form
            irv.Show();     //Mostramos el reporte de ventas
            MessageBox.Show("Bienvenido a la Interfaz Principal de reportes de Ventas de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para Cerrar Sesion
        private void btn_CerrarSesion_Click(object sender, EventArgs e)  {
            //Objetos
            Interfaz_De_Login idl = new Interfaz_De_Login();

            this.Hide();    //Ocultamos este form
            idl.Show();     //Mostramos el login
            MessageBox.Show("Sesion Cerrada con exito","Hasta Luego :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo que resuelve Preguntas Frecuentes
        private void btn_Preguntas_Click(object sender, EventArgs e) {
            MessageBox.Show("Es la memoria donde se almacenan todos los programas que se estan ejecutando\n", "1.- ¿Que es una Memoria RAM?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Es una unidad de almacenamiento equivalente a 1024 Megabytes\n", "2.- ¿Que es un GigaByte?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Todo va a depender de tus interes, y posibilidades\n", "3.- ¿Que Marca es Mejor?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}