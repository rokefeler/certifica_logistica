namespace Certifica_logistica.mantenimiento
{
    partial class FmSubDependencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSubDependencia));
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.EdCodDependencia = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdCodSubDep = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtRazonPersonal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EdCodPersonal = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtObsv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSigla = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAutorizacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtFechaAut = new DevExpress.XtraEditors.DateEdit();
            this.ChkIsConvenio = new System.Windows.Forms.CheckBox();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.TxtModificacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodDependencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaAut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaAut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.edificio_32;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(460, 27);
            this.LblTitulo.Text = "Mantenimiento Ficha de SubDependencias";
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(521, 43);
            // 
            // CboEstado
            // 
            this.CboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "DESACTIVADO",
            "ACTIVADO"});
            this.CboEstado.Location = new System.Drawing.Point(101, 307);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(244, 21);
            this.CboEstado.TabIndex = 23;
            this.CboEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Es&ado Actual:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(101, 103);
            this.TxtNombre.MaxLength = 256;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(407, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(27, 106);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(70, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "&RazónSocial:";
            // 
            // EdCodDependencia
            // 
            this.EdCodDependencia.EnterMoveNextControl = true;
            this.EdCodDependencia.Location = new System.Drawing.Point(101, 77);
            this.EdCodDependencia.Name = "EdCodDependencia";
            this.EdCodDependencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EdCodDependencia.Size = new System.Drawing.Size(407, 20);
            this.EdCodDependencia.TabIndex = 3;
            this.EdCodDependencia.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Dependencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Código:";
            // 
            // EdCodSubDep
            // 
            this.EdCodSubDep.EnterMoveNextControl = true;
            this.EdCodSubDep.Location = new System.Drawing.Point(101, 51);
            this.EdCodSubDep.Name = "EdCodSubDep";
            this.EdCodSubDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodSubDep.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodSubDep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodSubDep.Properties.Mask.BeepOnError = true;
            this.EdCodSubDep.Properties.Mask.EditMask = "LCCl";
            this.EdCodSubDep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdCodSubDep.Properties.Mask.SaveLiteral = false;
            this.EdCodSubDep.Properties.MaxLength = 15;
            this.EdCodSubDep.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdCodSubDep_Properties_ButtonClick);
            this.EdCodSubDep.Size = new System.Drawing.Size(65, 20);
            this.EdCodSubDep.TabIndex = 1;
            this.EdCodSubDep.Leave += new System.EventHandler(this.EdCodSubDep_Leave);
            // 
            // TxtRazonPersonal
            // 
            this.TxtRazonPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRazonPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRazonPersonal.Location = new System.Drawing.Point(207, 129);
            this.TxtRazonPersonal.Name = "TxtRazonPersonal";
            this.TxtRazonPersonal.ReadOnly = true;
            this.TxtRazonPersonal.Size = new System.Drawing.Size(301, 20);
            this.TxtRazonPersonal.TabIndex = 8;
            this.TxtRazonPersonal.TabStop = false;
            this.TxtRazonPersonal.Text = "POR DETERMINAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Jefe o Encargado:";
            // 
            // EdCodPersonal
            // 
            this.EdCodPersonal.EditValue = "00000000";
            this.EdCodPersonal.EnterMoveNextControl = true;
            this.EdCodPersonal.Location = new System.Drawing.Point(101, 129);
            this.EdCodPersonal.Name = "EdCodPersonal";
            this.EdCodPersonal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodPersonal.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodPersonal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodPersonal.Properties.Mask.BeepOnError = true;
            this.EdCodPersonal.Properties.Mask.EditMask = "99999999";
            this.EdCodPersonal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdCodPersonal.Properties.MaxLength = 15;
            this.EdCodPersonal.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCodPersonal_Properties_ButtonClick);
            this.EdCodPersonal.Size = new System.Drawing.Size(100, 20);
            this.EdCodPersonal.TabIndex = 7;
            this.EdCodPersonal.Leave += new System.EventHandler(this.EdCodPersonal_Leave);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTelefono.Location = new System.Drawing.Point(101, 155);
            this.TxtTelefono.MaxLength = 35;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(315, 20);
            this.TxtTelefono.TabIndex = 10;
            this.TxtTelefono.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "&Teléfonos:";
            // 
            // TxtWeb
            // 
            this.TxtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWeb.Location = new System.Drawing.Point(101, 203);
            this.TxtWeb.MaxLength = 70;
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(315, 20);
            this.TxtWeb.TabIndex = 14;
            this.TxtWeb.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtWeb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Página Web &http://";
            // 
            // TxtObsv
            // 
            this.TxtObsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtObsv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtObsv.Location = new System.Drawing.Point(101, 229);
            this.TxtObsv.MaxLength = 255;
            this.TxtObsv.Name = "TxtObsv";
            this.TxtObsv.Size = new System.Drawing.Size(407, 20);
            this.TxtObsv.TabIndex = 16;
            this.TxtObsv.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtObsv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Observaciones:";
            // 
            // TxtSigla
            // 
            this.TxtSigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSigla.Location = new System.Drawing.Point(101, 255);
            this.TxtSigla.MaxLength = 35;
            this.TxtSigla.Name = "TxtSigla";
            this.TxtSigla.Size = new System.Drawing.Size(315, 20);
            this.TxtSigla.TabIndex = 18;
            this.TxtSigla.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtSigla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Siglas &Impresión:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(101, 177);
            this.TxtEmail.MaxLength = 70;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(315, 20);
            this.TxtEmail.TabIndex = 12;
            this.TxtEmail.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Correo &Electrónico:";
            // 
            // TxtAutorizacion
            // 
            this.TxtAutorizacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAutorizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAutorizacion.Location = new System.Drawing.Point(101, 281);
            this.TxtAutorizacion.MaxLength = 35;
            this.TxtAutorizacion.Name = "TxtAutorizacion";
            this.TxtAutorizacion.Size = new System.Drawing.Size(315, 20);
            this.TxtAutorizacion.TabIndex = 20;
            this.TxtAutorizacion.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtAutorizacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Res. Autori&zación:";
            // 
            // DtFechaAut
            // 
            this.DtFechaAut.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtFechaAut.EnterMoveNextControl = true;
            this.DtFechaAut.Location = new System.Drawing.Point(422, 281);
            this.DtFechaAut.Name = "DtFechaAut";
            this.DtFechaAut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaAut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFechaAut.Properties.Mask.BeepOnError = true;
            this.DtFechaAut.Size = new System.Drawing.Size(86, 20);
            this.DtFechaAut.TabIndex = 21;
            this.DtFechaAut.ToolTip = "Fecha de Autorización";
            this.DtFechaAut.Enter += new System.EventHandler(this.ObjectEnter);
            // 
            // ChkIsConvenio
            // 
            this.ChkIsConvenio.AutoSize = true;
            this.ChkIsConvenio.Location = new System.Drawing.Point(358, 53);
            this.ChkIsConvenio.Name = "ChkIsConvenio";
            this.ChkIsConvenio.Size = new System.Drawing.Size(150, 17);
            this.ChkIsConvenio.TabIndex = 25;
            this.ChkIsConvenio.Text = "Es Un Con&venio Temporal";
            this.ChkIsConvenio.UseVisualStyleBackColor = true;
            this.ChkIsConvenio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // TxtModificacion
            // 
            this.TxtModificacion.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TxtModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtModificacion.Location = new System.Drawing.Point(3, 334);
            this.TxtModificacion.MaxLength = 80;
            this.TxtModificacion.Name = "TxtModificacion";
            this.TxtModificacion.ReadOnly = true;
            this.TxtModificacion.Size = new System.Drawing.Size(505, 20);
            this.TxtModificacion.TabIndex = 24;
            this.TxtModificacion.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 43;
            // 
            // FmSubDependencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 363);
            this.Controls.Add(this.TxtModificacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ChkIsConvenio);
            this.Controls.Add(this.DtFechaAut);
            this.Controls.Add(this.TxtAutorizacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSigla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtObsv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtWeb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRazonPersonal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EdCodPersonal);
            this.Controls.Add(this.EdCodSubDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.EdCodDependencia);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmSubDependencia";
            this.Text = "SubDependencias";
            this.Load += new System.EventHandler(this.FmSubDependencia_Load);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.EdCodDependencia, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CboEstado, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.EdCodSubDep, 0);
            this.Controls.SetChildIndex(this.EdCodPersonal, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TxtRazonPersonal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtTelefono, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtWeb, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.TxtObsv, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtSigla, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.TxtAutorizacion, 0);
            this.Controls.SetChildIndex(this.DtFechaAut, 0);
            this.Controls.SetChildIndex(this.ChkIsConvenio, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.TxtModificacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodDependencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaAut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFechaAut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label Nombre;
        private DevExpress.XtraEditors.LookUpEdit EdCodDependencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit EdCodSubDep;
        private System.Windows.Forms.TextBox TxtRazonPersonal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ButtonEdit EdCodPersonal;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtObsv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSigla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtAutorizacion;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.DateEdit DtFechaAut;
        private System.Windows.Forms.CheckBox ChkIsConvenio;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.TextBox TxtModificacion;
        private System.Windows.Forms.Label label11;

    }
}
