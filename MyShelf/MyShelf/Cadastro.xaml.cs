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
using System.Windows.Navigation;
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
            NUsuário f = new NUsuário();
            f.Cadastrar(a);
            Close();
        }
    }
}
