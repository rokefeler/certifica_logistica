using System;
using System.Data.Common;
using System.Data.SqlClient;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.XtraEditors.Controls;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmAlumno : Masterform
    {
        private Alumno _obj;
        private AlumnoDetalleEscuela _ade;
        public FmAlumno()
        {
            InitializeComponent();
        }

        private void FmAlumno_Load(object sender, System.EventArgs e)
        {
            EdEscuelas.Properties.DataSource = AlumnoDao.SelectAllEscuelas();
            EdEscuelas.Properties.DisplayMember = "Nombre";
            EdEscuelas.Properties.ValueMember = "IdEscuela";
            var col2 = EdEscuelas.Properties.Columns;
            col2.Add(new LookUpColumnInfo("IdEscuela", 0));
            col2.Add(new LookUpColumnInfo("Nombre", 0));
            EdEscuelas.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            EdEscuelas.Properties.SearchMode = SearchMode.AutoComplete;
            EdEscuelas.Properties.AutoSearchColumnIndex = 1;
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
            _ade = null;
            EdCUI.IsModified = false;
            EdCUI.Focus();
        }

        public override bool Master_Verificar()
        {
            var msg=String.Empty;
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
            if(_obj==null) 
                _obj=new Alumno(); 
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
            DbConnection con ;
            DbTransaction dbTrans;
            try
            {
                con = DATA.Db.CreateConnection();
                con.Open();
                dbTrans = con.BeginTransaction();
                ret=AlumnoDao.Grabar(_obj, dbTrans);
            }catch(SqlException ex)
        }
    }
}
