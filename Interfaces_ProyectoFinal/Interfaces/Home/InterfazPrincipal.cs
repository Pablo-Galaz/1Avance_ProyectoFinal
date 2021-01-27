using System;
using Interfaces_ProyectoFinal;
using InterTech.Herramientas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterTech  {
    public partial class InterfazPrincipal : Form  {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Metodo Constructor
        public InterfazPrincipal()  {
            InitializeComponent();
        }

        //Metodo para ir al form de celulares
        private void btn_Celulares_Click(object sender, EventArgs e)  {
            //Objetos
            Celulares cel = new Celulares();

            this.Hide();    //Ocultamos este form
            cel.Show();      //Mostramos la Interfaz de celulares
            MessageBox.Show("Bienvenido a la Interfaz de Celulares de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para ir al form de laptops
        private void BTN_Laptops_Click(object sender, EventArgs e)  {
            //Objeto
            Laptops lap = new Laptops();

            this.Hide();    //Ocultamos este form
            lap.Show();     //Mostramos la Interfaz de laptops
            MessageBox.Show("Bienvenido a la Interfaz de Laptops de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para abrir la Calculadora
        private void btn_Calculadora_Click(object sender, EventArgs e) {
            //Objeto
            Calculadora calc = new Calculadora();

            this.Hide();    //Ocultamos este form
            calc.Show();     //Mostramos la Interfaz de laptops
            MessageBox.Show("Bienvenido a la Calculadora de InterTech", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}