using System;

namespace DaoLogistica.ENTIDAD
{
    public class FuenteFinanciamiento
    {

		public FuenteFinanciamiento()
		{
            IdFuente = 0;
            Nombre = String.Empty;
            Abreviacion = String.Empty;
		}
		public FuenteFinanciamiento(short idFuente, string nombre, string abreviacion)
		{
			IdFuente = idFuente;
			Nombre = nombre;
			Abreviacion = abreviacion;
		}



		public short IdFuente { get; set; }
        public string Nombre { get; set; }
		public string Abreviacion { get; set; }


    }
}
