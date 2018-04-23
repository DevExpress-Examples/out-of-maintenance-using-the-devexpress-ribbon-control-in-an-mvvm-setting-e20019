using System.ComponentModel;

namespace DXRibbonNotepad.ViewModels {
    public class ViewModelBase : INotifyPropertyChanged {
        protected virtual void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}