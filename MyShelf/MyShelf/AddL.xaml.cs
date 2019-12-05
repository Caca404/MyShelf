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
    /// Lógica interna para Add.xaml
    /// </summary>
    public partial class AddL : Window
    {
        public AddL()
        {
            InitializeComponent();
        }
        private void ad(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        private void canc(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        public Livro GetLivro()
        {
            Livro l = new Livro();
            bool test = true;
            do
            {
                try
                {

                    l.Nome = n.Text;
                    l.ISBN = i.Text;
                    l.Autor = a.Text;
                    l.Ano = int.Parse(ano.Text);
                    l.Genero = g.Text;
                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            } while (test);
            return l;
        }
    }
}
