Imports Microsoft.VisualBasic
Imports System
Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.ViewModels
	Public NotInheritable Class DocumentViewModelFactory
		Private Sub New()
		End Sub
		Public Shared Function CreateDefaultViewModel() As DocumentsViewModel
			Dim documents As Documents = DocumentsFactory.CreateDefaultDocuments()
			Return CreateViewModel(documents)
		End Function
		Public Shared Function CreateViewModel(ByVal model As Documents) As DocumentsViewModel
			Return New DocumentsViewModel(model)
		End Function
	End Class
End Namespace