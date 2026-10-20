
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LibreriaPrintZone.Controllers;

namespace LibreriaPrintZone.Components
{
    public class CorreoService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public CorreoService(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException(
                    "La clave API de Resend es obligatoria.");
            }

            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task EnviarNotificacionRespaldoAsync(
            RespaldoController.ResultadoRespaldo respaldo,
            string nombreCompleto,
            string nombreUsuario,
            string rolUsuario)
        {
            if (respaldo == null)
            {
                throw new ArgumentNullException(nameof(respaldo));
            }

            string duracion = respaldo.Duracion.ToString(@"hh\:mm\:ss");

            string cuerpo =
                "PRINTZONE\n" +
                "INFORME DE RESPALDO\n\n" +

                "RESPALDO COMPLETADO\n" +
                "Operación finalizada correctamente.\n\n" +

                "1. INFORMACIÓN DE LA OPERACIÓN\n\n" +
                $"Base de datos: Inventario_Printzone\n" +
                $"Usuario responsable: {nombreCompleto}\n" +
                $"Nombre de usuario: {nombreUsuario}\n" +
                $"Rol: {rolUsuario}\n" +
                $"Fecha y hora de inicio: {respaldo.FechaInicio:dd/MM/yyyy HH:mm:ss}\n" +
                $"Fecha y hora de finalización: {respaldo.FechaFinalizacion:dd/MM/yyyy HH:mm:ss}\n" +
                $"Duración: {duracion}\n" +
                $"Modalidad: Manual\n" +
                $"Tipo de respaldo: {respaldo.TipoRespaldo}\n\n" +

                "2. ARCHIVO GENERADO\n\n" +
                $"Nombre del archivo: {respaldo.NombreArchivo}\n" +
                $"Ruta completa: {respaldo.RutaArchivo}\n" +
                $"Tamaño: {respaldo.TamanoMB:N2} MB\n\n" +

                "3. RESULTADO\n\n" +
                $"Estado del respaldo: {respaldo.Estado}\n" +

                "NOTIFICACIÓN\n" +
                "Este correo fue generado automáticamente por PrintZone.\n" +
                "El archivo de respaldo no se adjunta.";

            var correo = new
            {
                from = "PrintZone <onboarding@resend.dev>",
                to = new[] { "moisesosorio2030@gmail.com" },
                subject = $"PrintZone - Respaldo {respaldo.TipoRespaldo} completado",
                text = cuerpo
            };

            string json = JsonSerializer.Serialize(correo);

            using var solicitud = new HttpRequestMessage(
                HttpMethod.Post,
                "https://api.resend.com/emails");

            solicitud.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", _apiKey);

            solicitud.Content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

            using HttpResponseMessage respuesta =
                await _httpClient.SendAsync(solicitud);

            string contenido =
                await respuesta.Content.ReadAsStringAsync();

            if (!respuesta.IsSuccessStatusCode)
            {
                throw new InvalidOperationException(
                    $"Error al enviar el correo ({(int)respuesta.StatusCode}): {contenido}");
            }
        }
    }
}
