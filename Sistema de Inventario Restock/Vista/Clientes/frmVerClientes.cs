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
    public partial class frmVerClientes : Form
    {

        public void MostrarClientes()
        {
            string nombreEmpresa = txtBuscarEmpresa.Text.Trim();
            string nombre = txtBuscarNombre.Text.Trim();

            int id = 0;
            int.TryParse(txtBuscarID.Text.Trim(), out id);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.ObtenerCliente(nombre,nombreEmpresa,id);
        }
        public frmVerClientes()
        {
            InitializeComponent();
            dgvClientes.DataSource = Cliente.ObtenerCliente("","",0);

        }
        private void frmVerClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
           frmAgregarClientes agregarClientes = new frmAgregarClientes();
            agregarClientes.Show();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                MostrarClientes();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        
        private void txtBuscarDetalles_TextChanged(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void txtBuscarID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MostrarClientes();
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            MostrarClientes();
        }
    }
}
