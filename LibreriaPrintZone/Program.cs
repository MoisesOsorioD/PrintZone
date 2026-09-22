using LibreriaPrintZone.Models;

namespace LibreriaPrintZone
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Task.Run(() =>
            {
                try
                {
                    using var context = new InventarioPrintzoneContext();

                    _ = context.Model;
                    context.Database.CanConnect();
                }
                catch
                {
                    // La aplicación continuará normalmente.
                }
            });

            Application.Run(new frmInicioSesion());
        }
    }
}