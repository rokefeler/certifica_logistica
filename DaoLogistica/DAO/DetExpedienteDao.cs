using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class DetExpedienteDao
    {

        public static int GrabarInicial(DetExpediente obj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertDefecto); //103
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, obj.IdExpediente);
            DATA.Db.AddInParameter(cmd, "CodSubDep_Origen", DbType.String, obj.CodSubDepOrigen);
            DATA.Db.AddInParameter(cmd, "FechaRecepcion", DbType.DateTime, obj.FechaRecepcion);
            DATA.Db.AddInParameter(cmd, "CodPersonal_Origen", DbType.String, obj.CodPersonalOrigen);
            DATA.Db.AddInParameter(cmd, "IdxEstadoExp", DbType.String, obj.IdxEstadoExp);
            DATA.Db.AddInParameter(cmd, "Detalle", DbType.String, obj.Detalle);
            DATA.Db.AddInParameter(cmd, "cargo", DbType.String, obj.Cargo);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int Derivar(DetExpediente obj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertDerivar); //104   
            DATA.Db.AddInParameter(cmd, "IdDetalleExp", DbType.Int64, obj.IdDetalleExp);
            DATA.Db.AddInParameter(cmd, "IdxEstadoExp", DbType.String, obj.IdxEstadoExp);
            DATA.Db.AddInParameter(cmd, "Detalle", DbType.String, obj.Detalle);
            DATA.Db.AddInParameter(cmd, "IdxTipoDeriva", DbType.String, obj.IdxTipoDeriva);
            //DATA.Db.AddInParameter(cmd, "cargo", DbType.String, obj.Cargo);
            DATA.Db.AddInParameter(cmd, "CodSubDep_Destino", DbType.String, obj.CodSubDepDestino);
            DATA.Db.AddInParameter(cmd, "FechaDeriva", DbType.DateTime, obj.FechaDeriva);
            DATA.Db.AddInParameter(cmd, "CodPersonal_Deriva", DbType.String, obj.CodPersonalDeriva);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int Delete(long idDetalleExp, DbTransaction dbTrans)
        {
            if (idDetalleExp <= 0) throw new ArgumentNullException("idExpLog");
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "IdDetalleExp", DbType.Int64, idDetalleExp);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }
        public static DetExpediente GetbyId(long idDetalleExp)
        {
            if (idDetalleExp <= 0) throw new ArgumentNullException("idDetalleExp");
            DetExpediente obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdDetalleExp", DbType.Int64, idDetalleExp);
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
        public static DataSet FiltroByNroDocAsunto(string cFiltro, String anio)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606
            DATA.Db.AddInParameter(cmd, "NroDoc", DbType.String, cFiltro);
            DATA.Db.AddInParameter(cmd, "IdDetExpediente", DbType.String, anio);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        protected static DetExpediente MakeObj(IDataReader dr)
        {
            var obj = new DetExpediente();
            obj.IdDetalleExp= dr.GetInt64(dr.GetOrdinal("IdDetExpediente"));
            obj.IdExpediente= dr.GetString(dr.GetOrdinal("IdExpediente"));
            obj.CodSubDepOrigen = dr.GetString(dr.GetOrdinal("CodSubDep_Origen"));
            obj.FechaRecepcion = dr.IsDBNull(dr.GetOrdinal("FechaRecepcion"))
                ? new DateTime(1900, 1, 1)
                : dr.GetDateTime(dr.GetOrdinal("FechaRecepcion"));
            
            
            obj.CodPersonalOrigen = dr.GetString(dr.GetOrdinal("CodPersonal_Origen"));
            obj.IdxEstadoExp = dr.GetString(dr.GetOrdinal("IdxEstadoExp"));
            obj.Detalle = dr.GetString(dr.GetOrdinal("Detalle"));
            obj.IdxTipoDeriva = dr.GetString(dr.GetOrdinal("IdxTipoDeriva"));
            obj.Cargo = dr.GetString(dr.GetOrdinal("Cargo"));
            obj.CodSubDepDestino = dr.GetString(dr.GetOrdinal("CodSubDep_Destino"));
            obj.FechaDeriva = dr.IsDBNull(dr.GetOrdinal("FechaDeriva"))
                ? new DateTime(1900, 1, 1)
                : dr.GetDateTime(dr.GetOrdinal("FechaDeriva"));
            obj.CodPersonalDeriva = dr.GetString(dr.GetOrdinal("CodPersonal_Deriva"));
            obj.Aceptado = dr.GetBoolean(dr.GetOrdinal("Aceptado"));
            obj.CodLogin = dr.GetString(dr.GetOrdinal("CodLogin"));
            obj.FechaRegistro = dr.GetDateTime(dr.GetOrdinal("FechaRegistro"));
            return obj;
        }
        public static bool ExisteById(long idDetExp)
        {
            if (idDetExp <= 0) throw new ArgumentNullException("idDetExp");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TDetExpediente");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "IdDetalleExp", DbType.Int64, idDetExp);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
    }
}

