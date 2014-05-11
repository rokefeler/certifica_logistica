using System;
using Certifica_logistica.modulos;

namespace Certifica_logistica.Popups
{
    public partial class FpConfig : Certifica_logistica.Masterform
    {
        public FpConfig()
        {
            InitializeComponent();
        }

        private void FpConfig_Load(object sender, EventArgs e)
        {
            MskPeriodo.Text = _FrmPadre.Miconfiguracion.PeriodoActual;
            TxtCatalogo.Text = CONSTANTE.Catalogo;
            MskServerBD.Text = Properties.Settings.Default.IpServer;
            MskPuerto.Text = CONSTANTE.Puerto;
            MskServerUpdate.Text = Properties.Settings.Default.Server_Updates;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

    }
}
