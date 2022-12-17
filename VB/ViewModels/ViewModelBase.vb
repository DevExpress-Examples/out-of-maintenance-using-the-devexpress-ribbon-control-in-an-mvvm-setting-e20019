Imports System.ComponentModel

Namespace DXRibbonNotepad.ViewModels

    Public Class ViewModelBase
        Implements INotifyPropertyChanged

        Protected Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class
End Namespace
