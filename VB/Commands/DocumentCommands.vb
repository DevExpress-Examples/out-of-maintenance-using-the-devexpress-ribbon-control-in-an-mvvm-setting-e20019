Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.Commands

    Public Module DocumentCommands

        Public ReadOnly NewDocumentCommand As DocumentCommand

        Public ReadOnly CloseDocumentCommand As DocumentCommand

        Sub New()
            NewDocumentCommand = New DocumentCommand(AddressOf NewDocument)
            CloseDocumentCommand = New DocumentCommand(AddressOf CloseDocument, AddressOf CanCloseDocument)
        End Sub

        Private Function CanCloseDocument(ByVal documents As Documents) As Boolean
            Return documents.SelectedIndex <> -1
        End Function

        Private Sub CloseDocument(ByVal documents As Documents)
            documents.RemoveAt(documents.SelectedIndex)
        End Sub

        Private Sub NewDocument(ByVal documents As Documents)
            documents.Add(New Document())
        End Sub
    End Module
End Namespace
