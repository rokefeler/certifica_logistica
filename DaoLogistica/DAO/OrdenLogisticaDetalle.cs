using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class OrdenLogisticaDetalleDetalle
    {

        public static int Grabar(OrdenLogisticaDetalle obj, DbTransaction dbTrans)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            if(obj.Id>0)
                DATA.Db.AddInParameter(cmd, "Id", DbType.Int64, obj.Id);
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, obj.IdOrden);
            DATA.Db.AddInParameter(cmd, "IdClasificador", DbType.Int32, obj.IdClasificador);
            if(obj.TipoUsuario!=' ')
                DATA.Db.AddInParameter(cmd, "TipoUsuario", DbType.String, obj.TipoUsuario);
            if(!string.IsNullOrEmpty(obj.Codigo))
                DATA.Db.AddInParameter(cmd, "Codigo", DbType.String, obj.Codigo);
            if (!string.IsNullOrEmpty(obj.Detalle))
                DATA.Db.AddInParameter(cmd, "Detalle", DbType.String, obj.Detalle);
            DATA.Db.AddInParameter(cmd, "IdMeta", DbType.Int32, obj.IdMeta);
            DATA.Db.AddInParameter(cmd, "Monto", DbType.Decimal, obj.Monto);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(long idDet, DbTransaction dbTrans)
        {
            if (idDet <= 0) throw new ArgumentNullException("idDet");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "Id", DbType.Int64, idDet);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static OrdenLogisticaDetalle GetbyId(int id)
        {
            if (id <= 0) throw new ArgumentNullException("id");
            OrdenLogisticaDetalle obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "IdOrden", DbType.Int64, id);
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
        public static DataSet GetbyAll(long idOrden)
        {
            if (idOrden <= 0) throw new ArgumentNullException("idOrden");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetAll);
            DATA.Db.AddInParameter(cmd, "idOrden", DbType.Int64, idOrden);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        /*
        public static DataSet FiltroByNroDocAsunto(string cFiltro, String anio)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606
            DATA.Db.AddInParameter(cmd, "@NroDoc", DbType.String, cFiltro);
            DATA.Db.AddInParameter(cmd, "@IdOrdenLogisticaDetalle", DbType.String, anio);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        */
        protected static OrdenLogisticaDetalle MakeObj(IDataReader dr)
        {
            var obj = new OrdenLogisticaDetalle();
            obj.Id = dr.GetInt64(dr.GetOrdinal("Id"));
            obj.IdOrden = dr.GetInt64(dr.GetOrdinal("IdOrden"));
            obj.IdClasificador = dr.GetInt32(dr.GetOrdinal("IdClasificador"));
            obj.TipoUsuario = Convert.ToChar(dr.GetValue(dr.GetOrdinal("TipoUsuario")));
            obj.Codigo= dr.GetString(dr.GetOrdinal("codigo"));
            obj.Detalle = dr.GetString(dr.GetOrdinal("Detalle"));
            obj.IdMeta = dr.GetInt32(dr.GetOrdinal("IdMeta"));
            obj.Monto = dr.GetDecimal(dr.GetOrdinal("Monto"));
            return obj;
        }

        public static bool ExisteById(long id)
        {
            if (id <= 0) throw new ArgumentNullException("id");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TOrdenLogisticaDetalle");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "id", DbType.Int64, id);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }

    } //Fin de Clase
}
