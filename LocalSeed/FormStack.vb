' User Session structure
Public Structure CurrentUser
    Public id As String
    Public username As String
    Public email As String
    Public nationality As String
    Public dateOfBirth As String ' Format dd/mm/yyyy
    Public phoneNumber As String ' TODO: phone number validation
    Public address As String
    Public regDate As String ' Format dd/mm/yyyy
    Public verified As Boolean ' After 2FA email
End Structure

Module FormStack
    ' Global variables
    Public NavigationStack As New List(Of Form)
    Public CurrentIndex As Integer = -1 ' Initialize to indicate no forms are currently in the stack
    Public User As CurrentUser

    Public Sub Forward()
        ' Hide the current form and show the one previous visited ahead in the stack
        If CurrentIndex + 1 < NavigationStack.Count Then
            If CurrentIndex >= 0 Then
                NavigationStack(CurrentIndex).Hide()
            End If

            ' Increment the index counter
            CurrentIndex += 1
            NavigationStack(CurrentIndex).Show()
        End If
    End Sub

    Public Sub Back()
        ' Hide the current form and show the previous
        If CurrentIndex > 0 Then
            NavigationStack(CurrentIndex).Hide()
            CurrentIndex -= 1
            NavigationStack(CurrentIndex).Show()
            ' Exit all forms
        ElseIf CurrentIndex = 0 Then
            NavigationStack(CurrentIndex).Hide()
            CurrentIndex = -1
        End If
    End Sub

    Public Sub AddForm(ByVal form As Form)
        ' Instead of closing forms, hide any forms that are currently shown
        If CurrentIndex >= 0 Then
            NavigationStack(CurrentIndex).Hide()
        End If

        ' If adding a form that's already in the stack, adjust the index without having to add it back to the stack
        If NavigationStack.Contains(form) Then
            CurrentIndex = NavigationStack.IndexOf(form)
        Else
            ' Add the new form to the stack and update the current index
            NavigationStack.Add(form)
            CurrentIndex = NavigationStack.Count - 1
        End If

        ' Show the new form
        NavigationStack(CurrentIndex).Show()
    End Sub
End Module





