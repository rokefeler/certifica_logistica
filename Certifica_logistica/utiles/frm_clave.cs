using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.utiles
{
    // ReSharper disable InconsistentNaming
    public partial class frm_clave : Form
    {
        public bool _estado; 
        public Inicioform _FrmPadre;
        // ReSharper disable once NotAccessedField.Local
        private int _contador;

        public frm_clave()
        {
            InitializeComponent();
            _estado = false;
            _FrmPadre = null;
            _contador = 0;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\llave.jpg");
        }

        public void Login(string id_user)
        {
            TxtLogin.Text = id_user;
            Text = @"Cambiar Clave [" + id_user  + @" ]";
        }
        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            ValidaCambioDeClave();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            _estado = false;
            Hide();
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            string tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "System.Windows.Forms.TextBox":
                    var Txt2 = (TextBox)sender;
                    Txt2.SelectAll();
                    break;
                case "System.Windows.Forms.MaskedTextBox":
                    SendKeys.Send("{HOME}+{END}");
                    break;
            }
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void ValidaCambioDeClave()
        {
            Login log;
            var user = TxtLogin.Text.Trim();
            var pwd = TxtClave.Text.Trim();
            var pwd1 = TxtClaveNueva1.Text.Trim();
            var pwd2 = TxtClaveNueva2.Text.Trim();
            try
            {
                log = LoginDao.GetbyId(user);
            }
            catch (SqlException ee)
            {
                if (ee.Number == 10060 || ee.Number == 10061)
                {
                    Properties.Settings.Default.IpServer = "";
                    Properties.Settings.Default.Save();
                    General.ShowMessage("No se puede Tener Acceso a Servidor Central \n Intentelo Nuevamente o Comuniquese con el Administrador del Sistema", "Error de Acceso");
                    _FrmPadre.GrabaSalida();
                    Application.Exit();
                }
                else
                    MessageBox.Show(string.Format("{0} {1} {2}", "!! Acceso Denegado !! \n",
                        " Verifique que este bien escrito su Usuario y/o Clave \n",
                        ", Su cuenta puede Ser bloqueada y el IP Baneado"), @"Error Nº " + ee.Number);
                return;
            }

            if (log != null)
                if (pwd.Equals(log.Clave))
                {
                    if (pwd1.Equals(pwd2))
                    {
                        _estado = true;
                        try
                        {
                            log.Clave = pwd1; // Security.CreateHash(pwd1);
                            LoginDao.CambiarClave(log, null);
                        }
                        catch (SqlException ee)
                        {
                            _estado = false;
                            MessageBox.Show(ee.Message, @"Error al Actualizar Nueva Clave");
                        }
                        Close();
                    }
                    else //Si no Coincide Claves
                    {
                        _contador++;
                         General.ShowMessage(@"Existe Diferencias en Su Nueva Clave, Reintente",
                                             @"Password Nuevo no Coincide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtClaveNueva1.Focus();
                    }

                }
                else
                {
                    _contador++;
                    MessageBox.Show(
                        string.Format("{0}",
                            "Denomi de Usuario y/o Clave Son Incorrectos\n\r Reintente o Consulte con su Administrador"),
                        @"Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (_contador == 5)
                    {
                        Close();
                    }
                    TxtClave.Focus();
                }
        }
    } //------------------------ Fin de clase
}
