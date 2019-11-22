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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string ISBN { get; set; }
        public int Ano { get; set; }
        public override string ToString()
        {
            return $"{Id} {Nome} {Autor} {Genero} {Ano} {ISBN}";
        }
    }
}
