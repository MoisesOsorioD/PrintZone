
using System;
using System.IO;
using System.Text.Json;
using LibreriaPrintZone.Models;

namespace LibreriaPrintZone.Services
{
    public class ConfiguracionRespaldoService
    {
        private readonly string _rutaArchivo;

        public ConfiguracionRespaldoService()
        {
            string carpetaConfiguracion = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "PrintZone");

            Directory.CreateDirectory(carpetaConfiguracion);

            _rutaArchivo = Path.Combine(
                carpetaConfiguracion,
                "configuracion-respaldo.json");
        }

        public void Guardar(ConfiguracionRespaldo configuracion)
        {
            if (configuracion == null)
            {
                throw new ArgumentNullException(nameof(configuracion));
            }

            string json = JsonSerializer.Serialize(
                configuracion,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(_rutaArchivo, json);
        }

        public ConfiguracionRespaldo Cargar()
        {
            if (!File.Exists(_rutaArchivo))
            {
                return new ConfiguracionRespaldo();
            }

            string json = File.ReadAllText(_rutaArchivo);

            return JsonSerializer.Deserialize<ConfiguracionRespaldo>(json)
                   ?? new ConfiguracionRespaldo();
        }
    }
}
