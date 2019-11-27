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

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }
        private int k = 1;
        private void ad(object sender, RoutedEventArgs e)
        {
            Livro l = new Pesistencia.Livro(n.Text,a.Text,g.Text,i.Text,int.Parse(ano.Text),k++);
            NLivro li = new NLivro();
            li.Add(l);
            Close();
        }

    }
}
