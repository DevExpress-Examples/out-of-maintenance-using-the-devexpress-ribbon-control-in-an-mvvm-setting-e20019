Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Input
Imports DXRibbonNotepad.Model
Namespace DXRibbonNotepad.Commands
	Public Class DocumentCommand
		Implements ICommand
		Public Custom Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
			AddHandler(ByVal value As EventHandler)
				If canExecute_Renamed IsNot Nothing Then
					AddHandler CommandManager.RequerySuggested, value
				End If
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				If canExecute_Renamed IsNot Nothing Then
					RemoveHandler CommandManager.RequerySuggested, value
				End If
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Public Sub New(ByVal execute As Action(Of Documents))
			Me.New(execute, Nothing)
		End Sub
		Public Sub New(ByVal execute As Action(Of Documents), ByVal canExecute As Func(Of Documents, Boolean))
			If execute Is Nothing Then
				Throw New ArgumentNullException("execute")
			End If

			Me.execute_Renamed = execute
			Me.canExecute_Renamed = canExecute
		End Sub
		Public Overridable Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
			If canExecute_Renamed Is Nothing OrElse parameter Is Nothing Then
				Return True
			End If
			If Not(TypeOf parameter Is Documents) Then
				Throw New ArgumentException("parameter")
			End If
			Return canExecute_Renamed(CType(parameter, Documents))
		End Function
		Public Overridable Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
			If Not(TypeOf parameter Is Documents) Then
				Throw New ArgumentException("parameter")
			End If
			execute_Renamed(CType(parameter, Documents))
		End Sub

		Private execute_Renamed As Action(Of Documents)
		Private canExecute_Renamed As Func(Of Documents, Boolean)
	End Class
End Namespace