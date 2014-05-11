namespace Certifica_logistica.Popups
{
    partial class FphOrdenDetalle
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
            this.SpnMonto = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDetalle = new DevExpress.XtraEditors.TextEdit();
            this.CboTipoUsuario = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.EdCodigo = new DevExpress.XtraEditors.ButtonEdit();
            this.EdIdClasificador = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.EdIdMeta = new DevExpress.XtraEditors.ButtonEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CboPeriodo = new System.Windows.Forms.ComboBox();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpnMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdClasificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtDetalle);
            this.panel1.Controls.Add(this.CboPeriodo);
            this.panel1.Controls.Add(this.CboTipoUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SpnMonto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LblTipoUsuario);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.EdCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.EdIdClasificador);
            this.panel1.Controls.Add(this.EdIdMeta);
            this.panel1.Size = new System.Drawing.Size(433, 338);
            // 
            // SpnMonto
            // 
            this.SpnMonto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpnMonto.EnterMoveNextControl = true;
            this.SpnMonto.Location = new System.Drawing.Point(304, 27);
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
            this.SpnMonto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Importe:";
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.Location = new System.Drawing.Point(12, 122);
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDetalle.Properties.MaxLength = 70;
            this.TxtDetalle.Size = new System.Drawing.Size(396, 20);
            this.TxtDetalle.TabIndex = 5;
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.EnterMoveNextControl = true;
            this.CboTipoUsuario.Location = new System.Drawing.Point(12, 74);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Tipo de Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "&Detalle";
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Location = new System.Drawing.Point(138, 58);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblTipoUsuario.TabIndex = 2;
            this.LblTipoUsuario.Text = "&Usuario";
            // 
            // EdCodigo
            // 
            this.EdCodigo.EnterMoveNextControl = true;
            this.EdCodigo.Location = new System.Drawing.Point(131, 74);
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
            this.EdCodigo.Size = new System.Drawing.Size(99, 20);
            this.EdCodigo.TabIndex = 3;
            this.EdCodigo.Leave += new System.EventHandler(this.EdCodigo_Leave);
            // 
            // EdIdClasificador
            // 
            this.EdIdClasificador.EnterMoveNextControl = true;
            this.EdIdClasificador.Location = new System.Drawing.Point(80, 27);
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
            this.EdIdClasificador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Clasificador:";
            // 
            // EdIdMeta
            // 
            this.EdIdMeta.EnterMoveNextControl = true;
            this.EdIdMeta.Location = new System.Drawing.Point(238, 27);
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
            this.EdIdMeta.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "&Meta:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "&Periodo";
            // 
            // CboPeriodo
            // 
            this.CboPeriodo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboPeriodo.FormattingEnabled = true;
            this.CboPeriodo.Items.AddRange(new object[] {
            "SOLES",
            "DOLARES",
            "EUROS",
            "OTRO"});
            this.CboPeriodo.Location = new System.Drawing.Point(12, 26);
            this.CboPeriodo.Name = "CboPeriodo";
            this.CboPeriodo.Size = new System.Drawing.Size(61, 21);
            this.CboPeriodo.TabIndex = 1;
            this.CboPeriodo.TabStop = false;
            this.CboPeriodo.Leave += new System.EventHandler(this.CboPeriodo_Leave);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FphOrdenDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(433, 398);
            this.Name = "FphOrdenDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpnMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDetalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdClasificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        public DevExpress.XtraEditors.SpinEdit SpnMonto;
        public DevExpress.XtraEditors.LookUpEdit CboTipoUsuario;
        public DevExpress.XtraEditors.ButtonEdit EdCodigo;
        public DevExpress.XtraEditors.ButtonEdit EdIdClasificador;
        public DevExpress.XtraEditors.ButtonEdit EdIdMeta;
        public System.Windows.Forms.ComboBox CboPeriodo;
        public DevExpress.XtraEditors.TextEdit TxtDetalle;
    }
}
