using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Payment : INotifyPropertyChanged
    {
        private int paidDays;
        private int passDays;

        public int Id { get; set; }

        public int? RateId { get; set; }
        public int? PupilId { get; set; }
        [ForeignKey("RateId")]
        public virtual Rate Rate { get; set; }  // навигационное свойство
        [ForeignKey("PupilId")]
        public virtual Pupil Pupil { get; set; }  // навигационное свойство

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
