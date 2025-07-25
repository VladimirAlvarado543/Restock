using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Entidades;

namespace Vista.Stock_y_Productos
{
    public partial class frmVerProductos: Form
    {
        public frmVerProductos()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            //
            string nombre = txtBuscarNombre.Text.Trim();

            //parsear el texto del campo de búsqueda de ID a un entero
            int id = 0;
            int.TryParse(txtBuscarId.Text.Trim(), out id);

            // Limpiar el DataGridView y establecer su fuente de datos
            dgvVerProductos.DataSource = null;
            dgvVerProductos.DataSource = Producto.ObtenerProducto(nombre, id);
        }
        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            // Cargar los productos al iniciar el formulario
            MostrarProductos();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            /// Abrir el formulario para agregar un nuevo producto
            frmAgregarProductos agregarProductos = new frmAgregarProductos();
            agregarProductos.Show();
            this.Hide();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            // Llamar al método para mostrar los productos filtrados por nombre
            MostrarProductos();
        }

        private void txtBuscarid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Llamar al método para mostrar los productos filtrados por ID
            MostrarProductos();
        }
    }
}
