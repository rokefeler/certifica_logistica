using System;

namespace DaoLogistica.ENTIDAD
{
    public class Expediente
    {
        #region Constructors

		public Expediente()
		{
            Clear();
		}

	
		public Expediente(string idexpediente, DateTime fechaExp, DateTime fechaIngreso, 
            string codSubDepOrigen, string idxTipoDocTra, string nrodoc, string asunto, char moneda, 
            decimal montoAprobado, string cNroAuto, int idRubro, int idMeta, string ccp, short folios, short idfuente, 
            string codLogin, DateTime fechaRegistro)
		{
            Idexpediente = idexpediente;
            FechaExp = fechaExp;
            FechaIngreso = fechaIngreso;
            CodSubDepOrigen = codSubDepOrigen;
            IdxTipoDocTra = idxTipoDocTra;
            Nrodoc = nrodoc;
            Asunto = asunto;
            Moneda = moneda;
            MontoAprobado = montoAprobado;
            CNroAuto = cNroAuto;
            IdRubro = idRubro;
            IdMeta = idMeta;
            Ccp = ccp;
            Folios = folios;
            CodLogin = codLogin;
            FechaRegistro = fechaRegistro;
		    IdFuente = idfuente;
		}

        public void Clear()
        {
            var fecha = new DateTime(1900, 1, 1);
            Idexpediente = String.Empty;
            FechaExp = fecha;
            FechaIngreso = fecha;
            CodSubDepOrigen = String.Empty;
            IdxTipoDocTra = String.Empty;
            Nrodoc = String.Empty;
            Asunto = String.Empty;
            Moneda = 'S';
            MontoAprobado = 0m;
            CNroAuto = String.Empty;
            IdRubro = 0;
            IdMeta = 0;
            Ccp = String.Empty;
            Folios = 0;
            CodLogin = String.Empty;
            FechaRegistro = fecha;
            IdFuente = 0;
        }
		#endregion

		#region Properties

	    public string Idexpediente { get; set; }

		public DateTime FechaExp { get; set; }

		public DateTime FechaIngreso { get; set; }

		public string CodSubDepOrigen { get; set; }

		public string IdxTipoDocTra { get; set; }

		public string Nrodoc { get; set; }

		public string Asunto { get; set; }

		public char Moneda { get; set; }

		public decimal MontoAprobado { get; set; }

		
		public string CNroAuto { get; set; }

		public int IdRubro { get; set; }

		public int IdMeta { get; set; }

		public string Ccp { get; set; }

		public short Folios { get; set; }

		public string CodLogin { get; set; }

		public DateTime FechaRegistro { get; set; }
        public short IdFuente { get; set; }
		#endregion
    }
}
