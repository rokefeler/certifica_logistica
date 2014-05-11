using System;

namespace DaoLogistica.ENTIDAD
{
    public class Alumno
    {
        public Alumno()
        {
            Clear();
        }

        public void Clear()
        {
            Cui = String.Empty;
            ApeNom = String.Empty;
            Direccion = String.Empty;
            CodDis = String.Empty;
            Dni = String.Empty;
            Telefono = String.Empty;
            Email = String.Empty;
            Fecnac = new DateTime(1900, 1, 1);
            Fecha = new DateTime(1900, 1, 1);
            CodLogin = String.Empty;
            Estado = '1';
        }

        public String Cui { get; set; }
        public String ApeNom { get; set; }
        public string Direccion { get; set; }
        public string CodDis { get; set; }
        public String Dni { get; set; }
        public String Telefono { get; set; }
        public String Email { get; set; }
        public DateTime Fecnac { get; set; }
        public DateTime Fecha { get; set; }
        public String CodLogin { get; set; }
        public char Estado { get; set; }
    }
}
