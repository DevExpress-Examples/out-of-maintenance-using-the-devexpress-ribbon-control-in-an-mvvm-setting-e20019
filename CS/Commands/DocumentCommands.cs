using DXRibbonNotepad.Model;
namespace DXRibbonNotepad.Commands {
    public static class DocumentCommands {
        public static readonly DocumentCommand NewDocumentCommand;
        public static readonly DocumentCommand CloseDocumentCommand;

        static DocumentCommands() {
            NewDocumentCommand = new DocumentCommand(NewDocument);
            CloseDocumentCommand = new DocumentCommand(CloseDocument, CanCloseDocument);
        }
        static bool CanCloseDocument(Documents documents) {
            return documents.SelectedIndex != -1;
        }
        static void CloseDocument(Documents documents) {
            documents.RemoveAt(documents.SelectedIndex);
        }
        static void NewDocument(Documents documents) {
            documents.Add(new Document());
        }
    }
}