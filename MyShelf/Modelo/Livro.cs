using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
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
        public int Ano {
            get => Ano;
            set
            {
                int a = DateTime.Now.Year;
                if (value > a) throw new Exception("Ano do futuro");
                else Ano = value;
            }
        }
        public override string ToString()
        {
            return $"Nome: {Nome} -- Autor: {Autor} -- Genero: {Genero} -- Ano: {Ano}";
        }
    }
}
