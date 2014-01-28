namespace Certifica_logistica.utiles
{
    partial class frm_clave
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtClaveNueva2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtClaveNueva1 = new System.Windows.Forms.TextBox();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TxtClaveNueva2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtClave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtClaveNueva1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCambiar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(258, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtClaveNueva2
            // 
            this.TxtClaveNueva2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClaveNueva2.Location = new System.Drawing.Point(154, 97);
            this.TxtClaveNueva2.Name = "TxtClaveNueva2";
            this.TxtClaveNueva2.PasswordChar = '*';
            this.TxtClaveNueva2.Size = new System.Drawing.Size(146, 20);
            this.TxtClaveNueva2.TabIndex = 7;
            this.TxtClaveNueva2.UseSystemPasswordChar = true;
            this.TxtClaveNueva2.Enter += new System.EventHandler(this.Control_Enter);
            this.TxtClaveNueva2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password Anterior";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLogin.Location = new System.Drawing.Point(154, 3);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.ReadOnly = true;
            this.TxtLogin.Size = new System.Drawing.Size(146, 20);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.Enter += new System.EventHandler(this.Control_Enter);
            this.TxtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // TxtClave
            // 
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.Location = new System.Drawing.Point(154, 36);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '-';
            this.TxtClave.Size = new System.Drawing.Size(146, 20);
            this.TxtClave.TabIndex = 3;
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.Enter += new System.EventHandler(this.Control_Enter);
            this.TxtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // TxtClaveNueva1
            // 
            this.TxtClaveNueva1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClaveNueva1.Location = new System.Drawing.Point(154, 69);
            this.TxtClaveNueva1.Name = "TxtClaveNueva1";
            this.TxtClaveNueva1.PasswordChar = '*';
            this.TxtClaveNueva1.Size = new System.Drawing.Size(146, 20);
            this.TxtClaveNueva1.TabIndex = 5;
            this.TxtClaveNueva1.UseSystemPasswordChar = true;
            this.TxtClaveNueva1.Enter += new System.EventHandler(this.Control_Enter);
            this.TxtClaveNueva1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCambiar.Location = new System.Drawing.Point(3, 136);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(145, 27);
            this.BtnCambiar.TabIndex = 8;
            this.BtnCambiar.Text = "&Aceptar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelar.Location = new System.Drawing.Point(154, 136);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(146, 27);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repita Password Nuevo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password Nuevo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(573, 178);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "frm_clave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Clave [Usuario: ]";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtClaveNueva2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtClaveNueva1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Button BtnCancelar;

    }
}