using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DAL
{
    public class TesteDeConexaoDAL
    {
        public void TesteConexao(string diretorio)
        {
            try
            {
                Dados.diretorio = diretorio;

                SQLiteConnection cn = new SQLiteConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();
                cn.Close();
            }

            catch (SQLiteException liteEx)
            {
                throw new Exception("Erro ao tentar se conectar com o Banco de Dados: \n" + liteEx.StackTrace);
            }

            catch (Exception ex) 
            {
                throw new Exception(ex.StackTrace);
            }
        }
    }
}
