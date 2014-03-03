namespace Certifica_logistica.mantenimiento
{
    partial class FmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPersonal));
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EdCodPersonal = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CboTDoc = new System.Windows.Forms.ComboBox();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMovil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnUbigeo = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtUbigeo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFijo = new System.Windows.Forms.TextBox();
            this.CboCondicion = new System.Windows.Forms.ComboBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.GrpSubDependencia = new System.Windows.Forms.GroupBox();
            this.EdCodSubDep = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtSubDependencia = new System.Windows.Forms.TextBox();
            this.TxtDependencia = new System.Windows.Forms.TextBox();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.BtnImportarSunat = new System.Windows.Forms.Button();
            this.BtnImportarMTC = new System.Windows.Forms.Button();
            this.BtnImportarReniec = new System.Windows.Forms.Button();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUbigeo.Properties)).BeginInit();
            this.GrpSubDependencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.login48;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(362, 27);
            this.LblTitulo.Text = "Mantenimiento de Ficha Personal";
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(479, 43);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellidos.Location = new System.Drawing.Point(88, 80);
            this.TxtApellidos.MaxLength = 35;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(389, 20);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtApellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Usuario Resp.:";
            // 
            // EdCodPersonal
            // 
            this.EdCodPersonal.EnterMoveNextControl = true;
            this.EdCodPersonal.Location = new System.Drawing.Point(88, 49);
            this.EdCodPersonal.Name = "EdCodPersonal";
            this.EdCodPersonal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodPersonal.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodPersonal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodPersonal.Properties.Mask.BeepOnError = true;
            this.EdCodPersonal.Properties.Mask.EditMask = "A99999999";
            this.EdCodPersonal.Properties.MaxLength = 15;
            this.EdCodPersonal.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCodPersonal_Properties_ButtonClick);
            this.EdCodPersonal.Size = new System.Drawing.Size(100, 20);
            this.EdCodPersonal.TabIndex = 1;
            this.EdCodPersonal.Enter += new System.EventHandler(this.ObjectEnter);
            this.EdCodPersonal.Leave += new System.EventHandler(this.TxtCodPersonal_Leave);
            this.EdCodPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodPersonal_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Nombres:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombres.Location = new System.Drawing.Point(88, 106);
            this.TxtNombres.MaxLength = 35;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(389, 20);
            this.TxtNombres.TabIndex = 5;
            this.TxtNombres.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtNombres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "D&irección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Location = new System.Drawing.Point(88, 162);
            this.TxtDireccion.MaxLength = 70;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(389, 20);
            this.TxtDireccion.TabIndex = 10;
            this.TxtDireccion.Text = ".";
            this.TxtDireccion.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Doc. Identidad:";
            // 
            // CboTDoc
            // 
            this.CboTDoc.FormattingEnabled = true;
            this.CboTDoc.Location = new System.Drawing.Point(88, 134);
            this.CboTDoc.Name = "CboTDoc";
            this.CboTDoc.Size = new System.Drawing.Size(177, 21);
            this.CboTDoc.TabIndex = 7;
            this.CboTDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroDoc.Location = new System.Drawing.Point(271, 134);
            this.TxtNroDoc.MaxLength = 15;
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(206, 20);
            this.TxtNroDoc.TabIndex = 8;
            this.TxtNroDoc.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtNroDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            this.TxtNroDoc.Leave += new System.EventHandler(this.TxtNroDoc_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "&Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(88, 219);
            this.TxtEmail.MaxLength = 70;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(389, 20);
            this.TxtEmail.TabIndex = 15;
            this.TxtEmail.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nro. &Móvil:";
            // 
            // TxtMovil
            // 
            this.TxtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMovil.Location = new System.Drawing.Point(88, 245);
            this.TxtMovil.MaxLength = 15;
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(177, 20);
            this.TxtMovil.TabIndex = 17;
            this.TxtMovil.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtMovil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "C&ondición:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ubi&geo:";
            // 
            // BtnUbigeo
            // 
            this.BtnUbigeo.EditValue = "000000";
            this.BtnUbigeo.EnterMoveNextControl = true;
            this.BtnUbigeo.Location = new System.Drawing.Point(88, 189);
            this.BtnUbigeo.Name = "BtnUbigeo";
            this.BtnUbigeo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BtnUbigeo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BtnUbigeo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BtnUbigeo.Properties.Mask.BeepOnError = true;
            this.BtnUbigeo.Properties.Mask.EditMask = "999999";
            this.BtnUbigeo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.BtnUbigeo.Properties.MaxLength = 15;
            this.BtnUbigeo.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnUbigeo_Properties_ButtonClick);
            this.BtnUbigeo.Size = new System.Drawing.Size(87, 20);
            this.BtnUbigeo.TabIndex = 12;
            this.BtnUbigeo.Enter += new System.EventHandler(this.ObjectEnter);
            this.BtnUbigeo.Leave += new System.EventHandler(this.BtnUbigeo_Leave);
            // 
            // TxtUbigeo
            // 
            this.TxtUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUbigeo.Location = new System.Drawing.Point(181, 189);
            this.TxtUbigeo.MaxLength = 255;
            this.TxtUbigeo.Name = "TxtUbigeo";
            this.TxtUbigeo.ReadOnly = true;
            this.TxtUbigeo.Size = new System.Drawing.Size(296, 20);
            this.TxtUbigeo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nro. &Fijo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ca&tegoría:";
            // 
            // TxtFijo
            // 
            this.TxtFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFijo.Location = new System.Drawing.Point(320, 245);
            this.TxtFijo.MaxLength = 15;
            this.TxtFijo.Name = "TxtFijo";
            this.TxtFijo.Size = new System.Drawing.Size(157, 20);
            this.TxtFijo.TabIndex = 19;
            this.TxtFijo.Enter += new System.EventHandler(this.ObjectEnter);
            this.TxtFijo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // CboCondicion
            // 
            this.CboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCondicion.FormattingEnabled = true;
            this.CboCondicion.Location = new System.Drawing.Point(88, 271);
            this.CboCondicion.Name = "CboCondicion";
            this.CboCondicion.Size = new System.Drawing.Size(389, 21);
            this.CboCondicion.TabIndex = 21;
            this.CboCondicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(88, 296);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(389, 21);
            this.CboCategoria.TabIndex = 23;
            this.CboCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Object_KeyDown);
            // 
            // GrpSubDependencia
            // 
            this.GrpSubDependencia.BackColor = System.Drawing.Color.Transparent;
            this.GrpSubDependencia.Controls.Add(this.EdCodSubDep);
            this.GrpSubDependencia.Controls.Add(this.TxtSubDependencia);
            this.GrpSubDependencia.Controls.Add(this.TxtDependencia);
            this.GrpSubDependencia.Location = new System.Drawing.Point(0, 323);
            this.GrpSubDependencia.Name = "GrpSubDependencia";
            this.GrpSubDependencia.Size = new System.Drawing.Size(479, 74);
            this.GrpSubDependencia.TabIndex = 24;
            this.GrpSubDependencia.TabStop = false;
            this.GrpSubDependencia.Text = "Datos de SubDependencia al que se encuentra Asignado";
            // 
            // EdCodSubDep
            // 
            this.EdCodSubDep.EditValue = "000";
            this.EdCodSubDep.EnterMoveNextControl = true;
            this.EdCodSubDep.Location = new System.Drawing.Point(5, 18);
            this.EdCodSubDep.Name = "EdCodSubDep";
            this.EdCodSubDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EdCodSubDep.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.EdCodSubDep.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EdCodSubDep.Properties.Mask.BeepOnError = true;
            this.EdCodSubDep.Properties.Mask.EditMask = "LLLl";
            this.EdCodSubDep.Properties.Mask.SaveLiteral = false;
            this.EdCodSubDep.Properties.MaxLength = 15;
            this.EdCodSubDep.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EdCodSubDep_Properties_ButtonClick);
            this.EdCodSubDep.Size = new System.Drawing.Size(65, 20);
            this.EdCodSubDep.TabIndex = 0;
            this.EdCodSubDep.Leave += new System.EventHandler(this.EdCodSubDep_Leave);
            // 
            // TxtSubDependencia
            // 
            this.TxtSubDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubDependencia.Location = new System.Drawing.Point(79, 18);
            this.TxtSubDependencia.Name = "TxtSubDependencia";
            this.TxtSubDependencia.ReadOnly = true;
            this.TxtSubDependencia.Size = new System.Drawing.Size(394, 20);
            this.TxtSubDependencia.TabIndex = 1;
            this.TxtSubDependencia.TabStop = false;
            // 
            // TxtDependencia
            // 
            this.TxtDependencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDependencia.Location = new System.Drawing.Point(79, 44);
            this.TxtDependencia.Name = "TxtDependencia";
            this.TxtDependencia.ReadOnly = true;
            this.TxtDependencia.Size = new System.Drawing.Size(394, 20);
            this.TxtDependencia.TabIndex = 2;
            this.TxtDependencia.TabStop = false;
            // 
            // BtnImportarSunat
            // 
            this.BtnImportarSunat.Image = global::Certifica_logistica.Properties.Resources.sunat_small1;
            this.BtnImportarSunat.Location = new System.Drawing.Point(230, 46);
            this.BtnImportarSunat.Name = "BtnImportarSunat";
            this.BtnImportarSunat.Size = new System.Drawing.Size(111, 30);
            this.BtnImportarSunat.TabIndex = 25;
            this.BtnImportarSunat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipController1.SetToolTip(this.BtnImportarSunat, "Importar Datos de SUNAT (Requiere Conexión a Internet)");
            this.BtnImportarSunat.UseVisualStyleBackColor = true;
            this.BtnImportarSunat.Click += new System.EventHandler(this.BtnImportarSunat_Click);
            // 
            // BtnImportarMTC
            // 
            this.BtnImportarMTC.Location = new System.Drawing.Point(347, 46);
            this.BtnImportarMTC.Name = "BtnImportarMTC";
            this.BtnImportarMTC.Size = new System.Drawing.Size(49, 30);
            this.BtnImportarMTC.TabIndex = 26;
            this.BtnImportarMTC.Text = "MTC";
            this.toolTipController1.SetToolTip(this.BtnImportarMTC, "Importar Datos Online de MTC");
            this.BtnImportarMTC.UseVisualStyleBackColor = true;
            this.BtnImportarMTC.Visible = false;
            // 
            // BtnImportarReniec
            // 
            this.BtnImportarReniec.Location = new System.Drawing.Point(402, 46);
            this.BtnImportarReniec.Name = "BtnImportarReniec";
            this.BtnImportarReniec.Size = new System.Drawing.Size(71, 30);
            this.BtnImportarReniec.TabIndex = 27;
            this.BtnImportarReniec.Text = "RENIEC";
            this.toolTipController1.SetToolTip(this.BtnImportarReniec, "Importar Datos ONLINE de RENIEC");
            this.BtnImportarReniec.UseVisualStyleBackColor = true;
            this.BtnImportarReniec.Click += new System.EventHandler(this.BtnImportarReniec_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // FmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 405);
            this.Controls.Add(this.BtnImportarReniec);
            this.Controls.Add(this.BtnImportarMTC);
            this.Controls.Add(this.BtnImportarSunat);
            this.Controls.Add(this.GrpSubDependencia);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.CboCondicion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFijo);
            this.Controls.Add(this.TxtUbigeo);
            this.Controls.Add(this.BtnUbigeo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMovil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNroDoc);
            this.Controls.Add(this.CboTDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdCodPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmPersonal";
            this.Text = "Mantenimiento Ficha de Personal Institucional";
            this.Load += new System.EventHandler(this.FmPersonal_Load);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.EdCodPersonal, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtApellidos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtNombres, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtDireccion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.CboTDoc, 0);
            this.Controls.SetChildIndex(this.TxtNroDoc, 0);
            this.Controls.SetChildIndex(this.TxtEmail, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtMovil, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.BtnUbigeo, 0);
            this.Controls.SetChildIndex(this.TxtUbigeo, 0);
            this.Controls.SetChildIndex(this.TxtFijo, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.CboCondicion, 0);
            this.Controls.SetChildIndex(this.CboCategoria, 0);
            this.Controls.SetChildIndex(this.GrpSubDependencia, 0);
            this.Controls.SetChildIndex(this.BtnImportarSunat, 0);
            this.Controls.SetChildIndex(this.BtnImportarMTC, 0);
            this.Controls.SetChildIndex(this.BtnImportarReniec, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUbigeo.Properties)).EndInit();
            this.GrpSubDependencia.ResumeLayout(false);
            this.GrpSubDependencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdCodSubDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit EdCodPersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboTDoc;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMovil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.ButtonEdit BtnUbigeo;
        private System.Windows.Forms.TextBox TxtUbigeo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFijo;
        private System.Windows.Forms.ComboBox CboCondicion;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.GroupBox GrpSubDependencia;
        private DevExpress.XtraEditors.ButtonEdit EdCodSubDep;
        private System.Windows.Forms.TextBox TxtSubDependencia;
        private System.Windows.Forms.TextBox TxtDependencia;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.Button BtnImportarMTC;
        private System.Windows.Forms.Button BtnImportarSunat;
        private System.Windows.Forms.Button BtnImportarReniec;
    }
}
