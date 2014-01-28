using System;

namespace DaoLogistica.ENTIDAD
{
	public class Numero
	{
		#region Fields

		private string _codTipo;
		private string _descrip;
		private int _num;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BETNumero class.
		/// </summary>
		public Numero()
		{
            _codTipo = String.Empty;
            _descrip = String.Empty;
            _num = 0;
		}

		/// <summary>
		/// Initializes a new instance of the BETNumero class.
		/// </summary>
		public Numero(string codTipo, string descrip, int num)
		{
			_codTipo = codTipo;
			_descrip = descrip;
			_num = num;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodTipo value.
		/// </summary>
		public virtual string CodTipo
		{
			get { return _codTipo; }
			set { _codTipo = value; }
		}

		/// <summary>
		/// Gets or sets the Descrip value.
		/// </summary>
		public virtual string Descrip
		{
			get { return _descrip; }
			set { _descrip = value; }
		}

		/// <summary>
		/// Gets or sets the Num value.
		/// </summary>
		public virtual int Num
		{
			get { return _num; }
			set { _num = value; }
		}

		#endregion
	}
}
