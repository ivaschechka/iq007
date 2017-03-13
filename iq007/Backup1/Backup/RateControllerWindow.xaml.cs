using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using iq007.Model;

namespace iq007
{
    /// <summary>
    /// Логика взаимодействия для RateControllerWindow.xaml
    /// </summary>
    public partial class RateControllerWindow : Window
    {
        ApplicationContext db;
        public RateControllerWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Rates.Load();
            this.DataContext = db.Rates.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            RatesWindow ratesWindow = new RatesWindow(new Rate());
            if (ratesWindow.ShowDialog() == true)
            {
                Rate phone = ratesWindow.Rate;
                db.Rates.Add(phone);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (ratelist.SelectedItem == null) return;
            // получаем выделенный объект
            Rate rate = ratelist.SelectedItem as Rate;

            RatesWindow phoneWindow = new RatesWindow(new Rate
            {
                Id = rate.Id,
                Name = rate.Name,
                Cost = rate.Cost
            });

            if (phoneWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                rate = db.Rates.Find(phoneWindow.Rate.Id);
                if (rate != null)
                {
                    rate.Name = phoneWindow.Rate.Name;
                    rate.Cost = phoneWindow.Rate.Cost;
                    db.Entry(rate).State = EntityState.Modified;
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
            Rate rate = ratelist.SelectedItem as Rate;
            db.Rates.Remove(rate);
            db.SaveChanges();
        }
    }
}
