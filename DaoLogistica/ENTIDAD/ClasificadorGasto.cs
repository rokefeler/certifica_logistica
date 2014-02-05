using System;

namespace DaoLogistica.ENTIDAD
{
    public class ClasificadorGasto
        {
        public ClasificadorGasto(string anio, string clasificador, string descripcion, string detalle, int idClasificador)
        {
            Anio = anio;
            Clasificador = clasificador;
            Descripcion = descripcion;
            Detalle = detalle;
            IdClasificador = idClasificador;
        }
        public ClasificadorGasto()
        {
            Clear();
        }

        public void Clear()
        {
            Anio = String.Empty;
            Clasificador = String.Empty;
            Descripcion = String.Empty;
            Detalle = String.Empty;
            IdClasificador = 0;
        }
        
		#region Properties
		public int IdClasificador { get; set; }
		public string Anio { get; set; }
		public string Clasificador { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }

		#endregion
    }
}
