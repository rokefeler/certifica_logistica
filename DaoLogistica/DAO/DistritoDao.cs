using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class DistritoDao
	{

        public static int Grabar(Distrito tDistrito, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDistrito");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, tDistrito.CodDis);
            DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, tDistrito.CodProv);
            DATA.Db.AddInParameter(cmd, "Denomi", DbType.String, tDistrito.Nombre);

            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codDis, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDistrito");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, codDis);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Distrito GetbyId(String codDis)
        {
            Distrito obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDistrito");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, codDis);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeDistrito(dr);
                }
            }
            return obj;
        }

        public static DataSet GetAllByCodProv(String codProv)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDistrito");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, codProv);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Distrito> SelectGetAllGetbyCodProv(String codProv)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDistrito");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, codProv);

            using (IDataReader datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tDistritoList = new List<Distrito>();
                while (datareader.Read())
                {
                    Distrito tDistrito = MakeDistrito(datareader);
                    tDistritoList.Add(tDistrito);
                }
                return tDistritoList;
            }
        }
		
        protected static Distrito MakeDistrito(IDataReader dataReader)
        {
            var obj = new Distrito
            {
                CodDis = dataReader.IsDBNull(dataReader.GetOrdinal("codDis"))
                    ? String.Empty
                    : dataReader.GetString(dataReader.GetOrdinal("codDis")),
                CodProv = dataReader.IsDBNull(dataReader.GetOrdinal("CodProv"))
                    ? String.Empty
                    : dataReader.GetString(dataReader.GetOrdinal("CodProv")),
                Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre"))
                    ? String.Empty
                    : dataReader.GetString(dataReader.GetOrdinal("nombre")),
                NombreProv = dataReader.GetString(dataReader.GetOrdinal("nombreprov")),
                NombreDep = dataReader.GetString(dataReader.GetOrdinal("nombredep"))
            };
            return obj;
		}
        
	}
}
