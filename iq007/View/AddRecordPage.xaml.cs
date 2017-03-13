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
using System.Windows.Navigation;
using System.Windows.Shapes;
using iq007.UI;

namespace iq007.View
{
    /// <summary>
    /// Логика взаимодействия для AddRecordPage.xaml
    /// </summary>
    public partial class AddRecordPage : Page
    {
        ApplicationContext db;
        public List<Pupil> listPupils;

        public AddRecordPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Pupils.Load();
            listPupils = db.Pupils.Local.ToList();
        }
    }
}
