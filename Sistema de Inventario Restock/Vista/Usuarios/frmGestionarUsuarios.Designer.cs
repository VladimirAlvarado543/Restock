namespace Vista.Usuarios
{
    partial class frmGestionarUsuarios
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
            this.pnlPrincipal = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarId = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarId = new System.Windows.Forms.Label();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpRol = new System.Windows.Forms.GroupBox();
            this.rbnEmpleado = new System.Windows.Forms.RadioButton();
            this.rbnAdministrador = new System.Windows.Forms.RadioButton();
            this.dgvCargarUsuarios = new System.Windows.Forms.DataGridView();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.gpRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.txtBuscarNombre);
            this.pnlPrincipal.Controls.Add(this.txtBuscarId);
            this.pnlPrincipal.Controls.Add(this.lblBuscarId);
            this.pnlPrincipal.Controls.Add(this.lblBuscarNombre);
            this.pnlPrincipal.Controls.Add(this.btnAgregar);
            this.pnlPrincipal.Controls.Add(this.gpRol);
            this.pnlPrincipal.Controls.Add(this.dgvCargarUsuarios);
            this.pnlPrincipal.Controls.Add(this.txtContrasenia);
            this.pnlPrincipal.Controls.Add(this.lblContrasena);
            this.pnlPrincipal.Controls.Add(this.txtNumeroTelefono);
            this.pnlPrincipal.Controls.Add(this.lblContacto);
            this.pnlPrincipal.Controls.Add(this.lblNumeroTelefono);
            this.pnlPrincipal.Controls.Add(this.btnEliminar);
            this.pnlPrincipal.Controls.Add(this.txtContacto);
            this.pnlPrincipal.Controls.Add(this.txtApellido);
            this.pnlPrincipal.Controls.Add(this.txtNombre);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.lblApellido);
            this.pnlPrincipal.Controls.Add(this.lblNombre);
            this.pnlPrincipal.Location = new System.Drawing.Point(30, 31);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(999, 618);
            this.pnlPrincipal.TabIndex = 1;
            this.pnlPrincipal.TabStop = false;
            this.pnlPrincipal.Text = "Usuarios";
            this.pnlPrincipal.Enter += new System.EventHandler(this.gpPrincipal_Enter);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(230, 219);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(264, 22);
            this.txtBuscarNombre.TabIndex = 40;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(695, 216);
            this.txtBuscarId.Mask = "00000";
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarId.TabIndex = 39;
            this.txtBuscarId.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBuscarId_MaskInputRejected);
            this.txtBuscarId.TextChanged += new System.EventHandler(this.txtBuscarId_TextChanged);
            // 
            // lblBuscarId
            // 
            this.lblBuscarId.AutoSize = true;
            this.lblBuscarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarId.Location = new System.Drawing.Point(588, 222);
            this.lblBuscarId.Name = "lblBuscarId";
            this.lblBuscarId.Size = new System.Drawing.Size(101, 16);
            this.lblBuscarId.TabIndex = 38;
            this.lblBuscarId.Text = "Buscar por ID";
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.Location = new System.Drawing.Point(65, 222);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(141, 16);
            this.lblBuscarNombre.TabIndex = 37;
            this.lblBuscarNombre.Text = "Buscar por Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(678, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 45);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpRol
            // 
            this.gpRol.Controls.Add(this.rbnEmpleado);
            this.gpRol.Controls.Add(this.rbnAdministrador);
            this.gpRol.Location = new System.Drawing.Point(517, 35);
            this.gpRol.Name = "gpRol";
            this.gpRol.Size = new System.Drawing.Size(121, 98);
            this.gpRol.TabIndex = 29;
            this.gpRol.TabStop = false;
            this.gpRol.Text = "Rol";
            // 
            // rbnEmpleado
            // 
            this.rbnEmpleado.AutoSize = true;
            this.rbnEmpleado.Location = new System.Drawing.Point(2, 60);
            this.rbnEmpleado.Name = "rbnEmpleado";
            this.rbnEmpleado.Size = new System.Drawing.Size(91, 20);
            this.rbnEmpleado.TabIndex = 1;
            this.rbnEmpleado.TabStop = true;
            this.rbnEmpleado.Text = "Empleado";
            this.rbnEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbnAdministrador
            // 
            this.rbnAdministrador.AutoSize = true;
            this.rbnAdministrador.Location = new System.Drawing.Point(2, 21);
            this.rbnAdministrador.Name = "rbnAdministrador";
            this.rbnAdministrador.Size = new System.Drawing.Size(111, 20);
            this.rbnAdministrador.TabIndex = 0;
            this.rbnAdministrador.TabStop = true;
            this.rbnAdministrador.Text = "Administrador";
            this.rbnAdministrador.UseVisualStyleBackColor = true;
            // 
            // dgvCargarUsuarios
            // 
            this.dgvCargarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargarUsuarios.Location = new System.Drawing.Point(68, 288);
            this.dgvCargarUsuarios.Name = "dgvCargarUsuarios";
            this.dgvCargarUsuarios.RowHeadersWidth = 51;
            this.dgvCargarUsuarios.RowTemplate.Height = 24;
            this.dgvCargarUsuarios.Size = new System.Drawing.Size(803, 297);
            this.dgvCargarUsuarios.TabIndex = 28;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(219, 168);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(100, 22);
            this.txtContrasenia.TabIndex = 27;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(110, 174);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(90, 16);
            this.lblContrasena.TabIndex = 26;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(219, 107);
            this.txtNumeroTelefono.Mask = "(999)000-0000";
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(114, 22);
            this.txtNumeroTelefono.TabIndex = 24;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(135, 139);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(68, 16);
            this.lblContacto.TabIndex = 23;
            this.lblContacto.Text = "Contacto";
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTelefono.Location = new System.Drawing.Point(80, 107);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(123, 16);
            this.lblNumeroTelefono.TabIndex = 22;
            this.lblNumeroTelefono.Text = "NumeroTelefono";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(678, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 37);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(219, 136);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(262, 22);
            this.txtContacto.TabIndex = 12;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtContacto_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(219, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 22);
            this.txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 21;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(135, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 16);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // frmGestionarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1041, 676);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmGestionarUsuarios";
            this.Text = "frmGestionarUsuarios";
            this.Load += new System.EventHandler(this.frmGestionarUsuarios_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.gpRol.ResumeLayout(false);
            this.gpRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlPrincipal;
        private System.Windows.Forms.GroupBox gpRol;
        private System.Windows.Forms.RadioButton rbnEmpleado;
        private System.Windows.Forms.RadioButton rbnAdministrador;
        private System.Windows.Forms.DataGridView dgvCargarUsuarios;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.MaskedTextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.MaskedTextBox txtBuscarId;
        private System.Windows.Forms.Label lblBuscarId;
        private System.Windows.Forms.Label lblBuscarNombre;
    }
}