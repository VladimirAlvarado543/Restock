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

            string nombre = txtBuscarNombre.Text.Trim();

            int id = 0;
            int.TryParse(txtBuscarid.Text.Trim(), out id);

            dgvVerProveedores.DataSource = null;
            dgvVerProveedores.DataSource = Proveedor.ObtenerProveedor(nombre, id);
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor agregarProveedor = new frmAgregarProveedor();
            agregarProveedor.Show();
            this.Hide();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void txtBuscarid_TextChanged(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void frmVerProveedores_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
