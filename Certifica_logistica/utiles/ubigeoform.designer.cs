namespace Certifica_logistica.utiles
{
    partial class Ubigeoform
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboCodDep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCodProv = new System.Windows.Forms.ComboBox();
            this.CboCoddis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Departamento";
            // 
            // CboCodDep
            // 
            this.CboCodDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodDep.FormattingEnabled = true;
            this.CboCodDep.Location = new System.Drawing.Point(95, 12);
            this.CboCodDep.Name = "CboCodDep";
            this.CboCodDep.Size = new System.Drawing.Size(155, 21);
            this.CboCodDep.TabIndex = 3;
            this.CboCodDep.Leave += new System.EventHandler(this.CboCodDep_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Provincia";
            // 
            // CboCodProv
            // 
            this.CboCodProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCodProv.FormattingEnabled = true;
            this.CboCodProv.Location = new System.Drawing.Point(95, 51);
            this.CboCodProv.Name = "CboCodProv";
            this.CboCodProv.Size = new System.Drawing.Size(155, 21);
            this.CboCodProv.TabIndex = 5;
            this.CboCodProv.Leave += new System.EventHandler(this.CboCodProv_Leave);
            // 
            // CboCoddis
            // 
            this.CboCoddis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCoddis.FormattingEnabled = true;
            this.CboCoddis.Location = new System.Drawing.Point(95, 88);
            this.CboCoddis.Name = "CboCoddis";
            this.CboCoddis.Size = new System.Drawing.Size(155, 21);
            this.CboCoddis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dis&trito";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(50, 124);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(147, 124);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ubigeoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(261, 158);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.CboCoddis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboCodProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboCodDep);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ubigeoform";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Ubigeo";
            this.Shown += new System.EventHandler(this.ubigeoform_Shown);
            this.Load += new System.EventHandler(this.ubigeoform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCodDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCodProv;
        private System.Windows.Forms.ComboBox CboCoddis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}