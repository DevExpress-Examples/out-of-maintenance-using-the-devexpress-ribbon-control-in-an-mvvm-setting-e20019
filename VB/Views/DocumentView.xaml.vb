Imports System.Windows
Imports System.Windows.Controls

Namespace DXRibbonNotepad.Views

    Public Partial Class DocumentView
        Inherits UserControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Protected Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.documentElement.Focus()
        End Sub
    End Class
End Namespace
