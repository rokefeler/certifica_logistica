using System.Collections.Generic;
using System.Data;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class AlumnoDao
    {
        public static List<AlumnoEscuela> SelectAllEscuelas()
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TAlumno");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAllEscuelas); //501

            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tDataList = new List<AlumnoEscuela>();
                while (dr.Read())
                {
                    var t = MakeObjAlumnoEscuela(dr);
                    tDataList.Add(t);
                }
                return tDataList;
            }
        }
        protected static AlumnoEscuela MakeObjAlumnoEscuela(IDataReader dr)
        {
            var ob = new AlumnoEscuela
            {
                IdEscuela = dr.GetInt32(dr.GetOrdinal("IdEscuela")),
                Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
            };
            return ob;
        }


    }
}
