using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;

namespace Certifica_logistica.Popups
{
    public partial class FphModificarNroExp : FpMaster
    {
        public FphModificarNroExp()
        {
            InitializeComponent();
            var ninicial = DateTime.Now.Year;
            CboYearExpFinal.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboYearExpFinal.Items.Add(i.ToString(CultureInfo.InvariantCulture));
            CboYearExpFinal.SelectedIndex = 0;
        }

        public override void GrabarFormulario()
        {
            if (!LblOk.Visible)
            {
                EdExpFinal.Focus();
                General.ShowMessage("Debe Ingresar un Expediente Válido");
                return;
            }

            var codigoExpActual= EdExpFinal.Text.Trim();
                while (codigoExpActual.Length < 6)
                    codigoExpActual = "0" + codigoExpActual;
            codigoExpActual = codigoExpActual + "-" + CboYearExpFinal.SelectedItem;
            
            var dbCon = _miDatabase.CreateConnection();
            dbCon.Open();
            var dbTrans = dbCon.BeginTransaction();
            DialogResult = DialogResult.Abort;
            try
            {
                var ret = ExpedienteDao.Corregir(TxtExpedienteActual.Text, codigoExpActual, _nLog, _anio, _idUsuario, dbTrans);
                var msg = General.AnalizaResultadoSql(ret);
                if (ret > 0)
                {
                    dbTrans.Commit();
                    DialogResult = DialogResult.OK;
                }
                else
                    dbTrans.Rollback();
                General.ShowMessage(msg, "Aviso de Proceso");
            }
            catch (Exception ex)
            {
                dbTrans.Rollback();
                General.ShowMessage(ex.Message,"Error en Proceso", icon: MessageBoxIcon.Error);
            }
            finally
            {
                if(dbCon.State== ConnectionState.Open)
                dbCon.Close();
            }
            if(DialogResult==DialogResult.OK)
            Hide();
        }

        private void EdExpFinal_Leave(object sender, EventArgs e)
        {
            VerificaExpediente(sender);
        }

        private void VerificaExpediente(object sender)
        {
            string cNroExp;
            if (!EdExpFinal.IsModified)
            {
                Console.Beep();
                return;
            }
            try
            {
                cNroExp = EdExpFinal.EditValue.ToString();
            }
            catch
            {
                cNroExp = String.Empty;
            }
            LblOk.Visible = false;
            if (cNroExp.Length <= 0) return;
            cNroExp = cNroExp.PadLeft(6, '0');
            EdExpFinal.EditValue = cNroExp;
            cNroExp = cNroExp + "-" + CboYearExpFinal.SelectedItem;
            //--averiguar si Existe o no
            EdExpFinal.ResetBackColor();
            CboYearExpFinal.ResetBackColor();
            dxErrorProvider1.SetError(EdExpFinal, "");
            dxErrorProvider1.SetError(CboYearExpFinal, "");
            if (ExpedienteDao.ExisteById(cNroExp))
            {
                EdExpFinal.BackColor = Color.LightGreen;
                CboYearExpFinal.BackColor = Color.LightGreen;
                dxErrorProvider1.SetError((Control) sender, "Debe Ingresar un Número de Exp. que no Exista");
            }
            else
            {
                LblOk.Visible = true;
            }
        }

        private void CboYearExpFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificaExpediente(sender);
        }

        private void FphModificarNroExp_Load(object sender, EventArgs e)
        {
            TxtLog.Text = String.Format("{0}-{1}",_nLog.ToString("000000"), _anio.ToString("0000"));
            EdExpFinal.Focus();
        }
    }
}
