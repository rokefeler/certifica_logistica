using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;

namespace Certifica_logistica.Popups
{
    public partial class FphDetalleOrden : FpMaster
    {
// ReSharper disable once InconsistentNaming
        public ENumTipoOrden _TipoOrden;
        private DsTramite.TTipoUsuarioDataTable _tbUsuarioDetalle;
        public FphDetalleOrden()
        {
            InitializeComponent();
            _tbUsuarioDetalle = new DsTramite.TTipoUsuarioDataTable();
            _TipoOrden = new ENumTipoOrden();
        }
        private void FphDetalleOrden_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CboTipoUsuario_EditValueChanged(sender,e);
            EdIdClasificador.Focus();
        }


        private void CargarDatos()
        {
            SuspendLayout();
            try
            {
                var ninicial = DateTime.Now.Year;
                CboPeriodo.Items.Clear();
                for (var i = ninicial; i >= 2012; i--)
                    CboPeriodo.Items.Add(i.ToString(CultureInfo.InvariantCulture));

                CboPeriodo.SelectedIndex = 0;
                if (_tbUsuarioDetalle.Rows.Count <= 0)
                {
                    General.RellenarEstadoDataSet(ref _tbUsuarioDetalle, _TipoOrden, true);
                    CboTipoUsuario.Properties.DataSource = _tbUsuarioDetalle;
                    CboTipoUsuario.Properties.DisplayMember = "nombre";
                    CboTipoUsuario.Properties.ValueMember = "Sigla";
                }
                CboPeriodo_Leave(this, null);

                //Evaluar para que tipo de Orden se carga la ayuda
                //[V=Proveedor] - [P=Personal] - [A=Alumno] - [S=Servicios] [N=Ninguno]
                LblTipoUsuario.Visible = false;
                EdCodigo.Visible = false;
                LblTipoUsuario.Text = @"&Detalle";
                switch (_TipoOrden)
                {
                    case ENumTipoOrden.CONVENIO:
                    case ENumTipoOrden.VIATICOS:
                        CboTipoUsuario.EditValue = 'N';
                        EdCodigo.EditValue = null;
                        break;
                    case ENumTipoOrden.SERVICIO:
                        CboTipoUsuario.EditValue = 'V';
                        LblTipoUsuario.Visible = true;
                        EdCodigo.Visible = true;
                        LblTipoUsuario.Text = @"&Detalle - Apellidos/Nombres";
                        EdCodigo.EditValue = null;
                        break;

                    case ENumTipoOrden.MOVILIDAD:
                        CboTipoUsuario.EditValue = 'P';
                        LblTipoUsuario.Visible = true;
                        EdCodigo.Visible = true;
                        LblTipoUsuario.Text = @"&Detalle - Apellidos/Nombres";
                        EdCodigo.EditValue = null;
                        break;
                    case ENumTipoOrden.PROPINAS:
                        CboTipoUsuario.EditValue = 'A';
                        LblTipoUsuario.Visible = true;
                        EdCodigo.Visible = true;
                        LblTipoUsuario.Text = @"&Detalle - Apellidos/Nombres";
                        EdCodigo.EditValue = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                General.ShowMessage(ex.Message, "Error en carga");
            }
            ResumeLayout();
        }


        private void CboPeriodo_Leave(object sender, EventArgs e)
        {
            string pe = CboPeriodo.SelectedItem.ToString();
            try
            {
                if (CboPeriodo.Tag.Equals(pe))
                return;
            }
            catch
            {
                CboPeriodo.Tag = pe; //Copiar Valor Actual
            }
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

            EdIdClasificador_Leave(sender,e);
            EdIdMeta_Leave(sender,e);
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
      

        public override void GrabarFormulario()
        {
            String cad;
            try
            {
                if (dxErrorProvider1.HasErrors)
                {
                    General.ShowMessage("Existen Errores que no fueron Corregidos");
                    return;
                }
                cad = EdIdClasificador.EditValue.ToString();
                if (String.IsNullOrEmpty(cad))
                {
                    cad = "Ingrese el Clasificador del Presente Periodo";
                    dxErrorProvider1.SetError(EdIdClasificador,cad);
                    General.ShowMessage(cad);
                    return;
                }
                cad = EdIdMeta.EditValue.ToString();
                if (String.IsNullOrEmpty(cad))
                {
                    cad ="Ingrese La Meta del Presente Periodo";
                    General.ShowMessage(cad);
                    return;
                }
                cad = CboTipoUsuario.EditValue.ToString();
                if (cad.Equals("N"))
                {
                    if (TxtDetalle.Text.Trim().Length <= 0)
                    {
                        cad = "Debe Ingresar un Detalle del Item";
                        dxErrorProvider1.SetError(TxtDetalle, cad);
                        General.ShowMessage(cad);
                        return;
                    }
                   
                }
                else //Verificar si Ingreso Algun Codigo
                {
                    cad = EdCodigo.EditValue.ToString();
                    if (String.IsNullOrEmpty(cad))
                    {
                        cad = "Debe Ingresar un Código del Tipo de Usuario Seleccionado";
                        dxErrorProvider1.SetError(EdCodigo,cad);
                        General.ShowMessage(cad);
                        return;
                    }
                }
            }
            catch 
            {
               General.ShowMessage("Existen Datos que no fueron Completados");
               return;
            }
            _Codigo = "OK";
            Hide();
        }

        private void CboTipoUsuario_EditValueChanged(object sender, EventArgs e)
        {
            var c = (char)CboTipoUsuario.EditValue;
            switch (c)
            {
                case 'V': //Proveedor
                case 'A': //Alumno
                case 'P': //Personal
                case 'S': //Servicios
                    EdCodigo.Visible = true;
                    LblTipoUsuario.Visible = true;
                    break;
                case 'N': //Ninguno
                    EdCodigo.Visible = false;
                    LblTipoUsuario.Visible = false;
                    break;
            }
        }

        private void EdIdClasificador_Leave(object sender, EventArgs e)
        {
            string cad;
            dxErrorProvider1.SetError(EdIdClasificador, "");
            try
            {
                cad = EdIdClasificador.EditValue.ToString().Trim();
            }
            catch
            {
                cad = string.Empty;
            }
            if(string.IsNullOrEmpty(cad)) return;
            var cla=ClasificadorGastoDao.GetbyId(cad, CboPeriodo.SelectedItem.ToString());
            if (cla == null)
            {
                EdIdClasificador.ResetBackColor();
                dxErrorProvider1.SetError(EdIdClasificador, "Clasificador no Existe en el Periodo Seleccionado");
                EdIdClasificador.Tag = "";
            }
            else
            {
                EdIdClasificador.BackColor = Color.LightGreen;
                EdIdClasificador.Tag = cla.IdClasificador.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void EdIdMeta_Leave(object sender, EventArgs e)
        {
            string cad;
            dxErrorProvider1.SetError(EdIdMeta, "");
            try
            {
                cad = EdIdMeta.EditValue.ToString().Trim();
            }
            catch
            {
                cad = string.Empty;
            }
            if (string.IsNullOrEmpty(cad)) return;
            var me = MetaDao.GetbyId(cad, CboPeriodo.SelectedItem.ToString());
            if (me == null)
            {
                EdIdMeta.ResetBackColor();
                dxErrorProvider1.SetError(EdIdMeta, "Clasificador no Existe en el Periodo Seleccionado");
                EdIdMeta.Tag = "";
            }
            else
            {
                EdIdMeta.BackColor = Color.LightGreen;
                EdIdMeta.Tag = me.IdMeta.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void TxtDetalle_Leave(object sender, EventArgs e)
        {
            try
            {
                dxErrorProvider1.SetError(TxtDetalle, "");
                if (CboTipoUsuario.EditValue.ToString()[0] == 'N')
                    if (TxtDetalle.Text.Trim().Length <= 0)
                    {
                        const string cad = "Debe Ingresar Manualmente un Texto para el Detalle";
                        dxErrorProvider1.SetError(TxtDetalle, cad);
                    }
            }
            catch (Exception)
            {
                Console.Beep();
            }
        }

    }
}
