using System;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ServiciosDao
    {
        public static Servicios GetbyId(String nroservicio)
        {
            if (string.IsNullOrEmpty(nroservicio)) throw new ArgumentNullException("nroservicio");
            Servicios obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "numero", DbType.String, nroservicio);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {if (dr.Read())
                {
                    obj = Make(dr);
                }
            }
            return obj;
        }
        public static DataSet FiltroByRazon(string cFil1, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByRazon); //601
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "Autorizacion", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "Cese", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet FiltroByAutorizacion(string cFil1, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "Autorizacion", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "Cese", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        protected static Servicios Make(IDataReader dr)
        {
            var obj = new Servicios();
            obj.Numero = dr.GetString(dr.GetOrdinal("numero"));
            obj.TipoServicio = dr.GetString(dr.GetOrdinal("TipoServicio"));
            obj.CodSubDep = dr.GetString(dr.GetOrdinal("CodSubDep"));
            obj.Responsable = dr.GetString(dr.GetOrdinal("Responsable"));
            obj.Meta = dr.GetInt32(dr.GetOrdinal("Meta"));
            obj.Rpm = dr.GetString(dr.GetOrdinal("Rpm"));
            obj.Tipoplan = dr.GetString(dr.GetOrdinal("TipoPlan"));
            obj.Estado = Convert.ToChar(dr.GetValue(dr.GetOrdinal("Estado")));
            obj.Ruc = dr.GetString(dr.GetOrdinal("Ruc"));
            obj.Fecha = dr.IsDBNull(dr.GetOrdinal("fecha"))
                    ? new DateTime(1900, 01, 01)
                    : dr.GetDateTime(dr.GetOrdinal("fecha"));
            obj.FechaModi = dr.IsDBNull(dr.GetOrdinal("fechaModi"))
                    ? new DateTime(1900, 01, 01)
                    : dr.GetDateTime(dr.GetOrdinal("fechaModi"));
            obj.FechaInicio = dr.IsDBNull(dr.GetOrdinal("fechaInicio"))
                    ? new DateTime(1900, 01, 01)
                    : dr.GetDateTime(dr.GetOrdinal("fechaInicio"));
            obj.FechaCese = dr.IsDBNull(dr.GetOrdinal("fechaCese"))
                    ? new DateTime(1900, 01, 01)
                    : dr.GetDateTime(dr.GetOrdinal("fechaCese"));
            obj.Autorizacion = dr.GetString(dr.GetOrdinal("Autorizacion"));
            obj.Cese = dr.GetString(dr.GetOrdinal("cese"));
            obj.CodLogin= dr.GetString(dr.GetOrdinal("CodLogin"));
            
            return obj;
        }

        public static bool ExisteById(String codServicio)
        {
            if (string.IsNullOrEmpty(codServicio)) throw new ArgumentNullException("codServicio");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "codServicio", DbType.String, codServicio);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
    }
}
