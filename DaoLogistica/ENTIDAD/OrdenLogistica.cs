using System;

namespace DaoLogistica.ENTIDAD
{
    public class OrdenLogistica
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the TOrdenLogisticaDTO class.
		/// </summary>
		public OrdenLogistica()
		{
            var fecha=new DateTime(1900,1,1);
            IdOrden = String.Empty;
            IdExpediente = String.Empty;
            IdxTipoOrden = String.Empty;
            TipoUsuario = 'N';  //[V=Proveedor] - [P=Personal] - [A=Alumno] - [N=Ninguno]
            Codigo = String.Empty;
            StampNombre = String.Empty;
            FechaGiro = fecha;
            IdAlmacen = 0;
            IdProceso = String.Empty;
            Referencia = String.Empty;
            Descripcion = String.Empty;
            Total = 0;
            Estado = 0;
            Siaf = String.Empty;
            FechaImpresion = fecha;
            FechaBloqueo = fecha;
            IsCoa = false;
            CodLogin = String.Empty;
            FechaRegistro = fecha;
            FechaAnulacion = fecha;
		}

		/// <summary>
		/// Initializes a new instance of the TOrdenLogisticaDTO class.
		/// </summary>
		public OrdenLogistica(string idOrden, string idExpediente, string idxTipoOrden, 
            char tipoUsuario, string codigo, string stampNombre, DateTime fechaGiro, 
            int idAlmacen, string idProceso, string referencia, string descripcion, 
            Decimal total, short estado, string siaf, DateTime fechaImpresion, 
            DateTime fechaBloqueo, bool isCoa, string codLogin, DateTime fechaRegistro, DateTime fechaAnulacion)
		{
			IdOrden = idOrden;
			IdExpediente = idExpediente;
			IdxTipoOrden = idxTipoOrden;
			TipoUsuario = tipoUsuario;
			Codigo = codigo;
			StampNombre = stampNombre;
			FechaGiro = fechaGiro;
			IdAlmacen = idAlmacen;
			IdProceso = idProceso;
			Referencia = referencia;
			Descripcion = descripcion;
			Total = total;
			Estado = estado;
			Siaf = siaf;
			FechaImpresion = fechaImpresion;
			FechaBloqueo = fechaBloqueo;
			IsCoa = isCoa;
			CodLogin = codLogin;
			FechaRegistro = fechaRegistro;
			FechaAnulacion = fechaAnulacion;
		}

		#endregion

		#region Properties
	
		public string IdOrden { get; set; }
        public string IdExpediente { get; set; }
        public string IdxTipoOrden { get; set; }

		public char TipoUsuario { get; set; }
		public string Codigo { get; set; }
		public string StampNombre { get; set; }
		public DateTime FechaGiro { get; set; }
		public int IdAlmacen { get; set; }
		public string IdProceso { get; set; }
		public string Referencia { get; set; }
		public string Descripcion { get; set; }
		public Decimal Total { get; set; }
		public short Estado { get; set; }
		public string Siaf { get; set; }
		public DateTime FechaImpresion { get; set; }
		public DateTime FechaBloqueo { get; set; }
		public bool IsCoa { get; set; }
		public string CodLogin { get; set; }
		public DateTime FechaRegistro { get; set; }
		public DateTime FechaAnulacion { get; set; }

		#endregion
    }
}
