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
    public partial class Kabinet : Window
    {
        public string Login { get; set; }
        
        public Kabinet(string login)
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

        private void NewEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag)
            {
                textBox.Text = "";
            }
        }

        private void NewEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString() ?? "";
            }
        }

        private void Newepass_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag)
            {
                textBox.Text = "";
            }
        }

        private void Newepass_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag)
            {
                textBox.Text = "";
            }
        }
    }
}
