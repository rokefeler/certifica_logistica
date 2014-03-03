using System;
using System.Drawing;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using Certifica_logistica.Popups;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using CertificaUtils;

namespace Certifica_logistica.mantenimiento
{
    public partial class FmPersonal : Masterform
    {
        private Personal _obj;
        public FmPersonal()
        {
            InitializeComponent();
        }
        private void FmPersonal_Load(object sender, EventArgs e)
        {
            General.CargarDatos(CboTDoc, "TDOC", "TDOC-0000");
            General.CargarDatos(CboCategoria, "CCAT", "CCAT-0000");
            General.CargarDatos(CboCondicion, "CNDC", "CNDC-0000");
            EdCodPersonal.Focus();
        }
        public override bool Master_Verificar()
        {
            string cad;
            try
            {
                cad = EdCodPersonal.EditValue.ToString();
            }
            catch
            {
                cad = "";
            }
            if (String.IsNullOrEmpty(cad))
            {
                cad = "El Código debe concordar con el Numero del Doc. de Identidad/Pasaporte o Carnet de Extranjeria";
                dxErrorProvider1.SetError(EdCodPersonal, cad);
                toolTipController1.SetToolTip(EdCodPersonal, cad);
                return false;
            }
            dxErrorProvider1.SetError(EdCodPersonal, "");
            toolTipController1.SetToolTip(EdCodPersonal, "");

            if (!TxtNroDoc.Text.Trim().Equals(cad))
            {
                cad = "El Nro de Documento, debe concordar con el Código Ingresado";
                dxErrorProvider1.SetError(TxtNroDoc, cad);
                toolTipController1.SetToolTip(TxtNroDoc, cad);
                return false;
            }
            dxErrorProvider1.SetError(TxtNroDoc, "");
            toolTipController1.SetToolTip(TxtNroDoc, "");
            if (TxtApellidos.Text.Trim().Length <= 0)
            {
                cad = "Debe Ingrese los Apellidos";
                dxErrorProvider1.SetError(TxtApellidos,cad);
                toolTipController1.SetToolTip(TxtApellidos,cad);
                return false;
            }
            dxErrorProvider1.SetError(TxtApellidos, "");
            toolTipController1.SetToolTip(TxtApellidos, "");
            if (TxtNombres.Text.Trim().Length <= 0)
            {
                cad = "Debe Ingrese los Nombres";
                dxErrorProvider1.SetError(TxtNombres, cad);
                toolTipController1.SetToolTip(TxtNombres, cad);
                return false;
            }
            dxErrorProvider1.SetError(TxtNombres, "");
            toolTipController1.SetToolTip(TxtNombres, "");

            try
            {
                cad = EdCodSubDep.EditValue.ToString();
            }
            catch
            {
                cad = "";
            }
            if (String.IsNullOrEmpty(cad))
            {
                cad = "Debe ubicar a que SubDependencia esta Asignada";
                dxErrorProvider1.SetError(EdCodSubDep, cad);
                toolTipController1.SetToolTip(EdCodSubDep, cad);
                return false;
            }
            dxErrorProvider1.SetError(EdCodSubDep, "");
            toolTipController1.SetToolTip(EdCodSubDep, "");
            
            if (dxErrorProvider1.GetError(EdCodPersonal).Length > 0
                || dxErrorProvider1.GetError(BtnUbigeo).Length > 0
                || dxErrorProvider1.GetError(TxtNroDoc).Length > 0
                || dxErrorProvider1.GetError(EdCodSubDep).Length > 0
                )
            {
                General.ShowMessage("Primero Complete u Corriga Las Observaciones Encontradas ");
                return false;
            }
            
            
            return true;
        }
        public override void ObjectEnter(object sender, EventArgs e)
        {
            base.ObjectEnter(sender, e);
// ReSharper disable once RedundantJumpStatement
            return;
        }

        public override void Object_KeyDown(object sender, KeyEventArgs e)
        {
            base.Object_KeyDown(sender, e);
// ReSharper disable once RedundantJumpStatement
            return;
        }

