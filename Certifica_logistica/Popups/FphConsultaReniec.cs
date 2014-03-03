using System;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using CertificaUtils;

namespace Certifica_logistica.Popups
{
    public partial class FphConsultaReniec : FpMaster
    {
        
        public FphConsultaReniec()
        {
            InitializeComponent();
        }

        void CargarImagen()
        {
            try
            {
                if (_myInfo == null)
                    _myInfo = new Reniec();
                pictureCapcha.Image = _myInfo.GetCapcha;
            }
            catch (Exception ex)
            {
// ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        void CaptionResul()
        {
            try
            {
                switch (_myInfo.GetResul)
                {
                    case Reniec.Resul.Ok:
                        LblResul.Text = String.Format("Nombre(s): {0}" + Environment.NewLine +
                                            "Apellidos Paterno: {1}" + Environment.NewLine +
                                            "Apellidos Paterno: {2}", _myInfo.Persona.Nombres, _myInfo.Persona.ApePaterno, _myInfo.Persona.ApeMaterno);
                        break;
                    case Reniec.Resul.NoResul:
                        LblResul.Text = @"No existe DNI";
                        break;
                    case Reniec.Resul.ErrorCapcha:
                        CargarImagen();
                        LblResul.Text = @"Ingrese imagen correctamente";
                        break;
                    case Reniec.Resul.Error:
                        LblResul.Text = @"Error Desconocido";
                        break;
                }
            }
            catch (Exception ex)
            {
// ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        private void txtNumDni_TextChanged(object sender, EventArgs e)
        {
            LblResul.Text = "";
        }

        private void cmdReloadCapcha_Click(object sender, EventArgs e)
        {
            try
            {
                CargarImagen();
                txtCapcha.SelectAll();
                txtCapcha.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumDni.Text.Length != 8)
                {
                    LblResul.Text = @"Ingrese Dni Valido";
                    txtNumDni.SelectAll();
                    txtNumDni.Focus();
                    return;
                }

                _myInfo.GetInfo(txtNumDni.Text, txtCapcha.Text);
                CaptionResul();
                //CargarImagen(); //Comentar esta linea para consultar multiples DNI usando un solo captcha.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNumDni_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void FphConsultaReniec_Load(object sender, EventArgs e)
        {
            try
            {
                CargarImagen();
            }
            catch (Exception ex)
            {
                General.ShowMessage(ex.Message,"Error");
                //throw ex;
            }
            txtNumDni.Focus();
        }

        public override void GrabarFormulario()
        {
            try
            {
                _Codigo = _myInfo.Persona.ApePaterno + " " + _myInfo.Persona.ApeMaterno;
                try
                {
                    _Nombre = _myInfo.Persona.Nombres;
                }
                catch
                {
                    _Nombre = null;
                }
            }
            catch
            {
                //general.ShowMessage(ex.Message);
                _Codigo = string.Empty;
                _Nombre = string.Empty;
                return;
            }
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
