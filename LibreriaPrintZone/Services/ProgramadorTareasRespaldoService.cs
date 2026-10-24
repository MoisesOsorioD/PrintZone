
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using LibreriaPrintZone.Models;

namespace LibreriaPrintZone.Services
{
    public class ProgramadorTareasRespaldoService
    {
        private const string NombreTarea =
            "PrintZone - Respaldo automático";

        private const string RutaEjecutable =
            @"C:\Users\Fernando Duarte\source\repos\LibreriaPrintZone\PrintZone.RespaldoAutomatico\bin\Release\net10.0-windows\publish\PrintZone.RespaldoAutomatico.exe";

        public void ActualizarTarea(
            ConfiguracionRespaldo configuracion)
        {
            if (configuracion == null)
            {
                throw new ArgumentNullException(
                    nameof(configuracion));
            }

            if (!configuracion.Activado)
            {
                EjecutarSchtasks(
                    true,
                    "/Delete", "/TN", NombreTarea, "/F");

                return;
            }

            if (!File.Exists(RutaEjecutable))
            {
                throw new FileNotFoundException(
                    "No se encontró el ejecutable del respaldo.",
                    RutaEjecutable);
            }

            EjecutarSchtasks(
                true,
                "/Delete", "/TN", NombreTarea, "/F");

            string frecuencia;
            string argumentosFrecuencia = "";

            switch (configuracion.Frecuencia)
            {
                case "Diario":
                    frecuencia = "DAILY";
                    break;

                case "Semanal":
                    frecuencia = "WEEKLY";
                    argumentosFrecuencia =
                        "/D " + ObtenerDiaSemanal(
                            configuracion.DiaEjecucion);
                    break;

                case "Mensual":
                    frecuencia = "MONTHLY";
                    argumentosFrecuencia =
                        "/D " + configuracion.DiaEjecucion;
                    break;

                default:
                    throw new InvalidOperationException(
                        "La frecuencia seleccionada no es válida.");
            }

            string hora = configuracion.HoraInicio.ToString(
                @"hh\:mm",
                CultureInfo.InvariantCulture);

            string argumentos =
                $"/Create /TN \"{NombreTarea}\" " +
                $"/TR \"\\\"{RutaEjecutable}\\\"\" " +
                $"/SC {frecuencia} " +
                $"{argumentosFrecuencia} " +
                $"/ST {hora} /F";

            EjecutarSchtasks(false, argumentos);
        }

        private static string ObtenerDiaSemanal(string dia)
        {
            return dia switch
            {
                "Lunes" => "MON",
                "Martes" => "TUE",
                "Miércoles" => "WED",
                "Jueves" => "THU",
                "Viernes" => "FRI",
                "Sábado" => "SAT",
                "Domingo" => "SUN",
                _ => throw new InvalidOperationException(
                    "El día de la semana no es válido.")
            };
        }

        private static void EjecutarSchtasks(
            bool permitirError,
            params string[] argumentos)
        {
            using Process proceso = new Process();

            proceso.StartInfo = new ProcessStartInfo
            {
                FileName = "schtasks.exe",
                Arguments = string.Join(" ", argumentos),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            proceso.Start();

            string salida =
                proceso.StandardOutput.ReadToEnd();

            string error =
                proceso.StandardError.ReadToEnd();

            proceso.WaitForExit();

            if (proceso.ExitCode != 0 && !permitirError)
            {
                throw new InvalidOperationException(
                    "No se pudo actualizar la tarea programada.\n" +
                    salida + "\n" + error);
            }
        }
    }
}
