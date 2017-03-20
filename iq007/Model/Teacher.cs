using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace iq007.Model
{
    public class Teacher : INotifyPropertyChanged
    {

        private string fio;

        public int Id { get; set; }

        public string FIO
        {
            get { return fio; }
            set
            {
                fio= value;
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