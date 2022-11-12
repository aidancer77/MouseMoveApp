﻿using System.Windows;
using System.Windows.Input;
using System.Data.SQLite;
using System.IO;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace MouseMoveApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Collapsed;
            Start.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Collapsed;
        }

        //static DataTable ExecuteSql(string command)
        //{

        //    DataTable dt = new DataTable();

        //    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\blueb\OneDrive\Рабочий стол\Study\work\MouseMoveApp\MouseMoveApp\DataBase\MouseAction.db; Version=3;"))
        //    {
        //        connection.Open();

        //        SQLiteCommand Command = new SQLiteCommand(command, connection);
        //        SQLiteDataReader read = Command.ExecuteReader();

        //        using (read)
        //        {
        //            dt.Load(read);
        //        }

        //    }

        //    return dt;
        //}

        private void DataBase_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\blueb\OneDrive\Рабочий стол\Study\work\MouseMoveApp\MouseMoveApp\DataBase\MouseAction.db; Version=3;"))
            {
                string command = "CREATE TABLE IF NOT EXISTS [dbMouseAction] " + "([Date_time] TEXT, " + "[Action_name] TEXT, " + "[Coordinate_name] TEXT)"; // создать таблицу, если её 

                SQLiteCommand Command = new SQLiteCommand(command, connection);

                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("База данных подключена!");

            DataBase.Visibility = Visibility.Collapsed;
            Login.Visibility = Visibility.Visible;
            Start.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Collapsed;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            AdminUser adminLogin = new AdminUser();
            AdminUser userLogin = new AdminUser();

            //if (adminLogin.ShowDialog() == true)
            //{
            //    LoginWindow loginWindow = new LoginWindow();

            //    if (loginWindow.ShowDialog() == true)
            //    {
            //        if (loginWindow.Login == "abc" && loginWindow.Password == "123")
            //        {
            //            MessageBox.Show("Авторизация пройдена");
            //            DataBase.Visibility = Visibility.Collapsed;
            //            Login.Visibility = Visibility.Collapsed;
            //            Start.Visibility = Visibility.Visible;
            //            Stop.Visibility = Visibility.Collapsed;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Неверный логин или пароль");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Авторизация не пройдена");
            //    }
            //}
            //else 
            if (userLogin.ShowDialog() == true)
            {
                MessageBox.Show("Вход выполнен");
                DataBase.Visibility = Visibility.Collapsed;
                Login.Visibility = Visibility.Collapsed;
                Start.Visibility = Visibility.Visible;
                Stop.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Вход не выполнен");
            }
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ListInfo listInfo = new ListInfo();
            listInfo.Show();

            DataBase.Visibility = Visibility.Collapsed;
            Login.Visibility = Visibility.Collapsed;
            Start.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Visible;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int count = 0;
            const int n = 50;
            const int m = 4;

            Point p = e.GetPosition(this);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                }
            }


            if (e.ChangedButton == MouseButton.Middle && e.ButtonState == MouseButtonState.Pressed)
            {
                count++;

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\blueb\OneDrive\Рабочий стол\Study\work\MouseMoveApp\MouseMoveApp\DataBase\MouseAction.db; Version=3;"))
                {
                    connection.Open();

                    string command = "INSERT INTO [dbMouseAction] ([Date_time], [Action_name], [Coordinate_name] ) VALUES('01.01.2001', 'Колесико', '(p.X; p.Y)')";

                    SQLiteCommand Command = new SQLiteCommand(command, connection);

                    Command.ExecuteNonQuery();
                    connection.Close();
                }


                //DataTable dt = ExecuteSql("SELECT * FROM dbMouseAction");
                //listviewMouse.ItemsSource = dt.DefaultView;
            }

            else if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)

            {
                count++;

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\blueb\OneDrive\Рабочий стол\Study\work\MouseMoveApp\MouseMoveApp\DataBase\MouseAction.db; Version=3;"))
                {
                    connection.Open();

                    string command = "INSERT INTO [dbMouseAction] ([Date_time], [Action_name], [Coordinate_name] ) VALUES('01.01.2001', 'ЛКМ', '(p.X; p.Y)')";

                    SQLiteCommand Command = new SQLiteCommand(command, connection);

                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            else if (e.ChangedButton == MouseButton.Right && e.ButtonState == MouseButtonState.Pressed)

            {
                count++;

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=C:\Users\blueb\OneDrive\Рабочий стол\Study\work\MouseMoveApp\MouseMoveApp\DataBase\MouseAction.db; Version=3;"))
                {
                    connection.Open();

                    string command = "INSERT INTO [dbMouseAction] ([Date_time], [Action_name], [Coordinate_name] ) VALUES('01.01.2001', 'ПКМ', '(p.X; p.Y)')";

                    SQLiteCommand Command = new SQLiteCommand(command, connection);

                    Command.ExecuteNonQuery();
                    connection.Close();
                }
            }

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            ListInfo listInfo = new ListInfo();
            listInfo.Close();

            DataBase.Visibility = Visibility.Collapsed;
            Login.Visibility = Visibility.Collapsed;
            Start.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Collapsed;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            string dt = DateTime.Now.ToString();

            Point p = e.GetPosition(this);

            if (true)
            {

            }

        }
    }
}