        public override bool Master_GrabarFormulario()
        {
            var ret = 0;
            if (!Master_Verificar()) return false;

                Value = EdCodPersonal.Text.Trim();
                if(_obj==null) 
                    _obj = new Personal();
                _obj.CodPersonal = Value;
                _obj.Ape = TxtApellidos.Text.Trim();
                _obj.Nom = TxtNombres.Text.Trim();
                _obj.CodDis = BtnUbigeo.EditValue.ToString();
                _obj.Direc = TxtDireccion.Text.Trim();
                _obj.Email = TxtEmail.Text.Trim();
                //--_obj.Fecnac = 
                _obj.IdxTipoDoc = ((Codigo) CboTDoc.SelectedItem).Id;
                _obj.NroDocIden = TxtNroDoc.Text.Trim();
                _obj.IdxCategoria = ((Codigo)CboCategoria.SelectedItem).Id;
                _obj.IdxCondicion = ((Codigo)CboCondicion.SelectedItem).Id;
                _obj.Nrofijo = TxtFijo.Text.Trim();
                _obj.Movil = TxtMovil.Text.Trim();
            if(EdCodSubDep.EditValue!=null)
                if (EdCodSubDep.Text.Length > 0)
                    _obj.CodSubDep = EdCodSubDep.Text.Trim();

                var con = DATA.Db.CreateConnection();
                con.Open();
                var dbTrans = con.BeginTransaction();
                try
                {
                    ret = PersonalDao.Grabar(_obj, dbTrans);
                    if (ret > 0)
                    {
                        dbTrans.Commit();
                        MessageBox.Show(@"Los Datos FUeron Correctamente Actualizados");
                    }
                    else
                    {
                        General.ShowMessage("Error, No se pudo completar operación en Capa de Datos");
                        dbTrans.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    dbTrans.Rollback();
                    General.ShowMessage(ex.Message,"Operación Cancelada",icon: MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    dbTrans.Dispose();
                }
            
            return (ret > 0);
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De Personal Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.PERSONAL};
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodPersonal.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(EdCodPersonal, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }
        private void TxtCodPersonal_Leave(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(EdCodPersonal, "");
            EdCodPersonal.ResetBackColor();
            if (EdCodPersonal.EditValue == null)
                EdCodPersonal.EditValue = "";

            var idP = EdCodPersonal.EditValue.ToString();

            if (idP.Length == 0)
                return;
            
            if (idP.Length < 8)
            {
                TxtApellidos.Text = "";
                dxErrorProvider1.SetError(EdCodPersonal, "Código Ingresado es Muy Corto (Log. Minima 08 Dig)");
            }
            else
            {
                CargarFicha(idP);
            }
        }

        private void CargarFicha(string idP)
        {
            EdCodSubDep.EditValue = String.Empty;
            TxtSubDependencia.Text = String.Empty;
            TxtDependencia.Text = String.Empty;
            EdCodPersonal.ResetBackColor();
            toolTipController1.SetToolTip(EdCodPersonal, "");
            var p = PersonalDao.GetbyId(idP);
            if (p != null)
            {
                Value = idP;
                EdCodPersonal.BackColor = Color.GreenYellow;
                TxtApellidos.Text = p.Ape;
                TxtNombres.Text = p.Nom;
                General.UbicaItemsComboCodigo(CboTDoc, p.IdxTipoDoc);
                TxtNroDoc.Text = p.NroDocIden;
                TxtDireccion.Text = p.Direc;
                BtnUbigeo.EditValue = p.CodDis;
                BtnUbigeo_Leave(this,null); //cargar ubigeo
                TxtEmail.Text = p.Email;
                TxtMovil.Text = p.Movil;
                TxtFijo.Text = p.Nrofijo;
                General.UbicaItemsComboCodigo(CboCategoria, p.IdxCategoria);
                General.UbicaItemsComboCodigo(CboCondicion, p.IdxCondicion);
                if (p.CodSubDep.Length > 0)
                {
                    EdCodSubDep.EditValue = p.CodSubDep;
                    EdCodSubDep_Leave(EdCodSubDep,null); //mostrar datos
                }
            }
            else 
            {
                Value = string.Empty;
                TxtNroDoc.Text = EdCodPersonal.Text;
                General.UbicaItemsComboCodigo(CboTDoc, "TDOC-0001"); //ubicar DNI
                General.UbicaItemsComboCodigo(CboCondicion, "CNDC-0006"); //ubicar 4ta cat. SNP
                EdCodSubDep.EditValue = @"000";
                toolTipController1.SetToolTip(EdCodPersonal,"Este Código no Existe");
            }
        }

        private void TxtCodPersonal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !string.IsNullOrEmpty(dxErrorProvider1.GetError(EdCodPersonal));
            //BtnAdd.Enabled = !e.Cancel;
        }
        
        private void BtnUbigeo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            General.ShowMessage("Por lo pronto ingrese el codigo de Ubigeo respectivo\n"+
                                "Si no se acuerda o no conoce por lo pronto coloque 000000");
        }

