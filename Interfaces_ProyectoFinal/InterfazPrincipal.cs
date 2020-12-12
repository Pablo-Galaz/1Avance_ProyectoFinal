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

        private void Boton_Regresar_Click(object sender, EventArgs e)
        {
            Opciones opcion = new Opciones();
            opcion.Show();
            this.Hide();
        }
    }
}