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

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void rateMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var r=new RateControllerWindow();
            r.Show();
        }

        private void pupilMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var p = new PupilControllerWindow();
            p.Show();
        }
    }
}
