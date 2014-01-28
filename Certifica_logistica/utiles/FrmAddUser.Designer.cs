namespace Certifica_logistica.utiles
{
    partial class FrmAddUser
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtFono = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtClaveNueva2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClaveNueva1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CboSede = new System.Windows.Forms.ComboBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(809, 34);
            this.LblTitulo.Text = "Agregar Usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.TxtEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtFono, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtDni, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtDireccion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtNombres, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtClaveNueva2, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtClaveNueva1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.CboSede, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtApellidos, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 273);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Location = new System.Drawing.Point(218, 159);
            this.TxtEmail.MaxLength = 90;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(334, 20);
            this.TxtEmail.TabIndex = 13;
            // 
            // TxtFono
            // 
            this.TxtFono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtFono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFono.Location = new System.Drawing.Point(218, 133);
            this.TxtFono.MaxLength = 35;
            this.TxtFono.Name = "TxtFono";
            this.TxtFono.Size = new System.Drawing.Size(334, 20);
            this.TxtFono.TabIndex = 11;
            // 
            // TxtDni
            // 
            this.TxtDni.AcceptsReturn = true;
            this.TxtDni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDni.Location = new System.Drawing.Point(218, 107);
            this.TxtDni.MaxLength = 12;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(334, 20);
            this.TxtDni.TabIndex = 9;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDireccion.Location = new System.Drawing.Point(218, 81);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(334, 20);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDireccion_Validating);
            // 
            // TxtNombres
            // 
            this.TxtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombres.Location = new System.Drawing.Point(218, 55);
            this.TxtNombres.MaxLength = 70;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(334, 20);
            this.TxtNombres.TabIndex = 5;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // TxtClaveNueva2
            // 
            this.TxtClaveNueva2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtClaveNueva2.Location = new System.Drawing.Point(218, 238);
            this.TxtClaveNueva2.Name = "TxtClaveNueva2";
            this.TxtClaveNueva2.PasswordChar = '*';
            this.TxtClaveNueva2.Size = new System.Drawing.Size(334, 20);
            this.TxtClaveNueva2.TabIndex = 21;
            this.TxtClaveNueva2.UseSystemPasswordChar = true;
            this.TxtClaveNueva2.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClaveNueva2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login de Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtClaveNueva1
            // 
            this.TxtClaveNueva1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtClaveNueva1.Location = new System.Drawing.Point(218, 212);
            this.TxtClaveNueva1.Name = "TxtClaveNueva1";
            this.TxtClaveNueva1.PasswordChar = '*';
            this.TxtClaveNueva1.Size = new System.Drawing.Size(334, 20);
            this.TxtClaveNueva1.TabIndex = 19;
            this.TxtClaveNueva1.UseSystemPasswordChar = true;
            this.TxtClaveNueva1.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClaveNueva1_Validating);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Repita Password Nuevo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password Nuevo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellidos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Documento de Identidad";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Teléfono";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Sede";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CboSede
            // 
            this.CboSede.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.CboSede.FormattingEnabled = true;
            this.CboSede.Location = new System.Drawing.Point(218, 185);
            this.CboSede.Name = "CboSede";
            this.CboSede.Size = new System.Drawing.Size(248, 21);
            this.CboSede.TabIndex = 15;
            // 
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Location = new System.Drawing.Point(218, 3);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(132, 20);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLogin_Validating);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellidos.Location = new System.Drawing.Point(218, 29);
            this.TxtApellidos.MaxLength = 70;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(334, 20);
            this.TxtApellidos.TabIndex = 3;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 316);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAddUser";
            this.Text = "Agregar Usuario al Sistema";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtClaveNueva2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtClaveNueva1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtFono;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboSede;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}