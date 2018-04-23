using System.Windows;
using System.Windows.Controls;

namespace DXRibbonNotepad.Views {
    public partial class DocumentView : UserControl {
        public DocumentView() {
            InitializeComponent();
        }
        protected void OnLoaded(object sender, RoutedEventArgs e) {
            documentElement.Focus();
        }
    }
}
