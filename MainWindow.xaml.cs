using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        public class User
        {
            public int ID { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }


        public class AppDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                 optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=zakharovBd;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        private int failedAttempts = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var login = usernameT.Text;
            var password = passwordT.Text;
            var context = new AppDbContext();

            // Проверка длины пароля
            if (password.Length < 6 && login.Length < 6) // Условие на минимальную длину пароля
            {
                
                passwordT.BorderBrush = Brushes.Red;
                
                usernameT.BorderBrush = Brushes.Red;
                return;
            }

            // Проверка наличия специальных символов в пароле (пример)
                
            if (password.Contains('&') | password.Contains('$') | password.Contains('#') | password.Contains('@')
                | password.Contains('!') | password.Contains('^') | password.Contains('*') && login.Contains('&')
                | login.Contains('$') | login.Contains('#') | login.Contains('@')
                | login.Contains('!') | login.Contains('^') | login.Contains('*'))
            {
                passwordT.Text = "недопустимый символ";
                passwordT.BorderBrush = Brushes.Red;
                usernameT.Text = "недопустимый символ";
                usernameT.BorderBrush = Brushes.Red;
            }
            
            var user = context.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
            failedAttempts++;
            
            if (user is null || failedAttempts == 3)
            {
                // Блокируем пользователя
                Nepravpass pass = new Nepravpass();
                pass.Show();
                this.Close();
                Task.Delay(15000).GetAwaiter().GetResult(); // Асинхронная задержка в 15 секунд
                DisableInputFieldsAndButtons();
                usernameT.BorderBrush = Brushes.Red;
                passwordT.BorderBrush = Brushes.Red;

            }
            
            else
            {
                // Успешная авторизация
                failedAttempts = 0; // Сбрасываем счетчик попыток
                TopAkk akk = new TopAkk(login);
                akk.Show();
                this.Close();

            }
            
            
            
        }
        private void DisableInputFieldsAndButtons()
        {
            // Отключение полей ввода и кнопок
            usernameT.IsEnabled = false;
            passwordT.IsEnabled = false;
            ButtonVoiti.IsEnabled = false;
        }


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Focusable = false;
            Window1 registerWindow = new Window1();
            registerWindow.Show();
            this.Close();
        }

        

        private void usernameT_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag)
            {
                textBox.Text = "";
            }
        }

        private void usernameT_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString() ?? "";
            }
        }

        private void passwordT_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == textBox.Tag)
            {
                textBox.Text = "";
            }
        }

        private void passwordT_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString() ?? "";
            }
        }
       
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
                passwordBox.Password = passwordT.Text;
                passwordBox.Visibility = Visibility.Hidden;
                Vis.Visibility = Visibility.Hidden;
                Invis.Visibility = Visibility.Visible;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
                passwordT.Text = passwordBox.Password;
                passwordBox.Visibility = Visibility.Hidden;
                Invis.Visibility = Visibility.Visible;
                Vis.Visibility = Visibility.Hidden;
        }
    }
}