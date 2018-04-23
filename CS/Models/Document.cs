using System.Windows;
namespace DXRibbonNotepad.Model {
    public class Document {
        public string Text { get; set; }
        public string DocumentName { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }
        public TextAlignment TextAlignment { get; set; }
        public double FontSize { get; set; }
        public string FontFamily { get; set; }
        public Document() {
            Text = string.Empty;
            DocumentName = "Untitled";
            FontSize = 12d;
            FontFamily = "Consolas";
        }
    }
}