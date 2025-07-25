namespace Vista.Marca_y_categoria
{
    partial class frmMarcaCategoria
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
            this.pnlMarcaCategoria = new System.Windows.Forms.Panel();
            this.dgvVerMarca = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pnlMarcaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMarcaCategoria
            // 
            this.pnlMarcaCategoria.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMarcaCategoria.Controls.Add(this.dgvVerMarca);
            this.pnlMarcaCategoria.Controls.Add(this.btnAgregarMarca);
            this.pnlMarcaCategoria.Controls.Add(this.btnAgregarCategoria);
            this.pnlMarcaCategoria.Controls.Add(this.dgvCategoria);
            this.pnlMarcaCategoria.Location = new System.Drawing.Point(-37, -37);
            this.pnlMarcaCategoria.Name = "pnlMarcaCategoria";
            this.pnlMarcaCategoria.Size = new System.Drawing.Size(1046, 564);
            this.pnlMarcaCategoria.TabIndex = 2;
            this.pnlMarcaCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMarcaCategoria_Paint);
            // 
            // dgvVerMarca
            // 
            this.dgvVerMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerMarca.Location = new System.Drawing.Point(572, 220);
            this.dgvVerMarca.Name = "dgvVerMarca";
            this.dgvVerMarca.RowHeadersWidth = 51;
            this.dgvVerMarca.Size = new System.Drawing.Size(471, 321);
            this.dgvVerMarca.TabIndex = 23;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(669, 62);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(241, 110);
            this.btnAgregarMarca.TabIndex = 22;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(182, 62);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(227, 110);
            this.btnAgregarCategoria.TabIndex = 21;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(49, 220);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.RowTemplate.Height = 24;
            this.dgvCategoria.Size = new System.Drawing.Size(501, 321);
            this.dgvCategoria.TabIndex = 20;
            // 
            // frmMarcaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 516);
            this.Controls.Add(this.pnlMarcaCategoria);
            this.Name = "frmMarcaCategoria";
            this.Text = "frmMarcaCategoria";
            this.Load += new System.EventHandler(this.frmMarcaCategoria_Load);
            this.pnlMarcaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMarcaCategoria;
        private System.Windows.Forms.DataGridView dgvVerMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
    }
}