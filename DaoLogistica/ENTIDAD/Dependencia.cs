using System;

namespace DaoLogistica.ENTIDAD
{
	public class Dependencia
	{
		#region Constructors

		public Dependencia()
		{
            CodDependencia = String.Empty ;
            Nombre = String.Empty;
            IdxRubroDependencia = String.Empty;
            CodPersonal = String.Empty;
            Estado = true ;
            Siglas = String.Empty;
		}

	    public Dependencia(string codDependencia, string nombre, string idxRubroDependencia, string codPersonal,
	        bool estado, String siglas)
	    {
	        CodDependencia = codDependencia;
	        Nombre = nombre;
	        IdxRubroDependencia = idxRubroDependencia;
	        CodPersonal = codPersonal;
	        Estado = estado;
	        Siglas = siglas;
	    }

	    #endregion

		#region Properties
        public string CodDependencia { get; set; }
        public string Nombre { get; set; }
        public string IdxRubroDependencia { get; set; }
        public string CodPersonal { get; set; }
        public bool Estado { get; set; }
        public string Siglas { get; set; }
	    #endregion
	}
}
