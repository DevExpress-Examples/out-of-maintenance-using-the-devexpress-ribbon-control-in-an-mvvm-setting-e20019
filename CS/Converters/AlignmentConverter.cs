using System;
using System.Windows;
using System.Windows.Data;
namespace DXRibbonNotepad.Converters {
    public class AlignmentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return parameter.ToString() == value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return (bool)value ? Enum.Parse(typeof(TextAlignment), parameter.ToString()) : null;
        }
    }
}