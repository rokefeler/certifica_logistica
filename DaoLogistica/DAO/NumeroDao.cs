using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class NumeroDao
	{
        public static int Grabar(Numero tNumero, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tNumero");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "CodTipo", DbType.String, tNumero.CodTipo);
            DATA.Db.AddInParameter(cmd, "Descrip", DbType.String, tNumero.Descrip);
            DATA.Db.AddInParameter(cmd, "num", DbType.Int32, tNumero.Num);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codTipo, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tNumero");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodTipo", DbType.String, codTipo);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Numero GetbyId(String codTipo)
        {
            Numero obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tNumero");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodTipo", DbType.String, codTipo);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeNumero(dr);
                }
            }
            return obj;
        }

        public static DataSet GetAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tNumero");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Numero> SelectAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tNumero");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tNumeroList = new List<Numero>();
                while (dr.Read())
                {
                    var tDerecho = MakeNumero(dr);
                    tNumeroList.Add(tDerecho);
                }
                return tNumeroList;
            }
        }
		protected static Numero MakeNumero(IDataReader dr)
		{
		    var obETNumero = new Numero
		    {
		        CodTipo = dr.IsDBNull(dr.GetOrdinal("codTipo")) ? String.Empty : dr.GetString(dr.GetOrdinal("codTipo")),
		        Descrip = dr.IsDBNull(dr.GetOrdinal("descrip")) ? String.Empty : dr.GetString(dr.GetOrdinal("descrip")),
		        Num = dr.IsDBNull(dr.GetOrdinal("num")) ? 0 : dr.GetInt32(dr.GetOrdinal("num"))
		    };

			return obETNumero;
		}
	}
}
