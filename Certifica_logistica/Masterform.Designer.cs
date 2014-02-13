namespace Certifica_logistica
{
    partial class Masterform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool _haveRun; 

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
            this.pan1 = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.DarkRed;
            this.pan1.Controls.Add(this.pic1);
            this.pan1.Controls.Add(this.LblTitulo);
            this.pan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan1.Location = new System.Drawing.Point(0, 0);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(545, 43);
            this.pan1.TabIndex = 0;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(3, 0);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(53, 43);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Tag = "0";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.LavenderBlush;
            this.LblTitulo.Location = new System.Drawing.Point(61, 4);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(198, 27);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Titulo de Ventana";
            // 
            // Masterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.pan1);
            this.Name = "Masterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "masterform";
            this.Activated += new System.EventHandler(this.Masterform_Activated);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pic1;
        protected System.Windows.Forms.Label LblTitulo;
        protected System.Windows.Forms.Panel pan1;
    }
}