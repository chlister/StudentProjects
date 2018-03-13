using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace H2_HeltIFisk.ViewModel
{
    public class AnimalPictureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().Equals("Dolphin"))
            {
                return "Assets/Dolphin.jpeg";
            }
            else if(value.ToString().Equals("Shark"))
            {
                return "Assets/Shark.jpg";
            }
            else if (value.ToString().Equals("Clownfish"))
            {
                return "Assets/Clownfish.jpg";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
