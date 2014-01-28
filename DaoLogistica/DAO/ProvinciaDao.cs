using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class ProvinciaDao
	{
	
		public static int Grabar(Provincia tProvincia, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            try
            {
                DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tProvincia");
                DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
                DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, tProvincia.CodProv);
                DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, tProvincia.CodDep);
                DATA.Db.AddInParameter(cmd, "Denomi", DbType.String, tProvincia.Nombre );

                DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
                if (dbTrans != null)
                    DATA.Db.ExecuteNonQuery(cmd, dbTrans);
                else
                    DATA.Db.ExecuteNonQuery(cmd);
                ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            }
// ReSharper disable once RedundantCatchClause
            catch //Volver a producir Excepcion en Control Maestro.
            {
                throw;
            }
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codProv, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tProvincia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, codProv);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Provincia GetbyId(String codProv)
        {
            Provincia obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tProvincia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodProv", DbType.String, codProv);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeProvincia(dr);
                }
            }
            return obj;
        }

        public static DataSet GetAllByDepartamento(String codDep)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tProvincia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, codDep);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Provincia> SelectGetAllGetbyCodDep(String codDep)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tProvincia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodDep", DbType.String, codDep);

            using (IDataReader  datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tProvinciaList = new List<Provincia>();
                while (datareader.Read())
                {
                    Provincia tProvincia = MakeProvincia(datareader);
                    tProvinciaList.Add(tProvincia);
                }
                return tProvinciaList;
            }
        }
		protected static Provincia MakeProvincia(IDataReader dataReader)
		{
		    var obETProvincia = new Provincia
		    {
		        CodProv =dataReader.IsDBNull(dataReader.GetOrdinal("CodProv"))
		                ? String.Empty
		                : dataReader.GetString(dataReader.GetOrdinal("CodProv")),
		        CodDep =dataReader.IsDBNull(dataReader.GetOrdinal("codDep"))
		                ? String.Empty
		                : dataReader.GetString(dataReader.GetOrdinal("codDep")),
		        Nombre =dataReader.IsDBNull(dataReader.GetOrdinal("nombre"))
		                ? String.Empty
		                : dataReader.GetString(dataReader.GetOrdinal("nombre"))
		    };

			return obETProvincia;
		}


	}
}
