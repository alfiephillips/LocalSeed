Imports LocalSeed.DSTableAdapters

Public Class SignUp
    ' global variables to scrape from the form
    Dim fullName(), emailAddress, password As String

    ' subprocess name: SignUp_Load
    ' desc: This is the Sign Up form in correspondence to the Log In form which can be access through this parent form.
    ' args (sender, e) Returns Null
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InvestmentPreferencesTableAdapter.Fill(Me.DS.InvestmentPreferences)
        Me.InvestorTableAdapter.Fill(Me.DS.Investor)
        Me.UserTableAdapter.Fill(Me.DS.User)

        FormStack.AddForm(Me)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        fullName = Split(txtName.Text, " ")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        password = txtPassword.Text
    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    ' subprocess name: btnSignUp_Click
    ' desc: This is when the sign up form is submitted and we need to grab the data submitted by the user and validate it correctly to upload to the database
    ' args (sender, e) Returns Null
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'TODO: run password hash function and validation checks

        Dim fname, lname, username, newID As String

        fname = fullName(0)
        lname = fullName(1)
        username = fname & "." & lname

        'Check username and email not duplicate

        Dim usernameIndex, emailIndex As Integer

        usernameIndex = 3
        emailIndex = 5

        ' if a duplicate is found, display a report suggesting the user should retry or transfer to the login page
        If FindByValue(DS, "User", usernameIndex, username).found Or FindByValue(DS, "User", emailIndex, emailAddress).found Then
            MsgBox("Sorry, that username or email already exists! Please log in or use a different username/email.", Title:="Error: Duplicate username/email")
        Else
            ' create a new user row
            Dim newUser As DataRow = DS.Tables("User").NewRow()

            ' set all the data fields to avoid gaps
            newID = GetNextUserID(DS, "User")
            newUser("id") = fname(0) & lname(0) & CStr(newID)
            newUser("firstName") = fname
            newUser("lastName") = lname
            newUser("username") = username
            newUser("password") = password
            newUser("email") = emailAddress

            DS.Tables("User").Rows.Add(newUser)
            UserTableAdapter.Update(DS)

            With FormStack.User
                .id = newUser("id")
                .username = newUser("username")
                .email = newUser("email")
            End With

            ' temp msg box to ask if user wants to be investor or business
            Dim userType As Integer = MessageBox.Show("Do you want to register as an Investor or a Business?" & vbCrLf & vbCrLf &
                                          "Click 'Yes' for Investor" & vbCrLf &
                                          "Click 'No' for Business", "User Type Selection",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If userType = DialogResult.Yes Then
                Dim newInvestmentPreferences As DataRow = DS.Tables("InvestmentPreferences").NewRow()

                newInvestmentPreferences("id") = Guid.NewGuid()
                newInvestmentPreferences("description") = "technology, healthcare... etc"
                newInvestmentPreferences("tolerance") = 0 ' optional automatic sell point (-9 to 9) -90% to 90% loss/profit. 0 is the default for no automatic sell
                newInvestmentPreferences("horizon") = 1 '1-12 months expected hold of an investment
                newInvestmentPreferences("goal") = 0
                newInvestmentPreferences("investorId") = GetCurrentInvestorID(DS) + 1

                DS.Tables("InvestmentPreferences").Rows.Add(newInvestmentPreferences)
                InvestmentPreferencesTableAdapter.Update(DS)


                Dim newInvestor As DataRow = DS.Tables("Investor").NewRow()

                newInvestor("userID") = newUser("id")
                newInvestor("status") = "Inactive"
                newInvestor("bio") = "This is your bio. Tell the community your story!"
                newInvestor("risk") = 5
                newInvestor("amountInvested") = 0
                newInvestor("profitLoss") = 0

                DS.Tables("Investor").Rows.Add(newInvestor)
                InvestorTableAdapter.Update(DS)

            End If


            Me.Hide()

            ' reset variables just in case user returns to this form in their current session
            txtName.Text = ""
            txtEmail.Text = ""
            txtPassword.Text = ""

            ReDim fullName(1)
            emailAddress = ""
            password = ""

            Me.InvestmentPreferencesTableAdapter.Fill(Me.DS.InvestmentPreferences)
            Me.InvestorTableAdapter.Fill(Me.DS.Investor)
            Me.UserTableAdapter.Fill(Me.DS.User)

            Dashboard.ShowDialog()
        End If
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
