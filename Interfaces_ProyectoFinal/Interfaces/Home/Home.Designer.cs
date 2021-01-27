
namespace InterTech
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Lb_BienvenidaHome = new System.Windows.Forms.Label();
            this.btn_IP = new System.Windows.Forms.Button();
            this.btn_AgregarArticulos = new System.Windows.Forms.Button();
            this.btn_Preguntas = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.ImagenFondoIP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondoIP)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_BienvenidaHome
            // 
            this.Lb_BienvenidaHome.AutoSize = true;
            this.Lb_BienvenidaHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lb_BienvenidaHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lb_BienvenidaHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lb_BienvenidaHome.Font = new System.Drawing.Font("Lucida Handwriting", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BienvenidaHome.Location = new System.Drawing.Point(134, 29);
            this.Lb_BienvenidaHome.Name = "Lb_BienvenidaHome";
            this.Lb_BienvenidaHome.Size = new System.Drawing.Size(533, 31);
            this.Lb_BienvenidaHome.TabIndex = 1;
            this.Lb_BienvenidaHome.Text = "Bienvenido a su Cuenta de InterTech";
            // 
            // btn_IP
            // 
            this.btn_IP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_IP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_IP.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IP.ForeColor = System.Drawing.Color.Transparent;
            this.btn_IP.Location = new System.Drawing.Point(64, 109);
            this.btn_IP.Name = "btn_IP";
            this.btn_IP.Size = new System.Drawing.Size(205, 76);
            this.btn_IP.TabIndex = 2;
            this.btn_IP.Text = "Interfaz Principal";
            this.btn_IP.UseVisualStyleBackColor = false;
            this.btn_IP.Click += new System.EventHandler(this.btn_IP_Click);
            // 
            // btn_AgregarArticulos
            // 
            this.btn_AgregarArticulos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarArticulos.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarArticulos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AgregarArticulos.Location = new System.Drawing.Point(523, 109);
            this.btn_AgregarArticulos.Name = "btn_AgregarArticulos";
            this.btn_AgregarArticulos.Size = new System.Drawing.Size(205, 76);
            this.btn_AgregarArticulos.TabIndex = 3;
            this.btn_AgregarArticulos.Text = "Agregar Articulos";
            this.btn_AgregarArticulos.UseVisualStyleBackColor = false;
            this.btn_AgregarArticulos.Click += new System.EventHandler(this.btn_AgregarArticulos_Click);
            // 
            // btn_Preguntas
            // 
            this.btn_Preguntas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Preguntas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Preguntas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Preguntas.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Preguntas.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Preguntas.Location = new System.Drawing.Point(64, 278);
            this.btn_Preguntas.Name = "btn_Preguntas";
            this.btn_Preguntas.Size = new System.Drawing.Size(205, 76);
            this.btn_Preguntas.TabIndex = 6;
            this.btn_Preguntas.Text = "Preguntas Frecuentes";
            this.btn_Preguntas.UseVisualStyleBackColor = false;
            this.btn_Preguntas.Click += new System.EventHandler(this.btn_Preguntas_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(523, 296);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(205, 76);
            this.btn_CerrarSesion.TabIndex = 7;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // ImagenFondoIP
            // 
            this.ImagenFondoIP.Image = ((System.Drawing.Image)(resources.GetObject("ImagenFondoIP.Image")));
            this.ImagenFondoIP.Location = new System.Drawing.Point(-2, 0);
            this.ImagenFondoIP.Name = "ImagenFondoIP";
            this.ImagenFondoIP.Size = new System.Drawing.Size(789, 516);
            this.ImagenFondoIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFondoIP.TabIndex = 0;
            this.ImagenFondoIP.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 516);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Preguntas);
            this.Controls.Add(this.btn_AgregarArticulos);
            this.Controls.Add(this.btn_IP);
            this.Controls.Add(this.Lb_BienvenidaHome);
            this.Controls.Add(this.ImagenFondoIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondoIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenFondoIP;
        private System.Windows.Forms.Label Lb_BienvenidaHome;
        private System.Windows.Forms.Button btn_IP;
        private System.Windows.Forms.Button btn_AgregarArticulos;
        private System.Windows.Forms.Button btn_Preguntas;
        private System.Windows.Forms.Button btn_CerrarSesion;
    }
}