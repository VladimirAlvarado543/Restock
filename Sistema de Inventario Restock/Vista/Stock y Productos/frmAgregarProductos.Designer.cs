namespace Vista.Stock_y_Productos
{
    partial class frmAgregarProductos
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.dgvVerCategorias = new System.Windows.Forms.DataGridView();
            this.dgvVerProveedor = new System.Windows.Forms.DataGridView();
            this.dgvVerMarcas = new System.Windows.Forms.DataGridView();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.MaskedTextBox();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.dtmFechaPorducto = new System.Windows.Forms.DateTimePicker();
            this.lblFechas = new System.Windows.Forms.Label();
            this.nupExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.MaskedTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.lblMarcas);
            this.pnlPrincipal.Controls.Add(this.lblCategorias);
            this.pnlPrincipal.Controls.Add(this.dgvVerCategorias);
            this.pnlPrincipal.Controls.Add(this.dgvVerProveedor);
            this.pnlPrincipal.Controls.Add(this.dgvVerMarcas);
            this.pnlPrincipal.Controls.Add(this.txtProveedor);
            this.pnlPrincipal.Controls.Add(this.txtPrecioVenta);
            this.pnlPrincipal.Controls.Add(this.lblIdProveedor);
            this.pnlPrincipal.Controls.Add(this.lblPrecioVenta);
            this.pnlPrincipal.Controls.Add(this.dtmFechaPorducto);
            this.pnlPrincipal.Controls.Add(this.lblFechas);
            this.pnlPrincipal.Controls.Add(this.nupExistencias);
            this.pnlPrincipal.Controls.Add(this.lblExistencias);
            this.pnlPrincipal.Controls.Add(this.btnAgregar);
            this.pnlPrincipal.Controls.Add(this.txtMarca);
            this.pnlPrincipal.Controls.Add(this.lblMarca);
            this.pnlPrincipal.Controls.Add(this.txtPrecioCompra);
            this.pnlPrincipal.Controls.Add(this.lblCategoria);
            this.pnlPrincipal.Controls.Add(this.lblPrecioCompra);
            this.pnlPrincipal.Controls.Add(this.btnEliminar);
            this.pnlPrincipal.Controls.Add(this.txtContacto);
            this.pnlPrincipal.Controls.Add(this.txtDetalles);
            this.pnlPrincipal.Controls.Add(this.txtNombreProducto);
            this.pnlPrincipal.Controls.Add(this.lblDetalles);
            this.pnlPrincipal.Controls.Add(this.lblNombreProducto);
            this.pnlPrincipal.Location = new System.Drawing.Point(107, 26);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(922, 557);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 57;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(740, 302);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(52, 16);
            this.lblMarcas.TabIndex = 56;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(730, 205);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(73, 16);
            this.lblCategorias.TabIndex = 55;
            this.lblCategorias.Text = "Categorias";
            // 
            // dgvVerCategorias
            // 
            this.dgvVerCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCategorias.Location = new System.Drawing.Point(655, 224);
            this.dgvVerCategorias.Name = "dgvVerCategorias";
            this.dgvVerCategorias.RowHeadersWidth = 51;
            this.dgvVerCategorias.RowTemplate.Height = 24;
            this.dgvVerCategorias.Size = new System.Drawing.Size(226, 59);
            this.dgvVerCategorias.TabIndex = 54;
            // 
            // dgvVerProveedor
            // 
            this.dgvVerProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProveedor.Location = new System.Drawing.Point(131, 481);
            this.dgvVerProveedor.Name = "dgvVerProveedor";
            this.dgvVerProveedor.RowHeadersWidth = 51;
            this.dgvVerProveedor.RowTemplate.Height = 24;
            this.dgvVerProveedor.Size = new System.Drawing.Size(226, 66);
            this.dgvVerProveedor.TabIndex = 53;
            // 
            // dgvVerMarcas
            // 
            this.dgvVerMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerMarcas.Location = new System.Drawing.Point(654, 337);
            this.dgvVerMarcas.Name = "dgvVerMarcas";
            this.dgvVerMarcas.RowHeadersWidth = 51;
            this.dgvVerMarcas.RowTemplate.Height = 24;
            this.dgvVerMarcas.Size = new System.Drawing.Size(227, 64);
            this.dgvVerMarcas.TabIndex = 52;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(237, 445);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 22);
            this.txtProveedor.TabIndex = 51;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(237, 411);
            this.txtPrecioVenta.Mask = "99999.00";
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioVenta.TabIndex = 50;
            this.txtPrecioVenta.ValidatingType = typeof(int);
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.BackColor = System.Drawing.Color.LightSalmon;
            this.lblIdProveedor.Location = new System.Drawing.Point(132, 451);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(82, 16);
            this.lblIdProveedor.TabIndex = 49;
            this.lblIdProveedor.Text = "idProveedor";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.Color.LightSalmon;
            this.lblPrecioVenta.Location = new System.Drawing.Point(126, 414);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(103, 16);
            this.lblPrecioVenta.TabIndex = 48;
            this.lblPrecioVenta.Text = "Precio de Venta";
            // 
            // dtmFechaPorducto
            // 
            this.dtmFechaPorducto.Location = new System.Drawing.Point(237, 370);
            this.dtmFechaPorducto.Name = "dtmFechaPorducto";
            this.dtmFechaPorducto.Size = new System.Drawing.Size(249, 22);
            this.dtmFechaPorducto.TabIndex = 47;
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.BackColor = System.Drawing.Color.LightSalmon;
            this.lblFechas.Location = new System.Drawing.Point(41, 370);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(190, 16);
            this.lblFechas.TabIndex = 46;
            this.lblFechas.Text = "Fecha de ingreso del producto";
            // 
            // nupExistencias
            // 
            this.nupExistencias.Location = new System.Drawing.Point(237, 300);
            this.nupExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupExistencias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupExistencias.Name = "nupExistencias";
            this.nupExistencias.Size = new System.Drawing.Size(120, 22);
            this.nupExistencias.TabIndex = 45;
            this.nupExistencias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.BackColor = System.Drawing.Color.LightSalmon;
            this.lblExistencias.Location = new System.Drawing.Point(154, 300);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(75, 16);
            this.lblExistencias.TabIndex = 44;
            this.lblExistencias.Text = "Existencias";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(743, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 71);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(237, 261);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(262, 22);
            this.txtMarca.TabIndex = 41;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.LightSalmon;
            this.lblMarca.Location = new System.Drawing.Point(184, 267);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 40;
            this.lblMarca.Text = "Marca";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(237, 337);
            this.txtPrecioCompra.Mask = "99999.00";
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(96, 22);
            this.txtPrecioCompra.TabIndex = 39;
            this.txtPrecioCompra.ValidatingType = typeof(int);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCategoria.Location = new System.Drawing.Point(163, 226);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 38;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.BackColor = System.Drawing.Color.LightSalmon;
            this.lblPrecioCompra.Location = new System.Drawing.Point(132, 337);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(97, 16);
            this.lblPrecioCompra.TabIndex = 37;
            this.lblPrecioCompra.Text = "Precio Compra";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(743, 97);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 74);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Limpiar Campos";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(237, 220);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(262, 22);
            this.txtContacto.TabIndex = 33;
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(237, 75);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(462, 114);
            this.txtDetalles.TabIndex = 35;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(237, 46);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(262, 22);
            this.txtNombreProducto.TabIndex = 34;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.LightSalmon;
            this.lblDetalles.Location = new System.Drawing.Point(172, 75);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(57, 16);
            this.lblDetalles.TabIndex = 32;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.LightSalmon;
            this.lblNombreProducto.Location = new System.Drawing.Point(96, 49);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(135, 16);
            this.lblNombreProducto.TabIndex = 31;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // frmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmAgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarProductos";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupExistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.MaskedTextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.NumericUpDown nupExistencias;
        private System.Windows.Forms.DateTimePicker dtmFechaPorducto;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.MaskedTextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.DataGridView dgvVerMarcas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.DataGridView dgvVerCategorias;
        private System.Windows.Forms.DataGridView dgvVerProveedor;
    }
}