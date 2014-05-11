using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class DepartamentoDao
	{
	
	public static int Grabar(Departamento tDepartamento, DbTransaction dbTrans)
    {
	    var cmd = DATA.Db.GetStoredProcCommand("sp_tDepartamento");
	    DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
	    DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, tDepartamento.CodDep);
	    DATA.Db.AddInParameter(cmd, "Denomi", DbType.String, tDepartamento.Nombre );

	    DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
	    if (dbTrans != null)
	        DATA.Db.ExecuteNonQuery(cmd, dbTrans);
	    else
	        DATA.Db.ExecuteNonQuery(cmd);
	    var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
	    return ret; //devuelve el id único del registro
    }

        public static int Delete(String codDep, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDepartamento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, codDep);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Departamento GetbyId(String codDep)
        {
            Departamento obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDepartamento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, codDep);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeDepartamento(dr);
                }
            }
            return obj;
        }

        public static DataSet GetAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDepartamento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Departamento> SelectAll()
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDepartamento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            using (IDataReader  datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tDepartamentoList = new List<Departamento>();
                while (datareader.Read())
                {
                    Departamento tDepartamento = MakeDepartamento(datareader);
                    tDepartamentoList.Add(tDepartamento);
                }
                return tDepartamentoList;
            }
        }

		protected static Departamento MakeDepartamento(IDataReader dataReader)
		{
// ReSharper disable once UseObjectOrCollectionInitializer
		    var obj = new Departamento();
            obj.CodDep = dataReader.IsDBNull(dataReader.GetOrdinal("codDep"))
		        ? String.Empty
		        : dataReader.GetString(dataReader.GetOrdinal("codDep"));
		    obj.Nombre = dataReader.IsDBNull(dataReader.GetOrdinal("nombre"))
		        ? String.Empty
		        : dataReader.GetString(dataReader.GetOrdinal("nombre"));
			return obj;
		}

	}
}
