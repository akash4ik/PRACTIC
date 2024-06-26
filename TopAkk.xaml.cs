﻿using System;
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
    /// Логика взаимодействия для TopAkk.xaml
    /// </summary>
    public partial class TopAkk : Window
    {
        public string Login {  get; set; }
        public TopAkk(string login)
        {
            InitializeComponent();
            Login = login;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Program pr = new Program(Login);
            pr.Show();
            this.Close();
        }
    }
}
