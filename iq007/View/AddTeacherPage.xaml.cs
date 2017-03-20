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

namespace iq007.View
{
    /// <summary>
    /// Логика взаимодействия для AddTeacherPage.xaml
    /// </summary>
    public partial class AddTeacherPage : Page
    {
        ApplicationContext db;
        public AddTeacherPage()
        {
            InitializeComponent();
            db=new ApplicationContext();
            db.Teachers.Load();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var teacher = new Teacher {FIO= FIOTextBox.Text};
            db.Teachers.Add(teacher);
            db.SaveChanges();
            foreach (var window in Application.Current.Windows)
            {
                if (window is MainWindow)
                {
                    var w = (MainWindow)window;
                    w.Frame.Refresh();
                }
            }
        }
    }
}
