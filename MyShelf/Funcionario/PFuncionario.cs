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
    public class PFuncionario
    {
        private string arquivo = "Funcionarios.xml";
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
                if (cs == null) cs = "0";
            }
            catch { cs = "0"; }
            finally
            {
                if (f != null)
                {
                    f.Close();
                }
            }
            k = int.Parse(cs);
            return k;
        }
        public void SaveK(int k)
        {
            XmlSerializer x = new XmlSerializer(typeof(int));
            StreamWriter f = new StreamWriter(arq, false, Encoding.Default);
            x.Serialize(f, k);
            f.Close();
        }
        public List<Usuário> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Usuário>));
            StreamReader f = null;
            List<Usuário> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<Usuário>;
            }
            catch { cs = new List<Usuário>(); }

            finally { if (f != null) f.Close(); }

            return cs;
        }
        public void Save(List<Usuário> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Usuário>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
