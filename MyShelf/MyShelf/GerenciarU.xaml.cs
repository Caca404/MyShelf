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
    /// Lógica interna para GerenciarU.xaml
    /// </summary>
    public partial class GerenciarU : Window
    {
        NUsuário n = new NUsuário();
        public GerenciarU()
        {
            InitializeComponent();
            grid.ItemsSource = n.Listar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(grid.SelectedItem != null)
            {
                Usuário x = grid.SelectedItem as Usuário;
                n.Excluir(x);
                grid.ItemsSource = n.Listar();
            }
        }
    }
}
