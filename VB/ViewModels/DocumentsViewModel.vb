Imports Microsoft.VisualBasic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports DevExpress.Xpf.Core
Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.ViewModels
	Public Class DocumentsViewModel
		Inherits LockableCollection(Of DocumentViewModel)
		Private privateDocuments As Documents
		Public Property Documents() As Documents
			Get
				Return privateDocuments
			End Get
			Private Set(ByVal value As Documents)
				privateDocuments = value
			End Set
		End Property
		Public ReadOnly Property SelectedDocumentView() As DocumentViewModel
			Get
				Return Me(SelectedDocumentIndex)
			End Get
		End Property
		Public Property SelectedDocumentIndex() As Integer
			Get
				Return Documents.SelectedIndex
			End Get
			Set(ByVal value As Integer)
				Documents.SelectedIndex = value
			End Set
		End Property

		Public Sub New(ByVal documentsModel As Documents)
			Documents = documentsModel
			AddHandler Documents.CollectionChanged, AddressOf OnDocumentsModelCollectionChanged
			AddHandler Documents.SelectionChanged, AddressOf OnDocumentsModelSelectionChanged
			SyncCollection()
		End Sub

		Protected Overridable Sub OnDocumentsModelCollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
			SyncCollection()
		End Sub
		Protected Overridable Sub OnDocumentsModelSelectionChanged(ByVal sender As Object, ByVal args As DocumentSelectionChangedEventArgs)
			UpdateSelectedDocumentView()
		End Sub
		Protected Sub SyncCollection()
			BeginUpdate()
			Clear()
			For Each doc As Document In Documents
				Add(New DocumentViewModel(doc))
			Next doc
			EndUpdate()
		End Sub

		Private Sub UpdateSelectedDocumentView()
			OnPropertyChanged(New PropertyChangedEventArgs("SelectedDocumentIndex"))
			OnPropertyChanged(New PropertyChangedEventArgs("SelectedDocumentView"))
		End Sub
	End Class
End Namespace