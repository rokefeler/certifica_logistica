namespace Certifica_logistica.procesos
{
    partial class FpTramite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FpTramite));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LstObsv = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnObsv = new System.Windows.Forms.Button();
            this.TxtObsv = new System.Windows.Forms.TextBox();
            this.GrpOrigen_Remite = new System.Windows.Forms.GroupBox();
            this.EdCodSubDep_Recibe = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtSubDependencia_Recibe = new System.Windows.Forms.TextBox();
            this.TxtDependencia_Recibe = new System.Windows.Forms.TextBox();
            this.GrpDocumento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFolios = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GrpSubDependencia = new System.Windows.Forms.GroupBox();
            this.EdCodSubDep = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtSubDependencia = new System.Windows.Forms.TextBox();
            this.TxtDependencia = new System.Windows.Forms.TextBox();
            this.GrpAprobacion = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboFuente = new System.Windows.Forms.ComboBox();
            this.CboMoneda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtNroAutorizacion = new System.Windows.Forms.TextBox();
            this.TxtMontoAprobado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboYearExp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EdIdExpediente = new DevExpress.XtraEditors.ButtonEdit();
            this.DtFechaIngresoExp = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtFechaExp = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TxtnLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstObsv)).BeginInit();
            this.GrpOrigen_Remite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep_Recibe.Properties)).BeginInit();
            this.GrpDocumento.SuspendLayout();
            this.GrpSubDependencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).BeginInit();
            this.GrpAprobacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdExpediente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaIngresoExp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaIngresoExp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.inbox_icon_32;
            this.pic1.Size = new System.Drawing.Size(43, 43);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(386, 27);
            this.LblTitulo.Text = "Registro y Consulta de Expedientes";
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.TxtnLog);
            this.pan1.Size = new System.Drawing.Size(660, 46);
            this.pan1.Controls.SetChildIndex(this.LblTitulo, 0);
            this.pan1.Controls.SetChildIndex(this.pic1, 0);
            this.pan1.Controls.SetChildIndex(this.TxtnLog, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnLimpiar);
            this.splitContainer1.Panel1.Controls.Add(this.LstObsv);
            this.splitContainer1.Panel1.Controls.Add(this.BtnObsv);
            this.splitContainer1.Panel1.Controls.Add(this.TxtObsv);
            this.splitContainer1.Panel1.Controls.Add(this.GrpOrigen_Remite);
            this.splitContainer1.Panel1.Controls.Add(this.GrpDocumento);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.GrpSubDependencia);
            this.splitContainer1.Panel1.Controls.Add(this.GrpAprobacion);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(660, 442);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 1;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(575, 228);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(60, 33);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LstObsv
            // 
            this.LstObsv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.LstObsv.ColumnWidth = 90;
            this.LstObsv.Location = new System.Drawing.Point(3, 223);
            this.LstObsv.Name = "LstObsv";
            this.LstObsv.Size = new System.Drawing.Size(95, 74);
            this.LstObsv.TabIndex = 10;
            this.LstObsv.SelectedIndexChanged += new System.EventHandler(this.LstObsv_SelectedIndexChanged);
            this.LstObsv.DoubleClick += new System.EventHandler(this.LstObsv_DoubleClick);
            this.LstObsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstObsv_KeyDown);
            // 
            // BtnObsv
            // 
            this.BtnObsv.Enabled = false;
            this.BtnObsv.Location = new System.Drawing.Point(575, 261);
            this.BtnObsv.Name = "BtnObsv";
            this.BtnObsv.Size = new System.Drawing.Size(60, 36);
            this.BtnObsv.TabIndex = 9;
            this.BtnObsv.Text = "Agregar";
            this.BtnObsv.UseVisualStyleBackColor = true;
            this.BtnObsv.Click += new System.EventHandler(this.BtnObsv_Click);
            // 
            // TxtObsv
            // 
            this.TxtObsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtObsv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObsv.Location = new System.Drawing.Point(104, 241);
            this.TxtObsv.MaxLength = 256;
            this.TxtObsv.Multiline = true;
            this.TxtObsv.Name = "TxtObsv";
            this.TxtObsv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtObsv.Size = new System.Drawing.Size(469, 56);
            this.TxtObsv.TabIndex = 8;
            // 
            // GrpOrigen_Remite
            // 
            this.GrpOrigen_Remite.Controls.Add(this.EdCodSubDep_Recibe);
            this.GrpOrigen_Remite.Controls.Add(this.TxtSubDependencia_Recibe);
            this.GrpOrigen_Remite.Controls.Add(this.TxtDependencia_Recibe);
            this.GrpOrigen_Remite.Location = new System.Drawing.Point(3, 179);
            this.GrpOrigen_Remite.Name = "GrpOrigen_Remite";
            this.GrpOrigen_Remite.Size = new System.Drawing.Size(653, 43);
            this.GrpOrigen_Remite.TabIndex = 4;
            this.GrpOrigen_Remite.TabStop = false;
            this.GrpOrigen_Remite.Text = "Datos de SubDependencia que remite el Documento";
            // 
            // EdCodSubDep_Recibe
            // 
            this.EdCodSubDep_Recibe.EditValue = "NCS";
            this.EdCodSubDep_Recibe.EnterMoveNextControl = true;
            this.EdCodSubDep_Recibe.Location = new System.Drawing.Point(5, 18);
            this.EdCodSubDep_Recibe.Name = "EdCodSubDep_Recibe";
            this.EdCodSubDep_Recibe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodSubDep_Recibe.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodSubDep_Recibe.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodSubDep_Recibe.Properties.Mask.BeepOnError = true;
            this.EdCodSubDep_Recibe.Properties.Mask.EditMask = "LCCl";
            this.EdCodSubDep_Recibe.Properties.Mask.SaveLiteral = false;
            this.EdCodSubDep_Recibe.Properties.MaxLength = 15;
            this.EdCodSubDep_Recibe.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdCodSubDep_Properties_ButtonClick);
            this.EdCodSubDep_Recibe.Size = new System.Drawing.Size(65, 20);
            this.EdCodSubDep_Recibe.TabIndex = 0;
            this.EdCodSubDep_Recibe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EdCodSubDep_KeyDown);
            this.EdCodSubDep_Recibe.Leave += new System.EventHandler(this.EdCodSubDep_Leave);
            // 
            // TxtSubDependencia_Recibe
            // 
            this.TxtSubDependencia_Recibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubDependencia_Recibe.Location = new System.Drawing.Point(79, 18);
            this.TxtSubDependencia_Recibe.Name = "TxtSubDependencia_Recibe";
            this.TxtSubDependencia_Recibe.ReadOnly = true;
            this.TxtSubDependencia_Recibe.Size = new System.Drawing.Size(298, 20);
            this.TxtSubDependencia_Recibe.TabIndex = 1;
            this.TxtSubDependencia_Recibe.TabStop = false;
            // 
            // TxtDependencia_Recibe
            // 
            this.TxtDependencia_Recibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDependencia_Recibe.Location = new System.Drawing.Point(383, 18);
            this.TxtDependencia_Recibe.Name = "TxtDependencia_Recibe";
            this.TxtDependencia_Recibe.ReadOnly = true;
            this.TxtDependencia_Recibe.Size = new System.Drawing.Size(264, 20);
            this.TxtDependencia_Recibe.TabIndex = 2;
            this.TxtDependencia_Recibe.TabStop = false;
            // 
            // GrpDocumento
            // 
            this.GrpDocumento.Controls.Add(this.label4);
            this.GrpDocumento.Controls.Add(this.TxtNroDoc);
            this.GrpDocumento.Controls.Add(this.CboTipoDoc);
            this.GrpDocumento.Controls.Add(this.label6);
            this.GrpDocumento.Controls.Add(this.TxtAsunto);
            this.GrpDocumento.Controls.Add(this.label11);
            this.GrpDocumento.Controls.Add(this.TxtFolios);
            this.GrpDocumento.Controls.Add(this.label12);
            this.GrpDocumento.Location = new System.Drawing.Point(3, 115);
            this.GrpDocumento.Name = "GrpDocumento";
            this.GrpDocumento.Size = new System.Drawing.Size(653, 61);
            this.GrpDocumento.TabIndex = 3;
            this.GrpDocumento.TabStop = false;
            this.GrpDocumento.Text = "Datos del Documento Ingresado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Doc:";
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroDoc.Location = new System.Drawing.Point(131, 34);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(84, 20);
            this.TxtNroDoc.TabIndex = 3;
            this.TxtNroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Location = new System.Drawing.Point(5, 33);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.CboTipoDoc.TabIndex = 1;
            this.CboTipoDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nº de Documento";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAsunto.Location = new System.Drawing.Point(221, 34);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(375, 20);
            this.TxtAsunto.TabIndex = 5;
            this.TxtAsunto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Asunto o Referencia de Requerimiento";
            // 
            // TxtFolios
            // 
            this.TxtFolios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFolios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFolios.Location = new System.Drawing.Point(599, 34);
            this.TxtFolios.Name = "TxtFolios";
            this.TxtFolios.Size = new System.Drawing.Size(48, 20);
            this.TxtFolios.TabIndex = 7;
            this.TxtFolios.Text = "1";
            this.TxtFolios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(598, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Folios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Observaciones:";
            // 
            // GrpSubDependencia
            // 
            this.GrpSubDependencia.BackColor = System.Drawing.SystemColors.Info;
            this.GrpSubDependencia.Controls.Add(this.EdCodSubDep);
            this.GrpSubDependencia.Controls.Add(this.TxtSubDependencia);
            this.GrpSubDependencia.Controls.Add(this.TxtDependencia);
            this.GrpSubDependencia.Location = new System.Drawing.Point(3, 69);
            this.GrpSubDependencia.Name = "GrpSubDependencia";
            this.GrpSubDependencia.Size = new System.Drawing.Size(653, 43);
            this.GrpSubDependencia.TabIndex = 2;
            this.GrpSubDependencia.TabStop = false;
            this.GrpSubDependencia.Text = "Datos de SubDependencia o Centro de Costo Solicitante";
            // 
            // EdCodSubDep
            // 
            this.EdCodSubDep.EnterMoveNextControl = true;
            this.EdCodSubDep.Location = new System.Drawing.Point(5, 18);
            this.EdCodSubDep.Name = "EdCodSubDep";
            this.EdCodSubDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodSubDep.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodSubDep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodSubDep.Properties.Mask.BeepOnError = true;
            this.EdCodSubDep.Properties.Mask.EditMask = "LCCl";
            this.EdCodSubDep.Properties.Mask.SaveLiteral = false;
            this.EdCodSubDep.Properties.MaxLength = 15;
            this.EdCodSubDep.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdCodSubDep_Properties_ButtonClick);
            this.EdCodSubDep.Size = new System.Drawing.Size(65, 20);
            this.EdCodSubDep.TabIndex = 0;
            this.EdCodSubDep.Enter += new System.EventHandler(this.ObjectEnter);
            this.EdCodSubDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EdCodSubDep_KeyDown);
            this.EdCodSubDep.Leave += new System.EventHandler(this.EdCodSubDep_Leave);
            // 
            // TxtSubDependencia
            // 
            this.TxtSubDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubDependencia.Location = new System.Drawing.Point(79, 18);
            this.TxtSubDependencia.Name = "TxtSubDependencia";
            this.TxtSubDependencia.ReadOnly = true;
            this.TxtSubDependencia.Size = new System.Drawing.Size(298, 20);
            this.TxtSubDependencia.TabIndex = 1;
            this.TxtSubDependencia.TabStop = false;
            // 
            // TxtDependencia
            // 
            this.TxtDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDependencia.Location = new System.Drawing.Point(383, 18);
            this.TxtDependencia.Name = "TxtDependencia";
            this.TxtDependencia.ReadOnly = true;
            this.TxtDependencia.Size = new System.Drawing.Size(264, 20);
            this.TxtDependencia.TabIndex = 2;
            this.TxtDependencia.TabStop = false;
            // 
            // GrpAprobacion
            // 
            this.GrpAprobacion.Controls.Add(this.label17);
            this.GrpAprobacion.Controls.Add(this.label9);
            this.GrpAprobacion.Controls.Add(this.CboFuente);
            this.GrpAprobacion.Controls.Add(this.CboMoneda);
            this.GrpAprobacion.Controls.Add(this.label10);
            this.GrpAprobacion.Controls.Add(this.TxtNroAutorizacion);
            this.GrpAprobacion.Controls.Add(this.TxtMontoAprobado);
            this.GrpAprobacion.Location = new System.Drawing.Point(360, 1);
            this.GrpAprobacion.Name = "GrpAprobacion";
            this.GrpAprobacion.Size = new System.Drawing.Size(297, 66);
            this.GrpAprobacion.TabIndex = 1;
            this.GrpAprobacion.TabStop = false;
            this.GrpAprobacion.Text = "Aprobación Rectoral de Expediente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fuente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nro. Aut. Rectoral y Monto";
            // 
            // CboFuente
            // 
            this.CboFuente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboFuente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboFuente.FormattingEnabled = true;
            this.CboFuente.Location = new System.Drawing.Point(6, 36);
            this.CboFuente.Name = "CboFuente";
            this.CboFuente.Size = new System.Drawing.Size(79, 21);
            this.CboFuente.TabIndex = 1;
            this.CboFuente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // CboMoneda
            // 
            this.CboMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboMoneda.FormattingEnabled = true;
            this.CboMoneda.Items.AddRange(new object[] {
            "SOLES",
            "DOLARES",
            "EUROS",
            "OTRO"});
            this.CboMoneda.Location = new System.Drawing.Point(92, 36);
            this.CboMoneda.Name = "CboMoneda";
            this.CboMoneda.Size = new System.Drawing.Size(76, 21);
            this.CboMoneda.TabIndex = 3;
            this.CboMoneda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Moneda";
            // 
            // TxtNroAutorizacion
            // 
            this.TxtNroAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroAutorizacion.Location = new System.Drawing.Point(174, 37);
            this.TxtNroAutorizacion.MaxLength = 70;
            this.TxtNroAutorizacion.Name = "TxtNroAutorizacion";
            this.TxtNroAutorizacion.Size = new System.Drawing.Size(49, 20);
            this.TxtNroAutorizacion.TabIndex = 5;
            this.TxtNroAutorizacion.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtNroAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // TxtMontoAprobado
            // 
            this.TxtMontoAprobado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMontoAprobado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMontoAprobado.Location = new System.Drawing.Point(227, 37);
            this.TxtMontoAprobado.MaxLength = 35;
            this.TxtMontoAprobado.Name = "TxtMontoAprobado";
            this.TxtMontoAprobado.Size = new System.Drawing.Size(63, 20);
            this.TxtMontoAprobado.TabIndex = 6;
            this.TxtMontoAprobado.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtMontoAprobado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboYearExp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EdIdExpediente);
            this.groupBox2.Controls.Add(this.DtFechaIngresoExp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DtFechaExp);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 66);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expediente Formato Ej: 1024-2014";
            // 
            // CboYearExp
            // 
            this.CboYearExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboYearExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYearExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboYearExp.FormattingEnabled = true;
            this.CboYearExp.Location = new System.Drawing.Point(80, 36);
            this.CboYearExp.Name = "CboYearExp";
            this.CboYearExp.Size = new System.Drawing.Size(61, 21);
            this.CboYearExp.TabIndex = 3;
            this.CboYearExp.SelectedIndexChanged += new System.EventHandler(this.CboYearExp_SelectedIndexChanged);
            this.CboYearExp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº &Exp.:";
            // 
            // EdIdExpediente
            // 
            this.EdIdExpediente.EnterMoveNextControl = true;
            this.EdIdExpediente.Location = new System.Drawing.Point(4, 37);
            this.EdIdExpediente.Name = "EdIdExpediente";
            this.EdIdExpediente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdExpediente.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdExpediente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdExpediente.Properties.Mask.BeepOnError = true;
            this.EdIdExpediente.Properties.Mask.EditMask = "A99999";
            this.EdIdExpediente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdIdExpediente.Properties.MaxLength = 15;
            this.EdIdExpediente.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdIdExpediente_Properties_ButtonClick);
            this.EdIdExpediente.Size = new System.Drawing.Size(67, 20);
            this.EdIdExpediente.TabIndex = 1;
            this.EdIdExpediente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EdIdExpediente_KeyDown);
            this.EdIdExpediente.Leave += new System.EventHandler(this.EdIdExpediente_Leave);
            // 
            // DtFechaIngresoExp
            // 
            this.DtFechaIngresoExp.EditValue = null;
            this.DtFechaIngresoExp.EnterMoveNextControl = true;
            this.DtFechaIngresoExp.Location = new System.Drawing.Point(253, 37);
            this.DtFechaIngresoExp.Name = "DtFechaIngresoExp";
            this.DtFechaIngresoExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaIngresoExp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaIngresoExp.Properties.Mask.BeepOnError = true;
            this.DtFechaIngresoExp.Size = new System.Drawing.Size(86, 20);
            this.DtFechaIngresoExp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Exp.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Ingreso:";
            // 
            // DtFechaExp
            // 
            this.DtFechaExp.EditValue = null;
            this.DtFechaExp.EnterMoveNextControl = true;
            this.DtFechaExp.Location = new System.Drawing.Point(158, 37);
            this.DtFechaExp.Name = "DtFechaExp";
            this.DtFechaExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaExp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaExp.Properties.Mask.BeepOnError = true;
            this.DtFechaExp.Size = new System.Drawing.Size(86, 20);
            this.DtFechaExp.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(660, 139);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // toolTipController1
            // 
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // TxtnLog
            // 
            this.TxtnLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.TxtnLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtnLog.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtnLog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxtnLog.Location = new System.Drawing.Point(499, 12);
            this.TxtnLog.Name = "TxtnLog";
            this.TxtnLog.Size = new System.Drawing.Size(100, 20);
            this.TxtnLog.TabIndex = 2;
            this.TxtnLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FpTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(660, 488);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FpTramite";
            this.Tag = "Trámite Documentario - ";
            this.Text = "";
            this.Load += new System.EventHandler(this.FpTramite_Load);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LstObsv)).EndInit();
            this.GrpOrigen_Remite.ResumeLayout(false);
            this.GrpOrigen_Remite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep_Recibe.Properties)).EndInit();
            this.GrpDocumento.ResumeLayout(false);
            this.GrpDocumento.PerformLayout();
            this.GrpSubDependencia.ResumeLayout(false);
            this.GrpSubDependencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).EndInit();
            this.GrpAprobacion.ResumeLayout(false);
            this.GrpAprobacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdExpediente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaIngresoExp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaIngresoExp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboMoneda;
        private System.Windows.Forms.TextBox TxtMontoAprobado;
        private System.Windows.Forms.TextBox TxtNroAutorizacion;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit EdIdExpediente;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit DtFechaExp;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit DtFechaIngresoExp;
        private DevExpress.XtraEditors.ButtonEdit EdCodSubDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.TextBox TxtDependencia;
        private System.Windows.Forms.TextBox TxtSubDependencia;
        private System.Windows.Forms.GroupBox GrpAprobacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtFolios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GrpSubDependencia;
        private System.Windows.Forms.ComboBox CboYearExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CboTipoDoc;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.GroupBox GrpOrigen_Remite;
        private DevExpress.XtraEditors.ButtonEdit EdCodSubDep_Recibe;
        private System.Windows.Forms.TextBox TxtSubDependencia_Recibe;
        private System.Windows.Forms.TextBox TxtDependencia_Recibe;
        private System.Windows.Forms.GroupBox GrpDocumento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CboFuente;
        private System.Windows.Forms.TextBox TxtObsv;
        private System.Windows.Forms.Button BtnObsv;
        private DevExpress.XtraEditors.ListBoxControl LstObsv;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox TxtnLog;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}
