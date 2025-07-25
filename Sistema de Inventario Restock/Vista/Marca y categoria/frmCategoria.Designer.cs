namespace Vista.Marca_y_categoria
{
    partial class frmCategoria
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
            this.lblCategoriaId = new System.Windows.Forms.Label();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.lblCategoriaId);
            this.pnlPrincipal.Controls.Add(this.txtCategoriaId);
            this.pnlPrincipal.Controls.Add(this.btnAgregar);
            this.pnlPrincipal.Controls.Add(this.txtDetalles);
            this.pnlPrincipal.Controls.Add(this.txtNombreCategoria);
            this.pnlPrincipal.Controls.Add(this.lblDetalles);
            this.pnlPrincipal.Controls.Add(this.lblNombreCategoria);
            this.pnlPrincipal.Location = new System.Drawing.Point(37, -57);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(699, 495);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // lblCategoriaId
            // 
            this.lblCategoriaId.AutoSize = true;
            this.lblCategoriaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCategoriaId.Location = new System.Drawing.Point(73, 110);
            this.lblCategoriaId.Name = "lblCategoriaId";
            this.lblCategoriaId.Size = new System.Drawing.Size(77, 16);
            this.lblCategoriaId.TabIndex = 45;
            this.lblCategoriaId.Text = "idCategoria";
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
            this.btnAgregar.Location = new System.Drawing.Point(313, 431);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(206, 45);
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
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(211, 200);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(262, 22);
            this.txtNombreCategoria.TabIndex = 34;
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
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblNombreCategoria.Location = new System.Drawing.Point(73, 206);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(118, 16);
            this.lblNombreCategoria.TabIndex = 31;
            this.lblNombreCategoria.Text = "Nombre Categoria";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label lblCategoriaId;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label lblNombreCategoria;
    }
}