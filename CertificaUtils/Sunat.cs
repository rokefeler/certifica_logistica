using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;

namespace CertificaUtils
{
    public class Sunat
    {
        #region Private
        private const string Urlinforuc = "http://www.sunat.gob.pe/w/wapS01Alias?ruc=";
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

// ReSharper disable once UnusedMethodReturnValue.Local
        private bool ParseInfoContribuyente(IList<string> resul, string ruc)
        {
            if (resul == null) throw new ArgumentNullException("resul");
            try
            {
                _persona = new Person {Ruc = ruc};

                for (var i = 0; i < resul.Count; i++)
                {
                    switch (resul[i])
                    {
                        case "Número Ruc.":
                            _persona.RazonSocial = resul[i + 2].Substring(14);
                            break;
                        case "Antiguo Ruc.":
                            _persona.AntiguoRuc = resul[i + 5];
                            break;
                        case "Estado.": //ACTIVO - SUSPENSION TEMPORAL
                            _persona.Estado = resul[i + 2];
                            break;
                        case "Situación.": //HABIDO - NO HABIDO
                            _persona.Situacion = resul[i + 2];
                            break;
                        case "Agente Retención IGV.":
                            _persona.EsAgenteRetencion = resul[i + 3] + " " + resul[i + 5];
                            break;
                        case "Nombre Comercial.":
                            _persona.NombreComercial = resul[i + 3];
                            break;
                        case "Dirección.":
                            var cDirecion = resul[i + 3];

                            var split = cDirecion.Split(new[] { ' ' });
                            var tmp= split[split.Length - 2];
                            if (tmp.Contains("EL") || tmp.Contains("LA") || tmp.Contains("SAN") || tmp.Contains("RIO"))
                            {
                                _persona.NombreDistrito = tmp + " " + split[split.Length - 1];
                                _persona.NombreProvincia = split[split.Length - 3];
                                _persona.NombreDepartamento = split[split.Length - 4];
                            }
                            else
                            {
                                _persona.NombreDistrito = split[split.Length - 1];
                                _persona.NombreProvincia = split[split.Length - 2];
                                _persona.NombreDepartamento = split[split.Length - 3];
                            }
                            cDirecion = String.Empty;
                            for (var x = 0; x < split.Length - 3; x++)
                            {
                                if (split[x].Trim().Length == 0) continue;
                                cDirecion += split[x].Trim() + " ";
                            }
                            _persona.Direccion = cDirecion.Trim();
                            break;
                        case "Teléfono(s).":
                            _persona.Telefono = resul[i + 3];
                            if (_persona.Telefono.Trim().Length < 5)
                                _persona.Telefono = String.Empty;
                            break;
                        case "Dependencia.":
                            _persona.Dependencia = resul[i + 3];
                            break;
                        case "Tipo.":
                            _persona.TipoNegocio = resul[i + 3];
                            break;
                        case "DNI":
                            try
                            {
                                _persona.Dni = resul[i + 2].Substring(2);
                            }
                            catch
                            {
                                _persona.Dni = String.Empty;
                            }
                            break;
                        case "Fecha Nacimiento.":
                            try
                            {
                                _persona.FecNac = Convert.ToDateTime(resul[i + 2]);
                            }
                            catch
                            {
                                _persona.FecNac = new DateTime(1900,1,1);
                            }
                            break;
                    }
                }
                _ok = true; //
                
            }
            catch
            {
                _ok = false;
                _error = "Error al procesar informacion de sunat(Funcion ParseInfo)";
            }
            return _ok;
        }

        private void LoadInfoContribuyente(string ruc)
        {
            if (!LoadWebSource(String.Format("{0}{1}", Urlinforuc, ruc))) return;
            var split = _webSource.Split(new[] { '<', '>' });
            var resul = new List<string>();

            //quitamos todos los caracteres nulos y convertirmos todo  utf8
            for (var i = 0; i < split.Length; i++)
            {
                if (!string.IsNullOrEmpty(split[i].Trim()))
                    resul.Add(split[i].Trim());
            }

            if (resul.Count == 34) //no es valido o algo salio mal
            {
                _ok = false;
                _error = resul[15];
            }
            else
            {
                var car = resul[14].Split(new[] { '"' });

                if (car[1] == "Resultado")
                {
                    _ok = true;
                }
                else
                {
                    _ok = false;
                    _error = "El servidor de Sunat no devolvio una respuesta conocida(Funcion LoadInfo)";
                }
            }

            ParseInfoContribuyente(resul, ruc);
        }
        private void LoadInfoContribuyente2(string ruc)
        {
            if (!LoadWebSource(String.Format("{0}{1}", Urlinforuc, ruc))) return;
                var cTipo = String.Empty;
            var cEstado = String.Empty;
            var cNombreComercial = String.Empty;
            string cad = HtmlRemove.StripTagsCharArray(_webSource);
            cad = cad.Trim();
            if (cad.Length <= 300)
            {
                _ok = false;
                _error = @"El número Ruc ingresado no existe en la Base de datos de la SUNAT";
                return;
            }
            _persona = new Person { Ruc = ruc };
            try
            {
                cad = cad.Replace("Número Ruc.  " + ruc + " - ", "RazonSocial:");
                cad = cad.Replace("Estado.", "Estado:");
                cad = cad.Replace("Agente Retención IGV.", "AgenteRetencion:");
                cad = cad.Replace("Nombre Comercial.", "Nombre Comercial:");
                cad = cad.Replace("Dirección.", "Direccion:");
                cad = cad.Replace("Situación.", "Situacion:");
                cad = cad.Replace("Teléfono(s).", "Telefono:");

                var cad1 = "RazonSocial:";
                var cad2 = "Antiguo Ruc.";
                var x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                var y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length + 1;
                var xRazSoc = cad.Substring(x, (y - x)).Trim();

                cad1 = "Estado:";
                cad2 = "AgenteRetencion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cEstado = cad.Substring(x, (y - x)).Trim();
                }

                cad1 = "AgenteRetencion:";
                cad2 = "Nombre Comercial:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cAgenteRetencion = cad.Substring(x, (y - x)).Trim();
                if (cAgenteRetencion.Length < 5) cAgenteRetencion = "";

                cad1 = "Nombre Comercial:";
                cad2 = "Direccion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cNombreComercial = cad.Substring(x, (y - x)).Trim();
                    if (cNombreComercial.Equals("-")) cNombreComercial = "";
                }