        private void BtnUbigeo_Leave(object sender, EventArgs e)
        {
            string coddis = BtnUbigeo.Text.Trim();
            dxErrorProvider1.SetError(BtnUbigeo, "");
            if (string.IsNullOrEmpty(coddis))
            {
                dxErrorProvider1.SetError(BtnUbigeo, "Ingrese Código de Ubigeo - Ej: 040101");
                return;
            }
            var d = DistritoDao.GetbyId(coddis);
            if(d==null)
            {
                TxtUbigeo.Text = @"Código de Ubigeo no Existe!";
                dxErrorProvider1.SetError(BtnUbigeo, "Código de Ubigeo no Existe!");
            }
            else
            {
                TxtUbigeo.Text = d.NombreCompleto;
            }

        }

        private void TxtNroDoc_Leave(object sender, EventArgs e)
        {
            var cnum = TxtNroDoc.Text.Trim();
            dxErrorProvider1.SetError(TxtNroDoc, "");
            if(string.IsNullOrEmpty(cnum))
                dxErrorProvider1.SetError(TxtNroDoc, "Ingrese el Número de Documento");
            else if(cnum.Length<8)
                dxErrorProvider1.SetError(TxtNroDoc, "El Número de Documento de tener como mínimo una Long. de 8C");
        }

        private void EdCodSubDep_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var oFrm = new FphBusqueda { _TiTuloForm = "Busqueda De SubDependencia Institucional", _backColor = BackColor, _TipoTabla = ENumTabla.SUBDEPENDENCIA};
            oFrm.ShowDialog();
            SuspendLayout();
            EdCodSubDep.Text = oFrm._Codigo;
            toolTipController1.SetToolTip(EdCodSubDep, oFrm._Nombre);
            oFrm.Close();
            ResumeLayout();
        }

        private void EdCodSubDep_Leave(object sender, EventArgs e)
        {
            TxtSubDependencia.Text = "";
            TxtDependencia.Text = "";
            toolTipController1.SetToolTip(TxtSubDependencia, "");
            toolTipController1.SetToolTip(TxtDependencia, "");
            dxErrorProvider1.SetError(EdCodSubDep, "");
            if (EdCodSubDep.EditValue == null) return;
            if (EdCodSubDep.EditValue.ToString().Length <= 0) return;

            var cod = EdCodSubDep.EditValue.ToString().ToUpper();
            if (cod.Length <= 0) return;
            var obj = SubDependenciaDao.GetbyId(cod);
            if (obj == null)
            {
                dxErrorProvider1.SetError(EdCodSubDep, "Este Valor Ingresado no Existe");
                return;
            }
            TxtSubDependencia.Text = obj.Nombre;
            var obj2 = DependenciaDao.GetbyId(obj.CodDependencia);
            TxtDependencia.Text = obj2.Nombre;
            toolTipController1.SetToolTip(TxtSubDependencia, obj.Nombre);
            toolTipController1.SetToolTip(TxtDependencia, obj2.Nombre);
        }

