using System;
using System.Linq;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;


namespace Certifica_logistica.mantenimiento
{
    public partial class FmLogin : Masterform
    {
        private Login _obj;
        public FmLogin()
        {
            InitializeComponent();
            _obj = null;
        }

        public override bool Master_GrabarFormulario()
        {
            return Grabar();
        }

        private bool Grabar(bool isClave=false)
        {
            var ret = 0;
            if (errorProvider1.GetError(TxtLogin).Length > 0 ||
                errorProvider1.GetError(TxtCodPersonal).Length > 0)
            {
                General.ShowMessage("Debe Completar los Datos", "Faltan Datos", icon: MessageBoxIcon.Stop);
                return false;
            }
            if (_obj == null)
                _obj = new Login();
            _obj.CodLogin = TxtLogin.Text.Trim();
            _obj.Clave = (TxtClave.Text.Trim().Length > 0)
                ? Security.CreateHash(TxtClave.Text.Trim())
                : Security.CreateHash("LaClave123*");
            _obj.CodPersonal = TxtCodPersonal.Text.Trim();
            _obj.CodLoginOri = _FrmPadre.Miconfiguracion.IdUsuario;
            _obj.Preg01 = TxtPreg01.Text.Trim();
            _obj.Preg02 = TxtPreg02.Text.Trim();
            _obj.Estado = Convert.ToChar(CboEstado.SelectedItem.ToString().Substring(0, 1));
            var con = DATA.Db.CreateConnection();
            con.Open();
            var dbTrans = con.BeginTransaction();
            try
            {
                ret = isClave ? LoginDao.CambiarClave(_obj, dbTrans) : LoginDao.Grabar(_obj, dbTrans);
                if (ret > 0)
                {
                    dbTrans.Commit();
                    General.ShowMessage("Los Datos Fueron Correctamente Actualizados");
                }
                else
                {
                    dbTrans.Rollback();
                    General.ShowMessage("Error, No se pudo completar operación en Capa de Datos");
                }
            }
            catch (Exception ex)
            {
                dbTrans.Rollback();
                General.ShowMessage(ex.Message, "Operación Cancelada", icon: MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                dbTrans.Dispose();
            }
            return (ret > 0);
        }

        public override bool Master_NuevoFormulario()
        {
            return Master_LimpiarFormulario();
        }

        private void TxtCodPersonal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !string.IsNullOrEmpty(errorProvider1.GetError(TxtCodPersonal));
            //BtnAdd.Enabled = !e.Cancel;
        }
        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De Personal Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.PERSONAL};
            oFrm.ShowDialog();
            SuspendLayout();
            TxtCodPersonal.Text = oFrm._Codigo;
            TxtRazonSocial.Text = oFrm._Nombre;
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

            if (idP.Length < 8)
            {
                TxtRazonSocial.Text = "";
                errorProvider1.SetError(TxtCodPersonal, "Debe Ingresar Codigo de Usuario Final u digitar 0");
            }
            else
            {
                var p = PersonalDao.GetbyId(idP);
                TxtRazonSocial.Text = p != null ? p.RazonSocial : @"< NO EXISTE >";
            }
        }
        private void CargarFicha(string idP)
        {
            var l = LoginDao.GetbyId(idP);
            if (l != null)
            {
                Value = idP;
                TxtCodPersonal.Text = l.CodPersonal;
                TxtCodPersonal_Leave(this,null);
                TxtPreg01.Text = l.Preg01;
                TxtPreg02.Text = l.Preg02;
                foreach (var item in from string item in CboEstado.Items let estado = Convert.ToChar(item.Substring(0, 1)) where estado == l.Estado select item)
                {
                    CboEstado.SelectedItem = item;
                    break;
                }
                TxtCodLogin_Ori.Text = l.CodLoginOri;
                TxtUltimoAcceso.Text = string.Format("{0} {1}", l.UltimoAcceso.ToShortDateString() , l.UltimoAcceso.ToShortTimeString());
            }
            else
            {
                Value = string.Empty;
                General.ShowMessage("Este Código no Existe");
            }
        }
        private void ObjEnter(object sender, EventArgs e)
        {
            ObjectEnter(sender, e);
        }

        private void TxtLogin_Leave(object sender, EventArgs e)
        {
            var cod = TxtLogin.Text.Trim();
            errorProvider1.SetError(TxtLogin,"");
            if(string.IsNullOrEmpty(TxtLogin.Text))
                return;
            CargarFicha(cod);
        }

        private void BtnSetClave_Click(object sender, EventArgs e)
        {
            Grabar(true);
        }
    }
}
