using System;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class RubroFinanciamientoDao
    {

        public static RubroFinanciamiento GetbyId(int codRubro)
        {
            if (codRubro <= 0) throw new ArgumentNullException("codRubro");
            RubroFinanciamiento obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tRubroFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdRubro", DbType.Int32, codRubro);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeRubro(dr);
                }
            }
            return obj;
        }

        public static RubroFinanciamiento GetbyNroAnio(String cNro, String anio)
        {
            if (String.IsNullOrEmpty(cNro)) throw new ArgumentNullException("cNro");
            if (String.IsNullOrEmpty(anio)) throw new ArgumentNullException("anio");
            RubroFinanciamiento obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tRubroFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById2); //512
            DATA.Db.AddInParameter(cmd, "codigo", DbType.String, cNro);
            DATA.Db.AddInParameter(cmd, "anio", DbType.String, anio);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeRubro(dr);
                }
            }
            return obj;
        }




        public static DataSet FiltroByNombre(string cFil1 = null, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1) && String.IsNullOrEmpty(cfil2)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tRubroFinanciamiento");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroBy); //600
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "cFiltro1", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "cFiltro2", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        protected static RubroFinanciamiento MakeRubro(IDataReader dr)
        {
            var obj = new RubroFinanciamiento();
            obj.IdRubro  = dr.GetInt32(dr.GetOrdinal("idRubro"));
            obj.Anio = dr.GetString(dr.GetOrdinal("anio"));
            obj.IdFuente = dr.GetInt16(dr.GetOrdinal("idFuente"));
            obj.Codigo = dr.GetString(dr.GetOrdinal("codigo"));
            obj.Nombre = dr.GetString(dr.GetOrdinal("nombre"));
            obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
            obj.Abreviacion = dr.GetString(dr.GetOrdinal("abreviacion"));
            
            return obj;
        }

    }
}
