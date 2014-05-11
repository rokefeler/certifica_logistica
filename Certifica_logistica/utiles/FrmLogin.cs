using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.utiles
{
    public partial class FrmLogin : Form
    {
        // ReSharper disable once InconsistentNaming
        public bool _Estado; //devolvera si Contraseña es Correcta o Incorrecta
        // ReSharper disable once InconsistentNaming
        public Inicioform _FrmPadre;
        // ReSharper disable once InconsistentNaming
        private int contador;

        public FrmLogin()
        {
            InitializeComponent();
            _Estado = false;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\logo.gif");
        }
        private void Control_Enter(object sender, EventArgs e)
        {
            var tipo = sender.GetType().ToString();
            switch (tipo)
            {
                case "System.Windows.Forms.TextBox":
                    var txt2 = (TextBox)sender;
                    txt2.SelectAll();
                    break;
                case "System.Windows.Forms.MaskedTextBox":
                    //var msk = (MaskedTextBox)sender;
                    SendKeys.Send("{HOME}+{END}");
                    break;
            }
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            _Estado = false;
            Hide();
        }

        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            Login  log = null;
            var user = Txt_id_user.Text;
            var pwd = Txt_pwd.Text;
            _Estado = false;
            try 
            {
                log = LoginDao.GetbyId(user);
            }
            catch (SqlException ee)
            {
                
                if (ee.Number == 10060 || ee.Number ==10061)
                {
                    Properties.Settings.Default.IpServer = "";
                    Properties.Settings.Default.Save();
                    General.ShowMessage("No se puede Tener Acceso a Servidor Central \n Intentelo Nuevamente o Comuniquese con el Administrador del Sistema","Error de Acceso");
                    Application.Exit();
                }
                else
                    MessageBox.Show(string.Format("{0} {1} {2}","!! Acceso Denegado !! \n",
                        " Verifique que este bien escrito su Usuario y/o Clave \n",
                        ", Su cuenta puede Ser bloqueada y el IP Baneado"), @"Error Nº " + ee.Number); 
            }
            if (log != null)
                if (pwd.Equals(log.Clave))
                {
                    _FrmPadre.Miconfiguracion.IdUsuario = user;
                    var p = PersonalDao.GetbyId(log.CodPersonal);
                    if (p == null)
                        Application.Exit();
                    else
                    {
                    _FrmPadre.Miconfiguracion.Nombre = p.RazonSocial;
                    _FrmPadre.Miconfiguracion.HoraDeInicio = DateTime.Now;
                    _FrmPadre.Miconfiguracion.Derechos = "11111111111111111111111111111111111111111111111111";//Log.derechos;
                    _Estado = true;    
                    Close();
                    }
                }
            if (!_Estado)
            {
                contador++;
                MessageBox.Show(string.Format("{0}","Denomi de Usuario y/o Clave Son Incorrectos\n\r Reintente o Consulte con su Administrador"), @"Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (contador == 5) 
                { 
                    Close(); 
                    return; 
                }
                Txt_pwd.Focus();
            }
            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            try
            {
                for (var x = 1; x <= 80; x++)
                    _FrmPadre.Miconfiguracion.Derechos += "0";
                _FrmPadre.GrabaSalida();
                _FrmPadre.Miconfiguracion.IdConexion = 0;
                _FrmPadre.Miconfiguracion.IdUsuario = "[Ninguno]";
                //_FrmPadre.Miconfiguracion.Sede = "SED0003";
                _FrmPadre.Miconfiguracion.HoraDeInicio = DateTime.Now;
            }
            catch
            {
                Console.Beep();
            }
            //_FrmPadre.Miconfiguracion = new general();
        }

    }
}