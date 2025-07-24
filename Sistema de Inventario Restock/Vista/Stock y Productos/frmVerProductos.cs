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
            string nombre = txtBuscarNombre.Text.Trim();

            int id = 0;
            int.TryParse(txtBuscarId.Text.Trim(), out id);

            dgvVerProductos.DataSource = null;
            dgvVerProductos.DataSource = Producto.ObtenerProducto(nombre, id);
        }
        private void frmVerProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmAgregarProductos agregarProductos = new frmAgregarProductos();
            agregarProductos.Show();
            this.Hide();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void txtBuscarid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MostrarProductos();
        }
    }
}
