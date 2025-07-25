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

namespace Vista.Stock_y_Productos
{
    public partial class frmAgregarProductos: Form
    {
        public frmAgregarProductos()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            dtmFechaPorducto.Value = DateTime.Now;
            txtProveedor.Clear();
            txtDetalles.Clear();
            txtPrecioCompra.Clear();
            txtMarca.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (
    string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
    string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
    string.IsNullOrWhiteSpace(dtmFechaPorducto.Text) ||
    string.IsNullOrWhiteSpace(txtProveedor.Text) ||
    nupExistencias.Value < 0
)
            {
                MessageBox.Show("Debe llenar todos los campos principales", "ERROR");
                return;
            }
            else
            {
                Producto doc = new Producto();
                doc.NombreProducto = txtNombreProducto.Text;
                doc.IdCategoria = Convert.ToInt32(nupExistencias.Value);
                doc.IdMarca = Convert.ToInt32(txtMarca.Text);
                doc.Detalles = txtDetalles.Text;
                doc.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                doc.PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text);
                doc.IdProveedor = Convert.ToInt32(txtProveedor.Text);
                doc.FechaIngreso = DateTime.Now;
                doc.Existencia = Convert.ToInt32(nupExistencias.Value);
                doc.InsertarProductos();
                LimpiarCampos();
                MessageBox.Show("Producto agregado correctamente", "Éxito");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {
        }
    }
}

