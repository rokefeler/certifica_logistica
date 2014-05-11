using System;

namespace DaoLogistica.ENTIDAD
{
	public class SubDependencia
	{

		#region Constructors
		public SubDependencia()
		{
		    Clear();
		}

	    private void Clear()
	    {
	        TieneInternet = '0';
	        Fecha = new DateTime(1900, 1, 1);
	        Telefono = String.Empty;
	        CodSubDep = String.Empty;
	        CodDependencia = String.Empty;
	        Nombre = String.Empty;
	        CodPersonal = String.Empty;
	        Estado = true;
	        Autorizacion = String.Empty;
	        FechaAut = new DateTime(1900, 1, 1);
	        Web = String.Empty;
	        Obsv = String.Empty;
	        Siglas = String.Empty;
	        IsConvenio = false;
	        CodLogin = String.Empty;
	        Email = String.Empty;
	        NombreDependencia = String.Empty;
	    }

	    public SubDependencia(string codSubDep, string codDependencia, string nombre, string codPersonal, 
            bool estado, string autorizacion, DateTime fechaAut, string telefono,string web, 
            string obsv, char tieneInternet, DateTime fecha, String siglas, bool isConvenio, String email )
		{
			CodSubDep = codSubDep;
			CodDependencia = codDependencia;
			Nombre = nombre;
			CodPersonal = codPersonal;
			Estado = estado;
			Autorizacion = autorizacion;
			FechaAut = fechaAut;
			Web = web;
			Obsv = obsv;
		    TieneInternet = tieneInternet;
		    Fecha = fecha;
		    Telefono = telefono;
		    Siglas = siglas;
		    IsConvenio = isConvenio;
	        Email = email;
	        CodLogin = @CodLogin;
		}

		#endregion

		#region Properties

	    public string CodSubDep { get; set; }
	    public string CodDependencia { get; set; }
        public string NombreDependencia { get; set; }
	    public string Nombre { get; set; }
	    public string CodPersonal { get; set; }
	    public bool Estado { get; set; }
	    public string Autorizacion { get; set; }
		public DateTime FechaAut  { get; set; }
	    public string Telefono { get; set; }
	    public string Web { get; set; }
	    public string Obsv { get; set; }
        public char TieneInternet { get; set; }
        public DateTime Fecha  { get; set; }
        public string Siglas { get; set; }
        public string Email { get; set; }
        public string CodLogin { get; set; }
        public bool IsConvenio { get; set; }
		#endregion
	}
}
