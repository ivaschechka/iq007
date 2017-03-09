using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    class Payment : INotifyPropertyChanged
    {
        private int paidDays;
        private int passDays;

        public int Id { get; set; }

        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }

        public int PassDays
        {
            get
            {
                return passDays;
            }

            set
            {
                passDays = value;
                OnPropertyChanged("PassDays");
            }
        }

        public int PaidDays
        {
            get
            {
                return paidDays;
            }

            set
            {
                paidDays = value;
                OnPropertyChanged("PaidDays");
            }
        }

        public Payment()
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
