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

        public AddPupilPage()
        {
            InitializeComponent();
            image.Source=new BitmapImage(new Uri(@"C:\Users\ivan_\Source\Repos\iq007\iq007\Resources\boy.png"));
            db=new ApplicationContext();
            db.Pupils.Load();
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
                else
                {
                    continue;
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Pupil _pupil = new Pupil
            {
                Surname = SurnameTextBox1.Text,
                Name = NameTextBox.Text,
                Midname = MidNameTextBox.Text
            };
            db.Pupils.Add(_pupil);
            db.SaveChanges();
        }
    }
}
