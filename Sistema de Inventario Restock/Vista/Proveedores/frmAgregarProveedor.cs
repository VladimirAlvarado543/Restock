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
            // Limpiar todos los campos de texto
            txtNombre.Clear();
            txtNombreEmpresa.Clear();
            txtDetalles.Clear();
            txtProductos.Clear();
            txtIDDocumento.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();
            txtNumeroTelefono.Clear();
            txtPaginaWeb.Clear();
            txtContacto1.Clear();
            txtContacto2.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
     string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
            {
                // // Si alguno de los campos de texto está vacío, mostrar un mensaje de advertencia
                MessageBox.Show("Por favor, completa todos los campos de texto antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que los campos de texto no estén vacíos
            Proveedor p = new Proveedor();
            p.Nombre1 = txtNombre.Text;
            p.Nombreempresa = txtNombreEmpresa.Text;
            p.Detalles = txtDetalles.Text;
            p.Productos1 = txtProductos.Text;
            p.IDDocumento1 = txtIDDocumento.Text;
            p.CorreoElectronico1 = txtCorreoElectronico.Text;
            p.Direccion1 = txtDireccion.Text;
            p.NumeroTelefono1 = txtNumeroTelefono.Text;
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
                // Si ocurre un error al insertar el proveedor, mostrar un mensaje de error
                MessageBox.Show("Error al agregar proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Limpiar todos los campos después de guardar
            LimpiarTodosCampos();
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void gpProvedores_Enter(object sender, EventArgs e)
        {

        }
    }
}
