namespace Vista.Proveedores
{
    partial class frmVerProveedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.dgvVerProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscarid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarid);
            this.groupBox1.Controls.Add(this.txtBuscarNombre);
            this.groupBox1.Controls.Add(this.lblBuscarId);
            this.groupBox1.Controls.Add(this.lblBuscarUsuario);
            this.groupBox1.Controls.Add(this.btnAgregarProductos);
            this.groupBox1.Controls.Add(this.dgvVerProveedores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 652);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(326, 190);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(340, 22);
            this.txtBuscarNombre.TabIndex = 13;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(741, 199);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(63, 16);
            this.lblBuscarId.TabIndex = 12;
            this.lblBuscarId.Text = "Buscar Id";
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(187, 193);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblBuscarUsuario.TabIndex = 11;
            this.lblBuscarUsuario.Text = "Buscar por nombre";
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(445, 8);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(332, 82);
            this.btnAgregarProductos.TabIndex = 10;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // dgvVerProveedores
            // 
            this.dgvVerProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProveedores.Location = new System.Drawing.Point(136, 270);
            this.dgvVerProveedores.Name = "dgvVerProveedores";
            this.dgvVerProveedores.RowHeadersWidth = 51;
            this.dgvVerProveedores.RowTemplate.Height = 24;
            this.dgvVerProveedores.Size = new System.Drawing.Size(928, 375);
            this.dgvVerProveedores.TabIndex = 9;
            // 
            // txtBuscarid
            // 
            this.txtBuscarid.Location = new System.Drawing.Point(833, 196);
            this.txtBuscarid.Name = "txtBuscarid";
            this.txtBuscarid.Size = new System.Drawing.Size(215, 22);
            this.txtBuscarid.TabIndex = 14;
            this.txtBuscarid.TextChanged += new System.EventHandler(this.txtBuscarid_TextChanged);
            // 
            // frmVerProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 702);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVerProveedores";
            this.Text = "frmVerProveedores";
            this.Load += new System.EventHandler(this.frmVerProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.DataGridView dgvVerProveedores;
        private System.Windows.Forms.TextBox txtBuscarid;
    }
}