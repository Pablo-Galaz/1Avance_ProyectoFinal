using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interfaces_ProyectoFinal  {
    public partial class InterfazAgregarArticulos : Form  {

        protected override CreateParams CreateParams  {

            get  {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        //Constructor
        public InterfazAgregarArticulos()  {
            InitializeComponent();
        }

        //Form
        private void InterfazAgregarArticulos_Load(object sender, EventArgs e)  {

            conexion.obteniendoConexion();

            dataGridView1.DataSource = llenargrid();

        }

        //Llenar Tabla
        public DataTable llenargrid() {

         conexion.obteniendoConexion();
            DataTable dt = new DataTable();
            string  sql = "select Modelo, Resolucion, tamano, SO, Procesador, RAM, Memoria, Color, Año, Precio from telefonos";
             MySqlCommand com = new MySqlCommand(sql, conexion.obteniendoConexion());
             MySqlDataAdapter da = new MySqlDataAdapter(com);
             da.Fill(dt);
             return dt;

        }

        //Metodo para agregar un articulo
        private void btn_Agregar_Click(object sender, EventArgs e) {

            conexion.obteniendoConexion();

            string sql = ("insert into telefonos (Modelo, Resolucion, tamano, SO, Procesador, RAM, Memoria, Color, Año, Precio) values (Modelo, Resolucion, tamano, SO, Procesador, RAM, Memoria, Color, Año, Precio");
            MySqlCommand com2 = new MySqlCommand(sql, conexion.obteniendoConexion());
            com2.Parameters.AddWithValue("Modelo", tb_Modelo.Text);
            com2.Parameters.AddWithValue("Resolucion", tb_Resolucion.Text);
            com2.Parameters.AddWithValue("tamano", tb_TamañoPantalla.Text);
            com2.Parameters.AddWithValue("SO", tb_so.Text);
            com2.Parameters.AddWithValue("Procesador", tb_Procesador.Text);
            com2.Parameters.AddWithValue("RAM", tb_RAM.Text);
            com2.Parameters.AddWithValue("Memoria", tb_Almacenamiento.Text);
            com2.Parameters.AddWithValue("Color", tb_Color.Text);
            com2.Parameters.AddWithValue("Año", tb_Año.Text);
            com2.Parameters.AddWithValue("Precio", tb_Precio.Text);

            MessageBox.Show("Datos Agregados con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_TamañoPantalla.Text = "";
                tb_Año.Text = "";
                tb_Precio.Text = "";
                tb_so.Text = "";
                tb_Resolucion.Text = "";
                tb_RAM.Text = "";
                tb_Almacenamiento.Text = "";
                tb_Procesador.Text = "";
                tb_Color.Text = "";
            tb_Modelo.Text = "";

                dataGridView1.DataSource = llenargrid();
 
        }








    }
}