using System;

namespace DaoLogistica.ENTIDAD
{
    public class Meta
    {
#region Constructors

		public Meta()
		{
            IdMeta = 0;
		    Cnro = String.Empty;
            Anio = String.Empty;
            Descripcion = String.Empty;
            Dependencia = String.Empty;
            Referencia = String.Empty;
            Unidad = String.Empty;
            Responsable = String.Empty;
		    Cadena = String.Empty;
		}

		public Meta(int idMeta, string cnro, string anio, string descripcion, string dependencia, string referencia, string unidad, string responsable, String cadena)
		{
			IdMeta = idMeta;
		    Cnro = cnro;
			Anio = anio;
			Descripcion = descripcion;
			Dependencia = dependencia;
			Referencia = referencia;
			Unidad = unidad;
			Responsable = responsable;
		    Cadena = cadena;
		}

		#endregion

		#region Properties
		public int IdMeta { get; set; }
        public string Cnro { get; set; }
        public string Anio { get; set; }
		public string Descripcion { get; set; }
        public string Dependencia { get; set; }
        public string Referencia { get; set; }
		public string Unidad { get; set; }
        public string Responsable { get; set; }
        public string Cadena { get; set; }
		#endregion
    }
}
