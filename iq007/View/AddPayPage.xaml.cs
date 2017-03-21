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
using System.Windows.Navigation;
using System.Windows.Shapes;
using iq007.Model;
using Syncfusion.Windows.Shared;

namespace iq007.View
{
    /// <summary>
    /// Логика взаимодействия для AddPayPage.xaml
    /// </summary>
    public partial class AddPayPage : Page
    {
        ApplicationContext db;

        public AddPayPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Rates.Load();
            db.Payments.Load();
            comboBox1.ItemsSource = db.Rates.Local.ToBindingList();
        }


        private void Paybutton_Click(object sender, RoutedEventArgs e)
        {
            var pupil = comboBoxName.SelectedItem as Pupil;
            var rate = comboBox1.SelectedItem as Rate;
            var col = textBox.Text.ConvertToInt64Null();
            var sel = from pay in db.Payments.Local.ToList()
                      where (pay.Pupil.Id == pupil.Id && pay.Rate.Id == rate.Id)
                      select pay;
            foreach (var payment in sel)
            {
                MessageBox.Show("YES");
            }
        }
    }
}
