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
    public partial class frmMarca: Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMarca.Text) || string.IsNullOrEmpty(txtDetalles.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "ERROR");
                return;
            }
            Marca marca = new Marca
            {
                NombreMarca = txtNombreMarca.Text,
                Detalles = txtDetalles.Text
            };
            if (marca.InsertarMarca())
            {
                MessageBox.Show("Marca agregada correctamente", "Éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la marca.", "ERROR");
            }
        }
    }
}
