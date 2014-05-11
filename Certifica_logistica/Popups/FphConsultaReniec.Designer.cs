using CertificaUtils;

namespace Certifica_logistica.Popups
{
    partial class FphConsultaReniec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FphConsultaReniec));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblResul = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdReloadCapcha = new System.Windows.Forms.Button();
            this.pictureCapcha = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDni = new Certifica_logistica.controls.MyTextBox();
            this.txtCapcha = new Certifica_logistica.controls.MyTextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Size = new System.Drawing.Size(437, 329);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblResul, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmdConsultar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumDni, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCapcha, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 329);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblResul
            // 
            this.LblResul.AllowDrop = true;
            this.LblResul.AutoSize = true;
            this.LblResul.BackColor = System.Drawing.Color.Silver;
            this.LblResul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResul.ForeColor = System.Drawing.Color.Maroon;
            this.LblResul.Location = new System.Drawing.Point(3, 249);
            this.LblResul.Name = "LblResul";
            this.LblResul.Size = new System.Drawing.Size(431, 80);
            this.LblResul.TabIndex = 6;
            this.LblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.BackColor = System.Drawing.Color.Wheat;
            this.cmdConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdConsultar.Location = new System.Drawing.Point(0, 209);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(437, 40);
            this.cmdConsultar.TabIndex = 5;
            this.cmdConsultar.Text = "Consultar Reniec";
            this.cmdConsultar.UseVisualStyleBackColor = false;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.44654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.55346F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureCapcha, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 125);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 84);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.cmdReloadCapcha, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(355, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(64, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cmdReloadCapcha
            // 
            this.cmdReloadCapcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdReloadCapcha.Image = ((System.Drawing.Image)(resources.GetObject("cmdReloadCapcha.Image")));
            this.cmdReloadCapcha.Location = new System.Drawing.Point(0, 8);
            this.cmdReloadCapcha.Margin = new System.Windows.Forms.Padding(0);
            this.cmdReloadCapcha.Name = "cmdReloadCapcha";
            this.cmdReloadCapcha.Size = new System.Drawing.Size(64, 68);
            this.cmdReloadCapcha.TabIndex = 0;
            this.cmdReloadCapcha.TabStop = false;
            this.cmdReloadCapcha.UseVisualStyleBackColor = true;
            this.cmdReloadCapcha.Click += new System.EventHandler(this.cmdReloadCapcha_Click);
            // 
            // pictureCapcha
            // 
            this.pictureCapcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureCapcha.Location = new System.Drawing.Point(3, 3);
            this.pictureCapcha.Name = "pictureCapcha";
            this.pictureCapcha.Size = new System.Drawing.Size(349, 78);
            this.pictureCapcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCapcha.TabIndex = 1;
            this.pictureCapcha.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE los caracteres de la Imagen :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de DNI :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumDni
            // 
            this.txtNumDni.Apariencia = Certifica_logistica.controls.MyTextBox.Vista.Normal;
            this.txtNumDni.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDni.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumDni.Location = new System.Drawing.Point(3, 23);
            this.txtNumDni.Name = "txtNumDni";
            this.txtNumDni.Size = new System.Drawing.Size(431, 35);
            this.txtNumDni.TabIndex = 1;
            this.txtNumDni.TextChanged += new System.EventHandler(this.txtNumDni_TextChanged);
            this.txtNumDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumDni_KeyDown);
            // 
            // txtCapcha
            // 
            this.txtCapcha.Apariencia = Certifica_logistica.controls.MyTextBox.Vista.Normal;
            this.txtCapcha.BackColor = System.Drawing.SystemColors.Window;
            this.txtCapcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapcha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCapcha.Location = new System.Drawing.Point(3, 87);
            this.txtCapcha.Name = "txtCapcha";
            this.txtCapcha.Size = new System.Drawing.Size(431, 35);
            this.txtCapcha.TabIndex = 3;
            this.txtCapcha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumDni_KeyDown);
            // 
            // FphConsultaReniec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(437, 389);
            this.KeyPreview = false;
            this.Name = "FphConsultaReniec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FphConsultaReniec_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblResul;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button cmdReloadCapcha;
        private System.Windows.Forms.PictureBox pictureCapcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Reniec _myInfo;
        public controls.MyTextBox txtNumDni;
        private controls.MyTextBox txtCapcha;
    }
}
