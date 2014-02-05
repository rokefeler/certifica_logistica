using System;
using System.Collections.Generic;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ClasificadorGastoDao
    {

        public static ClasificadorGasto GetbyId(int iDClasificador)
        {
            if (iDClasificador <= 0) throw new ArgumentNullException("iDClasificador");
            ClasificadorGasto obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tClasificadorGasto");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdClasificadorGasto", DbType.Int32, iDClasificador);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeClasificadorGasto(dr);
                }
            }
            return obj;
        }

        public static List<ClasificadorGasto> SelectAllByAnio(String anio)
        {
            if (string.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tClasificadorGasto");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, 5121); //5121
            DATA.Db.AddInParameter(cmd, "anio", DbType.String, anio);
            using (var datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tList = new List<ClasificadorGasto>();
                while (datareader.Read())
                {
                    var tCodigo = MakeClasificadorGasto(datareader);
                    tList.Add(tCodigo);
                }
                return tList;
            }
        }
        public static List<String> GetStringAllByAnio(String anio)
        {
            if (string.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            var tList = new List<String>();
            var cmd = DATA.Db.GetStoredProcCommand("sp_tClasificadorGasto");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, 512); //5122
            DATA.Db.AddInParameter(cmd, "anio", DbType.String, anio);
            using (var datareader = DATA.Db.ExecuteReader(cmd))
            {
                while (datareader.Read())
                {
                    var ts = datareader.GetString(1);
                    tList.Add(ts);
                }
                
            }
            return tList;
        }



        public static DataSet FiltroByNombre(string cFil1 = null, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1) && String.IsNullOrEmpty(cfil2)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tClasificadorGasto");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroBy); //600
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "cFiltro1", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "cFiltro2", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

       

        protected static ClasificadorGasto MakeClasificadorGasto(IDataReader dr)
        {
            var obj = new ClasificadorGasto
            {
                IdClasificador = dr.GetInt32(dr.GetOrdinal("IdClasificador")),
                Anio = dr.GetString(dr.GetOrdinal("anio")),
                Clasificador = dr.GetString(dr.GetOrdinal("Clasificador")),
                Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                Detalle = dr.GetString(dr.GetOrdinal("Detalle"))
            };
            return obj;
        }


    }
}
