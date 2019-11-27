using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pesistencia;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para Att.xaml
    /// </summary>
    public partial class Att : Window
    {
        public Att(Pesistencia.Livro l)
        {
            InitializeComponent();
            li = l;
            n.Text = li.Nome;
            g.Text = li.Genero;
            ano.Text = li.Ano.ToString();
            a.Text = li.Autor;
            i.Text = li.ISBN;
        }
        
        private Pesistencia.Livro li;
        private void att(object sender, RoutedEventArgs e)
        {
            NLivro p = new NLivro();
            p.Update(li);
            Close();
        }
    }
}
