Imports Microsoft.VisualBasic
Imports System.Windows
Namespace DXRibbonNotepad.Model
	Public Class Document
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateDocumentName As String
		Public Property DocumentName() As String
			Get
				Return privateDocumentName
			End Get
			Set(ByVal value As String)
				privateDocumentName = value
			End Set
		End Property
		Private privateIsBold As Boolean
		Public Property IsBold() As Boolean
			Get
				Return privateIsBold
			End Get
			Set(ByVal value As Boolean)
				privateIsBold = value
			End Set
		End Property
		Private privateIsItalic As Boolean
		Public Property IsItalic() As Boolean
			Get
				Return privateIsItalic
			End Get
			Set(ByVal value As Boolean)
				privateIsItalic = value
			End Set
		End Property
		Private privateIsUnderline As Boolean
		Public Property IsUnderline() As Boolean
			Get
				Return privateIsUnderline
			End Get
			Set(ByVal value As Boolean)
				privateIsUnderline = value
			End Set
		End Property
		Private privateTextAlignment As TextAlignment
		Public Property TextAlignment() As TextAlignment
			Get
				Return privateTextAlignment
			End Get
			Set(ByVal value As TextAlignment)
				privateTextAlignment = value
			End Set
		End Property
		Private privateFontSize As Double
		Public Property FontSize() As Double
			Get
				Return privateFontSize
			End Get
			Set(ByVal value As Double)
				privateFontSize = value
			End Set
		End Property
		Private privateFontFamily As String
		Public Property FontFamily() As String
			Get
				Return privateFontFamily
			End Get
			Set(ByVal value As String)
				privateFontFamily = value
			End Set
		End Property
		Public Sub New()
			Text = String.Empty
			DocumentName = "Untitled"
			FontSize = 12R
			FontFamily = "Consolas"
		End Sub
	End Class
End Namespace