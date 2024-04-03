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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Program.xaml
    /// </summary>
    public partial class Program : Window
    {
        public string Login { get; set; }

        public Program(string login)
        {
            InitializeComponent();
            Login = login;
            DataContext = this;
        }

        

        private void passizm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void emailizm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
