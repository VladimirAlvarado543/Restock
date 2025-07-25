using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Dahsboard;

namespace Vista.InicioSesion
{
    public partial class frmInicio: Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void BTIniciasesion_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";

            string usuarioIngresado = TXBUsuario.Text.Trim();
            string contrasenaIngresada = TXBContrasenia.Text;

            if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada == contrasenaCorrecta)
            {
                
                frmDahsboard nuevoFormulario = new frmDahsboard();
                frmInicio Cerrar = new frmInicio();
                this.Hide();
                nuevoFormulario.Show();
                

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
