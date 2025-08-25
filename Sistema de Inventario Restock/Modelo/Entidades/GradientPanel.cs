using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;
using System.Windows.Forms;

namespace Modelo.Entidades
{
    internal class GradientPanel : Panel
    {
        public System.Drawing.Color ColorTop { get; set; } = Color.FromArgb(30, 60, 114);   // Azul oscuro elegante
        public System.Drawing.Color ColorBottom { get; set; } = Color.FromArgb(42, 82, 152); // Azul más brillante

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }
        }
    }
}

