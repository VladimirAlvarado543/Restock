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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombreEmpresa.Text) ||
string.IsNullOrWhiteSpace(txtDetalles.Text) || string.IsNullOrWhiteSpace(txtDocumentoID.Text) ||
string.IsNullOrWhiteSpace(txtContacto.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(mtxtNumeroTelefono.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "ERROR");
                return;
            }

            mtxtNumeroTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!int.TryParse(mtxtNumeroTelefono.Text, out int numeroTelefono))
            {
                MessageBox.Show("El número de teléfono no es válido.", "ERROR");
                mtxtNumeroTelefono.Clear();
                return;
            }

            Cliente clientes = new  Cliente
            {
                Nombre = txtNombre.Text,
                NombreEmpresa = txtNombreEmpresa.Text,
                Detalles = txtDetalles.Text,
                IdDocumento = txtDocumentoID.Text,
                Contacto = txtContacto.Text,
                CorreoElectronico = txtCorreoElectronico.Text,
                Direccion = txtDireccion.Text,
                NumeroTelefono = numeroTelefono
            };
            if (clientes.InsertarClientes())
            {
                MessageBox.Show("Cliente agregado correctamente", "Éxito");
                formularioPrincipal.MostrarClientes();
                formularioPrincipal.Show();
                LimpiarCampos();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cliente", "ERROR");
            }
        }
        private void LimpiarCampos()
        {
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

        public frmAgregarClientes(frmVerClientes principal)
        {
            InitializeComponent();
            formularioPrincipal = principal;
        }
    }
}
