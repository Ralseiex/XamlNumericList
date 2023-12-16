using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace XamlNumericList;

internal class IndexConverter : IValueConverter
{
    public object Convert(object value, Type TargetType, object parameter, CultureInfo culture)
    {
        var item = (ListViewItem)value;
        var listView = ItemsControl.ItemsControlFromItemContainer(item) as ListView;
        if (listView is null)
        {
            return 0;
        }
        int index = listView.ItemContainerGenerator.IndexFromContainer(item);
        return index;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
