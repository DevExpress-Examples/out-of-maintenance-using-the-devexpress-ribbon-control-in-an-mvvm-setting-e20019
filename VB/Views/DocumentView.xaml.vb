Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls

Namespace DXRibbonNotepad.Views
	Partial Public Class DocumentView
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			documentElement.Focus()
		End Sub
	End Class
End Namespace
