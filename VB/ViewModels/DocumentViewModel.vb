Imports System.Windows
Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.ViewModels

    Public Class DocumentViewModel
        Inherits ViewModelBase

        Public Property Document As Document
            Get
                Return documentField
            End Get

            Private Set(ByVal value As Document)
                documentField = value
            End Set
        End Property

        Public Property Text As String
            Get
                Return Document.Text
            End Get

            Set(ByVal value As String)
                If Equals(Text, value) Then Return
                Document.Text = value
                OnPropertyChanged("Text")
            End Set
        End Property

        Public Property DocumentName As String
            Get
                Return Document.DocumentName
            End Get

            Set(ByVal value As String)
                If Equals(DocumentName, value) Then Return
                Document.DocumentName = value
                OnPropertyChanged("DocumentName")
            End Set
        End Property

        Public Property FontFamily As String
            Get
                Return Document.FontFamily
            End Get

            Set(ByVal value As String)
                If Equals(Document.FontFamily, value) Then Return
                Document.FontFamily = value
                OnPropertyChanged("FontFamily")
            End Set
        End Property

        Public Property IsBold As Boolean
            Get
                Return Document.IsBold
            End Get

            Set(ByVal value As Boolean)
                If Document.IsBold = value Then Return
                Document.IsBold = value
                OnPropertyChanged("IsBold")
            End Set
        End Property

        Public Property IsItalic As Boolean
            Get
                Return Document.IsItalic
            End Get

            Set(ByVal value As Boolean)
                If Document.IsItalic = value Then Return
                Document.IsItalic = value
                OnPropertyChanged("IsItalic")
            End Set
        End Property

        Public Property IsUnderline As Boolean
            Get
                Return Document.IsUnderline
            End Get

            Set(ByVal value As Boolean)
                If Document.IsUnderline = value Then Return
                Document.IsUnderline = value
                OnPropertyChanged("IsUnderline")
            End Set
        End Property

        Public Property TextAlignment As TextAlignment
            Get
                Return Document.TextAlignment
            End Get

            Set(ByVal value As TextAlignment)
                If Document.TextAlignment = value Then Return
                Document.TextAlignment = value
                OnPropertyChanged("TextAlignment")
            End Set
        End Property

        Public Property FontSize As Double
            Get
                Return Document.FontSize
            End Get

            Set(ByVal value As Double)
                If Document.FontSize = value Then Return
                Document.FontSize = value
                OnPropertyChanged("FontSize")
            End Set
        End Property

        Public Sub New(ByVal document As Document)
            documentField = document
        End Sub

        Private documentField As Document
    End Class
End Namespace
