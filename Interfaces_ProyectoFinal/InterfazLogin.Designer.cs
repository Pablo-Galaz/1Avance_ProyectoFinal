namespace Interfaces_ProyectoFinal
{
    partial class Interfaz_De_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_De_Login));
            this.TextBox_Usuario = new System.Windows.Forms.TextBox();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.TextBox_Contraseña = new System.Windows.Forms.TextBox();
            this.Mostrar_Contraseña = new System.Windows.Forms.CheckBox();
            this.Boton_Ingresar = new System.Windows.Forms.Button();
            this.reset_Password = new System.Windows.Forms.LinkLabel();
            this.Crear_cuenta = new System.Windows.Forms.LinkLabel();
            this.SalirPrograma = new System.Windows.Forms.PictureBox();
            this.Imagen_Contraseña = new System.Windows.Forms.PictureBox();
            this.Imagen_Usuario = new System.Windows.Forms.PictureBox();
            this.Imagen_Candado = new System.Windows.Forms.PictureBox();
            this.ImagenFondo_LogIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalirPrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Candado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo_LogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Usuario
            // 
            this.TextBox_Usuario.BackColor = System.Drawing.Color.SteelBlue;
            this.TextBox_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Usuario.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Usuario.Location = new System.Drawing.Point(182, 145);
            this.TextBox_Usuario.Multiline = true;
            this.TextBox_Usuario.Name = "TextBox_Usuario";
            this.TextBox_Usuario.Size = new System.Drawing.Size(212, 22);
            this.TextBox_Usuario.TabIndex = 1;
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.BackColor = System.Drawing.Color.SteelBlue;
            this.Label_Usuario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.ForeColor = System.Drawing.Color.White;
            this.Label_Usuario.Location = new System.Drawing.Point(118, 113);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(76, 18);
            this.Label_Usuario.TabIndex = 6;
            this.Label_Usuario.Text = "USUARIO";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.label_Contraseña.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.ForeColor = System.Drawing.Color.White;
            this.label_Contraseña.Location = new System.Drawing.Point(118, 198);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(116, 18);
            this.label_Contraseña.TabIndex = 9;
            this.label_Contraseña.Text = "CONTRASEÑA";
            // 
            // TextBox_Contraseña
            // 
            this.TextBox_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.TextBox_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Contraseña.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Contraseña.Location = new System.Drawing.Point(182, 238);
            this.TextBox_Contraseña.Multiline = true;
            this.TextBox_Contraseña.Name = "TextBox_Contraseña";
            this.TextBox_Contraseña.PasswordChar = '*';
            this.TextBox_Contraseña.Size = new System.Drawing.Size(212, 22);
            this.TextBox_Contraseña.TabIndex = 10;
            // 
            // Mostrar_Contraseña
            // 
            this.Mostrar_Contraseña.AutoSize = true;
            this.Mostrar_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.Mostrar_Contraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mostrar_Contraseña.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar_Contraseña.Location = new System.Drawing.Point(182, 276);
            this.Mostrar_Contraseña.Name = "Mostrar_Contraseña";
            this.Mostrar_Contraseña.Size = new System.Drawing.Size(176, 23);
            this.Mostrar_Contraseña.TabIndex = 12;
            this.Mostrar_Contraseña.Text = "Mostrar Contraseña";
            this.Mostrar_Contraseña.UseVisualStyleBackColor = false;
            this.Mostrar_Contraseña.CheckedChanged += new System.EventHandler(this.Mostrar_Contraseña_CheckedChanged);
            // 
            // Boton_Ingresar
            // 
            this.Boton_Ingresar.AllowDrop = true;
            this.Boton_Ingresar.BackColor = System.Drawing.Color.SteelBlue;
            this.Boton_Ingresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Boton_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boton_Ingresar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Ingresar.ForeColor = System.Drawing.Color.White;
            this.Boton_Ingresar.Location = new System.Drawing.Point(144, 315);
            this.Boton_Ingresar.Name = "Boton_Ingresar";
            this.Boton_Ingresar.Size = new System.Drawing.Size(149, 32);
            this.Boton_Ingresar.TabIndex = 3;
            this.Boton_Ingresar.Text = "INGRESAR";
            this.Boton_Ingresar.UseVisualStyleBackColor = false;
            this.Boton_Ingresar.Click += new System.EventHandler(this.Boton_Ingresar_Click);
            // 
            // reset_Password
            // 
            this.reset_Password.AutoSize = true;
            this.reset_Password.BackColor = System.Drawing.Color.SteelBlue;
            this.reset_Password.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Password.LinkColor = System.Drawing.Color.Black;
            this.reset_Password.Location = new System.Drawing.Point(-1, 371);
            this.reset_Password.Name = "reset_Password";
            this.reset_Password.Size = new System.Drawing.Size(198, 23);
            this.reset_Password.TabIndex = 14;
            this.reset_Password.TabStop = true;
            this.reset_Password.Text = "Olvidaste tu Contraseña?";
            this.reset_Password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reset_Password_LinkClicked);
            // 
            // Crear_cuenta
            // 
            this.Crear_cuenta.AutoSize = true;
            this.Crear_cuenta.BackColor = System.Drawing.Color.SteelBlue;
            this.Crear_cuenta.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear_cuenta.LinkColor = System.Drawing.Color.Black;
            this.Crear_cuenta.Location = new System.Drawing.Point(228, 371);
            this.Crear_cuenta.Name = "Crear_cuenta";
            this.Crear_cuenta.Size = new System.Drawing.Size(180, 23);
            this.Crear_cuenta.TabIndex = 15;
            this.Crear_cuenta.TabStop = true;
            this.Crear_cuenta.Text = "No tienes una Cuenta?";
            this.Crear_cuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Crear_cuenta_LinkClicked);
            // 
            // SalirPrograma
            // 
            this.SalirPrograma.BackColor = System.Drawing.Color.SteelBlue;
            this.SalirPrograma.Image = ((System.Drawing.Image)(resources.GetObject("SalirPrograma.Image")));
            this.SalirPrograma.Location = new System.Drawing.Point(378, 12);
            this.SalirPrograma.Name = "SalirPrograma";
            this.SalirPrograma.Size = new System.Drawing.Size(35, 33);
            this.SalirPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalirPrograma.TabIndex = 16;
            this.SalirPrograma.TabStop = false;
            this.SalirPrograma.Click += new System.EventHandler(this.SalirPrograma_Click);
            // 
            // Imagen_Contraseña
            // 
            this.Imagen_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.Imagen_Contraseña.Image = global::Interfaces_ProyectoFinal.Properties.Resources.password1;
            this.Imagen_Contraseña.Location = new System.Drawing.Point(121, 219);
            this.Imagen_Contraseña.Name = "Imagen_Contraseña";
            this.Imagen_Contraseña.Size = new System.Drawing.Size(43, 41);
            this.Imagen_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Contraseña.TabIndex = 11;
            this.Imagen_Contraseña.TabStop = false;
            // 
            // Imagen_Usuario
            // 
            this.Imagen_Usuario.BackColor = System.Drawing.Color.SteelBlue;
            this.Imagen_Usuario.Image = global::Interfaces_ProyectoFinal.Properties.Resources.login;
            this.Imagen_Usuario.Location = new System.Drawing.Point(121, 134);
            this.Imagen_Usuario.Name = "Imagen_Usuario";
            this.Imagen_Usuario.Size = new System.Drawing.Size(35, 33);
            this.Imagen_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen_Usuario.TabIndex = 8;
            this.Imagen_Usuario.TabStop = false;
            // 
            // Imagen_Candado
            // 
            this.Imagen_Candado.BackColor = System.Drawing.Color.SteelBlue;
            this.Imagen_Candado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imagen_Candado.Image = global::Interfaces_ProyectoFinal.Properties.Resources.password;
            this.Imagen_Candado.Location = new System.Drawing.Point(12, 154);
            this.Imagen_Candado.Name = "Imagen_Candado";
            this.Imagen_Candado.Size = new System.Drawing.Size(78, 75);
            this.Imagen_Candado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagen_Candado.TabIndex = 5;
            this.Imagen_Candado.TabStop = false;
            // 
            // ImagenFondo_LogIn
            // 
            this.ImagenFondo_LogIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImagenFondo_LogIn.Image = ((System.Drawing.Image)(resources.GetObject("ImagenFondo_LogIn.Image")));
            this.ImagenFondo_LogIn.Location = new System.Drawing.Point(-4, 0);
            this.ImagenFondo_LogIn.Name = "ImagenFondo_LogIn";
            this.ImagenFondo_LogIn.Size = new System.Drawing.Size(431, 427);
            this.ImagenFondo_LogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenFondo_LogIn.TabIndex = 0;
            this.ImagenFondo_LogIn.TabStop = false;
            // 
            // Interfaz_De_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(425, 426);
            this.Controls.Add(this.SalirPrograma);
            this.Controls.Add(this.Crear_cuenta);
            this.Controls.Add(this.reset_Password);
            this.Controls.Add(this.Mostrar_Contraseña);
            this.Controls.Add(this.Imagen_Contraseña);
            this.Controls.Add(this.TextBox_Contraseña);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.Imagen_Usuario);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.Imagen_Candado);
            this.Controls.Add(this.Boton_Ingresar);
            this.Controls.Add(this.TextBox_Usuario);
            this.Controls.Add(this.ImagenFondo_LogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interfaz_De_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfaz_De_Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SalirPrograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Candado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenFondo_LogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenFondo_LogIn;
        private System.Windows.Forms.TextBox TextBox_Usuario;
        private System.Windows.Forms.PictureBox Imagen_Candado;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.PictureBox Imagen_Usuario;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.TextBox TextBox_Contraseña;
        private System.Windows.Forms.PictureBox Imagen_Contraseña;
        private System.Windows.Forms.CheckBox Mostrar_Contraseña;
        private System.Windows.Forms.Button Boton_Ingresar;
        private System.Windows.Forms.LinkLabel reset_Password;
        private System.Windows.Forms.LinkLabel Crear_cuenta;
        private System.Windows.Forms.PictureBox SalirPrograma;
    }
}

