using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Livro
{
    private string arquivo = "Livro.xml";
    public List<Livro> Open()
    {
        // x é um serializador, transforma um objeto em um texto xml
        XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
        // f é um objeto que abre um texto em um arquivo
        StreamReader f = null;
        // desserializar o objeto, abrindo o texto no arquivo
        List<Livro> cs = null;
        try
        {
            f = new StreamReader(arquivo, Encoding.Default);
            cs = x.Deserialize(f) as List<Livro>;
        }
        catch
        {
            cs = new List<Livro>();
        }
        finally
        {
            // fecha o arquivo
            if (f != null) f.Close();
        }
        // retorno a lista lida do arquivo
        return cs;
    }
    public void Save(List<Livro> cs)
    {
        // x é um serializador, transforma um objeto em um texto xml
        XmlSerializer x = new XmlSerializer(typeof(List<Livro>));
        // f é um objeto que salva um texto em um arquivo
        StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
        // serializar o objeto e salvar o texto no arquivo
        x.Serialize(f, cs);
        // fecha o arquivo
        f.Close();
    }
}
