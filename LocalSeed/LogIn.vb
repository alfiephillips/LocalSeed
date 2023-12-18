Public Class LogIn
    ' global variables to scrape from the form
    Dim emailAddress, password As String

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub
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
        Dim usernameIndex, emailIndex, passwordIndex As Integer
        Dim dbPassword As String
        Dim user As DuplicateReturnType

        ' TODO: password decryption
        usernameIndex = 3
        emailIndex = 5
        passwordIndex = 4

        ' since we used a find duplicate function in the sign up form, we can use this again
        user = FindByValue(DS, "User", emailIndex, emailAddress)

        ' if we find a user we need to compare the input password and the database password

        If user.found Then
            dbPassword = DS.Tables("User")(user.loopCount)(passwordIndex)
            If (txtPassword.Text = dbPassword) Then
                Me.Hide()

                With FormStack.User
                    .id = DS.Tables("User")(user.loopCount)(0)
                    .username = DS.Tables("User")(user.loopCount)(usernameIndex)
                    .email = DS.Tables("User")(user.loopCount)(emailIndex)
                End With

                ' reset variables just in case user returns to this form in their current session
                txtEmail.Text = ""
                txtPassword.Text = ""

                emailAddress = ""
                password = ""

                Dashboard.ShowDialog()
            End If
        Else
                MsgBox("There is no existing user with this email. Please try again.")
        End If
    End Sub

    Private Sub lblCreateAccount_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    ' subprocess name: LogIn_Load
    ' desc: This is the Log In form in correspondence to the Sign Up form which can be access through this parent form.
    ' args (sender, e) Returns Null
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.UserTableAdapter.Fill(Me.DS.User)

        FormStack.AddForm(Me)
    End Sub


End Class