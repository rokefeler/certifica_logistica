using System;
using System.Drawing;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmPersonal : Masterform
    {
        private Personal _obj;
        public FmPersonal()
        {
            InitializeComponent();
        }
        private void FmPersonal_Load(object sender, EventArgs e)
        {
            General.CargarDatos(CboTDoc, "TDOC", "TDOC-0000");
            General.CargarDatos(CboCategoria, "CCAT", "CCAT-0000");
            General.CargarDatos(CboCondicion, "CNDC", "CNDC-0000");
            TxtCodPersonal.Focus();
        }
        public override bool Master_Verificar()
        {
            var cad = string.Empty;
            var msg = string.Empty;
            if (dxErrorProvider1.GetError(TxtCodPersonal).Length > 0
                || dxErrorProvider1.GetError(BtnUbigeo).Length > 0
                || dxErrorProvider1.GetError(TxtNroDoc).Length > 0
                || dxErrorProvider1.GetError(EdCodSubDep).Length > 0
                )
            {
                General.ShowMessage("Primero Complete u Corriga Las Observaciones Encontradas ");
                return false;
            }
            
            
            return true;
        }
        public override void ObjectEnter(object sender, EventArgs e)
        {
            base.ObjectEnter(sender, e);
            return;
        }

        public override void Object_KeyDown(object sender, KeyEventArgs e)
        {
            base.Object_KeyDown(sender, e);
            return;
        }

        public override bool Master_GrabarFormulario()
        {
            var ret = 0;
            if (!Master_Verificar()) return false;

                Value = TxtCodPersonal.Text.Trim();
                if(_obj==null) 
                    _obj = new Personal();
                _obj.CodPersonal = Value;
                _obj.Ape = TxtApellidos.Text.Trim();
                _obj.Nom = TxtNombres.Text.Trim();
                _obj.CodDis = BtnUbigeo.EditValue.ToString();
                _obj.Direc = TxtDireccion.Text.Trim();
                _obj.Email = TxtEmail.Text.Trim();
                //--_obj.Fecnac = 
                _obj.IdxTipoDoc = ((Codigo) CboTDoc.SelectedItem).Id;
                _obj.NroDocIden = TxtNroDoc.Text.Trim();
                _obj.IdxCategoria = ((Codigo)CboCategoria.SelectedItem).Id;
                _obj.IdxCondicion = ((Codigo)CboCondicion.SelectedItem).Id;
                _obj.Nrofijo = TxtFijo.Text.Trim();
                _obj.Movil = TxtMovil.Text.Trim();
            if(EdCodSubDep.EditValue!=null)
                if (EdCodSubDep.Text.Length > 0)
                    _obj.CodSubDep = EdCodSubDep.Text.Trim();

                var con = DATA.Db.CreateConnection();
                con.Open();
                var dbTrans = con.BeginTransaction();
                try
                {
                    ret = PersonalDao.Grabar(_obj, dbTrans);
                    if (ret > 0)
                    {
                        dbTrans.Commit();
                        MessageBox.Show(@"Los Datos FUeron Correctamente Actualizados");
                    }
                    else
                    {
                        General.ShowMessage("Error, No se pudo completar operación en Capa de Datos");
                        dbTrans.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    dbTrans.Rollback();
                    General.ShowMessage(ex.Message,"Operación Cancelada",icon: MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    dbTrans.Dispose();
                }
            
            return (ret > 0);
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De Personal Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.PERSONAL};
            oFrm.ShowDialog();
            SuspendLayout();
            TxtCodPersonal.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(TxtCodPersonal, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }
        private void TxtCodPersonal_Leave(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(TxtCodPersonal, "");
            if (TxtCodPersonal.EditValue == null)
                TxtCodPersonal.EditValue = "";

            var idP = TxtCodPersonal.EditValue.ToString();

            if (idP.Length == 0)
            {
                TxtApellidos.Text = "";
                dxErrorProvider1.SetError(TxtCodPersonal, "Debe Ingresar Codigo de Usuario Final u digitar 0");
            }
            else if (idP.Length < 8)
            {
                TxtApellidos.Text = "";
                dxErrorProvider1.SetError(TxtCodPersonal, "Código Ingresado es Muy Corto (Log. Minima 08 Dig)");
            }
            else
            {
                CargarFicha(idP);
            }
        }

        private void CargarFicha(string idP)
        {
            EdCodSubDep.EditValue = String.Empty;
            TxtSubDependencia.Text = String.Empty;
            TxtDependencia.Text = String.Empty;
            TxtCodPersonal.ResetBackColor();
            var p = PersonalDao.GetbyId(idP);
            if (p != null)
            {
                Value = idP;
                TxtCodPersonal.BackColor = Color.GreenYellow;
                TxtApellidos.Text = p.Ape;
                TxtNombres.Text = p.Nom;
                General.UbicaItemsComboCodigo(CboTDoc, p.IdxTipoDoc);
                TxtNroDoc.Text = p.NroDocIden;
                TxtDireccion.Text = p.Direc;
                BtnUbigeo.EditValue = p.CodDis;
                BtnUbigeo_Leave(this,null); //cargar ubigeo
                TxtEmail.Text = p.Email;
                TxtMovil.Text = p.Movil;
                TxtFijo.Text = p.Nrofijo;
                General.UbicaItemsComboCodigo(CboCategoria, p.IdxCategoria);
                General.UbicaItemsComboCodigo(CboCondicion, p.IdxCondicion);
                if (p.CodSubDep.Length > 0)
                {
                    EdCodSubDep.EditValue = p.CodSubDep;
                    EdCodSubDep_Leave(EdCodSubDep,null); //mostrar datos
                }
            }
            else 
            {
                Value = string.Empty;
                TxtNroDoc.Text = TxtCodPersonal.Text;
                General.ShowMessage("Este Código no Existe");
            }
        }

        private void TxtCodPersonal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !string.IsNullOrEmpty(dxErrorProvider1.GetError(TxtCodPersonal));
            //BtnAdd.Enabled = !e.Cancel;
        }
        
        private void BtnUbigeo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            General.ShowMessage("Por lo pronto ingrese el codigo de Ubigeo respectivo\n"+
                                "Si no se acuerda o no conoce por lo pronto coloque 000000");
        }

        private void BtnUbigeo_Leave(object sender, EventArgs e)
        {
            string coddis = BtnUbigeo.Text.Trim();
            dxErrorProvider1.SetError(BtnUbigeo, "");
            if (string.IsNullOrEmpty(coddis))
            {
                dxErrorProvider1.SetError(BtnUbigeo, "Ingrese Código de Ubigeo - Ej: 040101");
                return;
            }
            var d = DistritoDao.GetbyId(coddis);
            if(d==null)
            {
                TxtUbigeo.Text = @"Código de Ubigeo no Existe!";
                dxErrorProvider1.SetError(BtnUbigeo, "Código de Ubigeo no Existe!");
            }
            else
            {
                TxtUbigeo.Text = d.NombreCompleto;
            }

        }

        private void TxtNroDoc_Leave(object sender, EventArgs e)
        {
            var cnum = TxtNroDoc.Text.Trim();
            dxErrorProvider1.SetError(TxtNroDoc, "");
            if(string.IsNullOrEmpty(cnum))
                dxErrorProvider1.SetError(TxtNroDoc, "Ingrese el Número de Documento");
            else if(cnum.Length<8)
                dxErrorProvider1.SetError(TxtNroDoc, "El Número de Documento de tener como mínimo una Long. de 8C");
        }

        private void EdCodSubDep_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De SubDependencia Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.SUBDEPENDENCIA};
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodSubDep.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(EdCodSubDep, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }

        private void EdCodSubDep_Leave(object sender, EventArgs e)
        {
            TxtSubDependencia.Text = "";
            TxtDependencia.Text = "";
            toolTipController1.SetToolTip(TxtSubDependencia, "");
            toolTipController1.SetToolTip(TxtDependencia, "");
            dxErrorProvider1.SetError(EdCodSubDep, "");
            if (EdCodSubDep.EditValue == null) return;
            if (EdCodSubDep.EditValue.ToString().Length <= 0) return;

            var cod = EdCodSubDep.EditValue.ToString().ToUpper();
            if (cod.Length <= 0) return;
            var obj = SubDependenciaDao.GetbyId(cod);
            if (obj == null)
            {
                dxErrorProvider1.SetError(EdCodSubDep, "Este Valor Ingresado no Existe");
                return;
            }
            TxtSubDependencia.Text = obj.Nombre;
            var obj2 = DependenciaDao.GetbyId(obj.CodDependencia);
            TxtDependencia.Text = obj2.Nombre;
            toolTipController1.SetToolTip(TxtSubDependencia, obj.Nombre);
            toolTipController1.SetToolTip(TxtDependencia, obj2.Nombre);
        }

      
    }
}
