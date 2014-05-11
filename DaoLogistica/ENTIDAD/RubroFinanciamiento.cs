using System;

namespace DaoLogistica.ENTIDAD
{
    public class RubroFinanciamiento
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the TbRubroFinanciamientoDTO class.
		/// </summary>
		public RubroFinanciamiento()
		{
            IdRubro = 0;
            Anio = String.Empty;
            IdFuente = 0;
            Codigo = String.Empty;
            Nombre = String.Empty;
            Descripcion = String.Empty;
		    Abreviacion = String.Empty;
		}

		/// <summary>
		/// Initializes a new instance of the TbRubroFinanciamientoDTO class.
		/// </summary>
		public RubroFinanciamiento(int idRubro, string anio, short idFuente, string codigo, string nombre, string descripcion, string abreviacion)
		{
			IdRubro = idRubro;
			Anio = anio;
			IdFuente = idFuente;
			Codigo = codigo;
			Nombre = nombre;
			Descripcion = descripcion;
		    Abreviacion = abreviacion;
		}

		#endregion

		#region Properties
		public int IdRubro { get; set; }
		public string Anio { get; set; }
		public short IdFuente { get; set; }
		public string Codigo { get; set; }
        public string Nombre { get; set; }
		public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
		#endregion
    }
}
