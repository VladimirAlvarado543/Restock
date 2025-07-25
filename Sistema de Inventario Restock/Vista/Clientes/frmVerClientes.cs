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
            // Limpiar el DataGridView antes de mostrar los resultados
            string nombreEmpresa = txtBuscarEmpresa.Text.Trim();
            string nombre = txtBuscarNombre.Text.Trim();

            int id = 0;
            int.TryParse(txtBuscarID.Text.Trim(), out id);

            // Actualizar el DataGridView con los clientes filtrados
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.ObtenerCliente(nombre,nombreEmpresa,id);
        }
        public frmVerClientes()
        {
            // Inicializar el formulario
            InitializeComponent();
            // Configurar el DataGridView para que no permita la edición de celdas
            dgvClientes.DataSource = Cliente.ObtenerCliente("","",0);

        }
        private void frmVerClientes_Load(object sender, EventArgs e)
        {
            // Cargar los clientes al iniciar el formulario
            MostrarClientes();
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para agregar nuevos clientes
            frmAgregarClientes agregarClientes = new frmAgregarClientes();
            agregarClientes.Show();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se ha hecho clic en una celda de tipo botón
            MostrarClientes();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            // Actualizar la lista de clientes al cambiar el texto del campo de búsqueda
            MostrarClientes();
        }
        
        private void txtBuscarDetalles_TextChanged(object sender, EventArgs e)
        {
            // Actualizar la lista de clientes al cambiar el texto del campo de búsqueda
            MostrarClientes();
        }

        private void txtBuscarID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Actualizar la lista de clientes al cambiar el texto del campo de búsqueda
            MostrarClientes();
        }

        private void txtBuscarID_TextChanged(object sender, EventArgs e)
        {
            // Actualizar la lista de clientes al cambiar el texto del campo de búsqueda
            MostrarClientes();
        }
    }
}
