Module FormStack
    Public NavigationStack As New List(Of Form)
    Public CurrentIndex As Integer = -1 ' Initialize to -1 to indicate no forms are currently in the stack

    Public Sub Forward()
        If CurrentIndex < NavigationStack.Count - 1 Then
            ' Close the current form
            NavigationStack(CurrentIndex).Close()
            CurrentIndex += 1

            ' Show the next form
            NavigationStack(CurrentIndex).Show()
        End If
    End Sub

    Public Sub Back()
        If CurrentIndex >= 0 Then
            ' Close the current form
            NavigationStack(CurrentIndex).Close()
            CurrentIndex -= 1

            ' Show the previous form
            NavigationStack(CurrentIndex).Show()
        End If
    End Sub

    Public Sub AddForm(ByVal form As Form)
        ' Add the form to the stack
        NavigationStack.Add(form)
        CurrentIndex += 1 ' Increment the index to the newly added form
    End Sub
End Module



