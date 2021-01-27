using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterTech.Herramientas  {
    public partial class Calculadora : Form  {

        //Variables Globales
        double numero1, numero2, resultado;
        bool Bandera1 = false, Bandera2 = false;
        String opcionIndicada;

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams {

            get {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Metodo Constructor
        public Calculadora() {
            InitializeComponent();
        }

        private void Numero1_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void Numero2_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void Numero3_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void Numero4_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void Numero5_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void Numero6_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void Numero7_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Numero8_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void Numero9_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void Suma_Click(object sender, EventArgs e) {
            if (!Bandera1 && !Bandera2)
            {
                numero1 = Convert.ToDouble(Pantalla.Text);
                Pantalla.Text = "";
                Bandera1 = true;
                Bandera2 = true;
                opcionIndicada = "Suma";
            }
        }

        private void Resta_Click(object sender, EventArgs e) {
            if (!Bandera1 && !Bandera2)
            {
                numero1 = Convert.ToDouble(Pantalla.Text);
                Pantalla.Text = "";
                Bandera1 = true;
                Bandera2 = true;
                opcionIndicada = "Resta";
            }
        }

        private void Multiplicacion_Click(object sender, EventArgs e) {
            if (!Bandera1 && !Bandera2)
            {
                numero1 = Convert.ToDouble(Pantalla.Text);
                Pantalla.Text = "";
                Bandera1 = true;
                Bandera2 = true;
                opcionIndicada = "Multiplicacion";
            }
        }

        private void Division_Click(object sender, EventArgs e) {
            if (!Bandera1 && !Bandera2)
            {
                numero1 = Convert.ToDouble(Pantalla.Text);
                Pantalla.Text = "";
                Bandera1 = true;
                Bandera2 = true;
                opcionIndicada = "Division";
            }
        }

        private void Numero0_Click(object sender, EventArgs e) {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void BotonIgual_Click(object sender, EventArgs e) {
            if (Bandera1) {
                numero2 = Convert.ToDouble(Pantalla.Text);
                resultado = Operaciones(opcionIndicada);
                Pantalla.Text = resultado.ToString();
                Borrar();
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e) {
            Pantalla.Text = "";
            Borrar();
        }

        private double Operaciones(string operacion) {
            double resultado = 0.0;
            switch (operacion)
            {
                case "Suma":
                    resultado = numero1 + numero2;
                    break;

                case "Resta":
                    resultado = numero1 - numero2;
                    break;

                case "Multiplicacion":
                    resultado = numero1 * numero2;
                    break;

                case "Division":
                    if (numero2 == 0)  {
                        MessageBox.Show("No se puede dividir entre cero");
                        Pantalla.Text = "";
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;
            }

            return resultado;
        }

        private void Borrar() {
            Bandera1 = false;
            Bandera2 = false;
        }


    }
}