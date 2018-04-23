﻿using System;
using System.Windows;
using System.Windows.Data;
namespace DXRibbonNotepad.Converters {
    public class FontWeightConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if((bool)value)
                return FontWeights.Bold;
            return FontWeights.Normal;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}