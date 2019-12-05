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
    /// Lógica interna para AttF.xaml
    /// </summary>
    public partial class AttF : Window
    {
        private string foto = string.Empty;
        public AttF(Funcionario x)
        {
            InitializeComponent();
            f = x;
            n.Text = x.Nome;
            ano.Text = x.Data.ToString();
            e.Text = x.Email;
            tel.Text = x.Telefone;

            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            byte[] b = Convert.FromBase64String(x.foto);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(b);
            bi.EndInit();

            img.Source = bi;
        }
        private Funcionario f;
        private void ad(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void canc(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        public Funcionario GetFuncionario()
        {
            Funcionario l = new Funcionario();
            l = f;
            l.Nome = n.Text;
            l.Telefone = tel.Text;
            l.Data = DateTime.Parse(ano.Text);
            l.Email = e.Text;
            l.foto = foto;
            return l;
        }

        private void attf(object sender, RoutedEventArgs e)
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
