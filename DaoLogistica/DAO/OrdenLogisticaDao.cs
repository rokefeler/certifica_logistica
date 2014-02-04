using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class OrdenLogisticaDao
    {

        public static int Grabar(OrdenLogistica obj, DbTransaction dbTrans)
        {
            if (obj==null) throw new ArgumentNullException("obj");
            if (String.IsNullOrEmpty(obj.Cnro)) throw new ArgumentNullException("obj","Falta Nro. Exp.");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            if(obj.IdOrden>0)
                DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, obj.IdOrden);
            DATA.Db.AddInParameter(cmd, "Cnro", DbType.String, obj.Cnro);
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, obj.IdExpediente);
            DATA.Db.AddInParameter(cmd, "IdxTipoOrden", DbType.String, obj.IdxTipoOrden);
            DATA.Db.AddInParameter(cmd, "TipoUsuario", DbType.String, obj.TipoUsuario);
            DATA.Db.AddInParameter(cmd, "Codigo", DbType.String, obj.Codigo);
            DATA.Db.AddInParameter(cmd, "FechaGiro", DbType.DateTime, obj.FechaGiro);
            if(obj.IdAlmacen>0)
                DATA.Db.AddInParameter(cmd, "IdAlmacen", DbType.String, obj.IdAlmacen);
            DATA.Db.AddInParameter(cmd, "IdxProceso", DbType.String, obj.IdxProceso);
            if(!string.IsNullOrEmpty(obj.Referencia))
                DATA.Db.AddInParameter(cmd, "Referencia", DbType.String, obj.Referencia);
            if(!string.IsNullOrEmpty(obj.Descripcion))
                DATA.Db.AddInParameter(cmd, "Descripcion", DbType.String, obj.Descripcion);
            DATA.Db.AddInParameter(cmd, "Total", DbType.Decimal, obj.Total);
            if(!string.IsNullOrEmpty(obj.Siaf))
                DATA.Db.AddInParameter(cmd, "Siaf", DbType.String, obj.Siaf);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(long idOrden, DbTransaction dbTrans)
        {
            if (idOrden <= 0) throw new ArgumentNullException("idOrden");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, idOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static OrdenLogistica GetbyId(int idOrden)
        {
            if (idOrden<=0) throw new ArgumentNullException("idOrden");
            OrdenLogistica obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int32, idOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeObj(dr);
                }
            }
            return obj;
        }
        public static OrdenLogistica GetbyId(String cNroOrden)
        {
            if (String.IsNullOrEmpty(cNroOrden)) throw new ArgumentNullException("cNroOrden");
            OrdenLogistica obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "cNro", DbType.String, cNroOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeObj(dr);
                }
            }
            return obj;
        }
        /*
        public static DataSet FiltroByNroDocAsunto(string cFiltro, String anio)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606
            DATA.Db.AddInParameter(cmd, "@NroDoc", DbType.String, cFiltro);
            DATA.Db.AddInParameter(cmd, "@IdOrdenLogistica", DbType.String, anio);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        */
        protected static OrdenLogistica MakeObj(IDataReader dr)
        {
            var obj = new OrdenLogistica();
            obj.IdOrden = dr.GetInt64(dr.GetOrdinal("IdOrden"));
            obj.Cnro = dr.GetString(dr.GetOrdinal("Cnro"));
            obj.IdExpediente = dr.GetString(dr.GetOrdinal("IdExpediente"));
            obj.IdxTipoOrden = dr.GetString(dr.GetOrdinal("IdxTipoOrden"));
            obj.TipoUsuario = Convert.ToChar(dr.GetValue(dr.GetOrdinal("TipoUsuario")));
            obj.Codigo = dr.GetString(dr.GetOrdinal("Codigo"));
            obj.StampNombre= dr.GetString(dr.GetOrdinal("StampNombre"));
            obj.FechaGiro = dr.GetDateTime(dr.GetOrdinal("FechaGiro"));
            obj.IdAlmacen = dr.GetInt16(dr.GetOrdinal("IdAlmacen"));
            obj.IdxProceso = dr.GetString(dr.GetOrdinal("IdxProceso"));
            obj.Referencia = dr.GetString(dr.GetOrdinal("Referencia"));
            obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
            obj.Total = dr.GetDecimal(dr.GetOrdinal("Total"));
            obj.Estado = dr.GetInt16(dr.GetOrdinal("Estado"));
            obj.Siaf = dr.GetString(dr.GetOrdinal("Siaf"));
            obj.FechaBloqueo = dr.IsDBNull(dr.GetOrdinal("FechaBloqueo"))
                ? new DateTime(1900, 1, 1)
                : dr.GetDateTime(dr.GetOrdinal("FechaBloqueo"));
            obj.IsCoa = dr.GetBoolean(dr.GetOrdinal("IsCoa"));
            obj.CodLogin = dr.GetString(dr.GetOrdinal("CodLogin"));
            obj.FechaRegistro  = dr.GetDateTime(dr.GetOrdinal("FechaRegistro"));
            obj.FechaImpresion = dr.IsDBNull(dr.GetOrdinal("FechaImpresion"))
                ? new DateTime(1900, 1, 1)
                : dr.GetDateTime(dr.GetOrdinal("FechaImpresion"));
            obj.FechaAnulacion = dr.IsDBNull(dr.GetOrdinal("FechaAnulacion"))
                ? new DateTime(1900, 1, 1)
                : dr.GetDateTime(dr.GetOrdinal("FechaAnulacion"));
            obj.CodLoginAnula = dr.GetString(dr.GetOrdinal("CodLoginAnula"));
            return obj;
        }

        public static bool ExisteById(long idOrden)
        {
            if (idOrden<=0) throw new ArgumentNullException("idOrden");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "idOrden", DbType.Int64, idOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
        public static bool ExisteById(String cNroOrden)
        {
            if (string.IsNullOrEmpty(cNroOrden)) throw new ArgumentNullException("cNroOrden");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "cNroOrden", DbType.String, cNroOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
    }
}