                cad1 = "Direccion:";
                cad2 = "Situacion:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cDireccion = cad.Substring(x, (y - x)).Trim();
                var split = cDireccion.Split(new[] {' '});
                _persona.NombreDistrito = split[split.Length - 1];
                _persona.NombreProvincia = split[split.Length - 2];
                _persona.NombreDepartamento = split[split.Length - 3];
                //EdUbigeo.Text = DistritoDao.UbicaDistrito(cDis.ToUpper().Trim(), cProv.ToUpper().Trim(), cDep.ToUpper().Trim());
                var i = 0;
                cDireccion = "";
                foreach (string s in split)
                {
                    if (i < split.Length - 3)
                    {
                        if (s.Trim().Length > 0)
                            cDireccion += " " + s;
                    }
                    else
                        break;
                    i++;
                }
                cDireccion = cDireccion.Trim();
                //Ubica Ubigeo(cDep, cProv, cDis);
                cad1 = "Situacion:";
                cad2 = "Telefono:";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cSituacion = cad.Substring(x, (y - x)).Trim();

                cad1 = "Telefono:";
                cad2 = "Dependencia.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                x = x + cad1.Length;
                var cTelefono = cad.Substring(x, (y - x)).Trim();
                if (cTelefono.Length <= 2) cTelefono = "";

                cad1 = "Tipo.";
                cad2 = "DNI :";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                if (y < 0)
                {
                    cad2 = "Inicio Act.";
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                }
                if (x > 0 && y > 0)
                {
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                    x = x + cad1.Length;
                    cTipo = cad.Substring(x, (y - x)).Trim();
                }


                cad1 = "DNI :";
                cad2 = "Fecha Nacimiento.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);
                y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                var cDni = String.Empty;
                if (x > 0 && y > 0)
                {
                    x = x + cad1.Length;
                    cDni = cad.Substring(x, (y - x)).Trim();
                }

                cad1 = "Fecha Nacimiento.";
                cad2 = "Inicio Act.";
                x = cad.IndexOf(cad1, 1, StringComparison.InvariantCulture);

                var cFecNac = String.Empty;
                if (x > 0)
                {
                    y = cad.IndexOf(cad2, 1, StringComparison.InvariantCulture);
                    x = x + cad1.Length;
                    cFecNac = cad.Substring(x, (y - x)).Trim();
                }

                xRazSoc = General.Limpiar(xRazSoc);
                cNombreComercial = General.Limpiar(cNombreComercial);
                cDireccion = General.Limpiar(cDireccion);
                cEstado = General.Limpiar(cEstado);
                _persona.Situacion = General.Limpiar(cSituacion);
                cTelefono = General.Limpiar(cTelefono);
                cDni = General.Limpiar(cDni);
                cFecNac = General.Limpiar(cFecNac);
                cTipo = General.Limpiar(cTipo);
                //------------------------------
                _persona.Estado = cEstado; //Habido o NO HABIDO
                //ChkHabido.Checked = cSituacion.Equals("HABIDO");
                _persona.RazonSocial = xRazSoc;
                _persona.RazonComercial = cNombreComercial;
                _persona.Direccion = cDireccion;
                _persona.EsAgenteRetencion = cAgenteRetencion;
                _persona.Telefono = cTelefono;
                _persona.Dni = cDni;
                try
                {
                    _persona.FecNac = Convert.ToDateTime(cFecNac);
                }
                catch (Exception)
                {
                    _persona.FecNac = new DateTime(1900, 1, 1);
                }
                _persona.TipoNegocio = cTipo;
                //------------------------------
                _ok = true;
            }
            catch (Exception ex)
            {
                _ok = false;
                _error = ex.Message;
            }
        }
        #endregion
        #region Constructor
        public Sunat(string ruc, bool nuevoformato)
        {
//            _persona = new Person();
            if(!nuevoformato)
                LoadInfoContribuyente(ruc);
            else
                LoadInfoContribuyente2(ruc);
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
