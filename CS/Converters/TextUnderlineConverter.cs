using System;
using System.Windows;
using System.Windows.Data;
namespace DXRibbonNotepad.Converters {
    public class TextUnderlineConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            TextDecorationCollection coll = new TextDecorationCollection();
            if((bool)value)
                coll.Add(new TextDecoration());
            return coll;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}