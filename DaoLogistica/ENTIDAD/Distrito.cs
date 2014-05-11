using System;

namespace DaoLogistica.ENTIDAD
{
	public class Distrito
	{
		#region Fields

		private string _codDis;
		private string _codProv;
		private string _nombre;
        private string _nombreProv;
	    private string _nombreDep;

	    #endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BETDistrito class.
		/// </summary>
		public Distrito()
		{
            _codDis = String.Empty;
            _codProv = String.Empty;
            _nombre = String.Empty;
            _nombreDep = String.Empty;
            _nombreProv = String.Empty;
		}

		/// <summary>
		/// Initializes a new instance of the BETDistrito class.
		/// </summary>
		public Distrito(string codDis, string codProv, string nombre, string nombredep, string nombreprov)
		{
			_codDis = codDis;
			_codProv = codProv;
			_nombre = nombre;
		    _nombreDep = nombredep;
		    _nombreProv = nombreprov;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodDis value.
		/// </summary>
		public virtual string CodDis
		{
			get { return _codDis; }
			set { _codDis = value; }
		}

		/// <summary>
		/// Gets or sets the CodProv value.
		/// </summary>
		public virtual string CodProv
		{
			get { return _codProv; }
			set { _codProv = value; }
		}

		/// <summary>
		/// Gets or sets the Denomi value.
		/// </summary>
		public virtual string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
        public virtual string NombreDep
        {
            get { return _nombreDep; }
            set { _nombreDep = value; }
        }
        public virtual string NombreProv
        {
            get { return _nombreProv; }
            set { _nombreProv = value; }
        }

        public virtual string NombreCompleto
        {
            get { return _nombreDep + "-" + _nombreProv + "-" + _nombre; }
        }

		#endregion
	}
}
