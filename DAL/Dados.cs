using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace DAL
{
    public class Dados {
        public static string diretorio = "";

        public static string StringDeConexao
        {
            get
            {
                return "Data Source=" + diretorio + "\\Fichas.db";
            }
        }
    }
}
