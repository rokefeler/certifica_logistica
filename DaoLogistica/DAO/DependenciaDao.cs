using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class DependenciaDao
	{

        public static int Grabar(Dependencia tDependencia, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, tDependencia.CodDependencia);
            DATA.Db.AddInParameter(cmd, "nombre", DbType.String, tDependencia.Nombre);
            DATA.Db.AddInParameter(cmd, "IdxRubroDependencia", DbType.String, tDependencia.IdxRubroDependencia);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, tDependencia.CodPersonal);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.Boolean, tDependencia.Estado);

            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codDependencia, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, codDependencia);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Dependencia GetbyId(String codDependencia)
        {
            Dependencia obj = null;
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodDependencia", DbType.String, codDependencia);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeDependencia(dr);
                }
            }
            return obj;
        }

        public static DataSet GetbyAll(Bit estado= Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static DataSet GetByRubroDependencia(String idxRubroDependencia,Bit estado=Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByRubroDependencia);
            DATA.Db.AddInParameter(cmd, "IdxRubroDependencia", DbType.String, idxRubroDependencia);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet GetByCodPersonal(String codPersonal, Bit estado = Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodPersonal);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<Dependencia> SelectAll(Bit estado = Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));

            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tDependenciaList = new List<Dependencia>();
                while (dr.Read())
                {
                    var tDependencia = MakeDependencia(dr);
                    tDependenciaList.Add(tDependencia);
                }
                return tDependenciaList;
            }
        }

        public static List<Dependencia> SelectAllGetByRubroDependencia(String idxRubroDependencia, Bit estado=Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByRubroDependencia);
            DATA.Db.AddInParameter(cmd, "IdxRubroDependencia", DbType.String, idxRubroDependencia);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tDependenciaList = new List<Dependencia>();
                while (dr.Read())
                {
                    Dependencia tDependencia = MakeDependencia(dr);
                    tDependenciaList.Add(tDependencia);
                }
                return tDependenciaList;
            }
        }
        public static List<Dependencia> SelectAllGetByCodPersonal(String codPersonal, Bit estado = Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tDependencia");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodPersonal);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean, (estado != Bit.Falso));
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tDependenciaList = new List<Dependencia>();
                while (dr.Read())
                {
                    Dependencia tDependencia = MakeDependencia(dr);
                    tDependenciaList.Add(tDependencia);
                }
                return tDependenciaList;
            }
        }
		
		protected static Dependencia MakeDependencia(IDataReader dr)
		{
            var ob = new Dependencia
            {
                CodDependencia = dr.IsDBNull(dr.GetOrdinal("CodDependencia"))
                        ? String.Empty
                        : dr.GetString(dr.GetOrdinal("CodDependencia")),
                Nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? String.Empty : dr.GetString(dr.GetOrdinal("nombre")),
                IdxRubroDependencia =
                    dr.IsDBNull(dr.GetOrdinal("IdxRubroDependencia"))
                        ? String.Empty
                        : dr.GetString(dr.GetOrdinal("IdxRubroDependencia")),
                CodPersonal = dr.IsDBNull(dr.GetOrdinal("CodPersonal")) ? String.Empty : dr.GetString(dr.GetOrdinal("CodPersonal")),
                Estado = !dr.IsDBNull(dr.GetOrdinal("Estado")) && dr.GetBoolean(dr.GetOrdinal("Estado"))
            };
            return ob;
		}

	}
}
