using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Certifica_logistica.Popups
{
    partial class FphModificarNroExp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CboYearExpFinal = new System.Windows.Forms.ComboBox();
            this.EdExpFinal = new DevExpress.XtraEditors.ButtonEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.LblOk = new System.Windows.Forms.Label();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TxtExpedienteActual = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdExpFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtExpedienteActual);
            this.panel1.Controls.Add(this.LblOk);
            this.panel1.Controls.Add(this.TxtLog);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CboYearExpFinal);
            this.panel1.Controls.Add(this.EdExpFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(437, 164);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro. Expediente Actual:";
            // 
            // CboYearExpFinal
            // 
            this.CboYearExpFinal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboYearExpFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYearExpFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboYearExpFinal.FormattingEnabled = true;
            this.CboYearExpFinal.Location = new System.Drawing.Point(275, 97);
            this.CboYearExpFinal.Name = "CboYearExpFinal";
            this.CboYearExpFinal.Size = new System.Drawing.Size(61, 21);
            this.CboYearExpFinal.TabIndex = 6;
            this.CboYearExpFinal.SelectedIndexChanged += new System.EventHandler(this.CboYearExpFinal_SelectedIndexChanged);
            // 
            // EdExpFinal
            // 
            this.EdExpFinal.EnterMoveNextControl = true;
            this.EdExpFinal.Location = new System.Drawing.Point(199, 98);
            this.EdExpFinal.Name = "EdExpFinal";
            this.EdExpFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdExpFinal.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdExpFinal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdExpFinal.Properties.Mask.BeepOnError = true;
            this.EdExpFinal.Properties.Mask.EditMask = "A99999";
            this.EdExpFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdExpFinal.Properties.MaxLength = 15;
            this.EdExpFinal.Size = new System.Drawing.Size(67, 20);
            this.EdExpFinal.TabIndex = 5;
            this.EdExpFinal.Leave += new System.EventHandler(this.EdExpFinal_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Reemplazar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nro. Log:";
            // 
            // TxtLog
            // 
            this.TxtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLog.Location = new System.Drawing.Point(199, 11);
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.Size = new System.Drawing.Size(137, 20);
            this.TxtLog.TabIndex = 1;
            this.TxtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblOk
            // 
            this.LblOk.AutoSize = true;
            this.LblOk.Location = new System.Drawing.Point(352, 104);
            this.LblOk.Name = "LblOk";
            this.LblOk.Size = new System.Drawing.Size(73, 13);
            this.LblOk.TabIndex = 7;
            this.LblOk.Text = "OK, No Existe";
            this.LblOk.Visible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // TxtExpedienteActual
            // 
            this.TxtExpedienteActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtExpedienteActual.Location = new System.Drawing.Point(199, 40);
            this.TxtExpedienteActual.Name = "TxtExpedienteActual";
            this.TxtExpedienteActual.ReadOnly = true;
            this.TxtExpedienteActual.Size = new System.Drawing.Size(137, 20);
            this.TxtExpedienteActual.TabIndex = 3;
            this.TxtExpedienteActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FphModificarNroExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 224);
            this.ControlBox = true;
            this.Name = "FphModificarNroExp";
            this.Text = "Corregir Nro. de Expediente";
            this.Load += new System.EventHandler(this.FphModificarNroExp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdExpFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboYearExpFinal;
        private DevExpress.XtraEditors.ButtonEdit EdExpFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblOk;
        public string _idUsuario;
        public Database _miDatabase;
        public int _nLog;
        public int _anio;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        public System.Windows.Forms.TextBox TxtExpedienteActual;
    }
}