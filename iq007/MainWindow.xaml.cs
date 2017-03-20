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
using Syncfusion.Windows.Shared;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
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

        private void recordMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var r = new RecordControllerWindow();
            r.Show();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Frame.NavigationService.Navigate(new Uri("View/PupilsPage.xaml", UriKind.Relative));
        }

        private void Teacher_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Frame.NavigationService.Navigate(new Uri("View/TeachersPage.xaml", UriKind.Relative));
        }

        private void Payments_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Frame.NavigationService.Navigate(new Uri("View/PaymentsPage.xaml", UriKind.Relative));
        }
    }
}
