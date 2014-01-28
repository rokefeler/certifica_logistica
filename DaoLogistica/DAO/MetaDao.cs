using System;
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
            var obj = new Meta();
            obj.IdMeta = dr.GetInt32(dr.GetOrdinal("IdMeta"));
            obj.Cnro = dr.GetString(dr.GetOrdinal("cnro"));
            obj.Anio = dr.GetString(dr.GetOrdinal("anio"));
            obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
            obj.Dependencia = dr.GetString(dr.GetOrdinal("Dependencia"));
            obj.Referencia = dr.GetString(dr.GetOrdinal("Referencia"));
            obj.Unidad = dr.GetString(dr.GetOrdinal("Unidad"));
            obj.Responsable = dr.GetString(dr.GetOrdinal("Responsable"));
            obj.Cadena = dr.GetString(dr.GetOrdinal("Cadena"));
            return obj;
        }

        
    }
}
