Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Data
Namespace DXRibbonNotepad.Converters
	Public Class AlignmentConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return parameter.ToString() = value.ToString()
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return If(CBool(value), System.Enum.Parse(GetType(TextAlignment), parameter.ToString()), Nothing)
		End Function
	End Class
End Namespace