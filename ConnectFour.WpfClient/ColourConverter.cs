using ConnectFour.Main;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ConnectFour.WpfClient
{
    public class ColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colour = value as Colour;
            if (colour == null)
                throw new ArgumentException("value is no colour");
            return new SolidColorBrush(Color.FromRgb(colour.Red, colour.Green, colour.Blue));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
