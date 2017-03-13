using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iq007.Model
{
    class PupilList : ObservableCollection<Pupil>
    {
        public PupilList()
        {
            var db = new ApplicationContext();
            db.Pupils.Load();
            var list = db.Pupils.Local.ToList();
            foreach (var p in list)
            {
                Add(p);
            }
        }
    }
}
