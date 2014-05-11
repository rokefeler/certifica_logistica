using System;
using System.Data;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;
using DevExpress.Data;

namespace Certifica_logistica.Popups
{
    public partial class FphRubro : FpMaster
    {
        private DataSet _ds;
        public FphRubro()
        {
            InitializeComponent();
        }


        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

            try
            {
                var sep = new char[] { '+' };
                string[] cParams = null;
                var cFiltro2 = String.Empty;
                var cFilter = TxtFiltro.Text.Trim() + "   ";
                var cFil = cFilter;
                if (cFil.Trim().Length <= 2)
                {
                    General.ShowMessage("La Longitud del Texto a buscar es muy corto\nIntentelo Nuevamente");
                    TxtFiltro.Focus();
                    return;
                }
                if (cFil.Substring(0, 2).Equals("**"))
                    cFilter = cFil.Substring(2);
                else if (cFil.Substring(0, 1).Equals("*"))
                    cFilter = cFil.Substring(1);
                else //verificar parametros
                {
                    if (cFilter.IndexOf('+') >= 0)
                    {
                        cParams = cFilter.Split(sep);
                        if (cParams[1].Length > 0)
                        {
                            cFilter = "%" + cParams[0].Trim() + "%";
                            cFiltro2 = "%" + cParams[1].Trim() + "%";
                        }
                    }
                }
                if (cFiltro2.Length <= 0)
                    cFilter = "%" + cFilter.Trim() + "%"; //pra evitar Phishing
                try
                {
                    //if (cFil.Substring(0, 2).Equals("*")) //Si es Buscar por Dni   
                    // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                    //if(Rnd1.Checked)
                        _ds = RubroFinanciamientoDao.FiltroByNombre(cFilter, cFiltro2);
                    
                } //try
                catch (Exception ee)
                {
                    gridControl1.DataSource = null;
                    General.ShowMessage(ee.Message, "Error en Base de Datos");
                }
            }
            catch (Exception ee)
            {
                Console.Beep();
                MessageBox.Show(ee.Message, @"Ups, que roche surgio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            gridControl1.DataSource = _ds.Tables[0];
            gridView1.Columns[0].SummaryItem.SummaryType = SummaryItemType.Count;
            gridView1.Columns[0].SummaryItem.DisplayFormat = @"{0} Personas";
            //gridView1.BestFitColumns();
            gridView1.BestFitColumns();
        }

        public override void GrabarFormulario()
        {
            try
            {
                var r = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
                _Codigo = r[0].ToString();
// ReSharper disable once RedundantToStringCall
                _Nombre = r[2].ToString() ;
            }
            catch 
            {
                //general.ShowMessage(ex.Message);
                _Codigo = string.Empty;
                _Nombre = string.Empty;
                return;
            }
            Hide();
        }


        private void TxtFiltro_Enter(object sender, EventArgs e)
        {
            TxtFiltro.SelectAll(); //Seleccionar todo
        }

        private void ChkMostrarGrupo_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowGroupPanel = ChkMostrarGrupo.Checked;
        }

        private void ChkFilter_CheckedChanged(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowAutoFilterRow = ChkFilter.Checked;
        }

        private void FphRubro_Load(object sender, EventArgs e)
        {
            TxtFiltro.Focus();
        }

        private void FphRubro_SizeChanged(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
        }

    }
}
