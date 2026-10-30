using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace BindingEntreControles
{
    internal class TamañoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cad = value as string;

            if(cad != null)
            {
                if(int.TryParse(cad, out int numero))
                
                    return (numero * 2);
                else return 0;  
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
