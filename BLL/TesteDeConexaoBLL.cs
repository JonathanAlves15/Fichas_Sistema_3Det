using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TesteDeConexaoBLL
    {
        public void TesteDeConexao(string diretorio)
        {
            TesteDeConexaoDAL teste = new TesteDeConexaoDAL();
            teste.TesteConexao(diretorio);
        }
    }
}
