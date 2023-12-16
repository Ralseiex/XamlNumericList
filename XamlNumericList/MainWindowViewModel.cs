using MvvmBase;
using System.Collections.ObjectModel;

namespace XamlNumericList;

internal class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<string> _items;

    public MainWindowViewModel()
    {
        _items = new();
        for (int i = 0; i < 20; i++)
        {
            _items.Add(Guid.NewGuid().ToString());
        }
    }

    public ObservableCollection<string> Items
    {
        get => _items;
        set
        {
            _items = value;
            RaisePropertyChanged(nameof(Items));
        }
    }
}
