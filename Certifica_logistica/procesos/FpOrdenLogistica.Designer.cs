﻿using Certifica_logistica.Ds;

namespace Certifica_logistica.procesos
{
    partial class FpOrdenLogistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FpOrdenLogistica));
            this.BtnCargaOrden = new System.Windows.Forms.Button();
            this.EdIdOrden = new DevExpress.XtraEditors.ButtonEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.LblRd = new System.Windows.Forms.Label();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.BtnClonar = new System.Windows.Forms.Button();
            this.TxtRd = new DevExpress.XtraEditors.TextEdit();
            this.memoDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.GrpTramite = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtFechaGiro = new DevExpress.XtraEditors.DateEdit();
            this.TxtNroProceso = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReferencia = new DevExpress.XtraEditors.TextEdit();
            this.TxtCcp = new DevExpress.XtraEditors.TextEdit();
            this.TxtSiaf = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.CboTipoProceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCarga = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DtFechaExp = new DevExpress.XtraEditors.DateEdit();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSubDependencia = new System.Windows.Forms.TextBox();
            this.GrpAprobacion = new System.Windows.Forms.GroupBox();
            this.TxtMontoAprobado = new DevExpress.XtraEditors.TextEdit();
            this.TxtNroAutorizacion = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CboFuente = new System.Windows.Forms.ComboBox();
            this.CboMoneda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboYearExp = new System.Windows.Forms.ComboBox();
            this.EdIdExpediente = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.GrpDocumento = new System.Windows.Forms.GroupBox();
            this.CboTipoUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtDirec = new System.Windows.Forms.TextBox();
            this.LblDirec = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblRuc = new System.Windows.Forms.Label();
            this.TxtRazon = new System.Windows.Forms.TextBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.EdCodigo = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.LblRazon = new System.Windows.Forms.Label();
            this.PicAnulado = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importarcionGenericaDeDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTramite = new Certifica_logistica.Ds.DsTramite();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClasificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchIdMeta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchTipoUsuario = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclasificador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CboYearOrden = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).BeginInit();
            this.GrpTramite.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaGiro.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaGiro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReferencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCcp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiaf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties)).BeginInit();
            this.GrpAprobacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoAprobado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroAutorizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdExpediente.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GrpDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnulado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchIdMeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchTipoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.order_64;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(383, 27);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "ORDEN DE SERVICIO y/o TRABAJO:";
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.CboYearOrden);
            this.pan1.Controls.Add(this.EdIdOrden);
            this.pan1.Controls.Add(this.BtnCargaOrden);
            this.pan1.Size = new System.Drawing.Size(698, 43);
            this.pan1.Controls.SetChildIndex(this.LblTitulo, 0);
            this.pan1.Controls.SetChildIndex(this.pic1, 0);
            this.pan1.Controls.SetChildIndex(this.BtnCargaOrden, 0);
            this.pan1.Controls.SetChildIndex(this.EdIdOrden, 0);
            this.pan1.Controls.SetChildIndex(this.CboYearOrden, 0);
            // 
            // BtnCargaOrden
            // 
            this.BtnCargaOrden.BackColor = System.Drawing.Color.Gold;
            this.BtnCargaOrden.Location = new System.Drawing.Point(646, 10);
            this.BtnCargaOrden.Name = "BtnCargaOrden";
            this.BtnCargaOrden.Size = new System.Drawing.Size(51, 23);
            this.BtnCargaOrden.TabIndex = 2;
            this.BtnCargaOrden.Text = "Carga";
            this.BtnCargaOrden.UseVisualStyleBackColor = false;
            this.BtnCargaOrden.Click += new System.EventHandler(this.BtnCargaOrden_Click);
            // 
            // EdIdOrden
            // 
            this.EdIdOrden.EnterMoveNextControl = true;
            this.EdIdOrden.Location = new System.Drawing.Point(521, 11);
            this.EdIdOrden.Name = "EdIdOrden";
            this.EdIdOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdOrden.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdOrden.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdOrden.Properties.Mask.BeepOnError = true;
            this.EdIdOrden.Properties.Mask.EditMask = "99999999";
            this.EdIdOrden.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdIdOrden.Properties.MaxLength = 15;
            this.EdIdOrden.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdIdOrden_Properties_ButtonClick);
            this.EdIdOrden.Size = new System.Drawing.Size(61, 20);
            this.EdIdOrden.TabIndex = 1;
            // 
            // LblRd
            // 
            this.LblRd.AutoSize = true;
            this.LblRd.Location = new System.Drawing.Point(440, 232);
            this.LblRd.Name = "LblRd";
            this.LblRd.Size = new System.Drawing.Size(47, 13);
            this.LblRd.TabIndex = 3;
            this.LblRd.Text = "R.D. Nº.";
            this.toolTipController1.SetToolTip(this.LblRd, "Nº Resolución de RECONOCIMIENTO DE DEUDA");
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 43);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.BtnClonar);
            this.splitContainerControl1.Panel1.Controls.Add(this.TxtRd);
            this.splitContainerControl1.Panel1.Controls.Add(this.LblRd);
            this.splitContainerControl1.Panel1.Controls.Add(this.memoDescripcion);
            this.splitContainerControl1.Panel1.Controls.Add(this.GrpTramite);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Controls.Add(this.GrpDocumento);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.PicAnulado);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(698, 482);
            this.splitContainerControl1.SplitterPosition = 307;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // BtnClonar
            // 
            this.BtnClonar.Location = new System.Drawing.Point(440, 265);
            this.BtnClonar.Name = "BtnClonar";
            this.BtnClonar.Size = new System.Drawing.Size(75, 37);
            this.BtnClonar.TabIndex = 6;
            this.BtnClonar.Text = "Clonar Orden";
            this.BtnClonar.UseVisualStyleBackColor = true;
            this.BtnClonar.Visible = false;
            this.BtnClonar.Click += new System.EventHandler(this.BtnClonar_Click);
            // 
            // TxtRd
            // 
            this.TxtRd.EnterMoveNextControl = true;
            this.TxtRd.Location = new System.Drawing.Point(495, 227);
            this.TxtRd.Name = "TxtRd";
            this.TxtRd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtRd.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRd.Properties.MaxLength = 45;
            this.TxtRd.Size = new System.Drawing.Size(198, 22);
            this.TxtRd.TabIndex = 4;
            // 
            // memoDescripcion
            // 
            this.memoDescripcion.Location = new System.Drawing.Point(4, 227);
            this.memoDescripcion.Name = "memoDescripcion";
            this.memoDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.memoDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.memoDescripcion.Size = new System.Drawing.Size(430, 75);
            this.memoDescripcion.TabIndex = 2;
            this.memoDescripcion.ToolTip = "Descripción detallada de Orden de Servicio";
            this.memoDescripcion.UseOptimizedRendering = true;
            // 
            // GrpTramite
            // 
            this.GrpTramite.Controls.Add(this.groupBox2);
            this.GrpTramite.Controls.Add(this.TxtNroProceso);
            this.GrpTramite.Controls.Add(this.label1);
            this.GrpTramite.Controls.Add(this.TxtReferencia);
            this.GrpTramite.Controls.Add(this.TxtCcp);
            this.GrpTramite.Controls.Add(this.TxtSiaf);
            this.GrpTramite.Controls.Add(this.label15);
            this.GrpTramite.Controls.Add(this.CboTipoProceso);
            this.GrpTramite.Controls.Add(this.label5);
            this.GrpTramite.Controls.Add(this.label19);
            this.GrpTramite.Controls.Add(this.label6);
            this.GrpTramite.Controls.Add(this.BtnCarga);
            this.GrpTramite.Controls.Add(this.label18);
            this.GrpTramite.Controls.Add(this.label14);
            this.GrpTramite.Controls.Add(this.DtFechaExp);
            this.GrpTramite.Controls.Add(this.TxtDocumento);
            this.GrpTramite.Controls.Add(this.label8);
            this.GrpTramite.Controls.Add(this.TxtSubDependencia);
            this.GrpTramite.Controls.Add(this.GrpAprobacion);
            this.GrpTramite.Controls.Add(this.label7);
            this.GrpTramite.Controls.Add(this.label3);
            this.GrpTramite.Controls.Add(this.CboYearExp);
            this.GrpTramite.Controls.Add(this.EdIdExpediente);
            this.GrpTramite.Location = new System.Drawing.Point(1, 1);
            this.GrpTramite.Name = "GrpTramite";
            this.GrpTramite.Size = new System.Drawing.Size(694, 159);
            this.GrpTramite.TabIndex = 0;
            this.GrpTramite.TabStop = false;
            this.GrpTramite.Text = "Ingrese Expediente Relacionado:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.DtFechaGiro);
            this.groupBox2.Location = new System.Drawing.Point(585, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "< Fecha Giro >";
            // 
            // DtFechaGiro
            // 
            this.DtFechaGiro.EditValue = null;
            this.DtFechaGiro.EnterMoveNextControl = true;
            this.DtFechaGiro.Location = new System.Drawing.Point(12, 29);
            this.DtFechaGiro.Name = "DtFechaGiro";
            this.DtFechaGiro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaGiro.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaGiro.Properties.Mask.BeepOnError = true;
            this.DtFechaGiro.Size = new System.Drawing.Size(86, 20);
            this.DtFechaGiro.TabIndex = 8;
            // 
            // TxtNroProceso
            // 
            this.TxtNroProceso.EnterMoveNextControl = true;
            this.TxtNroProceso.Location = new System.Drawing.Point(467, 131);
            this.TxtNroProceso.Name = "TxtNroProceso";
            this.TxtNroProceso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtNroProceso.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroProceso.Properties.MaxLength = 40;
            this.TxtNroProceso.Size = new System.Drawing.Size(112, 22);
            this.TxtNroProceso.TabIndex = 19;
            this.TxtNroProceso.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nro Proceso:";
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.EnterMoveNextControl = true;
            this.TxtReferencia.Location = new System.Drawing.Point(3, 133);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.TxtReferencia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtReferencia.Properties.MaxLength = 60;
            this.TxtReferencia.Size = new System.Drawing.Size(280, 20);
            this.TxtReferencia.TabIndex = 15;
            this.TxtReferencia.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // TxtCcp
            // 
            this.TxtCcp.EnterMoveNextControl = true;
            this.TxtCcp.Location = new System.Drawing.Point(640, 131);
            this.TxtCcp.Name = "TxtCcp";
            this.TxtCcp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtCcp.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCcp.Properties.MaxLength = 15;
            this.TxtCcp.Size = new System.Drawing.Size(50, 22);
            this.TxtCcp.TabIndex = 23;
            this.TxtCcp.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // TxtSiaf
            // 
            this.TxtSiaf.EnterMoveNextControl = true;
            this.TxtSiaf.Location = new System.Drawing.Point(582, 131);
            this.TxtSiaf.Name = "TxtSiaf";
            this.TxtSiaf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtSiaf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSiaf.Properties.MaxLength = 15;
            this.TxtSiaf.Size = new System.Drawing.Size(55, 22);
            this.TxtSiaf.TabIndex = 21;
            this.TxtSiaf.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "SIAF";
            // 
            // CboTipoProceso
            // 
            this.CboTipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTipoProceso.FormattingEnabled = true;
            this.CboTipoProceso.Location = new System.Drawing.Point(287, 132);
            this.CboTipoProceso.Name = "CboTipoProceso";
            this.CboTipoProceso.Size = new System.Drawing.Size(178, 21);
            this.CboTipoProceso.TabIndex = 17;
            this.CboTipoProceso.SelectedIndexChanged += new System.EventHandler(this.CboTipoProceso_SelectedIndexChanged);
            this.CboTipoProceso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo de Proceso:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(229, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Detalle/Referencia (Agregar Periodo del pago):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Documento Origen:";
            // 
            // BtnCarga
            // 
            this.BtnCarga.Location = new System.Drawing.Point(142, 38);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(51, 23);
            this.BtnCarga.TabIndex = 4;
            this.BtnCarga.Text = "Carga";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(196, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Fecha de Exp.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(640, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "C.C.P.";
            // 
            // DtFechaExp
            // 
            this.DtFechaExp.EditValue = null;
            this.DtFechaExp.Enabled = false;
            this.DtFechaExp.EnterMoveNextControl = true;
            this.DtFechaExp.Location = new System.Drawing.Point(199, 41);
            this.DtFechaExp.Name = "DtFechaExp";
            this.DtFechaExp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaExp.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaExp.Properties.Mask.BeepOnError = true;
            this.DtFechaExp.Properties.ReadOnly = true;
            this.DtFechaExp.Size = new System.Drawing.Size(86, 20);
            this.DtFechaExp.TabIndex = 6;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDocumento.Location = new System.Drawing.Point(395, 89);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.ReadOnly = true;
            this.TxtDocumento.Size = new System.Drawing.Size(294, 20);
            this.TxtDocumento.TabIndex = 13;
            this.TxtDocumento.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "SubDependencia - Centro de Costo:";
            // 
            // TxtSubDependencia
            // 
            this.TxtSubDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubDependencia.Location = new System.Drawing.Point(4, 89);
            this.TxtSubDependencia.Name = "TxtSubDependencia";
            this.TxtSubDependencia.ReadOnly = true;
            this.TxtSubDependencia.Size = new System.Drawing.Size(387, 20);
            this.TxtSubDependencia.TabIndex = 11;
            this.TxtSubDependencia.TabStop = false;
            // 
            // GrpAprobacion
            // 
            this.GrpAprobacion.Controls.Add(this.TxtMontoAprobado);
            this.GrpAprobacion.Controls.Add(this.TxtNroAutorizacion);
            this.GrpAprobacion.Controls.Add(this.label17);
            this.GrpAprobacion.Controls.Add(this.label9);
            this.GrpAprobacion.Controls.Add(this.CboFuente);
            this.GrpAprobacion.Controls.Add(this.CboMoneda);
            this.GrpAprobacion.Controls.Add(this.label10);
            this.GrpAprobacion.Location = new System.Drawing.Point(288, 6);
            this.GrpAprobacion.Name = "GrpAprobacion";
            this.GrpAprobacion.Size = new System.Drawing.Size(297, 66);
            this.GrpAprobacion.TabIndex = 9;
            this.GrpAprobacion.TabStop = false;
            this.GrpAprobacion.Text = "Aprobación Rectoral de Expediente";
            // 
            // TxtMontoAprobado
            // 
            this.TxtMontoAprobado.EnterMoveNextControl = true;
            this.TxtMontoAprobado.Location = new System.Drawing.Point(236, 34);
            this.TxtMontoAprobado.Name = "TxtMontoAprobado";
            this.TxtMontoAprobado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtMontoAprobado.Properties.ReadOnly = true;
            this.TxtMontoAprobado.Size = new System.Drawing.Size(55, 22);
            this.TxtMontoAprobado.TabIndex = 6;
            // 
            // TxtNroAutorizacion
            // 
            this.TxtNroAutorizacion.EnterMoveNextControl = true;
            this.TxtNroAutorizacion.Location = new System.Drawing.Point(174, 34);
            this.TxtNroAutorizacion.Name = "TxtNroAutorizacion";
            this.TxtNroAutorizacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtNroAutorizacion.Properties.ReadOnly = true;
            this.TxtNroAutorizacion.Size = new System.Drawing.Size(55, 22);
            this.TxtNroAutorizacion.TabIndex = 5;
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
            this.CboFuente.Enabled = false;
            this.CboFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboFuente.FormattingEnabled = true;
            this.CboFuente.Location = new System.Drawing.Point(6, 35);
            this.CboFuente.Name = "CboFuente";
            this.CboFuente.Size = new System.Drawing.Size(79, 21);
            this.CboFuente.TabIndex = 1;
            this.CboFuente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // CboMoneda
            // 
            this.CboMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMoneda.Enabled = false;
            this.CboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboMoneda.FormattingEnabled = true;
            this.CboMoneda.Items.AddRange(new object[] {
            "SOLES",
            "DOLARES",
            "EUROS",
            "OTRO"});
            this.CboMoneda.Location = new System.Drawing.Point(92, 35);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº &Exp.:";
            // 
            // CboYearExp
            // 
            this.CboYearExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboYearExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYearExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboYearExp.FormattingEnabled = true;
            this.CboYearExp.Location = new System.Drawing.Point(75, 40);
            this.CboYearExp.Name = "CboYearExp";
            this.CboYearExp.Size = new System.Drawing.Size(61, 21);
            this.CboYearExp.TabIndex = 3;
            this.CboYearExp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // EdIdExpediente
            // 
            this.EdIdExpediente.EnterMoveNextControl = true;
            this.EdIdExpediente.Location = new System.Drawing.Point(5, 41);
            this.EdIdExpediente.Name = "EdIdExpediente";
            this.EdIdExpediente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdExpediente.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdExpediente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdExpediente.Properties.Mask.BeepOnError = true;
            this.EdIdExpediente.Properties.Mask.EditMask = "99999999";
            this.EdIdExpediente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdIdExpediente.Properties.MaxLength = 15;
            this.EdIdExpediente.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdIdExpediente_Properties_ButtonClick);
            this.EdIdExpediente.Size = new System.Drawing.Size(67, 20);
            this.EdIdExpediente.TabIndex = 1;
            this.EdIdExpediente.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Location = new System.Drawing.Point(518, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Resumen Total >";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTotal.Location = new System.Drawing.Point(6, 15);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTotal.Size = new System.Drawing.Size(163, 35);
            this.TxtTotal.TabIndex = 0;
            this.TxtTotal.Text = "0.00";
            // 
            // GrpDocumento
            // 
            this.GrpDocumento.Controls.Add(this.CboTipoUsuario);
            this.GrpDocumento.Controls.Add(this.TxtDirec);
            this.GrpDocumento.Controls.Add(this.LblDirec);
            this.GrpDocumento.Controls.Add(this.TxtDni);
            this.GrpDocumento.Controls.Add(this.LblRuc);
            this.GrpDocumento.Controls.Add(this.TxtRazon);
            this.GrpDocumento.Controls.Add(this.LblTipoUsuario);
            this.GrpDocumento.Controls.Add(this.EdCodigo);
            this.GrpDocumento.Controls.Add(this.label4);
            this.GrpDocumento.Controls.Add(this.LblRazon);
            this.GrpDocumento.Location = new System.Drawing.Point(2, 162);
            this.GrpDocumento.Name = "GrpDocumento";
            this.GrpDocumento.Size = new System.Drawing.Size(693, 61);
            this.GrpDocumento.TabIndex = 1;
            this.GrpDocumento.TabStop = false;
            this.GrpDocumento.Text = "Datos del Beneficiario:";
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.EnterMoveNextControl = true;
            this.CboTipoUsuario.Location = new System.Drawing.Point(5, 32);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboTipoUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sigla", "Sigla", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CboTipoUsuario.Properties.DisplayMember = "nombre";
            this.CboTipoUsuario.Properties.DropDownRows = 3;
            this.CboTipoUsuario.Properties.ValueMember = "Sigla";
            this.CboTipoUsuario.Size = new System.Drawing.Size(115, 20);
            this.CboTipoUsuario.TabIndex = 1;
            this.CboTipoUsuario.EditValueChanged += new System.EventHandler(this.CboTipoUsuario_EditValueChanged);
            // 
            // TxtDirec
            // 
            this.TxtDirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDirec.Location = new System.Drawing.Point(438, 32);
            this.TxtDirec.Name = "TxtDirec";
            this.TxtDirec.ReadOnly = true;
            this.TxtDirec.Size = new System.Drawing.Size(177, 20);
            this.TxtDirec.TabIndex = 7;
            this.TxtDirec.TabStop = false;
            // 
            // LblDirec
            // 
            this.LblDirec.AutoSize = true;
            this.LblDirec.Location = new System.Drawing.Point(435, 16);
            this.LblDirec.Name = "LblDirec";
            this.LblDirec.Size = new System.Drawing.Size(55, 13);
            this.LblDirec.TabIndex = 6;
            this.LblDirec.Text = "Dirección:";
            // 
            // TxtDni
            // 
            this.TxtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDni.Location = new System.Drawing.Point(621, 32);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.ReadOnly = true;
            this.TxtDni.Size = new System.Drawing.Size(68, 20);
            this.TxtDni.TabIndex = 9;
            this.TxtDni.TabStop = false;
            // 
            // LblRuc
            // 
            this.LblRuc.AutoSize = true;
            this.LblRuc.Location = new System.Drawing.Point(614, 16);
            this.LblRuc.Name = "LblRuc";
            this.LblRuc.Size = new System.Drawing.Size(73, 13);
            this.LblRuc.TabIndex = 8;
            this.LblRuc.Text = "RUC/DNI/CE";
            // 
            // TxtRazon
            // 
            this.TxtRazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRazon.Location = new System.Drawing.Point(228, 32);
            this.TxtRazon.Name = "TxtRazon";
            this.TxtRazon.ReadOnly = true;
            this.TxtRazon.Size = new System.Drawing.Size(204, 20);
            this.TxtRazon.TabIndex = 5;
            this.TxtRazon.TabStop = false;
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(123, 16);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblTipoUsuario.TabIndex = 2;
            this.LblTipoUsuario.Text = "Usuario";
            // 
            // EdCodigo
            // 
            this.EdCodigo.EnterMoveNextControl = true;
            this.EdCodigo.Location = new System.Drawing.Point(126, 32);
            this.EdCodigo.Name = "EdCodigo";
            this.EdCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodigo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodigo.Properties.Mask.BeepOnError = true;
            this.EdCodigo.Properties.Mask.EditMask = "99999999999";
            this.EdCodigo.Properties.Mask.SaveLiteral = false;
            this.EdCodigo.Properties.MaxLength = 15;
            this.EdCodigo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCodPersonal_Properties_ButtonClick);
            this.EdCodigo.Size = new System.Drawing.Size(99, 20);
            this.EdCodigo.TabIndex = 3;
            this.EdCodigo.Enter += new System.EventHandler(this.ObjectEnter);
            this.EdCodigo.Leave += new System.EventHandler(this.EdCodigo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Usuario:";
            // 
            // LblRazon
            // 
            this.LblRazon.AutoSize = true;
            this.LblRazon.Location = new System.Drawing.Point(225, 16);
            this.LblRazon.Name = "LblRazon";
            this.LblRazon.Size = new System.Drawing.Size(121, 13);
            this.LblRazon.TabIndex = 4;
            this.LblRazon.Text = "Razon Social / Nombre:";
            // 
            // PicAnulado
            // 
            this.PicAnulado.Location = new System.Drawing.Point(0, 71);
            this.PicAnulado.Name = "PicAnulado";
            this.PicAnulado.Size = new System.Drawing.Size(137, 99);
            this.PicAnulado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAnulado.TabIndex = 24;
            this.PicAnulado.TabStop = false;
            this.PicAnulado.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.detalleOrdenBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchTipoUsuario,
            this.repositoryItemSearchIdMeta});
            this.gridControl1.Size = new System.Drawing.Size(698, 170);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragDrop);
            this.gridControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragEnter);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarcionGenericaDeDetallesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 48);
            // 
            // importarcionGenericaDeDetallesToolStripMenuItem
            // 
            this.importarcionGenericaDeDetallesToolStripMenuItem.Name = "importarcionGenericaDeDetallesToolStripMenuItem";
            this.importarcionGenericaDeDetallesToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.importarcionGenericaDeDetallesToolStripMenuItem.Text = "&1. Importacion Genérica de Detalles";
            this.importarcionGenericaDeDetallesToolStripMenuItem.Click += new System.EventHandler(this.importarcionGenericaDeDetallesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // detalleOrdenBindingSource
            // 
            this.detalleOrdenBindingSource.DataMember = "DetalleOrden";
            this.detalleOrdenBindingSource.DataSource = this.dsTramite;
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
            this.colIndex,
            this.colId,
            this.colIdOrden,
            this.colIdClasificador,
            this.colIdMeta,
            this.colIdTipoUsuario,
            this.colclasificador,
            this.colcodigo,
            this.colDetalle,
            this.colCantidad,
            this.colMonto,
            this.colImporte,
            this.colExceso});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", this.colIdMeta, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
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
            // colIndex
            // 
            this.colIndex.Caption = "Nº";
            this.colIndex.FieldName = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.Visible = true;
            this.colIndex.VisibleIndex = 0;
            this.colIndex.Width = 29;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colIdOrden
            // 
            this.colIdOrden.FieldName = "IdOrden";
            this.colIdOrden.Name = "colIdOrden";
            // 
            // colIdClasificador
            // 
            this.colIdClasificador.FieldName = "IdClasificador";
            this.colIdClasificador.Name = "colIdClasificador";
            // 
            // colIdMeta
            // 
            this.colIdMeta.Caption = "Meta";
            this.colIdMeta.ColumnEdit = this.repositoryItemSearchIdMeta;
            this.colIdMeta.FieldName = "IdMeta";
            this.colIdMeta.Name = "colIdMeta";
            this.colIdMeta.Visible = true;
            this.colIdMeta.VisibleIndex = 2;
            this.colIdMeta.Width = 35;
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
            // colIdTipoUsuario
            // 
            this.colIdTipoUsuario.Caption = "TipoUsuario";
            this.colIdTipoUsuario.ColumnEdit = this.repositoryItemSearchTipoUsuario;
            this.colIdTipoUsuario.FieldName = "IdTipoUsuario";
            this.colIdTipoUsuario.Name = "colIdTipoUsuario";
            this.colIdTipoUsuario.Visible = true;
            this.colIdTipoUsuario.VisibleIndex = 3;
            this.colIdTipoUsuario.Width = 91;
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
            // colclasificador
            // 
            this.colclasificador.Caption = "Clasificador";
            this.colclasificador.FieldName = "clasificador";
            this.colclasificador.Name = "colclasificador";
            this.colclasificador.Visible = true;
            this.colclasificador.VisibleIndex = 1;
            this.colclasificador.Width = 72;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Código";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 4;
            this.colcodigo.Width = 85;
            // 
            // colDetalle
            // 
            this.colDetalle.Caption = "Detalle";
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "Total S/. {0}")});
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 5;
            this.colDetalle.Width = 295;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 58;
            // 
            // colMonto
            // 
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Width = 180;
            // 
            // colImporte
            // 
            this.colImporte.Caption = "Importe";
            this.colImporte.DisplayFormat.FormatString = "#.00;[#.00];CERO";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 6;
            this.colImporte.Width = 74;
            // 
            // colExceso
            // 
            this.colExceso.DisplayFormat.FormatString = "#.00;[#.00];CERO";
            this.colExceso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colExceso.FieldName = "Exceso";
            this.colExceso.Name = "colExceso";
            this.colExceso.Width = 70;
            // 
            // CboYearOrden
            // 
            this.CboYearOrden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboYearOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYearOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboYearOrden.FormattingEnabled = true;
            this.CboYearOrden.Location = new System.Drawing.Point(585, 10);
            this.CboYearOrden.Name = "CboYearOrden";
            this.CboYearOrden.Size = new System.Drawing.Size(59, 21);
            this.CboYearOrden.TabIndex = 24;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FpOrdenLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 525);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FpOrdenLogistica";
            this.Text = "Trabajo de Ordenes de Servicio";
            this.Activated += new System.EventHandler(this.FpOrdenLogistica_Activated);
            this.Load += new System.EventHandler(this.FpOrdenLogistica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FpOrdenLogistica_KeyDown);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtRd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescripcion.Properties)).EndInit();
            this.GrpTramite.ResumeLayout(false);
            this.GrpTramite.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaGiro.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaGiro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReferencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCcp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSiaf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaExp.Properties)).EndInit();
            this.GrpAprobacion.ResumeLayout(false);
            this.GrpAprobacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoAprobado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroAutorizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdExpediente.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpDocumento.ResumeLayout(false);
            this.GrpDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnulado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchIdMeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchTipoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit EdIdOrden;
        private System.Windows.Forms.Button BtnCargaOrden;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.MemoEdit memoDescripcion;
        private System.Windows.Forms.GroupBox GrpTramite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CboTipoProceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.DateEdit DtFechaExp;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSubDependencia;
        private System.Windows.Forms.GroupBox GrpAprobacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboFuente;
        private System.Windows.Forms.ComboBox CboMoneda;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit DtFechaGiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboYearExp;
        private DevExpress.XtraEditors.ButtonEdit EdIdExpediente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GrpDocumento;
        private System.Windows.Forms.TextBox TxtDirec;
        private System.Windows.Forms.Label LblDirec;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label LblRuc;
        private System.Windows.Forms.TextBox TxtRazon;
        private System.Windows.Forms.Label LblTipoUsuario;
        private DevExpress.XtraEditors.ButtonEdit EdCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblRazon;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit TxtNroAutorizacion;
        private DevExpress.XtraEditors.TextEdit TxtReferencia;
        private DevExpress.XtraEditors.TextEdit TxtCcp;
        private DevExpress.XtraEditors.TextEdit TxtSiaf;
        private DevExpress.XtraEditors.TextEdit TxtMontoAprobado;
        private System.Windows.Forms.TextBox TxtTotal;
        private DevExpress.XtraEditors.LookUpEdit CboTipoUsuario;
        private DevExpress.XtraEditors.TextEdit TxtNroProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource detalleOrdenBindingSource;
        private Ds.DsTramite dsTramite;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchTipoUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchIdMeta;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraEditors.TextEdit TxtRd;
        private System.Windows.Forms.Label LblRd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboYearOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIndex;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClasificador;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMeta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colclasificador;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private System.Windows.Forms.Button BtnClonar;
        public long _idOrdenAClonar;
        private PrinterOrden _dsPrint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importarcionGenericaDeDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colExceso;
        private System.Windows.Forms.PictureBox PicAnulado;
    }
}
