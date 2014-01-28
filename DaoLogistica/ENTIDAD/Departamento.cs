using System;

namespace DaoLogistica.ENTIDAD
{
	public class Departamento
	{
		public Departamento()
		{
            CodDep = String.Empty;
            Nombre = String.Empty;
		}

		public Departamento(string codDep, string nombre)
		{
			CodDep = codDep;
			Nombre = nombre;
		}
        
	    public string CodDep { get; set; }
	    public string Nombre { get; set; }

	}
}
