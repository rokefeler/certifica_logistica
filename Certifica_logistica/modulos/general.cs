using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Certifica_logistica.Ds;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using Rebex.Net;
using Winnovative.ExcelLib;

namespace Certifica_logistica.modulos
{
// ReSharper disable once InconsistentNaming
static class CONSTANTE
{
    public const string PALABRAPASO="Con Cristo Hacemos Grandes Cosas Mt 6:31";
    // ReSharper disable once InconsistentNaming
     public const string PALABRASALTO = "Mas nosotros tenemos la mente de Cristo 1 Cor. 2:16";
     public const string VECTOR16 = "ROKEFELER@GMAIL.COM";
     public const int LONGITUD = 256; //128, 192, 256
     public const string HashProvider = "HashCertifica"; 
     public const string CryptoProvider = @"CryptoCertifica";
     public const string Catalogo = @"Logistica";
     public const string Puerto = @"1250";
     public const string UserDb = "sys"+"dba"+"log";
     public const string Syn = "dGb"+"UTA"+"XVS"+"26Q"+"JnZ"+"CC1"+"Na";
     public const string PasswordDb = @"6um"+"BUIy"+"sI4S"+"kvX"+"NAA"+"0ad";
}
    public enum ENumTabla
    {
        // ReSharper disable once InconsistentNaming
        NINGUNO = 0,
        // ReSharper disable once InconsistentNaming
        ALUMNO,
        // ReSharper disable once InconsistentNaming
        META,
        // ReSharper disable once InconsistentNaming
        PERSONAL, 
        // ReSharper disable once InconsistentNaming
        PROVEEDOR,
        // ReSharper disable once InconsistentNaming
        SERVICIOS,
        // ReSharper disable once InconsistentNaming
        SUBDEPENDENCIA,
        // ReSharper disable once InconsistentNaming
        RUBRO,
        // ReSharper disable once InconsistentNaming
        ORDENSERVICIO,
        // ReSharper disable once InconsistentNaming
        EXPEDIENTE
    };
    public enum ENumTipoOrden
    {
        // ReSharper disable once InconsistentNaming
        PARAORDEN = -1,
        // ReSharper disable once InconsistentNaming
        NINGUNO = 0,
        // ReSharper disable once InconsistentNaming
        SERVICIO = 1,
        // ReSharper disable once InconsistentNaming
        VIATICOS=2,
        // ReSharper disable once InconsistentNaming
        CONVENIO=3,
        // ReSharper disable once InconsistentNaming
        PROPINAS=4,
        // ReSharper disable once InconsistentNaming
        MOVILIDAD=5,
        // ReSharper disable once InconsistentNaming
        COMPRA=6
    };
    public struct SDerechoFormulario
    {
        public bool Nuevo;
        public bool Grabar;
        public bool Procesar;
        public bool Eliminar;
        public bool Corregir; //Excepcional para Tramite
        public string NuevoNombre;
        public string GrabarNombre;
        public string ProcesarNombre;
        public string EliminarNombre;
        public string CorregirNombre;
    }

    public enum ETipoDeBien
    {
        Patrimonio=1,
        Inventario
    }
   
    /// <summary>
    /// Permitira controlar los Datos que deben de ser exigidos 
    /// </summary>
    public struct SExigirCompletarDatos
    {
        public bool ExigirMedidas;
        public bool ExigirColor;
        public bool ExigirMarca;
        public bool ExigirSerie;

        public void Reset()
        {
            ExigirMedidas = false;
            ExigirColor = false;
            ExigirMarca = false;
            ExigirSerie = false;
        }
    }
    /*
    public enum e_EstadoFormulario
    {
        Ninguno=1,
        FueCambiado = 2,
        NoFueCambiado = 3,
        CargarDatos = 4,
        DatosFueronGrabados= 5
    };
    public enum e_QuedeboHacer
    {
        CargarSegunCodigo= 1,
        CrearUnoNuevo,
        ModificarExistente
    };
     * 
    /// <summary>
    /// Tipos de Datos que se contendra en Variable Global MiConfiguration en InicioForm
    /// </summary>*/
// ReSharper disable once InconsistentNaming
    public enum e_TipoDeDatoTemporal
    {
        Ninguno = 0,
        Alumno=1,
        Cliente,
        Proveedor,
        Expediente,
        OrdenLogistica,
    }
    
