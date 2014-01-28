using System;

namespace DaoLogistica.ENTIDAD
{
	public class Provincia
	{
		#region Fields

		private string _codProv;
		private string _codDep;
		private string _nombre;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BETProvincia class.
		/// </summary>
		public Provincia()
		{
            _codProv = String.Empty;
            _codDep = String.Empty;
            _nombre = String.Empty;
		}

		/// <summary>
		/// Initializes a new instance of the BETProvincia class.
		/// </summary>
		public Provincia(string codProv, string codDep, string nombre)
		{
			_codProv = codProv;
			_codDep = codDep;
			_nombre = nombre;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodProv value.
		/// </summary>
		public virtual string CodProv
		{
			get { return _codProv; }
			set { _codProv = value; }
		}

		/// <summary>
		/// Gets or sets the CodDep value.
		/// </summary>
		public virtual string CodDep
		{
			get { return _codDep; }
			set { _codDep = value; }
		}

		/// <summary>
		/// Gets or sets the Denomi value.
		/// </summary>
		public virtual string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		#endregion
	}
}
