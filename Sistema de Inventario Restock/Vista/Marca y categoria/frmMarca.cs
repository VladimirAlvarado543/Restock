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
            if (string.IsNullOrEmpty(txtNombreMarca.Text))
            {
                //En caso no se llene el capo nesesario
                MessageBox.Show("Debe llenar el campo de nombre", "ERROR");
                return;
            }
            Marca marca = new Marca
            {
                //Asignar Valores
                NombreMarca = txtNombreMarca.Text,
                Detalles = txtDetalles.Text
            };
            if (marca.InsertarMarca())
            {
                //mensake de exito
                MessageBox.Show("Marca agregada correctamente", "Éxito");
                this.Close();
            }
            else
            {
                //en caso algo falle
                MessageBox.Show("Error al agregar la marca.", "ERROR");
            }
        }
    }
}
