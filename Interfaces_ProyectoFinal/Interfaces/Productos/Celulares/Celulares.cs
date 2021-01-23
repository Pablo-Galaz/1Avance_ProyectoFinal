using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterTech  {
    public partial class Celulares : Form  {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Metodo Constructor
        public Celulares()  {
            InitializeComponent();
        }

        //Metodo para ir con Samsung
        private void btn_Samsung_Click(object sender, EventArgs e)  {
            //Objetos
            Samsung sam = new Samsung();

            this.Hide();    //Ocultamos este form
            sam.Show();      //Mostramos la Interfaz de Samsung
            MessageBox.Show("Bienvenido a la Interfaz de Samsung", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo para ir con Huawei
        private void btn_Huawei_Click(object sender, EventArgs e)  {
            //Objetos
            Huawei hua = new Huawei();

            this.Hide();    //Ocultamos este form
            hua.Show();      //Mostramos la Interfaz de Huawei
            MessageBox.Show("Bienvenido a la Interfaz de Huawei", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo par regresar a la Interfaz Principal
        private void btn_Regresar_Click(object sender, EventArgs e)   {
            //Objetos
            InterfazPrincipal ip = new InterfazPrincipal();

            this.Hide();    //Ocultamos este form
            ip.Show();      //Mostramos la Interfaz Principal
            MessageBox.Show("Regresando a la Interfaz Principal", "Hasta Luego :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}