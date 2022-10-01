using System;
using System.Globalization;
using Xamarin.Forms;

namespace EjemploTriggers
{
    public class Nombre : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is string && ((string)value).Length > 4)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