   public class General
    {
        public e_TipoDeDatoTemporal TipoTemporal;
        public string Temporal;
        public string IdUsuario       {get; set; }
       /// <summary>
       /// Periodo actual por defecto para Consultas de Inventarios
       /// </summary>
 
       public string PeriodoActual   { get; set; }

       /// <summary>
       /// Id de la Conexion en la Base de Datos
       /// </summary>
       public int IdConexion    {get; set;}

       private string _derechos;
        public string Derechos
        {
            get { return _derechos; }
            set { _derechos = value;
            while(_derechos.Length < 79)
                _derechos = _derechos + "0";
            }
        }
        public string Nombre        {get; set; }

        public  string PathServerFotos { get; set; }
        public string PrinterName {get; set;}

        public string Sede {get; set;}
        public PaperSize PrinterPaperSize{get; set;}
        public string Hostname {get; set;}
        public string Ip {get; set;}

        public DateTime HoraDeInicio {get;set;}
        public string RazonEmpresa { get; set; }
        public string RucEmpresa { get; set; }
        /// <summary>
        /// Código de Identificación de Institución, segun la SBN
        /// </summary>
        public string CodigoEmpresa { get; set; }

       /* public bool ComprobarDerechos(e_Derechos derecho)
        {
            //TODO Falta IMplementar COmprobar Derechos - general.cs, hacerlo despues
            return true;
        }*/
        public General()  //Constructor
        {
            TipoTemporal = e_TipoDeDatoTemporal.Ninguno;
            Temporal = null; //Vacio por defecto
            HoraDeInicio = DateTime.Now;
        }
        public static bool VerificarRuc(string ruc)
        {
            var pos1 = new int[11];
            int[] pos2 = {5,4,3,2,7,6,5,4,3,2,0};

            var suma = 0L; 
            bool ret;
            try
            {
                ruc = ruc.Trim();
            if (ruc.Length != 11) return false;
            for (var x = 1; x <= 11; x++)
            {
                pos1[x - 1] = int.Parse(ruc.Substring(x-1, 1));
                suma += pos1[x - 1] * pos2[x - 1];
                //Pos3[10] += Pos3[x - 1];
            }
            
            var residuo = (int)suma%11;
            var ultimoDigito = 11 - residuo;
            switch (ultimoDigito)
            {
                case 10:
                    ultimoDigito = 0;
            	    break;
                case 11:
                    ultimoDigito = 1;
                    break;
            }
            ret = ultimoDigito == pos1[10];
            }
            catch
            {
            	ret = false;
            }
            
            return ret;
        }
        public static bool LeerServerFtp(string carpeta, ref Ftp myftp, Boolean isRoot)
        {
            TimeSpan Dif ;
            FtpList list;
            try
            {
                list = myftp.GetList(carpeta);

            }
            catch
            {
                myftp.Disconnect();
                return false; //salir
            }
            
            myftp.ChangeDirectory(carpeta);
            //Crear Carpeta Nueva
            foreach (var iTem in list)
            {
                //tBytes += iTem.Size;
                var fileLocal = new FileInfo(Application.StartupPath + "\\" + iTem.Name);
                if (fileLocal.Attributes == FileAttributes.Directory)
                {
                    LeerServerFtp(fileLocal.Name, ref myftp, false);
                }
                else if(fileLocal.Attributes == FileAttributes.Archive)
                {
                    if (fileLocal.Exists)
                    {
                        Dif = fileLocal.LastWriteTime.Subtract(iTem.Modified);
                        if (Math.Abs(Dif.Minutes) > 10)
                        {
                            File.Move(fileLocal.FullName, fileLocal.FullName + "_" + DateTime.Now.Day.ToString(CultureInfo.InvariantCulture) + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute);
                            if (isRoot)
                                myftp.GetFile(iTem.Name, Application.StartupPath + "\\" + iTem.Name);
                            else
                                myftp.GetFile(iTem.Name, Application.StartupPath + "\\" + carpeta + "\\" + iTem.Name);
                        }
                    }
                    else
                    {
                        if(isRoot)
                            myftp.GetFile(iTem.Name, Application.StartupPath + "\\" + iTem.Name);
                        else
                            myftp.GetFile(iTem.Name, Application.StartupPath + "\\" + carpeta + "\\" + iTem.Name);
                    }
                }
            }
            return true;
        }
        public static void Liberar_Imagen(PictureBox picFoto)
        {
            if (picFoto.Image == null) return;
            picFoto.Image.Dispose(); 
            picFoto.Image = null;
        }
        public static void ShowMessage(string msg, string titulo="Aviso", 
            MessageBoxButtons button= MessageBoxButtons.OK, 
            MessageBoxIcon icon= MessageBoxIcon.Information )
        {
            Console.Beep();
            MessageBox.Show(msg, titulo, button, icon);
        }
        public static void RellenarEstadoDataSet(ref DsTramite.TTipoUsuarioDataTable tbE, ENumTipoOrden tipoOrden= ENumTipoOrden.PARAORDEN, bool esParaDetalle=false)
        {
            //[V=Proveedor] - [P=Personal] - [A=Alumno] - [S=Servicios] [N=Ninguno]
            var r = tbE.NewRow();
            r[0] = 'N';
            r[1] = " Ninguno";
            tbE.Rows.Add(r);
            switch (tipoOrden)
            {
                case ENumTipoOrden.NINGUNO:
                    r = tbE.NewRow();
                    r[0] = 'A';
                    r[1] = "ALUMNO";
                    tbE.Rows.Add(r);

                    r = tbE.NewRow();
                    r[0] = 'P';
                    r[1] = "PERSONAL / DOC.EXTRANJ.";
                    tbE.Rows.Add(r);

                    r = tbE.NewRow();
                    r[0] = 'V';
                    r[1] = "PROVEEDOR";
                    tbE.Rows.Add(r);

                    r = tbE.NewRow();
                    r[0] = 'S';
                    r[1] = "SERVICIOS";
                    tbE.Rows.Add(r);
                    break;
                case ENumTipoOrden.PROPINAS:
                    r = tbE.NewRow();
                    r[0] = 'A';
                    r[1] = "ALUMNO";
                    tbE.Rows.Add(r);
                    break;
                case ENumTipoOrden.MOVILIDAD:
                case ENumTipoOrden.VIATICOS:
                case ENumTipoOrden.CONVENIO:
                    r = tbE.NewRow();
                    r[0] = 'P';
                    r[1] = "PERSONAL / DOC.EXTRANJ.";
                    tbE.Rows.Add(r);
                    break;
                case ENumTipoOrden.SERVICIO:
                    r = tbE.NewRow();
                    r[0] = 'V';
                    r[1] = "PROVEEDOR";
                    tbE.Rows.Add(r);
                    if (!esParaDetalle) break;
                    r = tbE.NewRow();
                    r[0] = 'S';
                    r[1] = "SERVICIOS";
                    tbE.Rows.Add(r);
                    break;
               /*
                    r = tbE.NewRow();
                    r[0] = 'P';
                    r[1] = "PERSONAL / DOC.EXTRANJ.";
                    tbE.Rows.Add(r);
                    break;
                    */
            }
            
        }
  
