using System;

namespace DaoLogistica.ENTIDAD
{
    public class Servicios
    {
        public Servicios(string autorizacion, string cese, string codLogin, string codSubDep, char estado, DateTime fecha, DateTime fechaCese, DateTime fechaInicio, DateTime fechaModi, int meta, string numero, string responsable, string rpm, string ruc, string tipoplan, string tipoServicio)
        {
            Autorizacion = autorizacion;
            Cese = cese;
            CodLogin = codLogin;
            CodSubDep = codSubDep;
            Estado = estado;
            Fecha = fecha;
            FechaCese = fechaCese;
            FechaInicio = fechaInicio;
            FechaModi = fechaModi;
            Meta = meta;
            Numero = numero;
            Responsable = responsable;
            Rpm = rpm;
            Ruc = ruc;
            Tipoplan = tipoplan;
            TipoServicio = tipoServicio;
        }
        public Servicios()
        {
            Clear();
        }

        public void Clear()
        {
            Autorizacion = String.Empty;
            Cese = String.Empty;
            CodLogin = String.Empty;
            CodSubDep = String.Empty;
            Estado = '1';
            Fecha = new DateTime(1900, 1, 1);
            FechaCese = new DateTime(1900, 1, 1);
            FechaInicio = new DateTime(1900, 1, 1);
            FechaModi = new DateTime(1900, 1, 1);
            Meta = 0;
            Numero = String.Empty;
            Responsable = String.Empty;
            Rpm = String.Empty;
            Ruc = String.Empty;
            Tipoplan = String.Empty;
            TipoServicio = String.Empty;
        }

        #region Properties
        /// <summary>
        /// Gets or sets the Numero value.
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Gets or sets the TipoServicio value.
        /// </summary>
        public string TipoServicio { get; set; }

        public string NombreServicio
        {
            get
            {
                var cad="DESCONOCIDO!!!";
                //[TM=Moviles] [TF=Telefonia Fija] [SE=Suministro de Energia] 
                //[SA=Suministro de Agua y Desague] [SI=Suministro de Internet]
                switch (TipoServicio)
                {
                    case "TM":
                        cad = "TELEFONIA MOVILES";
                        break;
                    case "TF":
                        cad = "TELEFONIA FIJA";
                        break;
                    case "SE":
                        cad = "SUMINISTRO DE ENERGIA";
                        break;
                    case "SA":
                        cad = "SUMINISTRO DE AGUA";
                        break;
                    case "SI":
                        cad = "SUMINISTRO ACCESO A INTERNET";
                        break;
                }
                return cad;
            }
        }
        /// <summary>
        /// Gets or sets the CodSubDep value.
        /// </summary>
        public string CodSubDep { get; set; }

        /// <summary>
        /// Gets or sets the Responsable value.
        /// </summary>
        public string Responsable { get; set; }

        /// <summary>
        /// Gets or sets the Meta value.
        /// </summary>
        public int Meta { get; set; }

        /// <summary>
        /// Gets or sets the Rpm value.
        /// </summary>
        public string Rpm { get; set; }

        /// <summary>
        /// Gets or sets the Tipoplan value.
        /// </summary>
        public string Tipoplan { get; set; }

        /// <summary>
        /// Gets or sets the Estado value.
        /// </summary>
        public char Estado { get; set; }

        /// <summary>
        /// Gets or sets the Ruc value.
        /// </summary>
        public string Ruc { get; set; }

        /// <summary>
        /// Gets or sets the FechaInicio value.
        /// </summary>
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Gets or sets the Autorizacion value.
        /// </summary>
        public string Autorizacion { get; set; }

        /// <summary>
        /// Gets or sets the FechaCese value.
        /// </summary>
        public DateTime FechaCese { get; set; }

        /// <summary>
        /// Gets or sets the Cese value.
        /// </summary>
        public string Cese { get; set; }

        /// <summary>
        /// Gets or sets the CodLogin value.
        /// </summary>
        public string CodLogin { get; set; }

        /// <summary>
        /// Gets or sets the Fecha value.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Gets or sets the FechaModi value.
        /// </summary>
        public DateTime FechaModi { get; set; }

        #endregion
    }
}
