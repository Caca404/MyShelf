using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Funcionario : Usuário
    {
        private DateTime _Data;
        public string Matricula { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { 
            get => _Data;
            set
            {
                DateTime a = DateTime.Now;
                if (a < value) throw new Exception("Data é do futuro");
                else _Data = value;
            }
        }
        public Funcionario() : base() { }
        public Funcionario(int id, string n, string e, string sen, int t, string mat, string Tel, DateTime d) : base( id,  n,  e,  sen,  t)
        {
            Matricula = mat;
            Telefone = Tel;
            Data = d;
        }
        public override string ToString()
        {
            return base.ToString() + $" -- Matricula: {Matricula} -- Telefone:{Telefone} -- Data:{Data.Day}/{Data.Month}/{Data.Year}";
        }
    }
}
