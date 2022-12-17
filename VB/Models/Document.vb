Imports System.Windows

Namespace DXRibbonNotepad.Model

    Public Class Document

        Public Property Text As String

        Public Property DocumentName As String

        Public Property IsBold As Boolean

        Public Property IsItalic As Boolean

        Public Property IsUnderline As Boolean

        Public Property TextAlignment As TextAlignment

        Public Property FontSize As Double

        Public Property FontFamily As String

        Public Sub New()
            Text = String.Empty
            DocumentName = "Untitled"
            FontSize = 12R
            FontFamily = "Consolas"
        End Sub
    End Class
End Namespace
