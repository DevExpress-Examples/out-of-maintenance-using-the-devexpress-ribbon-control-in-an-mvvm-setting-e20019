Imports DevExpress.Xpf.Ribbon
Imports DXRibbonNotepad.ViewModels

Namespace DXRibbonNotepad.Views

    Public Partial Class MainWindow
        Inherits DXRibbonWindow

        Public Sub New()
            DataContext = CreateDefaultViewModel()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
