using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterTech.Interfaces.Productos.Laptops {
    public partial class HP : Form {

        //Variables Globales
        string so, resolucion, ram, memoria, procesa, color, signoPeso = "$";
        float tamano, año, precio;

        //Codigo para activar el doble buffer
        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Metodo Constructor
        public HP()
        {
            InitializeComponent();
        }
        
        //Metodo para comprar
        private void btn_Comprar_Click(object sender, EventArgs e) {
            //Variables
            int pago = int.Parse(tb_Pago.Text);
            int precio = int.Parse(tb_Precio.Text);

            if (pago >= precio) {
                MessageBox.Show("Felicidades, Compra llevada a cabo con exito", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Pago.Text = "";
                tb_Cambio.Text = "";
                tb_Total.Text = "";
                tb_Cantidad.Text = "";
                tb_TamañoPantalla.Text = "";
                tb_Año.Text = "";
                tb_Precio.Text = "";
                tb_so.Text = "";
                tb_Resolucion.Text = "";
                tb_RAM.Text = ram;
                tb_Almacenamiento.Text = "";
                tb_Procesador.Text = "";
                tb_Color.Text = "";

            } else {
                MessageBox.Show("Saldo Insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Regresar al form anterior
        private void btn_Regresar_Click(object sender, EventArgs e)  {
            //Objeto
            Celulares cel = new Celulares();

            this.Hide();
            cel.Show();
            MessageBox.Show("Regresando", "Amonos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Metodo para calcular el total
        private void btn_Total_Click(object sender, EventArgs e) {
            //Variable local
            int cantidad = int.Parse(tb_Cantidad.Text);
            int precio = int.Parse(tb_Precio.Text);
            int totalpagar = (cantidad * precio);
            tb_Total.Text = totalpagar.ToString();
        }

        
        //Calcular el cambio
        private void btn_Cambio_Click(object sender, EventArgs e) {
            //Variables
            int pago = int.Parse(tb_Pago.Text);
            int total = int.Parse(tb_Total.Text);

            if (pago >= total) {
                int cambio = total - pago;
                tb_Cambio.Text = cambio.ToString();

            } else {
                MessageBox.Show("El saldo no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Metodo del Combo Box
        private void lista_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable local
            int indice = lista_Productos.SelectedIndex;

            if (indice == 1)
            {
                //Caracteristicas e imagen
                tamano = 15.6f;
                año = 2013;
                precio = 6000;
                so = "Windows 8.1";
                resolucion = "1280x720";
                ram = "4 GB";
                memoria = "500 GB";
                procesa = "AMD E300";
                color = "Azul";
                tb_TamañoPantalla.Text = tamano.ToString();
                tb_Año.Text = año.ToString();
                tb_Precio.Text = precio.ToString();
                tb_so.Text = so;
                tb_Resolucion.Text = resolucion;
                tb_RAM.Text = ram;
                tb_Almacenamiento.Text = memoria;
                tb_Procesador.Text = procesa;
                tb_Color.Text = color;
                Imagen.Image = Properties.Resources.Laptop_HP_2000_Azul;
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else
            {
                //Caracteristicas e imagen
                tamano = 16;
                año = 2018;
                precio = 23000;
                so = "Windows 10";
                resolucion = "Ultra HD 4K";
                ram = "8 GB";
                procesa = "Intel Core i5";
                color = "Negra";
                tb_TamañoPantalla.Text = tamano.ToString();
                tb_Año.Text = año.ToString();
                tb_Precio.Text = precio.ToString();
                tb_so.Text = so;
                tb_Resolucion.Text = resolucion;
                tb_RAM.Text = ram;
                tb_Almacenamiento.Text = memoria;
                tb_Procesador.Text = procesa;
                tb_Color.Text = color;
                Imagen.Image = Properties.Resources.Laptop_HP_Pavilion_Gaming_Laptop___Negra;
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}