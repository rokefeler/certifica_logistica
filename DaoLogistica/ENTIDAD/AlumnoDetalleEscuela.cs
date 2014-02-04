using System;

namespace DaoLogistica.ENTIDAD
{
    public class AlumnoDetalleEscuela
    {
        public AlumnoDetalleEscuela(string codLogin, string cui, DateTime fecha, int id, int idEscuela, String nombre)
        {
            CodLogin = codLogin;
            Cui = cui;
            Fecha = fecha;
            Nombre = nombre;
            Id = id;
            IdEscuela = idEscuela;
        }

        public AlumnoDetalleEscuela()
        {
            Clear();
        }

        private void Clear()
        {
            CodLogin = String.Empty;
            Cui = String.Empty;
            Nombre = String.Empty;
            Fecha = new DateTime(1900, 1, 1);
            Id = 0;
            IdEscuela = 0;
        }

        public int Id { get; set; }
        public string Cui { get; set; }
        public int IdEscuela { get; set; }
        public string CodLogin { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
}
