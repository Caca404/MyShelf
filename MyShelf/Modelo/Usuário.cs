using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuário
    {
        private int Id;
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { get; set; }
        public string Senha { get; set; }
        public int Tipo { get; set; }
        public Usuário() {}
        public Usuário(int id, string n, string mat, string e, string sen, int t)
        {
            Id = id;
            Nome = n;
            Matricula = mat;
            Email = e;
            Senha = sen;
            Tipo = t;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} -- Matricula: {Matricula} -- Email: {Email}";
        }
    }
}
