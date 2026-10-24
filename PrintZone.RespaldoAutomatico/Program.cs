
using System;
using System.IO;
using System.Threading.Tasks;
using DotNetEnv;
using LibreriaPrintZone.Components;
using LibreriaPrintZone.Controllers;
using LibreriaPrintZone.Models;

namespace PrintZone.RespaldoAutomatico
{
    internal class Program
    {
        private static async Task<int> Main(string[] args)
        {
            try
            {
                // Ubicación compartida de la configuración.
                string rutaConfiguracion = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                    "PrintZone",
                    "configuracion-respaldo.json");

                if (!File.Exists(rutaConfiguracion))
                {
                    Console.Error.WriteLine(
                        "No se encontró la configuración: " +
                        rutaConfiguracion);

                    return 1;
                }

                string json = await File.ReadAllTextAsync(
                    rutaConfiguracion);

                ConfiguracionRespaldo? configuracion =
                    System.Text.Json.JsonSerializer
                        .Deserialize<ConfiguracionRespaldo>(json);

                if (configuracion == null)
                {
                    Console.Error.WriteLine(
                        "La configuración no es válida.");

                    return 1;
                }

                if (!configuracion.Activado)
                {
                    Console.WriteLine(
                        "El respaldo automático está desactivado.");

                    return 0;
                }

                // Buscar el archivo .env del proyecto.
                string carpetaActual = AppContext.BaseDirectory;
                string? rutaEnv = null;

                DirectoryInfo? carpeta =
                    new DirectoryInfo(carpetaActual);

                while (carpeta != null)
                {
                    string posibleRuta = Path.Combine(
                        carpeta.FullName,
                        "LibreriaPrintZone",
                        ".env");

                    if (File.Exists(posibleRuta))
                    {
                        rutaEnv = posibleRuta;
                        break;
                    }

                    string envDirecto = Path.Combine(
                        carpeta.FullName,
                        ".env");

                    if (File.Exists(envDirecto))
                    {
                        rutaEnv = envDirecto;
                        break;
                    }

                    carpeta = carpeta.Parent;
                }

                if (rutaEnv == null)
                {
                    Console.Error.WriteLine(
                        "No se encontró el archivo .env.");

                    return 1;
                }

                Env.Load(rutaEnv);

                // Crear el respaldo.
                RespaldoController controlador =
                    new RespaldoController();

                RespaldoController.ResultadoRespaldo resultado =
                    controlador.CrearRespaldoConDetalles(
                        configuracion.TipoRespaldo,
                        configuracion.CarpetaDestino);

                // Enviar el correo de notificación automática.
                CorreoService correo = new CorreoService();

                await correo.EnviarNotificacionRespaldoAsync(
                    resultado,
                    "Sistema PrintZone",
                    "Sistema PrintZone",
                    "Sistema",
                    "Automático");

                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(
                    "Error durante el respaldo automático:");

                Console.Error.WriteLine(ex.Message);

                return 1;
            }
        }
    }
}
