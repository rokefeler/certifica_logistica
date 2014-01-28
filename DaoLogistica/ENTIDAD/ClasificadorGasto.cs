namespace DaoLogistica.ENTIDAD
{
    public class ClasificadorGasto
        {
        #region Constructors

		public ClasificadorGasto()
		{
		}

		public ClasificadorGasto(string anio, string clasificador, string descripcion, string detalle)
		{
		    IdClasificador = 0;
            Anio = anio;
			Clasificador = clasificador;
			Descripcion = descripcion;
			Detalle = detalle;
		}

		public ClasificadorGasto(int idClasificador, string anio, string clasificador, string descripcion, string detalle)
		{
			IdClasificador = idClasificador;
			Anio = anio;
			Clasificador = clasificador;
			Descripcion = descripcion;
			Detalle = detalle;
		}

		#endregion

		#region Properties
		public int IdClasificador { get; set; }
		public string Anio { get; set; }
		public string Clasificador { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }

		#endregion
    }
}
