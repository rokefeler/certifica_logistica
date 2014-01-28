using System;

namespace DaoLogistica.ENTIDAD
{
	public class Login
	{
		#region Fields

		private string _codLogin;
		private string _codPersonal;
        private string _clave;
		private DateTime _ultimoAcceso;
		private string _preg01;
		private string _preg02;
	    private char _estado;
		private string _codLoginOri;

		#endregion

		#region Constructors
        public Login(string codLogin, string codPersonal, string clave, DateTime ultimoAcceso, string preg01, string preg02, char eStado, string codLoginOri)
        {
            _codLogin = codLogin;
            _codPersonal = codPersonal;
            _clave = clave;
            _ultimoAcceso = ultimoAcceso;
            _preg01 = preg01;
            _preg02 = preg02;
            _estado = eStado;
            _codLoginOri = codLoginOri;
        }

		public Login()
		{
            _codLogin = String.Empty;
            _codPersonal = String.Empty;
            _clave = null;
            _ultimoAcceso = DateTime.Now ;
            _preg01 = String.Empty ;
            _preg02 = String.Empty ;
            _codLoginOri = String.Empty;
		    _estado = 'A';
		}
        
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the CodLogin value.
		/// </summary>
		public virtual string CodLogin
		{
			get { return _codLogin; }
			set { _codLogin = value; }
		}

		/// <summary>
		/// Gets or sets the CodPersonal value.
		/// </summary>
		public virtual string CodPersonal
		{
			get { return _codPersonal; }
			set { _codPersonal = value; }
		}

		/// <summary>
		/// Gets or sets the Clave value.
		/// </summary>
		public virtual string Clave
		{
			get { return _clave; }
			set { _clave = value; }
		}

		/// <summary>
		/// Gets or sets the Ultimo_acceso value.
		/// </summary>
		public virtual DateTime UltimoAcceso
		{
			get { return _ultimoAcceso; }
			set { _ultimoAcceso = value; }
		}

		/// <summary>
		/// Gets or sets the Preg01 value.
		/// </summary>
		public virtual string Preg01
		{
			get { return _preg01; }
			set { _preg01 = value; }
		}

		/// <summary>
		/// Gets or sets the Preg02 value.
		/// </summary>
		public virtual string Preg02
		{
			get { return _preg02; }
			set { _preg02 = value; }
		}

        public virtual char Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
		/// <summary>
		/// Gets or sets the CodLogin_ori value.
		/// </summary>
		public virtual string CodLoginOri
		{
			get { return _codLoginOri; }
			set { _codLoginOri = value; }
		}
		#endregion
	}
}
