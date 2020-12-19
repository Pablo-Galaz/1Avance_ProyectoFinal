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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        

        //Metodo para regresar al menu principal
        private void Boton_Regresar_Click(object sender, EventArgs e)
        {
            Opciones opcion = new Opciones();
            opcion.Show();
            this.Hide();
        }

        //Metodo para abrir el Form de Celulares
        private void btn_Celulares_Click(object sender, EventArgs e)
        {
            Celulares celular = new Celulares();
            celular.Show();
            this.Hide();
        }

        //Metodo para abrir el form de Laptops
        private void btn_Laptops_Click(object sender, EventArgs e)
        {
            Laptops laps = new Laptops();
            laps.Show();
            this.Hide();
        }

        //Metodo para abrir el form de las PC´S
        private void btn_PCS_Click(object sender, EventArgs e)
        {
            PCS pc = new PCS();
            pc.Show();
            this.Hide();
        }

        //Metodo para abrir el form de las USB´S
        private void btn_USBS_Click(object sender, EventArgs e)
        {
            USBS usb = new USBS();
            usb.Show();
            this.Hide();
        }

        //Metodo para abrir el form de los SO
        private void btn_SO_Click(object sender, EventArgs e)
        {
            SO sistemao = new SO();
            sistemao.Show();
            this.Hide();
        }

        //Metodo para abrir el form de las Impresoras
        private void btn_Impresoras_Click(object sender, EventArgs e)
        {
            Impresoras impre = new Impresoras();
            impre.Show();
            this.Hide();
        }

        private void btn_AñadirCompra_Click(object sender, EventArgs e)
        {

        }

        private void btn_BorrarCompra_Click(object sender, EventArgs e)
        {

        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_totalPagar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_SuPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Cambio_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}