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
using Negocio;

namespace MyShelf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Cadastro : Window
    {
        private string foto = string.Empty;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cads(object sender, RoutedEventArgs e)
        {
            Usuário a = new Usuário();
            a.Nome = user.Text;
            a.Email = em.Text;
            a.Senha = sen.Password;
            a.Tipo = 2;
            a.foto = foto;
            NUsuário f = new NUsuário();
            f.Cadastrar(a);
            Close();
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

                imagem.Source = bi;
            }
        }
    }
}
