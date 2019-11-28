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
        private List<Usuário> ls;
        PFuncionario p = new PFuncionario();
        public List<Usuário> Listar()
        {
            ls = p.Open().OrderBy(c => c.Nome).ToList();
            return ls;
        }
        public void Adicionar(Usuário f)
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open();
            int m = 0;
            foreach (Usuário x in ls) if (x.Id > m) m = x.Id;
            f.Id = m + 1;
            f.Matricula = f.Id.ToString() + "2019";
            f.Senha = f.Matricula;
            ls.Add(f);
            p.Save(ls);
        }
        public void Excluir(Usuário c)
        {
            PFuncionario p = new PFuncionario();
            List<Usuário> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Matricula == c.Matricula)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
        public void Atualizar(Usuário f)
        {
            PFuncionario p = new PFuncionario();
            List<Usuário> cs = p.Open();
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
