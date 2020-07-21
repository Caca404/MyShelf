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
    /// Lógica interna para Estante.xaml
    /// </summary>
    public partial class Estante : Window
    {
        NUsuário k = new NUsuário();
        Usuário u = new Usuário();
        NLivro c = new NLivro();
        public Estante(Usuário u)
        {
            InitializeComponent();
            this.u = u;
            est.ItemsSource = u.todos;
        }

        private void todos(object sender, RoutedEventArgs e)
        {
            est.ItemsSource = u.todos;
        }

        private void Favoritos(object sender, RoutedEventArgs e)
        {
            est.ItemsSource = u.fav;
        }

        private void Lendo(object sender, RoutedEventArgs e)
        {
            est.ItemsSource = u.lendo;
        }

        private void Jali(object sender, RoutedEventArgs e)
        {
            est.ItemsSource = u.jl;
        }

        private void QroLe(object sender, RoutedEventArgs e)
        {
            est.ItemsSource = u.ql;
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            Livro l = est.SelectedItem as Livro;
            u.todos.RemoveAt(u.todos.IndexOf(l));
            k.Atualizar(u);
            est.ItemsSource = u.todos;
            if (u.fav.IndexOf(l) != -1)
            {
                u.fav.RemoveAt(u.fav.IndexOf(l));
                k.Atualizar(u);
                est.ItemsSource = u.fav;
            }
            else if (u.jl.IndexOf(l) != -1)
            {
                u.jl.RemoveAt(u.jl.IndexOf(l));
                k.Atualizar(u);
                est.ItemsSource = u.jl;
            }
            else if (u.lendo.IndexOf(l) != -1)
            {
                u.lendo.RemoveAt(u.lendo.IndexOf(l));
                k.Atualizar(u);
                est.ItemsSource = u.lendo;
            }
            else if (u.ql.IndexOf(l) != -1)
            {
                u.ql.RemoveAt(u.ql.IndexOf(l));
                k.Atualizar(u);
                est.ItemsSource = u.ql;
            }
            
        }
    }
}
