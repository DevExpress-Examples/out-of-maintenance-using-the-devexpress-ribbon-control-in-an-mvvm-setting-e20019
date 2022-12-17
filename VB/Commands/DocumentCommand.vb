Imports System
Imports System.Windows.Input
Imports DXRibbonNotepad.Model

Namespace DXRibbonNotepad.Commands

    Public Class DocumentCommand
        Implements ICommand

        Public Custom Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged
            AddHandler(ByVal value As EventHandler)
                If canExecuteField IsNot Nothing Then AddHandler CommandManager.RequerySuggested, value
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                If canExecuteField IsNot Nothing Then RemoveHandler CommandManager.RequerySuggested, value
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            End RaiseEvent
        End Event

        Public Sub New(ByVal execute As Action(Of Documents))
            Me.New(execute, Nothing)
        End Sub

        Public Sub New(ByVal execute As Action(Of Documents), ByVal canExecute As Func(Of Documents, Boolean))
            If execute Is Nothing Then Throw New ArgumentNullException("execute")
            executeField = execute
            canExecuteField = canExecute
        End Sub

        Public Overridable Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
            If canExecuteField Is Nothing OrElse parameter Is Nothing Then Return True
            If Not(TypeOf parameter Is Documents) Then Throw New ArgumentException("parameter")
            Return canExecuteField(CType(parameter, Documents))
        End Function

        Public Overridable Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
            If Not(TypeOf parameter Is Documents) Then Throw New ArgumentException("parameter")
            executeField(CType(parameter, Documents))
        End Sub

        Private executeField As Action(Of Documents)

        Private canExecuteField As Func(Of Documents, Boolean)
    End Class
End Namespace
