
namespace InterTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.FondoIP = new System.Windows.Forms.PictureBox();
            this.Lb_BienvenidaIP = new System.Windows.Forms.Label();
            this.btn_Celulares = new System.Windows.Forms.Button();
            this.BTN_Laptops = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_Calculadora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FondoIP)).BeginInit();
            this.SuspendLayout();
            // 
            // FondoIP
            // 
            this.FondoIP.BackColor = System.Drawing.Color.Transparent;
            this.FondoIP.Image = ((System.Drawing.Image)(resources.GetObject("FondoIP.Image")));
            this.FondoIP.Location = new System.Drawing.Point(1, 2);
            this.FondoIP.Name = "FondoIP";
            this.FondoIP.Size = new System.Drawing.Size(802, 535);
            this.FondoIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FondoIP.TabIndex = 0;
            this.FondoIP.TabStop = false;
            // 
            // Lb_BienvenidaIP
            // 
            this.Lb_BienvenidaIP.AutoSize = true;
            this.Lb_BienvenidaIP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lb_BienvenidaIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lb_BienvenidaIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lb_BienvenidaIP.Font = new System.Drawing.Font("Lucida Handwriting", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_BienvenidaIP.Location = new System.Drawing.Point(86, 31);
            this.Lb_BienvenidaIP.Name = "Lb_BienvenidaIP";
            this.Lb_BienvenidaIP.Size = new System.Drawing.Size(686, 31);
            this.Lb_BienvenidaIP.TabIndex = 3;
            this.Lb_BienvenidaIP.Text = "Bienvenido a la Interfaz Principal de InterTech\r\n";
            // 
            // btn_Celulares
            // 
            this.btn_Celulares.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Celulares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Celulares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Celulares.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Celulares.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Celulares.Location = new System.Drawing.Point(63, 101);
            this.btn_Celulares.Name = "btn_Celulares";
            this.btn_Celulares.Size = new System.Drawing.Size(222, 86);
            this.btn_Celulares.TabIndex = 4;
            this.btn_Celulares.Text = "CELULARES";
            this.btn_Celulares.UseVisualStyleBackColor = false;
            this.btn_Celulares.Click += new System.EventHandler(this.btn_Celulares_Click);
            // 
            // BTN_Laptops
            // 
            this.BTN_Laptops.BackColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Laptops.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Laptops.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Laptops.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Laptops.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Laptops.Location = new System.Drawing.Point(497, 101);
            this.BTN_Laptops.Name = "BTN_Laptops";
            this.BTN_Laptops.Size = new System.Drawing.Size(222, 86);
            this.BTN_Laptops.TabIndex = 5;
            this.BTN_Laptops.Text = "LAPTOPS";
            this.BTN_Laptops.UseVisualStyleBackColor = false;
            this.BTN_Laptops.Click += new System.EventHandler(this.BTN_Laptops_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Regresar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Regresar.Location = new System.Drawing.Point(497, 300);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(222, 86);
            this.btn_Regresar.TabIndex = 6;
            this.btn_Regresar.Text = "REGRESAR";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            // 
            // btn_Calculadora
            // 
            this.btn_Calculadora.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Calculadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calculadora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calculadora.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculadora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Calculadora.Location = new System.Drawing.Point(63, 300);
            this.btn_Calculadora.Name = "btn_Calculadora";
            this.btn_Calculadora.Size = new System.Drawing.Size(222, 86);
            this.btn_Calculadora.TabIndex = 7;
            this.btn_Calculadora.Text = "CALCULADORA";
            this.btn_Calculadora.UseVisualStyleBackColor = false;
            this.btn_Calculadora.Click += new System.EventHandler(this.btn_Calculadora_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 535);
            this.Controls.Add(this.btn_Calculadora);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.BTN_Laptops);
            this.Controls.Add(this.btn_Celulares);
            this.Controls.Add(this.Lb_BienvenidaIP);
            this.Controls.Add(this.FondoIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.FondoIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FondoIP;
        private System.Windows.Forms.Label Lb_BienvenidaIP;
        private System.Windows.Forms.Button btn_Celulares;
        private System.Windows.Forms.Button BTN_Laptops;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_Calculadora;
    }
}