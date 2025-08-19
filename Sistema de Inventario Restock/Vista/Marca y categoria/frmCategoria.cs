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
                //  Mostrar un mensaje de error si el campo de nombre está vacío
                MessageBox.Show("Debe llenar el campo de nombre", "ERROR");
                return;
            }
            // Verificar si el campo de detalles está vacío
            Categoria categoria = new Categoria
            {
                // Asignar los valores de los campos a la entidad Categoria
                NombreCategoria = txtNombreCategoria.Text,
                Detalles = txtDetalles.Text
            };
            if (categoria.InsertarCategoria())
            {
                // Si la inserción es exitosa, mostrar un mensaje de éxito y cerrar el formulario
                MessageBox.Show("Categoría agregada correctamente", "Éxito");
                this.Close();
            }
            else
            {
                // Si la inserción falla, mostrar un mensaje de error
                MessageBox.Show("Error al agregar la categoría.", "ERROR");
            }
        }
    }
}
