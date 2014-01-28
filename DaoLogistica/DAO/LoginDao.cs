using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using DaoLogistica.ENTIDAD;

namespace DaoLogistica.DAO
{
	public class LoginDao
	{
        public static int Grabar(Login tLogin, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.InsertUpdate);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, tLogin.CodLogin);
            DATA.Db.AddInParameter(cmd, "CodPersonal", DbType.String, tLogin.CodPersonal);
            DATA.Db.AddInParameter(cmd, "Clave", DbType.String, tLogin.Clave);
            //DATA.Db.AddInParameter(cmd, "Ultimo_Acceso", DbType.Decimal, tLogin.UltimoAcceso);
            DATA.Db.AddInParameter(cmd, "Preg01", DbType.String, (tLogin.Preg01 == String.Empty) ? Convert.DBNull : tLogin.Preg01);
            DATA.Db.AddInParameter(cmd, "Preg02", DbType.String, (tLogin.Preg02 == String.Empty) ? Convert.DBNull : tLogin.Preg02);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.String, tLogin.Estado);
            DATA.Db.AddInParameter(cmd, "CodLogin_Ori", DbType.String, tLogin.CodLoginOri);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int CambiarClave(Login tLogin, DbTransaction dbTrans)
        {
            // ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.SetClave);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, tLogin.CodLogin);
            DATA.Db.AddInParameter(cmd, "Clave", DbType.String, tLogin.Clave);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int MarcarRegistro(string codLogin, int idIngreso, string Ip, DbTransaction dbTrans=null)
        {
            // ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.MarcarIngresouSalida); //102
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddInParameter(cmd, "Ip", DbType.String, Ip);
            DATA.Db.AddInParameter(cmd, "IdIngreso", DbType.Int32, idIngreso);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret; //devuelve el id único del registro
        }
        public static int Delete(String codLogin, DbTransaction dbTrans)
        {
// ReSharper disable once RedundantAssignment
            int ret = -1;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.DeleteLogico);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }

        public static Login GetbyId(String codLogin)
        {
            Login obj = null;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetById);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddInParameter(cmd, "ClaveSyn", DbType.String, DATA.ClaveSyn);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    obj = MakeLogin(dr);
                }
            }
            return obj;
        }
        /*
        /// <summary>
        /// Retorna el Hash de la Clave que estuvo Almacenado en la Database, Deben comparar Hash en Capa de Negocios u Presentación
        /// </summary>
        /// <param name="codLogin">Login del Usuario</param>
        /// <returns></returns>
        public static String GetHashClaveById(String codLogin)
        {
            if (codLogin == null) throw new ArgumentNullException("codLogin");
            CryptographyManager crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetClave);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            //Obtener el campo Varbinary en array de bytes
            byte[] bClaveVarBinary = (byte[])DATA.Db.ExecuteScalar(cmd);

            ASCIIEncoding codificador = new ASCIIEncoding();
            String hashEncryptado = codificador.GetString(bClaveVarBinary);

            return crypto.DecryptSymmetric(DATA.ClaveSyn,hashEncryptado);
            //return (new UnicodeEncoding()).GetString(Desencryptado);
        }
        public static int SaveHashClaveById(String codLogin, String hashPlainText, DbTransaction dbTrans=null)
        {
            int ret = -1;
            if (codLogin == null) throw new ArgumentNullException("codLogin");
            CryptographyManager crypto = EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.SetClave);
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            
            String hashEncryptado = crypto.EncryptSymmetric(DATA.ClaveSyn, hashPlainText);
            //Ahora convertir Hash encryptado a bytes
            ASCIIEncoding codificador = new ASCIIEncoding();
            byte[] bClaveVarBinary = codificador.GetBytes(hashEncryptado);

            DATA.Db.AddInParameter(cmd, "Clave", DbType.Object, bClaveVarBinary);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);

            if (dbTrans != null)
                DATA.Db.ExecuteNonQuery(cmd, dbTrans);
            else
                DATA.Db.ExecuteNonQuery(cmd);
            ret = (int)DATA.Db.GetParameterValue(cmd, "@ret");
            return ret;
        }*/
        public static DataSet GetbyAllByEstado(Char eStado)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByEstado);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.String, Convert.ToString(eStado));
            return DATA.Db.ExecuteDataSet(cmd);
        }

        public static List<Login> SelectAllByEstado(Char eStado)
        {
            DbCommand cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.GetByEstado);
            DATA.Db.AddInParameter(cmd, "Estado", DbType.String, Convert.ToString(eStado));
            using (IDataReader dr = DATA.Db.ExecuteReader(cmd))
            {
                var tLoginList = new List<Login>();
                while (dr.Read())
                {
                    Login tDerecho = MakeLogin(dr);
                    tLoginList.Add(tDerecho);
                }
                return tLoginList;
            }
        }
        public static bool ExisteId(String codLogin)
        {
            int ret=0;
            var cmd = DATA.Db.GetStoredProcCommand("sp_tLogin");
            DATA.Db.AddInParameter(cmd, "tipo_select", DbType.Int32, Select_SQL.ExistsId); //400
            DATA.Db.AddInParameter(cmd, "CodLogin", DbType.String, codLogin);
            DATA.Db.AddInParameter(cmd, "ClaveSyn", DbType.String, DATA.ClaveSyn);
            DATA.Db.AddOutParameter(cmd, "ret", DbType.Int32, 10);
            DATA.Db.ExecuteNonQuery(cmd);
            ret = (int) DATA.Db.GetParameterValue(cmd, "@ret");
            return (ret > 0);
        }
		protected static Login MakeLogin(IDataReader dr)
		{
		    var obj = new Login
		    {
		        CodLogin = dr.IsDBNull(dr.GetOrdinal("codLogin"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("codLogin")),
		        CodPersonal = dr.IsDBNull(dr.GetOrdinal("CodPersonal"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("CodPersonal")),
		        //Clave por Defecto sera nulo, Utilizar Otra FUncion para Leer solo la Clave
		        Clave = dr.IsDBNull(dr.GetOrdinal("clave"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("clave")),
		        UltimoAcceso = dr.IsDBNull(dr.GetOrdinal("ultimo_acceso"))
		            ? new DateTime(1900, 01, 01)
		            : dr.GetDateTime(dr.GetOrdinal("ultimo_acceso")),
		        Preg01 = dr.IsDBNull(dr.GetOrdinal("preg01"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("preg01")),
		        Preg02 = dr.IsDBNull(dr.GetOrdinal("preg02"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("preg02")),
		        Estado = (dr.IsDBNull(dr.GetOrdinal("Estado"))
		            ? 'S'
		            : Convert.ToChar(dr.GetValue(dr.GetOrdinal("estado")))),
		        CodLoginOri = dr.IsDBNull(dr.GetOrdinal("CodLogin_ori"))
		            ? String.Empty
		            : dr.GetString(dr.GetOrdinal("CodLogin_ori"))
		    };
			return obj;
		}

	}
}
