
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibreriaPrintZone.Components
{
    public static class BotonRedondeado
    {
        public static void Aplicar(
            Button boton,
            int radio = 12)
        {
            if (boton == null)
                throw new ArgumentNullException(nameof(boton));

            if (radio < 1)
                throw new ArgumentOutOfRangeException(nameof(radio));

            void ActualizarRegion(object? sender, EventArgs e)
            {
                if (boton.Width <= 0 || boton.Height <= 0)
                    return;

                int diametro = Math.Min(
                    radio * 2,
                    Math.Min(boton.Width, boton.Height));

                Rectangle rectangulo = new Rectangle(
                    0, 0, boton.Width, boton.Height);

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
                    Region? regionAnterior = boton.Region;

                    boton.Region = nuevaRegion;
                    regionAnterior?.Dispose();
                }
            }

            boton.SizeChanged -= ActualizarRegion;
            boton.SizeChanged += ActualizarRegion;

            ActualizarRegion(boton, EventArgs.Empty);
        }
    }
}
