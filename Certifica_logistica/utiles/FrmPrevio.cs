using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Certifica_logistica.utiles
{
    public partial class FrmPrevio : Form
    {
        public ReportDocument RptDoc;
        public FrmPrevio()
        {
            InitializeComponent();
        }

        private void frm_imprimir_Load(object sender, EventArgs e)
        {
            if(RptDoc != null)
                crystalReportViewer1.ReportSource = RptDoc;
        }

        private void fuRprevio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
