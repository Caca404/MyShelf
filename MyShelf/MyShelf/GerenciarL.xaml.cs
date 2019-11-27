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
    /// Lógica interna para GerenciarL.xaml
    /// </summary>
    public partial class GerenciarL : Window
    {
        public GerenciarL()
        {
            InitializeComponent();
        }

        private void ListarL(object sender, RoutedEventArgs e)
        {
            NLivro l = new NLivro();
            livros.ItemsSource = l.Listar();
        }

        private void Pesq(object sender, RoutedEventArgs e)
        {
            NLivro l = new NLivro();
            livros.ItemsSource = l.Pesquisar(pes.Text);
        }

        private void newa(object sender, RoutedEventArgs e)
        {
            Window n = new Add();
            n.ShowDialog();
        }

        private void del(object sender, RoutedEventArgs e)
        {
            if (livros.SelectedItem != null)
            {
                NLivro l = new NLivro();
                l.Delete((livros.SelectedItem) as Pesistencia.Livro);
            }
        }

        private void att(object sender, RoutedEventArgs e)
        {
            Window n = new Att(livros.SelectedItem as Pesistencia.Livro);
            n.ShowDialog();
        }
    }
}
