using System;
using System.Windows.Forms;
using Certifica_logistica.modulos;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;


namespace Certifica_logistica
{
    public partial class Masterform : Form
    {
        //Tiene un Control de Procesar o Ejecutar
        // Identifica si ya hay una instancia activa
        //public bool _HayInstancia;
// ReSharper disable once InconsistentNaming
        public  Inicioform _FrmPadre;
// ReSharper disable InconsistentNaming
        public bool _IsBloqueado; //Esta Bloqueado el Ambiente ?
// ReSharper restore InconsistentNaming
        // ReSharper disable once InconsistentNaming
        public SDerechoFormulario _DerechoFormulario;
        
        // Identifica a la instancia activa
// ReSharper disable once InconsistentNaming
        public Masterform _InstanciaActiva;
        //public e_EstadoFormulario EstadoForm;
        public string Value; //Valor a Devolver del Formulario
        public string TagValue; //para Valores temporales
        /// <summary>
        /// Nro de expediente cargado o a cargar
        /// </summary>
        //public string _nExpediente; 
        public Masterform()
        {
            InitializeComponent();
            //_IsBloqueado = 1;
            //_nExpediente = String.Empty;
            _haveRun = true; //Verdadero por defecto
            _FrmPadre = null;
            _InstanciaActiva = null;
            _DerechoFormulario= new SDerechoFormulario
            {
                Procesar = true,
                Nuevo = false,
                Eliminar = false,
                Grabar = false,
                GrabarNombre = "&Grabar",
                ProcesarNombre = "&Procesar",
                NuevoNombre = "&Nuevo",
                EliminarNombre = "&Eliminar"
            };
        }
        /// <summary>
        /// Permite Grabar y/o Actualizar los Datos del Formulario Actual.
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_GrabarFormulario()
        {
            return false;
        }
        /// <summary>
        /// PErmite Ejecutar la orden principal del Formulario activo
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_RunFormulario()
        {
            return false;
        }
        /// <summary>
        /// Permite Cerrar el Formulario
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_CerrarFormulario()
        {
            Close();
            return true;
        }
        /// <summary>
        /// Permite Crear La creación de Una Nueva Entrada
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_NuevoFormulario()
        {
            return false;
        }
        /// <summary>
        /// Cancela cualquier edición, Limpiando todos los controles 
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_LimpiarFormulario()
        {
            foreach(Control ctrl in Controls)
                switch (ctrl.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        if (ctrl.Tag != null) if (ctrl.Tag.Equals("0")) break; 
                        ctrl.Text = "";
                        break;
                    case "System.Windows.Forms.NumericUpDown":
                        var spn = (NumericUpDown) ctrl;
                        if (spn.Tag != null) if (spn.Tag.Equals("0")) break; 
                        spn.Value = 0m;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        var cbo = (ComboBox) ctrl;
                        if (cbo.Tag != null) if (cbo.Tag.Equals("0")) break;
                        cbo.DataSource = null;
                        cbo.DisplayMember = null;
                        cbo.ValueMember = null;
                        break;
                    case "System.Windows.Forms.CheckBox":
                        var chk = (CheckBox)ctrl;
                        if (chk.Tag != null) if (chk.Tag.Equals("0")) break;
                        chk.CheckState = CheckState.Unchecked;
                        break;
                    case "System.Windows.Forms.ListView":
                        using (var lst2 = (ListView) ctrl)
                        {
                            if (lst2.Tag != null) if (lst2.Tag.Equals("0")) break;
                            lst2.Items.Clear();
                        }
                        break;
                    case "DevExpress.XtraEditors.ButtonEdit":
                        var btn = (ButtonEdit)ctrl;
                        btn.EditValue = null;
                        break;
                    case "System.Windows.Forms.PictureBox":
                        var pic = (PictureBox)ctrl;
                        if (pic.Tag != null)
                            if (pic.Tag.Equals("0"))
                                break;
                        General.Liberar_Imagen(pic);
                        break;
                    case "System.Windows.Forms.ListBox":
                        var lst = (ListBox)ctrl;
                        if (lst.Tag != null)
                            if (lst.Tag.Equals("0"))
                                break;
                        lst.Items.Clear();
                        break;

                    case "DevExpress.XtraTab.XtraTabPage":
                    case "System.Windows.Forms.GroupBox":
                    Master_LimpiarFormulario(ctrl.Controls);
                        break;
                }
            return true;
        }
        public virtual bool Master_LimpiarFormulario(Control.ControlCollection coleccion)
        {
                foreach (Control ctrl in coleccion)
                switch (ctrl.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        if (ctrl.Tag != null) if (ctrl.Tag.Equals("0")) break; 
                        ctrl.Text = "";
                        break;
                    case "System.Windows.Forms.NumericUpDown":
                        var spn = (NumericUpDown)ctrl;
                        if (spn.Tag != null) if (spn.Tag.Equals("0")) break; 
                        spn.Value = 0m;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        var cbo = (ComboBox)ctrl;
                        if (cbo.Tag != null) if (cbo.Tag.Equals("0")) break;
                        cbo.DataSource = null;
                        cbo.DisplayMember = null;
                        cbo.ValueMember = null;
                        break;
                    case "System.Windows.Forms.CheckBox":
                        var chk = (CheckBox)ctrl;
                        if (chk.Tag != null) if (chk.Tag.Equals("0")) break;
                        chk.CheckState = CheckState.Unchecked;
                        break;
                    case "System.Windows.Forms.MaskedTextBox":
                        var msk = (MaskedTextBox)ctrl;                       
                        if (msk.Tag != null) 
                            if (msk.Tag.Equals("0")) 
                                break;
                        msk.Text= "";
                        break;
                    case "DevExpress.XtraEditors.ButtonEdit":
                        var btn = (ButtonEdit)ctrl;
                        btn.EditValue = null;
                        break;
                    case "System.Windows.Forms.PictureBox":
                        var pic = (PictureBox) ctrl;
                        if (pic.Tag != null)
                            if (pic.Tag.Equals("0"))
                                break;
                        General.Liberar_Imagen(pic);
                        break;
                    case "System.Windows.Forms.ListBox":
                        var lst = (ListBox) ctrl;
                        if (lst.Tag != null)
                            if (lst.Tag.Equals("0"))
                                break;
                        lst.Items.Clear();
                        break;
                        
                    case "DevExpress.XtraTab.XtraTabPage":
                    case "System.Windows.Forms.GroupBox":
                        Master_LimpiarFormulario(ctrl.Controls);
                        break;
                }
            return true;
        }
        /// <summary>
        /// Permite imprimir Contenido de Formulario (Si Formulario Soporta)
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_ImprimirFormulario(bool isPrevio, int nCopias)
        {
            return true;
        }
        /// <summary>
        /// Permite Eliminar un Registro Mostrado
        /// </summary>
        /// <returns></returns>
         public virtual bool Master_EliminarFormulario()
        {
            return false;
        }
        /// <summary>
        /// Para Formularios de Operatividad, COnformidad y otros y se pueda Bloqeuar o desbloquear un Expediente
        /// para lo cual debe tener los derechos correspondientes
        /// </summary>
        /// <returns>bool</returns>
 
