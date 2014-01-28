using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Certifica_logistica.mantenimiento;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using Certifica_logistica.procesos;
using Certifica_logistica.utiles;
using DaoLogistica;
using DaoLogistica.DAO;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Certifica_logistica
{

    public sealed partial class Inicioform : Form
    {
        //private int childFormNumber = 0;

        public Database MiDatabase;
        public General Miconfiguracion;

        public Inicioform()
        {
            NetworkChange.NetworkAddressChanged += NetworkChange_NetworkAddressChanged;
            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
            InitializeComponent();
            Miconfiguracion = new General();
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\fondo2.jpg");
            //pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\logo.gif");
        }

        public void CargarDatosIniciales()
        {
            var con = new Conexion();
            try
            {
                //String C1 = Security.Encripta("123456");
                //String C2 = Security.CreateHash("123456");
                /* Backup BORRAR DESPUES*/
                /*
                Properties.Settings.Default.IpServer = @"+7oRfOv0nJev1TjhA4L8G8f/sEx8BZpCAPg0LeA4BKSe4J+luAdeE3bGSP88n4q0";
                Properties.Settings.Default.PuertoServer = @"dpg/IoL99iGqtJbL3K383Q6NI6Jbq7pZLH0togFTPKs=";
                Properties.Settings.Default.Catalogo = @"FT+rIX+ID8+CyHzhlcE4OvfgloDZOLQPEp0ietR1pXV2lTasP0Ypv1KfO1L+W6k9";
                Properties.Settings.Default.PathServerFotos = @"D:\TEMP";
                Properties.Settings.Default.DriveVirtual = @"Z:\";
                Properties.Settings.Default.Save();
                */

                con.Ip = Properties.Settings.Default.IpServer;
                con.Puerto = Properties.Settings.Default.PuertoServer;
                con.Catalogo = Properties.Settings.Default.Catalogo;
                con.Pwd = CONSTANTE.PasswordDb;
                con.Usuario = CONSTANTE.UserDb;

                //TODO: cambiar encryptacion por objeto
                /*
                byte[] serializedObject = SerializationUtility.ToBytes(con);
                byte[] hashed1Object = defaultCrypto.CreateHash("MD5Cng", con);
                 * */
                var cArchivoConfig = DatabaSeConfig.ConfiguracionDb(con);
                if (cArchivoConfig.Length == 0)
                {
                    Console.Beep();
                    MessageBox.Show(@"Error #0 - comunique al Administrador de Red");
                    return;
                }
                IConfigurationSource source = new FileConfigurationSource(cArchivoConfig);
                var factory = new DatabaseProviderFactory(source);

                MiDatabase = factory.Create("CERTIFICA");
                File.Delete(cArchivoConfig);
                //DATA.ClaveSyn = Security.CifrarTextoAes("3$KjqHp0rSN$>:-)",CONSTANTE.PALABRAPASO, CONSTANTE.PALABRASALTO,9,CONSTANTE.VECTOR16, CONSTANTE.LONGITUD);
                DATA.Db = MiDatabase;
                //Cargar Valores del Sistema
                DATA.ClaveSyn = CONSTANTE.Syn;
                using (var dr = ConfigDao.GetAllConfig())
                {
                    while (dr.Read())
                    {
                        switch (dr.GetInt32(dr.GetOrdinal("Id")))
                        {
                            case 1:
                                Miconfiguracion.RazonEmpresa = dr.GetString(dr.GetOrdinal("clave"));
                                break;
                            case 2:
                                Miconfiguracion.RucEmpresa = dr.GetString(dr.GetOrdinal("clave"));
                                break;
                            case 3:
                                Miconfiguracion.CodigoEmpresa = dr.GetString(dr.GetOrdinal("clave"));
                                break;
                        }
                    }
                }

                if (Miconfiguracion.RazonEmpresa == String.Empty)
                {
                    General.ShowMessage("Programa No pudo Localizar al Servidor", "Error de Conexi�n");
                    MiDatabase = null;
                    Application.Exit();
                }
                Miconfiguracion.PathServerFotos = Properties.Settings.Default.PathServerFotos;
                /* TODO habilitacion Unidad de red Deshabilitada
                if (cDriveVirtual.Length > 2)
                {
                    //String cad = string.Format("{0}:\\{1}";
                    //    , cDriveVirtual.Substring(0, 1)); //, Properties.Settings.Default.PathServerFotos);
                        try
                        {
                            if (!Directory.Exists(Miconfiguracion.PathServerFotos))
                                System.Diagnostics.Process.Start("subst " + 
                                      cDriveVirtual.Substring(0,2), Properties.Settings.Default.PathServerFotos);
                        }
                        catch (Exception ee)
                        {
                            General.ShowMessage("No se Pudo Enlazar ruta de Fotos con el Servidor\n\r" + ee.Message,"Error de Mapeado Unidad Virtual");
                        }
                }
                */
                UpdateStatusPanel(NetworkInterface.GetIsNetworkAvailable());
                UpdateAddressPanel(null);
                Text += string.Format(" - {0}", Miconfiguracion.RazonEmpresa);

                /**
                 * var v = AreaDao.GetAll();
                 * Text += " & " + v.Tables[0].Rows.Count.ToString();
                 * */

            }
            catch (SqlException sqe)
            {
                if (sqe.Number == 18456) //Si Clave de Database es InCorrecta
                {
                    General.ShowMessage("Error en Configuraci�n de Instalaci�n  - DB",
                        "Contactese con Administrador del Sistema");
                    Close();
                }
            }
            catch (SqlNullValueException sqe)
            {
                sqe.HelpLink = "rokefeler.net/sqe";
                General.ShowMessage("Configuraci�n de DB Alterada - Valores Nulos",
                        "Contactese con Administrador del Sistema" );
                Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Close();
            }
             
        }

        private void inicioform_Load(object sender, EventArgs e)
        {
            CargarDatosIniciales();
            LoginToolStripMenuItem_Click(sender, e);
        }

        #region OPCIONES GENERALES

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            //UpdateStatusPanel(e.IsAvailable);
            Invoke(new System.Threading.WaitCallback(UpdateStatusPanel), e.IsAvailable);
        }

        private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
        {
            Invoke(new System.Threading.WaitCallback(UpdateAddressPanel), e);
        }

        private void UpdateStatusPanel(Object state)
        {
            if ((bool) state)
            {
                toolStripStatusLabel1.ForeColor = Color.Green;
                toolStripStatusLabel1.Text = @"En Linea";
            }
            else
            {
                toolStripStatusLabel1.ForeColor = Color.Red;
                toolStripStatusLabel1.Text = @"Desconectado";
            }
        }

        private void UpdateAddressPanel(Object state)
        {
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            Miconfiguracion.Hostname = ipHostInfo.HostName;
            Miconfiguracion.Ip = General.GetIp4Address();
            toolStripStatusLabel2.Text = Miconfiguracion.Ip;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm == null) return;
            object obj = oFrm.ActiveControl;
            try
            {
                if (obj.GetType().ToString().Equals("System.Windows.Forms.TextBox") ||
                    obj.GetType().ToString().Equals("System.Windows.Forms.MaskedTextBox"))
                {
                    var txt = (TextBoxBase) obj;
                    Clipboard.SetText(txt.SelectedText, TextDataFormat.Text);
                    txt.SelectedText = "";
                }
            }
            catch
            {
                Console.Beep();
                Clipboard.Clear();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm == null) return;
            object obj = oFrm.ActiveControl;
            try
            {
                if (obj.GetType().ToString().Equals("System.Windows.Forms.TextBox") ||
                    obj.GetType().ToString().Equals("System.Windows.Forms.MaskedTextBox"))
                    Clipboard.SetText(((TextBoxBase) obj).SelectedText, TextDataFormat.Text);
            }
            catch
            {
                Console.Beep();
                Clipboard.Clear();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm == null) return;
            object obj = oFrm.ActiveControl;
            try
            {
                if (obj.GetType().ToString().Equals("System.Windows.Forms.TextBox") ||
                    obj.GetType().ToString().Equals("System.Windows.Forms.MaskedTextBox"))
                    if (Clipboard.ContainsText(TextDataFormat.Text))
                        ((TextBoxBase) obj).SelectedText = Clipboard.GetText(TextDataFormat.Text);
            }
            catch
            {
                Console.Beep();
                Clipboard.Clear();
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        #endregion


        #region "Comando Barra de Herramientas Formularios Hijos" 

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_GrabarFormulario();
        }

        private void RunToolStrip_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_RunFormulario();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_NuevoFormulario();
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_CerrarFormulario();
            else
            {
                GrabaSalida();
                Close();
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_EliminarFormulario();
        }

        private void cerrarActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closetoolStripButton_Click(sender, e);
        }

        private void printSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            if (PageSetupDialog1.Tag == null)
            {
                PageSetupDialog1.PageSettings =
                    new System.Drawing.Printing.PageSettings();

                // Initialize dialog's PrinterSettings property to hold user
                // set printer settings.
                PageSetupDialog1.PrinterSettings =
                    new System.Drawing.Printing.PrinterSettings();

                //Do not show the network in the printer dialog.
                PageSetupDialog1.ShowNetwork = true;
                PageSetupDialog1.Tag = "Ok";
            }

            //Show the dialog storing the result.
            var result = PageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                Miconfiguracion.PrinterName = PageSetupDialog1.PrinterSettings.PrinterName;
                /*Miconfiguracion.PrinterName_BV = PageSetupDialog1.PrinterSettings.PrinterName;
                Miconfiguracion.PrinterPaperSize = PageSetupDialog1.PageSettings.PaperSize;*/
                /*object[] results = new object[]{ 
            PageSetupDialog1.PageSettings.Margins , 
            PageSetupDialog1.PageSettings.PaperSize, 
            PageSetupDialog1.PageSettings.Landscape, 
            PageSetupDialog1.PrinterSettings.PrinterName, 
            PageSetupDialog1.PrinterSettings.PrintRange};
                //ListBox1.Items.AddRange(results);*/
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm == null) return;
            int nCopias;
            switch (oFrm.Name)
            {
                case "FpAmbiente":
                case "tarjetaform":
                    nCopias = 1;
                    break;
                default:
                    var pfrm = new FrmPrint();
                    pfrm.ShowDialog();
                    nCopias = pfrm._nCopias;
                    if (nCopias <= 0)
                        return;
                    pfrm.Close();
                    break;
            }
            oFrm.Master_ImprimirFormulario(false, nCopias);
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_ImprimirFormulario(true, 0);
        }

        private void toolStripBloquearExpediente_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_BloquearFormulario();
        }

        #endregion

        internal void ActivarMenus(bool estado)
        {
            LogoutToolStripMenuItem.Enabled = estado;
            cambiarClaveToolStripMenuItem.Enabled = estado;
            personalToolStripMenuItem.Enabled = estado;
            
            usuariosDeSistemaToolStripMenuItem.Enabled = estado;
            
            relaci�nDeAmbientesToolStripMenuItem.Enabled = estado;
            
            LoginToolStripMenuItem.Enabled = !estado;
            usuariosDeSistemaToolStripMenuItem.Enabled = false;
            MantenimientoMenuItemSup.Enabled = estado;
            operacionesToolStripMenuItemSup.Enabled = estado;
            ReportesMenuItemSup.Enabled = estado;
            if (Miconfiguracion.IdUsuario.Equals("ROOT"))
            {
                usuariosDeSistemaToolStripMenuItem.Enabled = estado;
                //mantenimientoToolStripMenuItem.Enabled = estado;
            }
            
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrabaSalida();
            ActivarMenus(false);
            toolStripStatus_user.Text = @"Usuario: <Ninguno>";
            Miconfiguracion.IdUsuario = "";
            Miconfiguracion.Nombre = "";
            Miconfiguracion.HoraDeInicio = new DateTime(1900, 1, 1);
            General.ShowMessage("Sessi�n Cerrada");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm == null) return;
            object obj = oFrm.ActiveControl;
            if (obj.GetType().ToString().Equals("System.Windows.Forms.TextBox") ||
                obj.GetType().ToString().Equals("System.Windows.Forms.MaskedTextBox"))
                ((TextBoxBase) obj).SelectAll();
        }

        #region Comandos basicos Calculadora, Excel, WInword

        private void calculadoraWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void abrirExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void abrirWinWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value++;
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
                toolStripProgressBar1.Value = 0;
            Application.DoEvents();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new AboutBox1 {MdiParent = this};
            oFrm.Show();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*
            var oFrm = new FrmLogin {_FrmPadre = this};
            oFrm.ShowDialog();
            try
            {
                ActivarMenus(oFrm._Estado);
                if (oFrm._Estado)
                {
                    toolStripStatus_user.Text = @"Usuario: " + Miconfiguracion.Nombre;
                    Miconfiguracion.IdConexion = LoginDao.MarcarRegistro(Miconfiguracion.IdUsuario, 0,
                        Miconfiguracion.ip);
                }
                else
                {
                    toolStripStatus_user.Text = @"Usuario:  [Ninguno]";
                }
                oFrm.Close();
                oFrm.Dispose();
            }
            catch (Exception ex)
            {
                General.ShowMessage(ex.Message);
            } */
            //TODO: JR restablecer al poner en producci�n
            Miconfiguracion.IdUsuario = "SYSTEM";
            Miconfiguracion.Nombre= "PRUEBAS";
            Miconfiguracion.Sede = "";
            Miconfiguracion.Derechos = new string('9',80);ActivarMenus(true);
             

        }

        private void procesarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = (Masterform) ActiveMdiChild;
            if (oFrm != null) oFrm.Master_RunFormulario();
        }

        private void ActualizarToolStrip_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(String.Format("{0} \n {1}\n{2}", @"Desea Ud. Actualizar los Datos del Sistema",
                    @"Si acepta, deber� cerrar todas las ventanas y",
                    @"Esperar a que el Programa se Reinicie Automaticamente, Si Cancela el Programa puede corromperse"), @"Confime por Favor y sea Paciente",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) !=
                DialogResult.Yes)
                return;

            var myftp = new Rebex.Net.Ftp();
            toolStripProgressBar1.Value = 0;
            timer1.Enabled = true;
            UseWaitCursor = true;
            try
            {
                myftp.Connect(Properties.Settings.Default.Server_Updates); 
                myftp.Login("certifica", "<Xtp$>9312.>"); 
                myftp.Passive = true;
                myftp.TransferType = Rebex.Net.FtpTransferType.Binary;
                if (General.LeerServerFtp("update_inv", ref myftp, true))
                    myftp.Disconnect();
                Application.Restart();
                //System.Diagnostics.Process.Start(Application.StartupPath + "\\certifica_patrimonio.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                myftp.Disconnect();
                timer1.Enabled = false;
                toolStripProgressBar1.Visible = false;
                UseWaitCursor = false;
                Console.Beep();
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void usuariosDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oFrm = new FmLogin
            {
                MdiParent = this,
                _DerechoFormulario = {Grabar = true, Eliminar = true, Nuevo = true, Procesar = false},
                _FrmPadre = this
            };
            oFrm.Show();
        }

        private void Inicioform_FormClosing(object sender, FormClosingEventArgs e)
        {
            GrabaSalida();
        }

        public void GrabaSalida()
        {
            if (Miconfiguracion.IdConexion <= 0) return;
            LoginDao.MarcarRegistro(Miconfiguracion.IdUsuario, Miconfiguracion.IdConexion, Miconfiguracion.Ip);
            Miconfiguracion.IdConexion = 0;
        }

        private void cambiarClaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var oFrm = new frm_clave {_FrmPadre = this};
            oFrm.Login(Miconfiguracion.IdUsuario);
            oFrm.ShowDialog();
            if (oFrm._estado)
            {
                MessageBox.Show(@"! Su Clave Fue Cambiada Satisfactoriamente !", @"Confirmaci�n de Operaci�n");
            }
            oFrm.Dispose();
        }

       private void toolStripMntConfiguracionAcceso_Click(object sender, EventArgs e)
        {
            //VErificar que no este Cargado
            if (Application.OpenForms["FpConfig"] != null)
            {
                Application.OpenForms["FpConfig"].Activate();
                return;
            }
            var oFrm = new FpConfig
            {
                _FrmPadre = this,
                MdiParent = this,
                _DerechoFormulario = {Grabar = true, Eliminar = false, Nuevo = false, Procesar = false},
            };
            oFrm.Show();
        }

       private void personalToolStripMenuItem_Click(object sender, EventArgs e)
       {
           var oFrm = new FmPersonal
           {
               MdiParent = this,
               _DerechoFormulario = { Grabar = true, Eliminar = true, Nuevo = true, Procesar = false },
               _FrmPadre = this
           };
           oFrm.Show();
       }

       private void tr�miteDocumentarioToolStripMenuItem_Click(object sender, EventArgs e)
       {
           var oFrm = new FpTramite
           {
               MdiParent = this,
               _DerechoFormulario = { Grabar = true, Eliminar = true, Nuevo = true, Procesar = false },
               _FrmPadre = this
           };
           oFrm.Show();
       }
    }
}