namespace Certifica_logistica.mantenimiento
{
    partial class FmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAlumno));
            this.label13 = new System.Windows.Forms.Label();
            this.EdCUI = new DevExpress.XtraEditors.ButtonEdit();
            this.Grp01 = new DevExpress.XtraEditors.GroupControl();
            this.EdEscuelas = new DevExpress.XtraEditors.LookUpEdit();
            this.LstEscuelas = new DevExpress.XtraEditors.ListBoxControl();
            this.TxtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.DtFecNac = new DevExpress.XtraEditors.DateEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtDni = new DevExpress.XtraEditors.TextEdit();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtUbigeo = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.TxtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TxtRazon = new DevExpress.XtraEditors.TextEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.EdUbigeo = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtModificacion = new System.Windows.Forms.TextBox();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCUI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp01)).BeginInit();
            this.Grp01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdEscuelas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFecNac.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFecNac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUbigeo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdUbigeo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.student_48;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(297, 27);
            this.LblTitulo.Text = "Mantenimiento de Alumnos";
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(660, 43);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "&CUI:";
            // 
            // EdCUI
            // 
            this.EdCUI.Location = new System.Drawing.Point(51, 49);
            this.EdCUI.Name = "EdCUI";
            this.EdCUI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCUI.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCUI.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCUI.Properties.Mask.BeepOnError = true;
            this.EdCUI.Properties.Mask.EditMask = "99999999999";
            this.EdCUI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdCUI.Properties.MaxLength = 15;
            this.EdCUI.Size = new System.Drawing.Size(89, 20);
            this.EdCUI.TabIndex = 3;
            this.EdCUI.Leave += new System.EventHandler(this.EdCUI_Leave);
            // 
            // Grp01
            // 
            this.Grp01.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Grp01.Appearance.Options.UseBackColor = true;
            this.Grp01.Controls.Add(this.EdEscuelas);
            this.Grp01.Controls.Add(this.LstEscuelas);
            this.Grp01.Controls.Add(this.TxtEmail);
            this.Grp01.Controls.Add(this.label7);
            this.Grp01.Controls.Add(this.DtFecNac);
            this.Grp01.Controls.Add(this.label23);
            this.Grp01.Controls.Add(this.label24);
            this.Grp01.Controls.Add(this.TxtDni);
            this.Grp01.Controls.Add(this.label25);
            this.Grp01.Controls.Add(this.TxtUbigeo);
            this.Grp01.Controls.Add(this.label27);
            this.Grp01.Controls.Add(this.TxtTelefono);
            this.Grp01.Controls.Add(this.label8);
            this.Grp01.Controls.Add(this.TxtDireccion);
            this.Grp01.Controls.Add(this.label28);
            this.Grp01.Controls.Add(this.label29);
            this.Grp01.Controls.Add(this.TxtRazon);
            this.Grp01.Controls.Add(this.label30);
            this.Grp01.Controls.Add(this.EdUbigeo);
            this.Grp01.Location = new System.Drawing.Point(0, 74);
            this.Grp01.Name = "Grp01";
            this.Grp01.Size = new System.Drawing.Size(659, 223);
            this.Grp01.TabIndex = 6;
            this.Grp01.Text = "Datos Principales";
            // 
            // EdEscuelas
            // 
            this.EdEscuelas.EnterMoveNextControl = true;
            this.EdEscuelas.Location = new System.Drawing.Point(333, 40);
            this.EdEscuelas.Name = "EdEscuelas";
            this.EdEscuelas.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EdEscuelas.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.EdEscuelas.Properties.Appearance.Options.UseBackColor = true;
            this.EdEscuelas.Properties.Appearance.Options.UseForeColor = true;
            this.EdEscuelas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EdEscuelas.Size = new System.Drawing.Size(321, 20);
            this.EdEscuelas.TabIndex = 19;
            this.EdEscuelas.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // LstEscuelas
            // 
            this.LstEscuelas.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LstEscuelas.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.LstEscuelas.Appearance.Options.UseBackColor = true;
            this.LstEscuelas.Appearance.Options.UseForeColor = true;
            this.LstEscuelas.Location = new System.Drawing.Point(333, 63);
            this.LstEscuelas.Name = "LstEscuelas";
            this.LstEscuelas.Size = new System.Drawing.Size(321, 95);
            this.LstEscuelas.TabIndex = 18;
            this.LstEscuelas.TabStop = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.EditValue = "@";
            this.TxtEmail.EnterMoveNextControl = true;
            this.TxtEmail.Location = new System.Drawing.Point(5, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Properties.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtEmail.Properties.MaxLength = 70;
            this.TxtEmail.Size = new System.Drawing.Size(322, 22);
            this.TxtEmail.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Correo Electrónico:";
            // 
            // DtFecNac
            // 
            this.DtFecNac.EditValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtFecNac.Location = new System.Drawing.Point(573, 191);
            this.DtFecNac.Name = "DtFecNac";
            this.DtFecNac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFecNac.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFecNac.Size = new System.Drawing.Size(82, 20);
            this.DtFecNac.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(559, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Fecha. Nacimiento";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(473, 174);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "DNI:";
            // 
            // TxtDni
            // 
            this.TxtDni.EditValue = "00000000";
            this.TxtDni.EnterMoveNextControl = true;
            this.TxtDni.Location = new System.Drawing.Point(476, 190);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Properties.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtDni.Properties.Appearance.Options.UseBackColor = true;
            this.TxtDni.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtDni.Properties.MaxLength = 12;
            this.TxtDni.Size = new System.Drawing.Size(88, 22);
            this.TxtDni.TabIndex = 13;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(76, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(172, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "Distrito / Provincia / Departamento";
            // 
            // TxtUbigeo
            // 
            this.TxtUbigeo.EnterMoveNextControl = true;
            this.TxtUbigeo.Location = new System.Drawing.Point(79, 136);
            this.TxtUbigeo.Name = "TxtUbigeo";
            this.TxtUbigeo.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.TxtUbigeo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtUbigeo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtUbigeo.Properties.ReadOnly = true;
            this.TxtUbigeo.Size = new System.Drawing.Size(248, 22);
            this.TxtUbigeo.TabIndex = 9;
            this.TxtUbigeo.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Dirección:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.EnterMoveNextControl = true;
            this.TxtTelefono.Location = new System.Drawing.Point(333, 189);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtTelefono.Properties.MaxLength = 60;
            this.TxtTelefono.Size = new System.Drawing.Size(135, 22);
            this.TxtTelefono.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Teléfonos:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.EditValue = ".";
            this.TxtDireccion.EnterMoveNextControl = true;
            this.TxtDireccion.Location = new System.Drawing.Point(5, 89);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtDireccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Properties.MaxLength = 120;
            this.TxtDireccion.Size = new System.Drawing.Size(322, 22);
            this.TxtDireccion.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(330, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Escuela:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(24, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(102, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Apellidos y Nombres";
            // 
            // TxtRazon
            // 
            this.TxtRazon.EnterMoveNextControl = true;
            this.TxtRazon.Location = new System.Drawing.Point(5, 40);
            this.TxtRazon.Name = "TxtRazon";
            this.TxtRazon.Properties.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtRazon.Properties.Appearance.Options.UseBackColor = true;
            this.TxtRazon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.TxtRazon.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtRazon.Properties.MaxLength = 100;
            this.TxtRazon.Size = new System.Drawing.Size(322, 22);
            this.TxtRazon.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 120);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "Ubigeo:";
            // 
            // EdUbigeo
            // 
            this.EdUbigeo.EditValue = "000000";
            this.EdUbigeo.Location = new System.Drawing.Point(5, 136);
            this.EdUbigeo.Name = "EdUbigeo";
            this.EdUbigeo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdUbigeo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdUbigeo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdUbigeo.Properties.Mask.BeepOnError = true;
            this.EdUbigeo.Properties.Mask.EditMask = "999999";
            this.EdUbigeo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.EdUbigeo.Properties.Mask.SaveLiteral = false;
            this.EdUbigeo.Properties.MaxLength = 15;
            this.EdUbigeo.Size = new System.Drawing.Size(68, 20);
            this.EdUbigeo.TabIndex = 7;
            this.EdUbigeo.Leave += new System.EventHandler(this.EdUbigeo_Leave);
            // 
            // TxtModificacion
            // 
            this.TxtModificacion.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TxtModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtModificacion.Location = new System.Drawing.Point(-1, 303);
            this.TxtModificacion.MaxLength = 80;
            this.TxtModificacion.Name = "TxtModificacion";
            this.TxtModificacion.ReadOnly = true;
            this.TxtModificacion.Size = new System.Drawing.Size(660, 20);
            this.TxtModificacion.TabIndex = 13;
            this.TxtModificacion.TabStop = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(660, 335);
            this.Controls.Add(this.TxtModificacion);
            this.Controls.Add(this.Grp01);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EdCUI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmAlumno";
            this.Text = "Mantenimiento de Alumnos";
            this.Load += new System.EventHandler(this.FmAlumno_Load);
            this.Controls.SetChildIndex(this.EdCUI, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.Grp01, 0);
            this.Controls.SetChildIndex(this.TxtModificacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCUI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp01)).EndInit();
            this.Grp01.ResumeLayout(false);
            this.Grp01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdEscuelas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFecNac.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFecNac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUbigeo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRazon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdUbigeo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ButtonEdit EdCUI;
        private DevExpress.XtraEditors.GroupControl Grp01;
        private DevExpress.XtraEditors.DateEdit DtFecNac;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.TextEdit TxtDni;
        private System.Windows.Forms.Label label25;
        private DevExpress.XtraEditors.TextEdit TxtUbigeo;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.TextEdit TxtTelefono;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit TxtDireccion;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private DevExpress.XtraEditors.TextEdit TxtRazon;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.ButtonEdit EdUbigeo;
        private DevExpress.XtraEditors.TextEdit TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtModificacion;
        private DevExpress.XtraEditors.ListBoxControl LstEscuelas;
        private DevExpress.XtraEditors.LookUpEdit EdEscuelas;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
