using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ObservacionExpedienteDao
    {
        public static int Grabar(ObservacionExpediente obj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAOBSV_EXPEDIENTE");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            if(obj.Id>0)
                DATA.Db.AddInParameter(cmd, "Id", DbType.Int64, obj.Id);
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, obj.IdExpediente);
            DATA.Db.AddInParameter(cmd, "Detalle", DbType.String, obj.Detalle);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int Delete(long id, String codLogin, DbTransaction dbTrans)
        {
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAOBSV_EXPEDIENTE");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico); //300
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int64, id);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static ObservacionExpediente GetbyId(int idObsv)
        {
            if (idObsv <= 0) throw new ArgumentNullException("idObsv");
            ObservacionExpediente obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAOBSV_EXPEDIENTE");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int32, idObsv);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeObservacionExpediente(dr);
                }
            }
            return obj;
        }

        public static DataSet GetAllExpediente(string idExpediente)
        {
            if (String.IsNullOrEmpty(idExpediente)) throw new ArgumentNullException("idExpediente");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAOBSV_EXPEDIENTE"); 
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll); //500
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, idExpediente);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<ObservacionExpediente> SelectAllExpediente(String idExpediente)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAOBSV_EXPEDIENTE");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll); //500
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, idExpediente);

            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tDataLst = new List<ObservacionExpediente>();
                while (dr.Read())
                {
                    var tobj = MakeObservacionExpediente(dr);
                    tDataLst.Add(tobj);
                }
                return tDataLst;
            }
        }

        protected static ObservacionExpediente MakeObservacionExpediente(IDataReader dr)
        {
            var obj = new ObservacionExpediente();
            obj.Id = dr.GetInt64(dr.GetOrdinal("Id"));
            obj.IdExpediente= dr.GetString(dr.GetOrdinal("IdExpediente"));
            obj.Fecha = dr.GetDateTime(dr.GetOrdinal("fecha"));
            obj.Detalle = dr.GetString(dr.GetOrdinal("Detalle"));
            obj.CodLogin= dr.GetString(dr.GetOrdinal("CodLogin"));
            obj.Eliminado = dr.GetBoolean(dr.GetOrdinal("Eliminado"));
            obj.CodLogin_Elimina = dr.GetString(dr.GetOrdinal("CodLogin_Elimina"));
            return obj;
        }
    }
}
