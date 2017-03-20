using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
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
    /// Логика взаимодействия для AddPupilPage.xaml
    /// </summary>
    public partial class AddPupilPage : Page
    {
        ApplicationContext db;
        List<Branch> _listBranches;

        public AddPupilPage()
        {
            InitializeComponent();
            db=new ApplicationContext();
            db.Pupils.Load();
            db.Branches.Load();
            db.PupilsBranches.Load();
            _listBranches = db.Branches.Local.ToList();
            ListBranches.ItemsSource = _listBranches;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var ctl in MainGrid.Children)
            {
                var block = ctl as TextBox;
                if (block != null)
                {
                    block.Text = "";
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var _pupil = new Pupil
            {
                Surname = SurnameTextBox1.Text,
                Name = NameTextBox.Text,
                Midname = MidNameTextBox.Text
            };
            db.Pupils.Add(_pupil);
            var pupilsBranch = new PupilsBranch
            {
                Branch = (Branch)ListBranches.SelectionBoxItem,
                Pupil = _pupil
            };
            db.PupilsBranches.Add(pupilsBranch);
            db.SaveChanges();
            foreach (var window in App.Current.Windows)
            {
                if (window is MainWindow)
                {
                    var w = (MainWindow) window;
                    w.Frame.Refresh();
                }
            }
        }
    }
}
