using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class AlumnoDao
    {
        public static int Grabar(Alumno tobj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tAlumno");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "Cui", DbType.String, tobj.Cui);
            DATA.Db.AddInParameter(cmd, "ApeNom", DbType.String, tobj.ApeNom);
            DATA.Db.AddInParameter(cmd, "Direccion", DbType.String, tobj.Direccion);
            DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, tobj.CodDis);
            DATA.Db.AddInParameter(cmd, "Dni", DbType.String, tobj.Dni);
            DATA.Db.AddInParameter(cmd, "Telefono", DbType.String, tobj.Telefono);
            DATA.Db.AddInParameter(cmd, "Email", DbType.String, tobj.Email);
            DATA.Db.AddInParameter(cmd, "FecNac", DbType.DateTime, tobj.Fecnac);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, tobj.CodLogin);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.String, tobj.Estado);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static Alumno GetBy(String cui)
        {
            if (String.IsNullOrEmpty(cui)) throw new ArgumentNullException("cui");
            Alumno obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tAlumno");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById); //511
            DATA.Db.AddInParameter(cmd, "Cui", DbType.String, cui);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeAlumno(dr);
                }
            }
            return obj;
        }

        protected static Alumno MakeAlumno(IDataReader dr)
        {
            var obj = new Alumno();
            obj.Cui= dr.GetString(dr.GetOrdinal("cui"));
            obj.ApeNom = dr.GetString(dr.GetOrdinal("ApeNom"));
            obj.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
            obj.CodDis = dr.GetString(dr.GetOrdinal("CodDis"));
            obj.Dni = dr.GetString(dr.GetOrdinal("Dni"));
            obj.Telefono= dr.GetString(dr.GetOrdinal("Telefono"));
            obj.Email = dr.GetString(dr.GetOrdinal("Email"));
            obj.Fecnac = dr.IsDBNull(dr.GetOrdinal("FecNac"))? new DateTime(1900, 01, 01): dr.GetDateTime(dr.GetOrdinal("FecNac"));
            obj.Fecha = dr.IsDBNull(dr.GetOrdinal("fecha")) ? new DateTime(1900, 01, 01) : dr.GetDateTime(dr.GetOrdinal("fecha"));
            obj.CodLogin= dr.GetString(dr.GetOrdinal("CodLogin"));
            obj.Estado = Convert.ToChar(dr.GetValue(dr.GetOrdinal("Estado")));
            return obj;
        }
    }}
