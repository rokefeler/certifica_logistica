using System;

namespace DaoLogistica.ENTIDAD
{
	public class Personal
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BETPersonal class.
		/// </summary>
		public Personal()
		{
            CodPersonal = String.Empty;
            Ape = String.Empty;
            Nom = String.Empty;
            Direc = String.Empty;
            IdxTipoDoc = String.Empty;
            NroDocIden = String.Empty;
            Fecnac = new DateTime(1900,1,1);
            Email = String.Empty;
            Movil = String.Empty;
            Nrofijo = String.Empty;
            CodDis = String.Empty;
            IdFotoDbExt = 0;
            IdxCategoria = String.Empty;
            IdxCondicion = String.Empty ;
		    CodSubDep = String.Empty;
		}

		public Personal(string codPersonal, string ape, string nom, string direc, string idcTipoDoc, 
            string nroDocIden, DateTime fecnac, string email, string movil, string nrofijo, 
            string codDis, int idFotoDbExt, string idcCategoria, string idcCondicion, string codsubdep)
		{
			CodPersonal = codPersonal;
			Ape = ape;
			Nom = nom;
			Direc = direc;
			IdxTipoDoc = idcTipoDoc;
			NroDocIden = nroDocIden;
			Fecnac = fecnac;
			Email = email;
			Movil = movil;
			Nrofijo = nrofijo;
			CodDis = codDis;
			IdFotoDbExt = idFotoDbExt;
		    IdxCategoria = idcCategoria;
            IdxCondicion = idcCondicion;
		    CodSubDep = codsubdep;
		}

		#endregion

		#region Properties

	    public string CodPersonal { get; set; }

	    public string Ape { get; set; }

        public string Nom { get; set; }

	    public string RazonSocial
	    {
	        get { return Ape + ", " + Nom; }
	    }

	    public string Direc { get; set; }

	    public string IdxTipoDoc { get; set; }

	    public string NroDocIden { get; set; }

        public DateTime Fecnac { get; set; }
		
	    public string Email { get; set; }

	    public string Movil { get; set; }

	    public string Nrofijo { get; set; }

	    public string CodDis { get; set; }

	    public int IdFotoDbExt { get; set; }

	    public string IdxCategoria { get; set; }

	    public string IdxCondicion { get; set; }
        public string CodSubDep { get; set; }
	    #endregion
	}
}
