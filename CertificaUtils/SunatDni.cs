using System;
using System.IO;
using System.Net;
using System.Web;

namespace CertificaUtils
{
    public class SunatDni
    {
         #region Private
        private const string UrlinfoDni = "http://www.sunat.gob.pe/ol-ti-itdenuncia/denS01Alias?tipodoc=1&accion=buscar&numdoc=";
        private HttpWebRequest _webRequest;
        private HttpWebResponse _webResponse;
        private string _webSource;
        private Person _persona;
        private bool _ok;
        private string _error;
        private bool LoadWebSource(string url)
        {
            _webRequest = (HttpWebRequest)WebRequest.Create(url);
            _webRequest.Proxy = null;

            try
            {
                _webResponse = (HttpWebResponse)_webRequest.GetResponse();
            }
            catch
            {
                _ok = false;
                _error = "Error al consultar con Sunat";
                return false;
            }

            var stream = _webResponse.GetResponseStream();

            var encode = System.Text.Encoding.GetEncoding("utf-8");


            if (stream != null)
            {
                var streamReader = new StreamReader(stream, encode);
                _webSource = HttpUtility.HtmlDecode(streamReader.ReadToEnd());
                return true;
            }
            return false;
        }

        private void LoadInfoPersona(string dni)
        {
            if (!LoadWebSource(String.Format("{0}{1}", UrlinfoDni, dni))) return;
            if (_webSource.Length <= 120000)
                {
                 _ok = false;
                _error = @"El número de DNI ingresado no existe en la Base de datos de la SUNAT";
                return;    
                }
            //string cad = HtmlRemove.StripTagsCharArray(_webSource);
            var cad = _webSource.Trim();
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
                    _persona.ApePaterno = "-";
                    _persona.ApeMaterno = nombres[0];
                    _persona.Nombres = String.Format("{0} {1}", nombres[1], nombres[2]);
                }
                else
                {
                    _persona.ApePaterno = nombres[0];
                    _persona.ApeMaterno = nombres[1];
                    _persona.Nombres = String.Format("{0} {1}", nombres[2], nombres[3]);
                }
            _ok = true;
        }
        #endregion
        #region Constructor
        public SunatDni(string dni)
        {
            _persona = new Person();
            _ok = false;
            _error = "";
            LoadInfoPersona(dni);
        }

        #endregion

        #region Public
        public string Error
        {
            get {
                return _ok ? string.Empty : _error;
            }
        }
        public Person GetPersona
        {
            get {
                return _ok ? _persona : null;
            }
        }
        #endregion
    }
}
