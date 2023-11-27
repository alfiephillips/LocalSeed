Imports System.Data.OleDb

Public Class SignUp
    ' subprocess name: SignUp_Load
    ' desc: This is the Sign Up form in correspondence to the Log In form which can be access through this parent form.
    ' args (sender, e) Returns Null

    Dim fullName, emailAddress, password As String

    Private Function GetNextUserID(ByVal tableName As String) As Integer
        ' Query the database to get the count of existing users
        Dim rows As Integer = DS.Tables(tableName).Rows().Count()
        Dim latestID As String = "0000"

        If rows > 0 Then
            latestID = DS.Tables(tableName).Rows(rows - 1)("id")
        End If

        Dim incrementedID As Integer = Integer.Parse(latestID) + 1

        Dim formattedID As String = incrementedID.ToString("D4")

        Return formattedID
    End Function
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        fullName = txtName.Text
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        password = txtPassword.Text
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'TODO: run password hash function

        Dim fname, lname As String
        Dim newID As Integer

        fname = fullName(0)
        lname = fullName(1)

        Dim newUser As DataRow = DS.Tables("User").NewRow()

        newID = GetNextUserID("User")
        newUser("id") = fname(0) & lname(0) & CStr(newID)
        newUser("firstName") = fname
        newUser("lastName") = lname
        newUser("username") = fname & "." & lname
        newUser("password") = password
        newUser("email") = emailAddress

        DS.Tables("User").Rows.Add(newUser)
        UserTableAdapter.Update(DS)
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DS.User)
    End Sub

    ' subprocess name: btnShowPassword_click
    ' desc: Handles viewing and hiding the user password, default value is set to hide.
    ' args: (sender, e) Returns Null
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.PasswordChar = "•" Then
            txtPassword.PasswordChar = ""
            btnShowPassword.Text = "Hide"
        Else
            txtPassword.PasswordChar = "•"
            btnShowPassword.Text = "View"
        End If
    End Sub
End Class
