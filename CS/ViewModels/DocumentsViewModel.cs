using System.Collections.Specialized;
using System.ComponentModel;
using DevExpress.Xpf.Core;
using DXRibbonNotepad.Model;

namespace DXRibbonNotepad.ViewModels {
    public class DocumentsViewModel : LockableCollection<DocumentViewModel> {
        public Documents Documents { get; private set; }
        public DocumentViewModel SelectedDocumentView {
            get { return this[SelectedDocumentIndex]; }
        }
        public int SelectedDocumentIndex {
            get { return Documents.SelectedIndex; }
            set { Documents.SelectedIndex = value; }
        }

        public DocumentsViewModel(Documents documentsModel) {
            Documents = documentsModel;
            Documents.CollectionChanged += OnDocumentsModelCollectionChanged;
            Documents.SelectionChanged += OnDocumentsModelSelectionChanged;
            SyncCollection();
        }
        
        protected virtual void OnDocumentsModelCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            SyncCollection();
        }
        protected virtual void OnDocumentsModelSelectionChanged(object sender, DocumentSelectionChangedEventArgs args) {
            UpdateSelectedDocumentView();
        }
        protected void SyncCollection() {
            BeginUpdate();
            Clear();
            foreach(Document doc in Documents)
                Add(new DocumentViewModel(doc));
            EndUpdate();
        }
        
        void UpdateSelectedDocumentView() {
            OnPropertyChanged(new PropertyChangedEventArgs("SelectedDocumentIndex"));
            OnPropertyChanged(new PropertyChangedEventArgs("SelectedDocumentView"));
        }
    }
}