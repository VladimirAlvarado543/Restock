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
using Vista.Marca_y_categoria;
using Vista.Proveedores;
using Vista.Usuarios;

namespace Vista.Dahsboard
{
    public partial class frmDahsboard : Form
    {
        // Variables para controlar el estado de los submenús y la barra lateral

        bool siderbarExpand;          // Para la barra lateral
        bool siderbarCollapse;        // Para el submenu de clientes
        bool inventarioExpand;        // Para el submenu de inventario
        bool proveedoresCollapse;     // Para el submenu de proveedores
        bool gestionCollapse;         // Para el submenu de gestion

        // Variable para rastrear el formulario activo
        private Form formularioActivo = null;

        //Para que los frm anexos se abran en el panel principal
        private void AbrirForm(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Con formulario Principal se refiere al panel donde se van a abrir los formularios, osea, el boton "clientes" es el
            // principal
            PNLMenuPrincipal.Controls.Add(formularioHijo);
            PNLMenuPrincipal.Tag = formularioHijo;

            //Con formulario hijo se refiere al formulario que se va a abrir dentro del panel
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        //Inicia el ajuste del tamaño del panel principal
        private void AjustarTamañoPanelPrincipal()
        {
            // Ajustar el tamaño del panel principal según el ancho del sidebar
            PNLMenuPrincipal.Width = this.ClientSize.Width - FLPBarraLateral.Width;
            PNLMenuPrincipal.Height = this.ClientSize.Height;
            PNLMenuPrincipal.Location = new Point(FLPBarraLateral.Width, 0);
        }

        private void frmDahsboard_Resize(object sender, EventArgs e)
        {
            AjustarTamañoPanelPrincipal();
        }

        public frmDahsboard()
        {
            InitializeComponent();
            this.Resize += frmDahsboard_Resize;
        }

        private void frmDahsboard_Load(object sender, EventArgs e)
        {
            AjustarTamañoPanelPrincipal();
        }
        private void PBMenuboton_MouseClick(object sender, MouseEventArgs e) { }
        private void FLPBarraLateral_Paint(object sender, PaintEventArgs e) { }
        private void PNLTresRayitasImagen_Paint(object sender, PaintEventArgs e) { }

        private void FLPBarraLateral_Click(object sender, EventArgs e) { }

        private void TMRBarraLateral_Tick(object sender, EventArgs e)
        {
            // Ajustar el tamaño del panel principal cada vez que se actualiza el tamaño del sidebar
            AjustarTamañoPanelPrincipal();

            //Poner el minimo y maximo del FYO de la barra lateral

            if (siderbarExpand)
            {
                //Si el sidebar esta expandido, minimizarlo
                FLPBarraLateral.Width -= 10;
                if (FLPBarraLateral.Width == FLPBarraLateral.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    TMRBarraLateral.Stop();
                }
            }
            else
            {
                FLPBarraLateral.Width += 10;
                if (FLPBarraLateral.Width == FLPBarraLateral.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    TMRBarraLateral.Stop();
                }
            }
        }

        //Empieza, Animacion del sidebar (tres lineas)
        private void PBMenuboton_Click(object sender, EventArgs e)
        {
            //Poner tmer para la animacion del sidebar
            TMRBarraLateral.Start();
        }

        //Termina ancion del sidebar (tres lineas)

        //Empieza

        private void TMRSubMenus_Tick(object sender, EventArgs e)
        {
            // Asumiendo que tienes un control para el submenú, por ejemplo un Panel llamado pnlSubMenu
            // Debes reemplazar 'siderbarCollapse' por el control real que quieres animar
            if (siderbarCollapse)
            {
                PNLClientesAnexo.Height += 10;
                if (PNLClientesAnexo.Height == PNLClientesAnexo.MaximumSize.Height)
                {
                    siderbarCollapse = false;
                    TMRSubMenus.Stop();
                }
            }
            else
            {
                PNLClientesAnexo.Height -= 10;
                if (PNLClientesAnexo.Height == PNLClientesAnexo.MinimumSize.Height)
                {
                    siderbarCollapse = true;
                    TMRSubMenus.Stop();
                }
            }
        }

        private void BTNClientes_Click(object sender, EventArgs e)
        {
            //Poner tmer para la animacion del sidebar
            TMRSubMenus.Start();
        }

        //Termina


        private void TMRInventario_Tick(object sender, EventArgs e)
        {
            if (inventarioExpand)
            {
                PNLExcInventario.Height += 10;
                if (PNLExcInventario.Height == PNLExcInventario.MaximumSize.Height)
                {
                    inventarioExpand = false;
                    TMRInventario.Stop();
                }
            }
            else
            {
                PNLExcInventario.Height -= 10;
                if (PNLExcInventario.Height == PNLExcInventario.MinimumSize.Height)
                {
                    inventarioExpand = true;
                    TMRInventario.Stop();
                }
            }
        }
        private void BTNInventario_Click(object sender, EventArgs e)
        {
            TMRInventario.Start();
        }

        private void TMRProveedor_Tick(object sender, EventArgs e)
        {
            if (proveedoresCollapse)
            {
                PNLExcProveedoores.Height += 10;
                if (PNLExcProveedoores.Height == PNLExcProveedoores.MaximumSize.Height)
                {
                    proveedoresCollapse = false;
                    TMRProveedor.Stop();
                }
            }
            else
            {
                PNLExcProveedoores.Height -= 10;
                if (PNLExcProveedoores.Height == PNLExcProveedoores.MinimumSize.Height)
                {
                    proveedoresCollapse = true;
                    TMRProveedor.Stop();
                }
            }
        }

        private void BTNProovedores_Click(object sender, EventArgs e)
        {
            TMRProveedor.Start();
        }

        private void TMRGestion_Tick(object sender, EventArgs e)
        {
            if (gestionCollapse)
            {
                PNLExcGestionar.Height += 10;
                if (PNLExcGestionar.Height == PNLExcGestionar.MaximumSize.Height)
                {
                    gestionCollapse = false;
                    TMRGestion.Stop();
                }
            }
            else
            {
                PNLExcGestionar.Height -= 10;
                if (PNLExcGestionar.Height == PNLExcGestionar.MinimumSize.Height)
                {
                    gestionCollapse = true;
                    TMRGestion.Stop();
                }
            }
        }

        private void BTNGestionar_Click(object sender, EventArgs e)
        {
            TMRGestion.Start();
        }

        private void BTNGestionarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmGestionarUsuarios());
        }

        private void BTNGestionarCategoriasyMarcas_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmMarcaCategoria());
        }

        private void BTNAgregarProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgregarProveedor());
        }

        private void BTNVerProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerProveedores());
        }

        private void BTNVesStock_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerProveedores());
        }

        private void BTNAgregarInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgregarProveedor());
        }

        private void BTNAgregarClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmAgregarClientes());
        }

        private void BTNVerClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerClientes());
        }

        private void BTNDashboard_Click(object sender, EventArgs e)
        {
            PNLMenuPrincipal.Controls.Clear();
        }
    }
}
