using System;

namespace DaoLogistica.ENTIDAD
{
    public class Proveedor
    {
        #region Propiedades
        public string Ruc { get; set; }
        public string Razon { get; set; }
        public string RazonComercial { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string AgenteRetencion { get; set; }
        public string Cci { get; set; }
        public string Rnp { get; set; }
        public DateTime RnpVencimiento { get; set; }
        public string CodDis { get; set; }
        public string Situacion { get; set; }
        public char EsHabido { get; set; }
        public string TipoNegocio { get; set; }
        public string Dni { get; set; }
        public DateTime FecNac { get; set; }
        public string CodLogin { get; set; }
        public DateTime FechaModi { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
        #endregion

        public Proveedor()
        {
            Clear();
        }

        public void Clear()
        {
            var fecha = new DateTime(1900, 1, 1);
            Ruc = String.Empty;
            Razon = String.Empty;
            Contacto = String.Empty;
            Situacion = String.Empty;
            AgenteRetencion = String.Empty;
            RazonComercial = String.Empty;
            Direccion = String.Empty;
            Referencia = String.Empty;
            CodDis = String.Empty;
            EsHabido = ' ';
            Telefono = String.Empty;
            TipoNegocio = String.Empty;
            Dni = String.Empty;
            FecNac = fecha;
            Cci = String.Empty;
            Rnp = String.Empty;
            RnpVencimiento = fecha;
            Email = String.Empty;
            CodLogin = String.Empty;
            FechaModi = fecha;
            Fecha = fecha;
        }
    }
}
