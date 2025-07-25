namespace Vista.Marca_y_categoria
{
    partial class frmMarca
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
            this.lblMarcaId = new System.Windows.Forms.Label();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblMarcaId);
            this.pnlPrincipal.Controls.Add(this.txtCategoriaId);
            this.pnlPrincipal.Controls.Add(this.btnAgregar);
            this.pnlPrincipal.Controls.Add(this.txtDetalles);
            this.pnlPrincipal.Controls.Add(this.txtNombreMarca);
            this.pnlPrincipal.Controls.Add(this.lblDetalles);
            this.pnlPrincipal.Controls.Add(this.lblNombreMarca);
            this.pnlPrincipal.Location = new System.Drawing.Point(-34, -47);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(750, 485);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // lblMarcaId
            // 
            this.lblMarcaId.AutoSize = true;
            this.lblMarcaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMarcaId.Location = new System.Drawing.Point(134, 110);
            this.lblMarcaId.Name = "lblMarcaId";
            this.lblMarcaId.Size = new System.Drawing.Size(56, 16);
            this.lblMarcaId.TabIndex = 45;
            this.lblMarcaId.Text = "idMarca";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Location = new System.Drawing.Point(211, 104);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.ReadOnly = true;
            this.txtCategoriaId.Size = new System.Drawing.Size(262, 22);
            this.txtCategoriaId.TabIndex = 44;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(284, 429);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 45);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(211, 294);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(462, 114);
            this.txtDetalles.TabIndex = 35;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(211, 200);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(262, 22);
            this.txtNombreMarca.TabIndex = 34;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblDetalles.Location = new System.Drawing.Point(134, 297);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(57, 16);
            this.lblDetalles.TabIndex = 32;
            this.lblDetalles.Text = "Detalles";
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNombreMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNombreMarca.Location = new System.Drawing.Point(73, 206);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(118, 16);
            this.lblNombreMarca.TabIndex = 31;
            this.lblNombreMarca.Text = "Nombre Categoria";
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarca";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblMarcaId;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblNombreMarca;
    }
}