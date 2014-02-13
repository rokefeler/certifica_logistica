using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmProveedor : Masterform
    {
        private Proveedor _obj;
        public FmProveedor()
        {
            InitializeComponent();
        }

        public override bool Master_NuevoFormulario()
        {
            EdRuc.EditValue = null;
            Value = String.Empty;
            TxtSituacion.Text = @"ACTIVO";
            ChkHabido.Checked = true;
            TxtRazon.Text = "";
            TxtRazonComercial.Text = "";
            TxtDireccion.Text = "";
            EdUbigeo.Text = "";
            TxtUbigeo.Text = "";
            TxtReferencia.Text = "";
            TxtTelefono.Text = "";
            TxtDni.Text = "";
            DtFecNac.EditValue = null;
            TxtContacto.Text = "";
            TxtCCI.Text = "";
            TxtRNP.Text = "";
            DtFecVencRNP.EditValue = null;
            TxtEmail.Text = "";
            TxtAgenteRetencion.Text = "";
            TxtTipoNegocio.Text = "";
            Cursor.Current = Cursors.Default;
            BtnImportarRuc.Enabled = true;
            EdRuc.Focus();
            return true;
        }

        public override bool Master_Verificar()
        {
            if (!SubVerificaSoloRuc()) return false;
            var msg = "Debe Ingresar El Nombre o Razon Social del Proveedor";
            if (TxtRazon.Text.Trim().Length <= 0)
            {
                General.ShowMessage(msg);
                TxtRazon.Focus();
                dxErrorProvider1.SetError(TxtRazon, msg);
                return false;
            }
            dxErrorProvider1.SetError(TxtRazon, "");

            msg = "Debe Ingresar la Dirección Principal del Proveedor";
            if (TxtDireccion.Text.Trim().Length <=0)
            {
                General.ShowMessage(msg);
                TxtDireccion.Focus();
                dxErrorProvider1.SetError(TxtDireccion, msg);
                return false;
            }
            dxErrorProvider1.SetError(TxtDireccion, "");
            return true;
        }

        public override bool Master_GrabarFormulario()
        {
            if (!Master_Verificar()) return false;
            if (_obj == null) _obj = new Proveedor();
            else _obj.Clear();

            _obj.Ruc = EdRuc.EditValue.ToString().Trim();
            _obj.Razon = TxtRazon.Text;
            _obj.RazonComercial = TxtRazonComercial.Text.Trim();
            _obj.Direccion = TxtDireccion.Text.Trim();
            _obj.Referencia = TxtReferencia.Text.Trim();
            _obj.Contacto = TxtContacto.Text;
            _obj.Telefono = TxtTelefono.Text;
            _obj.Email = TxtEmail.Text.Trim();
            _obj.AgenteRetencion = TxtAgenteRetencion.Text.Trim();
            _obj.Cci = TxtCCI.Text;
            _obj.Rnp = TxtRNP.Text;
            if (DtFecVencRNP.EditValue != null) 
                _obj.RnpVencimiento = DtFecVencRNP.DateTime; //verificar
            _obj.CodDis = EdUbigeo.EditValue.ToString().Trim();
            _obj.Situacion = TxtSituacion.Text;
            _obj.EsHabido = (ChkHabido.Checked) ? 'S' : 'N';
            _obj.TipoNegocio = TxtTipoNegocio.Text.Trim();
            _obj.Dni = TxtDni.Text.Trim();
            if(DtFecNac.EditValue!=null)
                _obj.FecNac = DtFecNac.DateTime;
            _obj.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            DbConnection con;
            DbTransaction dbTrans;
            var ret = 0;
            con = DATA.Db.CreateConnection();
            con.Open();
            dbTrans = con.BeginTransaction();
            string msg;
            try
            {
                ret=ProveedorDao.Grabar(_obj, dbTrans);
                msg = General.AnalizaResultadoSql(ret);
                if (ret > 0)
                    dbTrans.Commit();
                else
                    dbTrans.Rollback();
                General.ShowMessage(msg);
            }
            catch (SqlException sle)
            {
                dbTrans.Rollback();
                General.ShowMessage(sle.Message);
            }
            finally
            {
                if(con.State== ConnectionState.Open)
                    con.Close();
            }
            return (ret>0);
        }

        public override bool Master_CargarFicha(string idPrincipal, string idSecundario = null, int anio=2014)
        {
            _obj = ProveedorDao.GetbyId(idPrincipal);
            EdRuc.ResetBackColor();
            if (_obj == null)
            {
                General.ShowMessage("Ruc Ingresado no Existe");
                return false;
            }
   
            EdRuc.BackColor = Color.GreenYellow;
            TxtSituacion.Text = _obj.Situacion;
            ChkHabido.Checked = (_obj.EsHabido=='S');
            TxtRazon.Text = _obj.Razon;
            TxtRazonComercial.Text = _obj.RazonComercial;
            TxtDireccion.Text = _obj.Direccion;
            
            EdUbigeo.EditValue = _obj.CodDis;
            EdUbigeo_Leave(EdUbigeo,null);
            TxtReferencia.Text = _obj.Referencia;
            TxtTelefono.Text = _obj.Telefono;
            TxtDni.Text = _obj.Dni;
            if (_obj.FecNac.Year == 1900)
                DtFecNac.EditValue = null;
            else
                DtFecNac.EditValue = _obj.FecNac;
            TxtContacto.Text = _obj.Contacto;
            TxtCCI.Text = _obj.Cci;
            TxtRNP.Text = _obj.Rnp;
            if (_obj.RnpVencimiento.Year == 1900)
                DtFecVencRNP.EditValue = null;
            else
                DtFecVencRNP.EditValue = _obj.RnpVencimiento;
            TxtEmail.Text = _obj.Email;
            TxtAgenteRetencion.Text = _obj.AgenteRetencion;
            TxtTipoNegocio.Text = _obj.TipoNegocio;
            if (_obj.FechaModi.Year > 1900)
                TxtModificacion.Text = String.Format("Creado el {0} {1} - Modificado última vez por: {2} el {3} {4}",
                            _obj.FecNac.ToShortDateString(),
                            _obj.Fecha.ToShortTimeString(),
                            _obj.CodLogin, _obj.FechaModi.ToShortDateString(),_obj.FechaModi.ToShortTimeString());
            else
                TxtModificacion.Text = String.Format("Creado el {0} {1} - Por: {2}",
                            _obj.FecNac.ToShortDateString(), _obj.Fecha.ToShortTimeString(), _obj.CodLogin);
            return true;
        }

        private void BtnImportarRuc_Click(object sender, EventArgs e)
        {
            if (!SubVerificaSoloRuc()) return;
            Importarrucsunat(EdRuc.EditValue.ToString().Trim());
        }

        private bool SubVerificaSoloRuc()
        {
            var msg = "Debe Ingresar el Número de RUC a Importar";
            if (EdRuc.EditValue == null)
            {
                General.ShowMessage(msg);
                EdRuc.Focus();
                dxErrorProvider1.SetError(EdRuc, msg);
                return false;
            }

            msg = "RUC ingresado No Tiene la Longitud Correcta de digitos";
            if (EdRuc.EditValue.ToString().Length < 11)
            {
                General.ShowMessage(msg);
                EdRuc.Focus();
                dxErrorProvider1.SetError(EdRuc, msg);
                return false;
            }

            msg = "RUC ingresado es INVALIDO";
            if (!General.VerificarRuc(EdRuc.EditValue.ToString()))
            {
                General.ShowMessage(msg);
                EdRuc.Focus();
                dxErrorProvider1.SetError(EdRuc, msg);
                return false;
            }
            dxErrorProvider1.SetError(EdRuc, "");
            return true;
        }


        private void Importarrucsunat(String ruc)
        {
            var url = @"http://www.sunat.gob.pe/w/wapS01Alias?ruc=" + ruc;
            var cTipo = String.Empty;
            var cEstado = String.Empty;
            var cNombreComercial = String.Empty;
            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                Stream data;
                try
                {
                    BtnImportarRuc.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;
                    data = client.OpenRead(url);
                    Cursor.Current = Cursors.Default;
                    BtnImportarRuc.Enabled = true;
                }
                catch (WebException wex)
                {
                    General.ShowMessage(wex.Message);
                    return;
                }
                if (data == null) return;
                
                var reader = new StreamReader(data);
                var cad = reader.ReadToEnd();
                data.Close();
                reader.Close();

                cad = HtmlRemove.StripTagsCharArray(cad);
                cad = cad.Trim();
                if (cad.Length <= 300)
                {
                    MessageBox.Show(@"El número Ruc ingresado no existe en la Base de datos de la SUNAT");
                    return;
                }
                cad = cad.Replace("N&#xFA;mero Ruc.  " + ruc + " - ", "RazonSocial:");
                cad = cad.Replace("Estado.", "Estado:");
                cad = cad.Replace("Agente Retenci&#xF3;n IGV.", "AgenteRetencion:");
                cad = cad.Replace("Nombre Comercial.", "Nombre Comercial:");
                cad = cad.Replace("Direcci&#xF3;n.", "Direccion:");
                cad = cad.Replace("Situaci&#xF3;n.", "Situacion:");
                cad = cad.Replace("Tel&#xE9;fono(s).", "Telefono:");

                var cad1 = "RazonSocial:";
                var cad2 = "Antiguo Ruc.";
                var x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                var y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length + 1;
                var xRazSoc = cad.Substring(x, (y - x)).Trim();

                cad1 = "Estado:";
                cad2 = "AgenteRetencion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cEstado = cad.Substring(x, (y - x)).Trim();
                }

                cad1 = "AgenteRetencion:";
                cad2 = "Nombre Comercial:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cAgenteRetencion = cad.Substring(x, (y - x)).Trim();
                if (cAgenteRetencion.Length < 5) cAgenteRetencion = "";

                cad1 = "Nombre Comercial:";
                cad2 = "Direccion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cNombreComercial = cad.Substring(x, (y - x)).Trim();
                    if (cNombreComercial.Equals("-")) cNombreComercial = "";
                }

                    
                cad1 = "Direccion:";
                cad2 = "Situacion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cDireccion = cad.Substring(x, (y - x)).Trim();
                var split = cDireccion.Split(new[] { ' ' });
                var cDis = split[split.Length - 1];
                var cProv = split[split.Length - 2];
                var cDep = split[split.Length - 3];

                EdUbigeo.Text = DistritoDao.UbicaDistrito(cDis.ToUpper().Trim(), cProv.ToUpper().Trim(), cDep.ToUpper().Trim());
                var i = 0;
                cDireccion = "";
                foreach (string s in split)
                {
                    if (i < split.Length - 3)
                    {
                        if (s.Trim().Length > 0)
                            cDireccion += " " + s;
                    }
                    else
                        break;
                    i++;
                }
                cDireccion = cDireccion.Trim();
                //Ubica Ubigeo(cDep, cProv, cDis);
                cad1 = "Situacion:";
                cad2 = "Telefono:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cSituacion = cad.Substring(x, (y - x)).Trim();

                cad1 = "Telefono:";
                cad2 = "Dependencia.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cTelefono = cad.Substring(x, (y - x)).Trim();
                if (cTelefono.Length <= 2) cTelefono = "";

                cad1 = "Tipo.";
                cad2 = "DNI :";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (y < 0)
                {
                    cad2 = "Inicio Act.";
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                }
                if (x > 0 && y > 0)
                {
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                    x = x + cad1.Length;
                    cTipo = cad.Substring(x, (y - x)).Trim();
                }


                cad1 = "DNI :";
                cad2 = "Fecha Nacimiento.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                var cDni = String.Empty;
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cDni = cad.Substring(x, (y - x)).Trim();
                }

                cad1 = "Fecha Nacimiento.";
                cad2 = "Inicio Act.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);

                var cFecNac = String.Empty;
                if (x > 0)
                {
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                    x = x + cad1.Length;
                    cFecNac = cad.Substring(x, (y - x)).Trim();
                }

                xRazSoc = Limpiar(xRazSoc);
                cNombreComercial = Limpiar(cNombreComercial);
                cDireccion = Limpiar(cDireccion);
                cEstado = Limpiar(cEstado);
                cSituacion = Limpiar(cSituacion);
                cTelefono = Limpiar(cTelefono);
                cDni = Limpiar(cDni);
                cFecNac = Limpiar(cFecNac);
                cTipo = Limpiar(cTipo);
                //------------------------------
                TxtSituacion.Text = cEstado;
                ChkHabido.Checked = cSituacion.Equals("HABIDO");
                TxtRazon.Text = xRazSoc;
                TxtRazonComercial.Text = cNombreComercial;
                TxtDireccion.Text = cDireccion;
                TxtAgenteRetencion.Text = cAgenteRetencion;
                TxtTelefono.Text = cTelefono;
                TxtDni.Text = cDni;
                try
                {
                    DtFecNac.EditValue = Convert.ToDateTime(cFecNac);
                }
                catch (Exception)
                {
                    Console.Beep();
                    DtFecNac.EditValue = null;
                }
                TxtTipoNegocio.Text = cTipo;
                client.Dispose();
                //------------------------------
            }
        }

        private static String Limpiar(String cad)
        {
            cad = cad.Replace("&#209;", "Ñ");
            cad = cad.Replace("&#xD1;", "Ñ");
            cad = cad.Replace("&#193;", "Á");
            cad = cad.Replace("&#201;", "É");
            cad = cad.Replace("&#205;", "Í");
            cad = cad.Replace("&#211;", "Ó");
            cad = cad.Replace("&#218;", "Ú");
            cad = cad.Replace("&#xC1;", "Á");
            cad = cad.Replace("&#xC9;", "É");
            cad = cad.Replace("&#xCD;", "Í");
            cad = cad.Replace("&#xD3;", "Ó");
            cad = cad.Replace("&#xDA;", "Ú");

            return cad;
        }

        private void FmProveedor_Load(object sender, EventArgs e)
        {
            TxtModificacion.Text = String.Format("Creado el {0} {1} - Por: {2}",
                           DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), _FrmPadre.Miconfiguracion.IdUsuario);
            EdRuc.Focus();
        }

        private void EdRuc_Leave(object sender, EventArgs e)
        {
            if (!SubVerificaSoloRuc()) return;
            Value = EdRuc.EditValue.ToString().Trim();
            if(EdRuc.IsModified)
                Master_CargarFicha(Value);
        }

        private void EdUbigeo_Leave(object sender, EventArgs e)
        {
            try
            {
                var coddis = EdUbigeo.Text.Trim();
                dxErrorProvider1.SetError(EdUbigeo, "");
                if (string.IsNullOrEmpty(coddis))
                {
                    dxErrorProvider1.SetError(EdUbigeo, "Ingrese Código de Ubigeo - Ej: 040101");
                    return;
                }
                var d = DistritoDao.GetbyId(coddis);
                if (d == null)
                {
                    TxtUbigeo.Text = @"Código de Ubigeo no Existe!";
                    dxErrorProvider1.SetError(EdUbigeo, "Código de Ubigeo no Existe!");
                }
                else
                {
                    TxtUbigeo.Text = d.NombreCompleto;
                }
            }
            catch (Exception)
            {
                TxtUbigeo.Text = String.Empty;
            }

        }


    }
}