        public static Bitmap ByteToImage(byte[] blob)
        {
            var mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            var bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

       //Ubica un COdigo dado dentro de un ComboBox 
       public static void UbicaItemsComboCodigo(ComboBox cbo, string codigo, string nombre=null)
        {
            foreach (Codigo c in cbo.Items)
            {
                if(string.IsNullOrEmpty(nombre))
                {
                    if (!c.Id.Equals(codigo)) continue;
                    cbo.SelectedItem = c;
                    break;
                }
// ReSharper disable once RedundantIfElseBlock
                else
                {
                    if (!c.Nombre.Equals(nombre)) continue;
                    cbo.SelectedItem = c;
                    break;
                }
            }
        }
       //Cargar un Combo con un Tipo de Codigo
       public static void CargarDatos(ComboBox cbo, string tipo, string clave=null, string referencia=null)
       {
           try
           {
               cbo.DataSource = !string.IsNullOrEmpty(referencia) 
                                ? CodigoDao.SelectAllGetby(tipo, referencia, Bit.Verdadero) 
                                : CodigoDao.SelectAllGetby(tipo,estado: Bit.Verdadero);
               cbo.ValueMember = "Id";
               cbo.DisplayMember = "Nombre";

               //UBICAR CUAL ES EL CÓDIGO AÑADIDO.
               if (!string.IsNullOrEmpty(clave))
                   UbicaItemsComboCodigo(cbo,clave);
           }
           catch (Exception ex)
           {
               ShowMessage(ex.Message, "Error interno - Codigos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
       }

       public static string GetIp4Address()
       {
           var ip4Address = String.Empty;
           
           foreach (var ipa in Dns.GetHostAddresses(Dns.GetHostName()))
           {
               if (ipa.AddressFamily != AddressFamily.InterNetwork) continue;
               ip4Address = ipa.ToString();
               break;
           }
           return ip4Address;
       }


       public static ENumTabla DeterminaTipoUsuario(char cTipo, out string cNombre)
       {
           ENumTabla tipo;//[V=Proveedor] - [P=Personal] - [A=Alumno] - [S=Servicios] [N=Ninguno]
           switch (cTipo)
           {
               case 'V':
                   tipo= ENumTabla.PROVEEDOR;
                   cNombre = "PROVEEDOR";
                   break;
               case 'P':
                   tipo = ENumTabla.PERSONAL;
                   cNombre = "PERSONAL";
                   break;
               case 'A':
                   tipo = ENumTabla.ALUMNO;
                   cNombre = "ALUMNO";
                   break;
               case 'S':
                   tipo = ENumTabla.SERVICIOS;
                   cNombre = "SERVICIOS";
                   break;
               default:
                   tipo = ENumTabla.NINGUNO;
                   cNombre = "NINGUNO";
                   break;
           }
           return tipo;
       }
    
       /// <summary>
       /// Permite Devolver cual es el mensaje de texto a devolver, segun el resultado devuelto por la BD
       /// </summary>
       /// <param name="ret"></param>
       /// <returns></returns>
       public static String AnalizaResultadoSql(int ret)
       {
           string cad;
           switch (ret)
           {
               case -1:
                   cad = "Ud. no cuenta con los Derechos suficientes para esta operación";
                   break;
               case -2:
                   cad = "El Expediente en Mención Esta Bloqueado o Cerrado, Consulte con su Administrador";
                   break;
               case -3:
                   cad = "El Monto Actual, Supera El SALDO APROBADO, registrado en TRAMITE";
                   break;
               case -4:
                   cad = "Imposible Continuar, Estado Actual del Registro Es ANULADO";
                   break;
               case -5:
                   cad = "Imposible Continuar, Estado Actual del Registro Es BLOQUEADO TOTAL";
                   break;
               case -6: //CambioExpediente
                   cad = "Nro. de Expediente a Cambiar, Contiene Ordenes Relacionadas - Imposible Continuar";
                   break;
               case -7: //CambioExpediente
                   cad = "Nro. de Expediente NUEVO, Ya Existe y Contiene Ordenes Relacionadas - Imposible Continuar";
                   break;
               case -8:
                    cad = "Orden Ya no se encuentra Disponible (Fue Eliminado?)- Verifique Nuevamente";
                   break;
               default:
                   cad = "PROCESO SATISFACTORIO";
                   break;
           }
           return cad;
       }
       public static string AnalizaTipoOrden(ENumTipoOrden tipoOrden)
       {
           string cod;
           switch (tipoOrden)
           {
               case ENumTipoOrden.CONVENIO:
                   cod= "TOGL-0005"; // Tipo=TOGL
                   break;
               case ENumTipoOrden.MOVILIDAD:
                   cod= "TOGL-0003"; // Tipo=TOGL
                   break;
               case ENumTipoOrden.PROPINAS:
                   cod= "TOGL-0004"; // Tipo=TOGL
                   break;
               case ENumTipoOrden.SERVICIO:
                   cod= "TOGL-0001"; // Tipo=TOGL
                   break;
               case ENumTipoOrden.VIATICOS:
                   cod= "TOGL-0002"; // Tipo=TOGL
                   break;
               case ENumTipoOrden.COMPRA:
                   cod= "TOGL-0006"; // Tipo=TOGL
                   break;
               default:
                   cod = ""; //("ERROR EN TIPO DE ORDEN", "SOS PIRATA?");
                   //Application.Exit(); //culminar aplicación
                   break;
           }
           return cod;
       }

       public static void EstiloExportarExcel(ExcelWorkbook workbook,  
           out ExcelCellStyle StyleTitulo, out ExcelCellStyle StyleHeader,
           out ExcelCellStyle StyleRows, out ExcelCellStyle FormulaTotalStyle, out Image logoImg)
       {
           //var worksheet = workbook.Worksheets[0];
           // set the license key before saving the workbook
           workbook.LicenseKey = "RW51ZXZ0ZXVldGt1ZXZ0a3R3a3x8fHw=";
           var worksheet = workbook.Worksheets[0];
            #region CREATE CUSTOM WORKBOOK STYLES

            #region Add a style used for the cells in the worksheet title area

            var titleStyle = workbook.Styles.AddStyle("WorksheetTitleStyle");
            // center the text in the title area
            titleStyle.Alignment.HorizontalAlignment = ExcelCellHorizontalAlignmentType.Left;
            titleStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            // set the title area borders
            titleStyle.Borders[ExcelCellBorderIndex.Bottom].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Top].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Left].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Medium;
            titleStyle.Borders[ExcelCellBorderIndex.Right].Color = Color.Green;
            titleStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Medium;
            // set the gradient fill for the title area range with a custom color
            titleStyle.Fill.FillType = ExcelCellFillType.GradientFill;
            titleStyle.Fill.GradientFillOptions.Color1 = Color.FromArgb(255, 255, 204);
            titleStyle.Fill.GradientFillOptions.Color2 = Color.White;
            // set the title area font 
            titleStyle.Font.Size = 14;
            titleStyle.Font.Bold = true;
            titleStyle.Font.UnderlineType = ExcelCellUnderlineType.Single;
            StyleTitulo = titleStyle;
            #endregion

            #region Add a style used for the data table header

            var dataHeaderStyle = workbook.Styles.AddStyle("DataHeaderStyle");
            dataHeaderStyle.Font.Size = 10;
            dataHeaderStyle.Font.Bold = true;
            dataHeaderStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            dataHeaderStyle.Alignment.HorizontalAlignment = ExcelCellHorizontalAlignmentType.Left;
            dataHeaderStyle.Fill.FillType = ExcelCellFillType.SolidFill;
            dataHeaderStyle.Fill.SolidFillOptions.BackColor = Color.LightBlue;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            dataHeaderStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;
            StyleHeader = dataHeaderStyle;
            #endregion
            #region Add a style used for table Details

            var detailsRowsrStyle = workbook.Styles.AddStyle("DetailsRowStyle");
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            detailsRowsrStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;
            StyleRows = detailsRowsrStyle;

            #endregion
            #region Add a style used for the formula results

            var formulaResultStyle = workbook.Styles.AddStyle("FormulaResultStyle");
            formulaResultStyle.Font.Size = 10;
            formulaResultStyle.Font.Bold = true;
            formulaResultStyle.Alignment.VerticalAlignment = ExcelCellVerticalAlignmentType.Center;
            formulaResultStyle.Fill.FillType = ExcelCellFillType.SolidFill;
            formulaResultStyle.Fill.SolidFillOptions.BackColor = Color.FromArgb(204, 255, 204);
            formulaResultStyle.Borders[ExcelCellBorderIndex.Bottom].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Top].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Left].LineStyle = ExcelCellLineStyle.Thin;
            formulaResultStyle.Borders[ExcelCellBorderIndex.Right].LineStyle = ExcelCellLineStyle.Thin;
            FormulaTotalStyle = formulaResultStyle;
            #endregion
            #endregion

