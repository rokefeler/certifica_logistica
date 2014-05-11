using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using Certifica_logistica.utiles;
using CrystalDecisions.CrystalReports.Engine;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Winnovative.ExcelLib;

namespace Certifica_logistica.salidas
{
    public partial class FrReporte01 : Masterform
    {
        private DsTramite.TTipoUsuarioDataTable _tbUsuario;
// ReSharper disable once InconsistentNaming
        public ENumTipoOrden _TipoOrden;
        private DataSet _ds;
        public FrReporte01()
        {
            InitializeComponent();
            _tbUsuario = new DsTramite.TTipoUsuarioDataTable();
            var punto = new Point(3, 29);
            CboEmisor.Location = TxtFiltro.Location;
            CboTipoOrden.Location = TxtFiltro.Location;
            CboTipoProceso.Location = TxtFiltro.Location;
            CboTipoProceso.Size = CboTipoOrden.Size;
            GrpSubDependencia.Location = punto;
            GrpTipoUsuario.Location = punto;
            _ds = new DataSet();
        }
        private void FrReporte01_Load(object sender, EventArgs e)
        {
            _TipoOrden = ENumTipoOrden.NINGUNO;
            dsReporteOrden.Tables[name: "RptDetalleOrden"].Clear();
            //dsReporteOrden.Tables[name: "RptDetalleOrden"].Load(_ds.CreateDataReader());
            General.RellenarEstadoDataSet(ref _tbUsuario, _TipoOrden);
            /******************************************************/
            Dock = DockStyle.Fill;
            var location = Location;
            var tamanio = Size;
            Dock = DockStyle.None;
            Location = location;
            Size = tamanio;
            /******************************************************/
            CboTipoUsuario.Properties.DataSource = _tbUsuario;
            CboTipoUsuario.Properties.DisplayMember = "nombre";
            CboTipoUsuario.Properties.ValueMember = "Sigla";
            
            General.CargarDatos(CboTipoProceso, "PCAD", "PCAD-0000");
            General.CargarDatos(CboTipoOrden, "TOGL", "TOGL-0001");

            try
            {
                CboEmisor.DataSource = LoginDao.SelectAll(); //Listar Todos los Vigentes
                CboEmisor.ValueMember = "CodLogin";
                CboEmisor.DisplayMember = "CodLogin";

                //UBICAR CUAL ES EL Usuario Actual.
                foreach (Login user in CboEmisor.Items)
                {
                    if (!user.CodLogin.Equals(_FrmPadre.Miconfiguracion.IdUsuario)) continue;
                    CboEmisor.SelectedItem = user;
                    break;
                }
                    
            }
            catch (Exception ex)
            {
                General.ShowMessage(ex.Message, "Error interno - Codigos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CboFiltro.SelectedIndex = 0;
            DtFechaDel.DateTime = DateTime.Now;
            DtFechaAl.DateTime = DateTime.Now;
        }

        public override bool Master_RunFormulario()
        {
            var n = CboFiltro.SelectedIndex;
            String vDel, vAl;
            try
            {
                vDel = DtFechaDel.DateTime.ToString("yyyyMMdd");
                vAl = DtFechaAl.DateTime.ToString("yyyyMMdd");
            }
            catch(Exception exx)
            {
                General.ShowMessage(exx.Message,"Ups!");
                Console.Beep();
                return false;
            }

            Codigo cod;
            var codSub = String.Empty;
            switch (n)
            {
                case 1: // Listado por Nº Expediente
                    codSub = TxtFiltro.Text.Trim().ToUpper();
                    break;
                case 2: // Listado por Tipo de Orden
                    cod = (Codigo) CboTipoOrden.SelectedItem;
                    codSub = cod.Id;
                    break;
                case 3: // Tipo de Proceso
                    cod = (Codigo)CboTipoProceso.SelectedItem;
                    codSub = cod.Id;
                    break;
                case 4: // SubDependencia
                    codSub = EdCodSubDep.Text.Trim();
                    break;
                case 5: // Codigo RUC-DNI-CUI
                    codSub = EdCodigo.Text.Trim();
                    break;
                case 6: // Autorizado
                    codSub = TxtFiltro.Text.Trim();
                    break;
                case 7: // Ccp
                    codSub = TxtFiltro.Text.Trim();
                    break;
                case 8: // Usuario Emisor
                    codSub = ((Login) CboEmisor.SelectedItem).CodLogin;
                    break;
            }
            UseWaitCursor = true;
            _ds = OrdenLogisticaDao.GetReporteDetallado(n, _FrmPadre.Miconfiguracion.IdUsuario, vDel, vAl, codSub);
            dsReporteOrden.Tables[name: "RptDetalleOrden"].Clear();
            dsReporteOrden.Tables[name: "RptDetalleOrden"].Load(_ds.CreateDataReader());
            gridView1.BestFitColumns();
            UseWaitCursor = false;
            try
            {
                BtnExportar.Visible = false;
                if (_ds.Tables[0].Rows.Count > 0)
                    BtnExportar.Visible = true;
            }
            catch
            {
                Console.Beep();
            }
            return true;
        }
        public override bool Master_ImprimirFormulario(bool isPrevio, int nCopias, int desde, int hasta, string cImpresora)
        {
            const string cReporte = "detordenes.rpt";
            #region Verificar Datos suficientes para Imprimir
            if (dsReporteOrden.RptDetalleOrden.Rows.Count <= 0)
            {
                General.ShowMessage("No se encontró ninguna Orden registrada para poder Imprimir", "No Existen Datos", icon: MessageBoxIcon.Stop);
                return false;
            }
            #endregion

            var rpt = new ReportDocument();
            //var dsRpt = OrdenLogisticaDao.GetReporteByExpediente(Value);
            //_dsPrint = new PrinterOrden();
            //_dsPrint.Tables["Orden"].Load(ds.Tables[0].CreateDataReader());

            var cTitle = TituloReporte();
            rpt.Load(string.Format("{0}\\reportes\\{1}", Application.StartupPath, cReporte));
            rpt.SetDataSource((DataTable)dsReporteOrden.RptDetalleOrden);
            rpt.SetParameterValue(0, cTitle); //Parametro único que aparecera en el Titulo
            rpt.SetParameterValue(1, _FrmPadre.Miconfiguracion.IdUsuario); // CodLogin que Genera Impresión

            if (isPrevio)
            {
                var previewDoc = new FrmPrevio { RptDoc = rpt };
                previewDoc.ShowDialog();
            }
            else
            {
                rpt.PrintOptions.PrinterName = cImpresora;
                rpt.PrintToPrinter(nCopias, true, desde, hasta);
            }
            return true;
        }

        private string TituloReporte()
        {
            var cTitle = String.Format("Reporte Detallado de Ordenes Del {0} Al {1}", DtFechaDel.DateTime.ToShortDateString(),
                DtFechaAl.DateTime.ToShortDateString());
            cTitle += " Filtro = {0}";
            String cOpcion = "";
            switch (CboFiltro.SelectedIndex)
            {
                case 0:
                    cOpcion = "Ver Todos";
                    break;
                case 1:
                    cOpcion = "por Nº Expediente:";
                    cOpcion += TxtFiltro.Text.Trim();
                    break;
                case 2:
                    cOpcion = "por Tipo de Orden:";
                    var cod = (Codigo) CboTipoOrden.SelectedItem;
                    cOpcion += cod.Nombre;
                    break;
                case 3:
                    cOpcion = "por Tipo de Proceso:";
                    var cod2 = (Codigo) CboTipoProceso.SelectedItem;
                    cOpcion += cod2.Nombre;
                    break;
                case 4:
                    cOpcion = "por SubDependencia:";
                    cOpcion += TxtSubDependencia.Text;
                    break;
                case 5:
                    cOpcion = "por Código:";
                    cOpcion += EdCodigo.Text.Trim();
                    break;
                case 6:
                    cOpcion = "por Nº Autorizado:";
                    cOpcion += TxtFiltro.Text.Trim();
                    break;
                case 7:
                    cOpcion = "por Nº CCP";
                    cOpcion += TxtFiltro.Text.Trim();
                    break;
                case 8:
                    cOpcion = "por Usuario Emisor:";
                    var cl = (Login) CboEmisor.SelectedItem;
                    cOpcion += cl.CodLogin;
                    break;
            }
            cTitle = String.Format(cTitle, cOpcion);
            return cTitle;
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
        // ReSharper disable once RedundantOverridenMember
        public override void ObjectEnter(object sender, EventArgs e)
        {
            base.ObjectEnter(sender, e);
        }
        private void EdCodSubDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                EdCodSubDep_Properties_ButtonClick(sender, null);
            else
                base.Object_KeyDown(sender, e);
        }
        private void EdCodSubDep_Leave(object sender, EventArgs e)
        {
            var btn = (ButtonEdit)sender;
            if (!btn.IsModified)
            {
                Console.Beep();
                return;
            } //Si no se hizo modificaciones, salir
            var t1 = TxtSubDependencia;
            var t2 = TxtDependencia;
            t1.Text = "";
            t2.Text = "";
            toolTipController1.SetToolTip(t1, "");
            toolTipController1.SetToolTip(t2, "");
            dxErrorProvider1.SetError(btn, "");
            if (btn.EditValue == null) return;
            if (btn.EditValue.ToString().Length <= 0) return;

            var cod = btn.EditValue.ToString().ToUpper();
            if (cod.Length <= 0) return;
            var obj = SubDependenciaDao.GetbyId(cod);
            if (obj == null)
            {
                dxErrorProvider1.SetError(btn, "Este Valor Ingresado no Existe");
                return;
            }
            t1.Text = obj.Nombre;
            var obj2 = DependenciaDao.GetbyId(obj.CodDependencia);
            t2.Text = obj2.Nombre;
            toolTipController1.SetToolTip(t1, obj.Nombre);
            toolTipController1.SetToolTip(t2, obj2.Nombre);
        }
        private void EdCodSubDep_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var btn = (ButtonEdit)sender;
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De SubDependencia Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.SUBDEPENDENCIA };
            oFrm.ShowDialog();
            SuspendLayout();
            btn.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(btn, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
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
            string cMoviles;
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
        private void TxtCodPersonal_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var cTipoUsuario = (char)CboTipoUsuario.EditValue;
            var eTipoTabla = ENumTabla.NINGUNO;
            var msg = String.Empty;
            switch (cTipoUsuario)
            {
                case 'V':
                    eTipoTabla = ENumTabla.PROVEEDOR;
                    msg = "Busqueda de Proveedor";
                    break;
                case 'P':
                    eTipoTabla = ENumTabla.PERSONAL;
                    msg = "Busqueda de Personal";
                    break;
                case 'A':
                    eTipoTabla = ENumTabla.ALUMNO;
                    msg = "Busqueda de Alumnos";
                    break;
                case 'S':
                    eTipoTabla = ENumTabla.SERVICIOS;
                    msg = "Busqueda de Servicios";
                    break;
            }

            var oFrm = new FphBusqueda { _TiTuloForm = msg, _backColor = BackColor, _TipoTabla = eTipoTabla };
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodigo.Text = oFrm._Codigo;
            TxtRazon.Text = oFrm._Nombre;
            oFrm.Close();
            ResumeLayout();
        }
        private void CboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var n = CboFiltro.SelectedIndex;
            GrpTipoUsuario.Visible = false;
            GrpSubDependencia.Visible = false;
            CboEmisor.Visible = false;
            CboTipoOrden.Visible = false;
            CboTipoProceso.Visible = false;
            TxtFiltro.Visible = false;
            LblFiltro.Visible = false;
            splitContainerControl1.SplitterPosition = 49;
            switch (n)
            {
                case 1:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Expediente:";
                    TxtFiltro.Visible = true;
                    break;
                case 2:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Seleccione:";
                    CboTipoOrden.Visible = true;
                    break;
                case 3:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Seleccione:";
                    CboTipoProceso.Visible = true;
                    break;
                case 4:
                    splitContainerControl1.SplitterPosition = 80;
                    GrpSubDependencia.Visible = true;
                    break;
                case 5:
                    splitContainerControl1.SplitterPosition = 75;
                    GrpTipoUsuario.Visible = true;
                    break;
                case 6:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Nº Autorizado:";
                    TxtFiltro.Visible = true;
                    break;
                case 7:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Nº CCP:";
                    TxtFiltro.Visible = true;
                    break;
                case 8:
                    LblFiltro.Visible = true;
                    LblFiltro.Text = @"Seleccione:";
                    CboEmisor.Visible = true;
                    break;
            }
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            //Averiguar numero de filas del DataSet
            if (dsReporteOrden.RptDetalleOrden.Rows.Count <= 0)
            {
                General.ShowMessage("No se encontró ningún registro a Exportar");
                return;
            }
            var cTitle = TituloReporte();
            Image logoImg;
            var nTope = dsReporteOrden.RptDetalleOrden.Rows.Count + 6;
            var sRangeD = String.Concat("C6:C", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sCeldaTotal = String.Concat("M", nTope.ToString(CultureInfo.InvariantCulture));
            var sRangeSumaTotal = String.Concat("M6:M", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeA = String.Concat("A6:A", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeTotal = String.Concat("A6:X", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            // create the workbook in the desired format with a single worksheet
            
            var workbook = new ExcelWorkbook(ExcelWorkbookFormat.Xlsx_2007);

            // get the first worksheet in the workbook
            var worksheet = workbook.Worksheets[0];

            // set the default worksheet name
            worksheet.Name = "exportado";
            //worksheet[sRangeI].Style.Number.NumberFormatString = "@";
            
            // load data from DataTable into the worksheet
            worksheet.LoadDataTable(dsReporteOrden.RptDetalleOrden, 5, 1, true);
            // customize the workbook
            ExcelCellStyle styleTitulo, styleHeader, styleRows, styleformulaTotal;
            General.EstiloExportarExcel(workbook, out styleTitulo, out styleHeader, out styleRows, out styleformulaTotal, out logoImg);
            
            // set workbook description properties
            workbook.DocumentProperties.Subject = "Listado Detallado de Ordenes Según Criterio";
            workbook.DocumentProperties.Comments = "Información de OUL-UNSA";


            #region WRITE THE WORKSHEET TOP TITLE

            // merge the cells in the range to create the title area 
            worksheet["A2:X3"].Merge();
            // gets the merged range containing the top left cell of the range
            var titleRange = worksheet["A2"].MergeArea;
            // set the text of title area
            worksheet["A2"].Text = cTitle;

            // set a row height of 18 points for each row in the range
            titleRange.RowHeightInPoints = 18;
            // set the worksheet top title style
            titleRange.Style = styleTitulo;

            #endregion

            worksheet["A5:X5"].Style = styleHeader;
            worksheet["A5:X5"].RowHeightInPoints = 20;
            worksheet[sRangeTotal].Style = styleRows;
            // lock the data table header
            worksheet["A6"].FreezePanes();
            worksheet["A6"].FormulaR1C1 = "=+ROW(RC)-5";

            var firstCell = worksheet["A6"];
            var sRangeFilas = worksheet[sRangeA];
            firstCell.Copy(sRangeFilas);

            worksheet[sRangeD].Style.Number.NumberFormatString = "dd/mm/yy";
            worksheet[sRangeSumaTotal].Style.Number.NumberFormatString = "0.00";

            // autofit column width

            worksheet.AutofitColumns();

            worksheet.SetColumnWidthInChars(15, 20); //20 caracteres por defecto Masinfo
            worksheet.DeleteColumn(25); //Eliminar ultima columna
            worksheet.PageSetup.FitToPagesWide = 1;


            
            worksheet[sCeldaTotal].Formula = string.Format("SUM({0})", sRangeSumaTotal);
            worksheet[sCeldaTotal].Style = styleformulaTotal;
            
            // SAVE THE WORKBOOK

            // the workbook is saved in Excel 2007 (.xlsx) format 
            // get the output file path
            var outFilePath = System.IO.Path.Combine(Application.StartupPath, "listados", "DetalleOrdenes_" + DateTime.Now.ToString("--ddMMyy_hhmmss") + ".xlsx");
            try
            {
                // save the workbook to output path
                workbook.Save(outFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                workbook.Close();
            }

            var dr = MessageBox.Show(@"Desea Ud. Abrir el archivo de excel en un visor externo?", @"Abrir Libro de Excel", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes)
                General.ShowMessage(
                    string.Format("Se creo un Archivo llamado {0}, dentro de la Carpeta listados", outFilePath),
                    "Aviso importante");
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(outFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