        public virtual bool Master_BloquearFormulario()
         {
             return false;
         }
        /// <summary>
        /// Permite Imprimir los Datos Actuales
        /// </summary>
        /// <returns></returns>
        public virtual bool ImprimirFormulario()
        {
            return false;
        }
        
        //Procesa cualquier comando temporal, ejemplo para planillas pueda procesar de un solo pepo todas las facturas su constancia de Deposito.
        public virtual bool Master_Procesar2()
        {
            return false;
        }
        /*
        private void masterform_Deactivate(object sender, EventArgs e)
        {
            _FrmPadre.Run
        }*/
        
        /// <summary>
        /// Cuando Ingrese al COntrol que Seleccione T odo el Texto por Defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void ObjectEnter(object sender, EventArgs e)
        {
            try
            {
                switch (sender.GetType().ToString())
                {
                    case "System.Windows.Forms.TextBox":
                        var txt = (TextBox) sender;
                        if (txt.Tag != null) if (txt.Tag.Equals("0")) break;
                        txt.SelectAll();
                        break;
                    case "System.Windows.Forms.NumericUpDown":
                        var spn = (NumericUpDown) sender;
                        if (spn.Tag != null) if (spn.Tag.Equals("0")) break;
                        spn.Select(0, spn.Text.Length);
                        break;
                    case "System.Windows.Forms.ComboBox":
                        var cbo = (ComboBox) sender;
                        if (cbo.Tag != null) if (cbo.Tag.Equals("0")) break;
                        cbo.SelectAll();
                        break;
                    case "System.Windows.Forms.MaskedTextBox":
                        var msk = (MaskedTextBox) sender;
                        msk.SelectionStart = 0;
                        msk.SelectionLength = msk.TextLength;
                        break;
                    case "DevExpress.XtraEditors.ButtonEdit":
                        var btn = (ButtonEdit) sender;
                        btn.SelectAll();
                        break;
                }
            }
            catch
            {
                Console.Beep();
            }
        }

