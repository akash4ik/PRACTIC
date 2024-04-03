using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow loginwin = new MainWindow();
            loginwin.Show();
            this.Close();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {

            var login = usernameT.Text;

            var pass = passwordT.Text;

            var email = emailT.Text;

            var context = new AppDbContext();

            // Проверка длины пароля
            if (pass.Length < 6 && login.Length < 6) // Условие на минимальную длину пароля
            {
                passwordT.Text = "Короткий пароль";
                passwordT.BorderBrush = Brushes.Red;
                usernameT.Text = "Имя слишком короткое";
                usernameT.BorderBrush = Brushes.Red;
                return;
            }

            // Проверка наличия специальных символов в пароле (пример)

            if (pass.Contains('&') | pass.Contains('$') | pass.Contains('#') | pass.Contains('@')
                | pass.Contains('!') | pass.Contains('^') | pass.Contains('*') && login.Contains('&')
                | login.Contains('$') | login.Contains('#') | login.Contains('@')
                | login.Contains('!') | login.Contains('^') | login.Contains('*'))
            {
                passwordT.Text = "недопустимый символ";
                passwordT.BorderBrush = Brushes.Red;
                usernameT.Text = "недопустимый символ";
                usernameT.BorderBrush = Brushes.Red;
            }

            //Проверка Эмаил
            if (!IsValidEmail(email))
            {
                emailT.Text = "Неправильный формат Email";
                emailT.BorderBrush = Brushes.Red;
                return;
            }

            var userexists = context.Users.FirstOrDefault(x => x.Login == login);
            if (userexists is not null)
            {
                Yshe Est = new Yshe();
                Est.Show();
                this.Close();
            }
            else
            {
                var user = new User { Login = login, Password = pass, Email = email };
                context.Users.Add(user);
                context.SaveChanges();
                vxod Welcom = new vxod();
                Welcom.Show();
                this.Close();
            }
           


        }
    }
}
