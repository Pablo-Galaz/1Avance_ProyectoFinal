namespace Interfaces_ProyectoFinal
{
    partial class ResetearPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetearPassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mostrar_Contraseña = new System.Windows.Forms.CheckBox();
            this.Imagen_Contraseña = new System.Windows.Forms.PictureBox();
            this.TextBox_RegistroContraseña = new System.Windows.Forms.TextBox();
            this.label_Contraseña = new System.Windows.Forms.Label();
            this.Imagen_Usuario = new System.Windows.Forms.PictureBox();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.TextBox_RegistroUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Boton_CambiarContra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restablecimiento de Contraseña";
            // 
            // Mostrar_Contraseña
            // 
            this.Mostrar_Contraseña.AutoSize = true;
            this.Mostrar_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.Mostrar_Contraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mostrar_Contraseña.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar_Contraseña.Location = new System.Drawing.Point(152, 299);
            this.Mostrar_Contraseña.Name = "Mostrar_Contraseña";
            this.Mostrar_Contraseña.Size = new System.Drawing.Size(176, 23);
            this.Mostrar_Contraseña.TabIndex = 26;
            this.Mostrar_Contraseña.Text = "Mostrar Contraseña";
            this.Mostrar_Contraseña.UseVisualStyleBackColor = false;
            this.Mostrar_Contraseña.CheckedChanged += new System.EventHandler(this.Mostrar_Contraseña_CheckedChanged);
            // 
            // Imagen_Contraseña
            // 
            this.Imagen_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.Imagen_Contraseña.Image = global::Interfaces_ProyectoFinal.Properties.Resources.password1;
            this.Imagen_Contraseña.Location = new System.Drawing.Point(90, 237);
            this.Imagen_Contraseña.Name = "Imagen_Contraseña";
            this.Imagen_Contraseña.Size = new System.Drawing.Size(43, 41);
            this.Imagen_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen_Contraseña.TabIndex = 25;
            this.Imagen_Contraseña.TabStop = false;
            // 
            // TextBox_RegistroContraseña
            // 
            this.TextBox_RegistroContraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.TextBox_RegistroContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_RegistroContraseña.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RegistroContraseña.Location = new System.Drawing.Point(152, 256);
            this.TextBox_RegistroContraseña.Multiline = true;
            this.TextBox_RegistroContraseña.Name = "TextBox_RegistroContraseña";
            this.TextBox_RegistroContraseña.PasswordChar = '*';
            this.TextBox_RegistroContraseña.Size = new System.Drawing.Size(212, 22);
            this.TextBox_RegistroContraseña.TabIndex = 24;
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.BackColor = System.Drawing.Color.SteelBlue;
            this.label_Contraseña.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.ForeColor = System.Drawing.Color.White;
            this.label_Contraseña.Location = new System.Drawing.Point(90, 216);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(172, 18);
            this.label_Contraseña.TabIndex = 23;
            this.label_Contraseña.Text = "NUEVA CONTRASEÑA";
            // 
            // Imagen_Usuario
            // 
            this.Imagen_Usuario.BackColor = System.Drawing.Color.SteelBlue;
            this.Imagen_Usuario.Image = global::Interfaces_ProyectoFinal.Properties.Resources.login;
            this.Imagen_Usuario.Location = new System.Drawing.Point(90, 152);
            this.Imagen_Usuario.Name = "Imagen_Usuario";
            this.Imagen_Usuario.Size = new System.Drawing.Size(35, 33);
            this.Imagen_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen_Usuario.TabIndex = 22;
            this.Imagen_Usuario.TabStop = false;
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.BackColor = System.Drawing.Color.SteelBlue;
            this.Label_Usuario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.ForeColor = System.Drawing.Color.White;
            this.Label_Usuario.Location = new System.Drawing.Point(90, 131);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(76, 18);
            this.Label_Usuario.TabIndex = 21;
            this.Label_Usuario.Text = "USUARIO";
            // 
            // TextBox_RegistroUsuario
            // 
            this.TextBox_RegistroUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.TextBox_RegistroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_RegistroUsuario.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_RegistroUsuario.Location = new System.Drawing.Point(152, 163);
            this.TextBox_RegistroUsuario.Multiline = true;
            this.TextBox_RegistroUsuario.Name = "TextBox_RegistroUsuario";
            this.TextBox_RegistroUsuario.Size = new System.Drawing.Size(212, 22);
            this.TextBox_RegistroUsuario.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(332, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Boton_CambiarContra
            // 
            this.Boton_CambiarContra.AllowDrop = true;
            this.Boton_CambiarContra.BackColor = System.Drawing.Color.SteelBlue;
            this.Boton_CambiarContra.Cursor = System.Windows.Forms.Cursors.Default;
            this.Boton_CambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Boton_CambiarContra.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_CambiarContra.ForeColor = System.Drawing.Color.White;
            this.Boton_CambiarContra.Location = new System.Drawing.Point(152, 356);
            this.Boton_CambiarContra.Name = "Boton_CambiarContra";
            this.Boton_CambiarContra.Size = new System.Drawing.Size(149, 46);
            this.Boton_CambiarContra.TabIndex = 28;
            this.Boton_CambiarContra.Text = "CAMBIAR  CONTRASEÑA";
            this.Boton_CambiarContra.UseVisualStyleBackColor = false;
            this.Boton_CambiarContra.Click += new System.EventHandler(this.Boton_CambiarContra_Click);
            // 
            // ResetearPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 446);
            this.Controls.Add(this.Boton_CambiarContra);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Mostrar_Contraseña);
            this.Controls.Add(this.Imagen_Contraseña);
            this.Controls.Add(this.TextBox_RegistroContraseña);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.Imagen_Usuario);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.TextBox_RegistroUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetearPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetearPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Mostrar_Contraseña;
        private System.Windows.Forms.PictureBox Imagen_Contraseña;
        private System.Windows.Forms.TextBox TextBox_RegistroContraseña;
        private System.Windows.Forms.Label label_Contraseña;
        private System.Windows.Forms.PictureBox Imagen_Usuario;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.TextBox TextBox_RegistroUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Boton_CambiarContra;
    }
}