namespace Interfaces_ProyectoFinal
{
    partial class SubInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubInterfaz));
            this.logo_intertech = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_intertech)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_intertech
            // 
            this.logo_intertech.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.logo_intertech.Enabled = false;
            this.logo_intertech.Image = ((System.Drawing.Image)(resources.GetObject("logo_intertech.Image")));
            this.logo_intertech.Location = new System.Drawing.Point(1, 2);
            this.logo_intertech.Name = "logo_intertech";
            this.logo_intertech.Size = new System.Drawing.Size(246, 200);
            this.logo_intertech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_intertech.TabIndex = 0;
            this.logo_intertech.TabStop = false;
            // 
            // SubInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 205);
            this.Controls.Add(this.logo_intertech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubInterfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubInterfaz";
            this.Load += new System.EventHandler(this.SubInterfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_intertech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_intertech;
    }
}