namespace Vista.InicioSesion
{
    partial class frmInicio
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
            this.GBBienvenido = new System.Windows.Forms.GroupBox();
            this.BTIniciasesion = new System.Windows.Forms.Button();
            this.TXBContrasenia = new System.Windows.Forms.TextBox();
            this.TXBUsuario = new System.Windows.Forms.TextBox();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBContrasena = new System.Windows.Forms.Label();
            this.LBBienvenido = new System.Windows.Forms.Label();
            this.GBBienvenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // GBBienvenido
            // 
            this.GBBienvenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GBBienvenido.Controls.Add(this.BTIniciasesion);
            this.GBBienvenido.Controls.Add(this.TXBContrasenia);
            this.GBBienvenido.Controls.Add(this.TXBUsuario);
            this.GBBienvenido.Controls.Add(this.PBLogo);
            this.GBBienvenido.Controls.Add(this.LBUsuario);
            this.GBBienvenido.Controls.Add(this.label4);
            this.GBBienvenido.Controls.Add(this.LBContrasena);
            this.GBBienvenido.Controls.Add(this.LBBienvenido);
            this.GBBienvenido.Location = new System.Drawing.Point(311, 116);
            this.GBBienvenido.Name = "GBBienvenido";
            this.GBBienvenido.Size = new System.Drawing.Size(444, 450);
            this.GBBienvenido.TabIndex = 5;
            this.GBBienvenido.TabStop = false;
            // 
            // BTIniciasesion
            // 
            this.BTIniciasesion.Location = new System.Drawing.Point(152, 379);
            this.BTIniciasesion.Name = "BTIniciasesion";
            this.BTIniciasesion.Size = new System.Drawing.Size(135, 39);
            this.BTIniciasesion.TabIndex = 2;
            this.BTIniciasesion.Text = "Inicia sesión";
            this.BTIniciasesion.UseVisualStyleBackColor = true;
            this.BTIniciasesion.Click += new System.EventHandler(this.BTIniciasesion_Click);
            // 
            // TXBContrasenia
            // 
            this.TXBContrasenia.Location = new System.Drawing.Point(59, 331);
            this.TXBContrasenia.Name = "TXBContrasenia";
            this.TXBContrasenia.Size = new System.Drawing.Size(336, 22);
            this.TXBContrasenia.TabIndex = 2;
            this.TXBContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXBUsuario
            // 
            this.TXBUsuario.Location = new System.Drawing.Point(59, 218);
            this.TXBUsuario.Name = "TXBUsuario";
            this.TXBUsuario.Size = new System.Drawing.Size(336, 22);
            this.TXBUsuario.TabIndex = 2;
            this.TXBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PBLogo
            // 
            this.PBLogo.Image = global::Vista.Properties.Resources.logo_opcion_2;
            this.PBLogo.InitialImage = global::Vista.Properties.Resources.logo_opcion_21;
            this.PBLogo.Location = new System.Drawing.Point(31, 23);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(136, 57);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 6;
            this.PBLogo.TabStop = false;
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(55, 179);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(54, 16);
            this.LBUsuario.TabIndex = 5;
            this.LBUsuario.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(-94, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inicia sesión";
            // 
            // LBContrasena
            // 
            this.LBContrasena.AutoSize = true;
            this.LBContrasena.Location = new System.Drawing.Point(55, 292);
            this.LBContrasena.Name = "LBContrasena";
            this.LBContrasena.Size = new System.Drawing.Size(76, 16);
            this.LBContrasena.TabIndex = 2;
            this.LBContrasena.Text = "Contraseña";
            // 
            // LBBienvenido
            // 
            this.LBBienvenido.AutoSize = true;
            this.LBBienvenido.Font = new System.Drawing.Font("Cambria", 19F);
            this.LBBienvenido.Location = new System.Drawing.Point(149, 109);
            this.LBBienvenido.Name = "LBBienvenido";
            this.LBBienvenido.Size = new System.Drawing.Size(172, 37);
            this.LBBienvenido.TabIndex = 0;
            this.LBBienvenido.Text = "Bienvenido";
            this.LBBienvenido.Click += new System.EventHandler(this.LBBienvenido_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 688);
            this.Controls.Add(this.GBBienvenido);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.GBBienvenido.ResumeLayout(false);
            this.GBBienvenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBBienvenido;
        private System.Windows.Forms.Button BTIniciasesion;
        private System.Windows.Forms.TextBox TXBContrasenia;
        private System.Windows.Forms.TextBox TXBUsuario;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBContrasena;
        private System.Windows.Forms.Label LBBienvenido;
    }
}