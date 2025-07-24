using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entidades;

namespace Vista.Usuarios
{
    public partial class frmGestionarUsuarios: Form
    {
        public frmGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios()
            {
            string nombre = txtBuscarNombre.Text.Trim();

            int id = 0;
            int.TryParse(txtBuscarId.Text.Trim(), out id);

            dgvCargarUsuarios.DataSource = null;
            dgvCargarUsuarios.DataSource = Usuario.ObtenerUsuarios(nombre, id);
        }

            

            private void Limpiarcampos()
            {
                MessageBox.Show("Registro exitoso");
                txtNombre.Clear();
                txtApellido.Clear();
                txtNumeroTelefono.Clear();
                txtContrasena.Clear();
                txtContacto.Clear();
            }
            
        

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbnAdministrador.Checked == true)
            {
                Usuario doc = new Usuario();
                doc.Rol = 1;
                doc.Nombre = txtNombre.Text;
                doc.Apellido = txtApellido.Text;
                doc.NumeroTelefono = txtNumeroTelefono.Text;
                doc.Contacto = txtContacto.Text;
                doc.Contrasenia = txtContrasena.Text;
                doc.InsertarUsuarios();
                MostrarUsuarios();
                Limpiarcampos();
            }

            else if (rbnEmpleado.Checked == true)
            {
                Usuario doc = new Usuario();
                doc.Rol = 2;
                doc.Nombre = txtNombre.Text;
                doc.Apellido = txtApellido.Text;
                doc.NumeroTelefono = txtNumeroTelefono.Text;    
                doc.Contacto = txtContacto.Text;
                doc.Contrasenia = txtContrasena.Text;
                doc.InsertarUsuarios();
                MostrarUsuarios();
                Limpiarcampos();
            }
            else
            {
                MessageBox.Show("Seleccione un Rol de usuario");

            }
        }

        private void gpPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestionarUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtBuscarId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
           // MostrarUsuarios();
        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
    }
}
