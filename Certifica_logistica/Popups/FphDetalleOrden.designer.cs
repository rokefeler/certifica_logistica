namespace Certifica_logistica.Popups
{
    partial class FphDetalleOrden
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FphDetalleOrden));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboPeriodo = new System.Windows.Forms.ComboBox();
            this.SpnMonto = new DevExpress.XtraEditors.SpinEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EdIdClasificador = new DevExpress.XtraEditors.ButtonEdit();
            this.EdIdMeta = new DevExpress.XtraEditors.ButtonEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtServicio = new System.Windows.Forms.TextBox();
            this.LblServicio = new System.Windows.Forms.Label();
            this.TxtDetalle = new DevExpress.XtraEditors.TextEdit();
            this.CboTipoUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.EdCodigo = new DevExpress.XtraEditors.ButtonEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpnMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdClasificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(82, 12);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(216, 12);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Size = new System.Drawing.Size(413, 208);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 92);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboPeriodo);
            this.groupBox1.Controls.Add(this.SpnMonto);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.EdIdClasificador);
            this.groupBox1.Controls.Add(this.EdIdMeta);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Clasificador Meta y Monto";
            // 
            // CboPeriodo
            // 
            this.CboPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboPeriodo.FormattingEnabled = true;
            this.CboPeriodo.Location = new System.Drawing.Point(9, 45);
            this.CboPeriodo.Name = "CboPeriodo";
            this.CboPeriodo.Size = new System.Drawing.Size(61, 21);
            this.CboPeriodo.TabIndex = 9;
            this.CboPeriodo.TabStop = false;
            this.CboPeriodo.Leave += new System.EventHandler(this.CboPeriodo_Leave);
            // 
            // SpnMonto
            // 
            this.SpnMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpnMonto.EnterMoveNextControl = true;
            this.SpnMonto.Location = new System.Drawing.Point(301, 46);
            this.SpnMonto.Name = "SpnMonto";
            this.SpnMonto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpnMonto.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SpnMonto.Properties.Mask.EditMask = "n2";
            this.SpnMonto.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.SpnMonto.Size = new System.Drawing.Size(89, 20);
            this.SpnMonto.TabIndex = 15;
            this.SpnMonto.ToolTipController = this.toolTipController1;
            this.SpnMonto.Leave += new System.EventHandler(this.SpnMonto_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "&Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "&Importe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Clasificador:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "&Meta:";
            // 
            // EdIdClasificador
            // 
            this.EdIdClasificador.EnterMoveNextControl = true;
            this.EdIdClasificador.Location = new System.Drawing.Point(77, 46);
            this.EdIdClasificador.Name = "EdIdClasificador";
            this.EdIdClasificador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdClasificador.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdClasificador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdClasificador.Properties.Mask.BeepOnError = true;
            this.EdIdClasificador.Properties.Mask.EditMask = "0.0.9 99.99 99";
            this.EdIdClasificador.Properties.Mask.IgnoreMaskBlank = false;
            this.EdIdClasificador.Properties.MaxLength = 15;
            this.EdIdClasificador.Size = new System.Drawing.Size(147, 20);
            this.EdIdClasificador.TabIndex = 11;
            this.EdIdClasificador.ToolTipController = this.toolTipController1;
            this.EdIdClasificador.Leave += new System.EventHandler(this.EdIdClasificador_Leave);
            // 
            // EdIdMeta
            // 
            this.EdIdMeta.EnterMoveNextControl = true;
            this.EdIdMeta.Location = new System.Drawing.Point(235, 46);
            this.EdIdMeta.Name = "EdIdMeta";
            this.EdIdMeta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdMeta.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdMeta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdMeta.Properties.Mask.BeepOnError = true;
            this.EdIdMeta.Properties.Mask.EditMask = "00";
            this.EdIdMeta.Properties.Mask.SaveLiteral = false;
            this.EdIdMeta.Properties.MaxLength = 15;
            this.EdIdMeta.Size = new System.Drawing.Size(58, 20);
            this.EdIdMeta.TabIndex = 13;
            this.EdIdMeta.ToolTipController = this.toolTipController1;
            this.EdIdMeta.Leave += new System.EventHandler(this.EdIdMeta_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtServicio);
            this.panel4.Controls.Add(this.LblServicio);
            this.panel4.Controls.Add(this.TxtDetalle);
            this.panel4.Controls.Add(this.CboTipoUsuario);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.LblTipoUsuario);
            this.panel4.Controls.Add(this.EdCodigo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 116);
            this.panel4.TabIndex = 2;
            // 
            // TxtServicio
            // 
            this.TxtServicio.BackColor = System.Drawing.Color.Snow;
            this.TxtServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtServicio.Location = new System.Drawing.Point(236, 23);
            this.TxtServicio.Name = "TxtServicio";
            this.TxtServicio.ReadOnly = true;
            this.TxtServicio.Size = new System.Drawing.Size(155, 20);
            this.TxtServicio.TabIndex = 5;
            this.TxtServicio.TabStop = false;
            this.TxtServicio.Visible = false;
            // 
            // LblServicio
            // 
            this.LblServicio.AutoSize = true;
            this.LblServicio.Location = new System.Drawing.Point(256, 7);
            this.LblServicio.Name = "LblServicio";
            this.LblServicio.Size = new System.Drawing.Size(84, 13);
            this.LblServicio.TabIndex = 4;
            this.LblServicio.Text = "Tipo de Servicio";
            this.LblServicio.Visible = false;
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.EnterMoveNextControl = true;
            this.TxtDetalle.Location = new System.Drawing.Point(12, 74);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDetalle.Properties.MaxLength = 70;
            this.TxtDetalle.Size = new System.Drawing.Size(381, 20);
            this.TxtDetalle.TabIndex = 7;
            this.TxtDetalle.ToolTipController = this.toolTipController1;
            this.TxtDetalle.Leave += new System.EventHandler(this.TxtDetalle_Leave);
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.EnterMoveNextControl = true;
            this.CboTipoUsuario.Location = new System.Drawing.Point(12, 23);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboTipoUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sigla", "Sigla", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "Nombre", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CboTipoUsuario.Properties.DisplayMember = "nombre";
            this.CboTipoUsuario.Properties.ValueMember = "Sigla";
            this.CboTipoUsuario.Size = new System.Drawing.Size(112, 20);
            this.CboTipoUsuario.TabIndex = 1;
            this.CboTipoUsuario.ToolTipController = this.toolTipController1;
            this.CboTipoUsuario.EditValueChanged += new System.EventHandler(this.CboTipoUsuario_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Tipo de Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "&Detalle";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(138, 7);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblTipoUsuario.TabIndex = 2;
            this.LblTipoUsuario.Text = "&Usuario";
            // 
            // EdCodigo
            // 
            this.EdCodigo.EnterMoveNextControl = true;
            this.EdCodigo.Location = new System.Drawing.Point(131, 23);
            this.EdCodigo.Name = "EdCodigo";
            this.EdCodigo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodigo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodigo.Properties.Mask.BeepOnError = true;
            this.EdCodigo.Properties.Mask.EditMask = "99999999999";
            this.EdCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdCodigo.Properties.Mask.SaveLiteral = false;
            this.EdCodigo.Properties.MaxLength = 15;
            this.EdCodigo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdCodigo_Properties_ButtonClick);
            this.EdCodigo.Size = new System.Drawing.Size(99, 20);
            this.EdCodigo.TabIndex = 3;
            this.EdCodigo.ToolTipController = this.toolTipController1;
            this.EdCodigo.Leave += new System.EventHandler(this.EdCodigo_Leave);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FphDetalleOrden
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.ControlBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FphDetalleOrden";
            this.Text = "";
            this.Load += new System.EventHandler(this.FphDetalleOrden_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpnMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdClasificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox CboPeriodo;
        public DevExpress.XtraEditors.SpinEdit SpnMonto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        public DevExpress.XtraEditors.ButtonEdit EdIdClasificador;
        public DevExpress.XtraEditors.ButtonEdit EdIdMeta;
        public DevExpress.XtraEditors.TextEdit TxtDetalle;
        public DevExpress.XtraEditors.LookUpEdit CboTipoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTipoUsuario;
        public DevExpress.XtraEditors.ButtonEdit EdCodigo;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Label LblServicio;
        private System.Windows.Forms.TextBox TxtServicio;
    }
}
