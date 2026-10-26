
using System;
using System.Data;
using System.IO;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace LibreriaPrintZone.Controllers
{
    public class RespaldoController
    {
        private readonly string _cadenaConexion =
            "Server=ELMK;Database=Inventario_Printzone;Trusted_Connection=True;TrustServerCertificate=True;";

        private readonly string _cadenaConexionMaster =
            "Server=ELMK;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

        public class ResultadoRespaldo
        {
            public string TipoRespaldo { get; set; } = "";
            public string NombreArchivo { get; set; } = "";
            public string RutaArchivo { get; set; } = "";
            public double TamanoMB { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFinalizacion { get; set; }
            public TimeSpan Duracion { get; set; }

            public string Estado { get; set; } =
                "Realizado correctamente";

            public string Mensaje =>
                "Respaldo creado correctamente en:\n" +
                RutaArchivo;
        }

        public string CrearRespaldo(
            string tipoRespaldo,
            string carpetaRespaldo)
        {
            ResultadoRespaldo resultado =
                CrearRespaldoConDetalles(
                    tipoRespaldo,
                    carpetaRespaldo);

            return resultado.Mensaje;
        }

        public ResultadoRespaldo CrearRespaldoConDetalles(
            string tipoRespaldo,
            string carpetaRespaldo)
        {
            if (string.IsNullOrWhiteSpace(carpetaRespaldo))
            {
                throw new ArgumentException(
                    "Selecciona una ubicación para guardar el respaldo.");
            }

            string procedimiento;
            string prefijo;

            string tipoNormalizado =
                tipoRespaldo?.Trim().ToUpperInvariant() ?? "";

            switch (tipoNormalizado)
            {
                case "FULL":
                case "COMPLETO":

                    procedimiento = "dbo.sp_Respaldo_Full";
                    prefijo = "PrintZone_FULL_";
                    tipoNormalizado = "FULL";

                    break;

                case "INCREMENTAL":
                case "DIFERENCIAL":
                case "DIFFERENTIAL":

                    procedimiento = "dbo.sp_Respaldo_Diferencial";
                    prefijo = "PrintZone_DIFF_";
                    tipoNormalizado = "INCREMENTAL";

                    break;

                default:

                    throw new ArgumentException(
                        "Selecciona un respaldo FULL o INCREMENTAL.");
            }

            string carpeta = carpetaRespaldo.Trim();

            DateTime fechaInicio = DateTime.Now;

            if (!Directory.Exists(carpeta))
            {
                throw new DirectoryNotFoundException(
                    "La carpeta de respaldos no existe o no está accesible:\n" +
                    carpeta);
            }

            var archivosAnteriores = Directory
                .GetFiles(carpeta, "*.bak")
                .Select(Path.GetFullPath)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            using (SqlConnection conexion =
                   new SqlConnection(_cadenaConexion))
            {
                conexion.Open();

                using (SqlCommand comando =
                       new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType =
                        CommandType.StoredProcedure;

                    comando.CommandTimeout = 0;

                    comando.Parameters.Add(
                        "@Carpeta",
                        SqlDbType.NVarChar,
                        500
                    ).Value = carpeta;

                    comando.ExecuteNonQuery();
                }
            }

            DateTime fechaFinalizacion = DateTime.Now;

            string rutaArchivo = Directory
                .GetFiles(carpeta, prefijo + "*.bak")
                .Select(Path.GetFullPath)
                .Where(archivo =>
                    !archivosAnteriores.Contains(archivo))
                .OrderByDescending(
                    archivo => File.GetLastWriteTime(archivo))
                .FirstOrDefault();

            if (rutaArchivo == null)
            {
                throw new FileNotFoundException(
                    "El procedimiento terminó, pero no se pudo " +
                    "identificar el nuevo archivo de respaldo. " +
                    "Verifica la carpeta y los permisos de SQL Server.",
                    carpeta);
            }

            FileInfo informacionArchivo =
                new FileInfo(rutaArchivo);

            return new ResultadoRespaldo
            {
                TipoRespaldo = tipoNormalizado,
                NombreArchivo = informacionArchivo.Name,
                RutaArchivo = informacionArchivo.FullName,

                TamanoMB = Math.Round(
                    informacionArchivo.Length / (1024.0 * 1024.0),
                    2),

                FechaInicio = fechaInicio,
                FechaFinalizacion = fechaFinalizacion,
                Duracion = fechaFinalizacion - fechaInicio,

                Estado = "Realizado correctamente"
            };
        }

        public string RestaurarRespaldo(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
            {
                throw new ArgumentException(
                    "Selecciona un archivo de respaldo.");
            }

            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException(
                    "No se encontró el archivo de respaldo.",
                    rutaArchivo);
            }

            using (SqlConnection conexion =
                   new SqlConnection(_cadenaConexionMaster))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(@"
                    RESTORE VERIFYONLY
                    FROM DISK = @Ruta;

                    ALTER DATABASE [Inventario_Printzone]
                    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                    BEGIN TRY
                        RESTORE DATABASE [Inventario_Printzone]
                        FROM DISK = @Ruta
                        WITH REPLACE, RECOVERY;

                        ALTER DATABASE [Inventario_Printzone]
                        SET MULTI_USER;
                    END TRY
                    BEGIN CATCH
                        IF EXISTS (
                            SELECT 1
                            FROM sys.databases
                            WHERE name = N'Inventario_Printzone'
                              AND state_desc = N'ONLINE'
                              AND user_access_desc = N'SINGLE_USER'
                        )
                        BEGIN
                            ALTER DATABASE [Inventario_Printzone]
                            SET MULTI_USER;
                        END;

                        THROW;
                    END CATCH;
                ", conexion))
                {
                    comando.CommandTimeout = 0;

                    comando.Parameters.Add(
                        "@Ruta",
                        SqlDbType.NVarChar,
                        4000
                    ).Value = rutaArchivo;

                    comando.ExecuteNonQuery();
                }
            }

            return "La base de datos se restauró correctamente.";
        }
    }
}
