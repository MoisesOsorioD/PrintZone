
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

        public CorreoService()
            : this(Environment.GetEnvironmentVariable("RESEND_API_KEY"))
        {
        }

        public CorreoService(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException(
                    "No se encontró RESEND_API_KEY. Revisá el archivo .env."
                );
            }

            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task EnviarNotificacionRespaldoAsync(
            RespaldoController.ResultadoRespaldo respaldo,
            string nombreCompleto,
            string nombreUsuario,
            string rolUsuario,
            string modalidad = "Manual")
        {
            if (respaldo == null)
            {
                throw new ArgumentNullException(nameof(respaldo));
            }

            string fechaInicio = respaldo.FechaInicio.ToString(
                "dd/MM/yyyy HH:mm:ss"
            );

            string fechaFinalizacion =
                respaldo.FechaFinalizacion.ToString(
                    "dd/MM/yyyy HH:mm:ss"
                );

            string duracion = respaldo.Duracion.ToString(
                @"hh\:mm\:ss"
            );

            string tipoRespaldo = HtmlEncode(respaldo.TipoRespaldo);
            string nombreArchivo = HtmlEncode(respaldo.NombreArchivo);
            string rutaArchivo = HtmlEncode(respaldo.RutaArchivo);
            string estado = HtmlEncode(respaldo.Estado);

            string nombreCompletoHtml = HtmlEncode(nombreCompleto);
            string nombreUsuarioHtml = HtmlEncode(nombreUsuario);
            string rolUsuarioHtml = HtmlEncode(rolUsuario);

            string baseDatos = "Inventario_Printzone";
            string tamano = respaldo.TamanoMB.ToString("0.00") + " MB";

            string modalidadHtml = HtmlEncode(modalidad);

            string cuerpoHtml = GenerarPlantillaHtml(
                baseDatos,
                nombreCompletoHtml,
                nombreUsuarioHtml,
                rolUsuarioHtml,
                fechaInicio,
                fechaFinalizacion,
                duracion,
                modalidadHtml,
                tipoRespaldo,
                nombreArchivo,
                rutaArchivo,
                tamano,
                estado
            );

            string cuerpoTexto = GenerarTextoPlano(
                baseDatos,
                nombreCompleto,
                nombreUsuario,
                rolUsuario,
                fechaInicio,
                fechaFinalizacion,
                duracion,
                modalidad,
                respaldo.TipoRespaldo,
                respaldo.NombreArchivo,
                respaldo.RutaArchivo,
                tamano,
                respaldo.Estado
            );

            var contenido = new
            {
                from = "PrintZone <onboarding@resend.dev>",
                to = new[]
                {
                    "moisesosorio2030@gmail.com"
                },
                subject =
                    $"PrintZone - Respaldo {respaldo.TipoRespaldo} completado",
                html = cuerpoHtml,
                text = cuerpoTexto
            };

            string json = JsonSerializer.Serialize(contenido);

            using var solicitud = new HttpRequestMessage(
                HttpMethod.Post,
                "https://api.resend.com/emails"
            );

            solicitud.Headers.Authorization =
                new AuthenticationHeaderValue(
                    "Bearer",
                    _apiKey
                );

            solicitud.Content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );

            using HttpResponseMessage respuesta =
                await _httpClient.SendAsync(solicitud);

            if (!respuesta.IsSuccessStatusCode)
            {
                string detalle = await respuesta.Content
                    .ReadAsStringAsync();

                throw new Exception(
                    "No se pudo enviar el correo mediante Resend. " +
                    $"Código HTTP: {(int)respuesta.StatusCode}. " +
                    $"Detalle: {detalle}"
                );
            }
        }

        private static string GenerarPlantillaHtml(
            string baseDatos,
            string nombreCompleto,
            string nombreUsuario,
            string rolUsuario,
            string fechaInicio,
            string fechaFinalizacion,
            string duracion,
            string modalidad,
            string tipoRespaldo,
            string nombreArchivo,
            string rutaArchivo,
            string tamano,
            string estado)
        {
            var html = new StringBuilder();

            html.Append("""
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Informe de respaldo - PrintZone</title>
</head>
<body style="margin:0;padding:0;background-color:#edf1f6;font-family:Arial,Helvetica,sans-serif;color:#17243a;">
    <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="background-color:#edf1f6;width:100%;">
        <tr>
            <td align="center" style="padding:24px 10px;">
                <table role="presentation" width="620" cellpadding="0" cellspacing="0" border="0" style="width:100%;max-width:620px;background-color:#ffffff;border-radius:10px;overflow:hidden;">
                    <tr>
                        <td style="background-color:#17243a;padding:28px 26px;">
                            <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td valign="middle">
                                        <div style="font-size:25px;font-weight:bold;letter-spacing:1px;color:#ffffff;">
                                            PRINTZONE
                                        </div>
                                        <div style="font-size:12px;letter-spacing:1.5px;color:#c5d1e0;padding-top:6px;">
                                            INFORME DE RESPALDO
                                        </div>
                                    </td>
                                    <td align="right" valign="middle" style="font-size:30px;color:#4ade80;">
                                        &#10003;
                                    </td>
                                </tr>
                            </table>

                            <div style="height:1px;background-color:#40516b;margin:22px 0;"></div>

                            <div style="display:inline-block;background-color:#14532d;color:#bbf7d0;font-size:11px;font-weight:bold;letter-spacing:1px;padding:8px 11px;border-radius:4px;">
                                RESPALDO COMPLETADO
                            </div>

                            <div style="font-size:26px;line-height:1.3;font-weight:bold;color:#ffffff;margin-top:16px;">
                                ¡Todo listo!
                            </div>

                            <div style="font-size:14px;line-height:1.7;color:#d5dfec;margin-top:8px;">
                                La operación finalizó correctamente.
                                A continuación, se presenta el detalle
                                del respaldo realizado.
                            </div>
                        </td>
                    </tr>

                    <tr>
                        <td style="padding:24px 20px;">
                            <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="border:1px solid #e2e8f0;border-radius:8px;">
                                <tr>
                                    <td style="padding:20px;">
                                        <div style="font-size:18px;font-weight:bold;color:#17243a;margin-bottom:20px;">
                                            <span style="color:#526a8e;">01.</span>
                                            Información de la operación
                                        </div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                            BASE DE DATOS
                                        </div>
                                        <div style="font-size:15px;font-weight:bold;color:#17243a;padding-top:7px;">
                                            {{BASE_DATOS}}
                                        </div>

                                        <div style="height:1px;background-color:#e2e8f0;margin:18px 0;"></div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                            USUARIO RESPONSABLE
                                        </div>
                                        <div style="font-size:15px;font-weight:bold;color:#17243a;padding-top:7px;">
                                            {{NOMBRE_COMPLETO}}
                                        </div>
                                        <div style="font-size:13px;line-height:1.8;color:#475569;padding-top:4px;">
                                            Nombre de usuario: {{NOMBRE_USUARIO}}<br>
                                            Rol: {{ROL_USUARIO}}
                                        </div>

                                        <div style="height:1px;background-color:#e2e8f0;margin:18px 0;"></div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                            FECHA Y HORA DE INICIO
                                        </div>
                                        <div style="font-size:14px;color:#17243a;padding-top:6px;">
                                            {{FECHA_INICIO}}
                                        </div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;padding-top:15px;">
                                            FECHA Y HORA DE FINALIZACIÓN
                                        </div>
                                        <div style="font-size:14px;color:#17243a;padding-top:6px;">
                                            {{FECHA_FINALIZACION}}
                                        </div>

                                        <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="margin-top:18px;">
                                            <tr>
                                                <td width="50%" valign="top" style="padding:12px;background-color:#f1f5f9;border-radius:5px;">
                                                    <div style="font-size:10px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                                        DURACIÓN
                                                    </div>
                                                    <div style="font-size:16px;font-weight:bold;color:#17243a;padding-top:7px;">
                                                        {{DURACION}}
                                                    </div>
                                                </td>
                                                <td width="10"></td>
                                                <td width="50%" valign="top" style="padding:12px;background-color:#f1f5f9;border-radius:5px;">
                                                    <div style="font-size:10px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                                        MODALIDAD
                                                    </div>
                                                    <div style="font-size:16px;font-weight:bold;color:#17243a;padding-top:7px;">
                                                        {{MODALIDAD}}
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;padding-top:18px;">
                                            TIPO DE RESPALDO
                                        </div>
                                        <div style="font-size:14px;font-weight:bold;color:#17243a;padding-top:7px;">
                                            {{TIPO_RESPALDO}}
                                        </div>
                                    </td>
                                </tr>
                            </table>

                            <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="border:1px solid #e2e8f0;border-radius:8px;margin-top:18px;">
                                <tr>
                                    <td style="padding:20px;">
                                        <div style="font-size:18px;font-weight:bold;color:#17243a;margin-bottom:20px;">
                                            <span style="color:#526a8e;">02.</span>
                                            Archivo generado
                                        </div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                            NOMBRE DEL ARCHIVO
                                        </div>
                                        <div style="font-size:14px;line-height:1.7;font-weight:bold;color:#17243a;overflow-wrap:anywhere;padding-top:7px;">
                                            {{NOMBRE_ARCHIVO}}
                                        </div>

                                        <div style="height:1px;background-color:#e2e8f0;margin:18px 0;"></div>

                                        <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#64748b;">
                                            RUTA COMPLETA
                                        </div>
                                        <div style="font-family:Consolas,Monaco,monospace;font-size:12px;line-height:1.7;color:#334155;background-color:#f1f5f9;border-radius:5px;padding:12px;margin-top:8px;overflow-wrap:anywhere;word-break:break-word;">
                                            {{RUTA_ARCHIVO}}
                                        </div>

                                        <div style="background-color:#e7effb;border-radius:6px;padding:14px;margin-top:18px;">
                                            <div style="font-size:11px;font-weight:bold;letter-spacing:1px;color:#345a91;">
                                                TAMAÑO DEL ARCHIVO
                                            </div>
                                            <div style="font-size:21px;font-weight:bold;color:#17243a;padding-top:6px;">
                                                {{TAMANO}}
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>

                            <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="background-color:#e4f5ec;border:1px solid #b5e2ca;border-radius:8px;margin-top:18px;">
                                <tr>
                                    <td style="padding:20px;">
                                        <div style="font-size:18px;font-weight:bold;color:#166534;">
                                            <span style="color:#16804a;">03.</span>
                                            Resultado
                                        </div>
                                        <div style="font-size:14px;line-height:1.7;color:#166534;padding-top:12px;">
                                            <strong>Estado del respaldo:</strong><br>
                                            {{ESTADO}}
                                        </div>
                                    </td>
                                </tr>
                            </table>

                            <table role="presentation" width="100%" cellpadding="0" cellspacing="0" border="0" style="border:1px solid #e2e8f0;border-radius:8px;margin-top:18px;">
                                <tr>
                                    <td style="padding:18px 20px;">
                                        <div style="font-size:15px;font-weight:bold;color:#17243a;">
                                            &#9432; &nbsp; Notificación
                                        </div>
                                        <div style="font-size:13px;line-height:1.8;color:#475569;padding-top:10px;">
                                            Este correo fue generado automáticamente
                                            por PrintZone.<br>
                                            El archivo de respaldo no se adjunta.
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <tr>
                        <td align="center" style="background-color:#17243a;padding:24px 18px;">
                            <div style="font-size:16px;font-weight:bold;letter-spacing:1px;color:#ffffff;">
                                PRINTZONE
                            </div>
                            <div style="font-size:12px;color:#c5d1e0;padding-top:8px;">
                                Sistema de gestión de inventario
                            </div>
                            <div style="font-size:11px;line-height:1.7;color:#c5d1e0;padding-top:8px;">
                                Notificación automática · No es necesario responder
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>
</html>
""");

            return html.ToString()
                .Replace("{{BASE_DATOS}}", HtmlEncode(baseDatos))
                .Replace("{{NOMBRE_COMPLETO}}", nombreCompleto)
                .Replace("{{NOMBRE_USUARIO}}", nombreUsuario)
                .Replace("{{ROL_USUARIO}}", rolUsuario)
                .Replace("{{FECHA_INICIO}}", HtmlEncode(fechaInicio))
                .Replace("{{FECHA_FINALIZACION}}", HtmlEncode(fechaFinalizacion))
                .Replace("{{DURACION}}", HtmlEncode(duracion))
                .Replace("{{MODALIDAD}}", modalidad)
                .Replace("{{TIPO_RESPALDO}}", tipoRespaldo)
                .Replace("{{NOMBRE_ARCHIVO}}", nombreArchivo)
                .Replace("{{RUTA_ARCHIVO}}", rutaArchivo)
                .Replace("{{TAMANO}}", HtmlEncode(tamano))
                .Replace("{{ESTADO}}", estado);
        }

        private static string GenerarTextoPlano(
            string baseDatos,
            string nombreCompleto,
            string nombreUsuario,
            string rolUsuario,
            string fechaInicio,
            string fechaFinalizacion,
            string duracion,
            string modalidad,
            string tipoRespaldo,
            string nombreArchivo,
            string rutaArchivo,
            string tamano,
            string estado)
        {
            return $"""
PRINTZONE
INFORME DE RESPALDO

RESPALDO COMPLETADO
Operación finalizada correctamente.

1. INFORMACIÓN DE LA OPERACIÓN

Base de datos: {baseDatos}
Usuario responsable: {nombreCompleto}
Nombre de usuario: {nombreUsuario}
Rol: {rolUsuario}
Fecha y hora de inicio: {fechaInicio}
Fecha y hora de finalización: {fechaFinalizacion}

Duración: {duracion}
Modalidad: {modalidad}
Tipo de respaldo: {tipoRespaldo}

2. ARCHIVO GENERADO

Nombre del archivo: {nombreArchivo}
Ruta completa: {rutaArchivo}
Tamaño: {tamano}

3. RESULTADO

Estado del respaldo: {estado}

NOTIFICACIÓN
Este correo fue generado automáticamente por PrintZone.
El archivo de respaldo no se adjunta.
""";
        }

        private static string HtmlEncode(string valor)
        {
            if (valor == null)
            {
                return string.Empty;
            }

            return valor
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&#39;");
        }
    }
}
