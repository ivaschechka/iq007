using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Record : INotifyPropertyChanged
    {

        private string date;
        public int Id { get; set; }

        public virtual ICollection<Pupil> Pupils{ get; set; }
        public virtual ICollection<Rate> Rates { get; set; }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public Record()
        {
            Pupils = new List<Pupil>();
            Rates = new List<Rate>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
