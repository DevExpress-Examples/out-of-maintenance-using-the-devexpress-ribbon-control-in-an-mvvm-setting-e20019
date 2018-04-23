using System;
using System.Windows;
using System.Windows.Data;
namespace DXRibbonNotepad.Converters {
    public class FontStyleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if((bool)value)
                return FontStyles.Italic;
            return FontStyles.Normal;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}