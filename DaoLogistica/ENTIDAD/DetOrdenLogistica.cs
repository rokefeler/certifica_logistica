using System;

namespace DaoLogistica.ENTIDAD
{
    public class DetOrdenLogistica
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the TDetOrdenLogisticaDTO class.
		/// </summary>
		public DetOrdenLogistica()
		{
            Id = 0;
            IdOrden = 0;
            IdClasificador = 0;
            TipoUsuario = String.Empty;
            Codigo = String.Empty;
            Detalle = String.Empty;
            Monto = 0m;
		}

		/// <summary>
		/// Initializes a new instance of the TDetOrdenLogisticaDTO class.
		/// </summary>
		public DetOrdenLogistica(long id, long idOrden, int idClasificador, string tipoUsuario,
            string codigo, string detalle, decimal monto)
		{
			Id = id;
			IdOrden = idOrden;
			IdClasificador = idClasificador;
			TipoUsuario = tipoUsuario;
			Codigo = codigo;
			Detalle = detalle;
			Monto = monto;
		}

		#endregion

		#region Properties
	
		public long Id { get; set; }
		public long IdOrden { get; set; }
		public int IdClasificador { get; set; }
        public string TipoUsuario { get; set; }
		public string Codigo { get; set; }
		public string Detalle { get; set; }
		public Decimal Monto { get; set; }

		#endregion
    }
}
