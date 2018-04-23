Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Ribbon
Imports DXRibbonNotepad.ViewModels

Namespace DXRibbonNotepad.Views
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			DataContext = DocumentViewModelFactory.CreateDefaultViewModel()
			InitializeComponent()
		End Sub
	End Class
End Namespace
