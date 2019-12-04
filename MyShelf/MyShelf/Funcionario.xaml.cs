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

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para Funcionario.xaml
    /// </summary>
    public partial class funcionario : Window
    {
        public funcionario()
        {
            InitializeComponent();
        }

        private void GU(object sender, RoutedEventArgs e)
        {
            GerenciarU u = new GerenciarU();
            u.ShowDialog();
        }

        private void GL(object sender, RoutedEventArgs e)
        {
            GerenciarL l = new GerenciarL();
            l.ShowDialog();
        }
    }
}
