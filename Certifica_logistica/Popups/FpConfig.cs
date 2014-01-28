using System;

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
            TxtCatalogo.Text = Properties.Settings.Default.Catalogo;
            MskServerBD.Text = Properties.Settings.Default.IpServer;
            MskPuerto.Text = Properties.Settings.Default.PuertoServer;
            MskServerUpdate.Text = Properties.Settings.Default.Server_Updates;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

    }
}
