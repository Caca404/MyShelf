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
            try
            {
                Window n = new AddF();
                if (n.ShowDialog().Value)
                {
                    f.Adicionar((n as AddF).GetFuncionario());
                    funcionarios.ItemsSource = f.Listar();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Formato inválido");
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            try
            {
                f.Excluir((funcionarios.SelectedItem) as Funcionario);
                funcionarios.ItemsSource = f.Listar();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Nenhum Funcionário foi selecionado");
            }
        }

        private void Atualizar(object sender, RoutedEventArgs e)
        {
            try
            {
                Window n = new AttF(funcionarios.SelectedItem as Funcionario);
                if (n.ShowDialog().Value)
                {
                    f.Atualizar((n as AttF).GetFuncionario());
                    funcionarios.ItemsSource = f.Listar();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Nenhum Funcionário foi selecionado");
            }
            catch(Exception k)
            {
                MessageBox.Show(k.Message);
            }
        }
    }
}
