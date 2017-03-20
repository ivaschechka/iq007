using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using iq007.Annotations;

namespace iq007.Model
{
    public class PupilsBranch : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }
        public int? PupilId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch Branch{ get; set; }  // навигационное свойство
        [ForeignKey("PupilId")]
        public virtual Pupil Pupil { get; set; }  // навигационное свойство

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}