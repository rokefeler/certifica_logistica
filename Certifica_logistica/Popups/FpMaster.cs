using System;
using System.Drawing;
using System.Windows.Forms;

namespace Certifica_logistica.Popups
{
    public partial class FpMaster : Form
    {
// ReSharper disable once InconsistentNaming
        public string _Codigo;
        public string _Nombre;
// ReSharper disable once InconsistentNaming
        public Color _backColor;
        public String _TiTuloForm;

        public FpMaster()
        {
            InitializeComponent();

        }
        public virtual void GrabarFormulario()
        {
            return ;
        }
        public virtual void CancelarFormulario()
        {
            return ;
        }
      
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            GrabarFormulario();
            Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CancelarFormulario();
            _Codigo = String.Empty;
            Hide();
        }

        private void FpMaster_Load(object sender, EventArgs e)
        {
            panel1.BackColor  = _backColor;
            panel2.BackColor = _backColor;
            _Codigo = string.Empty;
            Text = _TiTuloForm;
        }
    }
}
