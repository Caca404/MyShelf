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
using Negocio;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para GerenciarF.xaml
    /// </summary>
    public partial class GerenciarF : Window
    {
        NFuncionario f = new NFuncionario();
        public GerenciarF()
        {
            InitializeComponent();
            funcionarios.ItemsSource = f.Listar();
        }
        private void Adicionar(object sender, RoutedEventArgs e)
        {
            Window n = new AddF();
            if (n.ShowDialog().Value)
            {
                int k = f.GetK();
                f.Adicionar((n as AddF).GetFuncionario(ref k));
                funcionarios.ItemsSource = f.Listar();
                f.SetK(k);
            }
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            if (funcionarios.SelectedItem != null)
            {
                f.Excluir((funcionarios.SelectedItem) as Usuário);
                funcionarios.ItemsSource = f.Listar();
            }
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            Window n = new AttF(funcionarios.SelectedItem as Usuário);
            if (n.ShowDialog().Value)
            {
                f.Atualizar((n as AttF).GetFuncionario());
                funcionarios.ItemsSource = f.Listar();
            }
        }
    }
}
