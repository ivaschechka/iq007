using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using iq007.Annotations;

namespace iq007.Model
{
    public class Branch : INotifyPropertyChanged
    {

        private string name;

        public int Id { get; set; }
        public virtual List<PupilsBranch> PupilsBranches { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}