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
            //Para mostrar los usuarios en el DataGridView
            string nombre = txtBuscarNombre.Text.Trim();

            //parsear el texto del campo de búsqueda de ID a un entero
            int id = 0;
            int.TryParse(txtBuscarId.Text.Trim(), out id);

            // Limpiar el DataGridView y establecer su fuente de datos
            dgvCargarUsuarios.DataSource = null;
            dgvCargarUsuarios.DataSource = Usuario.ObtenerUsuarios(nombre, id);
        }

            

            private void Limpiarcampos()
            {
            // Limpiar los campos de texto
            MessageBox.Show("Registro exitoso");
                txtNombre.Clear();
                txtApellido.Clear();
                txtNumeroTelefono.Clear();
                txtContrasenia.Clear();
                txtContacto.Clear();
            }
            
        

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos de texto no estén vacíos
            if ((string.IsNullOrEmpty(txtNumeroTelefono.Text))
            || (string.IsNullOrEmpty(txtNombre.Text)) || (string.IsNullOrEmpty(txtContrasenia.Text))
            || (string.IsNullOrEmpty(txtContrasenia.Text)))
            {
                // Mostrar un mensaje de advertencia si los campos están vacíos
                MessageBox.Show("Por favor ingrese los valores requeridos");
            }
            else {
                // Verificar el rol seleccionado y crear un nuevo usuario
                if (rbnAdministrador.Checked == true)
            {
                    // Crear un nuevo usuario con rol de administrador
                    Usuario doc = new Usuario();
                doc.Rol = 1;
                doc.Nombre = txtNombre.Text;
                doc.Apellido = txtApellido.Text;
                doc.NumeroTelefono = txtNumeroTelefono.Text;
                doc.Contacto = txtContacto.Text;
                doc.Contrasenia = txtContrasenia.Text;
                doc.InsertarUsuarios();
                MostrarUsuarios();
                Limpiarcampos();
            }

            else if (rbnEmpleado.Checked == true)
            {
                    // Crear un nuevo usuario con rol de empleado
                    Usuario doc = new Usuario();
                doc.Rol = 2;
                doc.Nombre = txtNombre.Text;
                doc.Apellido = txtApellido.Text;
                doc.NumeroTelefono = txtNumeroTelefono.Text;    
                doc.Contacto = txtContacto.Text;
                doc.Contrasenia = txtContrasenia.Text;
                doc.InsertarUsuarios();
                MostrarUsuarios();
                Limpiarcampos();
            }
            else
            {
                    // Mostrar un mensaje de advertencia si no se seleccionó un rol
                    MessageBox.Show("Seleccione un Rol de usuario");

            }
            }
        }

        private void gpPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void frmGestionarUsuarios_Load(object sender, EventArgs e)
        {
            // Cargar los usuarios al iniciar el formulario
            MostrarUsuarios();
        }

        private void txtBuscarId_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Llamar al método para mostrar los usuarios filtrados por ID
            MostrarUsuarios();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para mostrar los usuarios filtrados por nombre
            MostrarUsuarios();
        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para mostrar los usuarios filtrados por ID
            MostrarUsuarios();
        }
    }
}
