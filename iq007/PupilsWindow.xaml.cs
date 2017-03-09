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
using iq007.Model;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для PupilsWindow.xaml
    /// </summary>
    public partial class PupilsWindow : Window
    {
        public Pupil Pupil { get; private set; }
        public PupilsWindow(Pupil p)
        {
            InitializeComponent();
            Pupil = p;
            DataContext = Pupil;
        }
        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
