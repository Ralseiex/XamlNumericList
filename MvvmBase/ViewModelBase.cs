using System.ComponentModel;

namespace MvvmBase;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void RaisePropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new(propertyName));
}
