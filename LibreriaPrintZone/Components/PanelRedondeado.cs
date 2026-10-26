
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibreriaPrintZone.Components
{
    public static class PanelRedondeado
    {
        public static void Aplicar(Panel panel, int radio = 20)
        {
            if (panel == null)
                throw new ArgumentNullException(nameof(panel));

            if (radio < 1)
                throw new ArgumentOutOfRangeException(nameof(radio));

            void ActualizarRegion(object? sender, EventArgs e)
            {
                if (panel.Width <= 0 || panel.Height <= 0)
                    return;

                int diametro = Math.Min(
                    radio * 2,
                    Math.Min(panel.Width, panel.Height));

                Rectangle rectangulo = new Rectangle(
                    0, 0, panel.Width, panel.Height);

                using (GraphicsPath ruta = new GraphicsPath())
                {
                    ruta.AddArc(
                        rectangulo.X, rectangulo.Y,
                        diametro, diametro, 180, 90);

                    ruta.AddArc(
                        rectangulo.Right - diametro,
                        rectangulo.Y,
                        diametro, diametro, 270, 90);

                    ruta.AddArc(
                        rectangulo.Right - diametro,
                        rectangulo.Bottom - diametro,
                        diametro, diametro, 0, 90);

                    ruta.AddArc(
                        rectangulo.X,
                        rectangulo.Bottom - diametro,
                        diametro, diametro, 90, 90);

                    ruta.CloseFigure();

                    Region nuevaRegion = new Region(ruta);
                    Region? regionAnterior = panel.Region;

                    panel.Region = nuevaRegion;
                    regionAnterior?.Dispose();
                }
            }

            panel.SizeChanged -= ActualizarRegion;
            panel.SizeChanged += ActualizarRegion;

            ActualizarRegion(panel, EventArgs.Empty);
        }
    }
}
