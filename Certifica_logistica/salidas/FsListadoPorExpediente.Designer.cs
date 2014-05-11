namespace Certifica_logistica.salidas
{
    partial class FsListadoPorExpediente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FsListadoPorExpediente));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rptOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTramite = new Certifica_logistica.Ds.DsTramite();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDORDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIPOORDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNROORDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFUENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIPOUSUARIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRAZONCABECERA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFERENCIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHECHOPOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESOLUCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROCESO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODTIPOORDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchTipoUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchIdMeta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptOrdenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchTipoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchIdMeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.orden_48;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(301, 27);
            this.LblTitulo.Tag = "Ordenes por Expediente Nº:";
            this.LblTitulo.Text = "Ordenes por Expediente Nº:";
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.BtnExportar);
            this.pan1.Size = new System.Drawing.Size(844, 43);
            this.pan1.Controls.SetChildIndex(this.LblTitulo, 0);
            this.pan1.Controls.SetChildIndex(this.pic1, 0);
            this.pan1.Controls.SetChildIndex(this.BtnExportar, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.rptOrdenesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchTipoUsuario,
            this.repositoryItemSearchIdMeta});
            this.gridControl1.Size = new System.Drawing.Size(844, 404);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // rptOrdenesBindingSource
            // 
            this.rptOrdenesBindingSource.DataMember = "RptOrdenes";
            this.rptOrdenesBindingSource.DataSource = this.dsTramite;
            // 
            // dsTramite
            // 
            this.dsTramite.DataSetName = "DsTramite";
            this.dsTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDORDEN,
            this.colTIPOORDEN,
            this.colNROORDEN,
            this.colFECHA,
            this.colTOTAL,
            this.colFUENTE,
            this.colTIPOUSUARIO,
            this.colRAZONCABECERA,
            this.colCODIGO,
            this.colREFERENCIA,
            this.colDESCRIPCION,
            this.colHECHOPOR,
            this.colCCP,
            this.colRESOLUCION,
            this.colPROCESO,
            this.colESTADO,
            this.colCODTIPOORDEN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", this.colRAZONCABECERA, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // colIDORDEN
            // 
            this.colIDORDEN.FieldName = "IDORDEN";
            this.colIDORDEN.Name = "colIDORDEN";
            // 
            // colTIPOORDEN
            // 
            this.colTIPOORDEN.FieldName = "TIPOORDEN";
            this.colTIPOORDEN.Name = "colTIPOORDEN";
            this.colTIPOORDEN.Visible = true;
            this.colTIPOORDEN.VisibleIndex = 9;
            this.colTIPOORDEN.Width = 72;
            // 
            // colNROORDEN
            // 
            this.colNROORDEN.FieldName = "NROORDEN";
            this.colNROORDEN.Name = "colNROORDEN";
            this.colNROORDEN.Visible = true;
            this.colNROORDEN.VisibleIndex = 0;
            this.colNROORDEN.Width = 63;
            // 
            // colFECHA
            // 
            this.colFECHA.FieldName = "FECHA";
            this.colFECHA.Name = "colFECHA";
            this.colFECHA.Visible = true;
            this.colFECHA.VisibleIndex = 1;
            this.colFECHA.Width = 63;
            // 
            // colTOTAL
            // 
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 2;
            this.colTOTAL.Width = 51;
            // 
            // colFUENTE
            // 
            this.colFUENTE.FieldName = "FUENTE";
            this.colFUENTE.Name = "colFUENTE";
            this.colFUENTE.Visible = true;
            this.colFUENTE.VisibleIndex = 3;
            this.colFUENTE.Width = 51;
            // 
            // colTIPOUSUARIO
            // 
            this.colTIPOUSUARIO.FieldName = "TIPOUSUARIO";
            this.colTIPOUSUARIO.Name = "colTIPOUSUARIO";
            this.colTIPOUSUARIO.Visible = true;
            this.colTIPOUSUARIO.VisibleIndex = 4;
            this.colTIPOUSUARIO.Width = 78;
            // 
            // colRAZONCABECERA
            // 
            this.colRAZONCABECERA.FieldName = "RAZONCABECERA";
            this.colRAZONCABECERA.Name = "colRAZONCABECERA";
            this.colRAZONCABECERA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTAL", "Total S/. {0}")});
            this.colRAZONCABECERA.Visible = true;
            this.colRAZONCABECERA.VisibleIndex = 5;
            this.colRAZONCABECERA.Width = 176;
            // 
            // colCODIGO
            // 
            this.colCODIGO.FieldName = "CODIGO";
            this.colCODIGO.Name = "colCODIGO";
            this.colCODIGO.Visible = true;
            this.colCODIGO.VisibleIndex = 6;
            this.colCODIGO.Width = 47;
            // 
            // colREFERENCIA
            // 
            this.colREFERENCIA.FieldName = "REFERENCIA";
            this.colREFERENCIA.Name = "colREFERENCIA";
            this.colREFERENCIA.Visible = true;
            this.colREFERENCIA.VisibleIndex = 7;
            this.colREFERENCIA.Width = 118;
            // 
            // colDESCRIPCION
            // 
            this.colDESCRIPCION.FieldName = "DESCRIPCION";
            this.colDESCRIPCION.Name = "colDESCRIPCION";
            this.colDESCRIPCION.Width = 50;
            // 
            // colHECHOPOR
            // 
            this.colHECHOPOR.FieldName = "HECHOPOR";
            this.colHECHOPOR.Name = "colHECHOPOR";
            this.colHECHOPOR.Visible = true;
            this.colHECHOPOR.VisibleIndex = 8;
            this.colHECHOPOR.Width = 66;
            // 
            // colCCP
            // 
            this.colCCP.FieldName = "CCP";
            this.colCCP.Name = "colCCP";
            this.colCCP.Width = 37;
            // 
            // colRESOLUCION
            // 
            this.colRESOLUCION.FieldName = "RESOLUCION";
            this.colRESOLUCION.Name = "colRESOLUCION";
            this.colRESOLUCION.Width = 37;
            // 
            // colPROCESO
            // 
            this.colPROCESO.FieldName = "PROCESO";
            this.colPROCESO.Name = "colPROCESO";
            this.colPROCESO.Width = 54;
            // 
            // colESTADO
            // 
            this.colESTADO.FieldName = "ESTADO";
            this.colESTADO.Name = "colESTADO";
            this.colESTADO.Visible = true;
            this.colESTADO.VisibleIndex = 10;
            this.colESTADO.Width = 42;
            // 
            // colCODTIPOORDEN
            // 
            this.colCODTIPOORDEN.FieldName = "CODTIPOORDEN";
            this.colCODTIPOORDEN.Name = "colCODTIPOORDEN";
            // 
            // repositoryItemSearchTipoUsuario
            // 
            this.repositoryItemSearchTipoUsuario.AutoHeight = false;
            this.repositoryItemSearchTipoUsuario.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchTipoUsuario.Name = "repositoryItemSearchTipoUsuario";
            this.repositoryItemSearchTipoUsuario.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSearchIdMeta
            // 
            this.repositoryItemSearchIdMeta.AutoHeight = false;
            this.repositoryItemSearchIdMeta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchIdMeta.Name = "repositoryItemSearchIdMeta";
            this.repositoryItemSearchIdMeta.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // BtnExportar
            // 
            this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportar.Location = new System.Drawing.Point(766, 12);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(75, 25);
            this.BtnExportar.TabIndex = 2;
            this.BtnExportar.Text = "Exportar";
            this.toolTipController1.SetToolTip(this.BtnExportar, "F6 Exportación Completa a Excel");
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Visible = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // FsListadoPorExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(844, 447);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FsListadoPorExpediente";
            this.Tag = "Ordenes por Expediente Nº:";
            this.Text = "Listado de Ordenes por Expediente";
            this.Load += new System.EventHandler(this.FsListadoPorExpediente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FsListadoPorExpediente_KeyDown);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptOrdenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchTipoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchIdMeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchIdMeta;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchTipoUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private System.Windows.Forms.BindingSource rptOrdenesBindingSource;
        private Ds.DsTramite dsTramite;
        private DevExpress.XtraGrid.Columns.GridColumn colNROORDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colFUENTE;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPOUSUARIO;
        private DevExpress.XtraGrid.Columns.GridColumn colRAZONCABECERA;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFERENCIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPCION;
        private DevExpress.XtraGrid.Columns.GridColumn colHECHOPOR;
        private DevExpress.XtraGrid.Columns.GridColumn colTIPOORDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCCP;
        private DevExpress.XtraGrid.Columns.GridColumn colRESOLUCION;
        private DevExpress.XtraGrid.Columns.GridColumn colPROCESO;
        private DevExpress.XtraGrid.Columns.GridColumn colESTADO;
        private DevExpress.XtraGrid.Columns.GridColumn colIDORDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colCODTIPOORDEN;
        private System.Windows.Forms.Button BtnExportar;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
