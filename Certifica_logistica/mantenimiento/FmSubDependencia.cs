using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.XtraEditors.Controls;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmSubDependencia : Masterform
    {
        private SubDependencia _obj;
        public FmSubDependencia()
        {
            InitializeComponent();
        }
        private void FmSubDependencia_Load(object sender, System.EventArgs e)
        {
            EdCodDependencia.Properties.DataSource = DependenciaDao.SelectAll(Bit.Verdadero);
            EdCodDependencia.Properties.DisplayMember = "Nombre";
            EdCodDependencia.Properties.ValueMember = "CodDependencia";
            var col2 = EdCodDependencia.Properties.Columns;
            col2.Add(new LookUpColumnInfo("CodDependencia", 0));
            col2.Add(new LookUpColumnInfo("Nombre", 0));
            EdCodDependencia.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            EdCodDependencia.Properties.SearchMode = SearchMode.AutoComplete;
            EdCodDependencia.Properties.AutoSearchColumnIndex = 1;
            EdCodDependencia.EditValue = @"00"; //Dependencia por defecto
            CboEstado.SelectedIndex = 1;

        }
        public override bool Master_Verificar()
        {
            if (EdCodSubDep.EditValue == null)
            {
                dxErrorProvider1.SetError(EdCodSubDep, "El Valor no puede ser vacio");
                EdCodSubDep.Focus();
                return false;
            }
            if (EdCodSubDep.Text.Length<=0)
            {
                dxErrorProvider1.SetError(EdCodSubDep, "El Valor no puede ser vacio");
                EdCodSubDep.Focus();
                return false;
            }
            dxErrorProvider1.SetError(EdCodSubDep, "");

            if (EdCodDependencia.EditValue == null)
            {
                dxErrorProvider1.SetError(EdCodDependencia, "Debe Seleccionar una Dependencia a la que pertenecera Esta nueva SubDependencia");
                EdCodDependencia.Focus();
                return false;
            }
            if (EdCodDependencia.Text.Length <= 0)
            {
                dxErrorProvider1.SetError(EdCodDependencia, "Debe Seleccionar una Dependencia a la que pertenecera Esta nueva SubDependencia");
                EdCodDependencia.Focus();
                return false;
            }
            dxErrorProvider1.SetError(EdCodDependencia, "");

            if (TxtNombre.Text.Trim().Length <= 0)
            {
                dxErrorProvider1.SetError(TxtNombre, "Ups! Le falto el Nombre que Identificara a esta nueva SubDependencia");
                TxtNombre.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtNombre, "");

            if (EdCodPersonal.EditValue == null)
                EdCodPersonal.EditValue = @"00000000";
            if (EdCodPersonal.EditValue.ToString().Length == 0)
                EdCodPersonal.EditValue = @"00000000";
            return true;
        }

        public override bool Master_GrabarFormulario()
        {
            var ret = 0;
            if (!Master_Verificar()) return false;
            if(_obj==null) 
                _obj=new SubDependencia();
            _obj.CodSubDep = EdCodSubDep.EditValue.ToString();
            _obj.CodDependencia = EdCodDependencia.EditValue.ToString();
            _obj.Nombre = TxtNombre.Text;
            _obj.CodPersonal = EdCodPersonal.EditValue.ToString();
            _obj.Estado = (CboEstado.SelectedIndex==1);
            _obj.Autorizacion = TxtAutorizacion.Text;
            _obj.FechaAut = (DateTime) DtFechaAut.EditValue;
            _obj.Telefono = TxtTelefono.Text;
            _obj.Web = TxtWeb.Text;
            _obj.Obsv = TxtObsv.Text;
            _obj.Siglas = TxtSigla.Text;
            _obj.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            _obj.IsConvenio = ChkIsConvenio.Checked;
            _obj.Email = TxtEmail.Text;
            var msg = String.Empty;
            var con = DATA.Db.CreateConnection();
            DbTransaction dbTrans = null;
            try
            {
                con.Open();
                dbTrans = con.BeginTransaction();
                ret = SubDependenciaDao.Grabar(_obj, dbTrans);
                msg = General.AnalizaResultadoSql(ret);
                if (ret <= 0)
                    dbTrans.Rollback();
                else
                    dbTrans.Commit();
                General.ShowMessage(msg);
            }
            catch (Exception ex)
            {
                if (dbTrans != null) dbTrans.Rollback();
                General.ShowMessage(ex.Message,"Error");
            }
            finally
            {
                if(con.State== ConnectionState.Open) con.Close();
            }
            return (ret>0);
        }

        public override bool Master_NuevoFormulario()
        {
            var ret = false;
            try
            {
                _obj = null;
                Value = String.Empty;
                EdCodSubDep.EditValue = null;
                EdCodSubDep.IsModified = true;
                EdCodDependencia.EditValue = @"00";
                EdCodDependencia.IsModified = true;
                TxtNombre.Text = "";
                EdCodPersonal.EditValue = @"00000000";
                TxtRazonPersonal.Text = @"POR DETERMINAR";
                CboEstado.SelectedIndex = 1;
                TxtAutorizacion.Text = "";
                DtFechaAut.EditValue = DateTime.Now;
                TxtTelefono.Text = "";
                TxtWeb.Text = "";
                TxtObsv.Text = "";
                TxtSigla.Text = "";
                ChkIsConvenio.Checked = false;
                TxtEmail.Text = "";
                TxtModificacion.Text = string.Format("Registro Nuevo Creado por: {0} El {1} a las {2}", _FrmPadre.Miconfiguracion.IdUsuario, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());
                ret = true;
            }
            catch
            {
                Console.Beep();
            }
            return ret;
        }
        private void EdCodSubDep_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphSubDependencia { _TiTuloForm = "Busqueda De SubDePendencias Oficiales", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodSubDep.EditValue = oFrm._Codigo;
            TxtNombre.Text = oFrm._Nombre;
            oFrm.Close();
            ResumeLayout();
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphPersonal { _TiTuloForm = "Busqueda De Personal Institucional", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodPersonal.Text = oFrm._Codigo;
            TxtRazonPersonal.Text = oFrm._Nombre;
            toolTipController1.SetToolTip(EdCodPersonal, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }

 private void EdCodSubDep_Leave(object sender, System.EventArgs e)
        {
            if (!EdCodSubDep.IsModified)
            {
                Console.Beep();
                return;
            } //Si no se hizo modificaciones, salir

            _obj = null;
            if (EdCodSubDep.EditValue != null) 
                _obj = SubDependenciaDao.GetbyId(EdCodSubDep.EditValue.ToString());
            if (_obj == null)
            {
                EdCodSubDep.ResetBackColor();
                return;
            }
            EdCodSubDep.BackColor = Color.GreenYellow;
            EdCodDependencia.EditValue = _obj.CodDependencia;
            TxtNombre.Text = _obj.Nombre;
            EdCodPersonal.EditValue = _obj.CodPersonal;
            EdCodPersonal_Leave(EdCodPersonal,null);
            //jalar apellidos y nombre
            CboEstado.SelectedIndex = (_obj.Estado ? 1 : 0);
            TxtAutorizacion.Text = _obj.Autorizacion;
            DtFechaAut.EditValue = _obj.FechaAut;
            TxtTelefono.Text = _obj.Telefono;
            TxtWeb.Text = _obj.Web;
            TxtObsv.Text = _obj.Obsv;
            TxtSigla.Text = _obj.Siglas;
            ChkIsConvenio.Checked = _obj.IsConvenio;
            TxtEmail.Text = _obj.Email;
        }

        //--referencias
       private void EdCodPersonal_Leave(object sender, EventArgs e)
        {
       
            dxErrorProvider1.SetError(EdCodPersonal, "");
            if (EdCodPersonal.EditValue == null)
                EdCodPersonal.EditValue = "";

            var idP = EdCodPersonal.EditValue.ToString();

            if (idP.Length == 0)
            {
                TxtRazonPersonal.Text = "";
                dxErrorProvider1.SetError(EdCodPersonal, "Debe Ingresar Codigo de Usuario Final u digitar 0");
            }
            else if (idP.Length < 8)
            {
                TxtRazonPersonal.Text = "";
                dxErrorProvider1.SetError(EdCodPersonal, "Código Ingresado es Muy Corto (Log. Minima 08 Dig)");
            }
            else
            {
                var p=PersonalDao.GetbyId(idP);
                if (p == null)
                {
                    var cad = "Código Ingresado No Existe";
                    General.ShowMessage(cad);
                    dxErrorProvider1.SetError(EdCodPersonal, cad);
                    return;
                }
                else
                {
                    TxtRazonPersonal.Text = p.RazonSocial;
                }
            }
        }
        #region Sobrecargados
        public override void Object_KeyDown(object sender, KeyEventArgs e)
        {
            base.Object_KeyDown(sender, e);
            return;
        }

        public override void ObjectEnter(object sender, EventArgs e)
        {
            base.ObjectEnter(sender, e);
            return;
        }
        #endregion
    }
}
