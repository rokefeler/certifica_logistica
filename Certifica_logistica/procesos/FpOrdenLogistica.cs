﻿using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using Certifica_logistica.utiles;
using CrystalDecisions.CrystalReports.Engine;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.procesos
{
    public partial class FpOrdenLogistica : Masterform
    {
// ReSharper disable once InconsistentNaming
        public ENumTipoOrden _TipoOrden;
        private DsTramite.TTipoUsuarioDataTable _tbUsuario;
        private DsTramite.TTipoUsuarioDataTable _tbUsuarioGrid;
        private DsTramite.DetalleOrdenDataTable _tbOrdenDetalle;
        private string _lastClasificador;
        private string _lastMeta;
        private Ds.PrinterOrden _DsPrint;
/*
        private DataSet _ds;
*/
        public FpOrdenLogistica()
        {
            InitializeComponent();
            _tbUsuario = new DsTramite.TTipoUsuarioDataTable();
            _tbUsuarioGrid = new DsTramite.TTipoUsuarioDataTable();
            _TipoOrden= ENumTipoOrden.SERVICIO;
            _tbOrdenDetalle = (DsTramite.DetalleOrdenDataTable) dsTramite.Tables[name: "DetalleOrden"];
        }

        private void FpOrdenLogistica_Load(object sender, EventArgs e)
        {
            var cad = String.Empty;
            var collection = new AutoCompleteStringCollection();
            string[] str = { "FACTURA", "BOLETA DE VENTA", "SERV.LUZ ELECTRICA", "SERV.LUZ TRIFASICA", "SERV.AGUA", "SERV.TELEFONIA MOVIL", "SERV.TELEFONIA FIJA", "SERV.INTERNET", "LABOR REALIZADA (rph)", "PROPINAS", "MOVILIDAD", "VIATICOS", "PASAJES AEREOS", "RECIBO", "PASAJES TERRESTRES", "SERV.CABLE", "DOCENTE EXTRANJERO" };
            collection.AddRange(str);
            TxtReferencia.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtReferencia.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtReferencia.MaskBox.AutoCompleteCustomSource = collection;
            var ninicial = DateTime.Now.Year;
            CboYearExp.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
            {
                CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));
                CboYearOrden.Items.Add(i.ToString(CultureInfo.InvariantCulture));
            }


            CboYearExp.SelectedIndex = 0;
            CboYearOrden.SelectedIndex = 0;
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
            switch (_TipoOrden)
            {
                case ENumTipoOrden.PROPINAS:
                    CboTipoUsuario.EditValue = 'N';
                    cad = @"PLANILLA DE PROPINAS";
                    break;
                case ENumTipoOrden.MOVILIDAD: //PERSONAL
                    cad = @"PLANILLA DE MOVILIDAD";
                    CboTipoUsuario.EditValue = 'N';
                    break;
                case ENumTipoOrden.CONVENIO: //DOC EXTRANJERO
                    cad = @"CONTRATO CONVENIO";
                    CboTipoUsuario.EditValue = 'P';
                    break;
                case ENumTipoOrden.VIATICOS: //PERSONAL
                    cad = @"PLANILLA DE VIATICOS";
                    CboTipoUsuario.EditValue = 'P';
                    break;
                case ENumTipoOrden.SERVICIO: //PROVEEDOR
                    cad = @"ORDEN DE SERVICIO U TRABAJO";
                    CboTipoUsuario.EditValue = 'V';
                    break;
            }
            LblTitulo.Text = cad;
            Text = cad;
            //Para Columnas del GridView
            General.RellenarEstadoDataSet(ref _tbUsuarioGrid, ENumTipoOrden.NINGUNO);
            repositoryItemSearchTipoUsuario.DataSource = _tbUsuarioGrid;
            repositoryItemSearchTipoUsuario.DisplayMember = "nombre";
            repositoryItemSearchTipoUsuario.ValueMember = "Sigla";

            //TODO GRAVE: Se debe consistenciar para consultas de años posteriores
            repositoryItemSearchIdMeta.DataSource = MetaDao.SelectAllByAnio(DateTime.Now.Year.ToString(CultureInfo.InvariantCulture)); //TipoFormapagoDao.GetAllList();
            repositoryItemSearchIdMeta.DisplayMember = "Cnro";
            repositoryItemSearchIdMeta.ValueMember = "IdMeta";
            RefreshDetalle();
            //Por defecto fecha actual para la orden en pantalla
            DtFechaGiro.DateTime = DateTime.Now;
        }


        public override bool Master_GrabarFormulario()
        {
            if (!Master_Verificar()) return false;
            OrdenLogistica obj;
            obj = new OrdenLogistica();
            if (!String.IsNullOrEmpty(Value))
                obj.IdOrden = Convert.ToInt64(Value); //Indicar el Id de la Orden.
            obj.IdExpediente = EdIdExpediente.Tag.ToString();
            obj.IdxTipoOrden = General.AnalizaTipoOrden(_TipoOrden);
            if (obj.IdxTipoOrden.Length == 0)
            {
                General.ShowMessage("No Puedo Controlar este Tipo de Formulario","Datos Modificados");
                Application.Exit();
            }
            obj.TipoUsuario = (char) CboTipoUsuario.EditValue;
            try
            {
                obj.Codigo = EdCodigo.EditValue.ToString().Trim();
            }
            catch
            {
                obj.Codigo = "";
            }
            obj.FechaGiro = DtFechaGiro.DateTime;
            Codigo cod;
            cod = (Codigo) CboTipoProceso.SelectedItem;
            obj.IdxProceso = cod.Id;
            obj.Nro = Convert.ToInt32(EdIdOrden.EditValue);
            obj.Anio = Convert.ToInt32(CboYearOrden.SelectedItem.ToString());
            obj.NroProceso = TxtNroProceso.Text;
            obj.Referencia = TxtReferencia.Text;
            obj.Descripcion = memoDescripcion.Text;
            obj.Total = Convert.ToDecimal(TxtTotal.Tag);
            obj.Siaf = TxtSiaf.Text;
            obj.CodLogin = _FrmPadre.Miconfiguracion.IdUsuario;
            obj.Ccp = TxtCcp.Text;
            obj.RdAutoriza = TxtRd.Text;
            DbConnection con = null;
            string msg;
            DbTransaction dbTrans = null;
            try
            {
                con = DATA.Db.CreateConnection();
                con.Open();
                dbTrans = con.BeginTransaction();
                int nroOrden, IdOrden;
                var ret = OrdenLogisticaDao.Grabar(obj, dbTrans, out nroOrden);
                msg = General.AnalizaResultadoSql(ret);
                if (ret <= 0)
                {
                    EdIdOrden.ResetBackColor();
                    General.ShowMessage(msg, "Error", icon: MessageBoxIcon.Error);
                    dbTrans.Rollback();
                    return false;
                }
                IdOrden = ret;
                OrdenLogisticaDetalle det;
                //Ahora Grabar u Modificar los Detalles de la Orden
                foreach (DsTramite.DetalleOrdenRow dr in _tbOrdenDetalle.Rows)
                {
                    det=new OrdenLogisticaDetalle();
                    det.Id = (long) dr["Id"];
                    det.IdOrden = IdOrden ;
                    det.IdClasificador = (int) dr["IdClasificador"];
                    det.IdMeta = (int) dr["IdMeta"];
                    det.TipoUsuario = (char) dr["IdTipoUsuario"];
                    det.Codigo = (string) dr["codigo"];
                    det.Detalle = (string) dr["Detalle"];
                    det.Monto = (decimal) dr["Monto"];
                    ret=OrdenLogisticaDetalleDao.Grabar(det, dbTrans);
                    if (ret > 0) continue;
                    dbTrans.Rollback();
                    EdIdOrden.ResetBackColor();
                    msg = General.AnalizaResultadoSql(ret);
                    General.ShowMessage(msg,"ERROR EN TRANSACCION", icon: MessageBoxIcon.Error);
                    return false; //Salir y CAncelar
                } //fin de ForEachdbTrans.Commit();
                Value = IdOrden.ToString(CultureInfo.InvariantCulture); //grabar En Memoria el Nro de IdOrden.
                if(nroOrden>0)
                    EdIdOrden.EditValue = nroOrden;   //Colocar el Nro de Orden
                EdIdOrden.BackColor = Color.LightGreen;
                dbTrans.Commit();
                General.ShowMessage(msg,"PROCESO OK");
            }
            catch (Exception ex)
            {
                if (dbTrans != null) dbTrans.Rollback();
                General.ShowMessage(ex.Message);
            }
            finally
            {
                if (con != null && con.State== ConnectionState.Open) con.Close();
            }

            return true;
        }
        public override bool Master_ImprimirFormulario(bool isPrevio, int nCopias)
        {
            var ret = false;
            #region Verificar Datos suficientes para Imprimir
            if (String.IsNullOrEmpty(Value))
            {
                General.ShowMessage("Primero debe cargar los Datos del Prestamo en Pantalla", "Faltan Datos");
                EdIdOrden.Focus();
                return false;
            }
            #endregion


            var rpt = new ReportDocument();
            
            var Ds= OrdenLogisticaDao.ImprimirOrden(Convert.ToInt64(Value));
            _DsPrint = new PrinterOrden();
            // dsTramite.Tables[name: "DetalleOrden"].Clear();
            // dsTramite.Tables[name: "DetalleOrden"].Load(_tbOrdenDetalle.CreateDataReader());
            _DsPrint.Tables["Orden"].Load(Ds.Tables[0].CreateDataReader());
            _DsPrint.Tables["Detalle"].Load(Ds.Tables[1].CreateDataReader());
            _DsPrint.Tables["resumen_metas"].Load(Ds.Tables[2].CreateDataReader());

            if (_DsPrint.Tables.Count > 0)
            {
                rpt.Load(Application.StartupPath + @"\reportes\ordenservicio.rpt");
                rpt.SetDataSource(_DsPrint);
                ret = true;
                if (isPrevio)
                {
                    var previewDoc = new FrmPrevio { RptDoc = rpt };
                    previewDoc.ShowDialog();
                }
                else
                {
                    //Rpt.PrintOptions.PrinterName = _FrmPadre.Miconfiguracion.PrinterName;
                    rpt.PrintToPrinter(nCopias, true, 1, 99999);
                }
            }
            else
            {
                General.ShowMessage("No Existe Nada que Imprimir", "Resultado Vacio");
                EdIdOrden.Focus();
            }
            _DsPrint.Clear();
            _DsPrint = null;
            return ret;
        }
        public override bool Master_Verificar()
        {
            String cad;
            try
            {
                cad = EdIdExpediente.EditValue.ToString().Trim();

            }
            catch
            {
                cad = string.Empty;
            }
            if (string.IsNullOrEmpty(cad))
            {
                cad = "Debe Cargar el Expediente Relacionado";
                dxErrorProvider1.SetError(EdIdExpediente,cad);
                toolTipController1.SetToolTip(EdIdExpediente,cad);
                EdIdExpediente.Focus();
                return false;
            }
            dxErrorProvider1.SetError(EdIdExpediente, "");
            if (TxtReferencia.Text.Trim().Length <= 0)
            {
                cad = "Falta descripción o Detalle";
                dxErrorProvider1.SetError(TxtReferencia, cad);
                toolTipController1.SetToolTip(TxtReferencia, cad);
                TxtReferencia.Focus();
                return false;
            }
            toolTipController1.SetToolTip(TxtReferencia, "");

            if (_TipoOrden == ENumTipoOrden.VIATICOS || _TipoOrden == ENumTipoOrden.CONVENIO ||
                _TipoOrden == ENumTipoOrden.SERVICIO)
            {
                try     { cad = EdCodigo.EditValue.ToString().Trim(); }
                catch   { cad = string.Empty; }
                if (string.IsNullOrEmpty(cad))
                {
                    cad = "Falta Ingresar el Código del Personal u Proveedor";
                    dxErrorProvider1.SetError(EdCodigo, cad);
                    toolTipController1.SetToolTip(EdCodigo, cad);
                    EdCodigo.Focus();
                    return false;
                }
            }
            dxErrorProvider1.SetError(EdCodigo, "");

            if (gridView1.RowCount <= 0)
            {
                cad = "Debe Agregar Items al Documento";
                dxErrorProvider1.SetError(gridControl1, cad);
                gridView1.Focus();
            }
            dxErrorProvider1.SetError(gridControl1, "");
            return true;
        }

        public override bool Master_NuevoFormulario()
        {
            toolTipController1.SetToolTip(DtFechaExp, "");
            EdIdOrden.EditValue = null;
            EdIdOrden.ResetBackColor();
            
            EdIdExpediente.EditValue = null;
            EdIdExpediente.ResetBackColor();
            
            CboYearOrden.SelectedIndex = 0;
            CboYearOrden.ResetBackColor();
            
            CboYearExp.SelectedIndex = 0;
            CboYearExp.ResetBackColor();
            
            DtFechaExp.EditValue = null;
            CboFuente.SelectedIndex = 0;
            CboMoneda.SelectedIndex = 0;
            TxtNroAutorizacion.Text = "";
            TxtMontoAprobado.Text = "";
            DtFechaGiro.DateTime = DateTime.Now;
            TxtSubDependencia.Text = "";
            TxtDocumento.Text = "";
            TxtReferencia.Text = "";
            CboTipoProceso.SelectedIndex = 0;
            TxtNroProceso.Text = "";
            TxtSiaf.Text = "";
            TxtCcp.Text = "";
            EdCodigo.EditValue = null;
            TxtRazon.Text = "";
            TxtDirec.Text = "";
            TxtDni.Text = "";
            memoDescripcion.EditValue = null;
            TxtRd.Text = "";
            TxtTotal.Text = @"0.00";
            _tbOrdenDetalle.Rows.Clear();
            dxErrorProvider1.ClearErrors();
            EdIdExpediente.Focus();
            return true;
        }

        public override bool Master_CargarFicha(string idPrincipal, string idSecundario, int anio)
        {
            var ord = OrdenLogisticaDao.GetbyId(Convert.ToInt32(idPrincipal),anio, idSecundario);
            if (ord == null)
            {
                General.ShowMessage("El Numero de Orden Ingresado, No Se encuentra Registrado","Intentelo Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            CargarExpediente(ord.IdExpediente);
            Value = ord.IdOrden.ToString();
            //TODO PROBAR CARGA DE ORDEN AQUI ME QUEDE
            //Ahora cargar los demas Datos
            DtFechaGiro.EditValue = ord.FechaGiro;
            TxtReferencia.Text = ord.Referencia;
            EdIdOrden.BackColor = Color.LightGreen;
            CboYearOrden.BackColor = Color.LightGreen;
            General.UbicaItemsComboCodigo(CboTipoProceso, ord.IdxProceso);
            CboTipoProceso_SelectedIndexChanged(this,null);
            TxtNroProceso.Text = ord.NroProceso;
            TxtSiaf.Text = ord.Siaf;
            TxtCcp.Text = ord.Ccp;
            CboTipoUsuario.EditValue = ord.TipoUsuario;
            CboTipoUsuario_EditValueChanged(this,null);
            EdCodigo.EditValue = ord.Codigo;
            EdCodigo_Leave(this,null);
            memoDescripcion.EditValue = ord.Descripcion;
            TxtRd.Text = ord.RdAutoriza;
            var ds = OrdenLogisticaDetalleDao.GetbyAll(ord.IdOrden);
            _tbOrdenDetalle.Clear();
            _tbOrdenDetalle.Load(ds.CreateDataReader());
            TxtTotal.Text = ord.Total.ToString();
            TxtTotal.Tag = ord.Total.ToString();
            // dsTramite.Tables[name: "DetalleOrden"].Clear();
            // dsTramite.Tables[name: "DetalleOrden"].Load(_tbOrdenDetalle.CreateDataReader());
            return false;
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var cTipoUsuario = (char) CboTipoUsuario.EditValue;
            var eTipoTabla= ENumTabla.NINGUNO;
            var msg=String.Empty;
            switch (cTipoUsuario)
            {
                case 'V':
                    eTipoTabla=ENumTabla.PROVEEDOR;
                    msg = "Busqueda de Proveedor";
                    break;
                case 'P':
                    eTipoTabla= ENumTabla.PERSONAL;
                    msg = "Busqueda de Personal";
                    break;
                case 'A':
                    eTipoTabla= ENumTabla.ALUMNO;
                    msg = "Busqueda de Alumnos";
                    break;
                case 'S':
                    eTipoTabla= ENumTabla.SERVICIOS;
                    msg = "Busqueda de Servicios";
                    break;
            }
            
            var oFrm = new FphBusqueda { _TiTuloForm = msg, _backColor = BackColor, _TipoTabla = eTipoTabla };
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodigo.Text = oFrm._Codigo;
            TxtRazon.Text=oFrm._Nombre;
            oFrm.Close();
            ResumeLayout();
        }


        private void RefreshDetalle()
        {
            dsTramite.Tables[name: "DetalleOrden"].AcceptChanges();
            //CALCULAR la SUMA
            var objSum = _tbOrdenDetalle.Compute("Sum(Monto)", "");
            TxtTotal.Text = Convert.ToDecimal(objSum).ToString("# ###,#00.00");
            TxtTotal.Tag = Convert.ToDecimal(objSum).ToString(CultureInfo.InvariantCulture);
            
            /*
            var query = from row in _tbOrdenDetalle.AsEnumerable()
                        group row by row.Field<Int32>("IdMeta") into grp
                        select new
                        {
                            Id = grp.Key,
                            sum = grp.Sum(r => r.Field<int>("Monto"))
                        };
            foreach (var grp in query)
            {
                LstMetas.Items.Add(String.Format("S/. {0} = {1}", grp.Id, grp.sum));
            }*/
            //var dtotal=_tbOrdenDetalle.Select("COUNT")
            // dsTramite.Tables[name: "DetalleOrden"].Clear();
            // dsTramite.Tables[name: "DetalleOrden"].Load(_tbOrdenDetalle.CreateDataReader());
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
            if (EdIdExpediente.EditValue == null) return;
            if (EdIdExpediente.IsModified) return;
            var cNroExp = EdIdExpediente.EditValue.ToString();
            if (cNroExp.Length <= 0) return;
            cNroExp = cNroExp.PadLeft(6, '0');
            EdIdExpediente.EditValue = cNroExp;
            cNroExp = cNroExp + "-" + CboYearExp.SelectedItem;
            CargarExpediente(cNroExp);
        }

        private void CargarExpediente(string cNroExp)
        {
            string msg;
            var exp = ExpedienteDao.GetbyId(cNroExp);
            EdIdExpediente.ResetBackColor();
            CboYearExp.ResetBackColor();
            if (exp == null)
            {
                EdIdExpediente.Tag = "";
                Console.Beep();
                msg = "El Expediente Ingresado " + cNroExp + " No Existe";
                toolTipController1.ShowHint((string) msg);
                return;
            }
            EdIdExpediente.Tag = cNroExp;
            EdIdExpediente.BackColor = Color.LightGreen;
            CboYearExp.BackColor = Color.LightGreen;
            var words = cNroExp.Split('-');
            EdIdExpediente.EditValue = words[0];
            toolTipController1.SetToolTip(label18, "F.Exp =" + exp.FechaExp.ToShortDateString());
            DtFechaExp.DateTime = exp.FechaIngreso;
            for (var x = 0; x < CboFuente.Items.Count; x++)
            {
                var fte = (FuenteFinanciamiento) CboFuente.Items[x];
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
            TxtSubDependencia.Text = codSubDep != null
                ? string.Format("{0} / {1}", codSubDep.Nombre, codSubDep.NombreDependencia)
                : @"NO EXISTE !!!";

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
                ModificarItem(true);
            }
            else if (e.KeyCode == Keys.Enter)
                ModificarItem();
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            ModificarItem();
        }

        private void ModificarItem(bool isNuevo=false)
        {
            var index = GetUnicaFilaActual(); //index de muestra del grid
            if(!isNuevo)
                if (index <= 0) return;
            var msg = isNuevo ? @"Nuevo ITEM" : @"MODIFICACION DE ITEM";
            var oFrm2 = new FphDetalleOrden
            {
                _TiTuloForm = msg,
                _backColor = Color.PaleGoldenrod,
                _TipoOrden = _TipoOrden
            };
            try
            {
                oFrm2.CargarDatos();
                DataRowView r=null;

                if (!isNuevo)
                {
                    /*drow = (DsTramite.DetalleOrdenRow) _tbOrdenDetalle.Rows.Find(index);
                    if (drow == null)
                    {
                        General.ShowMessage("No se encontró la Fila Indicada");
                        return;
                    }*/
                    r = (DataRowView) gridView1.GetFocusedRow();
                    
                    oFrm2.EdIdClasificador.Tag = r["IdClasificador"].ToString();
                    var m = MetaDao.GetbyId(Convert.ToInt32(r["IdMeta"]));
                    if (m != null)
                    {
                        oFrm2.EdIdMeta.Tag = m.IdMeta.ToString(CultureInfo.InvariantCulture);
                        oFrm2.EdIdMeta.EditValue = m.Cnro;
                    }
                    oFrm2.CboTipoUsuario.EditValue = Convert.ToChar(r["IdTipoUsuario"]);
                    oFrm2.EdIdClasificador.EditValue = r["Clasificador"];
                    oFrm2.EdCodigo.EditValue = r["Codigo"];
                    oFrm2.EdCodigo.IsModified = false;
                    oFrm2.TxtDetalle.Text = r["Detalle"].ToString();
                    oFrm2.SpnMonto.EditValue = Convert.ToDecimal(r["Monto"]);

                }
                else //Si es Nuevo
                {
                    if (!String.IsNullOrEmpty(_lastClasificador))
                        oFrm2.EdIdClasificador.EditValue = _lastClasificador;
                    if (!String.IsNullOrEmpty(_lastMeta))
                        oFrm2.EdIdMeta.EditValue = _lastMeta;
                }
                
                oFrm2.ShowDialog();
                SuspendLayout();
                if (String.IsNullOrEmpty(oFrm2._Codigo)) //valor vacio si cerro o hizo click en Cancelar
                {
                    oFrm2.Close();
                    return;
                }

                if (isNuevo)
                {
                    var drow = _tbOrdenDetalle.NewDetalleOrdenRow();
                    drow["Id"] = 0; //Este es Id de Base de Datos CUIDADO
                    drow["IdOrden"] = String.IsNullOrEmpty(Value) ? 0 : Convert.ToInt64(Value);
                    drow["IdClasificador"] = Convert.ToInt32(oFrm2.EdIdClasificador.Tag);
                    drow["IdMeta"] = Convert.ToInt32(oFrm2.EdIdMeta.Tag);
                    _lastMeta = oFrm2.EdIdMeta.EditValue.ToString();
                    drow["IdTipoUsuario"] = oFrm2.CboTipoUsuario.EditValue.ToString()[0];
                    _lastClasificador = oFrm2.EdIdClasificador.EditValue.ToString();
                    drow["Clasificador"] = _lastClasificador;
                    drow["Codigo"] = (oFrm2.EdCodigo==null) ? "" : oFrm2.EdCodigo.EditValue.ToString() ;
                    drow["Detalle"] = oFrm2.TxtDetalle.Text.Trim();
                    drow["Monto"] = oFrm2.SpnMonto.EditValue;
                    _tbOrdenDetalle.Rows.Add(drow);
                }
                else //Si es Modificación de un Item
                {
                    //Continua drow
                    r["IdClasificador"] = oFrm2.EdIdClasificador.Tag;
                    r["IdMeta"] = Convert.ToInt32(oFrm2.EdIdMeta.Tag);
                    _lastMeta = oFrm2.EdIdMeta.EditValue.ToString();
                    r["IdTipoUsuario"] = oFrm2.CboTipoUsuario.EditValue.ToString()[0];
                    _lastClasificador = oFrm2.EdIdClasificador.EditValue.ToString();
                    r["Clasificador"] = _lastClasificador;
                    r["Codigo"] = oFrm2.EdCodigo.EditValue.ToString();
                    r["Detalle"] = oFrm2.TxtDetalle.Text.Trim();
                    r["Monto"] = oFrm2.SpnMonto.EditValue;
                }
                RefreshDetalle();
                ResumeLayout();
            }
            catch (Exception ex)
            {
                General.ShowMessage(ex.Message, "Ups , Intentelo Nuevamente");
            }
        }
        private void CboTipoUsuario_EditValueChanged(object sender, EventArgs e)
        {
            var c = (char)CboTipoUsuario.EditValue;
            switch (c)
            {
                case 'V': //Proveedor
                case 'A': //Alumno
                case 'P': //Personal
                    LblRazon.Visible = true;
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
                    LblRazon.Visible = false;    
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
        private int GetUnicaFilaActual()
        {
            string cod;
            try
            {
                var r = (DataRowView)gridView1.GetFocusedRow();
                cod = r[0].ToString();
            }
            catch
            {
                cod = "0";
            }
            return Convert.ToInt32(cod);
        }

        private void BtnCargaOrden_Click(object sender, EventArgs e)
        {
            if (EdIdOrden.EditValue == null) return;
            if (EdIdOrden.IsModified) return;
            var cNroExp = EdIdOrden.EditValue.ToString();
            var nExp = Convert.ToInt32(cNroExp);
            if (nExp<= 0) return;
            try
            {
                var cIdxTipoOrden = General.AnalizaTipoOrden(_TipoOrden);
                if (cIdxTipoOrden.Length == 0)
                {
                    General.ShowMessage("No Puedo Controlar este Tipo de Formulario", "Datos Modificados");
                    Application.Exit();
                }
                Master_CargarFicha(cNroExp, cIdxTipoOrden, Convert.ToInt32(CboYearOrden.SelectedItem.ToString()));
            }
            catch
            {
                Console.Beep();
                return;
            }
        }

        private void EdIdExpediente_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De Expedientes Ingresados", _backColor = BackColor, _TipoTabla = ENumTabla.EXPEDIENTE };
            oFrm.ShowDialog();
            SuspendLayout();
            var cad = oFrm._Codigo;
            var sLista = cad.Split('-');
            toolTipController1.SetToolTip(EdIdExpediente, oFrm._Nombre);
            EdIdExpediente.EditValue=sLista[0];
            foreach (var anio in CboYearExp.Items)
            {
                if (!anio.Equals(sLista[1])) continue;
                CboYearExp.SelectedItem = anio;
                break;
            }
            oFrm.Close();
            ResumeLayout();
        
        }

        
    } //Fin de Clase
}
