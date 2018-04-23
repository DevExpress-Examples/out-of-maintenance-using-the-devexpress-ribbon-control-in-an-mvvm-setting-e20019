Imports Microsoft.VisualBasic
Imports System
Namespace DXRibbonNotepad.Model
	Public NotInheritable Class DocumentsFactory
		Private Sub New()
		End Sub
		Public Shared Function CreateDefaultDocuments() As Documents
			Dim result As Documents = CreateDocuments()
			result.Add(New Document())
			Return result
		End Function
		Public Shared Function CreateDocuments() As Documents
			Return New Documents()
		End Function
	End Class
End Namespace