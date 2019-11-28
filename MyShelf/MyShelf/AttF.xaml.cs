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
    /// Lógica interna para AttF.xaml
    /// </summary>
    public partial class AttF : Window
    {
        public AttF(Usuário x)
        {
            InitializeComponent();
            f = x;
            n.Text = x.Nome;
            ano.Text = x.Data.ToString();
            e.Text = x.Email;
            tel.Text = x.Telefone;
        }
        private Usuário f;
        private void ad(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void canc(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
        public Usuário GetFuncionario()
        {
            Usuário l = new Usuário();
            l = f;
            l.Nome = n.Text;
            l.Telefone = tel.Text;
            l.Data = DateTime.Parse(ano.Text);
            l.Email = e.Text;
            return l;
        }
    }
}
