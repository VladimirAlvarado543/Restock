using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Clientes;
using Vista.Proveedores;
using Vista.Stock_y_Productos;
using Vista.Usuarios;

namespace Vista.Dahsboard
{
    public partial class frmDahsboard : Form
    {
        public frmDahsboard()
        {
            InitializeComponent();
        }


        private Form ActivarForm = null;
        private void AbrirForm(Form formularioPintar)
        {
            if (ActivarForm != null)
            {
                ActivarForm.Close();
            }
            ActivarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerClientes());
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgregarClientes());
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgregarProveedor());
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionarUsuarios());
        }

        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerProductos());
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerProveedores());
        }
    }
}
