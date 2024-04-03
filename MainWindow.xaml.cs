using Microsoft.EntityFrameworkCore;
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = usernameT.Text;
            var password = passwordT.Text;
            var context = new AppDbContext();
            

            // Проверка длины пароля
            if (password.Length < 6 && login.Length < 6) // Условие на минимальную длину пароля
            {
                passwordT.Text = "Короткий пароль";
                passwordT.BorderBrush = Brushes.Red;
                usernameT.Text = "Имя слишком короткое";
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
            if (user is null)
            {
                Nepravpass pass = new Nepravpass();
                pass.Show();
                this.Close();
            }
            else
            {
                TopAkk akk = new TopAkk(login);
                akk.Show();
                this.Close();
            }
        }
        private bool isPasswordVisible = false;
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                // Если текст пароля видимый - скрываем и меняем иконку на закрытый глаз
                passwordT.Visibility = Visibility.Visible;
                eye1.Source = new BitmapImage(new Uri("eyecclose.png", UriKind.Relative));
            }
            else if (isPasswordVisible)
            {
                // Если текст пароля скрытый - показываем и меняем иконку на открытый глаз
                passwordT.Visibility = Visibility.Visible;
                eye.Source = new BitmapImage(new Uri("eye.png", UriKind.Relative));
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Focusable = false;
            Window1 registerWindow = new Window1();
            registerWindow.Show();
            this.Close();
        }
    }
}