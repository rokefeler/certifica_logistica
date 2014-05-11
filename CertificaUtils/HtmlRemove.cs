using System.Text.RegularExpressions;

namespace CertificaUtils
{
    public class HtmlRemove
    {
        /// <summary>
        /// Remove HTML from string with Regex.
        /// </summary>
        public static string StripTagsRegex(string source)
        {
            var cad = Regex.Replace(source, "<.*?>", string.Empty);
            const char car1 = (char)13; //retorno de carro
            const char car2 = (char)10; //nueva linea
            const char car3 = (char)9; //TAB
            cad = cad.Replace(car1, ' ');
            cad = cad.Replace(car2, ' ');
            cad = cad.Replace(car3, ' ');
            return cad;
        }

        /// <summary>
        /// Compiled regular expression for performance.
        /// </summary>
        static Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

        /// <summary>
        /// Remove HTML from string with compiled Regex.
        /// </summary>
        public static string StripTagsRegexCompiled(string source)
        {
            var cad = _htmlRegex.Replace(source, string.Empty);
            const char car1 = (char)13; //retorno de carro
            const char car2 = (char)10; //nueva linea
            const char car3 = (char)9; //TAB
            cad = cad.Replace(car1, ' ');
            cad = cad.Replace(car2, ' ');
            cad = cad.Replace(car3, ' ');
            return cad;
        }

        /// <summary>
        /// Remove HTML tags from string using char array.
        /// </summary>
        public static string StripTagsCharArray(string source)
        {
            var array = new char[source.Length];
            var arrayIndex = 0;
            var inside = false;

            for (var i = 0; i < source.Length; i++)
            {
                var let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            var cad = new string(array, 0, arrayIndex);
            const char car1 = (char)13; //retorno de carro
            const char car2 = (char)10; //nueva linea
            const char car3 = (char)9; //TAB
            cad = cad.Replace(car1, ' ');
            cad = cad.Replace(car2, ' ');
            cad = cad.Replace(car3, ' ');
            return cad;
        }
    }
}
