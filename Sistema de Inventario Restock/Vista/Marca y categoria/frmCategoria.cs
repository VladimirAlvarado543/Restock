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

namespace Vista.Marca_y_categoria
{
    public partial class frmCategoria: Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                
                MessageBox.Show("Debe llenar re.el campo de nomb", "ERROR");
                return;
            }

            Categoria categoria = new Categoria
            {
                NombreCategoria = txtNombreCategoria.Text,
                Detalles = txtDetalles.Text
            };
            if (categoria.InsertarCategoria())
            {
                MessageBox.Show("Categoría agregada correctamente", "Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la categoría.", "ERROR");
            }
        }
    }
}
