using System.Data.Entity;
using System.Windows.Controls;

namespace iq007.View
{
    /// <summary>
    /// Логика взаимодействия для ListPupilNPage.xaml
    /// </summary>
    public partial class ListPupilNPage : Page
    {
        ApplicationContext db;
        public ListPupilNPage()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Pupils.Load();
            DataContext = db.Pupils.Local.ToBindingList();
        }

        public void Refresh()
        {
            db.Pupils.Load();
            DataContext = db.Pupils.Local.ToBindingList();
        }
    }
}
