using System;

namespace DaoLogistica.ENTIDAD
{
	public class Codigo
	{
	    #region Constructors
		public Codigo()
		{
            Id = String.Empty ;
            CodTipo = String.Empty;
            Nombre = String.Empty;
            Referencia = String.Empty;
            Descrip = String.Empty;
            Num = 0;
            Estado = false;
		}

		/// <summary>
		/// Initializes a new instance of the BETCodigo class.
		/// </summary>
		public Codigo(string codigo, string codTipo, string nombre, string referencia, string descrip, int num, bool estado)
		{
			Id = codigo;
			CodTipo = codTipo;
			Nombre = nombre;
			Referencia = referencia;
			Descrip = descrip;
			Num = num;
			Estado = estado;
		}

		#endregion

		#region Properties

	    public string Id { get; set; }
	    public string CodTipo { get; set; }
	    public string Nombre { get; set; }
	    public string Referencia { get; set; }
	    public string Descrip { get; set; }
        public int Num { get; set; }
        public bool Estado { get; set; }

	    #endregion
	}
}
