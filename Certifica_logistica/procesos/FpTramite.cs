using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

namespace Certifica_logistica.procesos
{
    public partial class FpTramite : Masterform
    {
        private DataTable _tb;
        private Expediente _exp;
        public FpTramite()
        {
            InitializeComponent();
        }

        public override bool Master_Verificar()
        {
            Decimal dval;
            int ival;
            string msg;
            if (EdIdExpediente.EditValue == null)
                msg = String.Empty;
            else
            {
                if (EdIdExpediente.Text.Trim().Length <= 0)
                    msg = String.Empty;
                else
                    msg = EdIdExpediente.Text;
            }

            if (String.IsNullOrEmpty(msg))
            {
                msg = "Por Favor Debe Ingresar el nro. de Exp. Asignado por Mesa de Partes";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdIdExpediente, msg);
                EdIdExpediente.Focus();
                return false;
            }


            dxErrorProvider1.SetError(EdIdExpediente, "");
            if (DtFechaExp.DateTime.Year <= 1900)
            {
                msg="Debe Ingresar la Fecha del Expediente";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(DtFechaExp,msg);
                DtFechaExp.Focus();
                return false;
            }
            dxErrorProvider1.SetError(DtFechaExp, "");
            if (DtFechaIngresoExp.DateTime.Year <= 1900)
            {
                msg = "Debe Ingresar la Fecha de Recepción de Este Documento, se Coloca Fecha Actual";
                General.ShowMessage(msg);
                DtFechaIngresoExp.DateTime = new DateTime();
                DtFechaIngresoExp.Focus();
                return false;
            }
            var cad = "0" + TxtNroAutorizacion.Text.Trim();
            if (!int.TryParse(cad, out ival))
            {
                msg = "El Nro Ingresado no de la autorización no es un valor Válido";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtNroAutorizacion, msg);
                TxtNroAutorizacion.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtNroAutorizacion, "");
            cad = "0"+TxtMontoAprobado.Text.Trim();
            if (!Decimal.TryParse(cad, out dval))
            {
                msg = "El Monto de aprobación Rectoral que Ingreso, No es un Valor valido";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtMontoAprobado, msg);
                TxtMontoAprobado.Focus();
                return false;
            }
            if (dval<0)
            {
                msg = "El Monto de aprobación Rectoral No puede ser UN VALOR NEGATIVO";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtMontoAprobado, msg);
                TxtMontoAprobado.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtMontoAprobado, "");


            if (EdCodSubDep.EditValue ==null)
            {
                msg = "Debe Seleccionar la SubDependencia a la que pertence el Documento que esta Registrando";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdCodSubDep, msg);
                EdCodSubDep.Focus();
                return false;
            }
            
            cad = EdCodSubDep.Text.Trim();
            if (cad.Length <= 0)
            {
                msg = "Debe Seleccionar la SubDependencia a la que pertence el Documento que esta Registrando";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdCodSubDep, msg);
                EdCodSubDep.Focus();
                return false;
            }
            dxErrorProvider1.SetError(EdCodSubDep, "");
            //---------------------------------------------
            if (EdCodSubDep_Recibe .EditValue == null)
            {
                msg = "Debe Seleccionar la SubDependencia Que Entrego este Expediente";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdCodSubDep_Recibe, msg);
                EdCodSubDep_Recibe.Focus();
                return false;
            }

            cad = EdCodSubDep_Recibe.Text.Trim();
            if (cad.Length <= 0)
            {
                msg = "Debe Seleccionar la SubDependencia Que Entrego este Expediente";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdCodSubDep_Recibe, msg);
                EdCodSubDep_Recibe.Focus();
                return false;
            }
            dxErrorProvider1.SetError(EdCodSubDep_Recibe, "");
            //---------------------------------------------
            cad = TxtNroDoc.Text;
            if (cad.Length <= 0)
            {
                msg = "Debe Ingresar el Nro del Documento Recepcionado o a Tramitar";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtNroDoc, msg);
                TxtNroDoc.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtNroDoc, "");
            
            cad = TxtAsunto.Text;
            if (cad.Length <= 0)
            {
                msg = "Debe Ingresar el Asunto o Resumen de Solicitud de Documento";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtAsunto, msg);
                TxtAsunto.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtAsunto, "");

            cad = TxtFolios.Text;
            if (cad.Length <= 0)
            {
                msg = "Debe Ingresar la Cantidad de Folios del Expediente";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtFolios, msg);
                TxtFolios.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtFolios, "");

            if(!int.TryParse(cad,out ival))
            {
                msg = "El Valor Ingresado en Folios no es un numero Entero Válido";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtFolios, msg);
                TxtFolios.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtObsv, "");

            if (TxtObsv.Text.Trim().Length>0 && TxtObsv.Text.Trim().Length<=4)
            {
                msg = "La Longitud de la Observación es muy Corta, debe ser mas de 4 caracteres";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(TxtObsv, msg);
                TxtObsv.Focus();
                return false;
            }
            
            /*
            if (EdIdRubro.EditValue == null)
            {
                msg = "Debe Ingresar El Rubro de la Fuente de Financiamiento";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdIdRubro, msg);
                EdIdRubro.Focus();
                return false;
            }
            if (EdIdMeta.EditValue == null)
            {
                msg = "Debe Ingresar La Meta de la Fuente de Financiamiento";
                General.ShowMessage(msg);
                dxErrorProvider1.SetError(EdIdMeta, msg);
                EdIdMeta.Focus();
                return false;
            }
           */

            return true;

        }

        public override bool Master_GrabarFormulario()
        {
            var bExisteExp = false;
            string cad;
            DbConnection con=null;
            DbTransaction dbtrans = null;
            if (!Master_Verificar())
                    return false;

            Value = EdIdExpediente.Text.Trim().PadLeft(6,'0');
            Value = Value + "-" + CboYearExp.SelectedItem;
            if(_exp==null)
                _exp=new Expediente();
            else
                _exp.Clear();

            //Verificar si Existe
            bExisteExp = ExpedienteDao.ExisteById(Value);

            _exp.Idexpediente = Value;
            _exp.FechaIngreso = DtFechaIngresoExp.DateTime;
            _exp.FechaExp = DtFechaExp.DateTime;
            if (TxtNroAutorizacion.Text.Trim().Length > 0)
                _exp.CNroAuto = TxtNroAutorizacion.Text;
            _exp.Moneda = CboMoneda.SelectedItem.ToString()[0];
            if (TxtMontoAprobado.Text.Trim().Length > 0)
                _exp.MontoAprobado = Convert.ToDecimal(TxtMontoAprobado.Text);
            _exp.CodSubDepOrigen = EdCodSubDep.Text;
            _exp.CodSubDepEntrega = EdCodSubDep_Recibe.Text;
            var cod = (Codigo)CboTipoDoc.SelectedItem;
            _exp.IdxTipoDocTra = cod.Id;
            _exp.Nrodoc = TxtNroDoc.Text;
            _exp.Asunto = TxtAsunto.Text;
            _exp.Folios = Convert.ToInt16(TxtFolios.Text);
            /*_exp.Ccp = TxtCcp.Text;
            if (EdIdRubro.Tag != null)
                if (!string.IsNullOrEmpty(EdIdRubro.Tag.ToString()))
                    _exp.IdRubro = Convert.ToInt32(EdIdRubro.Tag.ToString());
            if (EdIdMeta.Tag != null)
                if (!string.IsNullOrEmpty(EdIdMeta.Tag.ToString()))
                    _exp.IdMeta = Convert.ToInt32(EdIdMeta.Tag.ToString());
            */
            _exp.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            _exp.IdFuente = ((FuenteFinanciamiento)CboFuente.SelectedItem).IdFuente;
            
            try
            {
                con = DATA.Db.CreateConnection();
                con.Open();
                dbtrans = con.BeginTransaction();
                var ret = ExpedienteDao.Grabar(_exp, dbtrans);
                _exp.Nlog = ret; //grabar el nro de Log
                TxtnLog.Text = @"Log:" + _exp.Nlog.ToString(CultureInfo.InvariantCulture).PadLeft(6, '0');
                cad = General.AnalizaResultadoSql(ret);
                if (ret > 0)
                {
                    if (!bExisteExp) //Si es un Exp Nuevo, grabar por defecto inicio de derivación
                    {
                        //Pasar Expediente a Estado por Revisar
                        var det = new DetExpediente();
                        det.IdExpediente = _exp.Idexpediente;
                        var codSubDepOrigen = EdCodSubDep_Recibe.EditValue.ToString().Trim();
                        det.CodSubDepOrigen = codSubDepOrigen;
                        det.FechaRecepcion = _exp.FechaIngreso;
                        var obj = LoginDao.GetbyId(_FrmPadre.Miconfiguracion.IdUsuario);
                        det.CodPersonalOrigen = obj.CodPersonal;
                        det.IdxEstadoExp = "DEES-0000"; //Estado inicial por Revisa
                        det.Detalle = "Recepción Doc. por realizar Despacho";
                        det.Aceptado = false;
                        det.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
                        ret = DetExpedienteDao.GrabarInicial(det, dbtrans);
                    }
                    if (ret > 0)
                    {
                        //Ahora en Cadena, Grabar Observación Si Existe
                        if (!String.IsNullOrEmpty(TxtObsv.Text))
                        {
                            var obsv = new ObservacionExpediente(_exp.Idexpediente, TxtObsv.Text, _FrmPadre.Miconfiguracion.IdUsuario);
                            ret = ObservacionExpedienteDao.Grabar(obsv, dbtrans);
                        }
                        if (ret > 0)
                        {
                            dbtrans.Commit();
                            MessageBox.Show(cad, @"Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            VerDetalleExpediente();
                        }
                     }
                }
                if(ret<=0)
                {
                    dbtrans.Rollback();
                    General.ShowMessage(cad);
                }
            }
            catch (SqlException ex)
            {
                if (dbtrans != null) dbtrans.Rollback();
                General.ShowMessage(ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            return true;
        }

        public override bool Master_NuevoFormulario()
        {
            return Master_LimpiarFormulario();
        }

        public override bool Master_LimpiarFormulario()
        {
            Value = String.Empty;
            EdIdExpediente.EditValue = null;
            CboYearExp.SelectedIndex = 0;
            //DtFechaExp.EditValue = null; //mantener por indic. de SUssy
            DtFechaIngresoExp.EditValue = DateTime.Now;
            //CboFuente.SelectedIndex = 3;
            CboMoneda.SelectedIndex = 0;
            TxtNroAutorizacion.Text = "";
            TxtMontoAprobado.Text = "";
            //EdCodSubDep.EditValue = null;  //Queda misma Dependencia  por defecto, segun sussy
            //TxtDependencia.Text = "";
            //toolTipController1.SetToolTip(TxtDependencia,"");
            //TxtSubDependencia.Text = "";
            //toolTipController1.SetToolTip(TxtSubDependencia,"");
            General.CargarDatos(CboTipoDoc, "TDTR", "TDTR-0001"); //por defecto oficio seleccionado
            TxtNroDoc.Text = "";
            TxtAsunto.Text = "";
            TxtFolios.Text = @"01"; //por defecto
            LstObsv.DataSource = null;
            TxtObsv.Text = "";
            toolTipController1.SetToolTip(LstObsv, "");
            toolTipController1.SetToolTip(TxtObsv, "");
            _tb.Rows.Clear(); //limpioar registros
            Text = Tag + @"Modificado por : " + _FrmPadre.Miconfiguracion.IdUsuario +
            @" El " + DateTime.Now.ToShortDateString() + @" " + DateTime.Now.ToShortTimeString();
            TxtnLog.Text = "";
            EdIdExpediente.ResetBackColor();
            if(_exp!=null) _exp.Clear();
            EdIdExpediente.Focus();
            
            return true;
        }

        public override bool Master_CargarFicha(string idPrincipal, string idSecundario = null)
        {
            BtnObsv.Enabled = false;
            _exp = ExpedienteDao.GetbyId(idPrincipal);
            EdIdExpediente.ResetBackColor();
            CboYearExp.ResetBackColor();
            if (_exp == null)
            {
                Console.Beep();
                toolTipController1.ShowHint("El Expediente Ingresado " + idPrincipal + " No Existe");
                return false;
            }
            EdIdExpediente.BackColor = Color.LightGreen;
            CboYearExp.BackColor = Color.LightGreen;
            Value = idPrincipal;
            DtFechaExp.DateTime = _exp.FechaExp;
            DtFechaIngresoExp.DateTime = _exp.FechaIngreso;
            for (var x = 0; x < CboFuente.Items.Count; x++)
            {
                var fte = (FuenteFinanciamiento) CboFuente.Items[x];
                if (fte.IdFuente == _exp.IdFuente)
                {
                    CboFuente.SelectedIndex = x;
                    break;
                }
            }
            for (int x = 0; x < CboMoneda.Items.Count; x++)
            {
                var m = CboMoneda.Items[x].ToString()[0];
                if (_exp.Moneda==m)
                {
                    CboMoneda.SelectedIndex = x;
                    break;
                }
            }

            TxtNroAutorizacion.Text = _exp.CNroAuto;
            if(_exp.MontoAprobado <= 0)
                TxtMontoAprobado.Text = "";
            else
                TxtMontoAprobado.Text = _exp.MontoAprobado.ToString("####00.00");
            EdCodSubDep.IsModified = true;
            EdCodSubDep_Recibe.IsModified = true;

            EdCodSubDep.EditValue = _exp.CodSubDepOrigen;
            EdCodSubDep_Leave(EdCodSubDep,null);
            EdCodSubDep_Recibe.EditValue = _exp.CodSubDepEntrega;
            EdCodSubDep_Leave(EdCodSubDep_Recibe, null);
            General.UbicaItemsComboCodigo(CboTipoDoc,_exp.IdxTipoDocTra);
            TxtNroDoc.Text = _exp.Nrodoc;
            TxtAsunto.Text = _exp.Asunto;
            TxtFolios.Text = _exp.Folios.ToString("#00");
            TxtnLog.Text = @"Log:" + _exp.Nlog.ToString(CultureInfo.InvariantCulture).PadLeft(6, '0');
            BtnObsv.Enabled = true;
            //Cargar Observaciones
            VerDetalleExpediente();
            return true;
        }

        private void FpTramite_Load(object sender, EventArgs e)
        {
            var ninicial = DateTime.Now.Year;
            CboYearExp.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));

            /*CboPeriodo.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboPeriodo.Items.Add(i.ToString(CultureInfo.InvariantCulture));
            CboPeriodo.SelectedIndex = 0;
             * */
            CboYearExp.SelectedIndex = 0;
            CboMoneda.SelectedIndex = 0;
            General.CargarDatos(CboTipoDoc, "TDTR", "TDTR-0001"); //por defecto oficio seleccionado
            CboFuente.DataSource = FuenteFinanciamientoDao.SelectAll();
            CboFuente.ValueMember = "IdFuente";
            CboFuente.DisplayMember = "Abreviacion";
            CboFuente.SelectedIndex = 3;
            DtFechaIngresoExp.EditValue = DateTime.Now;
            DtFechaExp.DateTime = DateTime.Now; //Por Defecto Fecha de Hoy
            EdCodSubDep_Recibe.EditValue = @"NCS";
            EdCodSubDep_Recibe.IsModified = true;
            EdCodSubDep_Leave(EdCodSubDep_Recibe,null);
            Text = Tag + @"Modificado por : " + _FrmPadre.Miconfiguracion.IdUsuario + 
                        @" El " + DateTime.Now.ToShortDateString() + @" " + DateTime.Now.ToShortTimeString();
            EdIdExpediente.Focus();
           

        }
       
        private void VerDetalleExpediente()
        {
            var ds = DetExpedienteDao.GetDetalle(Value);
            if (ds.Tables.Count <= 0) return;
            _tb = ds.Tables[0];
            gridControl1.DataSource = _tb;
            //gridView1.Columns[3].Visible = false; //Escondr Columna
            //gridView1.Editable = false;
            for (var i = 1; i <= 8; i++)
                gridView1.Columns[i].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;

            gridView1.Columns[0].SummaryItem.SummaryType = SummaryItemType.Count;
            gridView1.Columns[0].SummaryItem.DisplayFormat = @"{0} Mov.";
            gridView1.BestFitColumns();
            /*
                gridView1.Columns[16].SummaryItem.SummaryType = SummaryItemType.Sum;
                gridView1.Columns[16].SummaryItem.DisplayFormat = "Suma={0}";
                 * */

            /* Ahora las Observaciones */
            VerDetalleObservaciones();
        }

        private void VerDetalleObservaciones()
        {
            if (string.IsNullOrEmpty(Value)) return;
            LstObsv.DataSource = ObservacionExpedienteDao.SelectAllExpediente(Value);
            LstObsv.DisplayMember = "Display";
            LstObsv.ValueMember = "Id";
            if (LstObsv.DataSource!=null )
                LstObsv.SelectedIndex = 0;
        }

        private void EdIdExpediente_Leave(object sender, EventArgs e)
        {
            if (!EdIdExpediente.IsModified) {
                Console.Beep();
                return;
            }
            if (EdIdExpediente.EditValue == null) return;
            var cNroExp = EdIdExpediente.EditValue.ToString();
            if(cNroExp.Length<=0) return;
            cNroExp = cNroExp.PadLeft(6, '0');
            EdIdExpediente.EditValue = cNroExp;
            cNroExp = cNroExp + "-" + CboYearExp.SelectedItem;
            Master_CargarFicha(cNroExp);
        }

        private void LstObsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtObsv.Text = "";
            toolTipController1.SetToolTip(TxtObsv, "");
            toolTipController1.SetToolTip(LstObsv, "");
            try
            {
                var cad = @"Reg. por:";
                var obsv = (ObservacionExpediente) LstObsv.SelectedItem;
                cad = String.Format("{0} {1}", cad, obsv.CodLogin);
                TxtObsv.Text = string.Format(@"[{0} {1}] {2}", obsv.CodLogin, obsv.Display, obsv.Detalle);
                toolTipController1.SetToolTip(TxtObsv, cad);
                toolTipController1.SetToolTip(LstObsv, cad);
            }
            catch 
            {
                Console.Beep();
            }
        }
        private void LstObsv_DoubleClick(object sender, EventArgs e)
        {
            LstObsv_SelectedIndexChanged(sender, e);
        }

        private void CboYearExp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EdIdExpediente.EditValue == null) return;
            var cNroExp = EdIdExpediente.EditValue.ToString();
            if (cNroExp.Length <= 0) return;
            cNroExp = cNroExp.PadLeft(6, '0') + "-" + CboYearExp.SelectedItem;
            Master_CargarFicha(cNroExp);
        }

        private void BtnObsv_Click(object sender, EventArgs e)
        {
            if (Value.Length <= 0) return;
            dxErrorProvider1.SetError(TxtObsv, "");
            if (TxtObsv.Text.Length <= 3)
            {
                var cad = "La Longitud de la Observación es muy Corta, debe ser mas de 4 caracteres";
                General.ShowMessage(cad);
                dxErrorProvider1.SetError(TxtObsv,cad);
                return;
            }
            var obj = new ObservacionExpediente(Value, TxtObsv.Text,_FrmPadre.Miconfiguracion.IdUsuario);
            ObservacionExpedienteDao.Grabar(obj, null);
            VerDetalleObservaciones();
        }


        #region Llamadas a SubFormularios de Busqueda y Ayuda
        private void EdCodSubDep_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var btn = (ButtonEdit)sender;
            var oFrm = new FphSubDependencia { _TiTuloForm = "Busqueda De SubDependencia Institucional", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            btn.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(btn, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }

        private void EdCodSubDep_Leave(object sender, EventArgs e)
        {
            var btn = (ButtonEdit)sender;
            if (!btn.IsModified)
            {
                Console.Beep();
                return;
            } //Si no se hizo modificaciones, salir
        TextBox t1, t2;
            if (btn.Name.Equals("EdCodSubDep"))
            {
                t1 = TxtSubDependencia;
                t2 = TxtDependencia;
            }
            else
            {
                t1 = TxtSubDependencia_Recibe;
                t2 = TxtDependencia_Recibe;
            }
            t1.Text = "";
            t2.Text = "";
            toolTipController1.SetToolTip(t1, "");
            toolTipController1.SetToolTip(t2, "");
            dxErrorProvider1.SetError(btn, "");
            if (btn.EditValue == null) return;
            if (btn.EditValue.ToString().Length <= 0) return;

            var cod = btn.EditValue.ToString().ToUpper();
            if (cod.Length <= 0) return;
            var obj = SubDependenciaDao.GetbyId(cod);
            if (obj == null)
            {
                dxErrorProvider1.SetError(btn, "Este Valor Ingresado no Existe");
                return;
            }
            t1.Text = obj.Nombre;
            var obj2 = DependenciaDao.GetbyId(obj.CodDependencia);
            t2.Text = obj2.Nombre;
            toolTipController1.SetToolTip(t1, obj.Nombre);
            toolTipController1.SetToolTip(t2, obj2.Nombre);
        }
        #endregion

        private void LstObsv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (String.IsNullOrEmpty(Value)) return;
                var con = DATA.Db.CreateConnection();
                con.Open();
                var dbTrans = con.BeginTransaction();
                try
                {
// ReSharper disable once RedundantAssignment
                    var ret = 0;
// ReSharper disable once RedundantAssignment
                    var cad = String.Empty;
                    var o = (ObservacionExpediente) LstObsv.SelectedItem;

                    if (o.Id > 0)
                    {

                        ret = ObservacionExpedienteDao.Delete(o.Id, _FrmPadre.Miconfiguracion.IdUsuario, dbTrans);
                        if (ret >= 0)
                        {
                            dbTrans.Commit();
                            General.ShowMessage(string.Format("Observación del {0} Fue Eliminada Correctamente",
                                o.Display));
                            EdIdExpediente.IsModified = true; //marcar que se modifico el control para refrescos
                            VerDetalleObservaciones(); //Refrescar
                        }
                        else
                        {
                            dbTrans.Rollback();
                            cad = General.AnalizaResultadoSql(ret);
                            General.ShowMessage(cad);
                        }
                    }
                }
                catch (Exception)
                {
                    dbTrans.Rollback();
                    Console.Beep();
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }
      
        /*
        private void buttonEdit3_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oFrm = new FphMeta { _TiTuloForm = "Busqueda De Metas Presupuestales", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            if (oFrm._Codigo.Length > 0)
            {
                TxtMeta.Text = oFrm._Nombre;
                toolTipController1.SetToolTip(TxtMeta, oFrm._Nombre);
                var obj = MetaDao.GetbyId(Convert.ToInt32(oFrm._Codigo));
                EdIdMeta.Tag = oFrm._Codigo; //cod. principal ID
                EdIdMeta.Text = obj.Cnro;
            }
            oFrm.Close();
            ResumeLayout();
        }
        
        private void EdIdMeta_Leave(object sender, EventArgs e)
        {
            if (EdIdMeta.EditValue == null) return;
            var anio = CboPeriodo.SelectedItem.ToString();
            var cnro = EdIdMeta.EditValue.ToString();
            if(cnro.Length<=0) return;

            var obj = MetaDao.GetbyNroAnio(cnro, anio);
            if (obj == null)
            {
                General.ShowMessage("Codigo de Meta No Existe","Reintente por favor", icon: MessageBoxIcon.Exclamation );
                return;
            }
            toolTipController1.SetToolTip(TxtMeta, obj.Descripcion);
            TxtMeta.Text = obj.Descripcion;
            EdIdMeta.Tag = obj.IdMeta;
        }
        
        private void EdIdRubro_Leave(object sender, EventArgs e)
        {
            TxtRubro.Text = "";
            if (EdIdRubro.EditValue == null) return;
            var anio = CboPeriodo.SelectedItem.ToString();
            var cnro = EdIdRubro.EditValue.ToString();
            if (cnro.Length <= 0) return;
            var obj = RubroFinanciamientoDao.GetbyNroAnio(cnro, anio);
            if (obj == null)
            {
                General.ShowMessage("Codigo de RUBRO " + cnro +"-" + anio +" NO EXISTE","Reintente por favor", icon: MessageBoxIcon.Exclamation );
                EdIdRubro.Text = "";
                EdIdRubro.Tag = "";
                return;
            }
            TxtRubro.Text = obj.Nombre;
            toolTipController1.SetToolTip(TxtRubro,obj.Nombre);
            EdIdRubro.Tag = obj.IdRubro.ToString(CultureInfo.InvariantCulture);
        }

        private void EdIdRubro_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var oFrm = new FphRubro { _TiTuloForm = "Busqueda De Rubros de Financiamiento", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            if (oFrm._Codigo.Length > 0)
            {
                TxtRubro.Text = oFrm._Nombre;
                var obj = RubroFinanciamientoDao.GetbyId(Convert.ToInt32(oFrm._Codigo));
                toolTipController1.SetToolTip(TxtRubro, obj.Nombre);
                EdIdRubro.Tag = oFrm._Codigo; //cod. principal ID
                EdIdRubro.Text = obj.Codigo;
            }
            oFrm.Close();
            ResumeLayout();
        }
        */
 
    }
}
