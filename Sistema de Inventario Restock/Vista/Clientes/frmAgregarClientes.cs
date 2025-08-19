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

namespace Vista.Clientes
{
    public partial class 
        frmAgregarClientes: Form
    {
        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Crear condiciones para que se llenen los datos necesarios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) ||
string.IsNullOrWhiteSpace(txtDetalles.Text) || string.IsNullOrWhiteSpace(txtDocumentoID.Text) ||
string.IsNullOrWhiteSpace(txtContacto.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(mtxtNumeroTelefono.Text))
            {
                //Mensaje en caso que no se llenen todos los campos
                MessageBox.Show("Debe llenar todos los campos.", "ERROR");
                return;
            }

            //Darle propiedades mask format a un textbox
            //se hizo para buscar una forma mas limpia de realizar búsquedas
            mtxtNumeroTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //si no se parsea correctamente el numero telefono dara un error
            if (!int.TryParse(mtxtNumeroTelefono.Text, out int numeroTelefono))
            {
                MessageBox.Show("El número de teléfono no es válido.", "ERROR");
                mtxtNumeroTelefono.Clear();
                return;
            }

            //Enviar los valores a la clase
            Cliente clientes = new  Cliente
            {
                // Valores
                Nombre = txtNombre.Text,
                NombreEmpresa = txtNombreEmpresa.Text,
                Detalles = txtDetalles.Text,
                IdDocumento = txtDocumentoID.Text,
                Contacto = txtContacto.Text,
                CorreoElectronico = txtCorreoElectronico.Text,
                Direccion = txtDireccion.Text,
                NumeroTelefono = numeroTelefono
            };
            // Intentar insertar el cliente en la base de datos
            if (clientes.InsertarClientes())
            {
                // Si la inserción es exitosa, mostrar un mensaje de éxito y actualizar la lista de clientes
                MessageBox.Show("Cliente agregado correctamente", "Éxito");
                LimpiarCampos();
                this.Close();
            }
            else
            {
                // Si la inserción falla, mostrar un mensaje de error
                MessageBox.Show("No se pudo agregar el cliente", "ERROR");
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar todos los campos del formulario
            txtClienteID.Clear();
            txtNombre.Clear();
            txtNombreEmpresa.Clear();
            txtDetalles.Clear();
            txtDocumentoID.Clear();
            txtContacto.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            mtxtNumeroTelefono.Clear();

        }

        private frmVerClientes formularioPrincipal;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtxtNumeroTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
