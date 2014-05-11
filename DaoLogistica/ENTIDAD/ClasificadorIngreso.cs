using System;

namespace DaoLogistica.ENTIDAD
{
    public class ClasificadorIngreso
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the TbClasificadorIngresoDTO class.
		/// </summary>
		public ClasificadorIngreso()
		{
            IdIngreso = 0;
            Anio = String.Empty;
            Clasificador = String.Empty;
            Descripcion = String.Empty;
            Detalle = String.Empty;
		}

		public ClasificadorIngreso(string anio, string clasificador, string descripcion, string detalle)
		{
            IdIngreso = 0;
            Anio = anio;
			Clasificador = clasificador;
			Descripcion = descripcion;
			Detalle = detalle;
		}

		public ClasificadorIngreso(int idIngreso, string anio, string clasificador, string descripcion, string detalle)
		{
			IdIngreso = idIngreso;
			Anio = anio;
			Clasificador = clasificador;
			Descripcion = descripcion;
			Detalle = detalle;
		}

		#endregion

		#region Properties
	public int IdIngreso { get; set; }
		public string Anio { get; set; }
		public string Clasificador { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }

		#endregion
    }
}
