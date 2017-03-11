using iq007.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для RecordsWindow.xaml
    /// </summary>
    public partial class RecordsWindow : Window
    {
        ApplicationContext db;
        public List<Rate> Ratelist { get; set; }
        public Record Record { get; private set; }

        public RecordsWindow(Record r)
        {
            InitializeComponent();
            Record = r;
            DataContext = Record;
            db = new ApplicationContext();
            db.Rates.Load();
            Ratelist = db.Rates.ToList();
            comboBoxRate.ItemsSource = Ratelist;
        }

        private void buttonAccept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
