﻿using System;

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
            string codSubDepOrigen, string codSubdepEntrega, string idxTipoDocTra, string nrodoc, string asunto, char moneda, 
            decimal montoAprobado, string cNroAuto, int idRubro, int idMeta, string ccp, short folios, short idfuente, 
            string codLogin, DateTime fechaRegistro, int nlog, int anio)
		{
            Idexpediente = idexpediente;
            FechaExp = fechaExp;
            FechaIngreso = fechaIngreso;
            CodSubDepOrigen = codSubDepOrigen;
		    CodSubDepEntrega = codSubdepEntrega;
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
		    Nlog = nlog;
		    Estado = '1';
		    Anio = anio;
		}

        public void Clear()
        {
            var fecha = new DateTime(1900, 1, 1);
            Idexpediente = String.Empty;
            FechaExp = fecha;
            FechaIngreso = fecha;
            CodSubDepOrigen = String.Empty;
            CodSubDepEntrega = String.Empty;
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
            Nlog = 0;
            Estado = '1';
            Anio = 0;
        }
		#endregion

		#region Properties

	    public string Idexpediente { get; set; }

		public DateTime FechaExp { get; set; }

		public DateTime FechaIngreso { get; set; }

		public string CodSubDepOrigen { get; set; }
        /// <summary>
        /// SubDependencia que Entrega el Expediente en Mesa de Partes
        /// </summary>
        public string CodSubDepEntrega { get; set; }
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
        /// <summary>
        /// Numero de Log. Interno
        /// </summary>
        public int Nlog { get; set; }
        /// <summary>
        /// Año del Log
        /// </summary>
        public int Anio { get; set; }
        /// <summary>
        /// Estado [0=Anulado, 1=Vigente, 2=Bloqueado con O/S, 3=Bloqueo total, 4=etc ]
        /// </summary>
        public char Estado { get; set; }
		#endregion
    }
}
