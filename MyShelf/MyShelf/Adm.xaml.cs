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
    /// Lógica interna para Adm.xaml
    /// </summary>
    public partial class Adm : Window
    {
        public Adm()
        {
            InitializeComponent();
        }


        private void GF(object sender, RoutedEventArgs e)
        {
            Window a = new GerenciarF();
            a.ShowDialog();

        }

        private void GU(object sender, RoutedEventArgs e)
        {
            Window a = new GerenciarU();
            a.ShowDialog();
        }

        private void GL(object sender, RoutedEventArgs e)
        {
            Window a = new GerenciarL();
            a.ShowDialog();
        }
        private void log(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.ShowDialog();
            Close();
        }
    }
}
