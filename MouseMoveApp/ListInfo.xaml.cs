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
    public partial class ListInfo : Window
    {
        public int id { get; set; }
        public string date_time { get; set; }
        public string action { get; set; }
        public string coord { get; set; }

        public ListInfo()
        {
            InitializeComponent();
        }

        public ListInfo(string date_time, string action, string coord)
        {
            this.date_time = date_time;
            this.action = action;
            this.coord = coord;
        }

    }

}
