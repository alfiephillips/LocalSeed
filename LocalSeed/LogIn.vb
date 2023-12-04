Public Class LogIn
    ' global variables to scrape from the form
    Dim fullName(), emailAddress, password As String

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        password = txtPassword.Text
    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.PasswordChar = "•" Then
            txtPassword.PasswordChar = ""
            btnShowPassword.Text = "Hide"
        Else
            txtPassword.PasswordChar = "•"
            btnShowPassword.Text = "View"
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim emailIndex, passwordIndex, loopCount As Integer
        Dim userFound As Boolean

        ' TODO: password decryption
        emailIndex = 3
        passwordIndex = 4

        ' since we used a find duplicate function in the sign up form, we can use this again
        FindDuplicate(DS, "User", emailIndex, emailAddress)

        ' if we find a user we need to compare the input password and the database password

        If userFound Then

        Else

        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub

    ' subprocess name: LogIn_Load
    ' desc: This is the Log In form in correspondence to the Sign Up form which can be access through this parent form.
    ' args (sender, e) Returns Null
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.UserTableAdapter.Fill(Me.DS.User)

        FormStack.AddForm(Me)
    End Sub


End Class