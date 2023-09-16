using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTL
{
    public class Vantagens
    {
        public int Id_ficha { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }

    public class Desvantagens
    {
        public int Id_ficha { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }

    public class Tecnicas
    {
        public int Id_ficha { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }

    public class Ficha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Arquetipo { get; set; }
        public string Pericias { get; set; }
        public string Foto { get; set; }
        public int Exp { get; set; }
        public int Pontos { get; set; }
        public int Poder { get; set; }
        public int Habilidade { get; set; }
        public int Resistencia { get; set; }
        public int Pv { get; set; }
        public int MaxPv { get; set; }
        public int Pa { get; set; }
        public int MaxPa { get; set; }
        public int Pm { get; set; }
        public int MaxPm { get; set; }
        public string Inventario { get; set; }
    }
}
