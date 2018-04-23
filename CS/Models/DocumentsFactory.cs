namespace DXRibbonNotepad.Model {
    public static class DocumentsFactory {
        public static Documents CreateDefaultDocuments() {
            Documents result = CreateDocuments();
            result.Add(new Document());
            return result;
        }
        public static Documents CreateDocuments() {
            return new Documents();
        }
    }
}