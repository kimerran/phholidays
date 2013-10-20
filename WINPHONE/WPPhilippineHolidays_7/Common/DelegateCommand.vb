
Public Class DelegateCommand
    Implements ICommand

    Private _canExecute As Func(Of Object, Boolean)
    Private _executeAction As Action(Of Object)

    Public Sub New(executeAction As Action(Of Object))
        Me.New(executeAction, Nothing)
    End Sub

    Public Sub New(executeAction As Action(Of Object), canExecute As Func(Of Object, Boolean))
        If executeAction Is Nothing Then
            Throw New ArgumentNullException("executeAction")
        End If
        Me._executeAction = executeAction
        Me._canExecute = canExecute
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Dim result As Boolean = True
        Dim canExecuteHandler As Func(Of Object, Boolean) = Me._canExecute
        If canExecuteHandler IsNot Nothing Then
            result = canExecuteHandler(parameter)
        End If

        Return result
    End Function

    Public Event CanExecuteChanged As EventHandler

    Public Sub RaiseCanExecuteChanged()
        'Dim handler As EventHandler = 
        RaiseEvent CanExecuteChanged(Me, New EventArgs)
        'Me.CanExecuteChanged(Me, New EventArgs())
    End Sub

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        Me._executeAction(parameter)
    End Sub

    Public Event CanExecuteChanged1(sender As Object, e As EventArgs) Implements ICommand.CanExecuteChanged





End Class
