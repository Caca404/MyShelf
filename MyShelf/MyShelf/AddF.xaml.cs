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
    /// Lógica interna para AddF.xaml
    /// </summary>
    public partial class AddF : Window
    {
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
        public Usuário GetFuncionario(ref int k)
        {
            Usuário u = new Usuário();
            u.Email = e.Text;
            u.Nome = n.Text;
            u.Tipo = 1;
            u.Telefone = tel.Text;
            u.Data = DateTime.Parse(ano.Text);
            u.Matricula = k.ToString() + "2019";k++;
            u.Senha = u.Matricula;
            MessageBox.Show($"Email: {u.Email}\nSenha: {u.Senha}");
            return u;
        }
    }
}
