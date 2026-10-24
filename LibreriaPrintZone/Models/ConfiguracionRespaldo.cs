
using System;

namespace LibreriaPrintZone.Models
{
    public class ConfiguracionRespaldo
    {
        public bool Activado { get; set; } = false;

        public string Frecuencia { get; set; } = "Diario";

        public string DiaEjecucion { get; set; } = "No aplica";

        public TimeSpan HoraInicio { get; set; } =
            new TimeSpan(20, 0, 0);

        public string TipoRespaldo { get; set; } = "Completo";

        public string CarpetaDestino { get; set; } = "";
    }
}
