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
            // Validar las credenciales de inicio de sesión
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "1234";

            // Obtener los valores ingresados por el usuario
            string usuarioIngresado = TXBUsuario.Text.Trim();
            string contrasenaIngresada = TXBContrasenia.Text;

            if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada == contrasenaCorrecta)
            {
                //Si las credenciales son correctas, abrir el formulario del dashboard y ocultar el formulario de inicio de sesión
               frmDahsboard nuevoFormulario = new frmDahsboard();
                // Crear una instancia del formulario de inicio y ocultarlo
                frmInicio Cerrar = new frmInicio();
                // Cerrar
                Cerrar.Close();
                // Mostrar el nuevo formulario del dashboard
                nuevoFormulario.Show();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PNIniciosesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void LBBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
