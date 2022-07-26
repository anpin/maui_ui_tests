using System.Globalization;

namespace app;

public class IntToTextConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var count = (int)value ;
        if (count == 0)
            return "Click me";
        else if (count == 1)
            return $"Clicked {count} time";
        else
            return $"Clicked {count} times";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}