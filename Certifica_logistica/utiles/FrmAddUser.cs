using System;
using System.ComponentModel;
using System.Windows.Forms;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.utiles
{
    public partial class FrmAddUser : Masterform
    {
        //public inicioform _FrmPadre;
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private bool ExisteId(string name)
        {
            return LoginDao.ExisteId(name);
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            Master_GrabarFormulario();
        }

        private void TxtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (ExisteId(TxtLogin.Text.Trim()))
                errorProvider1.SetError(TxtLogin, "Login Ya Existe, Modifiquelo");
            else
                errorProvider1.SetError(TxtLogin, "");
        }

        private void TxtApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (TxtApellidos.Text.Trim().Length <= 0)
                errorProvider1.SetError(TxtApellidos, "Falta los Apellidos");
            else
                errorProvider1.SetError(TxtApellidos, "");
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            if (TxtApellidos.Text.Trim().Length <= 0)
                errorProvider1.SetError(TxtNombres, "Falta los Apellidos");
            else
                errorProvider1.SetError(TxtNombres, "");
        }

        private void TxtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (TxtDireccion.Text.Trim().Length <= 0)
                errorProvider1.SetError(TxtDireccion, "Falta los Apellidos");
            else
                errorProvider1.SetError(TxtDireccion, "");            
        }
        public override bool Master_GrabarFormulario()
        {
            if(errorProvider1.GetError(TxtLogin).Length > 0 ||
               errorProvider1.GetError(TxtDireccion).Length > 0 ||
               errorProvider1.GetError(TxtApellidos).Length > 0 ||
               errorProvider1.GetError(TxtDireccion).Length > 0 ||
               errorProvider1.GetError(TxtNombres).Length > 0  ||
               errorProvider1.GetError(TxtClaveNueva1).Length > 0 ||
               errorProvider1.GetError(TxtClaveNueva2).Length > 0 || 
               errorProvider1.GetError(TxtNombres).Length > 0 )
            {
                MessageBox.Show(@"Existen Inconsistencias que debe arreglar, Mire los Iconos Rojos", @"Error de Validación");
                return false;
            }
            if (!TxtClaveNueva1.Text.Trim().Equals(TxtClaveNueva2.Text.Trim()))
            {
                MessageBox.Show(@"Su Clave Ingresada no Coincide en ambos Ingresos", "Error de Clave");
                return false;
            }

            Login Newuser = new Login();
            try
            {
                Newuser.CodLogin = TxtLogin.Text.Trim();
                /*
                Newuser.apellidos = TxtApellidos.Text.Trim();
                Newuser.nombres = TxtNombres.Text.Trim();
                Newuser.direccion = TxtDireccion.Text.Trim();
                Newuser.dni = TxtDni.Text.Trim();
                Newuser.fono = TxtFono.Text.Trim();
                Newuser.email = TxtEmail.Text.Trim();
                Newuser.id_sede = ((Codigos)CboSede.SelectedItem).id_codigo;
                Newuser.pwd = TxtClaveNueva1.Text.Trim(); 
                if (LoginHelper.Login_SQL(  Newuser, Select_SQL.Insert, null) > 0)
                    MessageBox.Show("Usuario Añadido Correctamente", "Ok");
                else
                    MessageBox.Show("Base de Datos Envio un Error", "Reintente por favor");
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            this.Close();
            return true;
        }

        private void TxtClaveNueva1_Validating(object sender, CancelEventArgs e)
        {
            if (TxtClaveNueva1.Text.Length <= 0)
                errorProvider1.SetError(TxtClaveNueva1,"Ingrese Su Clave");
            else
                errorProvider1.SetError(TxtClaveNueva1,"");
        }
        private void TxtClaveNueva2_Validating(object sender, CancelEventArgs e)
        {
            if (TxtClaveNueva1.Text.Length <= 0)
                errorProvider1.SetError(TxtClaveNueva2, "Reingrese Su Clave");
            else
                errorProvider1.SetError(TxtClaveNueva2,"");
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            CboSede.DataSource = CodigoDao.SelectAllGetby("SED");
            CboSede.ValueMember = "Id";
            CboSede.DisplayMember = "nombre";
        }

    } //no borrar
}