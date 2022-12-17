Imports System
Imports System.Windows
Imports System.Windows.Data

Namespace DXRibbonNotepad.Converters

    Public Class TextUnderlineConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim coll As TextDecorationCollection = New TextDecorationCollection()
            If CBool(value) Then coll.Add(New TextDecoration())
            Return coll
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
