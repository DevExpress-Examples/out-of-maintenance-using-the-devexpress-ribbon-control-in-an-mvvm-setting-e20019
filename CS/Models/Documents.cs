using System;
using System.Collections.Specialized;
using DevExpress.Xpf.Core;
namespace DXRibbonNotepad.Model {
    public class DocumentSelectionChangedEventArgs : EventArgs {
        public int OldSelectedIndex { get; private set; }
        public int NewSelectedIndex { get; private set; }
        public DocumentSelectionChangedEventArgs(int oldSelectedIndex, int newSelectedIndex) {
            OldSelectedIndex = oldSelectedIndex;
            NewSelectedIndex = newSelectedIndex;
        }
    }
    public delegate void DocumentSelectionChangedEventHandler(object sender, DocumentSelectionChangedEventArgs args);

    public class Documents : LockableCollection<Document> {
        public Document SelectedDocument {
            get { return IsValidIndex(SelectedIndex) ? this[SelectedIndex] : null; }
        }
        public int SelectedIndex {
            get { return selectedIndex; }
            set {
                if(!IsValidIndex(value)) value = -1;
                if(selectedIndex == value) return;
                int oldValue = selectedIndex;
                selectedIndex = value;
                OnSelectedIndexChanged(oldValue);
            }
        }
        public event DocumentSelectionChangedEventHandler SelectionChanged;

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e) {
            base.OnCollectionChanged(e);
            if(IsUpdateLocked) return;
            if(e.Action == NotifyCollectionChangedAction.Add && e.NewStartingIndex != -1)
                SelectedIndex = e.NewStartingIndex;
            if(e.Action == NotifyCollectionChangedAction.Remove && e.OldStartingIndex != -1) {
                if(e.OldStartingIndex == 0)
                    SelectedIndex = 0;
                else if(e.OldStartingIndex < SelectedIndex || SelectedIndex >= Count)
                    SelectedIndex--;
            }
        }
        protected virtual void OnSelectedIndexChanged(int oldValue) {
            if(SelectionChanged != null) 
                SelectionChanged(this, new DocumentSelectionChangedEventArgs(oldValue, SelectedIndex));
        }

        bool IsValidIndex(int selectedIndex) {
            return selectedIndex >= 0 && selectedIndex < Count;
        }
        int selectedIndex = -1;
    }
}