using System;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
    public class ProveedorDao
    {

        public static int Grabar(Proveedor obj, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "Ruc", DbType.String, obj.Ruc);
            DATA.Db.AddInParameter(cmd, "Razon", DbType.String, obj.Razon);
            if(!string.IsNullOrEmpty(obj.RazonComercial))
                DATA.Db.AddInParameter(cmd, "RazonComercial", DbType.String, obj.RazonComercial);
            DATA.Db.AddInParameter(cmd, "Direccion", DbType.String, obj.Direccion);
            if(!string.IsNullOrEmpty(obj.Referencia))
            DATA.Db.AddInParameter(cmd, "Referencia", DbType.String, obj.Referencia);
            if(!string.IsNullOrEmpty(obj.Contacto))
                DATA.Db.AddInParameter(cmd, "Contacto", DbType.String, obj.Contacto);
            if(!string.IsNullOrEmpty(obj.Telefono))
                DATA.Db.AddInParameter(cmd, "Telefono", DbType.String, obj.Telefono);
            if(!string.IsNullOrEmpty(obj.Email))
                DATA.Db.AddInParameter(cmd, "Email", DbType.String, obj.Email);
            if(!string.IsNullOrEmpty(obj.AgenteRetencion))
                DATA.Db.AddInParameter(cmd, "AgenteRetencion", DbType.String, obj.AgenteRetencion);
            if(!string.IsNullOrEmpty(obj.Cci))
                DATA.Db.AddInParameter(cmd, "Cci", DbType.String, obj.Cci);
            if(!string.IsNullOrEmpty(obj.Rnp))
                DATA.Db.AddInParameter(cmd, "Rnp", DbType.String, obj.Rnp);
            if(obj.RnpVencimiento.Year>1900)
                DATA.Db.AddInParameter(cmd, "RnpVencimiento", DbType.DateTime, obj.RnpVencimiento);
            if(!string.IsNullOrEmpty(obj.CodDis))
                DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, obj.CodDis);

            if(!string.IsNullOrEmpty(obj.Situacion))
                DATA.Db.AddInParameter(cmd, "Situacion", DbType.String, obj.Situacion);
            
            if(obj.EsHabido!=' ')
                DATA.Db.AddInParameter(cmd, "EsHabido", DbType.String, obj.EsHabido);
            if(!string.IsNullOrEmpty(obj.TipoNegocio))
                DATA.Db.AddInParameter(cmd, "TipoNegocio", DbType.String, obj.TipoNegocio);
            if(!string.IsNullOrEmpty(obj.Dni))
                DATA.Db.AddInParameter(cmd, "Dni", DbType.String, obj.Dni);
            if(obj.FecNac.Year>1900)
                DATA.Db.AddInParameter(cmd, "Fecnac", DbType.DateTime, obj.FecNac);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, obj.CodLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codProveedor, DbTransaction dbTrans)
        {
            if (codProveedor== null) throw new ArgumentNullException("codProveedor");
            // ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codProveedor);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Proveedor GetbyId(String ruc)
        {
            if (String.IsNullOrEmpty(ruc)) throw new ArgumentNullException("ruc");
            Proveedor obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_TProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "Ruc", DbType.String, ruc);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeProveedor(dr);
                }
            }
            return obj;
        }

        

        public static DataSet FiltroByRazon(string cFil1, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByRazon); //601
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "Razon", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "RazonComercial", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static DataSet FiltroByDireccion(string cFil1, string cfil2 = null)
        {
            if (String.IsNullOrEmpty(cFil1)) throw new ArgumentNullException("cFil1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDireccion); //609
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "Razon", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "RazonComercial", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        protected static Proveedor MakeProveedor(IDataReader dr)
        {
            var obj = new Proveedor();
            obj.Ruc= dr.GetString(dr.GetOrdinal("Ruc"));
            obj.Razon = dr.GetString(dr.GetOrdinal("Razon"));
            obj.RazonComercial= dr.GetString(dr.GetOrdinal("RazonComercial"));
            obj.Direccion = dr.GetString(dr.GetOrdinal("Direccion"));
            obj.Referencia = dr.GetString(dr.GetOrdinal("Referencia"));
            obj.Contacto = dr.GetString(dr.GetOrdinal("Contacto"));
            obj.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
            obj.Email = dr.GetString(dr.GetOrdinal("email"));
            obj.AgenteRetencion = dr.GetString(dr.GetOrdinal("AgenteRetencion"));
            obj.Cci= dr.GetString(dr.GetOrdinal("Cci"));
            obj.Rnp = dr.GetString(dr.GetOrdinal("Rnp"));
            obj.RnpVencimiento= dr.IsDBNull(dr.GetOrdinal("RnpVencimiento")) ? new DateTime(1900,1,1) : dr.GetDateTime(dr.GetOrdinal("RnpVencimiento"));
            obj.CodDis = dr.GetString(dr.GetOrdinal("codDis"));
            obj.Situacion= dr.GetString(dr.GetOrdinal("Situacion"));
            obj.EsHabido = Convert.ToChar(dr.GetValue(dr.GetOrdinal("EsHabido")));
            obj.TipoNegocio= dr.GetString(dr.GetOrdinal("TIpoNegocio"));
            obj.Dni = dr.GetString(dr.GetOrdinal("Dni"));
            obj.FecNac = dr.IsDBNull(dr.GetOrdinal("FecNac")) ? new DateTime(1900, 1, 1) : dr.GetDateTime(dr.GetOrdinal("FecNac"));
            obj.CodLogin = dr.GetString(dr.GetOrdinal("CodLogin"));
            obj.FechaModi = dr.IsDBNull(dr.GetOrdinal("FechaModi")) ? new DateTime(1900, 1, 1) : dr.GetDateTime(dr.GetOrdinal("FechaModi"));
            obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
            obj.Estado = Convert.ToChar(dr.GetValue(dr.GetOrdinal("Estado")));
            
            return obj;
        }

        public static bool ExisteById(String ruc)
        {
            if (String.IsNullOrEmpty(ruc)) throw new ArgumentNullException("ruc");
            var cmd = DATA.Db.GetStoredProcCommand("sp_TProveedor");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, ruc);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
    }
}
