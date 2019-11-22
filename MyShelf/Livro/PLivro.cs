using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Livro
{
    internal class PLivro
    {
        private string arquivo = "Livro.xml";
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
