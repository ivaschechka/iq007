using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Rate : INotifyPropertyChanged
    {
        private string name;
        private int cost;

        public int Id { get; set; }
        public int? RecordId { get; set; }
        public int? PaymentId { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged("Cost");
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
