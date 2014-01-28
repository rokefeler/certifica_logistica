namespace Certifica_logistica.procesos
{
    partial class FpOrdenLogistica
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
            this.GrpDocumento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtFolios = new System.Windows.Forms.TextBox();
            this.TxtCcp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.pan1.SuspendLayout();
            this.GrpDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.Size = new System.Drawing.Size(722, 43);
            // 
            // GrpDocumento
            // 
            this.GrpDocumento.Controls.Add(this.label4);
            this.GrpDocumento.Controls.Add(this.TxtNroDoc);
            this.GrpDocumento.Controls.Add(this.CboTipoUsuario);
            this.GrpDocumento.Controls.Add(this.label6);
            this.GrpDocumento.Controls.Add(this.TxtAsunto);
            this.GrpDocumento.Controls.Add(this.label11);
            this.GrpDocumento.Controls.Add(this.label14);
            this.GrpDocumento.Controls.Add(this.TxtFolios);
            this.GrpDocumento.Controls.Add(this.TxtCcp);
            this.GrpDocumento.Controls.Add(this.label12);
            this.GrpDocumento.Location = new System.Drawing.Point(3, 49);
            this.GrpDocumento.Name = "GrpDocumento";
            this.GrpDocumento.Size = new System.Drawing.Size(653, 61);
            this.GrpDocumento.TabIndex = 5;
            this.GrpDocumento.TabStop = false;
            this.GrpDocumento.Text = "Datos del Documento Ingresado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroDoc.Location = new System.Drawing.Point(160, 33);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(128, 20);
            this.TxtNroDoc.TabIndex = 6;
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTipoUsuario.FormattingEnabled = true;
            this.CboTipoUsuario.Items.AddRange(new object[] {
            "ALUMNO",
            "PERSONAL",
            "PROVEEDOR",
            "NINGUNO"});
            this.CboTipoUsuario.Location = new System.Drawing.Point(5, 32);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(152, 21);
            this.CboTipoUsuario.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de Documento";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAsunto.Location = new System.Drawing.Point(294, 33);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(253, 20);
            this.TxtAsunto.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Asunto o Referencia de Requerimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(593, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "C.C.P.";
            // 
            // TxtFolios
            // 
            this.TxtFolios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFolios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFolios.Location = new System.Drawing.Point(555, 33);
            this.TxtFolios.Name = "TxtFolios";
            this.TxtFolios.Size = new System.Drawing.Size(31, 20);
            this.TxtFolios.TabIndex = 10;
            // 
            // TxtCcp
            // 
            this.TxtCcp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCcp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCcp.Location = new System.Drawing.Point(596, 33);
            this.TxtCcp.Name = "TxtCcp";
            this.TxtCcp.Size = new System.Drawing.Size(48, 20);
            this.TxtCcp.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Folios";
            // 
            // FpOrdenLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(722, 414);
            this.Controls.Add(this.GrpDocumento);
            this.Name = "FpOrdenLogistica";
            this.Controls.SetChildIndex(this.pan1, 0);
            this.Controls.SetChildIndex(this.GrpDocumento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.GrpDocumento.ResumeLayout(false);
            this.GrpDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtFolios;
        private System.Windows.Forms.TextBox TxtCcp;
        private System.Windows.Forms.Label label12;
    }
}
