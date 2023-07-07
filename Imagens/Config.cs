using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagens
{
    public class Config
    {
        //Credenciais de acesso ao banco
        public static string dbHost = ConfigurationManager.AppSettings["dbHost"];
        public static string dbPort = ConfigurationManager.AppSettings["dbPort"];
        public static string dbName = ConfigurationManager.AppSettings["dbName"];
        public static string dbUser = ConfigurationManager.AppSettings["dbUser"];
        public static string dbPass = ConfigurationManager.AppSettings["dbPass"];

        //Diretório raiz da aplicação
        public static string appRootFolder = AppDomain.CurrentDomain.BaseDirectory;

        public static string imageFolder = Path.Combine(appRootFolder, 
            ConfigurationManager.AppSettings["imageFolder"]);

    }
}
