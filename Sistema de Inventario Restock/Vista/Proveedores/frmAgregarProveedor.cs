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

namespace Vista.Proveedores
{
    public partial class frmAgregarProveedor: Form
    {
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void LimpiarTodosCampos()
        {
            txtNombre.Clear();
            txtNombreEmpresa.Clear();
            txtDetalles.Clear();
            txtProductos.Clear();
            txtIDDocumento.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            txtWhatsApp.Clear();
            txtPaginaWeb.Clear();
            txtContacto1.Clear();
            txtContacto2.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
     string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos de texto antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Proveedor p = new Proveedor();
            p.Nombre1 = txtNombre.Text;
            p.Nombreempresa = txtNombreEmpresa.Text;
            p.Detalles = txtDetalles.Text;
            p.Productos1 = txtProductos.Text;
            p.IDDocumento1 = txtIDDocumento.Text;
            p.CorreoElectronico1 = txtCorreoElectronico.Text;
            p.Direccion1 = txtDireccion.Text;
            p.WhatsApp1 = txtWhatsApp.Text;
            p.PaginaWeb1 = txtPaginaWeb.Text;
            p.Contacto11 = txtContacto1.Text;
            p.Contacto21 = txtContacto2.Text;

            if (p.InsertarProveedor())
            {
                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MostrarProveedor();
            }
            else
            {
                MessageBox.Show("Error al agregar proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
