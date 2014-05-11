using System;
using System.Windows.Forms;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;

namespace Certifica_logistica.utiles
{
    public partial class Ubigeoform : Form
    {
        public Inicioform FrmPadre;
        public  string CUbigeo;
        public  bool Estado;
        public  string CNombreUbigeo= "[ ] - [ ] - [ ]";

        public Ubigeoform()
        {
            InitializeComponent();
        }

        private void ubigeoform_Load(object sender, EventArgs e)
        {
            CboCodDep.DataSource = DepartamentoDao.GetAll();
            CboCodDep.ValueMember = "id_cod";
            CboCodDep.DisplayMember = "name"; 
        }

        private void CboCodDep_Leave(object sender, EventArgs e)
        {
            CargaProvincias(CboCodDep.SelectedValue.ToString());
            CargaDistritos(CboCodProv.SelectedValue.ToString());
        }

        private void CboCodProv_Leave(object sender, EventArgs e)
        {
            
            string cCodProv;
            try
            {
                cCodProv = CboCodProv.SelectedValue.ToString().Trim();
            }
            catch
            {
                cCodProv = "";
            }
            if (cCodProv.Length > 0)
                CargaDistritos(CboCodProv.SelectedValue.ToString());
            else
                CboCodDep.Select();  
    
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CUbigeo = "";
            CNombreUbigeo = "";
            Estado = false; 
            Close(); //Esconder Formulario  
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            CUbigeo = CboCoddis.SelectedValue.ToString();
            CNombreUbigeo = "[" + CboCodDep.Text.Trim() + 
                               "]-[" + CboCodProv.Text.Trim() +
                               "]-[" + CboCoddis.Text.Trim() + "]";     
            Estado = true;  
            Close(); 
        }

        private void ubigeoform_Shown(object sender, EventArgs e)
        {
            string codDep, codProv, codDis;
            //Buscar Si existe Algun dato para Mostrar
            if (CUbigeo.Length > 0)
            {
                codDep  = CUbigeo.Substring(0,2) ;
                codProv = CUbigeo.Substring(0,4);
                codDis = CUbigeo; 
                //Si Departamento empieza con Cero, Entonces Salir de Todo
                if (codDep.Equals("00"))
                {
                    CboCodDep.Select();  
                    return;
                }
                //Ubicar Departamento
                foreach(Departamento iteraUbigeo in CboCodDep.Items ) 
                {
                    if (iteraUbigeo.CodDep.Equals(codDep))
                    {
                        CboCodDep.SelectedItem = iteraUbigeo;
                        break;
                    }
                }
                CargaProvincias(codDep);
                //Ubicar Provincia
                foreach (Provincia iteraUbigeo in CboCodProv.Items)
                {
                    if (iteraUbigeo.CodProv.Equals(codProv))
                    {
                        CboCodProv.SelectedItem = iteraUbigeo;
                        break;
                    }
                }

                CargaDistritos(CUbigeo.Substring(0,4));
                //Ubicar Distrito
                foreach (Distrito iteraUbigeo in CboCoddis.Items)
                {
                    if (iteraUbigeo.CodDis.Equals(codDis))
                    {
                        CboCoddis.SelectedItem = iteraUbigeo;
                        break;
                    }
                }
                
              //ahora Ubicar COntrol en Combo de Distrito
                CboCoddis.Select(); 

            }
        }

        internal void CargaProvincias(string cDep)
        {
            CboCodProv.DataSource = ProvinciaDao.GetAllByDepartamento( cDep);
            CboCodProv.ValueMember = "CodProv";
            CboCodProv.DisplayMember = "Denomi";
        }

        internal void CargaDistritos(string cProv)
        {
            CboCoddis.DataSource = DistritoDao.GetAllByCodProv( cProv);
            CboCoddis.ValueMember = "CodDis";
            CboCoddis.DisplayMember = "Denomi";
        }
  
    } //Fin de Clase
} //Fin de NameSpace