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
using Pesistencia;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para GerenciarF.xaml
    /// </summary>
    public partial class GerenciarF : Window
    {
        public GerenciarF()
        {
            InitializeComponent();
        }

        private void Listar (object sender, RoutedEventArgs e)
        {
            NFuncionario f = new NFuncionario();
            funcionarios.ItemsSource = f.Listar();
        }

        private void Adicionar(object sender, RoutedEventArgs e)
        {
            Window n = new Add();
            n.ShowDialog();
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            if (funcionarios.SelectedItem != null)
            {
                NFuncionario l = new NFuncionario();
                l.Excluir((funcionarios.SelectedItem) as Pesistencia.Funcionario);
            }
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {

        }
    }
}
