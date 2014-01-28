using System;using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmPersonal : Certifica_logistica.Masterform
    {
        private Personal _obj;
        public FmPersonal()
        {
            InitializeComponent();
        }

        public override bool Master_GrabarFormulario()
        {
            var ret = 0;
            if (errorProvider1.GetError(TxtCodPersonal).Length > 0 
                || errorProvider1.GetError(BtnUbigeo).Length > 0
                || errorProvider1.GetError(TxtNroDoc).Length > 0)
            {
                General.ShowMessage("Primero Complete u Corriga Las Observaciones Encontradas ");
                return false;
            }
            else
            {
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
            }
            return (ret > 0);
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphPersonal { _TiTuloForm = "Busqueda De Personal Institucional", _backColor = BackColor };
            oFrm.ShowDialog();
            SuspendLayout();
            TxtCodPersonal.Text = oFrm._Codigo;
            toolTip1.SetToolTip(TxtCodPersonal, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }
        private void TxtCodPersonal_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(TxtCodPersonal, "");
            if (TxtCodPersonal.EditValue == null)
                TxtCodPersonal.EditValue = "";

            var idP = TxtCodPersonal.EditValue.ToString();

            if (idP.Length == 0)
            {
                TxtApellidos.Text = "";
                errorProvider1.SetError(TxtCodPersonal, "Debe Ingresar Codigo de Usuario Final u digitar 0");
            }
            else if (idP.Length < 8)
            {
                TxtApellidos.Text = "";
                errorProvider1.SetError(TxtCodPersonal, "Código Ingresado es Muy Corto (Log. Minima 08 Dig)");
            }
            else
            {
                CargarFicha(idP);
            }
        }

        private void CargarFicha(string idP)
        {
            var p = PersonalDao.GetbyId(idP);
            if (p != null)
            {
                Value = idP;
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
            }
            else 
            {
                Value = string.Empty;
                General.ShowMessage("Este Código no Existe");
            }
        }

        private void TxtCodPersonal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !string.IsNullOrEmpty(errorProvider1.GetError(TxtCodPersonal));
            //BtnAdd.Enabled = !e.Cancel;
        }
        private void ObjEnter(object sender, EventArgs e)
        {
            ObjectEnter(sender, e);
        }

        private void FmPersonal_Load(object sender, EventArgs e)
        {
            General.CargarDatos(CboTDoc, "TDOC", "TDOC-0000");
            General.CargarDatos(CboCategoria, "CCAT", "CCAT-0000");
            General.CargarDatos(CboCondicion, "CNDC", "CNDC-0000");
            TxtCodPersonal.Focus();
        }

        private void BtnUbigeo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            General.ShowMessage("Por lo pronto ingrese el codigo de Ubigeo respectivo\n"+
                                "Si no se acuerda o no conoce por lo pronto coloque 000000");
        }

        private void BtnUbigeo_Leave(object sender, EventArgs e)
        {
            string coddis = BtnUbigeo.Text.Trim();
            errorProvider1.SetError(BtnUbigeo, "");
            if (string.IsNullOrEmpty(coddis))
            {
                errorProvider1.SetError(BtnUbigeo, "Ingrese Código de Ubigeo - Ej: 040101");
                return;
            }
            var d = DistritoDao.GetbyId(coddis);
            if(d==null)
            {
                TxtUbigeo.Text = @"Código de Ubigeo no Existe!";
                errorProvider1.SetError(BtnUbigeo, "Código de Ubigeo no Existe!");
                return;
            }
            else
            {
                TxtUbigeo.Text = d.NombreCompleto;
            }

        }

        private void TxtNroDoc_Leave(object sender, EventArgs e)
        {
            var cnum = TxtNroDoc.Text.Trim();
            errorProvider1.SetError(TxtNroDoc, "");
            if(string.IsNullOrEmpty(cnum))
                errorProvider1.SetError(TxtNroDoc,"Ingrese el Número de Documento");
            else if(cnum.Length<8)
                errorProvider1.SetError(TxtNroDoc,"El Número de Documento de tener como mínimo una Long. de 8C");
        }
    }
}
