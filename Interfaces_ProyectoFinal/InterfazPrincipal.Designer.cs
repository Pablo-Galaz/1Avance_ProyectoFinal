namespace Interfaces_ProyectoFinal
{
    partial class InterfazPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Imagen_InterfazPrincipal = new System.Windows.Forms.PictureBox();
            this.label_SelProductos = new System.Windows.Forms.Label();
            this.btn_Celulares = new System.Windows.Forms.Button();
            this.btn_Laptops = new System.Windows.Forms.Button();
            this.btn_PCS = new System.Windows.Forms.Button();
            this.btn_USBS = new System.Windows.Forms.Button();
            this.btn_Impresoras = new System.Windows.Forms.Button();
            this.btn_SO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Cambio = new System.Windows.Forms.TextBox();
            this.textBox_SuPago = new System.Windows.Forms.TextBox();
            this.textBox_totalPagar = new System.Windows.Forms.TextBox();
            this.btn_AñadirCompra = new System.Windows.Forms.Button();
            this.Boton_Regresar = new System.Windows.Forms.Button();
            this.btn_BorrarCompra = new System.Windows.Forms.Button();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_InterfazPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagen_InterfazPrincipal
            // 
            this.Imagen_InterfazPrincipal.Image = global::Interfaces_ProyectoFinal.Properties.Resources.depositphotos_108268286_stock_photo_abstract_dark_metallic_background;
            this.Imagen_InterfazPrincipal.Location = new System.Drawing.Point(-3, 0);
            this.Imagen_InterfazPrincipal.Name = "Imagen_InterfazPrincipal";
            this.Imagen_InterfazPrincipal.Size = new System.Drawing.Size(660, 520);
            this.Imagen_InterfazPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_InterfazPrincipal.TabIndex = 0;
            this.Imagen_InterfazPrincipal.TabStop = false;
            // 
            // label_SelProductos
            // 
            this.label_SelProductos.AutoSize = true;
            this.label_SelProductos.BackColor = System.Drawing.Color.Black;
            this.label_SelProductos.Font = new System.Drawing.Font("Britannic Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelProductos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_SelProductos.Location = new System.Drawing.Point(181, 45);
            this.label_SelProductos.Name = "label_SelProductos";
            this.label_SelProductos.Size = new System.Drawing.Size(303, 31);
            this.label_SelProductos.TabIndex = 1;
            this.label_SelProductos.Text = "Seleccion de Productos";
            // 
            // btn_Celulares
            // 
            this.btn_Celulares.BackColor = System.Drawing.Color.Black;
            this.btn_Celulares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Celulares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Celulares.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Celulares.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Celulares.Location = new System.Drawing.Point(57, 106);
            this.btn_Celulares.Name = "btn_Celulares";
            this.btn_Celulares.Size = new System.Drawing.Size(122, 35);
            this.btn_Celulares.TabIndex = 2;
            this.btn_Celulares.Text = "Celulares";
            this.btn_Celulares.UseVisualStyleBackColor = false;
            this.btn_Celulares.Click += new System.EventHandler(this.btn_Celulares_Click);
            // 
            // btn_Laptops
            // 
            this.btn_Laptops.BackColor = System.Drawing.Color.Black;
            this.btn_Laptops.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Laptops.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Laptops.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Laptops.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Laptops.Location = new System.Drawing.Point(273, 106);
            this.btn_Laptops.Name = "btn_Laptops";
            this.btn_Laptops.Size = new System.Drawing.Size(122, 35);
            this.btn_Laptops.TabIndex = 3;
            this.btn_Laptops.Text = "Laptops";
            this.btn_Laptops.UseVisualStyleBackColor = false;
            this.btn_Laptops.Click += new System.EventHandler(this.btn_Laptops_Click);
            // 
            // btn_PCS
            // 
            this.btn_PCS.BackColor = System.Drawing.Color.Black;
            this.btn_PCS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PCS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PCS.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PCS.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_PCS.Location = new System.Drawing.Point(516, 106);
            this.btn_PCS.Name = "btn_PCS";
            this.btn_PCS.Size = new System.Drawing.Size(122, 35);
            this.btn_PCS.TabIndex = 4;
            this.btn_PCS.Text = "PC´S";
            this.btn_PCS.UseVisualStyleBackColor = false;
            this.btn_PCS.Click += new System.EventHandler(this.btn_PCS_Click);
            // 
            // btn_USBS
            // 
            this.btn_USBS.BackColor = System.Drawing.Color.Black;
            this.btn_USBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_USBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_USBS.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_USBS.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_USBS.Location = new System.Drawing.Point(57, 235);
            this.btn_USBS.Name = "btn_USBS";
            this.btn_USBS.Size = new System.Drawing.Size(122, 35);
            this.btn_USBS.TabIndex = 5;
            this.btn_USBS.Text = "USB´S";
            this.btn_USBS.UseVisualStyleBackColor = false;
            this.btn_USBS.Click += new System.EventHandler(this.btn_USBS_Click);
            // 
            // btn_Impresoras
            // 
            this.btn_Impresoras.BackColor = System.Drawing.Color.Black;
            this.btn_Impresoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Impresoras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Impresoras.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Impresoras.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Impresoras.Location = new System.Drawing.Point(516, 235);
            this.btn_Impresoras.Name = "btn_Impresoras";
            this.btn_Impresoras.Size = new System.Drawing.Size(122, 35);
            this.btn_Impresoras.TabIndex = 6;
            this.btn_Impresoras.Text = "Impresoras";
            this.btn_Impresoras.UseVisualStyleBackColor = false;
            this.btn_Impresoras.Click += new System.EventHandler(this.btn_Impresoras_Click);
            // 
            // btn_SO
            // 
            this.btn_SO.BackColor = System.Drawing.Color.Black;
            this.btn_SO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SO.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SO.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_SO.Location = new System.Drawing.Point(273, 235);
            this.btn_SO.Name = "btn_SO";
            this.btn_SO.Size = new System.Drawing.Size(122, 35);
            this.btn_SO.TabIndex = 7;
            this.btn_SO.Text = "S.O";
            this.btn_SO.UseVisualStyleBackColor = false;
            this.btn_SO.Click += new System.EventHandler(this.btn_SO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(393, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total a Pagar: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(427, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Su Pago: \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(411, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Su Cambio: \r\n";
            // 
            // textBox_Cambio
            // 
            this.textBox_Cambio.BackColor = System.Drawing.Color.Black;
            this.textBox_Cambio.Enabled = false;
            this.textBox_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cambio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Cambio.Location = new System.Drawing.Point(516, 493);
            this.textBox_Cambio.Name = "textBox_Cambio";
            this.textBox_Cambio.Size = new System.Drawing.Size(141, 22);
            this.textBox_Cambio.TabIndex = 14;
            this.textBox_Cambio.Text = "$";
            this.textBox_Cambio.TextChanged += new System.EventHandler(this.textBox_Cambio_TextChanged);
            // 
            // textBox_SuPago
            // 
            this.textBox_SuPago.BackColor = System.Drawing.Color.Black;
            this.textBox_SuPago.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_SuPago.Location = new System.Drawing.Point(516, 450);
            this.textBox_SuPago.Name = "textBox_SuPago";
            this.textBox_SuPago.Size = new System.Drawing.Size(141, 20);
            this.textBox_SuPago.TabIndex = 15;
            this.textBox_SuPago.TextChanged += new System.EventHandler(this.textBox_SuPago_TextChanged);
            // 
            // textBox_totalPagar
            // 
            this.textBox_totalPagar.BackColor = System.Drawing.Color.Black;
            this.textBox_totalPagar.Enabled = false;
            this.textBox_totalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_totalPagar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_totalPagar.Location = new System.Drawing.Point(516, 398);
            this.textBox_totalPagar.Name = "textBox_totalPagar";
            this.textBox_totalPagar.Size = new System.Drawing.Size(141, 22);
            this.textBox_totalPagar.TabIndex = 16;
            this.textBox_totalPagar.Text = "$";
            this.textBox_totalPagar.TextChanged += new System.EventHandler(this.textBox_totalPagar_TextChanged);
            // 
            // btn_AñadirCompra
            // 
            this.btn_AñadirCompra.BackColor = System.Drawing.Color.Black;
            this.btn_AñadirCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AñadirCompra.Font = new System.Drawing.Font("Franklin Gothic Demi", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AñadirCompra.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_AñadirCompra.Location = new System.Drawing.Point(33, 350);
            this.btn_AñadirCompra.Name = "btn_AñadirCompra";
            this.btn_AñadirCompra.Size = new System.Drawing.Size(84, 54);
            this.btn_AñadirCompra.TabIndex = 25;
            this.btn_AñadirCompra.Text = "Añadir Compra";
            this.btn_AñadirCompra.UseVisualStyleBackColor = false;
            this.btn_AñadirCompra.Click += new System.EventHandler(this.btn_AñadirCompra_Click);
            // 
            // Boton_Regresar
            // 
            this.Boton_Regresar.BackColor = System.Drawing.Color.Black;
            this.Boton_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boton_Regresar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Regresar.ForeColor = System.Drawing.Color.DarkCyan;
            this.Boton_Regresar.Location = new System.Drawing.Point(498, 0);
            this.Boton_Regresar.Name = "Boton_Regresar";
            this.Boton_Regresar.Size = new System.Drawing.Size(159, 36);
            this.Boton_Regresar.TabIndex = 27;
            this.Boton_Regresar.Text = "Regresar Al Menu";
            this.Boton_Regresar.UseVisualStyleBackColor = false;
            this.Boton_Regresar.Click += new System.EventHandler(this.Boton_Regresar_Click);
            // 
            // btn_BorrarCompra
            // 
            this.btn_BorrarCompra.BackColor = System.Drawing.Color.Black;
            this.btn_BorrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BorrarCompra.Font = new System.Drawing.Font("Franklin Gothic Demi", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrarCompra.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_BorrarCompra.Location = new System.Drawing.Point(163, 350);
            this.btn_BorrarCompra.Name = "btn_BorrarCompra";
            this.btn_BorrarCompra.Size = new System.Drawing.Size(84, 54);
            this.btn_BorrarCompra.TabIndex = 28;
            this.btn_BorrarCompra.Text = "Borrar Compra";
            this.btn_BorrarCompra.UseVisualStyleBackColor = false;
            this.btn_BorrarCompra.Click += new System.EventHandler(this.btn_BorrarCompra_Click);
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.BackColor = System.Drawing.Color.Black;
            this.btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Comprar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comprar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Comprar.Location = new System.Drawing.Point(33, 431);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(84, 54);
            this.btn_Comprar.TabIndex = 29;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = false;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.Black;
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Finalizar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Finalizar.Location = new System.Drawing.Point(163, 431);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(84, 54);
            this.btn_Finalizar.TabIndex = 30;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 522);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.btn_BorrarCompra);
            this.Controls.Add(this.Boton_Regresar);
            this.Controls.Add(this.btn_AñadirCompra);
            this.Controls.Add(this.textBox_totalPagar);
            this.Controls.Add(this.textBox_SuPago);
            this.Controls.Add(this.textBox_Cambio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SO);
            this.Controls.Add(this.btn_Impresoras);
            this.Controls.Add(this.btn_USBS);
            this.Controls.Add(this.btn_PCS);
            this.Controls.Add(this.btn_Laptops);
            this.Controls.Add(this.btn_Celulares);
            this.Controls.Add(this.label_SelProductos);
            this.Controls.Add(this.Imagen_InterfazPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_InterfazPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imagen_InterfazPrincipal;
        private System.Windows.Forms.Label label_SelProductos;
        private System.Windows.Forms.Button btn_Celulares;
        private System.Windows.Forms.Button btn_Laptops;
        private System.Windows.Forms.Button btn_PCS;
        private System.Windows.Forms.Button btn_USBS;
        private System.Windows.Forms.Button btn_Impresoras;
        private System.Windows.Forms.Button btn_SO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Cambio;
        private System.Windows.Forms.TextBox textBox_SuPago;
        private System.Windows.Forms.TextBox textBox_totalPagar;
        private System.Windows.Forms.Button btn_AñadirCompra;
        private System.Windows.Forms.Button Boton_Regresar;
        private System.Windows.Forms.Button btn_BorrarCompra;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Button btn_Finalizar;
    }
}