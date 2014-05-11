using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class AlumnoDetalleEscuelaDao
    {
        public static int GrabarDetalleEscuela(String cui, int idEscuela, String codLogin, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tAlumno");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertRelacionado); //105
            DATA.Db.AddInParameter(cmd, "Cui", DbType.String, cui);
            DATA.Db.AddInParameter(cmd, "IdEscuela", DbType.Int32, idEscuela);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static List<AlumnoDetalleEscuela> SelectAllGetby(String cui)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_tAlumno");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById2); //512
            DATA.Db.AddInParameter(cmd, "cui", DbType.String, cui);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tList = new List<AlumnoDetalleEscuela>();
                while (dr.Read())
                {
                    var ta = MakeAlumnoDetalleEscuela(dr);
                    tList.Add(ta);
                }
                return tList;
            }
        }


        protected static AlumnoDetalleEscuela MakeAlumnoDetalleEscuela(IDataReader dr)
        {
            var ob = new AlumnoDetalleEscuela
            {
                Id = dr.GetInt32(dr.GetOrdinal("Id")),
                IdEscuela = dr.GetInt32(dr.GetOrdinal("IdEscuela")),
                Cui = dr.GetString(dr.GetOrdinal("Cui")),
                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                CodLogin = dr.GetString(dr.GetOrdinal("CodLogin")),
                Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"))
            };
            return ob;
        }
    }
}
