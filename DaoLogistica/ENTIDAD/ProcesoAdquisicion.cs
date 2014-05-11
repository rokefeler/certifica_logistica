using System;

namespace DaoLogistica.ENTIDAD
{
    public class ProcesoAdquisicion
    {
        #region Constructors

		/// <summary>
		/// Initializes a new instance of the TProcesoAdquisicionDTO class.
		/// </summary>
		public ProcesoAdquisicion()
		{
            IdProceso = String.Empty;
			Proceso = String.Empty;
			Sigla = String.Empty;
		}

		/// <summary>
		/// Initializes a new instance of the TProcesoAdquisicionDTO class.
		/// </summary>
		public ProcesoAdquisicion(string idProceso, string proceso, string sigla)
		{
			IdProceso = idProceso;
			Proceso = proceso;
			Sigla = sigla;
		}

		#endregion

		#region Properties
		public string IdProceso { get; set; }
		public string Proceso { get; set; }
        public string Sigla { get; set; }

		#endregion
    }
}
