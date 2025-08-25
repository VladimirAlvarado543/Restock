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
            this.components = new System.ComponentModel.Container();
            this.FLPBarraLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.PNLTresRayitasImagen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PBMenuboton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNDashboard = new System.Windows.Forms.Button();
            this.PNLClientesAnexo = new System.Windows.Forms.Panel();
            this.BTNAgregarClientes = new System.Windows.Forms.Button();
            this.PNLExcClientes = new System.Windows.Forms.Panel();
            this.BTNClientes = new System.Windows.Forms.Button();
            this.BTNVerClientes = new System.Windows.Forms.Button();
            this.PNLExcInventario = new System.Windows.Forms.Panel();
            this.PNLInventario = new System.Windows.Forms.Panel();
            this.BTNInventario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTNAgregarInventario = new System.Windows.Forms.Button();
            this.BTNVesStock = new System.Windows.Forms.Button();
            this.PNLExcProveedoores = new System.Windows.Forms.Panel();
            this.PNLExcProveedor = new System.Windows.Forms.Panel();
            this.BTNProovedores = new System.Windows.Forms.Button();
            this.BTNAgregarProveedor = new System.Windows.Forms.Button();
            this.BTNVerProveedor = new System.Windows.Forms.Button();
            this.PNLExcGestionar = new System.Windows.Forms.Panel();
            this.PNLExcGestion = new System.Windows.Forms.Panel();
            this.BTNGestionar = new System.Windows.Forms.Button();
            this.BTNGestionarCategoriasyMarcas = new System.Windows.Forms.Button();
            this.BTNGestionarUsuarios = new System.Windows.Forms.Button();
            this.TMRBarraLateral = new System.Windows.Forms.Timer(this.components);
            this.TMRSubMenus = new System.Windows.Forms.Timer(this.components);
            this.TMRInventario = new System.Windows.Forms.Timer(this.components);
            this.TMRProveedor = new System.Windows.Forms.Timer(this.components);
            this.TMRGestion = new System.Windows.Forms.Timer(this.components);
            this.PNLArribaInformativo = new System.Windows.Forms.Panel();
            this.PNLMenuPrincipal = new System.Windows.Forms.Panel();
            this.FLPBarraLateral.SuspendLayout();
            this.PNLTresRayitasImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenuboton)).BeginInit();
            this.panel1.SuspendLayout();
            this.PNLClientesAnexo.SuspendLayout();
            this.PNLExcClientes.SuspendLayout();
            this.PNLExcInventario.SuspendLayout();
            this.PNLInventario.SuspendLayout();
            this.PNLExcProveedoores.SuspendLayout();
            this.PNLExcProveedor.SuspendLayout();
            this.PNLExcGestionar.SuspendLayout();
            this.PNLExcGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLPBarraLateral
            // 
            this.FLPBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.FLPBarraLateral.Controls.Add(this.PNLTresRayitasImagen);
            this.FLPBarraLateral.Controls.Add(this.panel1);
            this.FLPBarraLateral.Controls.Add(this.PNLClientesAnexo);
            this.FLPBarraLateral.Controls.Add(this.PNLExcInventario);
            this.FLPBarraLateral.Controls.Add(this.PNLExcProveedoores);
            this.FLPBarraLateral.Controls.Add(this.PNLExcGestionar);
            this.FLPBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLPBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.FLPBarraLateral.MaximumSize = new System.Drawing.Size(301, 795);
            this.FLPBarraLateral.MinimumSize = new System.Drawing.Size(106, 795);
            this.FLPBarraLateral.Name = "FLPBarraLateral";
            this.FLPBarraLateral.Size = new System.Drawing.Size(106, 795);
            this.FLPBarraLateral.TabIndex = 0;
            this.FLPBarraLateral.Click += new System.EventHandler(this.FLPBarraLateral_Click);
            this.FLPBarraLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPBarraLateral_Paint);
            // 
            // PNLTresRayitasImagen
            // 
            this.PNLTresRayitasImagen.Controls.Add(this.label1);
            this.PNLTresRayitasImagen.Controls.Add(this.PBMenuboton);
            this.PNLTresRayitasImagen.Location = new System.Drawing.Point(3, 3);
            this.PNLTresRayitasImagen.MaximumSize = new System.Drawing.Size(298, 138);
            this.PNLTresRayitasImagen.MinimumSize = new System.Drawing.Size(103, 138);
            this.PNLTresRayitasImagen.Name = "PNLTresRayitasImagen";
            this.PNLTresRayitasImagen.Size = new System.Drawing.Size(103, 138);
            this.PNLTresRayitasImagen.TabIndex = 1;
            this.PNLTresRayitasImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLTresRayitasImagen_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(124, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // PBMenuboton
            // 
            this.PBMenuboton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBMenuboton.Image = global::Vista.Properties.Resources.icons8_align_justify_50__1_;
            this.PBMenuboton.Location = new System.Drawing.Point(16, 43);
            this.PBMenuboton.Name = "PBMenuboton";
            this.PBMenuboton.Size = new System.Drawing.Size(66, 54);
            this.PBMenuboton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMenuboton.TabIndex = 0;
            this.PBMenuboton.TabStop = false;
            this.PBMenuboton.Click += new System.EventHandler(this.PBMenuboton_Click);
            this.PBMenuboton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PBMenuboton_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 88);
            this.panel1.TabIndex = 2;
            // 
            // BTNDashboard
            // 
            this.BTNDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDashboard.ForeColor = System.Drawing.Color.White;
            this.BTNDashboard.Image = global::Vista.Properties.Resources.icons8_casa_32__1_;
            this.BTNDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDashboard.Location = new System.Drawing.Point(-11, -11);
            this.BTNDashboard.Name = "BTNDashboard";
            this.BTNDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNDashboard.Size = new System.Drawing.Size(309, 113);
            this.BTNDashboard.TabIndex = 0;
            this.BTNDashboard.Text = "Dashboard";
            this.BTNDashboard.UseVisualStyleBackColor = true;
            this.BTNDashboard.Click += new System.EventHandler(this.BTNDashboard_Click);
            // 
            // PNLClientesAnexo
            // 
            this.PNLClientesAnexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.PNLClientesAnexo.Controls.Add(this.BTNAgregarClientes);
            this.PNLClientesAnexo.Controls.Add(this.PNLExcClientes);
            this.PNLClientesAnexo.Controls.Add(this.BTNVerClientes);
            this.PNLClientesAnexo.Location = new System.Drawing.Point(3, 241);
            this.PNLClientesAnexo.MaximumSize = new System.Drawing.Size(283, 184);
            this.PNLClientesAnexo.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLClientesAnexo.Name = "PNLClientesAnexo";
            this.PNLClientesAnexo.Size = new System.Drawing.Size(283, 90);
            this.PNLClientesAnexo.TabIndex = 7;
            // 
            // BTNAgregarClientes
            // 
            this.BTNAgregarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNAgregarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAgregarClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregarClientes.ForeColor = System.Drawing.Color.White;
            this.BTNAgregarClientes.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNAgregarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregarClientes.Location = new System.Drawing.Point(0, 91);
            this.BTNAgregarClientes.Name = "BTNAgregarClientes";
            this.BTNAgregarClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNAgregarClientes.Size = new System.Drawing.Size(283, 49);
            this.BTNAgregarClientes.TabIndex = 1;
            this.BTNAgregarClientes.Text = "Agregar clientes";
            this.BTNAgregarClientes.UseVisualStyleBackColor = false;
            this.BTNAgregarClientes.Click += new System.EventHandler(this.BTNAgregarClientes_Click);
            // 
            // PNLExcClientes
            // 
            this.PNLExcClientes.Controls.Add(this.BTNClientes);
            this.PNLExcClientes.Location = new System.Drawing.Point(3, 0);
            this.PNLExcClientes.Name = "PNLExcClientes";
            this.PNLExcClientes.Size = new System.Drawing.Size(287, 88);
            this.PNLExcClientes.TabIndex = 3;
            // 
            // BTNClientes
            // 
            this.BTNClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClientes.ForeColor = System.Drawing.Color.White;
            this.BTNClientes.Image = global::Vista.Properties.Resources.icons8_clientes_32__1_;
            this.BTNClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNClientes.Location = new System.Drawing.Point(-16, -19);
            this.BTNClientes.Name = "BTNClientes";
            this.BTNClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNClientes.Size = new System.Drawing.Size(301, 129);
            this.BTNClientes.TabIndex = 0;
            this.BTNClientes.Text = "Clientes";
            this.BTNClientes.UseVisualStyleBackColor = false;
            this.BTNClientes.Click += new System.EventHandler(this.BTNClientes_Click);
            // 
            // BTNVerClientes
            // 
            this.BTNVerClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNVerClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVerClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVerClientes.ForeColor = System.Drawing.Color.White;
            this.BTNVerClientes.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNVerClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNVerClientes.Location = new System.Drawing.Point(0, 138);
            this.BTNVerClientes.Name = "BTNVerClientes";
            this.BTNVerClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNVerClientes.Size = new System.Drawing.Size(283, 47);
            this.BTNVerClientes.TabIndex = 4;
            this.BTNVerClientes.Text = "Ver clientes";
            this.BTNVerClientes.UseVisualStyleBackColor = false;
            this.BTNVerClientes.Click += new System.EventHandler(this.BTNVerClientes_Click);
            // 
            // PNLExcInventario
            // 
            this.PNLExcInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.PNLExcInventario.Controls.Add(this.PNLInventario);
            this.PNLExcInventario.Controls.Add(this.BTNAgregarInventario);
            this.PNLExcInventario.Controls.Add(this.BTNVesStock);
            this.PNLExcInventario.ForeColor = System.Drawing.Color.White;
            this.PNLExcInventario.Location = new System.Drawing.Point(3, 337);
            this.PNLExcInventario.MaximumSize = new System.Drawing.Size(283, 184);
            this.PNLExcInventario.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLExcInventario.Name = "PNLExcInventario";
            this.PNLExcInventario.Size = new System.Drawing.Size(283, 90);
            this.PNLExcInventario.TabIndex = 8;
            // 
            // PNLInventario
            // 
            this.PNLInventario.Controls.Add(this.BTNInventario);
            this.PNLInventario.Controls.Add(this.button4);
            this.PNLInventario.Location = new System.Drawing.Point(3, 0);
            this.PNLInventario.MaximumSize = new System.Drawing.Size(283, 184);
            this.PNLInventario.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLInventario.Name = "PNLInventario";
            this.PNLInventario.Size = new System.Drawing.Size(283, 90);
            this.PNLInventario.TabIndex = 3;
            // 
            // BTNInventario
            // 
            this.BTNInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNInventario.ForeColor = System.Drawing.Color.White;
            this.BTNInventario.Image = global::Vista.Properties.Resources.icons8_producto_32;
            this.BTNInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNInventario.Location = new System.Drawing.Point(-10, -19);
            this.BTNInventario.Name = "BTNInventario";
            this.BTNInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNInventario.Size = new System.Drawing.Size(301, 129);
            this.BTNInventario.TabIndex = 0;
            this.BTNInventario.Text = "Inventario";
            this.BTNInventario.UseVisualStyleBackColor = false;
            this.BTNInventario.Click += new System.EventHandler(this.BTNInventario_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Vista.Properties.Resources.icons8_producto_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-10, -19);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(301, 129);
            this.button4.TabIndex = 1;
            this.button4.Text = "Inventario";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BTNAgregarInventario
            // 
            this.BTNAgregarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNAgregarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAgregarInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregarInventario.ForeColor = System.Drawing.Color.White;
            this.BTNAgregarInventario.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNAgregarInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregarInventario.Location = new System.Drawing.Point(0, 94);
            this.BTNAgregarInventario.Name = "BTNAgregarInventario";
            this.BTNAgregarInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNAgregarInventario.Size = new System.Drawing.Size(283, 51);
            this.BTNAgregarInventario.TabIndex = 1;
            this.BTNAgregarInventario.Text = "     Agregar producto";
            this.BTNAgregarInventario.UseVisualStyleBackColor = false;
            this.BTNAgregarInventario.Click += new System.EventHandler(this.BTNAgregarInventario_Click);
            // 
            // BTNVesStock
            // 
            this.BTNVesStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNVesStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNVesStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVesStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVesStock.ForeColor = System.Drawing.Color.White;
            this.BTNVesStock.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNVesStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNVesStock.Location = new System.Drawing.Point(0, 138);
            this.BTNVesStock.Name = "BTNVesStock";
            this.BTNVesStock.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNVesStock.Size = new System.Drawing.Size(283, 47);
            this.BTNVesStock.TabIndex = 4;
            this.BTNVesStock.Text = "Ver stock";
            this.BTNVesStock.UseVisualStyleBackColor = false;
            this.BTNVesStock.Click += new System.EventHandler(this.BTNVesStock_Click);
            // 
            // PNLExcProveedoores
            // 
            this.PNLExcProveedoores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.PNLExcProveedoores.Controls.Add(this.PNLExcProveedor);
            this.PNLExcProveedoores.Controls.Add(this.BTNAgregarProveedor);
            this.PNLExcProveedoores.Controls.Add(this.BTNVerProveedor);
            this.PNLExcProveedoores.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNLExcProveedoores.ForeColor = System.Drawing.Color.White;
            this.PNLExcProveedoores.Location = new System.Drawing.Point(3, 433);
            this.PNLExcProveedoores.MaximumSize = new System.Drawing.Size(283, 185);
            this.PNLExcProveedoores.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLExcProveedoores.Name = "PNLExcProveedoores";
            this.PNLExcProveedoores.Size = new System.Drawing.Size(283, 90);
            this.PNLExcProveedoores.TabIndex = 9;
            // 
            // PNLExcProveedor
            // 
            this.PNLExcProveedor.Controls.Add(this.BTNProovedores);
            this.PNLExcProveedor.Location = new System.Drawing.Point(3, 0);
            this.PNLExcProveedor.MaximumSize = new System.Drawing.Size(283, 184);
            this.PNLExcProveedor.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLExcProveedor.Name = "PNLExcProveedor";
            this.PNLExcProveedor.Size = new System.Drawing.Size(283, 90);
            this.PNLExcProveedor.TabIndex = 3;
            // 
            // BTNProovedores
            // 
            this.BTNProovedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNProovedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNProovedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProovedores.ForeColor = System.Drawing.Color.White;
            this.BTNProovedores.Image = global::Vista.Properties.Resources.icons8_proveedor_32;
            this.BTNProovedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNProovedores.Location = new System.Drawing.Point(-15, -19);
            this.BTNProovedores.Name = "BTNProovedores";
            this.BTNProovedores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNProovedores.Size = new System.Drawing.Size(311, 129);
            this.BTNProovedores.TabIndex = 0;
            this.BTNProovedores.Text = "   Proveedores";
            this.BTNProovedores.UseVisualStyleBackColor = false;
            this.BTNProovedores.Click += new System.EventHandler(this.BTNProovedores_Click);
            // 
            // BTNAgregarProveedor
            // 
            this.BTNAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAgregarProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.BTNAgregarProveedor.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregarProveedor.Location = new System.Drawing.Point(0, 94);
            this.BTNAgregarProveedor.Name = "BTNAgregarProveedor";
            this.BTNAgregarProveedor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNAgregarProveedor.Size = new System.Drawing.Size(283, 51);
            this.BTNAgregarProveedor.TabIndex = 6;
            this.BTNAgregarProveedor.Text = "     Agregar proveedor";
            this.BTNAgregarProveedor.UseVisualStyleBackColor = false;
            this.BTNAgregarProveedor.Click += new System.EventHandler(this.BTNAgregarProveedor_Click);
            // 
            // BTNVerProveedor
            // 
            this.BTNVerProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNVerProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNVerProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVerProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVerProveedor.ForeColor = System.Drawing.Color.White;
            this.BTNVerProveedor.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNVerProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNVerProveedor.Location = new System.Drawing.Point(0, 138);
            this.BTNVerProveedor.Name = "BTNVerProveedor";
            this.BTNVerProveedor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNVerProveedor.Size = new System.Drawing.Size(283, 47);
            this.BTNVerProveedor.TabIndex = 5;
            this.BTNVerProveedor.Text = "Ver proveedor";
            this.BTNVerProveedor.UseVisualStyleBackColor = false;
            this.BTNVerProveedor.Click += new System.EventHandler(this.BTNVerProveedor_Click);
            // 
            // PNLExcGestionar
            // 
            this.PNLExcGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.PNLExcGestionar.Controls.Add(this.PNLExcGestion);
            this.PNLExcGestionar.Controls.Add(this.BTNGestionarCategoriasyMarcas);
            this.PNLExcGestionar.Controls.Add(this.BTNGestionarUsuarios);
            this.PNLExcGestionar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNLExcGestionar.ForeColor = System.Drawing.Color.White;
            this.PNLExcGestionar.Location = new System.Drawing.Point(3, 529);
            this.PNLExcGestionar.MaximumSize = new System.Drawing.Size(283, 185);
            this.PNLExcGestionar.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLExcGestionar.Name = "PNLExcGestionar";
            this.PNLExcGestionar.Size = new System.Drawing.Size(283, 90);
            this.PNLExcGestionar.TabIndex = 10;
            // 
            // PNLExcGestion
            // 
            this.PNLExcGestion.Controls.Add(this.BTNGestionar);
            this.PNLExcGestion.Location = new System.Drawing.Point(3, 0);
            this.PNLExcGestion.MaximumSize = new System.Drawing.Size(283, 184);
            this.PNLExcGestion.MinimumSize = new System.Drawing.Size(280, 90);
            this.PNLExcGestion.Name = "PNLExcGestion";
            this.PNLExcGestion.Size = new System.Drawing.Size(283, 90);
            this.PNLExcGestion.TabIndex = 3;
            // 
            // BTNGestionar
            // 
            this.BTNGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGestionar.ForeColor = System.Drawing.Color.White;
            this.BTNGestionar.Image = global::Vista.Properties.Resources.icons8_proveedor_32;
            this.BTNGestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionar.Location = new System.Drawing.Point(-15, -19);
            this.BTNGestionar.Name = "BTNGestionar";
            this.BTNGestionar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNGestionar.Size = new System.Drawing.Size(311, 129);
            this.BTNGestionar.TabIndex = 0;
            this.BTNGestionar.Text = "Gestión";
            this.BTNGestionar.UseVisualStyleBackColor = false;
            this.BTNGestionar.Click += new System.EventHandler(this.BTNGestionar_Click);
            // 
            // BTNGestionarCategoriasyMarcas
            // 
            this.BTNGestionarCategoriasyMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNGestionarCategoriasyMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionarCategoriasyMarcas.Font = new System.Drawing.Font("Segoe UI", 5.8F);
            this.BTNGestionarCategoriasyMarcas.ForeColor = System.Drawing.Color.White;
            this.BTNGestionarCategoriasyMarcas.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNGestionarCategoriasyMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionarCategoriasyMarcas.Location = new System.Drawing.Point(0, 94);
            this.BTNGestionarCategoriasyMarcas.Name = "BTNGestionarCategoriasyMarcas";
            this.BTNGestionarCategoriasyMarcas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNGestionarCategoriasyMarcas.Size = new System.Drawing.Size(283, 51);
            this.BTNGestionarCategoriasyMarcas.TabIndex = 6;
            this.BTNGestionarCategoriasyMarcas.Text = "Gestionar categorias y marcas";
            this.BTNGestionarCategoriasyMarcas.UseVisualStyleBackColor = false;
            this.BTNGestionarCategoriasyMarcas.Click += new System.EventHandler(this.BTNGestionarCategoriasyMarcas_Click);
            // 
            // BTNGestionarUsuarios
            // 
            this.BTNGestionarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.BTNGestionarUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTNGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGestionarUsuarios.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGestionarUsuarios.ForeColor = System.Drawing.Color.White;
            this.BTNGestionarUsuarios.Image = global::Vista.Properties.Resources.icons8_punto_32;
            this.BTNGestionarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGestionarUsuarios.Location = new System.Drawing.Point(0, 138);
            this.BTNGestionarUsuarios.Name = "BTNGestionarUsuarios";
            this.BTNGestionarUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNGestionarUsuarios.Size = new System.Drawing.Size(283, 47);
            this.BTNGestionarUsuarios.TabIndex = 5;
            this.BTNGestionarUsuarios.Text = "Gestionar usuarios";
            this.BTNGestionarUsuarios.UseVisualStyleBackColor = false;
            this.BTNGestionarUsuarios.Click += new System.EventHandler(this.BTNGestionarUsuarios_Click);
            // 
            // TMRBarraLateral
            // 
            this.TMRBarraLateral.Interval = 10;
            this.TMRBarraLateral.Tick += new System.EventHandler(this.TMRBarraLateral_Tick);
            // 
            // TMRSubMenus
            // 
            this.TMRSubMenus.Interval = 10;
            this.TMRSubMenus.Tick += new System.EventHandler(this.TMRSubMenus_Tick);
            // 
            // TMRInventario
            // 
            this.TMRInventario.Interval = 10;
            this.TMRInventario.Tick += new System.EventHandler(this.TMRInventario_Tick);
            // 
            // TMRProveedor
            // 
            this.TMRProveedor.Interval = 10;
            this.TMRProveedor.Tick += new System.EventHandler(this.TMRProveedor_Tick);
            // 
            // TMRGestion
            // 
            this.TMRGestion.Interval = 10;
            this.TMRGestion.Tick += new System.EventHandler(this.TMRGestion_Tick);
            // 
            // PNLArribaInformativo
            // 
            this.PNLArribaInformativo.Location = new System.Drawing.Point(307, 4);
            this.PNLArribaInformativo.Name = "PNLArribaInformativo";
            this.PNLArribaInformativo.Size = new System.Drawing.Size(1273, 100);
            this.PNLArribaInformativo.TabIndex = 1;
            // 
            // PNLMenuPrincipal
            // 
            this.PNLMenuPrincipal.Location = new System.Drawing.Point(307, 110);
            this.PNLMenuPrincipal.MaximumSize = new System.Drawing.Size(1440, 673);
            this.PNLMenuPrincipal.Name = "PNLMenuPrincipal";
            this.PNLMenuPrincipal.Size = new System.Drawing.Size(1265, 673);
            this.PNLMenuPrincipal.TabIndex = 2;
            // 
            // frmDahsboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 795);
            this.Controls.Add(this.PNLMenuPrincipal);
            this.Controls.Add(this.PNLArribaInformativo);
            this.Controls.Add(this.FLPBarraLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDahsboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDahsboard";
            this.Load += new System.EventHandler(this.frmDahsboard_Load);
            this.FLPBarraLateral.ResumeLayout(false);
            this.PNLTresRayitasImagen.ResumeLayout(false);
            this.PNLTresRayitasImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMenuboton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PNLClientesAnexo.ResumeLayout(false);
            this.PNLExcClientes.ResumeLayout(false);
            this.PNLExcInventario.ResumeLayout(false);
            this.PNLInventario.ResumeLayout(false);
            this.PNLExcProveedoores.ResumeLayout(false);
            this.PNLExcProveedor.ResumeLayout(false);
            this.PNLExcGestionar.ResumeLayout(false);
            this.PNLExcGestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPBarraLateral;
        private System.Windows.Forms.Panel PNLTresRayitasImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNDashboard;
        private System.Windows.Forms.PictureBox PBMenuboton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TMRBarraLateral;
        private System.Windows.Forms.Panel PNLClientesAnexo;
        private System.Windows.Forms.Button BTNAgregarClientes;
        private System.Windows.Forms.Button BTNVerClientes;
        private System.Windows.Forms.Timer TMRSubMenus;
        private System.Windows.Forms.Timer TMRInventario;
        private System.Windows.Forms.Panel PNLExcClientes;
        private System.Windows.Forms.Button BTNClientes;
        private System.Windows.Forms.Panel PNLExcInventario;
        private System.Windows.Forms.Button BTNAgregarInventario;
        private System.Windows.Forms.Panel PNLInventario;
        private System.Windows.Forms.Button BTNInventario;
        private System.Windows.Forms.Button BTNVesStock;
        private System.Windows.Forms.Timer TMRProveedor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel PNLExcProveedoores;
        private System.Windows.Forms.Panel PNLExcProveedor;
        private System.Windows.Forms.Button BTNProovedores;
        private System.Windows.Forms.Button BTNAgregarProveedor;
        private System.Windows.Forms.Button BTNVerProveedor;
        private System.Windows.Forms.Panel PNLExcGestionar;
        private System.Windows.Forms.Panel PNLExcGestion;
        private System.Windows.Forms.Button BTNGestionar;
        private System.Windows.Forms.Button BTNGestionarCategoriasyMarcas;
        private System.Windows.Forms.Button BTNGestionarUsuarios;
        private System.Windows.Forms.Timer TMRGestion;
        private System.Windows.Forms.Panel PNLArribaInformativo;
        private System.Windows.Forms.Panel PNLMenuPrincipal;
    }
}