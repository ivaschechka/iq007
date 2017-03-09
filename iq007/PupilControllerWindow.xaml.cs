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
using iq007.Model;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для PupilControllerWindow.xaml
    /// </summary>
    public partial class PupilControllerWindow : Window
    {
        ApplicationContext db;
        public PupilControllerWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Pupils.Load();
            this.DataContext = db.Pupils.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            PupilsWindow pupilsWindow = new PupilsWindow(new Pupil());
            if (pupilsWindow.ShowDialog() == true)
            {
                Pupil pupil = pupilsWindow.Pupil;
                db.Pupils.Add(pupil);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (ratelist.SelectedItem == null) return;
            // получаем выделенный объект
            Pupil pupil = ratelist.SelectedItem as Pupil;

            PupilsWindow pupilWindow = new PupilsWindow(new Pupil
            {
                Id = pupil.Id,
                Surname = pupil.Surname,
                Name = pupil.Name,
                Midname = pupil.Midname,
                Age = pupil.Age

            });

            if (pupilWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                pupil = db.Pupils.Find(pupilWindow.Pupil.Id);
                if (pupil != null)
                {
                    pupil.Surname = pupilWindow.Pupil.Surname;
                    pupil.Name = pupilWindow.Pupil.Name;
                    pupil.Midname = pupilWindow.Pupil.Midname;
                    pupil.Age = pupilWindow.Pupil.Age;
                    db.Entry(pupil).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (ratelist.SelectedItem == null) return;
            // получаем выделенный объект
            Pupil pupil = ratelist.SelectedItem as Pupil;
            db.Pupils.Remove(pupil);
            db.SaveChanges();
        }
    }
}
