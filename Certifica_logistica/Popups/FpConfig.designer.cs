namespace Certifica_logistica.Popups
{
    partial class FpConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FpConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MskPuerto = new System.Windows.Forms.MaskedTextBox();
            this.MskPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.MskServerUpdate = new System.Windows.Forms.MaskedTextBox();
            this.MskServerBD = new System.Windows.Forms.MaskedTextBox();
            this.TxtCatalogo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Image = global::Certifica_logistica.Properties.Resources.process_48;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Size = new System.Drawing.Size(270, 27);
            this.LblTitulo.Text = " Parametros Del Sistema";
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(406, 43);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.MskPuerto);
            this.groupBox1.Controls.Add(this.MskPeriodo);
            this.groupBox1.Controls.Add(this.MskServerUpdate);
            this.groupBox1.Controls.Add(this.MskServerBD);
            this.groupBox1.Controls.Add(this.TxtCatalogo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "< Datos Sensibles - Grabe y Pruebe Antes de Cerrar esta Ventana >";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Resetear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MskPuerto
            // 
            this.MskPuerto.Location = new System.Drawing.Point(312, 85);
            this.MskPuerto.Mask = "00000";
            this.MskPuerto.Name = "MskPuerto";
            this.MskPuerto.Size = new System.Drawing.Size(47, 20);
            this.MskPuerto.TabIndex = 7;
            // 
            // MskPeriodo
            // 
            this.MskPeriodo.Location = new System.Drawing.Point(94, 32);
            this.MskPeriodo.Mask = "0000-00";
            this.MskPeriodo.Name = "MskPeriodo";
            this.MskPeriodo.Size = new System.Drawing.Size(64, 20);
            this.MskPeriodo.TabIndex = 1;
            this.MskPeriodo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MskServerUpdate
            // 
            this.MskServerUpdate.Location = new System.Drawing.Point(245, 125);
            this.MskServerUpdate.Mask = "000.000.000.000";
            this.MskServerUpdate.Name = "MskServerUpdate";
            this.MskServerUpdate.Size = new System.Drawing.Size(111, 20);
            this.MskServerUpdate.TabIndex = 9;
            // 
            // MskServerBD
            // 
            this.MskServerBD.Location = new System.Drawing.Point(141, 89);
            this.MskServerBD.Mask = "000.000.000.000";
            this.MskServerBD.Name = "MskServerBD";
            this.MskServerBD.Size = new System.Drawing.Size(100, 20);
            this.MskServerBD.TabIndex = 5;
            // 
            // TxtCatalogo
            // 
            this.TxtCatalogo.Location = new System.Drawing.Point(94, 55);
            this.TxtCatalogo.Name = "TxtCatalogo";
            this.TxtCatalogo.Size = new System.Drawing.Size(147, 20);
            this.TxtCatalogo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Servidor de Actualizaciones por Defecto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puerto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catalogo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo :";
            // 
            // FpConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(406, 220);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FpConfig";
            this.Text = "Parametros del Sistema";
            this.Load += new System.EventHandler(this.FpConfig_Load);
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox MskPuerto;
        private System.Windows.Forms.MaskedTextBox MskPeriodo;
        private System.Windows.Forms.MaskedTextBox MskServerUpdate;
        private System.Windows.Forms.MaskedTextBox MskServerBD;
        private System.Windows.Forms.TextBox TxtCatalogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}
