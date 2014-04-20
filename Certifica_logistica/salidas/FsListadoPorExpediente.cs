using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.procesos;
using Certifica_logistica.modulos;
using Certifica_logistica.utiles;
using CrystalDecisions.CrystalReports.Engine;
using DaoLogistica.DAO;
using Winnovative.ExcelLib;


namespace Certifica_logistica.salidas
{
    public partial class FsListadoPorExpediente : Masterform
    {
        private DataSet _ds;
        public FsListadoPorExpediente()
        {
            InitializeComponent();
        }
        public override bool Master_GrabarFormulario()
        {
            var codbien = GetUnicaFilaActual();
            if (codbien <= 0) return false;
            var r = (DataRowView)gridView1.GetFocusedRow();
            var cTipoOrden= r[16].ToString();
            var tipoOrden = ENumTipoOrden.NINGUNO;
            switch (cTipoOrden)
            {
                case "TOGL-0001":
                    tipoOrden = ENumTipoOrden.SERVICIO;
                    break;
                case "TOGL-0002":
                    tipoOrden = ENumTipoOrden.VIATICOS;
                    break;
                case "TOGL-0003":
                    tipoOrden = ENumTipoOrden.MOVILIDAD;
                    break;
                case "TOGL-0004":
                    tipoOrden = ENumTipoOrden.PROPINAS;
                    break;
                case "TOGL-0005":
                    tipoOrden = ENumTipoOrden.CONVENIO;
                    break;
                case "TOGL-0006":
                    tipoOrden = ENumTipoOrden.COMPRA;
                    break;                    
            }
            var ofrmHome = _FrmPadre;
            var oFrm = new FpOrdenLogistica
            {
                MdiParent = ofrmHome,
                _TipoOrden = tipoOrden,
                Value = codbien.ToString(CultureInfo.InvariantCulture),
                _DerechoFormulario = {Grabar = true, Eliminar = true, Nuevo = true, Procesar = false},
                _FrmPadre = ofrmHome
            };
            oFrm.Show();
            return true;
        }
        public override bool Master_ImprimirFormulario(bool isPrevio, int nCopias, int desde, int hasta, string cImpresora)
        {
            const string cReporte = "ordenes.rpt";
            #region Verificar Datos suficientes para Imprimir
            if (dsTramite.RptOrdenes.Rows.Count<=0)
            {
                General.ShowMessage("No se encontró ninguna Orden registrada para poder Imprimir", "No Existen Datos", icon: MessageBoxIcon.Stop);
                return false;
            }
            #endregion

            var rpt = new ReportDocument();
            //var dsRpt = OrdenLogisticaDao.GetReporteByExpediente(Value);
            //_dsPrint = new PrinterOrden();
            //_dsPrint.Tables["Orden"].Load(ds.Tables[0].CreateDataReader());

            //rpt.ParameterFields[0].
            //rpt.SetParameterValue("@Expediente", Value);    
            rpt.Load(string.Format("{0}\\reportes\\{1}", Application.StartupPath, cReporte));
            rpt.SetDataSource((DataTable) dsTramite.RptOrdenes);
            rpt.SetParameterValue(0, Value);                
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
        private void FsListadoPorExpediente_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Value)) return;
            LblTitulo.Text = String.Format("{0} {1}", LblTitulo.Tag ,Value);
            _ds = OrdenLogisticaDao.GetReporteByExpediente(Value);
            dsTramite.Tables[name: "RptOrdenes"].Clear();
            dsTramite.Tables[name: "RptOrdenes"].Load(_ds.CreateDataReader());
        }
        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargaFila();
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            CargaFila();
        }
        private void CargaFila()
        {
            if (GetUnicaFilaActual() > 0)
                Master_GrabarFormulario();
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

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            //Averiguar numero de filas del DataSet
            if (dsTramite.RptOrdenes.Rows.Count <= 0)
            {
                General.ShowMessage("No se encontró ningún registro a Exportar");
                return;
            }
            var nTope = dsTramite.RptOrdenes.Rows.Count + 6;
            var sCelda = String.Concat("E", nTope.ToString(CultureInfo.InvariantCulture));
            var sRange = String.Concat("E6:E", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeA = String.Concat("A6:A", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeD = String.Concat("D6:D", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeE = String.Concat("E6:E", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeI = String.Concat("I6:I", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            var sRangeTotal = String.Concat("A6:P", (nTope - 1).ToString(CultureInfo.InvariantCulture));
            // create the workbook in the desired format with a single worksheet
            var workbook = new ExcelWorkbook(ExcelWorkbookFormat.Xlsx_2007);

            // get the first worksheet in the workbook
            var worksheet = workbook.Worksheets[0];

            // set the default worksheet name
            worksheet.Name = Value;
            worksheet[sRangeI].Style.Number.NumberFormatString = "@";

            // load data from DataTable into the worksheet
            worksheet.LoadDataTable(dsTramite.RptOrdenes, 5, 1, true);
            // customize the workbook

            // set the license key before saving the workbook
            workbook.LicenseKey = "RW51ZXZ0ZXVldGt1ZXZ0a3R3a3x8fHw=";

            // set workbook description properties
            workbook.DocumentProperties.Subject = "Listado de Ordenes del Expediente " + Value;
            workbook.DocumentProperties.Comments = "Información de OUL-UNSA";

            #region CREATE CUSTOM WORKBOOK STYLES

            #region Add a style used for the cells in the worksheet title area

            var titleStyle = workbook.Styles.AddStyle("WorksheetTitleStyle");
            // center the text in the title area
            titleStyle.Alignment.HorizontalAlignment = ExcelCellHorizontalAlignmentType.Left;
            titleStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            // set the title area borders
            titleStyle.Borders[ExcelCellBorderIndex.Bottom].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Top].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Left].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Right].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Medium;
                // set the gradient fill for the title area range with a custom color
                titleStyle.Fill.FillType = ExcelCellFillType.GradientFill;
                titleStyle.Fill.GradientFillOptions.Color1 = Color.FromArgb(255, 255, 204);
                titleStyle.Fill.GradientFillOptions.Color2 = Color.White;
            // set the title area font 
            titleStyle.Font.Size = 14;
            titleStyle.Font.Bold = true;
            titleStyle.Font.UnderlineType = ExcelCellUnderlineType.Single;

            #endregion

            #region Add a style used for the data table header

            var dataHeaderStyle = workbook.Styles.AddStyle("DataHeaderStyle");
            dataHeaderStyle.Font.Size = 10;
            dataHeaderStyle.Font.Bold = true;
            dataHeaderStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            dataHeaderStyle.Alignment.HorizontalAlignment = ExcelCellHorizontalAlignmentType.Left;
            dataHeaderStyle.Fill.FillType = ExcelCellFillType.SolidFill;
            dataHeaderStyle.Fill.SolidFillOptions.BackColor = Color.LightBlue;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;

            #endregion
            #region Add a style used for table Details

            var detailsRowsrStyle = workbook.Styles.AddStyle("DetailsRowStyle");
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;

            #endregion
            #region Add a style used for the formula results

            var formulaResultStyle = workbook.Styles.AddStyle("FormulaResultStyle");
            formulaResultStyle.Font.Size = 10;
            formulaResultStyle.Font.Bold = true;
            formulaResultStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            formulaResultStyle.Fill.FillType = ExcelCellFillType.SolidFill;
            formulaResultStyle.Fill.SolidFillOptions.BackColor = Color.FromArgb(204, 255, 204);
            formulaResultStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;

            #endregion
            #endregion

            #region WORKSHEET PAGE SETUP

            // set worksheet paper size and orientation, margins, header and footer
            worksheet.PageSetup.PaperSize = ExcelPagePaperSize.PaperA4;
            worksheet.PageSetup.Orientation = ExcelPageOrientation.Landscape;
            worksheet.PageSetup.LeftMargin = 0.5;
            worksheet.PageSetup.RightMargin = 0.5;
            worksheet.PageSetup.TopMargin = 1;
            worksheet.PageSetup.BottomMargin = 0.5;

            // add header and footer

            //display a logo image in the left part of the header
            var imagesPath = System.IO.Path.Combine(Application.StartupPath, @"images"); //..\..\Images"
            var logoImg = Image.FromFile(System.IO.Path.Combine(imagesPath, "logo.jpg"));
            worksheet.PageSetup.LeftHeaderFormat = "&G";
            worksheet.PageSetup.LeftHeaderPicture = logoImg;
            // display Fecha y hora in the right part of the header
            worksheet.PageSetup.RightHeaderFormat = "&D &T"; 

            // add worksheet header and footer
            // display the workbook file name in the left part of the footer
            worksheet.PageSetup.LeftFooterFormat = "&F";
            // display the page number in the center part of the footer
            worksheet.PageSetup.RightFooterFormat = "&P";

            #endregion

            #region WRITE THE WORKSHEET TOP TITLE

            // merge the cells in the range to create the title area 
            worksheet["A2:P3"].Merge();
            // gets the merged range containing the top left cell of the range
            var titleRange = worksheet["A2"].MergeArea;
            // set the text of title area
            worksheet["A2"].Text = "Relación de Ordenes de Servicio Giradas del Expediente Nº " + Value;

            // set a row height of 18 points for each row in the range
            titleRange.RowHeightInPoints = 18;
            // set the worksheet top title style
            titleRange.Style = titleStyle;

            #endregion

            

            worksheet["A5"].Value = "ITEM";
            worksheet["A5:P5"].Style = dataHeaderStyle;
            worksheet["A5:P5"].RowHeightInPoints = 20;
            worksheet[sRangeTotal].Style = detailsRowsrStyle;
            // lock the data table header
            worksheet["A6"].FreezePanes();
            worksheet["A6"].FormulaR1C1 = "=+ROW(RC)-5";
            
            var firstCell = worksheet["A6"];
            var sRangeFilas = worksheet[sRangeA];
            firstCell.Copy(sRangeFilas);
            
            worksheet[sRangeD].Style.Number.NumberFormatString = "dd/mm/yy";
            worksheet[sRangeE].Style.Number.NumberFormatString = "0.00";
            worksheet[sRangeI].Style.Number.NumberFormatString = "@";
            worksheet[sRangeI].Style.Alignment.HorizontalAlignment = ExcelCellHorizontalAlignmentType.Right;
            // autofit column width
            
            worksheet.AutofitColumns();
            worksheet.SetColumnWidthInChars(7, 8); //35 caracteres por defecto
            worksheet.SetColumnWidthInChars(11,20); //35 caracteres por defecto
            //worksheet.SetColumnVisibility(1, false); //Esconder pRIMERA Columna
            worksheet.DeleteColumn(17);
            //worksheet.SetColumnVisibility(17,false); //Esconder Ultima Columna
            //worksheet.AutofitColumn(3);
            //worksheet.AutofitColumn(7);
            worksheet.PageSetup.FitToPagesWide = 1;


            
            worksheet[sCelda].Formula = string.Format("SUM({0})",sRange);
            worksheet[sCelda].Style = formulaResultStyle;
            
            // SAVE THE WORKBOOK

            // the workbook is saved in Excel 2007 (.xlsx) format 
            // get the output file path
            var outFilePath = System.IO.Path.Combine(Application.StartupPath, "listados","Ordenes_Exp_" + Value+DateTime.Now.ToString("--ddMMyy_hhmmss") +".xlsx");
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
                    // close the workbook and release the allocated resources
                    workbook.Close();
                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    if (logoImg != null)
                        logoImg.Dispose();
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

        private void FsListadoPorExpediente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F6)
                BtnExportar_Click(sender,null);
        }

    }
}
