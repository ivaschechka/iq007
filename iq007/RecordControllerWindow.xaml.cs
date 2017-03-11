using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using iq007.Model;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для RecordControllerWindow.xaml
    /// </summary>
    public partial class RecordControllerWindow : Window
    {
        ApplicationContext db;
        public RecordControllerWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Records.Load();
            this.DataContext = db.Records.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            RecordsWindow recordsWindow = new RecordsWindow(new Record());
            if (recordsWindow.ShowDialog() == true)
            {
                Record record = recordsWindow.Record;
                db.Records.Add(record);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (recordlist.SelectedItem == null) return;
            // получаем выделенный объект
            Record record = recordlist.SelectedItem as Record;

            RecordsWindow recordWindow = new RecordsWindow(new Record
            {
                Id = record.Id,
                Pupil = record.Pupil,
                Rate = record.Rate,
                Date = record.Date
            });

            if (recordWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                record = db.Records.Find(recordWindow.Record.Id);
                if (record != null)
                {
                    record.Pupil = recordWindow.Record.Pupil;
                    record.Rate = recordWindow.Record.Rate;
                    record.Date = recordWindow.Record.Date;
                    db.Entry(record).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (recordlist.SelectedItem == null) return;
            // получаем выделенный объект
            Record record = recordlist.SelectedItem as Record;
            db.Records.Remove(record);
            db.SaveChanges();
        }
    }
}
