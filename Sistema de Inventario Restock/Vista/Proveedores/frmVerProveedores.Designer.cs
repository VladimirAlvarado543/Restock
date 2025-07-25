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
            this.gpIngresos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarid = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.dgvVerProveedores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.gpIngresos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpIngresos
            // 
            this.gpIngresos.Controls.Add(this.panel1);
            this.gpIngresos.Controls.Add(this.txtBuscarid);
            this.gpIngresos.Controls.Add(this.txtBuscarNombre);
            this.gpIngresos.Controls.Add(this.btnAgregarProductos);
            this.gpIngresos.Controls.Add(this.dgvVerProveedores);
            this.gpIngresos.Controls.Add(this.panel2);
            this.gpIngresos.Location = new System.Drawing.Point(12, 12);
            this.gpIngresos.Name = "gpIngresos";
            this.gpIngresos.Size = new System.Drawing.Size(1022, 563);
            this.gpIngresos.TabIndex = 0;
            this.gpIngresos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblBuscarUsuario);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(83, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 25);
            this.panel1.TabIndex = 15;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(5, 6);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(138, 16);
            this.lblBuscarUsuario.TabIndex = 11;
            this.lblBuscarUsuario.Text = "Buscar por nombre";
            // 
            // txtBuscarid
            // 
            this.txtBuscarid.Location = new System.Drawing.Point(743, 126);
            this.txtBuscarid.Name = "txtBuscarid";
            this.txtBuscarid.Size = new System.Drawing.Size(215, 22);
            this.txtBuscarid.TabIndex = 14;
            this.txtBuscarid.TextChanged += new System.EventHandler(this.txtBuscarid_TextChanged);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.Location = new System.Drawing.Point(238, 124);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(340, 22);
            this.txtBuscarNombre.TabIndex = 13;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(326, 4);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(332, 82);
            this.btnAgregarProductos.TabIndex = 10;
            this.btnAgregarProductos.Text = "Agregar Proveedores";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // dgvVerProveedores
            // 
            this.dgvVerProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProveedores.Location = new System.Drawing.Point(6, 169);
            this.dgvVerProveedores.Name = "dgvVerProveedores";
            this.dgvVerProveedores.RowHeadersWidth = 51;
            this.dgvVerProveedores.RowTemplate.Height = 24;
            this.dgvVerProveedores.Size = new System.Drawing.Size(1010, 375);
            this.dgvVerProveedores.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblBuscarId);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(647, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 26);
            this.panel2.TabIndex = 16;
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.Location = new System.Drawing.Point(3, 3);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(72, 16);
            this.lblBuscarId.TabIndex = 12;
            this.lblBuscarId.Text = "Buscar Id";
            // 
            // frmVerProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.gpIngresos);
            this.Name = "frmVerProveedores";
            this.Text = "frmVerProveedores";
            this.Load += new System.EventHandler(this.frmVerProveedores_Load);
            this.gpIngresos.ResumeLayout(false);
            this.gpIngresos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProveedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpIngresos;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.DataGridView dgvVerProveedores;
        private System.Windows.Forms.TextBox txtBuscarid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}