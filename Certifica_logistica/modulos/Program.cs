using System;
using System.Windows.Forms;
using DaoLogistica.DAO;

namespace Certifica_logistica.modulos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // ReSharper disable once UnusedMember.Local
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var oFrm = new Inicioform();
            try
            {
                //Console.WriteLine();
                Application.Run(oFrm);
            }

            catch (Exception ex)
            {
                if (oFrm.Miconfiguracion.IdConexion > 0)
                {
                    LoginDao.MarcarRegistro(oFrm.Miconfiguracion.IdUsuario, oFrm.Miconfiguracion.IdConexion, null);
                    oFrm.Miconfiguracion.IdConexion = 0;
                }
                General.ShowMessage(ex.Message, "Ups. Se Produjo un Error que aun no pude controlar");
                //Application.Restart();
            }
            finally
            {
                oFrm.Dispose();
            }
        }
    }
}