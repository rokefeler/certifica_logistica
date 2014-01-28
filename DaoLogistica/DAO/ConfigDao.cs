using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ConfigDao
    {
        public static int Grabar(Config tconfig, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_TConfig");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "Id", DbType.String, tconfig.Id);
            DATA.Db.AddInParameter(cmd, "Clave", DbType.String, tconfig.Clave);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(int id, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tConfig");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int32, id);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Config GetbyId(int id, string syn)
        {
            Config obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tConfig");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int32, id);
            DATA.Db.AddInParameter(cmd, "Syn", DbType.String, syn);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeConfig(dr);
                }
            }
            return obj;
        }
        
        public static DataSet GetAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tConfig");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        /// <summary>
        /// Devuelve Configuración De Aplicación, Todos los parametros indicados en DB
        /// </summary>
        /// <returns></returns>
        public static IDataReader GetAllConfig()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tConfig");
            DATA.Db.AddInParameter(cmd, "Syn", DbType.String, DATA.ClaveSyn);
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int32, 0);
            return DATA.Db.ExecuteReader(cmd);
        }
        public static List<Config> SelectAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tConfig");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tConfigList = new List<Config>();
                while (dr.Read())
                {
                    Config obj = MakeConfig(dr);
                    tConfigList.Add(obj);
                }
                return tConfigList;
            }
        }
		protected static Config MakeConfig(IDataReader dr)
		{
		    var obj = new Config
		    {
		        Id = dr.IsDBNull(dr.GetOrdinal("id")) ? 0 : dr.GetInt32(dr.GetOrdinal("id")),
		        Clave = dr.IsDBNull(dr.GetOrdinal("Clave")) ? String.Empty : dr.GetString(dr.GetOrdinal("Clave"))
		    };
			return obj;
		}


    }
}
