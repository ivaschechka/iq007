using System.Windows;
using iq007.Model;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для RatesWindow.xaml
    /// </summary>
    public partial class RatesWindow : Window
    {
        public Rate Rate { get; private set; }
        public RatesWindow(Rate r)
        {
            InitializeComponent();
            Rate = r;
            DataContext = Rate;
        }

        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