            #region WORKSHEET PAGE SETUP

            // set worksheet paper size and orientation, margins, header and footer
            worksheet.PageSetup.PaperSize = ExcelPagePaperSize.PaperA4;
            worksheet.PageSetup.Orientation = ExcelPageOrientation.Landscape;
            worksheet.PageSetup.LeftMargin = 0.5;
            worksheet.PageSetup.RightMargin = 0.5;
            worksheet.PageSetup.TopMargin = 1;
            worksheet.PageSetup.BottomMargin = 0.5;

            // add header and footer

            //display a logo image in the left part of the header
            var imagesPath = Path.Combine(Application.StartupPath, @"images"); //..\..\Images"
            logoImg = Image.FromFile(Path.Combine(imagesPath, "logo.jpg"));
           
               worksheet.PageSetup.LeftHeaderFormat = "&G";
               worksheet.PageSetup.LeftHeaderPicture = logoImg;
           // display Fecha y hora in the right part of the header
               worksheet.PageSetup.RightHeaderFormat = "&D &T";

               // add worksheet header and footer
               // display the workbook file name in the left part of the footer
               worksheet.PageSetup.LeftFooterFormat = "&F";
               // display the page number in the center part of the footer
               worksheet.PageSetup.RightFooterFormat = "&P";
           

           #endregion
       }
   
    } //--no borrar
}