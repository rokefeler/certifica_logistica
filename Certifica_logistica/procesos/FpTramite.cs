using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Certifica_logistica.procesos
{
    public partial class FpTramite : Masterform
    {
        private Expediente _exp;
        public FpTramite()
        {
            InitializeComponent();
        }

        public override bool Master_Verificar()
        {
            Decimal dval;
            int ival;
            var msg = String.Empty;
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
            dxErrorProvider1.SetError(TxtFolios, "");
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
            string cad;
            DbConnection con=null;
            DbTransaction dbtrans = null;
            if (!Master_Verificar())
                    return false;

            Value = EdIdExpediente.Text.Trim() + "-" + CboYearExp.SelectedItem;
            if(_exp==null)
                _exp=new Expediente();
            else
                _exp.Clear();


            _exp.Idexpediente = Value;
            _exp.FechaIngreso = DtFechaIngresoExp.DateTime;
            _exp.FechaExp = DtFechaExp.DateTime;
            if (TxtNroAutorizacion.Text.Trim().Length > 0)
                _exp.CNroAuto = TxtNroAutorizacion.Text;
            _exp.Moneda = CboMoneda.SelectedItem.ToString()[0];
            if (TxtMontoAprobado.Text.Trim().Length > 0)
                _exp.MontoAprobado = Convert.ToDecimal(TxtMontoAprobado.Text);
            _exp.CodSubDepOrigen = EdCodSubDep.Text;
            var cod = (Codigo)CboTipoDoc.SelectedItem;
            _exp.IdxTipoDocTra = cod.Id;
            _exp.Nrodoc = TxtNroDoc.Text;
            _exp.Asunto = TxtAsunto.Text;
            _exp.Folios = Convert.ToInt16(TxtFolios.Text);
            _exp.Ccp = TxtCcp.Text;
            if (EdIdRubro.Tag != null)
                if (!string.IsNullOrEmpty(EdIdRubro.Tag.ToString()))
                    _exp.IdRubro = Convert.ToInt32(EdIdRubro.Tag.ToString());
            if (EdIdMeta.Tag != null)
                if (!string.IsNullOrEmpty(EdIdMeta.Tag.ToString()))
                    _exp.IdMeta = Convert.ToInt32(EdIdMeta.Tag.ToString());
            _exp.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            _exp.IdFuente = ((FuenteFinanciamiento)CboFuente.SelectedItem).IdFuente;
            
            try
            {
                con = DATA.Db.CreateConnection();
                con.Open();
                dbtrans = con.BeginTransaction();
                var ret = ExpedienteDao.Grabar(_exp, dbtrans);
                cad = General.AnalizaResultadoSql(ret);
                if (ret > 0)
                {
                    //Pasar Expediente a Estado por Revisar
                    var det= new DetExpediente();
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
                    ret=DetExpedienteDao.GrabarInicial(det, dbtrans);
                    if (ret > 0)
                    {
                        dbtrans.Commit();
                        MessageBox.Show(cad, @"Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dbtrans.Rollback();
                General.ShowMessage(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return true;
        }

        private void FpTramite_Load(object sender, EventArgs e)
        {
            var ninicial = DateTime.Now.Year;
            CboYearExp.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));

            CboPeriodo.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboPeriodo.Items.Add(i.ToString(CultureInfo.InvariantCulture));
            
            CboYearExp.SelectedIndex = 0;
            CboPeriodo.SelectedIndex = 0;
            CboMoneda.SelectedIndex = 0;
            General.CargarDatos(CboTipoDoc, "TDTR", "TDTR-0001"); //por defecto oficio seleccionado
            CboFuente.DataSource = FuenteFinanciamientoDao.SelectAll();
            CboFuente.ValueMember = "IdFuente";
            CboFuente.DisplayMember = "Abreviacion";
            CboFuente.SelectedIndex = 3;

            

            TxtInfo.Text = _FrmPadre.Miconfiguracion.IdUsuario + 
                @" El " + DateTime.Now.ToShortDateString() + @" " + 
                DateTime.Now.ToShortTimeString();
            EdIdExpediente.Focus();
            DtFechaIngresoExp.EditValue = DateTime.Now;
            DtFechaExp.DateTime = DateTime.Now; //Por Defecto Fecha de Hoy
        }

        private void EdCodSubDep_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var btn = (ButtonEdit) sender;
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
            TextBox t1=null, t2=null;
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
            toolTipController1.SetToolTip(t1,obj.Nombre);
            toolTipController1.SetToolTip(t2, obj2.Nombre);
        }

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

 
    }
}
