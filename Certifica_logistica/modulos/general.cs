using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using DaoLogistica;
using DaoLogistica.DAO;
using DaoLogistica.ENTIDAD;
using Rebex.Net;

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
     public const string CryptoProvider = "CryptoCertifica";
     public const string UserDb = "sys"+"dba"+"log";
     public const string Syn = "dGb"+"UTA"+"XVS"+"26Q"+"JnZ"+"CC1"+"Na";
     public const string PasswordDb = "xeg"+"x8@"+"py^e"+"62x"+"Cz_Y"+"]D";
}
    public enum ENumTabla
    {
        Cliente = 1,
        Contacto,
        Ingenieros, //Tabla de Ing. responsbales para CErtificados de Conformidad
        Rpin,       //Tabla de RPIN cada Rpin asociado a un codigo de cliente
        Tramitador,  //Tabla Tramitador
        Proveedor //Tabla Proveedores
    };

    public struct SDerechoFormulario
    {
        public bool Nuevo;
        public bool Grabar;
        public bool Procesar;
        public bool Eliminar;
        public string NuevoNombre;
        public string GrabarNombre;
        public string ProcesarNombre;
        public string EliminarNombre;
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
       /*
        public static void RellenarEstadoDataSet(ref DSets.DsImportar.TEstadoBienDataTable tbE)
        {
            var r = tbE.NewRow();
            r[0] = ' ';
            r[1] = " No Definido";
            tbE.Rows.Add(r);

            r = tbE.NewRow();
            r[0] = 'B';
            r[1] = "Bueno";
            tbE.Rows.Add(r);

            r = tbE.NewRow();
            r[0] = 'M';
            r[1] = "Malo";
            tbE.Rows.Add(r);

            r = tbE.NewRow();
            r[0] = 'N';
            r[1] = "Muy Bueno";
            tbE.Rows.Add(r);

            r = tbE.NewRow();
            r[0] = 'R';
            r[1] = "Regular";
            tbE.Rows.Add(r);
        }
       */
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

       public static DataTable GenerarTablaForStickers()
       {
           var tb = new DataTable();
           var c = new DataColumn { DataType = Type.GetType("System.Int32"), ColumnName = "CodBien" };
           tb.Columns.Add(c);

           c = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Denomi" };
           tb.Columns.Add(c);

           c = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "CodSbn" };
           tb.Columns.Add(c);

           c = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "CodAmbiente" };
           tb.Columns.Add(c);

           c = new DataColumn { DataType = Type.GetType("System.String"), ColumnName = "Gp" };
           tb.Columns.Add(c);

           c = new DataColumn("Codbar", typeof(byte[]));
           tb.Columns.Add(c);
           return tb;
       }

       public static bool AnalizarEstadoAmbiente(int estado, out String msgEstado)
       {
            var isBloqueado = false;
                    switch (estado)
                    {
                        case 1: //No Existe Estado 0
                            msgEstado = "Ambiente Pendiente de Asignar Responsables";
                            break;
                        case 2:
                            msgEstado = "Ambiente En Proceso de Inventario";
                            break;
                        case 3:
                            msgEstado = "Planillas de Amb. Entregadas a USUARIO, Pendientes de Firmar";
                            break;
                        case 4:
                            msgEstado =
                                "Planillas de Amb. FIRMADAS x USUARIO, ENTREGADAS a Coordinador - Ambiente Cerrado";
                            isBloqueado = true;
                            break;
                        case 5:
                            msgEstado = "Planillas de Amb. Digitalizadas, Ambiente Cerrado";
                            isBloqueado = true;
                            break;
                        case 6:
                            msgEstado = "Planillas de Amb. Empastadas en Libro, Ambiente Cerrado";
                            isBloqueado = true;
                            break;
                        case 7:
                            msgEstado = "Planillas de Amb. Conciliadas, Ambiente Cerrado";
                            isBloqueado = true;
                            break;
                        default:
                           msgEstado = "Estado de Ambiente DESCONOCIDO, COMUNIQUE AL ADMINISTRADOR";
                           isBloqueado = true;
                            break;
                    }
           return isBloqueado;
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
               default:
                   cad = "Los Datos Fueron Correctamente Grabados en la Base de Datos";
                   break;
           }
           return cad;
       }
    } //--no borrar
}