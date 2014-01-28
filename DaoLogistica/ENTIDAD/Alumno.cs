using System;

namespace DaoLogistica.ENTIDAD
{
    public class Alumno
    {
        public Alumno(string apeNom, string cui, string direccion, string dni, string email, string escuela, String fecnac, int id)
        {
            ApeNom = apeNom;
            Cui = cui;
            Direccion = direccion;
            Dni = dni;
            Email = email;
            Escuela = escuela;
            Fecnac = fecnac;
            Id = id;
        }
        public Alumno()
        {
            ApeNom = String.Empty;
            Cui = String.Empty;
            Direccion = String.Empty;
            Dni = String.Empty;
            Email = String.Empty;
            Escuela = String.Empty;
            Fecnac = String.Empty;
            Id = 0;
        }
        public int Id { get; set; }
        public String Cui { get; set; }
        public String ApeNom { get; set; }
        public string Escuela { get; set; }
        public string Direccion { get; set; }
        public String Email { get; set; }
        public String Fecnac { get; set; }
        public String Dni { get; set; }

    }
}
