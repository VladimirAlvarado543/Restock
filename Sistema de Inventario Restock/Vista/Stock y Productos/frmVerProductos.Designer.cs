namespace Vista.Stock_y_Productos
{
    partial class frmVerProductos
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
            this.dgvVerProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarId = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerProductos
            // 
            this.dgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerProductos.Location = new System.Drawing.Point(38, 209);
            this.dgvVerProductos.Name = "dgvVerProductos";
            this.dgvVerProductos.RowHeadersWidth = 51;
            this.dgvVerProductos.RowTemplate.Height = 24;
            this.dgvVerProductos.Size = new System.Drawing.Size(969, 317);
            this.dgvVerProductos.TabIndex = 0;
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarId.Location = new System.Drawing.Point(755, 146);
            this.txtBuscarId.Mask = "0000";
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(173, 24);
            this.txtBuscarId.TabIndex = 11;
            this.txtBuscarId.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBuscarid_MaskInputRejected);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProductos.Location = new System.Drawing.Point(411, 12);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(253, 79);
            this.btnAgregarProductos.TabIndex = 10;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarId.Location = new System.Drawing.Point(679, 152);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(70, 18);
            this.lblBuscarId.TabIndex = 9;
            this.lblBuscarId.Text = "Buscar id";
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.Location = new System.Drawing.Point(78, 152);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(141, 18);
            this.lblBuscarNombre.TabIndex = 8;
            this.lblBuscarNombre.Text = "Buscar Por Nombre";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombre.Location = new System.Drawing.Point(240, 146);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(330, 24);
            this.txtBuscarNombre.TabIndex = 7;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // frmVerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.lblBuscarId);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.dgvVerProductos);
            this.Name = "frmVerProductos";
            this.Text = "frmVerProductos";
            this.Load += new System.EventHandler(this.frmVerProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerProductos;
        private System.Windows.Forms.MaskedTextBox txtBuscarId;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
    }
}