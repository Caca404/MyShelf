using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class Funcionario
    {
        public Funcionario(){}
        public string nome{get;set;}
        public string matricula { get; set; }
        public Funcionario(string n, string m)
        {
            nome = n;
            matricula = m;
        }
        public override string ToString()
        {
            return $"{nome} {matricula}";
        }
    }
}
