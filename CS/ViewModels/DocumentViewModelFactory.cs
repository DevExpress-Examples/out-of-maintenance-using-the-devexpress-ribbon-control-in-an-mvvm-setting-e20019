using DXRibbonNotepad.Model;

namespace DXRibbonNotepad.ViewModels {
    public static class DocumentViewModelFactory {
        public static DocumentsViewModel CreateDefaultViewModel() {
            Documents documents = DocumentsFactory.CreateDefaultDocuments();
            return CreateViewModel(documents);
        }
        public static DocumentsViewModel CreateViewModel(Documents model) {
            return new DocumentsViewModel(model);
        }
    }
}