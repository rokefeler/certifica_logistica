using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web;

namespace CertificaUtils
{
    public class Reniec
    {
        public enum Resul
        {
            /// <summary>
            /// Se encontro la persona
            /// </summary>
            Ok = 0,
            /// <summary>
            /// No se encontro la persona
            /// </summary>
            NoResul = 1,
            /// <summary>
            /// la imagen capcha no es valida
            /// </summary>
            ErrorCapcha = 2, 
            /// <summary>
            /// Error no especificado
            /// </summary>
            Error=3,
        }

        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private CookieContainer _myCookie;

        #region Propiedades

        /// <summary>
        /// Devuelve la imagen para el reto capcha
        /// </summary>
        public Image GetCapcha { get { return ReadCapcha(); } }

        public Person Persona { get; set; }

        /// <summary>
        /// Devuelve el resultado de la busqueda de DNI
        /// </summary>
        public Resul GetResul { get; private set; }

        #endregion

        #region Constructor

        public Reniec()
        {
            try
            {
                Persona = new Person();
                _myCookie = null; 
                _myCookie = new CookieContainer();

                //Permitir SSL
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                ReadCapcha();
            }
            catch (Exception ex)
            {
// ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        #endregion

        /// <summary>
        /// Carga la imagen Capcha
        /// </summary>
        private Image ReadCapcha()
        {
            try
            {
                var myWebRequest = (HttpWebRequest)WebRequest.Create("https://cel.reniec.gob.pe/valreg/codigo.do");

                myWebRequest.CookieContainer = _myCookie;

                myWebRequest.Proxy = null;

                myWebRequest.Credentials = CredentialCache.DefaultCredentials;

                var myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();

                var myImgStream = myWebResponse.GetResponseStream();

                //myWebResponse.Close();

// ReSharper disable once AssignNullToNotNullAttribute
                return Image.FromStream(myImgStream);
            }
            catch (Exception ex)
            {
// ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        /// <summary>
        /// Inicia la carga de los datos de la persona 
        /// </summary>
        /// <param name="numDni"></param>
        /// <param name="imgCapcha"></param>
        public void GetInfo(string numDni, string imgCapcha)
        {
            try
            {
                var myUrl = String.Format("https://cel.reniec.gob.pe/valreg/valreg.do?accion=buscar&nuDni={0}&imagen={1}",
                                        numDni, imgCapcha);

                var myWebRequest = (HttpWebRequest)WebRequest.Create(myUrl);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";//esto creo que lo puse por gusto :/
                myWebRequest.CookieContainer = _myCookie;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;

                var myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();

                var myStream = myHttpWebResponse.GetResponseStream();

                if (myStream != null)
                {
                    var myStreamReader = new StreamReader(myStream);

                    var webSource = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

                    var split = webSource.Split(new[] { '<', '>', '\n', '\r' });
                
                    var resul = new List<string>();

                    //quitamos todos los caracteres nulos
                    for (int i = 0; i < split.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(split[i].Trim()))
                            resul.Add(split[i].Trim());
                    }

                    // Anlizando la el arreglo "_resul" llegamos a la siguiente conclusion
                    // 
                    // _resul.Count == 217 cuando nos equivocamos en el captcha
                    // _resul.Count == 232 cuando todo salio ok
                    // _resul.Count == 222 cuando no existe el DNI
                    //

                    switch (resul.Count)
                    {
                        case 217:
                            GetResul = Resul.ErrorCapcha;
                            break;
                        case 232:
                            GetResul = Resul.Ok;
                            break;
                        case 222:
                            GetResul = Resul.NoResul;
                            break;
                        default:
                            GetResul = Resul.Error;
                            break;
                    }

                    if (GetResul == Resul.Ok)
                    {
                        Persona.Nombres = resul[185];
                        Persona.ApePaterno = resul[186];
                        Persona.ApeMaterno = resul[187];
                    }
                }

                myHttpWebResponse.Close();   
            }
            catch (Exception ex)
            {
// ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
