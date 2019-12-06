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
using Negocio;
using Modelo;

namespace MyShelf
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void JanelaG(object sender, RoutedEventArgs e)
        {
            bool logou = false;
            Usuário u = new Usuário();
            int i = 0;
            do
            { 
                logou = VerificarSenha(ref i, user.Text, sen.Password, ref u);
                if (!logou) MessageBox.Show("Usuário ou senha inválidos");
                else break;
            } while(logou);
            if (logou)
            {
                if (i == 0)
                {
                    Window janela = new Adm();
                    Close();
                    janela.ShowDialog();
                }
                else if (i == 1)
                {
                    Window janela = new funcionario();
                    Close();
                    janela.ShowDialog();
                }
                else if (i == 2)
                {
                    Window janela = new HUsuario(u);
                    Close();
                    janela.ShowDialog();
                }
            }
        }
        public static bool VerificarSenha(ref int p, string n, string s, ref Usuário u)
        {
            bool r = false;
            if (n == "Admin")
            {
                r = s == "1230";
                p = 0;
            }
            if (r == false)
            {
                
                NFuncionario f = new NFuncionario();
                List<Funcionario> a = f.Listar();
                foreach (Usuário x in a)
                {
                    string h = x.Senha;
                    string te = "";
                    foreach (char pl in h)
                    {
                        int v = pl;
                        v -= 10;
                        te += Convert.ToChar(v);
                    }
                    if (x.Email == n && s == te)
                    {
                        r = true;
                        p = x.Tipo;
                        u = x;
                        break;
                    }
                }
            }
            if(r == false)
            {
                NUsuário e = new NUsuário();
                List<Usuário> b = e.Listar();
                foreach (Usuário x in b)
                {
                    string h = x.Senha;
                    string te = "";
                    foreach (char pl in h)
                    {
                        int v = pl;
                        v -= 10;
                        te += Convert.ToChar(v);
                    }
                    if (x.Email == n && s == te)
                    {
                        r = true;
                        p = x.Tipo;
                        u = x;
                        break;
                    }
                }
            }
            return r;
        }

        private void JanelaC(object sender, RoutedEventArgs e)
        {
            Cadastro w = new Cadastro();
            w.ShowDialog();
        }
    }
}