        private void BtnImportarSunat_Click(object sender, EventArgs e)
        {
            string cod;
            try  { cod = EdCodPersonal.Text.Trim();}
            catch{ cod = ""; }
            if (string.IsNullOrEmpty(cod)) return;
            var obj = new SunatDni(cod);
            if (obj.GetPersona!=null)
            {
                TxtApellidos.Text = String.Format("{0} {1}", obj.GetPersona.ApePaterno, obj.GetPersona.ApeMaterno);
                TxtNombres.Text = obj.GetPersona.Nombres;
            }
            else
            {
                TxtApellidos.Text = "";
                TxtNombres.Text = "";
                General.ShowMessage(obj.Error);
            }
            //ImportarDnIsunat(cod);
        }
        
        private void BtnImportarReniec_Click(object sender, EventArgs e)
        {
            var oFrm = new FphConsultaReniec {_TiTuloForm = "Consulta Externa RENIEC", _backColor = BackColor};
            oFrm.txtNumDni.Text = EdCodPersonal.Text;
            var res = oFrm.ShowDialog();
            if (res == DialogResult.Cancel)
                oFrm.ShowDialog();

            SuspendLayout();
            try
            {
                EdCodPersonal.Text = oFrm.txtNumDni.Text;
                TxtApellidos.Text = oFrm._Codigo;
                TxtNombres.Text = oFrm._Nombre;
                EdCodPersonal.Focus();
            }
            catch
            {
                EdCodPersonal.Text = oFrm.txtNumDni.Text;
                TxtApellidos.Text = "";
                TxtNombres.Text = "";
            }
            oFrm.Close();
            ResumeLayout();
        }

        /*
         * private void ImportarDnIsunat(String dni)
        {
            var url = string.Format("http://www.sunat.gob.pe/ol-ti-itdenuncia/denS01Alias?tipodoc=1&numdoc={0}&accion=buscar", dni);
            using (var client = new WebClient())
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                Stream data;
                try
                {
                    BtnImportarSunat.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;
                    data = client.OpenRead(url);
                    Cursor.Current = Cursors.Default;
                    BtnImportarSunat.Enabled = true;
                }
                catch (WebException wex)
                {
                    General.ShowMessage(wex.Message);
                    return;
                }
                if (data == null) return;

                var reader = new StreamReader(data);
                var cad = reader.ReadToEnd();
                data.Close();
                reader.Close();

                cad = cad.Trim();
                if (cad.Length <= 120000)
                {
                    MessageBox.Show(@"El número de DNI ingresado no existe en la Base de datos de la SUNAT");
                    return;
                }
                cad = cad.Substring(113000); //empezar desde aqui, porque siempre saldra
                var buscar =
                    String.Format(
                        "<input NAME={0}nombre{1} CLASS={2}bg{3} type={4}text{5} maxlength={6}70{7} size={8}70{9} value=",
                        '\u0022', '\u0022', '\u0022', '\u0022', '\u0022', '\u0022', '\u0022', '\u0022', '\u0022', '\u0022');
                cad = cad.Replace(buscar, "RAZONDEPERSONA:");
                buscar = string.Format("onChange={0}this.value=this.value.toUpperCase(){1} disabled>", '\u0022',
                    '\u0022');
                cad = cad.Replace(buscar, "FINXXX");
                const string cad1 = "RAZONDEPERSONA:";
                const string cad2 = "FINXXX";
                var x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                var y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length + 1;
                var xRazSoc = cad.Substring(x, (y - x)).Trim();
                xRazSoc = General.Limpiar(xRazSoc);
                var nombres = xRazSoc.Split(' ');
                if (nombres.Length <=3)
                {
                    TxtApellidos.Text = String.Format("- {0}",nombres[0]);
                    TxtNombres.Text = String.Format("{0} {1}", nombres[1], nombres[2]);
                }
                else
                {
                    TxtApellidos.Text = String.Format("{0} {1}", nombres[0], nombres[1]);
                    TxtNombres.Text = String.Format("{0} {1}", nombres[2], nombres[3]);
                }
                
                client.Dispose();
                //------------------------------
            }
        }
         * */
      
    }
}
