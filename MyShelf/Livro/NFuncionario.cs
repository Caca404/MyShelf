using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Pesistencia;

namespace Negocio
{
    public class NFuncionario
    {
        private List<Usuário> ls;
        public List<Usuário> Listar()
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open().OrderBy(c => c.Nome).ToList();
            return ls;
        }
        public void Adicionar(Usuário f)
        {
            PFuncionario p = new PFuncionario();
            ls = p.Open();
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
