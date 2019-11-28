using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Modelo;

namespace Pesistencia
{
    public class PLivro
    {
        private string arquivo = "Livro.xml";
        private string arq = "k.xml";
        public int OpenK()
        {
            XmlSerializer x = new XmlSerializer(typeof(int));
            StreamReader f = null;
            string cs = "0";
            int k = 0;
            try
            {
                f = new StreamReader(arq, Encoding.Default);
                cs = x.Deserialize(f) as string;
            }
            catch { cs = "0"; }
            finally
            {
                if (f != null)
                {
                    f.Close();
                    k = int.Parse(cs);
                }
            }
            return k;
        }
        public void SaveK(int k)
        {
            XmlSerializer x = new XmlSerializer(typeof(int));
            StreamWriter f = new StreamWriter(arq, false, Encoding.Default);
            x.Serialize(f, k);
            f.Close();
        }
        public List<Livro> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamReader f = null;
            List<Livro> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<Livro>;
            }
            catch { cs = new List<Livro>(); }

            finally{ if (f != null) f.Close(); }
            
            return cs;
        }
        public void Save(List<Livro> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
