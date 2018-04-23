using System.Windows;
using DXRibbonNotepad.Model;

namespace DXRibbonNotepad.ViewModels {
    public class DocumentViewModel : ViewModelBase {
        public Document Document {
            get { return document; }
            private set { document = value; }
        }
        public string Text {
            get { return Document.Text; }
            set {
                if(Text == value) return;
                Document.Text = value;
                OnPropertyChanged("Text");
            }
        }
        public string DocumentName {
            get { return Document.DocumentName; }
            set {
                if(DocumentName == value) return;
                Document.DocumentName = value;
                OnPropertyChanged("DocumentName");
            }
        }
        public string FontFamily {
            get { return Document.FontFamily; }
            set {
                if(Document.FontFamily == value) return;
                Document.FontFamily = value;
                OnPropertyChanged("FontFamily");
            }
        }
        public bool IsBold {
            get { return Document.IsBold; }
            set {
                if(Document.IsBold == value) return;
                Document.IsBold = value;
                OnPropertyChanged("IsBold");
            }
        }
        public bool IsItalic {
            get { return Document.IsItalic; }
            set {
                if(Document.IsItalic == value) return;
                Document.IsItalic = value;
                OnPropertyChanged("IsItalic");
            }
        }
        public bool IsUnderline {
            get { return Document.IsUnderline; }
            set {
                if(Document.IsUnderline == value) return;
                Document.IsUnderline = value;
                OnPropertyChanged("IsUnderline");
            }
        }
        public TextAlignment TextAlignment {
            get { return Document.TextAlignment; }
            set {
                if(Document.TextAlignment == value) return;
                Document.TextAlignment = value;
                OnPropertyChanged("TextAlignment");
            }
        }
        public double FontSize {
            get { return Document.FontSize; }
            set {
                if(Document.FontSize == value) return;
                Document.FontSize = value;
                OnPropertyChanged("FontSize");
            }
        }

        public DocumentViewModel(Document document) {
            this.document = document;
        }
        Document document;
    }
}
