Imports Microsoft.VisualBasic
Imports System.Windows
Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.ViewModels
	Public Class DocumentViewModel
		Inherits ViewModelBase
		Public Property Document() As Document
			Get
				Return document_Renamed
			End Get
			Private Set(ByVal value As Document)
				document_Renamed = value
			End Set
		End Property
		Public Property Text() As String
			Get
				Return Document.Text
			End Get
			Set(ByVal value As String)
				If Text = value Then
					Return
				End If
				Document.Text = value
				OnPropertyChanged("Text")
			End Set
		End Property
		Public Property DocumentName() As String
			Get
				Return Document.DocumentName
			End Get
			Set(ByVal value As String)
				If DocumentName = value Then
					Return
				End If
				Document.DocumentName = value
				OnPropertyChanged("DocumentName")
			End Set
		End Property
		Public Property FontFamily() As String
			Get
				Return Document.FontFamily
			End Get
			Set(ByVal value As String)
				If Document.FontFamily = value Then
					Return
				End If
				Document.FontFamily = value
				OnPropertyChanged("FontFamily")
			End Set
		End Property
		Public Property IsBold() As Boolean
			Get
				Return Document.IsBold
			End Get
			Set(ByVal value As Boolean)
				If Document.IsBold = value Then
					Return
				End If
				Document.IsBold = value
				OnPropertyChanged("IsBold")
			End Set
		End Property
		Public Property IsItalic() As Boolean
			Get
				Return Document.IsItalic
			End Get
			Set(ByVal value As Boolean)
				If Document.IsItalic = value Then
					Return
				End If
				Document.IsItalic = value
				OnPropertyChanged("IsItalic")
			End Set
		End Property
		Public Property IsUnderline() As Boolean
			Get
				Return Document.IsUnderline
			End Get
			Set(ByVal value As Boolean)
				If Document.IsUnderline = value Then
					Return
				End If
				Document.IsUnderline = value
				OnPropertyChanged("IsUnderline")
			End Set
		End Property
		Public Property TextAlignment() As TextAlignment
			Get
				Return Document.TextAlignment
			End Get
			Set(ByVal value As TextAlignment)
				If Document.TextAlignment = value Then
					Return
				End If
				Document.TextAlignment = value
				OnPropertyChanged("TextAlignment")
			End Set
		End Property
		Public Property FontSize() As Double
			Get
				Return Document.FontSize
			End Get
			Set(ByVal value As Double)
				If Document.FontSize = value Then
					Return
				End If
				Document.FontSize = value
				OnPropertyChanged("FontSize")
			End Set
		End Property

		Public Sub New(ByVal document As Document)
			Me.document_Renamed = document
		End Sub
		Private document_Renamed As Document
	End Class
End Namespace
