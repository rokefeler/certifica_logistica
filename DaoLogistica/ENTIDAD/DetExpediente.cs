using System;

namespace DaoLogistica.ENTIDAD
{
    public class DetExpediente
    {
        #region Constructors

		public DetExpediente()
		{
		    Clear();
		}

		public DetExpediente(long idDetalleExp, string idExp, string codSubDepOrigen, 
            DateTime fechaRecepcion, string codPersonalOrigen, string idxEstadoExp, 
            string detalle, string idxTipoDeriva, string cargo, string codSubDepDestino, 
            DateTime fechaDeriva, string codPersonalDeriva, bool aceptado, string codLogin, DateTime fechaRegistro)
		{
			IdDetalleExp = idDetalleExp;
			IdExpediente = idExp;
			CodSubDepOrigen = codSubDepOrigen;
			FechaRecepcion = fechaRecepcion;
			CodPersonalOrigen = codPersonalOrigen;
			IdxEstadoExp = idxEstadoExp;
			Detalle = detalle;
			IdxTipoDeriva = idxTipoDeriva;
			Cargo = cargo;
			CodSubDepDestino = codSubDepDestino;
			FechaDeriva = fechaDeriva;
			CodPersonalDeriva = codPersonalDeriva;
			Aceptado = aceptado;
			CodLogin = codLogin;
			FechaRegistro = fechaRegistro;
		}
        public void Clear()
        {
            IdDetalleExp = 0;
            IdExpediente = String.Empty;
            CodSubDepOrigen = String.Empty;
            FechaRecepcion = new DateTime(1900,1,1);
            CodPersonalOrigen = String.Empty;
            IdxEstadoExp = String.Empty;
            Detalle = String.Empty;
            IdxTipoDeriva = String.Empty;
            Cargo = String.Empty;
            CodSubDepDestino = String.Empty;
            FechaDeriva = new DateTime(1900,1,1);
            CodPersonalDeriva = String.Empty;
            Aceptado = false;
            CodLogin = String.Empty;
            FechaRegistro = new DateTime(1900,1,1);
        }
		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdDetalleExp value.
		/// </summary>
		public long IdDetalleExp { get; set; }

		/// <summary>
		/// Gets or sets the IdExpLog value.
		/// </summary>
		public String IdExpediente{ get; set; }

		/// <summary>
		/// Gets or sets the CodSubDep_origen value.
		/// </summary>
		public string CodSubDepOrigen { get; set; }

		/// <summary>
		/// Gets or sets the FechaRecepcion value.
		/// </summary>
		public DateTime FechaRecepcion { get; set; }

		/// <summary>
		/// Gets or sets the CodPersonal_Origen value.
		/// </summary>
		public string CodPersonalOrigen { get; set; }

		/// <summary>
		/// Gets or sets the IdEstadoExp value.
		/// </summary>
		public String IdxEstadoExp { get; set; }

		/// <summary>
		/// Gets or sets the Detalle value.
		/// </summary>
		public string Detalle { get; set; }

		/// <summary>
		/// Gets or sets the IdxTipoDeriva value.
		/// </summary>
		public string IdxTipoDeriva { get; set; }

		/// <summary>
		/// Gets or sets the Cargo value.
		/// </summary>
		public string Cargo { get; set; }

		/// <summary>
		/// Gets or sets the CodSubDep_Destino value.
		/// </summary>
		public string CodSubDepDestino { get; set; }

		/// <summary>
		/// Gets or sets the FechaDeriva value.
		/// </summary>
		public DateTime FechaDeriva { get; set; }

		/// <summary>
		/// Gets or sets the CodPersonal_Deriva value.
		/// </summary>
		public string CodPersonalDeriva { get; set; }

		/// <summary>
		/// Gets or sets the Aceptado value.
		/// </summary>
		public bool Aceptado { get; set; }

		/// <summary>
		/// Gets or sets the CodLogin value.
		/// </summary>
		public string CodLogin { get; set; }

		/// <summary>
		/// Gets or sets the FechaRegistro value.
		/// </summary>
		public DateTime FechaRegistro { get; set; }

		#endregion
    }
}
