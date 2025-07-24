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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnCategoria_Marca = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.btnGestionarProveedores = new System.Windows.Forms.Button();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVerInventario = new System.Windows.Forms.Button();
            this.btnGestionarInventario = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlBarraUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarraLateral.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraUsuario
            // 
            this.pnlBarraUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraUsuario.Controls.Add(this.pictureBox1);
            this.pnlBarraUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraUsuario.Name = "pnlBarraUsuario";
            this.pnlBarraUsuario.Size = new System.Drawing.Size(1455, 104);
            this.pnlBarraUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBarraLateral.Controls.Add(this.btnGestionarUsuarios);
            this.pnlBarraLateral.Controls.Add(this.btnCategoria_Marca);
            this.pnlBarraLateral.Controls.Add(this.btnVerProveedores);
            this.pnlBarraLateral.Controls.Add(this.btnGestionarProveedores);
            this.pnlBarraLateral.Controls.Add(this.btnAgregarClientes);
            this.pnlBarraLateral.Controls.Add(this.btnVerClientes);
            this.pnlBarraLateral.Controls.Add(this.btnClientes);
            this.pnlBarraLateral.Controls.Add(this.pnlInventario);
            this.pnlBarraLateral.Controls.Add(this.btnGestionarInventario);
            this.pnlBarraLateral.Controls.Add(this.btnInicio);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 104);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(174, 642);
            this.pnlBarraLateral.TabIndex = 1;
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 477);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(174, 67);
            this.btnGestionarUsuarios.TabIndex = 14;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnCategoria_Marca
            // 
            this.btnCategoria_Marca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria_Marca.Location = new System.Drawing.Point(0, 425);
            this.btnCategoria_Marca.Name = "btnCategoria_Marca";
            this.btnCategoria_Marca.Size = new System.Drawing.Size(174, 52);
            this.btnCategoria_Marca.TabIndex = 13;
            this.btnCategoria_Marca.Text = "Gestionar Categorias y marcas";
            this.btnCategoria_Marca.UseVisualStyleBackColor = true;
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerProveedores.Location = new System.Drawing.Point(0, 380);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(174, 45);
            this.btnVerProveedores.TabIndex = 12;
            this.btnVerProveedores.Text = "AgregarProveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = true;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // btnGestionarProveedores
            // 
            this.btnGestionarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarProveedores.Location = new System.Drawing.Point(0, 335);
            this.btnGestionarProveedores.Name = "btnGestionarProveedores";
            this.btnGestionarProveedores.Size = new System.Drawing.Size(174, 45);
            this.btnGestionarProveedores.TabIndex = 11;
            this.btnGestionarProveedores.Text = "Proveedores";
            this.btnGestionarProveedores.UseVisualStyleBackColor = true;
            this.btnGestionarProveedores.Click += new System.EventHandler(this.btnGestionarProveedores_Click);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarClientes.Location = new System.Drawing.Point(0, 289);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(174, 46);
            this.btnAgregarClientes.TabIndex = 10;
            this.btnAgregarClientes.Text = "Agregar Clientes";
            this.btnAgregarClientes.UseVisualStyleBackColor = true;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerClientes.Location = new System.Drawing.Point(0, 243);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(174, 46);
            this.btnVerClientes.TabIndex = 9;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Location = new System.Drawing.Point(0, 192);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(174, 51);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // pnlInventario
            // 
            this.pnlInventario.Controls.Add(this.btnAgregarProducto);
            this.pnlInventario.Controls.Add(this.btnVerInventario);
            this.pnlInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventario.Location = new System.Drawing.Point(0, 112);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(174, 80);
            this.pnlInventario.TabIndex = 2;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 38);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(174, 42);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Añadir Prducto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnVerInventario
            // 
            this.btnVerInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerInventario.Location = new System.Drawing.Point(0, 0);
            this.btnVerInventario.Name = "btnVerInventario";
            this.btnVerInventario.Size = new System.Drawing.Size(174, 38);
            this.btnVerInventario.TabIndex = 0;
            this.btnVerInventario.Text = "Ver Stock";
            this.btnVerInventario.UseVisualStyleBackColor = true;
            this.btnVerInventario.Click += new System.EventHandler(this.btnVerInventario_Click);
            // 
            // btnGestionarInventario
            // 
            this.btnGestionarInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarInventario.Location = new System.Drawing.Point(0, 57);
            this.btnGestionarInventario.Name = "btnGestionarInventario";
            this.btnGestionarInventario.Size = new System.Drawing.Size(174, 55);
            this.btnGestionarInventario.TabIndex = 1;
            this.btnGestionarInventario.Text = "Inventario";
            this.btnGestionarInventario.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(174, 57);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 746);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1455, 35);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(174, 104);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1281, 642);
            this.pnlCentral.TabIndex = 3;
            // 
            // frmDahsboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 781);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlBarraLateral);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlBarraUsuario);
            this.Name = "frmDahsboard";
            this.Text = "frmDahsboard";
            this.pnlBarraUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraLateral.ResumeLayout(false);
            this.pnlInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraUsuario;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnVerInventario;
        private System.Windows.Forms.Button btnGestionarInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategoria_Marca;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnGestionarProveedores;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnGestionarUsuarios;
    }
}