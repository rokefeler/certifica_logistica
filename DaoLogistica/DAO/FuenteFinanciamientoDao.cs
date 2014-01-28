using System;
using System.Collections.Generic;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class FuenteFinanciamientoDao
    {
        public static FuenteFinanciamiento GetbyId(short id)
        {
            if (id <= 0) throw new ArgumentNullException("id");
            FuenteFinanciamiento obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_FuenteFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdFuente", DbType.Int16, id);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeFuenteFinanciamiento(dr);
                }
            }
            return obj;
        }

        public static DataSet GetByAll()
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_FuenteFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll); //500
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<FuenteFinanciamiento> SelectAll()
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_FuenteFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll); //500
            using (var datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tData = new List<FuenteFinanciamiento>();
                while (datareader.Read())
                {
                    var t = MakeFuenteFinanciamiento(datareader);
                    tData.Add(t);
                }
                return tData;
            }
        }
        protected static FuenteFinanciamiento MakeFuenteFinanciamiento(IDataReader dr)
        {
            var obj = new FuenteFinanciamiento
            {
                IdFuente = dr.GetInt16(dr.GetOrdinal("IdFuente")),
                Nombre = dr.GetString(dr.GetOrdinal("nombre")),
                Abreviacion = dr.GetString(dr.GetOrdinal("abreviacion"))
            };
            return obj;
        }

    }
}
