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

namespace MouseMoveApp
{
    /// <summary>
    /// Логика взаимодействия для ListInfo.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        public string Date_time { get; set; }
        public string Action_name { get; set; }
        public string Coordinate { get; set; }

        public DataGrid()
        {
            InitializeComponent(); 
        }

        public DataGrid(string date_time, string action, string coord)
        {
            this.Date_time = date_time;
            this.Action_name = action;
            this.Coordinate = coord;
        }
    }
}
