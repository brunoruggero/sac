using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOBanco
    {
        /*
        public static String StringDeConexao
        {

            get
            {
               // return "SERVER=localhost;DATABASE=sacbanco;UID=root;PASSWORD=abc123@;";
               return "Data Source=DESKTOP-75HM3J5\\SQLEXPRESS;Initial Catalog=sacBanco;User ID=sa;Password=abc123@";
            }

        }*/

        
        public static String servidor = @"BRO\SQLEXPRESS";
        public static String banco = "sacBanco";
        public static String usuario = "sa";
        public static String senha = "abc123@";

        public static String StringDeConexao
        {

            get
            {
                // return "SERVER=localhost;DATABASE=sacbanco;UID=root;PASSWORD=abc123@;";
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }

        } 

    }
}
