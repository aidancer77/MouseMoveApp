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

namespace MouseMoveApp
{
    /// <summary>
    /// Логика взаимодействия для AdminUser.xaml
    /// </summary>
    public partial class AdminUser : Window
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

    }
}
