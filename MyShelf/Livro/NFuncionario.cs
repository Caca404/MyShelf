using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NFuncionario
    {
        private List<Funcionario> ls;
        PFuncionario p = new PFuncionario();
        public List<Funcionario> Listar()
        {
            ls = p.Open().OrderBy(c => c.Nome).ToList();
            return ls;
        }
        public void Adicionar(Funcionario f)
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open();
            f.Id = ls.Count;
            f.Matricula = f.Id.ToString() + "2019" + f.Tipo.ToString();
            f.Senha = f.Matricula;
            ls.Add(f);
            p.Save(ls);
        }
        public void Excluir(Funcionario c)
        {
            PFuncionario p = new PFuncionario();
            List<Funcionario> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Matricula == c.Matricula)
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
                if (cs[i].Matricula == f.Matricula)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(f);
            p.Save(cs);
        }
    }
}
