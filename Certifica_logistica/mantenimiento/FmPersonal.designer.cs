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
            this.TxtCodPersonal = new DevExpress.XtraEditors.ButtonEdit();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUbigeo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.TxtApellidos.Location = new System.Drawing.Point(88, 75);
            this.TxtApellidos.MaxLength = 35;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(389, 20);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.Enter += new System.EventHandler(this.ObjEnter);
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
            // TxtCodPersonal
            // 
            this.TxtCodPersonal.Location = new System.Drawing.Point(88, 49);
            this.TxtCodPersonal.Name = "TxtCodPersonal";
            this.TxtCodPersonal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtCodPersonal.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.TxtCodPersonal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodPersonal.Properties.Mask.BeepOnError = true;
            this.TxtCodPersonal.Properties.Mask.EditMask = "99999999";
            this.TxtCodPersonal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtCodPersonal.Properties.MaxLength = 15;
            this.TxtCodPersonal.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtCodPersonal_Properties_ButtonClick);
            this.TxtCodPersonal.Size = new System.Drawing.Size(127, 20);
            this.TxtCodPersonal.TabIndex = 1;
            this.TxtCodPersonal.Enter += new System.EventHandler(this.ObjEnter);
            this.TxtCodPersonal.Leave += new System.EventHandler(this.TxtCodPersonal_Leave);
            this.TxtCodPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodPersonal_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Nombres:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombres.Location = new System.Drawing.Point(88, 101);
            this.TxtNombres.MaxLength = 35;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(389, 20);
            this.TxtNombres.TabIndex = 5;
            this.TxtNombres.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "D&irección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Location = new System.Drawing.Point(88, 157);
            this.TxtDireccion.MaxLength = 70;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(389, 20);
            this.TxtDireccion.TabIndex = 10;
            this.TxtDireccion.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Doc. Identidad:";
            // 
            // CboTDoc
            // 
            this.CboTDoc.FormattingEnabled = true;
            this.CboTDoc.Location = new System.Drawing.Point(88, 129);
            this.CboTDoc.Name = "CboTDoc";
            this.CboTDoc.Size = new System.Drawing.Size(177, 21);
            this.CboTDoc.TabIndex = 7;
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroDoc.Location = new System.Drawing.Point(271, 129);
            this.TxtNroDoc.MaxLength = 15;
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(206, 20);
            this.TxtNroDoc.TabIndex = 8;
            this.TxtNroDoc.Enter += new System.EventHandler(this.ObjEnter);
            this.TxtNroDoc.Leave += new System.EventHandler(this.TxtNroDoc_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "&Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Location = new System.Drawing.Point(88, 214);
            this.TxtEmail.MaxLength = 70;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(389, 20);
            this.TxtEmail.TabIndex = 15;
            this.TxtEmail.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nro. &Móvil:";
            // 
            // TxtMovil
            // 
            this.TxtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMovil.Location = new System.Drawing.Point(88, 240);
            this.TxtMovil.MaxLength = 15;
            this.TxtMovil.Name = "TxtMovil";
            this.TxtMovil.Size = new System.Drawing.Size(177, 20);
            this.TxtMovil.TabIndex = 17;
            this.TxtMovil.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "C&ondición:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ubi&geo:";
            // 
            // BtnUbigeo
            // 
            this.BtnUbigeo.Location = new System.Drawing.Point(88, 184);
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
            this.BtnUbigeo.Enter += new System.EventHandler(this.ObjEnter);
            this.BtnUbigeo.Leave += new System.EventHandler(this.BtnUbigeo_Leave);
            // 
            // TxtUbigeo
            // 
            this.TxtUbigeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtUbigeo.Location = new System.Drawing.Point(181, 184);
            this.TxtUbigeo.MaxLength = 255;
            this.TxtUbigeo.Name = "TxtUbigeo";
            this.TxtUbigeo.ReadOnly = true;
            this.TxtUbigeo.Size = new System.Drawing.Size(296, 20);
            this.TxtUbigeo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nro. &Fijo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ca&tegoría:";
            // 
            // TxtFijo
            // 
            this.TxtFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFijo.Location = new System.Drawing.Point(320, 240);
            this.TxtFijo.MaxLength = 15;
            this.TxtFijo.Name = "TxtFijo";
            this.TxtFijo.Size = new System.Drawing.Size(157, 20);
            this.TxtFijo.TabIndex = 19;
            this.TxtFijo.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // CboCondicion
            // 
            this.CboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCondicion.FormattingEnabled = true;
            this.CboCondicion.Location = new System.Drawing.Point(88, 266);
            this.CboCondicion.Name = "CboCondicion";
            this.CboCondicion.Size = new System.Drawing.Size(389, 21);
            this.CboCondicion.TabIndex = 21;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(88, 291);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(389, 21);
            this.CboCategoria.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(179, 23);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(97, 23);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.buttonEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.buttonEdit1.Properties.Mask.BeepOnError = true;
            this.buttonEdit1.Properties.Mask.EditMask = "999999";
            this.buttonEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.buttonEdit1.Properties.MaxLength = 15;
            this.buttonEdit1.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnUbigeo_Properties_ButtonClick);
            this.buttonEdit1.Size = new System.Drawing.Size(76, 20);
            this.buttonEdit1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "SubDependencia:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(97, 49);
            this.textBox2.MaxLength = 255;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(372, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Dependencia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEdit1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(2, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 83);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dependencia & SubDependencia Al que esta Asignado";
            // 
            // FmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 404);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.TxtCodPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmPersonal";
            this.Text = "Mantenimiento Ficha de Personal Institucional";
            this.Load += new System.EventHandler(this.FmPersonal_Load);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.TxtCodPersonal, 0);
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
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUbigeo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ButtonEdit TxtCodPersonal;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}
