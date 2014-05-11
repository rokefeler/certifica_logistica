using System.IO;

namespace Certifica_logistica.modulos
{
    public class DatabaSeConfig
    {
        public static string ConfiguracionDb(Conexion con)
        {
            var cNombreTemporal = Path.GetTempFileName();
            try
            {
                using (var ws = new StreamWriter(cNombreTemporal))
                {
                    ws.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    ws.WriteLine("\t<configuration>");
                    ws.WriteLine("\t\t<configSections>");
                    ws.WriteLine(
                        "\t\t\t<section name=\"dataConfiguration\" type=\"Microsoft.Practices.EnterpriseLibrary.Data.Configuration.DatabaseSettings, Microsoft.Practices.EnterpriseLibrary.Data, Version=5.0.414.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\"/>");
                    ws.WriteLine("\t\t</configSections>");
                    ws.WriteLine("\t\t<connectionStrings>"); //2433
                    ws.WriteLine("\t\t\t<add name=\"CERTIFICA\" connectionString=\"Data Source=" + con.Ip + "," +
                                 con.Puerto + ";Initial Catalog=" + con.Catalogo + ";User ID=" + con.Usuario +
                                 ";Password=" + con.Pwd + ";MultipleActiveResultSets=True\"");
                    //ws.WriteLine("\t\t\t<add name=\"CERTIFICA\" connectionString=\"Data Source=.\\SQLEXPRESS;Initial Catalog=CERTIFICA;Trusted_Connection=yes;MultipleActiveResultSets=True\"");
                    ws.WriteLine("\t\t\t\t providerName=\"System.Data.SqlClient\"/>");
                    ws.WriteLine("\t\t</connectionStrings>");
                    ws.WriteLine("\t\t<dataConfiguration defaultDatabase=\"CERTIFICA\"/>");
                    ws.WriteLine("\t</configuration>");
                }
              }//Fin de Try
            catch //(Exception ee)
            {
                 cNombreTemporal = "";
            }

            return cNombreTemporal;
        }
 
    }


}
