using System;
using System.Collections.Generic;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class MetaDao
    {

        public static Meta GetbyId(int codMeta)
        {
            if (codMeta<=0) throw new ArgumentNullException("codMeta");
            Meta obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdMeta", DbType.Int32, codMeta);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeMeta(dr);
                }
            }
            return obj;
        }

        public static Meta GetbyNroAnio(String cNro, String anio)
        {
            if (String.IsNullOrEmpty(cNro)) throw new ArgumentNullException("cNro");
            if (String.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            Meta obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById2);
            DATA.Db.AddInParameter(cmd, "cnro", DbType.String, cNro);
            DATA.Db.AddInParameter(cmd, "anio", DbType.String, anio);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeMeta(dr);
                }
            }
            return obj;
        }

        public static List<String> GetStringAllByAnio(String anio)
        {
            if (string.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            var tList = new List<String>();
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, 5121); 
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

        public static List<Meta> SelectAllByAnio(String anio)
        {
            if (string.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            var tList = new List<Meta>();
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, 5122);
            DATA.Db.AddInParameter(cmd, "anio", DbType.String, anio);
            using (var datareader = DATA.Db.ExecuteReader(cmd))
            {
                while (datareader.Read())
                {
                    var ts = MakeMeta(datareader);
                    tList.Add(ts);
                }

            }
            return tList;
        }


        public static DataSet FiltroByNombre(string cFil1 = null, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1) && String.IsNullOrEmpty(cfil2)) throw new ArgumentNullException("cFil1"); 
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroBy); //600
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "cFiltro1", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "cFiltro2", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static DataSet FiltroByPrograma(string cFil1 = null, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1) && String.IsNullOrEmpty(cfil2)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tMeta");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByPrograma); //608
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "cFiltro1", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "cFiltro2", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        protected static Meta MakeMeta(IDataReader dr)
        {
            var obj = new Meta
            {
                IdMeta = dr.GetInt32(dr.GetOrdinal("IdMeta")),
                Cnro = dr.GetString(dr.GetOrdinal("cnro")),
                Anio = dr.GetString(dr.GetOrdinal("anio")),
                Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                Dependencia = dr.GetString(dr.GetOrdinal("Dependencia")),
                Referencia = dr.GetString(dr.GetOrdinal("Referencia")),
                Unidad = dr.GetString(dr.GetOrdinal("Unidad")),
                Responsable = dr.GetString(dr.GetOrdinal("Responsable")),
                Cadena = dr.GetString(dr.GetOrdinal("Cadena"))
            };
            return obj;
        }

        
    }
}
