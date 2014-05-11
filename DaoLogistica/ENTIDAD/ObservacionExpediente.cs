using System;

namespace DaoLogistica.ENTIDAD
{
    public class ObservacionExpediente
    {
        public ObservacionExpediente(string idExpediente, string detalle, string codLogin)
        {
            Clear();
            CodLogin = codLogin;
            Detalle = detalle;
            IdExpediente = idExpediente;
        }
        public ObservacionExpediente()
        {
            Clear();
        }
        public void Clear()
        {
            Id = 0;
            IdExpediente = String.Empty;
            Fecha = new DateTime(1900,1,1);
            Detalle = String.Empty;
            CodLogin = String.Empty;
            Eliminado = false;
            CodLogin_Elimina = String.Empty;
        }
        public long Id { get; set; }
        public string IdExpediente { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public string CodLogin { get; set; }
        public bool Eliminado { get; set; }
        public string CodLogin_Elimina { get; set; }
        /// <summary>
        /// Muestra Valor de Fecha Resumida
        /// </summary>
        public string Display
        {
            get
            {
                return String.Format("{0}.{1}.{2} {3}:{4}", Fecha.Day.ToString("00"), 
                                                    Fecha.Month.ToString("00"),
                                                    Fecha.Year.ToString("0000").Substring(2, 2),
                                                    Fecha.Hour.ToString("00"),
                                                    Fecha.Minute.ToString("00") );
            }
        }
    }
}
