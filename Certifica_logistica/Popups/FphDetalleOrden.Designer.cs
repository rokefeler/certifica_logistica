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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LstMetas = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CboPeriodo = new System.Windows.Forms.ComboBox();
            this.EdIdMeta = new DevExpress.XtraEditors.ButtonEdit();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.LstMetas);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CboPeriodo);
            this.groupBox1.Controls.Add(this.EdIdMeta);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Datos presupuestales >";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Importe";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.Location = new System.Drawing.Point(115, 27);
            this.textBox6.MaxLength = 35;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(53, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(5, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 50);
            this.textBox1.TabIndex = 17;
            this.textBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LstMetas
            // 
            this.LstMetas.FormattingEnabled = true;
            this.LstMetas.Location = new System.Drawing.Point(210, 7);
            this.LstMetas.Name = "LstMetas";
            this.LstMetas.Size = new System.Drawing.Size(125, 95);
            this.LstMetas.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Periodo";
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
            this.CboPeriodo.Location = new System.Drawing.Point(5, 27);
            this.CboPeriodo.Name = "CboPeriodo";
            this.CboPeriodo.Size = new System.Drawing.Size(61, 21);
            this.CboPeriodo.TabIndex = 1;
            this.CboPeriodo.TabStop = false;
            // 
            // EdIdMeta
            // 
            this.EdIdMeta.Location = new System.Drawing.Point(67, 27);
            this.EdIdMeta.Name = "EdIdMeta";
            this.EdIdMeta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdIdMeta.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdIdMeta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdIdMeta.Properties.Mask.BeepOnError = true;
            this.EdIdMeta.Properties.Mask.EditMask = "00";
            this.EdIdMeta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdIdMeta.Properties.Mask.SaveLiteral = false;
            this.EdIdMeta.Properties.MaxLength = 15;
            this.EdIdMeta.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit3_Properties_ButtonClick);
            this.EdIdMeta.Size = new System.Drawing.Size(45, 20);
            this.EdIdMeta.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Meta";
            // 
            // FphDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.groupBox1);
            this.Name = "FphDetalleOrden";
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdIdMeta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LstMetas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboPeriodo;
        private DevExpress.XtraEditors.ButtonEdit EdIdMeta;
        private System.Windows.Forms.Label label13;
    }
}
