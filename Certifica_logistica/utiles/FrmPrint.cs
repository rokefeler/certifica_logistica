using System;
using System.Windows.Forms;

namespace Certifica_logistica.utiles
{
    public partial class FrmPrint : Form
    {
        public int _nCopias;
        public FrmPrint()
        {
            InitializeComponent();
        }

        private void frm_print_Load(object sender, EventArgs e)
        {
            _nCopias = 0;
            Spn_NCopias.Select(0, Spn_NCopias.Value.ToString().Length);
            Spn_NCopias.Focus();
            SendKeys.Send("{HOME}+{END}");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            _nCopias = Convert.ToInt32( Spn_NCopias.Value );
            Hide();
        }
    }
}
