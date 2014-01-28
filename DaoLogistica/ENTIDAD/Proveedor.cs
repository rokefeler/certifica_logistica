using System;

namespace DaoLogistica.ENTIDAD
{
    public class Proveedor
    {
        #region Propiedades
 
        public string Ruc { get; set; }
        public string Razon { get; set; }
        public string Contacto { get; set; }
        public string Situacion { get; set; }
        public string AgenteRetencion { get; set; }
        public string ReferenciaAgenteRetencion { get; set; }
        public string Razoncomercial { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string CodDis { get; set; }
        public char EsHabido { get; set; }
        public string Telefono { get; set; }
        public string TipoNegocio { get; set; }
        public string Dni { get; set; }
        public DateTime FecNac { get; set; }
        public string RepresentanteLegal1 { get; set; }
        public string RepresentanteLegal2 { get; set; }
        public string RepresentanteLegal3 { get; set; }
        public string DniRepresentanteLegal1 { get; set; }
        public string DniRepresentanteLegal2 { get; set; }
        public string DniRepresentanteLegal3 { get; set; }
        public string CuentaCci { get; set; }
        public short IdProveedorEstado { get; set; }
        public DateTime FechaRenovacionRnp { get; set; }
        public string Email { get; set; }
        public string CodLogin { get; set; }
        public DateTime FechaModi { get; set; }
        public DateTime Fecha { get; set; }
        #endregion

        public Proveedor()
		{
            var fecha=new DateTime(1900,1,1);
            Ruc = String.Empty;
            Razon = String.Empty;
            Contacto = String.Empty;
            Situacion = String.Empty;
            AgenteRetencion = String.Empty;
            ReferenciaAgenteRetencion = String.Empty;
            Razoncomercial = String.Empty;
            Direccion = String.Empty;
            Referencia = String.Empty;
            CodDis = String.Empty;
            EsHabido = ' ';
            Telefono = String.Empty;
            TipoNegocio = String.Empty;
            Dni = String.Empty;
            FecNac = fecha;
            RepresentanteLegal1 = String.Empty;
            RepresentanteLegal2 = String.Empty;
            RepresentanteLegal3 = String.Empty;
            DniRepresentanteLegal1 = String.Empty;
            DniRepresentanteLegal2 = String.Empty;
            DniRepresentanteLegal3 = String.Empty;
            CuentaCci = String.Empty;
            IdProveedorEstado = 0;
            FechaRenovacionRnp = fecha;
            Email = String.Empty;
            CodLogin = String.Empty;
            FechaModi = fecha;
            Fecha = fecha;
		}

		/// <summary>
		/// Initializes a new instance of the TProveedorDTO class.
		/// </summary>
		public Proveedor(string ruc, string razon, string contacto, string estado, 
            string agenteRetencion, string referenciaAgenteRetencion, 
            string razoncomercial, string direccion, string referencia, 
            string codDis, char esHabido, string telefono, string tipoNegocio, 
            string dNi, DateTime fecNac, string representanteLegal1, 
            string representanteLegal2, string representanteLegal3, 
            string dniRepresentanteLegal1, string dniRepresentanteLegal2, 
            string dniRepresentanteLegal3, string cuentaCci, short idProveedorEstado, 
            DateTime fechaRenovacionRnp, string email, string codLogin, 
            DateTime fechaModi, DateTime fecha)
		{
			Ruc = ruc;
			Razon = razon;
			Contacto = contacto;
			Situacion = estado;
			AgenteRetencion = agenteRetencion;
			ReferenciaAgenteRetencion = referenciaAgenteRetencion;
			Razoncomercial = razoncomercial;
			Direccion = direccion;
			Referencia = referencia;
			CodDis = codDis;
			EsHabido = esHabido;
			Telefono = telefono;
			TipoNegocio = tipoNegocio;
			Dni = dNi;
			FecNac = fecNac;
			RepresentanteLegal1 = representanteLegal1;
			RepresentanteLegal2 = representanteLegal2;
			RepresentanteLegal3 = representanteLegal3;
			DniRepresentanteLegal1 = dniRepresentanteLegal1;
			DniRepresentanteLegal2 = dniRepresentanteLegal2;
			DniRepresentanteLegal3 = dniRepresentanteLegal3;
			CuentaCci = cuentaCci;
			IdProveedorEstado = idProveedorEstado;
			FechaRenovacionRnp= fechaRenovacionRnp;
			Email = email;
			CodLogin = codLogin;
			FechaModi = fechaModi;
			Fecha = fecha;
		}
    }
}
