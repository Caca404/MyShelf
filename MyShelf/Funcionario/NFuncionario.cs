using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class NFuncionario
    {
        private List<Funcionario> ls;
        
        public List<Funcionario> Listar()
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open().OrderBy(c => c.nome).ToList();
            return ls;
        }
        
        public void Adicionar(Funcionario f)
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open();
            ls.Add(f);
            p.Save(ls);
        }
        
        public void Excluir(Funcionario c)
        {
            PFuncionario p = new PFuncionario();
            List<Funcionario> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].matricula == c.matricula)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
        
        public void Atualizar(Funcionario f)
        {
            PFuncionario p = new PFuncionario();
            List<Funcionario> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].matricula == f.matricula)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(f);
            p.Save(cs);
        }
    }
}
