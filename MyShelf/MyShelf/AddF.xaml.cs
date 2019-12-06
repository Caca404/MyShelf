using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica interna para AddF.xaml
    /// </summary>
    public partial class AddF : Window
    {
        private string foto = string.Empty;
        public AddF()
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
        public Funcionario GetFuncionario()
        {
            bool test = true;
            Funcionario u = new Funcionario();
                try
                {
                    u.Email = e.Text;
                    u.Nome = n.Text;
                    u.Tipo = 1;
                    u.foto = foto;
                    u.Telefone = tel.Text;
                    u.Data = DateTime.Parse(ano.Text);
                    return u;
                }
                catch (Exception k)
                {
                    MessageBox.Show(k.Message);
                    return null;
                }
            
        }

        private void img(object sender, RoutedEventArgs e)
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

                imagem.Source = bi;
            }
        }
    }
}
