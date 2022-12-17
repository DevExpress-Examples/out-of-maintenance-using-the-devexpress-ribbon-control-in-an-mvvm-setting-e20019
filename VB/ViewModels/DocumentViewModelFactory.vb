Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.ViewModels

    Public Module DocumentViewModelFactory

        Public Function CreateDefaultViewModel() As DocumentsViewModel
            Dim documents As Documents = CreateDefaultDocuments()
            Return CreateViewModel(documents)
        End Function

        Public Function CreateViewModel(ByVal model As Documents) As DocumentsViewModel
            Return New DocumentsViewModel(model)
        End Function
    End Module
End Namespace
