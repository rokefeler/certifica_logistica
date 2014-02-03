using System;

namespace DaoLogistica.ENTIDAD
{
    public class AlumnoEscuela
    {
        public AlumnoEscuela(int idEscuela, string nombre)
        {
            IdEscuela = idEscuela;
            Nombre = nombre;
        }
        public AlumnoEscuela()
        {
            Clear();
        }

        private void Clear()
        {
            IdEscuela = 0;
            Nombre = String.Empty;
        }

        public int IdEscuela { get; set; }
        public string Nombre { get; set; }

    }
}
