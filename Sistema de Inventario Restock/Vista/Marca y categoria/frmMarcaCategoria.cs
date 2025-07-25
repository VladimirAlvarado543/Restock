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
using Vista.Clientes;

namespace Vista.Marca_y_categoria
{
    public partial class frmMarcaCategoria: Form
    {
        public frmMarcaCategoria()
        {
            InitializeComponent();
        }

        public void MostrarCategoria()
        {
            // limpiar el DataGridView antes de asignar una nueva fuente de datos
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = Categoria.VerCategoria();
        }

        public void MostrarMarca()
        {
            // limpiar el DataGridView antes de asignar una nueva fuente de datos
            dgvVerMarca.DataSource = null;
            dgvVerMarca.DataSource = Marca.VerMarca();
        }   

        private void frmMarcaCategoria_Load(object sender, EventArgs e)
        {
            // Cargar los datos de las categorías y marcas al iniciar el formulario
            MostrarCategoria();
            MostrarMarca(); 
        }

        private void pnlMarcaCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y abrir el formulario de agregar categoría
            frmMarcaCategoria frm = new frmMarcaCategoria();
            this.Close();
            frmCategoria agregarCategoria = new frmCategoria();
            agregarCategoria.Show();
            
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual y abrir el formulario de agregar marca
            frmMarcaCategoria frm = new frmMarcaCategoria();
            this.Close();
            frmMarca agregarCategoria = new frmMarca();
            agregarCategoria.Show();
            
        }
    }
}
