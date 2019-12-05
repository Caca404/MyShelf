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
using Negocio;
using Modelo;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para GerenciarL.xaml
    /// </summary>
    public partial class GerenciarL : Window
    {
        NLivro l = new NLivro();
        public GerenciarL()
        {
            InitializeComponent();
            livros.ItemsSource = l.Listar();
        }

        private void Pesq(object sender, RoutedEventArgs e)
        {
            livros.ItemsSource = l.Pesquisar(pes.Text);
        }

        private void newa(object sender, RoutedEventArgs e)
        {
            Window n = new AddL();
            if (n.ShowDialog().Value)
            {
                l.Add((n as AddL).GetLivro());
                livros.ItemsSource = l.Listar();
            }
        }

        private void del(object sender, RoutedEventArgs e)
        {
            if (livros.SelectedItem != null)
            {
                l.Delete((livros.SelectedItem) as Livro);
                livros.ItemsSource = l.Listar();
            }
        }

        private void att(object sender, RoutedEventArgs e)
        {
            Window n = new AttL(livros.SelectedItem as Livro);
            if (n.ShowDialog().Value)
            {
                l.Update((n as AttL).GetLivro());
                livros.ItemsSource = l.Listar();
            }
        }
    }
}
