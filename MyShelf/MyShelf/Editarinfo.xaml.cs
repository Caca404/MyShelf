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
    /// Lógica interna para Editarinfo.xaml
    /// </summary>
    public partial class Editarinfo : Window
    {
        Usuário u = new Usuário();
        private string foto = String.Empty;
        public Editarinfo(Usuário u)
        {
            InitializeComponent();
            txtn.Text = u.Nome;
            txte.Text = u.Email;
            string h = u.Senha;
            string te = "";
            foreach (char pl in h)
            {
                int v = pl;
                v -= 10;
                te += Convert.ToChar(v);
            }
            txts.Text = te;
            if (u.foto != null)
            {
                byte[] b = Convert.FromBase64String(u.foto);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();
                img.Source = bi;
            }
            this.u = u;
        }

        private void att(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void canc(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public Usuário GetUsuário()
        {
            u.Nome = txtn.Text;
            string te = "";
            foreach (char x in txts.Text)
            {
                int v = x;
                v += 10;
                te += Convert.ToChar(v);
            }
            u.Senha = te;
            u.Senha = txts.Text;
            u.Email = txte.Text;
            u.foto = foto;
            return u;
        }

        private void ft(object sender, RoutedEventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            if (w.ShowDialog().Value)
            {
                byte[] b = File.ReadAllBytes(w.FileName);
                foto = Convert.ToBase64String(b);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                img.Source = bi;
            }
        }
    }
}
