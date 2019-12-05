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
    /// Lógica interna para Estante.xaml
    /// </summary>
    public partial class Estante : Window
    {
        Usuário u = new Usuário();
        public Estante(Usuário u)
        {
            InitializeComponent();
            this.u = u;
            List<Livro> l = new List<Livro>();
            Livro[] i = u.lendo.ToArray(); 
            est.ItemsSource = (u.lendo + u.jl);
        }
    }
}
