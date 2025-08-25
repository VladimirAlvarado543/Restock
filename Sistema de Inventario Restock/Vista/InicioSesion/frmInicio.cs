using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Dahsboard;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vista.InicioSesion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void BTIniciasesion_Click(object sender, EventArgs e)
        {
            // Credenciales de ejemplo
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";

            // Obtener los valores ingresados
            string usuarioIngresado = TXBUsuario.Text.Trim();
            string contrasenaIngresada = TXBContrasenia.Text;

            if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada == contrasenaCorrecta)
            {
                // Abrir dashboard
                frmDahsboard nuevoFormulario = new frmDahsboard();
                nuevoFormulario.Show();

                // Ocultar formulario de inicio
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Redondear panel (ejemplo en PNLBienvendia)
        private void PNLBienvendia_Paint(object sender, PaintEventArgs e)
        {
            int radio = 170; // <-- Cambia este valor para ajustar el redondeo
            Panel panel = sender as Panel;

            if (panel != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
                path.AddLine(radio, 0, panel.Width - radio, 0);
                path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), -90, 90);
                path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
                path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
                path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);
                path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            }
        }
        private void LBBienvenido_Click(object sender, EventArgs e) { }
        private void TXBUsuario_TextChanged(object sender, EventArgs e) { }

        private void frmInicio_Load(object sender, EventArgs e) { }
    }
}
