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
    /// Логика взаимодействия для vxod.xaml
    /// </summary>
    public partial class vxod : Window
    {
        public vxod()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow loginwin = new MainWindow();
            loginwin.Show();
            this.Close();
        }
    }
}
