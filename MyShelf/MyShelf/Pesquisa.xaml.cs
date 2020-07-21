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
    /// Lógica interna para Pesquisa.xaml
    /// </summary>
    public partial class Pesquisa : Window
    {
        Usuário i = new Usuário();
        NUsuário u = new NUsuário();
        NLivro n = new NLivro();
        public Pesquisa(string no, Usuário u)
        {
            InitializeComponent();
            grid.ItemsSource = n.Pesquisar(no);
            i = u;
        }
        private void Pesq(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Pesquisar(txtpes.Text);

        }
        private void Lendo(object sender, RoutedEventArgs e)
        {
            i.lendo.Add(grid.SelectedItem as Livro);
            i.todos.Add(grid.SelectedItem as Livro);
            u.Atualizar(i);
        }

        private void Favoritos(object sender, RoutedEventArgs e)
        {
            i.fav.Add(grid.SelectedItem as Livro);
            i.todos.Add(grid.SelectedItem as Livro);
            u.Atualizar(i);
        }

        private void QueroLer(object sender, RoutedEventArgs e)
        {
            i.ql.Add(grid.SelectedItem as Livro);
            i.todos.Add(grid.SelectedItem as Livro);
            u.Atualizar(i);
        }

        private void JaLi(object sender, RoutedEventArgs e)
        {
            i.jl.Add(grid.SelectedItem as Livro);
            i.todos.Add(grid.SelectedItem as Livro);
            u.Atualizar(i);
        }
    }
}
