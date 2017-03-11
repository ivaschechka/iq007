using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Record : INotifyPropertyChanged
    {

        private string date;
        public int Id { get; set; }

        public int? RateId { get; set; }
        public int? PupilId { get; set; }
        [ForeignKey("RateId")]
        public virtual Rate Rate { get; set; }  // навигационное свойство
        [ForeignKey("PupilId")]
        public virtual Pupil Pupil { get; set; }  // навигационное свойство

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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
