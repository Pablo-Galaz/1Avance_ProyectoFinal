using System;
using InterTech.Interfaces.Productos.Laptops;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal  {
    public partial class Laptops : Form  {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Metodo Constructor
        public Laptops(){
            InitializeComponent();
        }

        //Metodo para ir al form de HP
        private void btn_HP_Click(object sender, EventArgs e) {
            HP hp = new HP();

            this.Hide();    //Ocultamos este form
            hp.Show();      //Mostramos la Interfaz HP
            MessageBox.Show("Bienvenido a la Interfaz de HP", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}