        public virtual void Object_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void Masterform_Activated(object sender, EventArgs e)
        {
            try
            {
                if (MdiParent == null) return;
                var oFrm = (Inicioform)MdiParent;
                //if (_DerechoFormulario.Procesar)
                //{
                oFrm.RunToolStrip.Enabled = _DerechoFormulario.Procesar;
                oFrm.procesarToolStrip.Enabled = _DerechoFormulario.Procesar;
                oFrm.RunToolStrip.Text = _DerechoFormulario.ProcesarNombre;
                oFrm.procesarToolStrip.Text = _DerechoFormulario.ProcesarNombre;
                //}
                //if (_DerechoFormulario.Grabar)
                //{
                oFrm.toolStripGrabar.Enabled = _DerechoFormulario.Grabar;//Visible;
                oFrm.saveToolStrip.Enabled = _DerechoFormulario.Grabar;//Visible;
                oFrm.toolStripGrabar.Text = _DerechoFormulario.GrabarNombre;
                oFrm.saveToolStrip.Text = _DerechoFormulario.GrabarNombre;
                //}
                //if (_DerechoFormulario.Nuevo)
                //{
                oFrm.newToolStrip.Enabled = _DerechoFormulario.Nuevo;//Visible;
                oFrm.nuevoToolStrip.Enabled = _DerechoFormulario.Nuevo;//Visible;
                oFrm.newToolStrip.Text = _DerechoFormulario.NuevoNombre;
                oFrm.nuevoToolStrip.Text = _DerechoFormulario.NuevoNombre;
                //}
                //if (_DerechoFormulario.Eliminar)
                //{
                oFrm.deleteToolStrip.Enabled = _DerechoFormulario.Eliminar;//Visible;
                oFrm.toolStripEliminar.Enabled = _DerechoFormulario.Eliminar; //Visible;
                oFrm.deleteToolStrip.Text = _DerechoFormulario.EliminarNombre;
                oFrm.toolStripEliminar.Text = _DerechoFormulario.EliminarNombre;
                //}
            }
            catch
            {
                Console.Beep();
            }
        }
        /// <summary>
        /// Permite verificar si el Usuario cumplio con ingresar los datos minimos para Poder grabar
        /// </summary>
        /// <returns></returns>
        public virtual bool Master_Verificar()
        {
            return false;
        }

       /// <summary>
       /// Permite cargar los datos del Valor Primario que se desee
       /// </summary>
       /// <param name="idPrincipal"></param>
       /// <param name="idSecundario"></param>
       /// <returns></returns>
        public virtual bool Master_CargarFicha(String idPrincipal, String idSecundario=null)
        {
            return false;
        }
    }
}