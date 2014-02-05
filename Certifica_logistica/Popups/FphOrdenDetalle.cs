using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;

namespace Certifica_logistica.Popups
{
    public partial class FphOrdenDetalle : FpMaster
    {
// ReSharper disable once InconsistentNaming
        public ENumTipoOrden _TipoOrden { get; set; }
        private DsTramite.TTipoUsuarioDataTable _tbUsuario;
        public FphOrdenDetalle()
        {
            InitializeComponent();
            _tbUsuario = new DsTramite.TTipoUsuarioDataTable();
            _TipoOrden = ENumTipoOrden.SERVICIO;
        }
        private void FphOrdenDetalle_Load(object sender, EventArgs e)
        {
            var ninicial = DateTime.Now.Year;
            CboPeriodo.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboPeriodo.Items.Add(i.ToString(CultureInfo.InvariantCulture));

            CboPeriodo.SelectedIndex = 0;

            General.RellenarEstadoDataSet(ref _tbUsuario, _TipoOrden,true);
            CboTipoUsuario.Properties.DataSource = _tbUsuario;
            CboTipoUsuario.Properties.DisplayMember = "nombre";
            CboTipoUsuario.Properties.ValueMember = "Sigla";

            CboPeriodo_Leave(this,null);

            //Evaluar para que tipo de Orden se carga la ayuda
            //[V=Proveedor] - [P=Personal] - [A=Alumno] - [S=Servicios] [N=Ninguno]
            LblTipoUsuario.Visible = false;
            EdCodigo.Visible = false;
            LblTipoUsuario.Text = @"&Detalle";
            switch (_TipoOrden)
            {
                case ENumTipoOrden.CONVENIO:
                case ENumTipoOrden.SERVICIO:
                case ENumTipoOrden.VIATICOS:
                    CboTipoUsuario.EditValue = 'N';
                    EdCodigo.EditValue = String.Empty;
                    break;
                case ENumTipoOrden.MOVILIDAD:
                    CboTipoUsuario.EditValue = 'P';
                    LblTipoUsuario.Visible = true;
                    EdCodigo.Visible = true;
                    LblTipoUsuario.Text = @"&Detalle - Apellidos/Nombres";
                    EdCodigo.EditValue = String.Empty;
                    break;
                case ENumTipoOrden.PROPINAS:
                    CboTipoUsuario.EditValue = 'A';
                    LblTipoUsuario.Visible = true;
                    EdCodigo.Visible = true;
                    LblTipoUsuario.Text = @"&Detalle - Apellidos/Nombres";
                    EdCodigo.EditValue = String.Empty;
                    break;
              }
            EdIdClasificador.Focus();
        }


        private void CboPeriodo_Leave(object sender, EventArgs e)
        {
            var collection = new AutoCompleteStringCollection();
            var str = ClasificadorGastoDao.GetStringAllByAnio(CboPeriodo.SelectedItem.ToString());
            collection.AddRange(str.ToArray());
            EdIdClasificador.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            EdIdClasificador.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EdIdClasificador.MaskBox.AutoCompleteCustomSource = collection;

            var collect2 = new AutoCompleteStringCollection();
            var str2 = MetaDao.GetStringAllByAnio(CboPeriodo.SelectedItem.ToString());
            collect2.AddRange(str2.ToArray());
            EdIdMeta.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            EdIdMeta.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EdIdMeta.MaskBox.AutoCompleteCustomSource = collect2;
        }

        private void EdCodigo_Leave(object sender, EventArgs e)
        {
            String cod, cNombreTabla = String.Empty;
            if (!EdCodigo.IsModified) return; //Si no hay modificaciones, salir
            dxErrorProvider1.SetError(EdCodigo, "");
            toolTipController1.SetToolTip(TxtDetalle, "");
            EdCodigo.ResetBackColor();
            var eTipoTabla = ENumTabla.NINGUNO;
            if (!EdCodigo.Enabled) return;
            try
            {
                var cTipoUsuario = (char)CboTipoUsuario.EditValue;
                eTipoTabla = General.DeterminaTipoUsuario(cTipoUsuario, out cNombreTabla);
                cod = EdCodigo.EditValue.ToString().Trim();
            }
            catch (Exception)
            {
                cod = String.Empty;
            }
            if (String.IsNullOrEmpty(cod))
            {
                dxErrorProvider1.SetError(EdCodigo, "Ingrese un Código de " + cNombreTabla);
                return;
            }
            //-----------------------------------
            switch (eTipoTabla)
            {
                case ENumTabla.ALUMNO:
                    var objA = AlumnoDao.GetBy(cod);
                    if (objA == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }
                    EdCodigo.BackColor = Color.LightGreen;
                    TxtDetalle.Text = objA.ApeNom;
                    toolTipController1.SetToolTip(TxtDetalle, "Dirección: " + objA.Direccion);
                    break;
                case ENumTabla.PERSONAL:
                    var objP = PersonalDao.GetbyId(cod);
                    if (objP == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }

                    EdCodigo.BackColor = Color.LightGreen;
                    TxtDetalle.Text = objP.RazonSocial;
                    toolTipController1.SetToolTip(TxtDetalle, objP.Direc);
                    break;
                case ENumTabla.PROVEEDOR:
                    var objV = ProveedorDao.GetbyId(cod);
                    if (objV == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }

                    EdCodigo.BackColor = Color.LightGreen;
                    TxtDetalle.Text = objV.Razon;
                    toolTipController1.SetToolTip(TxtDetalle, objV.Direccion);
                    break;
                case ENumTabla.SERVICIOS:
                    var objS = ServiciosDao.GetbyId(cod);
                    if (objS == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }

                    EdCodigo.BackColor = Color.LightGreen;
                    TxtDetalle.Text = objS.Responsable;
                    toolTipController1.SetToolTip(TxtDetalle, objS.NombreServicio);
                    break;

            } //fin de switch
        }

       
    }
}
