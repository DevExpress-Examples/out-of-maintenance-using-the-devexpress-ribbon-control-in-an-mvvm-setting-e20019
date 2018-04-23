Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Specialized
Imports DevExpress.Xpf.Core
Namespace DXRibbonNotepad.Model
	Public Class DocumentSelectionChangedEventArgs
		Inherits EventArgs
		Private privateOldSelectedIndex As Integer
		Public Property OldSelectedIndex() As Integer
			Get
				Return privateOldSelectedIndex
			End Get
			Private Set(ByVal value As Integer)
				privateOldSelectedIndex = value
			End Set
		End Property
		Private privateNewSelectedIndex As Integer
		Public Property NewSelectedIndex() As Integer
			Get
				Return privateNewSelectedIndex
			End Get
			Private Set(ByVal value As Integer)
				privateNewSelectedIndex = value
			End Set
		End Property
		Public Sub New(ByVal oldSelectedIndex As Integer, ByVal newSelectedIndex As Integer)
			OldSelectedIndex = oldSelectedIndex
			NewSelectedIndex = newSelectedIndex
		End Sub
	End Class
	Public Delegate Sub DocumentSelectionChangedEventHandler(ByVal sender As Object, ByVal args As DocumentSelectionChangedEventArgs)

	Public Class Documents
		Inherits LockableCollection(Of Document)
		Public ReadOnly Property SelectedDocument() As Document
			Get
				Return If(IsValidIndex(SelectedIndex), Me(SelectedIndex), Nothing)
			End Get
		End Property
		Public Property SelectedIndex() As Integer
			Get
				Return selectedIndex_Renamed
			End Get
			Set(ByVal value As Integer)
				If (Not IsValidIndex(value)) Then
					value = -1
				End If
				If selectedIndex_Renamed = value Then
					Return
				End If
				Dim oldValue As Integer = selectedIndex_Renamed
				selectedIndex_Renamed = value
				OnSelectedIndexChanged(oldValue)
			End Set
		End Property
		Public Event SelectionChanged As DocumentSelectionChangedEventHandler

		Protected Overrides Sub OnCollectionChanged(ByVal e As NotifyCollectionChangedEventArgs)
			MyBase.OnCollectionChanged(e)
			If IsUpdateLocked Then
				Return
			End If
			If e.Action = NotifyCollectionChangedAction.Add AndAlso e.NewStartingIndex <> -1 Then
				SelectedIndex = e.NewStartingIndex
			End If
			If e.Action = NotifyCollectionChangedAction.Remove AndAlso e.OldStartingIndex <> -1 Then
				If e.OldStartingIndex = 0 Then
					SelectedIndex = 0
				ElseIf e.OldStartingIndex < SelectedIndex OrElse SelectedIndex >= Count Then
					SelectedIndex -= 1
				End If
			End If
		End Sub
		Protected Overridable Sub OnSelectedIndexChanged(ByVal oldValue As Integer)
			RaiseEvent SelectionChanged(Me, New DocumentSelectionChangedEventArgs(oldValue, SelectedIndex))
		End Sub

		Private Function IsValidIndex(ByVal selectedIndex As Integer) As Boolean
			Return selectedIndex >= 0 AndAlso selectedIndex < Count
		End Function
		Private selectedIndex_Renamed As Integer = -1
	End Class
End Namespace