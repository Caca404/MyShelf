using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PFuncionario
    {
        private string arquivo = "Funcionarios.xml";
        public List<Funcionario> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Funcionario>));
            StreamReader f = null;
            List<Funcionario> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<Funcionario>;
            }
            catch { cs = new List<Funcionario>(); }

            finally { if (f != null) f.Close(); }

            return cs;
        }
        public void Save(List<Funcionario> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Funcionario>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
