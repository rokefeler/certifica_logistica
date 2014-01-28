using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class PersonalDao
	{
	
        public static int Grabar(Personal tPersonal, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, tPersonal.CodPersonal);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, tPersonal.Ape);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, tPersonal.Nom);
            DATA.Db.AddInParameter(cmd, "Direc", DbType.String, tPersonal.Direc);
            DATA.Db.AddInParameter(cmd, "IdcTipoDoc", DbType.String, (tPersonal.IdxTipoDoc==String.Empty)?Convert.DBNull:tPersonal.IdxTipoDoc);
            DATA.Db.AddInParameter(cmd, "NroDocIden", DbType.String, tPersonal.NroDocIden);
            DATA.Db.AddInParameter(cmd, "fecnac", DbType.DateTime, tPersonal.Fecnac);
            DATA.Db.AddInParameter(cmd, "Email", DbType.String, tPersonal.Email);
            DATA.Db.AddInParameter(cmd, "Movil", DbType.String,(tPersonal.Movil==String.Empty)?Convert.DBNull:tPersonal.Movil );
            DATA.Db.AddInParameter(cmd, "NroFijo", DbType.String,(tPersonal.Nrofijo==String.Empty)?Convert.DBNull:tPersonal.Nrofijo);
            DATA.Db.AddInParameter(cmd, "CodDis", DbType.String, tPersonal.CodDis);
            DATA.Db.AddInParameter(cmd, "IdFotoDbExt", DbType.Int32, tPersonal.IdFotoDbExt);
            DATA.Db.AddInParameter(cmd, "IdcCondicion", DbType.String, tPersonal.IdxCondicion);
            DATA.Db.AddInParameter(cmd, "CodSubDep", DbType.String, tPersonal.CodSubDep);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }

        public static int Delete(String codPersonal, DbTransaction dbTrans)
        {
            if (codPersonal == null) throw new ArgumentNullException("codPersonal");
// ReSharper disable once RedundantAssignment
            var ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Personal GetbyId(String codPersonal)
        {
            if (codPersonal == null) throw new ArgumentNullException("codPersonal");
            Personal obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakePersonal(dr);
                }
            }
            return obj;
        }

      

        public static DataSet GetAllByDirec(String cod1, String cod2 = null)
        {
            if (cod1 == null) throw new ArgumentNullException("cod1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByDirec);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, cod1);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, cod2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<Personal> SelectAllByDirec(String cod1, String cod2 = null)
        {
            if (cod1 == null) throw new ArgumentNullException("cod1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByDirec);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, cod1);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, cod2);

            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tPersonalList = new List<Personal>();
                while (dr.Read())
                {
                    var tPersonal = MakePersonal(dr);
                    tPersonalList.Add(tPersonal);
                }
                return tPersonalList;
            }
        }
        
        public static DataSet GetAllByRazon(String cod1, String cod2 = null)
        {
            if (cod1 == null) throw new ArgumentNullException("cod1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByRazon);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, cod1);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, cod2);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<Personal> SelectAllByRazon(String cod1, String cod2 = null)
        {
            if (cod1 == null) throw new ArgumentNullException("cod1");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByRazon);
            DATA.Db.AddInParameter(cmd, "Ape", DbType.String, cod1);
            DATA.Db.AddInParameter(cmd, "Nom", DbType.String, cod2);

            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tPersonalList = new List<Personal>();
                while (dr.Read())
                {
                    var tPersonal = MakePersonal(dr);
                    tPersonalList.Add(tPersonal);
                }
                return tPersonalList;
            }
        }
        
        public static DataSet GetAllByDocumento(String idcTipoDoc, String nroDocIden)
        {
            if (idcTipoDoc == null) throw new ArgumentNullException("idcTipoDoc");
            if (nroDocIden == null) throw new ArgumentNullException("nroDocIden");

            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByDirec);
            DATA.Db.AddInParameter(cmd, "IdcTipoDoc", DbType.String, idcTipoDoc);
            DATA.Db.AddInParameter(cmd, "nroDocIden", DbType.String, nroDocIden);
            return DATA.Db.ExecuteDataSet(cmd);
        }
        public static List<Personal> SelectAllByDocumento(String idcTipoDoc, String nroDocIden)
        {
            if (idcTipoDoc == null) throw new ArgumentNullException("idcTipoDoc");
            if (nroDocIden == null) throw new ArgumentNullException("nroDocIden");

            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByDirec);
            DATA.Db.AddInParameter(cmd, "IdcTipoDoc", DbType.String, idcTipoDoc);
            DATA.Db.AddInParameter(cmd, "nroDocIden", DbType.String, nroDocIden);

            using (var dr = DATA.Db.ExecuteReader(cmd))
            {
                var tPersonalList = new List<Personal>();
                while (dr.Read())
                {
                    var tPersonal = MakePersonal(dr);
                    tPersonalList.Add(tPersonal);
                }
                return tPersonalList;
            }
        }

        public static DataSet FiltroByRazon(string cFil1 = null, string cfil2 = null)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByRazon); //601
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "ape", DbType.String, cFil1);
            if (!string.IsNullOrEmpty(cfil2))
                DATA.Db.AddInParameter(cmd, "nom", DbType.String, cfil2);
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static DataSet FiltroByDoc(string cFil1)
        {
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.FiltroByDoc); //606
            if (!string.IsNullOrEmpty(cFil1))
                DATA.Db.AddInParameter(cmd, "ape", DbType.String, cFil1);
            return DATA.Db.ExecuteDataSet(cmd);
        }

		protected static Personal MakePersonal(IDataReader dr)
		{
		    var obj = new Personal();
		        obj.CodPersonal = dr.GetString(dr.GetOrdinal("CodPersonal"));
		        obj.Ape = dr.IsDBNull(dr.GetOrdinal("ape")) ? String.Empty : dr.GetString(dr.GetOrdinal("ape"));
		        obj.Nom = dr.IsDBNull(dr.GetOrdinal("nom")) ? String.Empty : dr.GetString(dr.GetOrdinal("nom"));
		        obj.Direc = dr.IsDBNull(dr.GetOrdinal("direc")) ? String.Empty : dr.GetString(dr.GetOrdinal("direc"));
		        obj.IdxTipoDoc = dr.IsDBNull(dr.GetOrdinal("idxTipoDoc")) ? String.Empty : dr.GetString(dr.GetOrdinal("idxTipoDoc"));
		        obj.NroDocIden = dr.IsDBNull(dr.GetOrdinal("nroDocIden")) ? String.Empty : dr.GetString(dr.GetOrdinal("nroDocIden"));
		        obj.Fecnac = dr.IsDBNull(dr.GetOrdinal("fecnac"))
		                ? new DateTime(1900, 01, 01)
		                : dr.GetDateTime(dr.GetOrdinal("fecnac"));
		        obj.Email = dr.IsDBNull(dr.GetOrdinal("email")) ? String.Empty : dr.GetString(dr.GetOrdinal("email"));
		        obj.Movil = dr.IsDBNull(dr.GetOrdinal("Movil")) ? String.Empty : dr.GetString(dr.GetOrdinal("Movil"));
		        obj.Nrofijo = dr.IsDBNull(dr.GetOrdinal("nrofijo")) ? String.Empty : dr.GetString(dr.GetOrdinal("nrofijo"));
		        obj.CodDis = dr.IsDBNull(dr.GetOrdinal("codDis")) ? String.Empty : dr.GetString(dr.GetOrdinal("codDis"));
		        obj.IdFotoDbExt = dr.IsDBNull(dr.GetOrdinal("IdFotoDbExt")) ? 0 : dr.GetInt32(dr.GetOrdinal("IdFotoDbExt"));
                obj.IdxCategoria = dr.IsDBNull(dr.GetOrdinal("IdxCategoria")) ? String.Empty : dr.GetString(dr.GetOrdinal("IdxCategoria"));
                obj.IdxCondicion = dr.IsDBNull(dr.GetOrdinal("IdxCondicion")) ? String.Empty : dr.GetString(dr.GetOrdinal("IdxCondicion"));
                obj.CodSubDep = dr.IsDBNull(dr.GetOrdinal("CodSubDep")) ? String.Empty : dr.GetString(dr.GetOrdinal("CodSubDep"));
    			return obj;
		}

        public static bool ExisteById(String codPersonal)
        {
            if (codPersonal == null) throw new ArgumentNullException("codPersonal");
            var cmd = DATA.Db.GetStoredProcCommand("sp_tPersonal");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, codPersonal);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            var ret = (int) DATA.Db.GetParameterValue(cmd,"@ret");
            return (ret > 0);
        }
	}
}
