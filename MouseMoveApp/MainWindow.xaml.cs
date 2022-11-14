using System.Windows;
using System.Windows.Input;
using System.Data.SQLite;
using System.IO;
using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Collections.Generic;

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

            //DataGrid dataGridList = new DataGrid();
            //List<DataGrid> dataGrid = new List<DataGrid>();
            //dataGrid.Add(new DataGrid() { Date_time = "", Action_name = "John Doe", Coordinate = "" });

            //dataGridList.dataGridMouse.ItemsSource = dataGrid;
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
                string command = "CREATE TABLE IF NOT EXISTS [dbMouseAction] " + "([Date_time] TEXT, " + "[Action_name] TEXT, " + "[Coordinate] TEXT)"; // создать таблицу, если её нет

                SQLiteCommand Command = new SQLiteCommand(command, connection);

                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
            }

            //MessageBox.Show("База данных подключена!");

            DataBase.Visibility = Visibility.Collapsed;
            Login.Visibility = Visibility.Visible;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            AdminUser adminLogin = new AdminUser();
            AdminUser userLogin = new AdminUser();

            //запрос на вход

            //if (adminLogin.ShowDialog() == true) //выбран админ
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
            //            DataBase.Visibility = Visibility.Collapsed;
            //            Login.Visibility = Visibility.Visible;
            //        }
            //    } //login password
            //    else
            //    {
            //        MessageBox.Show("Авторизация не пройдена");
            //    }
            //}
            //else 
            if (userLogin.ShowDialog() == true) //выбран юзер
            {
                MessageBox.Show("Вход выполнен");
            }
            else
            {
                MessageBox.Show("Вход не выполнен");
            }


            Login.Visibility = Visibility.Collapsed;
            Start.Visibility = Visibility.Visible;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.Show();

            Start.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Visible;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int count = 0;
            //const int n = 50;
            //const int m = 4;

            //Point p = e.GetPosition(this);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {

            //    }
            //}

            DataGrid listInfo = new DataGrid();

            do
            {
                if (e.ChangedButton == MouseButton.Middle || e.ChangedButton == MouseButton.Left || e.ChangedButton == MouseButton.Right && e.ButtonState == MouseButtonState.Pressed)
                {
                    count++;
                    listInfo.clickCount.Content = String.Format("Количество записей: {0}", count);

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

            } while (count == 50);
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.Close();

            Start.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Collapsed;
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

            //string dt = DateTime.Now.ToString();

            //Point p = e.GetPosition(this);

        }
    }
}


