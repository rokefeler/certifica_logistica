using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ExpedienteDao
    {

        public static int Grabar(Expediente obj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "Idexpediente", DbType.String, obj.Idexpediente);
            DATA.Db.AddInParameter(cmd, "FechaExp", DbType.DateTime, obj.FechaExp);
            DATA.Db.AddInParameter(cmd, "FechaIngreso", DbType.DateTime, obj.FechaIngreso);
            DATA.Db.AddInParameter(cmd, "CodSubDep_Origen", DbType.String, obj.CodSubDepOrigen);
            DATA.Db.AddInParameter(cmd, "CodSubDep_Entrega", DbType.String, obj.CodSubDepEntrega);
            DATA.Db.AddInParameter(cmd, "IdxTipoDocTra", DbType.String, obj.IdxTipoDocTra);
            DATA.Db.AddInParameter(cmd, "Nrodoc", DbType.String, obj.Nrodoc);
            DATA.Db.AddInParameter(cmd, "Asunto", DbType.String, obj.Asunto);
            DATA.Db.AddInParameter(cmd, "Moneda", DbType.String, obj.Moneda);
            DATA.Db.AddInParameter(cmd, "IdFuente", DbType.Int16, obj.IdFuente);
            DATA.Db.AddInParameter(cmd, "MontoAprobado", DbType.Decimal, obj.MontoAprobado);
            if (!String.IsNullOrEmpty(obj.CNroAuto))
                DATA.Db.AddInParameter(cmd, "cNroAuto", DbType.String, obj.CNroAuto);
            if (obj.IdRubro>0)
                DATA.Db.AddInParameter(cmd, "IdRubro", DbType.Int32, obj.IdRubro);
            if (obj.IdMeta > 0)
                DATA.Db.AddInParameter(cmd, "IdMeta", DbType.Int32, obj.IdMeta);
            if (!String.IsNullOrEmpty(obj.Ccp))
                DATA.Db.AddInParameter(cmd, "Ccp", DbType.String, obj.Ccp);
            DATA.Db.AddInParameter(cmd, "Folios", DbType.Int16, obj.Folios);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int Corregir(string expActual, string nuevoExp, int nLog, int anio, string codLogin, DbTransaction dbTrans)
        {
            if (String.IsNullOrEmpty(expActual)) throw new ArgumentNullException("expActual");
            if (String.IsNullOrEmpty(nuevoExp)) throw new ArgumentNullException("nuevoExp");
            if (nLog<=0 || anio<=0) throw new ArgumentNullException("nLog");
            if (String.IsNullOrEmpty(codLogin)) throw new ArgumentNullException("codLogin");
            if (dbTrans == null) throw new ArgumentNullException("dbTrans");
            
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.Corregir);//1001
            DATA.Db.AddInParameter(cmd, "Idexpediente", DbType.String, expActual);
            DATA.Db.AddInParameter(cmd, "IdexpedienteFinal", DbType.String, nuevoExp);
            DATA.Db.AddInParameter(cmd, "nLog", DbType.Int32, nLog);
            DATA.Db.AddInParameter(cmd, "Anio", DbType.Int32, anio);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id de respuesta
        }
        public static int Delete(long idExpLog, DbTransaction dbTrans)
        {
            if (idExpLog <=0) throw new ArgumentNullException("idExpLog");
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "IdExpLog", DbType.Int64, idExpLog);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Expediente GetbyId(string cIdExpediente)
        {
            if (String.IsNullOrEmpty(cIdExpediente)) throw new ArgumentNullException("cIdExpediente");
            Expediente obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, cIdExpediente);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeObj(dr);
                }
            }
            return obj;
        }
        public static Expediente GetbyId(long idExpLog)
        {
            if (idExpLog<=0) throw new ArgumentNullException("idExpLog");
            Expediente obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdExpLog", DbType.Int64, idExpLog);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeObj(dr);
                }
            }
            return obj;
        }
        
        public static DataSet FiltroByNroDocAsunto(string cFiltro, int anio, String cFiltro2)
        {
            if (String.IsNullOrEmpty(cFiltro)) throw new ArgumentNullException("cFiltro");
            if (anio<=0) throw new ArgumentNullException("anio");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByRazon); //601
            DATA.Db.AddInParameter(cmd, "@NroDoc", DbType.String, cFiltro);
            DATA.Db.AddInParameter(cmd, "@Anio", DbType.Int32, anio);
            if(!String.IsNullOrEmpty(cFiltro2))
                DATA.Db.AddInParameter(cmd, "@cFiltro2", DbType.String, cFiltro2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet FiltroByLog(String cLog, int anio)
        {
            if (String.IsNullOrEmpty(cLog)) throw new ArgumentNullException("cLog");
            if (anio <= 0) throw new ArgumentNullException("anio");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606 
            DATA.Db.AddInParameter(cmd, "@NroDoc", DbType.String, cLog);
            DATA.Db.AddInParameter(cmd, "@Anio", DbType.Int32, anio);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static DataSet FiltroBySubDependencia(string cFiltro, int anio, String cFiltro2)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByPersonal); //607
            DATA.Db.AddInParameter(cmd, "@NroDoc", DbType.String, cFiltro);
            DATA.Db.AddInParameter(cmd, "@Anio", DbType.Int32, anio);
            if(!String.IsNullOrEmpty(cFiltro2))
                DATA.Db.AddInParameter(cmd, "@Asunto", DbType.String, cFiltro2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        protected static Expediente MakeObj(IDataReader dr)
        {
            var obj = new Expediente
            {
                Idexpediente = dr.GetString(dr.GetOrdinal("IdExpediente")),
                FechaExp = dr.GetDateTime(dr.GetOrdinal("FechaExp")),
                FechaIngreso = dr.GetDateTime(dr.GetOrdinal("FechaIngreso")),
                CodSubDepOrigen = dr.GetString(dr.GetOrdinal("CodSubDep_Origen")),
                CodSubDepEntrega = dr.GetString(dr.GetOrdinal("CodSubDep_Entrega")),
                IdxTipoDocTra = dr.GetString(dr.GetOrdinal("IdxTipoDocTra")),
                Nrodoc = dr.GetString(dr.GetOrdinal("NroDoc")),
                Asunto = dr.GetString(dr.GetOrdinal("Asunto")),
                Moneda = Convert.ToChar(dr.GetValue(dr.GetOrdinal("Moneda"))),
                MontoAprobado = dr.GetDecimal(dr.GetOrdinal("MontoAprobado")),
                CNroAuto = dr.GetString(dr.GetOrdinal("cNroAuto")),
                IdRubro = dr.GetInt32(dr.GetOrdinal("IdRubro")),
                IdMeta = dr.GetInt32(dr.GetOrdinal("IdMeta")),
                Ccp = dr.GetString(dr.GetOrdinal("ccp")),
                Folios = dr.GetInt16(dr.GetOrdinal("Folios")),
                IdFuente = dr.GetInt16(dr.GetOrdinal("IdFuente")),
                CodLogin = dr.GetString(dr.GetOrdinal("CodLogin")),
                FechaRegistro = dr.GetDateTime(dr.GetOrdinal("FechaRegistro")),
                Nlog = dr.GetInt32(dr.GetOrdinal("nLog")),
                Anio = dr.GetInt32(dr.GetOrdinal("Anio")),
                Estado = Convert.ToChar(dr.GetValue(dr.GetOrdinal("Estado")))
            };
            return obj;
        }

        public static bool ExisteById(String idExpediente)
        {
            if (String.IsNullOrEmpty(idExpediente)) throw new ArgumentNullException("idExpediente");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "idExpediente", DbType.String, idExpediente);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
    }
}

