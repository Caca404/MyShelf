using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
        Usuário u = new Usuário();
        public HUsuario(Usuário u)
        {
            InitializeComponent();
            this.u = u;
            n.Header = u.Nome;

            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
                byte[] b = Convert.FromBase64String(u.foto);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                img.Source = bi;
        }

        private void pesq(object sender, RoutedEventArgs e)
        {
            Pesquisa p = new Pesquisa(txtpes.Text, u);
            p.ShowDialog();
        }

        private void Est(object sender, RoutedEventArgs e)
        {
            Estante es = new Estante(u);
            es.ShowDialog();
        }
    }
}
