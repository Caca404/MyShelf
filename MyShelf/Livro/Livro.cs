using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    public class Livro
    {
        public Livro(){}
        public Livro(string n,string a,string g, string i,int ano, int id)
        {
            Id = id;
            Nome = n;
            Autor = a;
            Genero = g;
            ISBN = i;
            Ano = ano;
        }
        internal int Id { get; set; }
        internal string Nome { get; set; }
        internal string Autor { get; set; }
        internal string Genero { get; set; }
        internal string ISBN { get; set; }
        internal int Ano { get; set; }
        public override string ToString()
        {
            return $"{Id} {Nome} {Autor} {Genero} {Ano} {ISBN}";
        }
    }
}
