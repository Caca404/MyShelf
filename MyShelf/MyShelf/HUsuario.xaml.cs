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

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para HUsuario.xaml
    /// </summary>
    public partial class HUsuario : Window
    {
        public HUsuario(Usuário u)
        {
            InitializeComponent();
            n.Header = u.Nome;
        }

        private void pesq(object sender, RoutedEventArgs e)
        {
            Pesquisa p = new Pesquisa(txtpes.Text);
            p.ShowDialog();
        }
    }
}
