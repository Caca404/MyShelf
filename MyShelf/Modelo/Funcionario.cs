using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Funcionario : Usuário
    {
        public string Matricula { get; set; }
        public string Telefone { get; set; }
        public DateTime Data {
            get { return Data; }
            set
            {
                DateTime a = new DateTime();
                a = DateTime.Now;
                if (value.Date > a) throw new Exception("Data é muito do futuro");
                else Data = value;
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
