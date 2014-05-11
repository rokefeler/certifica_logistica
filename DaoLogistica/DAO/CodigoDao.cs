using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class CodigoDao
	{

        public static int Grabar(Codigo tCodigo, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tCodigo");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "Codigo", DbType.String, (tCodigo.Id==String.Empty)?Convert.DBNull:tCodigo.Id);
            DATA.Db.AddInParameter(cmd, "CodTipo", DbType.String, (tCodigo.CodTipo==String.Empty)?"":tCodigo.CodTipo);
            DATA.Db.AddInParameter(cmd, "Denomi", DbType.String, (tCodigo.Nombre==String.Empty)?"":tCodigo.Nombre );
            DATA.Db.AddInParameter(cmd, "referencia", DbType.String, (tCodigo.Referencia==String.Empty)?Convert.DBNull:tCodigo.Referencia);
            DATA.Db.AddInParameter(cmd, "descrip", DbType.String, (tCodigo.Descrip==String.Empty)?"":tCodigo.Descrip);
            DATA.Db.AddInParameter(cmd, "num", DbType.Int32, (tCodigo.Num==0)?Convert.DBNull:tCodigo.Num);
            DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean,tCodigo.Estado);

            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(int codigo, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tCodigo");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "codigo", DbType.String, codigo);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Codigo GetbyId(String codigo)
        {
            Codigo obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tCodigo");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "codigo", DbType.String, codigo);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeCodigo(dr);
                }
            }
            return obj;
        }

        public static DataSet Getby(String codTipo, String referencia=null, Bit estado= Bit.Nulo )
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_tCodigo");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodTipo); //522
            DATA.Db.AddInParameter(cmd, "codTipo", DbType.String, codTipo);
            if(referencia!=null)
                DATA.Db.AddInParameter(cmd, "referencia", DbType.String, referencia);
            if(estado!= Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean , 
                    (estado== Bit.Verdadero));
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Codigo> SelectAllGetby(String codTipo, String referencia = null, Bit estado = Bit.Nulo)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tCodigo");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByCodTipo); //522
            DATA.Db.AddInParameter(cmd, "codTipo", DbType.String, codTipo);
            if (referencia != null)
                DATA.Db.AddInParameter(cmd, "referencia", DbType.String, referencia);
            if (estado != Bit.Nulo)
                DATA.Db.AddInParameter(cmd, "estado", DbType.Boolean,
                    (estado == Bit.Verdadero));

            using (IDataReader  datareader = DATA.Db.ExecuteReader(cmd))
            {
                var tCodigoList = new List<Codigo>();
                while (datareader.Read())
                {
                    Codigo tCodigo = MakeCodigo(datareader);
                    tCodigoList.Add(tCodigo);
                }
                return tCodigoList;
            }
        }


		protected static Codigo MakeCodigo(IDataReader  dr)
		{
            var obETCodigo = new Codigo
            {
                Id = dr.IsDBNull(dr.GetOrdinal("Codigo")) ? String.Empty : dr.GetString(dr.GetOrdinal("Codigo")),
                CodTipo = dr.IsDBNull(dr.GetOrdinal("codTipo")) ? String.Empty : dr.GetString(dr.GetOrdinal("codTipo")),
                Nombre = dr.IsDBNull(dr.GetOrdinal("nombre")) ? String.Empty : dr.GetString(dr.GetOrdinal("nombre")),
                Referencia = dr.IsDBNull(dr.GetOrdinal("referencia")) ? String.Empty : dr.GetString(dr.GetOrdinal(
                "referencia")),
                Descrip = dr.IsDBNull(dr.GetOrdinal("descrip")) ? String.Empty : dr.GetString(dr.GetOrdinal("descrip")),
                Num = dr.IsDBNull(dr.GetOrdinal("num")) ? 0 : dr.GetInt32(dr.GetOrdinal("num")),
                Estado = !dr.IsDBNull(dr.GetOrdinal("estado")) && dr.GetBoolean(dr.GetOrdinal("estado"))
            };
            return obETCodigo;
		}
	}
}
