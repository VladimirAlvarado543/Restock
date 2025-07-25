namespace Vista.Clientes
{
    partial class frmVerClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarID = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarClientes = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlBuscarDetalles = new System.Windows.Forms.Panel();
            this.lblBuscarDetalles = new System.Windows.Forms.Label();
            this.pnlBuscarID = new System.Windows.Forms.Panel();
            this.lblBuscarID = new System.Windows.Forms.Label();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            this.pnlBuscarNombre = new System.Windows.Forms.Panel();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlBuscarDetalles.SuspendLayout();
            this.pnlBuscarID.SuspendLayout();
            this.pnlBuscarNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarID);
            this.panel1.Controls.Add(this.btnAgregarClientes);
            this.panel1.Controls.Add(this.dgvClientes);
            this.panel1.Controls.Add(this.pnlBuscarDetalles);
            this.panel1.Controls.Add(this.pnlBuscarID);
            this.panel1.Controls.Add(this.txtBuscarEmpresa);
            this.panel1.Controls.Add(this.pnlBuscarNombre);
            this.panel1.Controls.Add(this.txtBuscarNombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 698);
            this.panel1.TabIndex = 0;
            // 
            // txtBuscarID
            // 
            this.txtBuscarID.Location = new System.Drawing.Point(871, 28);
            this.txtBuscarID.Mask = "99999";
            this.txtBuscarID.Name = "txtBuscarID";
            this.txtBuscarID.Size = new System.Drawing.Size(146, 22);
            this.txtBuscarID.TabIndex = 22;
            this.txtBuscarID.ValidatingType = typeof(int);
            this.txtBuscarID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBuscarID_MaskInputRejected);
            this.txtBuscarID.TextChanged += new System.EventHandler(this.txtBuscarID_TextChanged);
            // 
            // btnAgregarClientes
            // 
            this.btnAgregarClientes.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClientes.Location = new System.Drawing.Point(669, 163);
            this.btnAgregarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarClientes.Name = "btnAgregarClientes";
            this.btnAgregarClientes.Size = new System.Drawing.Size(237, 76);
            this.btnAgregarClientes.TabIndex = 21;
            this.btnAgregarClientes.Text = "Agregar Clientes";
            this.btnAgregarClientes.UseVisualStyleBackColor = false;
            this.btnAgregarClientes.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(-3, 335);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1020, 207);
            this.dgvClientes.TabIndex = 20;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // pnlBuscarDetalles
            // 
            this.pnlBuscarDetalles.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlBuscarDetalles.Controls.Add(this.lblBuscarDetalles);
            this.pnlBuscarDetalles.Location = new System.Drawing.Point(46, 183);
            this.pnlBuscarDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBuscarDetalles.Name = "pnlBuscarDetalles";
            this.pnlBuscarDetalles.Size = new System.Drawing.Size(267, 75);
            this.pnlBuscarDetalles.TabIndex = 19;
            // 
            // lblBuscarDetalles
            // 
            this.lblBuscarDetalles.AutoSize = true;
            this.lblBuscarDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarDetalles.Location = new System.Drawing.Point(46, 28);
            this.lblBuscarDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarDetalles.Name = "lblBuscarDetalles";
            this.lblBuscarDetalles.Size = new System.Drawing.Size(182, 24);
            this.lblBuscarDetalles.TabIndex = 1;
            this.lblBuscarDetalles.Text = "Buscar por Empresa";
            // 
            // pnlBuscarID
            // 
            this.pnlBuscarID.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlBuscarID.Controls.Add(this.lblBuscarID);
            this.pnlBuscarID.Location = new System.Drawing.Point(588, 4);
            this.pnlBuscarID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBuscarID.Name = "pnlBuscarID";
            this.pnlBuscarID.Size = new System.Drawing.Size(267, 75);
            this.pnlBuscarID.TabIndex = 18;
            // 
            // lblBuscarID
            // 
            this.lblBuscarID.AutoSize = true;
            this.lblBuscarID.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarID.Location = new System.Drawing.Point(77, 27);
            this.lblBuscarID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarID.Name = "lblBuscarID";
            this.lblBuscarID.Size = new System.Drawing.Size(123, 24);
            this.lblBuscarID.TabIndex = 1;
            this.lblBuscarID.Text = "Buscar por ID";
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(320, 208);
            this.txtBuscarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarEmpresa.Multiline = true;
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(245, 31);
            this.txtBuscarEmpresa.TabIndex = 17;
            this.txtBuscarEmpresa.TextChanged += new System.EventHandler(this.txtBuscarDetalles_TextChanged);
            // 
            // pnlBuscarNombre
            // 
            this.pnlBuscarNombre.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlBuscarNombre.Controls.Add(this.lblBuscarNombre);
            this.pnlBuscarNombre.Location = new System.Drawing.Point(38, 4);
            this.pnlBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBuscarNombre.Name = "pnlBuscarNombre";
            this.pnlBuscarNombre.Size = new System.Drawing.Size(267, 75);
            this.pnlBuscarNombre.TabIndex = 14;
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.Location = new System.Drawing.Point(43, 27);
            this.lblBuscarNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(175, 24);
            this.lblBuscarNombre.TabIndex = 1;
            this.lblBuscarNombre.Text = "Buscar por Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.Location = new System.Drawing.Point(312, 24);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarNombre.Multiline = true;
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(209, 31);
            this.txtBuscarNombre.TabIndex = 12;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // frmVerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerClientes";
            this.Text = "frmVerClientes";
            this.Load += new System.EventHandler(this.frmVerClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlBuscarDetalles.ResumeLayout(false);
            this.pnlBuscarDetalles.PerformLayout();
            this.pnlBuscarID.ResumeLayout(false);
            this.pnlBuscarID.PerformLayout();
            this.pnlBuscarNombre.ResumeLayout(false);
            this.pnlBuscarNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlBuscarDetalles;
        private System.Windows.Forms.Label lblBuscarDetalles;
        private System.Windows.Forms.Panel pnlBuscarID;
        private System.Windows.Forms.Label lblBuscarID;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
        private System.Windows.Forms.Panel pnlBuscarNombre;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Button btnAgregarClientes;
        private System.Windows.Forms.MaskedTextBox txtBuscarID;
    }
}