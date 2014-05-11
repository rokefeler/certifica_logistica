using System;

namespace Certifica_logistica.modulos
{
    public class Conexion
    {
        public Conexion()
        {
            Ip = String.Empty;
            Puerto = String.Empty;
            Catalogo = String.Empty;
            Usuario = String.Empty;
            Pwd = String.Empty;
        }

        public Conexion(string ip, string puerto, string catalogo, string usuario, string pwd)
        {
            Ip = ip;
            Puerto = puerto;
            Catalogo = catalogo;
            Usuario = usuario;
            Pwd = pwd;
        }


        public string Ip { get; set; }

        public string Puerto { get; set; }

        public string Catalogo { get; set; }

        public string Usuario { get; set; }

        public string Pwd { get; set; }
    }
}
