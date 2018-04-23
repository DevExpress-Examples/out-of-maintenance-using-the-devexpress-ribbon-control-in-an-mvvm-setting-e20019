Imports Microsoft.VisualBasic
Imports System
Imports DXRibbonNotepad.Model
Namespace DXRibbonNotepad.Commands
	Public NotInheritable Class DocumentCommands
		Public Shared ReadOnly NewDocumentCommand As DocumentCommand
		Public Shared ReadOnly CloseDocumentCommand As DocumentCommand

		Private Sub New()
		End Sub
		Shared Sub New()
			NewDocumentCommand = New DocumentCommand(AddressOf NewDocument)
			CloseDocumentCommand = New DocumentCommand(AddressOf CloseDocument, AddressOf CanCloseDocument)
		End Sub
		Private Shared Function CanCloseDocument(ByVal documents As Documents) As Boolean
			Return documents.SelectedIndex <> -1
		End Function
		Private Shared Sub CloseDocument(ByVal documents As Documents)
			documents.RemoveAt(documents.SelectedIndex)
		End Sub
		Private Shared Sub NewDocument(ByVal documents As Documents)
			documents.Add(New Document())
		End Sub
	End Class
End Namespace