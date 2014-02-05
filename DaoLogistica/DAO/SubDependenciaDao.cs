using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class SubDependenciaDao
	{
	    
        public static int Grabar(SubDependencia tSubDependencia, DbTransaction dbTrans=null)
        {
            if (tSubDependencia == null) throw new ArgumentNullException("tSubDependencia");
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate); //100
            DATA.Db.AddInParameter(cmd, "CodSubDep", DbType.String, tSubDependencia.CodSubDep);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, tSubDependencia.CodDependencia);
            DATA.Db.AddInParameter(cmd, "nombre", DbType.String, tSubDependencia.Nombre);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, tSubDependencia.CodPersonal);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, tSubDependencia.Estado);
            DATA.Db.AddInParameter(cmd, "Autorizacion", DbType.String, (tSubDependencia.Autorizacion == String.Empty) ? Convert.DBNull : tSubDependencia.Autorizacion);
            DATA.Db.AddInParameter(cmd, "FechaAut", DbType.DateTime, (tSubDependencia.FechaAut.Year == 1900) ? Convert.DBNull : tSubDependencia.FechaAut);
            DATA.Db.AddInParameter(cmd, "Telefono", DbType.String, (tSubDependencia.Telefono == String.Empty) ? Convert.DBNull : tSubDependencia.Telefono);
            DATA.Db.AddInParameter(cmd, "Web", DbType.String, (tSubDependencia.Web==String.Empty)?Convert.DBNull:tSubDependencia.Web);
            DATA.Db.AddInParameter(cmd, "Obsv", DbType.String, (tSubDependencia.Obsv==String.Empty)?Convert.DBNull:tSubDependencia.Obsv);
            DATA.Db.AddInParameter(cmd, "Email", DbType.String, (tSubDependencia.Email == String.Empty) ? Convert.DBNull : tSubDependencia.Email);
            DATA.Db.AddInParameter(cmd, "Siglas", DbType.String, (tSubDependencia.Siglas == String.Empty) ? Convert.DBNull : tSubDependencia.Siglas);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, tSubDependencia.CodLogin);
            DATA.Db.AddInParameter(cmd, "IsConvenio", DbType.Boolean, tSubDependencia.IsConvenio);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codSubDep, string codlogin, DbTransaction dbTrans=null)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodSubDep", DbType.String, codSubDep);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codlogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static SubDependencia GetbyId(String codSubDep)
        {
            if (codSubDep == null) throw new ArgumentNullException("codSubDep");
            SubDependencia obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodSubDep", DbType.String, codSubDep);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeSubDependencia(dr);
                }
            }
            return obj;
        }
        
        public static DataSet GetbyCodDependencia(String codDependencia, Bit estado= Bit.Nulo)
        {
            if (codDependencia == null) throw new ArgumentNullException("codDependencia");
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, codDependencia);
            if(estado!= Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, estado != Bit.Falso );
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet GetbyCodPersonal(String codPersonal, Bit estado = Bit.Nulo)
        {
            if (codPersonal == null) throw new ArgumentNullException("codPersonal");
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodPersonal);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, estado != Bit.Falso);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<SubDependencia> SelectAllGetbyCodDependencia(String codDependencia, Bit estado = Bit.Nulo)
        {
            if (codDependencia == null) throw new ArgumentNullException("codDependencia");
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodDep);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, codDependencia);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, estado != Bit.Falso);

            using (IDataReader datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tSubDepList = new List<SubDependencia>();
                while (datareader.Read())
                {
                    var tSubDep = MakeSubDependencia(datareader);
                    tSubDepList.Add(tSubDep);
                }
                return tSubDepList;
            }
        }
        public static List<SubDependencia> SelectAllGetbyCodPersonal(String codPersonal, Bit estado = Bit.Nulo)
        {
            if (codPersonal == null) throw new ArgumentNullException("codPersonal");
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodPersonal);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, estado != Bit.Falso);

            using (IDataReader datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tSubDepList = new List<SubDependencia>();
                while (datareader.Read())
                {
                    var tSubDep = MakeSubDependencia(datareader);
                    tSubDepList.Add(tSubDep);
                }
                return tSubDepList;
            }
        }

        public static DataSet FiltroByNombre(String filtro1, String filtro2)
        {
            if (String.IsNullOrEmpty(filtro1) && String.IsNullOrEmpty(filtro2)) throw new ArgumentNullException("nombreDep");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByRazon); //601
            
            if(!String.IsNullOrEmpty(filtro1))
                DATA.Db.AddInParameter(cmd, "Nombre", DbType.String, filtro1);
            if (!String.IsNullOrEmpty(filtro2))
                DATA.Db.AddInParameter(cmd, "Obsv", DbType.String, filtro2);

            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet FiltroByEncargadoSubDependencia(String filtro1, String filtro2)
        {
            if (String.IsNullOrEmpty(filtro1) && String.IsNullOrEmpty(filtro2)) throw new ArgumentNullException("nombreDep");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tSubDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByPersonal); //607

            if (!String.IsNullOrEmpty(filtro1))
                DATA.Db.AddInParameter(cmd, "Nombre", DbType.String, filtro1);
            if (!String.IsNullOrEmpty(filtro2))
                DATA.Db.AddInParameter(cmd, "Obsv", DbType.String, filtro2);

            return DATA.Db.ExecuteDataSet(cmd);
        }
		protected static SubDependencia MakeSubDependencia(IDataReader dr)
		{
            var obj = new SubDependencia
            {
                CodSubDep = dr.GetString(dr.GetOrdinal("CodSubDep")),
                CodDependencia = dr.IsDBNull(dr.GetOrdinal("CodDependencia"))
                ? String.Empty
                : dr.GetString(dr.GetOrdinal("CodDependencia")),
                Nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? String.Empty : dr.GetString(dr.GetOrdinal("nombre")),
                NombreDependencia = dr.IsDBNull(dr.GetOrdinal("nombreDependencia")) ? String.Empty : dr.GetString(dr.GetOrdinal("nombreDependencia")),
                CodPersonal = dr.IsDBNull(dr.GetOrdinal("CodPersonal")) 
                ? String.Empty 
                : dr.GetString(dr.GetOrdinal("CodPersonal")),
                Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) && dr.GetBoolean(dr.GetOrdinal("Estado")),
                Autorizacion = dr.IsDBNull(dr.GetOrdinal("autorizacion")) 
                ? String.Empty 
                : dr.GetString(dr.GetOrdinal("autorizacion")),
                FechaAut = dr.IsDBNull(dr.GetOrdinal("fechaAut")) 
                ? new DateTime(1900, 01, 01) 
                : dr.GetDateTime(dr.GetOrdinal("fechaAut")),
                Web = dr.IsDBNull(dr.GetOrdinal("web")) ? String.Empty : dr.GetString(dr.GetOrdinal("web")),
                Obsv = dr.IsDBNull(dr.GetOrdinal("obsv")) ? String.Empty : dr.GetString(dr.GetOrdinal("obsv")),
                Email = dr.GetString(dr.GetOrdinal("Email")),
                CodLogin = dr.GetString(dr.GetOrdinal("CodLogin")),
                Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                IsConvenio = dr.GetBoolean(dr.GetOrdinal("IsConvenio")),
                Telefono = dr.GetString(dr.GetOrdinal("Telefono"))
            };
			return obj;
		}
     }
}
