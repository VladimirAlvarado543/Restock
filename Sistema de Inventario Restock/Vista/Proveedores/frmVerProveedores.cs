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
using Vista.Stock_y_Productos;

namespace Vista.Proveedores
{
    public partial class frmVerProveedores: Form
    {
        public frmVerProveedores()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            // Obtener los valores de los campos de búsqueda
            string nombre = txtBuscarNombre.Text.Trim();

            // Intentar convertir el texto del campo de búsqueda de ID a un entero
            int id = 0;
            int.TryParse(txtBuscarid.Text.Trim(), out id);

            // Limpiar el DataGridView y establecer su fuente de datos
            dgvVerProveedores.DataSource = null;
            dgvVerProveedores.DataSource = Proveedor.ObtenerProveedor(nombre, id);
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para agregar un nuevo proveedor
            frmAgregarProveedor agregarProveedor = new frmAgregarProveedor();
            agregarProveedor.Show();
            this.Hide();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para mostrar los productos filtrados por nombre
            MostrarProductos();
        }

        private void txtBuscarid_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para mostrar los productos filtrados por ID
            MostrarProductos();
        }

        private void frmVerProveedores_Load(object sender, EventArgs e)
        {
            // Cargar los proveedores al iniciar el formulario
            MostrarProductos();
        }
    }
}
