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
using Modelo;
using Negocio;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para Att.xaml
    /// </summary>
    public partial class AttL : Window
    {
        public AttL(Livro l)
        {
            InitializeComponent();
            li = l;
            n.Text = li.Nome;
            g.Text = li.Genero;
            ano.Text = li.Ano.ToString();
            a.Text = li.Autor;
            i.Text = li.ISBN;
        }
        private Livro li;
        private void att(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        public Livro GetLivro()
        {
            Livro l = new Livro();
            l.Id = li.Id;
            l.Nome = n.Text;
            l.ISBN = i.Text;
            l.Autor = a.Text;
            l.Ano = int.Parse(ano.Text);
            l.Genero = g.Text;
            return l;
        }

        private void canc(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
