using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Pupil : INotifyPropertyChanged
    {
        private string surname;
        private string name;
        private string midname;

        public int Id { get; set; }
        public virtual List<Record> Records { get; set; }
        public virtual List<Payment> Payments { get; set; }

        public String FullName { get { return $"{Surname} {Name} {Midname}"; } }
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Midname
        {
            get
            {
                return midname;
            }

            set
            {
                midname = value;
                OnPropertyChanged("Midname");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
