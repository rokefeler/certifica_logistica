namespace Certifica_logistica.mantenimiento
{
    partial class FmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUltimoAcceso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPreg01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPreg02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodLogin_Ori = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboEstado = new System.Windows.Forms.ComboBox();
            this.TxtCodPersonal = new DevExpress.XtraEditors.ButtonEdit();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSetClave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodPersonal.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.login48;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(330, 27);
            this.LblTitulo.Text = "Ficha de Usuarios del Sistema";
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(488, 43);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Location = new System.Drawing.Point(84, 54);
            this.TxtLogin.MaxLength = 15;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(100, 20);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.Enter += new System.EventHandler(this.ObjEnter);
            this.TxtLogin.Leave += new System.EventHandler(this.TxtLogin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal:";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(84, 106);
            this.TxtClave.MaxLength = 128;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(100, 20);
            this.TxtClave.TabIndex = 6;
            this.TxtClave.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave:";
            // 
            // TxtUltimoAcceso
            // 
            this.TxtUltimoAcceso.Location = new System.Drawing.Point(83, 38);
            this.TxtUltimoAcceso.Name = "TxtUltimoAcceso";
            this.TxtUltimoAcceso.ReadOnly = true;
            this.TxtUltimoAcceso.Size = new System.Drawing.Size(142, 20);
            this.TxtUltimoAcceso.TabIndex = 3;
            this.TxtUltimoAcceso.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ultimo Acceso:";
            // 
            // TxtPreg01
            // 
            this.TxtPreg01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPreg01.Location = new System.Drawing.Point(84, 132);
            this.TxtPreg01.MaxLength = 70;
            this.TxtPreg01.Name = "TxtPreg01";
            this.TxtPreg01.Size = new System.Drawing.Size(387, 20);
            this.TxtPreg01.TabIndex = 9;
            this.TxtPreg01.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pregunta 01:";
            // 
            // TxtPreg02
            // 
            this.TxtPreg02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPreg02.Location = new System.Drawing.Point(84, 158);
            this.TxtPreg02.MaxLength = 70;
            this.TxtPreg02.Name = "TxtPreg02";
            this.TxtPreg02.Size = new System.Drawing.Size(387, 20);
            this.TxtPreg02.TabIndex = 11;
            this.TxtPreg02.Enter += new System.EventHandler(this.ObjEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pregunta 02:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // TxtCodLogin_Ori
            // 
            this.TxtCodLogin_Ori.Location = new System.Drawing.Point(83, 7);
            this.TxtCodLogin_Ori.Name = "TxtCodLogin_Ori";
            this.TxtCodLogin_Ori.ReadOnly = true;
            this.TxtCodLogin_Ori.Size = new System.Drawing.Size(142, 20);
            this.TxtCodLogin_Ori.TabIndex = 1;
            this.TxtCodLogin_Ori.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Creado por:";
            // 
            // CboEstado
            // 
            this.CboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstado.FormattingEnabled = true;
            this.CboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "BLOQUEADO",
            "SUSPENDIDO"});
            this.CboEstado.Location = new System.Drawing.Point(84, 184);
            this.CboEstado.Name = "CboEstado";
            this.CboEstado.Size = new System.Drawing.Size(142, 21);
            this.CboEstado.TabIndex = 13;
            // 
            // TxtCodPersonal
            // 
            this.TxtCodPersonal.Location = new System.Drawing.Point(84, 80);
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
            this.TxtCodPersonal.Size = new System.Drawing.Size(100, 20);
            this.TxtCodPersonal.TabIndex = 3;
            this.TxtCodPersonal.Enter += new System.EventHandler(this.ObjEnter);
            this.TxtCodPersonal.Leave += new System.EventHandler(this.TxtCodPersonal_Leave);
            this.TxtCodPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodPersonal_Validating);
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(190, 80);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(281, 20);
            this.TxtRazonSocial.TabIndex = 4;
            this.TxtRazonSocial.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtUltimoAcceso);
            this.panel1.Controls.Add(this.TxtCodLogin_Ori);
            this.panel1.Location = new System.Drawing.Point(3, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 75);
            this.panel1.TabIndex = 14;
            // 
            // BtnSetClave
            // 
            this.BtnSetClave.Location = new System.Drawing.Point(190, 104);
            this.BtnSetClave.Name = "BtnSetClave";
            this.BtnSetClave.Size = new System.Drawing.Size(75, 23);
            this.BtnSetClave.TabIndex = 7;
            this.BtnSetClave.Text = "Set Clave";
            this.BtnSetClave.UseVisualStyleBackColor = true;
            this.BtnSetClave.Click += new System.EventHandler(this.BtnSetClave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(488, 295);
            this.Controls.Add(this.BtnSetClave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtRazonSocial);
            this.Controls.Add(this.TxtCodPersonal);
            this.Controls.Add(this.CboEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPreg02);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPreg01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label1);
            this.Name = "FmLogin";
            this.Text = "Ficha de Usuarios del Sistema";
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtLogin, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtClave, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtPreg01, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtPreg02, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.CboEstado, 0);
            this.Controls.SetChildIndex(this.TxtCodPersonal, 0);
            this.Controls.SetChildIndex(this.TxtRazonSocial, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.BtnSetClave, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodPersonal.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUltimoAcceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPreg01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPreg02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCodLogin_Ori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboEstado;
        private DevExpress.XtraEditors.ButtonEdit TxtCodPersonal;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSetClave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
