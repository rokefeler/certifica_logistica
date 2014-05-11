using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class OrdenLogisticaDao
    {

        public static int Grabar(OrdenLogistica obj, DbTransaction dbTrans,out int cNroOrden)
        {
            if (obj==null) throw new ArgumentNullException("obj");
            if (dbTrans == null) throw new ArgumentNullException("dbTrans");
            cNroOrden = 0;            
            //if (obj.Nro==0) throw new ArgumentNullException("obj","Falta Nro. de Orden");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            if(obj.IdOrden>0)
                DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, obj.IdOrden);
            DATA.Db.AddInParameter(cmd, "Nro", DbType.Int32, obj.Nro);
            DATA.Db.AddInParameter(cmd, "Anio", DbType.Int32, obj.Anio);
            DATA.Db.AddInParameter(cmd, "IdExpediente", DbType.String, obj.IdExpediente);
            DATA.Db.AddInParameter(cmd, "IdxTipoOrden", DbType.String, obj.IdxTipoOrden);
            DATA.Db.AddInParameter(cmd, "TipoUsuario", DbType.String, obj.TipoUsuario);
            DATA.Db.AddInParameter(cmd, "Codigo", DbType.String, obj.Codigo);
            DATA.Db.AddInParameter(cmd, "FechaGiro", DbType.DateTime, obj.FechaGiro);
            if(obj.IdAlmacen>0)
                DATA.Db.AddInParameter(cmd, "IdAlmacen", DbType.String, obj.IdAlmacen);
            DATA.Db.AddInParameter(cmd, "IdxProceso", DbType.String, obj.IdxProceso);
            if(!String.IsNullOrEmpty(obj.NroProceso))
                DATA.Db.AddInParameter(cmd, "NroProceso", DbType.String, obj.NroProceso);
            if(!string.IsNullOrEmpty(obj.Referencia))
                DATA.Db.AddInParameter(cmd, "Referencia", DbType.String, obj.Referencia);
            if(!string.IsNullOrEmpty(obj.Descripcion))
                DATA.Db.AddInParameter(cmd, "Descripcion", DbType.String, obj.Descripcion);
            DATA.Db.AddInParameter(cmd, "Total", DbType.Decimal, obj.Total);
            if(!string.IsNullOrEmpty(obj.Siaf))
                DATA.Db.AddInParameter(cmd, "Siaf", DbType.String, obj.Siaf);
            if (!string.IsNullOrEmpty(obj.Ccp))
                DATA.Db.AddInParameter(cmd, "Ccp", DbType.String, obj.Ccp);
            if (!string.IsNullOrEmpty(obj.RdAutoriza))
                DATA.Db.AddInParameter(cmd, "RdAutoriza", DbType.String, obj.RdAutoriza);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.AddOutParameter(cmd, "NroOrden", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            if (obj.IdOrden <= 0)
            {
                if(ret>0) //Si no existio ningun Error
                    cNroOrden = (int) DATA.Db.GetParameterValue(cmd, "@NroOrden");
            }
            return ret; //devuelve el id único del registro
        }

        public static int Delete(long idOrden, string codlogin, DbTransaction dbTrans)
        {
            if (idOrden <= 0) throw new ArgumentNullException("idOrden");
            if (dbTrans==null) throw new ArgumentNullException("dbTrans", "Baby que mal");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico); //300
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, idOrden);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codlogin);

            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd, dbTrans);

            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static OrdenLogistica GetbyId(long idOrden)
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
        public static OrdenLogistica GetbyId(int nroOrden, int anio, string idxTipoOrden)
        {
            if (nroOrden<=0) throw new ArgumentNullException("nroOrden");
            if (anio<= 0) throw new ArgumentNullException("anio");
            if (String.IsNullOrEmpty(idxTipoOrden)) throw new ArgumentNullException("idxTipoOrden");
            OrdenLogistica obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById2); //512
            DATA.Db.AddInParameter(cmd, "Nro", DbType.Int32, nroOrden);
            DATA.Db.AddInParameter(cmd, "Anio", DbType.Int32, anio);
            DATA.Db.AddInParameter(cmd, "idxTipoOrden", DbType.String, idxTipoOrden);
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
        public static DataSet GetAllByRazon(String cod1, String cod2 = null)
        {
            if (cod1 == null) throw new ArgumentNullException("cod1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByRazon);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, cod1);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, cod2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static DataSet ImprimirOrden(long IdOrden)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetPrinter); //5321
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, IdOrden);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static void CambiaEstado(EstadoOrden estado, long idorden)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.CambiarEstado); //1021
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, idorden);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.Int16, estado);
            DATA.Db.ExecuteNonQuery(cmd);
        }
        protected static OrdenLogistica MakeObj(IDataReader dr)
        {
            var obj = new OrdenLogistica();
            obj.IdOrden = dr.GetInt64(dr.GetOrdinal("IdOrden"));
            obj.Nro = dr.GetInt32(dr.GetOrdinal("Nro"));
            obj.Anio = dr.GetInt32(dr.GetOrdinal("Anio"));
            obj.IdExpediente = dr.GetString(dr.GetOrdinal("IdExpediente"));
            obj.IdxTipoOrden = dr.GetString(dr.GetOrdinal("IdxTipoOrden"));
            obj.TipoUsuario = Convert.ToChar(dr.GetValue(dr.GetOrdinal("TipoUsuario")));
            obj.Codigo = dr.GetString(dr.GetOrdinal("Codigo"));
            obj.StampNombre = dr.GetString(dr.GetOrdinal("stamp_nombre"));
            obj.FechaGiro = dr.GetDateTime(dr.GetOrdinal("FechaGiro"));
            obj.IdAlmacen = dr.GetInt16(dr.GetOrdinal("IdAlmacen"));
            obj.IdxProceso = dr.GetString(dr.GetOrdinal("IdxProceso"));
            obj.NroProceso = dr.GetString(dr.GetOrdinal("NroProceso"));
            obj.Referencia = dr.GetString(dr.GetOrdinal("Referencia"));
            obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
            obj.Total = dr.GetDecimal(dr.GetOrdinal("Total"));
            obj.Estado = dr.GetInt16(dr.GetOrdinal("Estado"));
            obj.Siaf = dr.GetString(dr.GetOrdinal("Siaf"));
            obj.Ccp  = dr.GetString(dr.GetOrdinal("Ccp"));
            obj.RdAutoriza = dr.GetString(dr.GetOrdinal("RdAutoriza"));
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
        public static bool ExisteExpediente(String idExpediente)
        {
            if (String.IsNullOrEmpty(idExpediente)) throw new ArgumentNullException("idExpediente");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistId2);
            DATA.Db.AddInParameter(cmd, "idExpediente", DbType.String, idExpediente);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
        public static bool ExisteById(int nroOrden, int anio)
        {
            if (nroOrden<=0) throw new ArgumentNullException("nroOrden");
            if (anio<= 0) throw new ArgumentNullException("anio");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogistica");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "Nro", DbType.Int32, nroOrden);
            DATA.Db.AddInParameter(cmd, "Anio", DbType.Int32, anio);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
        public static DataSet GetReporteByExpediente(string idexpediente)
        {
            if (idexpediente == null) throw new ArgumentNullException("idexpediente","Baby requiero mas datos");
            var cmd = DATA.Db.GetStoredProcCommand("sp_ReporteOrdenServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ReporteByExpediente);
            DATA.Db.AddInParameter(cmd, "@IdExpediente", DbType.String, idexpediente);
            cmd.CommandTimeout = 150; //Tiempo 150 seg
            return DATA.Db.ExecuteDataSet(cmd); 
        }
        public static DataSet GetReporteDetallado(int opcion, String codLogin, 
                                        String del, String al, String param)
        {
            if (param == null) throw new ArgumentNullException("param", "Baby no lo intentes");
            var cmd = DATA.Db.GetStoredProcCommand("sp_ReporteDetalladoOrdenServicio");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, opcion);
            DATA.Db.AddInParameter(cmd, "@param", DbType.String, param);
            DATA.Db.AddInParameter(cmd, "@Codlogin", DbType.String, codLogin);
            DATA.Db.AddInParameter(cmd, "@del", DbType.String, del);
            DATA.Db.AddInParameter(cmd, "@al", DbType.String, al);
            cmd.CommandTimeout = 0; //Tiempo Ilimitado
            return DATA.Db.ExecuteDataSet(cmd);
        }
    }
}
