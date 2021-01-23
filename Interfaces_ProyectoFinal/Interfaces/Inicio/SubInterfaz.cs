using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_ProyectoFinal {

    public partial class SubInterfaz : Form {

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Reloj Interno
        Timer reloj = new Timer();

        //Constructor
        public SubInterfaz() {
            InitializeComponent();
        }

        //Declaracion del Reloj Interno
        private void SubInterfaz_Load(object sender, EventArgs e) {
            reloj.Interval = 2000;
            reloj.Tick += Tarea;
            reloj.Start();
        }

        //Tarea para el Reloj Interno.
        private void Tarea(object sender, EventArgs e) {
            this.Visible = false;
            Interfaz_De_Login Login = new Interfaz_De_Login();
            Login.Show();
            reloj.Stop();
        }

       
    }
}