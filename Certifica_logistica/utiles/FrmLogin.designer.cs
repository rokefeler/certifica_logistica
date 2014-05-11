namespace Certifica_logistica.utiles
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id_user = new System.Windows.Forms.TextBox();
            this.Txt_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Usuario:";
            // 
            // Txt_id_user
            // 
            this.Txt_id_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_id_user.Location = new System.Drawing.Point(244, 20);
            this.Txt_id_user.MaxLength = 12;
            this.Txt_id_user.Name = "Txt_id_user";
            this.Txt_id_user.Size = new System.Drawing.Size(182, 20);
            this.Txt_id_user.TabIndex = 1;
            this.Txt_id_user.Enter += new System.EventHandler(this.Control_Enter);
            this.Txt_id_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // Txt_pwd
            // 
            this.Txt_pwd.Location = new System.Drawing.Point(244, 64);
            this.Txt_pwd.Name = "Txt_pwd";
            this.Txt_pwd.Size = new System.Drawing.Size(182, 20);
            this.Txt_pwd.TabIndex = 3;
            this.Txt_pwd.UseSystemPasswordChar = true;
            this.Txt_pwd.Enter += new System.EventHandler(this.Control_Enter);
            this.Txt_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Con&traseña";
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Location = new System.Drawing.Point(244, 95);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(88, 29);
            this.Btn_Validar.TabIndex = 4;
            this.Btn_Validar.Text = "&Validar";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(338, 95);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(88, 29);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "&Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(427, 132);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.Txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id_user);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificación de Usuario";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id_user;
        private System.Windows.Forms.TextBox Txt_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Validar;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}