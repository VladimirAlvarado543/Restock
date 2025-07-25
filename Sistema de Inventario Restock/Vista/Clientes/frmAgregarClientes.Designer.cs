namespace Vista.Clientes
{
    partial class frmAgregarClientes
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mtxtNumeroTelefono = new System.Windows.Forms.MaskedTextBox();
            this.pnlNumeroTelefono = new System.Windows.Forms.Panel();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.pnlDireccion = new System.Windows.Forms.Panel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pnlCorreoElectronico = new System.Windows.Forms.Panel();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.pnlContacto = new System.Windows.Forms.Panel();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.pnlDocumentoID = new System.Windows.Forms.Panel();
            this.lblDocumentoID = new System.Windows.Forms.Label();
            this.txtDocumentoID = new System.Windows.Forms.TextBox();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlNombreEmpresa = new System.Windows.Forms.Panel();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.pnlClienteID = new System.Windows.Forms.Panel();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlNumeroTelefono.SuspendLayout();
            this.pnlDireccion.SuspendLayout();
            this.pnlCorreoElectronico.SuspendLayout();
            this.pnlContacto.SuspendLayout();
            this.pnlDocumentoID.SuspendLayout();
            this.pnlDetalles.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.pnlNombreEmpresa.SuspendLayout();
            this.pnlClienteID.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.mtxtNumeroTelefono);
            this.panel1.Controls.Add(this.pnlNumeroTelefono);
            this.panel1.Controls.Add(this.pnlDireccion);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.pnlCorreoElectronico);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.pnlContacto);
            this.panel1.Controls.Add(this.txtContacto);
            this.panel1.Controls.Add(this.pnlDocumentoID);
            this.panel1.Controls.Add(this.txtDocumentoID);
            this.panel1.Controls.Add(this.pnlDetalles);
            this.panel1.Controls.Add(this.txtDetalles);
            this.panel1.Controls.Add(this.pnlNombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.pnlNombreEmpresa);
            this.panel1.Controls.Add(this.txtNombreEmpresa);
            this.panel1.Controls.Add(this.pnlClienteID);
            this.panel1.Controls.Add(this.txtClienteID);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 561);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(629, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(267, 106);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mtxtNumeroTelefono
            // 
            this.mtxtNumeroTelefono.Location = new System.Drawing.Point(757, 275);
            this.mtxtNumeroTelefono.Mask = "0000-0000";
            this.mtxtNumeroTelefono.Name = "mtxtNumeroTelefono";
            this.mtxtNumeroTelefono.Size = new System.Drawing.Size(106, 22);
            this.mtxtNumeroTelefono.TabIndex = 43;
            // 
            // pnlNumeroTelefono
            // 
            this.pnlNumeroTelefono.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlNumeroTelefono.Controls.Add(this.lblNumeroTelefono);
            this.pnlNumeroTelefono.Location = new System.Drawing.Point(558, 259);
            this.pnlNumeroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNumeroTelefono.Name = "pnlNumeroTelefono";
            this.pnlNumeroTelefono.Size = new System.Drawing.Size(192, 55);
            this.pnlNumeroTelefono.TabIndex = 42;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(4, 16);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(186, 24);
            this.lblNumeroTelefono.TabIndex = 1;
            this.lblNumeroTelefono.Text = "Numero de Telefono";
            // 
            // pnlDireccion
            // 
            this.pnlDireccion.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlDireccion.Controls.Add(this.lblDireccion);
            this.pnlDireccion.Location = new System.Drawing.Point(553, 177);
            this.pnlDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDireccion.Name = "pnlDireccion";
            this.pnlDireccion.Size = new System.Drawing.Size(141, 55);
            this.pnlDireccion.TabIndex = 41;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(23, 17);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 24);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(702, 177);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(284, 55);
            this.txtDireccion.TabIndex = 40;
            // 
            // pnlCorreoElectronico
            // 
            this.pnlCorreoElectronico.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlCorreoElectronico.Controls.Add(this.lblCorreoElectronico);
            this.pnlCorreoElectronico.Location = new System.Drawing.Point(553, 92);
            this.pnlCorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCorreoElectronico.Name = "pnlCorreoElectronico";
            this.pnlCorreoElectronico.Size = new System.Drawing.Size(172, 55);
            this.pnlCorreoElectronico.TabIndex = 39;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(1, 17);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(168, 24);
            this.lblCorreoElectronico.TabIndex = 1;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(733, 102);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElectronico.Multiline = true;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(245, 31);
            this.txtCorreoElectronico.TabIndex = 38;
            // 
            // pnlContacto
            // 
            this.pnlContacto.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlContacto.Controls.Add(this.lblContacto);
            this.pnlContacto.Location = new System.Drawing.Point(558, 21);
            this.pnlContacto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContacto.Name = "pnlContacto";
            this.pnlContacto.Size = new System.Drawing.Size(108, 55);
            this.pnlContacto.TabIndex = 37;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.BackColor = System.Drawing.Color.Transparent;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(9, 16);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(84, 24);
            this.lblContacto.TabIndex = 1;
            this.lblContacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(680, 32);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtContacto.Multiline = true;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(306, 31);
            this.txtContacto.TabIndex = 36;
            // 
            // pnlDocumentoID
            // 
            this.pnlDocumentoID.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlDocumentoID.Controls.Add(this.lblDocumentoID);
            this.pnlDocumentoID.Location = new System.Drawing.Point(22, 364);
            this.pnlDocumentoID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDocumentoID.Name = "pnlDocumentoID";
            this.pnlDocumentoID.Size = new System.Drawing.Size(133, 55);
            this.pnlDocumentoID.TabIndex = 35;
            // 
            // lblDocumentoID
            // 
            this.lblDocumentoID.AutoSize = true;
            this.lblDocumentoID.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoID.Location = new System.Drawing.Point(3, 17);
            this.lblDocumentoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentoID.Name = "lblDocumentoID";
            this.lblDocumentoID.Size = new System.Drawing.Size(130, 24);
            this.lblDocumentoID.TabIndex = 1;
            this.lblDocumentoID.Text = "ID Documento";
            // 
            // txtDocumentoID
            // 
            this.txtDocumentoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoID.Location = new System.Drawing.Point(163, 381);
            this.txtDocumentoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoID.Multiline = true;
            this.txtDocumentoID.Name = "txtDocumentoID";
            this.txtDocumentoID.Size = new System.Drawing.Size(382, 31);
            this.txtDocumentoID.TabIndex = 34;
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlDetalles.Controls.Add(this.lblDetalles);
            this.pnlDetalles.Location = new System.Drawing.Point(22, 259);
            this.pnlDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(108, 55);
            this.pnlDetalles.TabIndex = 33;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(17, 16);
            this.lblDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(76, 24);
            this.lblDetalles.TabIndex = 1;
            this.lblDetalles.Text = "Detalles";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.Location = new System.Drawing.Point(138, 259);
            this.txtDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(407, 75);
            this.txtDetalles.TabIndex = 32;
            // 
            // pnlNombre
            // 
            this.pnlNombre.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlNombre.Controls.Add(this.lblNombre);
            this.pnlNombre.Location = new System.Drawing.Point(22, 92);
            this.pnlNombre.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Size = new System.Drawing.Size(108, 55);
            this.pnlNombre.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 17);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(138, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(407, 31);
            this.txtNombre.TabIndex = 30;
            // 
            // pnlNombreEmpresa
            // 
            this.pnlNombreEmpresa.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlNombreEmpresa.Controls.Add(this.lblNombreEmpresa);
            this.pnlNombreEmpresa.Location = new System.Drawing.Point(22, 177);
            this.pnlNombreEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNombreEmpresa.Name = "pnlNombreEmpresa";
            this.pnlNombreEmpresa.Size = new System.Drawing.Size(189, 55);
            this.pnlNombreEmpresa.TabIndex = 29;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(1, 14);
            this.lblNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(187, 24);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "Nombre de Empresa";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(219, 191);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpresa.Multiline = true;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(327, 31);
            this.txtNombreEmpresa.TabIndex = 28;
            // 
            // pnlClienteID
            // 
            this.pnlClienteID.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlClienteID.Controls.Add(this.lblClienteID);
            this.pnlClienteID.Location = new System.Drawing.Point(22, 21);
            this.pnlClienteID.Margin = new System.Windows.Forms.Padding(4);
            this.pnlClienteID.Name = "pnlClienteID";
            this.pnlClienteID.Size = new System.Drawing.Size(108, 55);
            this.pnlClienteID.TabIndex = 27;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(10, 16);
            this.lblClienteID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(90, 24);
            this.lblClienteID.TabIndex = 1;
            this.lblClienteID.Text = "ID Cliente";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.Location = new System.Drawing.Point(138, 32);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteID.Multiline = true;
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.ReadOnly = true;
            this.txtClienteID.Size = new System.Drawing.Size(407, 31);
            this.txtClienteID.TabIndex = 26;
            // 
            // frmAgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1041, 585);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmAgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNumeroTelefono.ResumeLayout(false);
            this.pnlNumeroTelefono.PerformLayout();
            this.pnlDireccion.ResumeLayout(false);
            this.pnlDireccion.PerformLayout();
            this.pnlCorreoElectronico.ResumeLayout(false);
            this.pnlCorreoElectronico.PerformLayout();
            this.pnlContacto.ResumeLayout(false);
            this.pnlContacto.PerformLayout();
            this.pnlDocumentoID.ResumeLayout(false);
            this.pnlDocumentoID.PerformLayout();
            this.pnlDetalles.ResumeLayout(false);
            this.pnlDetalles.PerformLayout();
            this.pnlNombre.ResumeLayout(false);
            this.pnlNombre.PerformLayout();
            this.pnlNombreEmpresa.ResumeLayout(false);
            this.pnlNombreEmpresa.PerformLayout();
            this.pnlClienteID.ResumeLayout(false);
            this.pnlClienteID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.MaskedTextBox mtxtNumeroTelefono;
        private System.Windows.Forms.Panel pnlNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Panel pnlDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel pnlCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Panel pnlContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Panel pnlDocumentoID;
        private System.Windows.Forms.Label lblDocumentoID;
        private System.Windows.Forms.TextBox txtDocumentoID;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Panel pnlClienteID;
        private System.Windows.Forms.Label lblClienteID;
    }
}