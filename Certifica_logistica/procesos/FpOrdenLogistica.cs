using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.procesos
{
    public partial class FpOrdenLogistica : Masterform
    {
// ReSharper disable once InconsistentNaming
        public ENumTipoOrden _TipoOrden;
        private DsTramite.TTipoUsuarioDataTable _tbUsuario;
        private DsTramite.DetalleOrdenDataTable _tbOrdenDetalle;
/*
        private DataSet _ds;
*/
        public FpOrdenLogistica()
        {
            InitializeComponent();
            _tbUsuario = new DsTramite.TTipoUsuarioDataTable();
            _TipoOrden= ENumTipoOrden.SERVICIO;
            _tbOrdenDetalle = new DsTramite.DetalleOrdenDataTable();
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FpOrdenLogistica_Load(object sender, EventArgs e)
        {
            var collection = new AutoCompleteStringCollection();
            string[] str ={"FACTURA","BOLETA DE VENTA","SERV.LUZ ELECTRICA","SERV.LUZ TRIFASICA","SERV.AGUA","SERV.TELEFONIA MOVIL","SERV.TELEFONIA FIJA","SERV.INTERNET","LABOR REALIZADA (rph)","PROPINAS","MOVILIDAD","VIATICOS","PASAJES AEREOS","RECIBO","PASAJES TERRESTRES","SERV.CABLE","DOCENTE EXTRANJERO"};
            collection.AddRange(str);
            TxtReferencia.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtReferencia.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtReferencia.MaskBox.AutoCompleteCustomSource = collection;
            var ninicial = DateTime.Now.Year;
            CboYearExp.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));

            CboYearExp.SelectedIndex = 0;
            CboMoneda.SelectedIndex = 0;
            General.CargarDatos(CboTipoProceso, "PCAD", "PCAD-0000");
            CboFuente.DataSource = FuenteFinanciamientoDao.SelectAll();
            CboFuente.ValueMember = "IdFuente";
            CboFuente.DisplayMember = "Abreviacion";
            CboFuente.SelectedIndex = 3;

            General.RellenarEstadoDataSet(ref _tbUsuario, _TipoOrden);
            CboTipoUsuario.Properties.DataSource = _tbUsuario;
            CboTipoUsuario.Properties.DisplayMember = "nombre";
            CboTipoUsuario.Properties.ValueMember = "Sigla";
            EdIdExpediente.IsModified = true;

            //Para Columnas del GridView
            repositoryItemSearchTipoUsuario.DataSource = _tbUsuario;
            repositoryItemSearchTipoUsuario.DisplayMember = "nombre";
            repositoryItemSearchTipoUsuario.ValueMember = "Sigla";

            //TODO GRAVE: Se debe consistenciar para consultas de años posteriores
            repositoryItemSearchIdMeta.DataSource = MetaDao.SelectAllByAnio(DateTime.Now.Year.ToString(CultureInfo.InvariantCulture)); //TipoFormapagoDao.GetAllList();
            repositoryItemSearchIdMeta.DisplayMember = "Cnro";
            repositoryItemSearchIdMeta.ValueMember = "IdMeta";
            RefreshDetalle();
        }

        private void RefreshDetalle()
        {
//---------------------------------------------------------------------------
            //_tbOrdenDetalle = General.GenerarCuotasdePrestamo(dPrestamo, dInteresTea, iMeses, (DateTime)dtFechaEntrega.EditValue, out fechaFin);
            dsTramite.Tables[name: "DetalleOrdenDataTable"].Clear();
            dsTramite.Tables[name: "DetalleOrdenDataTable"].Load(_tbOrdenDetalle.CreateDataReader());
        }

// ReSharper disable once RedundantOverridenMember
        public override void ObjectEnter(object sender, EventArgs e)
        {
            base.ObjectEnter(sender, e);
        }

// ReSharper disable once RedundantOverridenMember
        public override void Object_KeyDown(object sender, KeyEventArgs e)
        {
            base.Object_KeyDown(sender, e);
        }

        private void BtnCarga_Click(object sender, EventArgs e)
        {
            string msg;
            if (EdIdExpediente.EditValue == null) return;
            if (EdIdExpediente.IsModified) return;
            var cNroExp = EdIdExpediente.EditValue.ToString();
            if (cNroExp.Length <= 0) return;
            cNroExp = cNroExp.PadLeft(6, '0');
            EdIdExpediente.EditValue = cNroExp;
            cNroExp = cNroExp + "-" + CboYearExp.SelectedItem;

            var exp = ExpedienteDao.GetbyId(cNroExp);
            EdIdExpediente.ResetBackColor();
            CboYearExp.ResetBackColor();
            if (exp == null)
            {
                Console.Beep();
                msg = "El Expediente Ingresado " + cNroExp + " No Existe";
                toolTipController1.ShowHint(msg);
                return ;
            }
            EdIdExpediente.BackColor = Color.LightGreen;
            CboYearExp.BackColor = Color.LightGreen;
            
            DtFechaExp.DateTime = exp.FechaExp;
            DtFechaIngresoExp.DateTime = exp.FechaIngreso;
            for (var x = 0; x < CboFuente.Items.Count; x++)
            {
                var fte = (FuenteFinanciamiento)CboFuente.Items[x];
                if (fte.IdFuente != exp.IdFuente) continue;
                CboFuente.SelectedIndex = x;
                break;
            }
            for (var x = 0; x < CboMoneda.Items.Count; x++)
            {
                var m = CboMoneda.Items[x].ToString()[0];
                if (exp.Moneda != m) continue;
                CboMoneda.SelectedIndex = x;
                break;
            }

            TxtNroAutorizacion.Text = exp.CNroAuto;
            TxtMontoAprobado.Text = exp.MontoAprobado <= 0 ? "" : exp.MontoAprobado.ToString("####00.00");

            var codSubDep = SubDependenciaDao.GetbyId(exp.CodSubDepOrigen);
            TxtSubDependencia.Text = codSubDep != null ? string.Format("{0} / {1}", codSubDep.Nombre, codSubDep.NombreDependencia) : @"NO EXISTE !!!";

            var td = CodigoDao.GetbyId(exp.IdxTipoDocTra);
            TxtDocumento.Text = td != null ? string.Format("{0} {1}", td.Nombre, exp.Nrodoc) : String.Empty;
            TxtReferencia.Text = exp.Asunto;
            
        }

        private void CboTipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var c = (Codigo) CboTipoProceso.SelectedItem;
                TxtNroProceso.Enabled = !c.Id.Equals("PCAD-0000");
            }
            catch (Exception)
            {
                TxtNroProceso.Text="";
            }
        }

        private void EdCodigo_Leave(object sender, EventArgs e)
        {
            String cod, cNombreTabla = String.Empty;
            if (!EdCodigo.IsModified) return; //Si no hay modificaciones, salir
            dxErrorProvider1.SetError(EdCodigo, "");
            toolTipController1.SetToolTip(TxtDni, "");
            TxtRazon.Text = String.Empty;
            TxtDirec.Text = String.Empty;
            TxtDni.Text = String.Empty;
            EdCodigo.ResetBackColor();
            var eTipoTabla = ENumTabla.NINGUNO;
            if (!EdCodigo.Enabled) return;
            try
            {
                var cTipoUsuario = (char) CboTipoUsuario.EditValue;
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
            string cMoviles;
            switch (eTipoTabla)
            {
                case ENumTabla.ALUMNO:
                    var objA = AlumnoDao.GetBy(cod);
                    if (objA == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo,"Código Ingresado No Existe");
                        break;
                    }
                    EdCodigo.BackColor = Color.LightGreen;
                    TxtRazon.Text = objA.ApeNom;
                    if (objA.Telefono.Length > 0)
                        toolTipController1.SetToolTip(TxtDni, "Teléfono(s): " + objA.Telefono);
                    TxtDirec.Text = objA.Direccion;
                    TxtDni.Text = objA.Dni;
                    break;
                case ENumTabla.PERSONAL:
                    var objP = PersonalDao.GetbyId(cod);
                    if (objP == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }

                    EdCodigo.BackColor = Color.LightGreen;
                    cMoviles = String.Empty;
                    TxtRazon.Text = objP.RazonSocial;
                    if (objP.Nrofijo.Length > 0)
                        cMoviles = "FIJO: " + objP.Nrofijo;
                    if (objP.Movil.Length > 0)
                        cMoviles = "MOVIL: " + objP.Movil;
                    if (!string.IsNullOrEmpty(cMoviles))
                        toolTipController1.SetToolTip(TxtDni, cMoviles);
                    TxtDirec.Text = objP.Direc;
                    TxtDni.Text = objP.NroDocIden;
                    break;
                case ENumTabla.PROVEEDOR:
                    var objV = ProveedorDao.GetbyId(cod);
                    if (objV == null)
                    {
                        dxErrorProvider1.SetError(EdCodigo, "Código Ingresado No Existe");
                        break;
                    }

                    EdCodigo.BackColor = Color.LightGreen;
                    cMoviles = String.Empty;
                    TxtRazon.Text = objV.Razon;
                    if (objV.Telefono.Length > 0)
                        cMoviles = "FIJO: " + objV.Telefono;
                    if (!string.IsNullOrEmpty(cMoviles))
                        toolTipController1.SetToolTip(TxtDni, cMoviles);
                    TxtDirec.Text = objV.Direccion;
                    TxtDni.Text = objV.Dni;
                    break;

            } //fin de switch
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
               BtnAgregar_Click(sender,null);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var oFrm2 = new FphDetalleOrden
            {
                _TiTuloForm = "Busqueda o Modificación de un Item",
                _backColor = Color.PaleGoldenrod,
                _TipoOrden = ENumTipoOrden.SERVICIO
            };
            //oFrm2.CargarDatos();
            oFrm2.ShowDialog();
            SuspendLayout();
            if (String.IsNullOrEmpty(oFrm2._Codigo)) //valor vacio si cerro o hizo click en Cancelar
            {
                oFrm2.Close();
                return;
            }
            var drow = _tbOrdenDetalle.NewRow();
            drow["Id"] = 0; //Es Nuevo
            drow["IdOrden"] = String.IsNullOrEmpty(Value) ? 0 : Convert.ToInt64(Value);
            drow["IdClasificador"] = Convert.ToInt32(oFrm2.EdIdClasificador.Tag);
            drow["IdMeta"] = Convert.ToInt32(oFrm2.EdIdMeta.Tag);
            drow["IdTipoUsuario"] = oFrm2.CboTipoUsuario.EditValue.ToString()[0];
            drow["Clasificador"] = oFrm2.EdIdClasificador.EditValue.ToString();
            drow["Codigo"] = oFrm2.EdCodigo.EditValue.ToString();
            drow["Detalle"] = oFrm2.TxtDetalle.Text.Trim();
            drow["Monto"] = oFrm2.SpnMonto.EditValue;
            _tbOrdenDetalle.Rows.Add(drow);
            RefreshDetalle();
            ResumeLayout();
        }

        private void CboTipoUsuario_EditValueChanged(object sender, EventArgs e)
        {
            var c = (char)CboTipoUsuario.EditValue;
            switch (c)
            {
                case 'V': //Proveedor
                case 'A': //Alumno
                case 'P': //Personal
                    EdCodigo.Visible = true;
                    LblTipoUsuario.Visible = true;
                    TxtDirec.Visible = true;
                    TxtRazon.Visible = true;
                    TxtDni.Visible = true;
                    LblDirec.Visible = true;
                    LblRuc.Visible = true;
                    break;
                case 'S': //Servicios
                case 'N': //Ninguno
                    EdCodigo.Visible = false;
                    LblTipoUsuario.Visible = false;
                    TxtDirec.Visible = false;
                    TxtRazon.Visible = false;
                    TxtDni.Visible = false;
                    LblDirec.Visible = false;
                    LblRuc.Visible = false;
                    break;
            }
        }
    } //Fin de Clase
}
