using System;

namespace DaoLogistica.ENTIDAD
{
    public class OrdenLogistica
    {
		public OrdenLogistica()
		{
		    Clear();
		}

        public void Clear()
        {
            IdOrden = 0;
            Cnro = String.Empty;
            IdExpediente = String.Empty;
            IdxTipoOrden = String.Empty;
            TipoUsuario = 'N'; //[V=Proveedor] - [P=Personal] - [A=Alumno] - [N=Ninguno]
            Codigo = String.Empty;
            StampNombre = String.Empty;
            FechaGiro = new DateTime(1900, 1, 1);
            IdAlmacen = 0;
            IdxProceso = String.Empty;
            Referencia = String.Empty;
            Descripcion = String.Empty;
            Total = 0m;
            Estado = 0;
            Siaf = String.Empty;

            FechaBloqueo = new DateTime(1900, 1, 1);
            ;
            IsCoa = false;
            CodLogin = String.Empty;
            FechaRegistro = new DateTime(1900, 1, 1);
            ;
            FechaImpresion = new DateTime(1900, 1, 1);
            FechaAnulacion = new DateTime(1900, 1, 1);
            CodLoginAnula = String.Empty;
        }

        #region Properties
	
		public long IdOrden { get; set; }
        public string Cnro { get; set; }
        public string IdExpediente { get; set; }
        public string IdxTipoOrden { get; set; }

		public char TipoUsuario { get; set; }
		public string Codigo { get; set; }
		public string StampNombre { get; set; }
		public DateTime FechaGiro { get; set; }
		public int IdAlmacen { get; set; }
		public string IdxProceso { get; set; }
		public string Referencia { get; set; }
		public string Descripcion { get; set; }
		public Decimal Total { get; set; }
		public short Estado { get; set; }
		public string Siaf { get; set; }
		public DateTime FechaBloqueo { get; set; }
		public bool IsCoa { get; set; }
		public string CodLogin { get; set; }
		public DateTime FechaRegistro { get; set; }
        public DateTime FechaImpresion { get; set; }
        public DateTime FechaAnulacion { get; set; }
        public string CodLoginAnula { get; set; }
		#endregion
    }
}
