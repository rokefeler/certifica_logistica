using System;

namespace CertificaUtils
{
    class General
    {
        public static String Limpiar(String cad)
        {
            cad = cad.Replace("&#209;", "Ñ");
            cad = cad.Replace("&#xD1;", "Ñ");
            cad = cad.Replace("&#193;", "Á");
            cad = cad.Replace("&#201;", "É");
            cad = cad.Replace("&#205;", "Í");
            cad = cad.Replace("&#211;", "Ó");
            cad = cad.Replace("&#218;", "Ú");
            cad = cad.Replace("&#xC1;", "Á");
            cad = cad.Replace("&#xC9;", "É");
            cad = cad.Replace("&#xCD;", "Í");
            cad = cad.Replace("&#xD3;", "Ó");
            cad = cad.Replace("&#xDA;", "Ú");
            cad = cad.Replace('\u0022', ' ');
            return cad;
        }
    }
}
