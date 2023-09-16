using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using DTL;
using DAL;

namespace BLL
{
    public class FichasBLL
    {
        public bool InsertFicha(Ficha ficha, Vantagens[] vantagens, Desvantagens[] desvantagens, Tecnicas[] tecnicas) {
            FichasDAL dal = new FichasDAL();

            if (ficha.Nome.Trim() != "")
            {
                dal.Insert(ficha, vantagens, desvantagens, tecnicas);

                return true;
            }

            else
                return false;
        }

        public bool UpdateFicha(Ficha ficha, Vantagens[] vantagens, Desvantagens[] desvantagens, Tecnicas[] tecnicas) 
        {
            FichasDAL dal = new FichasDAL();

            if (ficha.Nome.Trim() != "")
            {
                dal.Update(ficha, vantagens, desvantagens, tecnicas);

                return true;
            }

            else
                return false;
        }

        public DataTable SelectFicha(int id) {
            FichasDAL dal = new FichasDAL();
            return dal.Select(id);
        }

        public bool DeletarFicha(int id)
        {
            FichasDAL dal = new FichasDAL();

            try
            {
                dal.Delete(id);

                return true;
            }

            catch
            {
                return false;
            }
        }

        public Ficha CarregarFicha(int id)
        {
            FichasDAL dal = new FichasDAL();
            return dal.CarregarFichas(id);
        }

        public Vantagens[] CarregarVantagem(int id)
        {
            FichasDAL dal = new FichasDAL();
            return dal.CarregarVantagens(id);
        }

        public Desvantagens[] CarregarDesvantagem(int id)
        {
            FichasDAL dal = new FichasDAL();
            return dal.CarregarDesvantagens(id);
        }

        public Tecnicas[] CarregarTecnica(int id)
        {
            FichasDAL dal = new FichasDAL();
            return dal.CarregarTecnicas(id);
        }

        public int NextId()
        {
            FichasDAL dal = new FichasDAL();
            return dal.NextId();
        }
    }
}
