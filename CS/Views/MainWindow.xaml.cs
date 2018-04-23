using DevExpress.Xpf.Ribbon;
using DXRibbonNotepad.ViewModels;

namespace DXRibbonNotepad.Views {
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            DataContext = DocumentViewModelFactory.CreateDefaultViewModel();
            InitializeComponent();
        }
    }
}
