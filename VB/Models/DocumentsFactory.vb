Namespace DXRibbonNotepad.Model

    Public Module DocumentsFactory

        Public Function CreateDefaultDocuments() As Documents
            Dim result As Documents = CreateDocuments()
            result.Add(New Document())
            Return result
        End Function

        Public Function CreateDocuments() As Documents
            Return New Documents()
        End Function
    End Module
End Namespace
