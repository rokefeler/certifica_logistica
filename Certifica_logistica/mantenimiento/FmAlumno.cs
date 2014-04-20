using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.XtraEditors.Controls;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmAlumno : Masterform
    {
        private Alumno _obj;
        private List<AlumnoDetalleEscuela> _Lst;
        public FmAlumno()
        {
            InitializeComponent();
            _Lst = null;
            _obj = null;
        }

        private void FmAlumno_Load(object sender, EventArgs e)
        {
            EdEscuelas.Properties.DataSource = AlumnoEscuelaDao.SelectAllEscuelas();
            EdEscuelas.Properties.DisplayMember = "Nombre";
            EdEscuelas.Properties.ValueMember = "IdEscuela";
            var col2 = EdEscuelas.Properties.Columns;
            col2.Add(new LookUpColumnInfo("IdEscuela", 0));
            col2.Add(new LookUpColumnInfo("Nombre", 0));
            EdEscuelas.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            EdEscuelas.Properties.SearchMode = SearchMode.AutoComplete;
            EdEscuelas.Properties.AutoSearchColumnIndex = 1;
            EdEscuelas.EditValue = 0; //por defecto
            //EdEscuelas.EditValue = @"00"; //Dependencia por defecto

        }
        
        public override bool Master_NuevoFormulario()
        {
            EdCUI.EditValue = null;
            EdEscuelas.IsModified = true;
            EdEscuelas.EditValue = null;
            Value = "";
            TxtRazon.Text = "";
            TxtDireccion.Text = "";
            EdUbigeo.EditValue = null;
            TxtUbigeo.Text = "";
            TxtTelefono.Text = "";
            TxtEmail.Text = "";
            TxtDni.Text = "";
            DtFecNac.EditValue = null;
            _obj = null;
            EdCUI.IsModified = false;
            EdCUI.Focus();
            return true;
        }

        public override bool Master_Verificar()
        {
            string msg;
            try
            {
                Value = EdCUI.EditValue.ToString();
                dxErrorProvider1.SetError(EdCUI, "");
            }
            catch (Exception)
            {
                msg = "CUI esta Vacio o es un valor Nulo, Corriga por Favor!";
                dxErrorProvider1.SetError(EdCUI, msg);
                EdCUI.Focus();
                return false;
            }

            if (TxtRazon.Text.Length <= 0)
            {
                msg = "Por Favor, escriba Los Apellidos y Nombres del Alumno";
                dxErrorProvider1.SetError(TxtRazon, msg);
                TxtRazon.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtRazon, "");
            if (TxtDireccion.Text.Length <= 0)
            {
                msg = "Por Favor, Ingrese la Dirección Actual del Alumno";
                dxErrorProvider1.SetError(TxtRazon, msg);
                TxtDireccion.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtDireccion, "");
            if (TxtDni.Text.Length <= 0)
            {
                msg = "Por Favor, Ingrese El DNI del Alumno";
                dxErrorProvider1.SetError(TxtDni, msg);
                TxtDni.Focus();
                return false;
            }
            dxErrorProvider1.SetError(TxtDni, "");
            return true;
        }

        public override bool Master_GrabarFormulario()
        {
            var ret = 0;
            if (!Master_Verificar()) return false;
            if (_obj == null)
                _obj = new Alumno();
            else
                _obj.Clear();

            _obj.Cui = EdCUI.EditValue.ToString();
            _obj.ApeNom = TxtRazon.Text.Trim();
            _obj.Direccion = TxtDireccion.Text;
            if (EdUbigeo.EditValue != null) _obj.CodDis = EdUbigeo.EditValue.ToString();
            _obj.Email = TxtEmail.Text;
            _obj.Telefono = TxtTelefono.Text;
            _obj.Dni = TxtDni.Text;
            if (DtFecNac.EditValue != null) _obj.Fecnac = DtFecNac.DateTime;
            _obj.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            _obj.Estado = '1';
            DbConnection con = null;
            DbTransaction dbTrans = null;
            try
            {
                con = DATA.Db.CreateConnection();
                con.Open();
                dbTrans = con.BeginTransaction();
                ret = AlumnoDao.Grabar(_obj, dbTrans);
                if (ret > 0)
                {
                    string msg;
                    if(_Lst!=null)
                    foreach (var t in _Lst)
                    {
                        ret = AlumnoDetalleEscuelaDao.GrabarDetalleEscuela(_obj.Cui, t.IdEscuela,
                            _FrmPadre.Miconfiguracion.IdUsuario, dbTrans);
                        if (ret >= 0) continue;
                        msg = General.AnalizaResultadoSql(ret);
                        dbTrans.Rollback();
                        General.ShowMessage(msg, "Proceso Abortado - Detalle Escuelas");
                        return false;
                    }
                    var idescuela = (int)EdEscuelas.EditValue;
                    ret = AlumnoDetalleEscuelaDao.GrabarDetalleEscuela(_obj.Cui, idescuela,
                        _FrmPadre.Miconfiguracion.IdUsuario, dbTrans);
                    if (ret < 0)
                    {
                        msg = General.AnalizaResultadoSql(ret);
                        dbTrans.Rollback();
                        General.ShowMessage(msg, "Proceso Abortado - Detalle Escuelas");
                        return false;
                    }
                    dbTrans.Commit();
                    msg = General.AnalizaResultadoSql(ret);
                    General.ShowMessage(msg, "Proceso OK");
                }
            }
            catch (Exception ex)
            {
                if (dbTrans != null) dbTrans.Rollback();
                General.ShowMessage(ex.Message, "Error Excepcional", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            return (ret>0);
        }

        public override bool Master_CargarFicha(string idPrincipal, string idSecundario = null,int anio=2014)
        {
            _obj = AlumnoDao.GetBy(idPrincipal);
            EdCUI.ResetBackColor();
            if(_obj==null)
                return false;
            EdCUI.BackColor = Color.GreenYellow;
            TxtRazon.Text = _obj.ApeNom;
            TxtDireccion.Text = _obj.Direccion;
            EdUbigeo.EditValue = _obj.CodDis;
            TxtEmail.Text = _obj.Email;
            TxtTelefono.Text = _obj.Telefono;
            TxtDni.Text = _obj.Dni;
            if (_obj.Fecnac.Year <= 1900)
                DtFecNac.EditValue = null;
            else
                DtFecNac.EditValue = _obj.Fecnac;
            //ahora Cargar Detalle de Escuela en las que Ingreso
            _Lst = AlumnoDetalleEscuelaDao.SelectAllGetby(_obj.Cui);
            LstEscuelas.DataSource = _Lst;
            LstEscuelas.DisplayMember = "Nombre";
            LstEscuelas.ValueMember = "Id";
            try
            {
                var tal = (AlumnoDetalleEscuela)LstEscuelas.GetItem(0);
                EdEscuelas.EditValue =tal.IdEscuela;
            }
            catch (Exception)
            {
                Console.Beep();
            }
            TxtModificacion.Text = String.Format("Ultima Modificación Realizada Por: {0} el {1} {2}",
                            _obj.CodLogin, _obj.Fecha.ToShortDateString(), _obj.Fecha.ToShortTimeString());
            return true;
        }

        private void EdCUI_Leave(object sender, EventArgs e)
        {
            Value = string.Empty;
            if (EdCUI.EditValue == null)
            {
                dxErrorProvider1.SetError(EdCUI,"El CUI esta vacio o es Nulo");
                Console.Beep();
                return ;
            }
            if (EdCUI.EditValue.ToString().Length<8)
            {
                dxErrorProvider1.SetError(EdCUI, "El CUI Ingresado es Invalido, Corrija");
                Console.Beep();
                return;
            }
            dxErrorProvider1.SetError(EdCUI, "");
            Value = EdCUI.EditValue.ToString().Trim();
            if (EdCUI.IsModified)
                Master_CargarFicha(Value);
        }

        private void EdUbigeo_Leave(object sender, EventArgs e)
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
    }
}
