using System;

namespace CertificaUtils
{
    public class Person
    {
        public Person()
        {
            AntiguoRuc = String.Empty;
            ApeMaterno = String.Empty;
            ApePaterno = String.Empty;
            Dependencia = String.Empty;
            Direccion = String.Empty;
            Dni = String.Empty;
            EsAgenteRetencion = String.Empty;
            Estado = String.Empty;
            FecNac = new DateTime(1900,1,1);
            NombreComercial = String.Empty;
            NombreDepartamento = String.Empty;
            NombreDistrito = String.Empty;
            NombreProvincia = String.Empty;
            Nombres = String.Empty;
            RazonComercial = String.Empty;
            RazonSocial = String.Empty;
            Ruc = String.Empty;
            Situacion = String.Empty;
            Telefono = String.Empty;
            TipoNegocio = String.Empty;
        }

        /// <summary>
        /// Si no Hubo error en la lectura de datos devuelve los nombres 
        /// de la persona caso contrario devuelve ""
        /// </summary>
        public string Nombres { get;  set; }

        /// <summary>
        /// Si no Hubo error en la lectura de datos devuelve el Apellido Paterno
        /// de la persona caso contrario devuelve ""
        /// </summary>
        public string ApePaterno { get;  set; }

        /// <summary>
        /// Si no Hubo error en la lectura de datos devuelve el Apellido Materno
        /// de la persona caso contrario devuelve ""
        /// </summary>
        public string ApeMaterno { get;  set; }
        public string Ruc { get; set; }
        public string Situacion { get; set; }
        public string RazonSocial { get; set; }
        public string RazonComercial { get; set; }
        public string AntiguoRuc { get; set; }
        public string Dni { get; set; }
        public DateTime FecNac { get; set; }
        public string Estado { get; set; }

        public string EsAgenteRetencion { get; set; }

        public string NombreComercial { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Dependencia { get; set; }
        public string TipoNegocio { get; set; }
        public string NombreDistrito { get; set; }
        public string NombreProvincia { get; set; }
        public string NombreDepartamento { get; set; }
    }
}
