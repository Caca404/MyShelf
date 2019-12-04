using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NLivro
    {
        PLivro p = new PLivro();
        private List<Livro> ls;
        public List<Livro> Pesquisar(string nome)
        {
            
            List<Livro> cs = p.Open().OrderBy(c => c.Nome).ToList();
            List<Livro> r = new List<Livro>();
            foreach (Livro c in cs)
                if (c.Nome.StartsWith(nome)) r.Add(c);
            return r;
        }
        public List<Livro> Listar()
        {
            PLivro p = new PLivro();
            ls = p.Open().OrderBy(c => c.Nome).ToList();
            return ls;
        }
        public void Delete(Livro c)
        {
            PLivro p = new PLivro();
            List<Livro> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
        public void Add(Livro l)
        {
            PLivro p = new PLivro();
            ls = p.Open();
            int m = 0;
            foreach (Livro x in ls) if (x.Id > m) m = x.Id;
            l.Id = m + 1;
            ls.Add(l);
            p.Save(ls);
        }
        public void Update(Livro l)
        {
            PLivro p = new PLivro();
            List<Livro> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == l.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(l);
            p.Save(cs);
        }
    }
}
