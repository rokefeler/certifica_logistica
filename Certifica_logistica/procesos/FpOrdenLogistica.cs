using System;
using System.Globalization;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using Certifica_logistica.modulos;
using DaoLogistica.DAO;

namespace Certifica_logistica.procesos
{
    public partial class FpOrdenLogistica : Masterform
    {
        private DsTramite.TTipoUsuarioDataTable _tbUsuario;
        public FpOrdenLogistica()
        {
            InitializeComponent();
            _tbUsuario = new DsTramite.TTipoUsuarioDataTable();
        }

        private void TxtCodPersonal_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void FpOrdenLogistica_Load(object sender, System.EventArgs e)
        {
            var collection = new AutoCompleteStringCollection();
            string[] str ={"FACTURA","BOLETA DE VENTA","SERV.LUZ ELECTRICA","SERV.LUZ TRIFASICA","SERV.AGUA","SERV.TELEFONIA MOVIL","SERV.TELEFONIA FIJA","SERV.INTERNET","LABOR REALIZADA (rph)","PROPINAS","MOVILIDAD","VIATICOS","PASAJES AEREOS","RECIBO","PASAJES TERRESTRES","SERV.CABLE","DOCENTE EXTRANJERO"};
            collection.AddRange(str);
            TxtReferencia.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TxtReferencia.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TxtReferencia.MaskBox.AutoCompleteCustomSource = collection;
            var ninicial = DateTime.Now.Year;
            CboYearExp.Items.Clear();
            for (var i = ninicial; i >= 2012; i--)
                CboYearExp.Items.Add(i.ToString(CultureInfo.InvariantCulture));

            CboYearExp.SelectedIndex = 0;
            CboMoneda.SelectedIndex = 0;
            General.CargarDatos(CboTipoProceso, "PCAD", "PCAD-0000");
            CboFuente.DataSource = FuenteFinanciamientoDao.SelectAll();
            CboFuente.ValueMember = "IdFuente";
            CboFuente.DisplayMember = "Abreviacion";
            CboFuente.SelectedIndex = 3;

            General.RellenarEstadoDataSet(ref _tbUsuario);
            CboTipoUsuario.Properties.DataSource = _tbUsuario;
            CboTipoUsuario.Properties.DisplayMember = "nombre";
            CboTipoUsuario.Properties.ValueMember = "Sigla";
            
        }
    }
}
