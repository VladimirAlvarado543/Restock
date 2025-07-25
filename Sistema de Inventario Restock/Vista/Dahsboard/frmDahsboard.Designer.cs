namespace Vista.Dahsboard
{
    partial class frmDahsboard
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
            this.pnlBarraUsuario = new System.Windows.Forms.Panel();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestionarProveedores = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.btnCategoria_Marca = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVerInventario = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlBarraLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraUsuario
            // 
            this.pnlBarraUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBarraUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraUsuario.Name = "pnlBarraUsuario";
            this.pnlBarraUsuario.Size = new System.Drawing.Size(1271, 104);
            this.pnlBarraUsuario.TabIndex = 0;
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlBarraLateral.Controls.Add(this.panel1);
            this.pnlBarraLateral.Controls.Add(this.pnlInventario);
            this.pnlBarraLateral.Controls.Add(this.btnAgregarProducto);
            this.pnlBarraLateral.Controls.Add(this.btnVerInventario);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 104);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(174, 608);
            this.pnlBarraLateral.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnGestionarProveedores);
            this.panel1.Controls.Add(this.btnGestionarUsuarios);
            this.panel1.Controls.Add(this.btnVerProveedores);
            this.panel1.Controls.Add(this.btnCategoria_Marca);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 257);
            this.panel1.TabIndex = 15;
            // 
            // btnGestionarProveedores
            // 
            this.btnGestionarProveedores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarProveedores.Location = new System.Drawing.Point(0, 141);
            this.btnGestionarProveedores.Name = "btnGestionarProveedores";
            this.btnGestionarProveedores.Size = new System.Drawing.Size(174, 55);
            this.btnGestionarProveedores.TabIndex = 11;
            this.btnGestionarProveedores.Text = "Ver Proveedores";
            this.btnGestionarProveedores.UseVisualStyleBackColor = false;
            this.btnGestionarProveedores.Click += new System.EventHandler(this.btnGestionarProveedores_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 190);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(174, 67);
            this.btnGestionarUsuarios.TabIndex = 14;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerProveedores.Location = new System.Drawing.Point(0, 73);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(174, 68);
            this.btnVerProveedores.TabIndex = 12;
            this.btnVerProveedores.Text = "AgregarProveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = false;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // btnCategoria_Marca
            // 
            this.btnCategoria_Marca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategoria_Marca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria_Marca.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria_Marca.Name = "btnCategoria_Marca";
            this.btnCategoria_Marca.Size = new System.Drawing.Size(174, 73);
            this.btnCategoria_Marca.TabIndex = 13;
            this.btnCategoria_Marca.Text = "Gestionar Categorias y marcas";
            this.btnCategoria_Marca.UseVisualStyleBackColor = false;
            this.btnCategoria_Marca.Click += new System.EventHandler(this.btnCategoria_Marca_Click);
            // 
            // pnlInventario
            // 
            this.pnlInventario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlInventario.Controls.Add(this.btnVerClientes);
            this.pnlInventario.Controls.Add(this.btnAgregarClientes);
            this.pnlInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlInventario.Location = new System.Drawing.Point(0, 116);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(174, 121);
            this.pnlInventario.TabIndex = 2;
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerClientes.Location = new System.Drawing.Point(0, 0);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(174, 60);
            this.btnVerClientes.TabIndex = 9;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = false;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarClientes.Location = new System.Drawing.Point(0, 59);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(174, 62);
            this.btnAgregarClientes.TabIndex = 10;
            this.btnAgregarClientes.Text = "Agregar Clientes";
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 64);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(174, 52);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Añadir Prducto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVerInventario
            // 
            this.btnVerInventario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerInventario.Location = new System.Drawing.Point(0, 0);
            this.btnVerInventario.Name = "btnVerInventario";
            this.btnVerInventario.Size = new System.Drawing.Size(174, 64);
            this.btnVerInventario.TabIndex = 0;
            this.btnVerInventario.Text = "Ver Stock";
            this.btnVerInventario.UseVisualStyleBackColor = false;
            this.btnVerInventario.Click += new System.EventHandler(this.btnVerInventario_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 712);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1271, 35);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pbLogo);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(174, 104);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1097, 608);
            this.pnlCentral.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::Vista.Properties.Resources.logo_opcion_21;
            this.pbLogo.ImageLocation = "cen";
            this.pbLogo.InitialImage = global::Vista.Properties.Resources.logo_opcion_2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1097, 608);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // frmDahsboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 747);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlBarraLateral);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlBarraUsuario);
            this.MaximizeBox = false;
            this.Name = "frmDahsboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDahsboard";
            this.Load += new System.EventHandler(this.frmDahsboard_Load);
            this.pnlBarraLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlInventario.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraUsuario;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnVerInventario;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCategoria_Marca;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnGestionarProveedores;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Panel panel1;
    }
}