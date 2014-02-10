using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;
using DevExpress.Data;

namespace Certifica_logistica.Popups
{
    public partial class FphBusqueda : FpMaster
    {
        private DataSet _ds;
        public FphBusqueda()
        {
            InitializeComponent();
        }

        private void FphBusqueda_Load(object sender, EventArgs e)
        {
            switch (_TipoTabla)
            {
                case ENumTabla.ALUMNO:
                case ENumTabla.PERSONAL:
                    Rnd1.Text = @"Apellidos u Nombres";
                    Rnd2.Text = @"Doc. Identidad";
                    break;
                case ENumTabla.PROVEEDOR:
                    Rnd1.Text = @"Razón Social / Nombre Comercial";
                    Rnd2.Text = @"Dirección / Referencia";
                    break;
                case ENumTabla.SERVICIOS:
                    Rnd1.Text = @"Responsable/Rpm/Autorizacion";
                    Rnd2.Text = @"Autorizacion / Cese";
                    break;
                case ENumTabla.META:
                    Rnd1.Text = @"Nombre de Meta";
                    Rnd2.Text = @"Nº Programa u Actividad";
                    break;
                case ENumTabla.SUBDEPENDENCIA:
                    Rnd1.Text = @"Nombre";
                    Rnd2.Text = @"Encargado de SubDepenDencia";
                    break;
                case ENumTabla.RUBRO:
                    groupBox1.Visible = false;
                    Rnd1.Checked = true;
                    break;
                case ENumTabla.ORDENSERVICIO:
                    Rnd1.Text = @"Razon Social";
                    Rnd2.Text = @"Razon de Detalle";
                    break;
                case ENumTabla.EXPEDIENTE:
                    Rnd1.Text = @"Nro. Documento / Asunto";
                    Rnd2.Text = @"Nro de Log";
                    Rnd3.Text = @"SubDependencia Origen";
                    var ninicial = DateTime.Now.Year;
                    CboYearExp.Items.Clear();
                    for (var i = ninicial; i >= 2012; i--)
                        CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));
                    CboYearExp.SelectedIndex = 0;
                    LblPeriodo.Visible = true;
                    CboYearExp.Visible = true;
                    Rnd3.Visible = true;
                    break;
            }

            TxtFiltro.Focus();
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
                var nlong = 3;
                if (_TipoTabla == ENumTabla.EXPEDIENTE && Rnd2.Checked)
                    nlong = 2;
                if (cFil.Trim().Length < nlong)
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
                    if (Rnd1.Checked)
                    {
                        switch (_TipoTabla)
                        {
                            case ENumTabla.ALUMNO:
                                _ds = AlumnoDao.FiltroByRazon(cFilter, cFiltro2);
                                break;
                            case ENumTabla.PERSONAL:
                                _ds = PersonalDao.FiltroByRazon(cFilter, cFiltro2);
                                break;
                            case ENumTabla.PROVEEDOR:
                                _ds = ProveedorDao.FiltroByRazon(cFilter, cFiltro2);
                                break;
                            case ENumTabla.SERVICIOS:
                                _ds=ServiciosDao.FiltroByRazon(cFilter, cFiltro2);
                                break;
                            case ENumTabla.META:
                                _ds = MetaDao.FiltroByNombre(cFilter, cFiltro2);
                                break;
                            case ENumTabla.SUBDEPENDENCIA:
                                _ds = SubDependenciaDao.FiltroByNombre(cFilter, cFiltro2);
                                break;
                            case ENumTabla.RUBRO: //Siempre ocurrira solo esto
                                _ds = RubroFinanciamientoDao.FiltroByNombre(cFilter, cFiltro2);
                                break;
                            case ENumTabla.ORDENSERVICIO:
                                //_ds = OrdenLogisticaDao.FiltroByNroDocAsunto(cFilter, cFiltro2);
                                break;
                            case ENumTabla.EXPEDIENTE:
                                _ds = ExpedienteDao.FiltroByNroDocAsunto(cFilter, Convert.ToInt32(CboYearExp.SelectedItem), cFiltro2);
                                break;
                        }
                        
                    }
                    else if (Rnd2.Checked)
                    {
                        switch (_TipoTabla)
                        {
                            case ENumTabla.ALUMNO:
                                _ds = AlumnoDao.FiltroByDoc(cFilter);
                                break;
                            case ENumTabla.PERSONAL:
                                _ds = PersonalDao.FiltroByDoc(cFilter);
                                break;
                            case ENumTabla.PROVEEDOR:
                                _ds = ProveedorDao.FiltroByDireccion(cFilter,cFiltro2);
                                break;
                            case ENumTabla.SERVICIOS:
                                _ds = ServiciosDao.FiltroByAutorizacion(cFilter, cFiltro2);
                                break;
                            case ENumTabla.META:
                                 _ds = MetaDao.FiltroByPrograma(cFilter, cFiltro2);
                                break;
                            case ENumTabla.SUBDEPENDENCIA:
                                _ds = SubDependenciaDao.FiltroByEncargadoSubDependencia(cFilter, cFiltro2);
                                break;
                            case ENumTabla.EXPEDIENTE:
                                _ds = ExpedienteDao.FiltroByLog(cFilter, Convert.ToInt32(CboYearExp.SelectedItem));
                                break;
                        }                        
                        
                    }
                    else //si esta seleccionado 3era opcion
                        switch (_TipoTabla)
                        {

                            case ENumTabla.EXPEDIENTE:
                                _ds = ExpedienteDao.FiltroBySubDependencia(cFilter, Convert.ToInt32(CboYearExp.SelectedItem), cFiltro2);
                                break;
                        }  
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
// ReSharper disable once RedundantToStringCall
                _Nombre = r[2].ToString() + ", "+ r[1].ToString();
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


        #region MINIUTILIDADES de Navegacion
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

        private void FphBusqueda_SizeChanged(object sender, EventArgs e)
        {
            gridView1.BestFitColumns();
        }
        #endregion

        private void TxtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
                BtnFiltrar_Click(sender,null);
        }
    }
}
