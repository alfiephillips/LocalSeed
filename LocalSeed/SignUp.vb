Imports LocalSeed.DSTableAdapters

Public Class SignUp
    ' global variables to scrape from the form
    Dim fullName(), emailAddress, password As String

    ' subprocess name: SignUp_Load
    ' desc: This is the Sign Up form in correspondence to the Log In form which can be access through this parent form.
    ' args (sender, e) Returns Null
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.Transactions' table. You can move, or remove it, as needed.
        Me.TransactionsTableAdapter.Fill(Me.DS.Transactions)
        'TODO: This line of code loads data into the 'DS.InvestmentListings' table. You can move, or remove it, as needed.
        Me.InvestmentListingsTableAdapter.Fill(Me.DS.InvestmentListings)
        'TODO: This line of code loads data into the 'DS.Investment' table. You can move, or remove it, as needed.
        Me.InvestmentTableAdapter.Fill(Me.DS.Investment)
        'TODO: This line of code loads data into the 'DS.Business' table. You can move, or remove it, as needed.
        Me.BusinessTableAdapter.Fill(Me.DS.Business)
        Me.InvestmentPreferencesTableAdapter.Fill(Me.DS.InvestmentPreferences)
        Me.InvestorTableAdapter.Fill(Me.DS.Investor)
        Me.UserTableAdapter.Fill(Me.DS.User)

        FormStack.AddForm(Me)
    End Sub

    ' subprocesses names: [object]_TextChanged
    ' desc: These are the subprocesses used to manage the state of each object managing a value of a text box.
    ' args (sender, e) Returns Null
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        fullName = Split(txtName.Text, " ")
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        password = txtPassword.Text
    End Sub

    ' subprocess name: lblLogIn_Click
    ' desc: Show the login form after previously being on the sign up form
    ' args (sender, e) Returns Null
    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        FormStack.AddForm(LogIn)
    End Sub

    ' subprocess name: btnSignUp_Click
    ' desc: This is when the sign up form is submitted and we need to grab the data submitted by the user and validate it correctly to upload to the database
    ' args (sender, e) Returns Null
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim fname, lname, username, newID As String

        fname = fullName(0)
        lname = fullName(1)
        username = fname & "." & lname

        'Check username and email not duplicate

        Dim usernameIndex, emailIndex As Integer

        usernameIndex = 3
        emailIndex = 5

        ' If a duplicate is found, display a report suggesting the user should retry or transfer to the login page
        If FindByValue(DS, "User", usernameIndex, username).found Or FindByValue(DS, "User", emailIndex, emailAddress).found Then
            MsgBox("Sorry, that username or email already exists! Please log in or use a different username/email.", Title:="Error: Duplicate username/email")
        Else
            ' Create a new user row
            Dim newUser As DataRow = DS.Tables("User").NewRow()

            ' Set all the data fields to avoid gaps

            Dim hashedPassword As String = ""

            Try
                ' Encrypt password
                hashedPassword = PasswordHelper.Encrypt(password:=password)

            Catch ex As Exception
                Debug.Write(ex)

                ' Add error instance
            End Try

            newID = GetNextUserID(DS, "User")
            newUser("id") = fname(0) & lname(0) & CStr(newID)
            newUser("firstName") = fname
            newUser("lastName") = lname
            newUser("username") = username
            newUser("password") = hashedPassword
            newUser("email") = emailAddress
            newUser("regDate") = Date.Now()

            Dim continueSignUp As Integer = MessageBox.Show("Do you want to complete sign up now?", "Continue sign up.", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If continueSignUp = DialogResult.Yes Then
                newUser("nationality") = InputBox("We ask for your nationality for improving your preferences. Please enter your nationality. Ex GB.", Title:="Enter your nationality", DefaultResponse:="GB")
                newUser("dateOfBirth") = InputBox("We ask for your date of birth for external verification of your age. You must be 18 to use this platform. Format: dd/mm/yyyy", Title:="Enter your Date Of Birth")
                newUser("phoneNumber") = InputBox("This field is completely optional. Please enter your phone number or leave blank.", Title:="Enter your phone number", DefaultResponse:="N/A")
                newUser("address") = InputBox("This field is completely optional. Please enter your address or postcode.", Title:="Enter your address or postcode", DefaultResponse:="N/A")
            End If

            ' Start 2FA Authentication process

            Dim generatedCode, userResponse As Integer

            ' Initiate an authenticator 

            Dim Auth = New Authenticator()

            ' Form a generated code (100000-999999)
            generatedCode = Auth.GenerateCode()

            ' Send the email to the user with their identification code for verification.
            Auth.SendEmail(newUser("email"), "LocalSeed 2FA: Please verify it's really you.", "Your code: " & CStr(generatedCode))

            ' Error handling: If the user mistakenly inputs a dissimilar Type such as a String, they must enter their code again.
            Try
                userResponse = CInt(InputBox("Please enter the code sent to" & newUser("email"), Title:="LocalSeed 2FA: Please verify it's really you.", DefaultResponse:=0))
            Catch ex As Exception
                Console.Write(ex)
                MsgBox("Authentication failed. Please try again.")
            End Try

            ' Verify the code against the user's response

            If Auth.VerifyCode(userResponse, generatedCode) Then
                MsgBox("Successfully verified!")

                newUser("verified") = True
            Else
                ' Begin loop for continuous data entry until the user stops the authentication process or enters the correct code
                Dim userEnded = False

                While userResponse <> generatedCode And userEnded = False
                    ' Error handling: If the user enters 0 or something dissimilar to a 6 digit code, the loop restarts.
                    Try
                        userResponse = CInt(InputBox("Please enter the code sent to" & FormStack.User.email & ". Enter '0' to stop the verification process.", Title:="LocalSeed 2FA: Please verify it's really you.", DefaultResponse:=0))

                        If userResponse = 0 Then
                            ' Break case

                            userEnded = True
                        End If
                    Catch ex As Exception
                        Console.Write(ex)
                        MsgBox("Authentication failed. Please enter your password to begin verification.")

                        ' Reset variables

                        password = ""
                        txtPassword.Text = ""
                    End Try
                End While

                ' If the user responds with 0, authentication is stopped.
                If userResponse = 0 Then
                    MsgBox("Authentication haulted. Please enter your password again to begin verification.")
                    password = ""
                    txtPassword.Text = ""
                Else
                    MsgBox("Successfully verified!")

                    newUser("verified") = True
                End If
            End If

            ' Add the new row for a user
            DS.Tables("User").Rows.Add(newUser)
            UserTableAdapter.Update(DS)

            ' Update the user session
            With FormStack.User
                .id = newUser("id")
                .username = newUser("username")
                .email = newUser("email")
                .nationality = newUser("nationality")
                .dateOfBirth = newUser("dateOfBirth")
                .address = newUser("address")
                .phoneNumber = newUser("phoneNumber")
                .regDate = newUser("regDate")
                .verified = newUser("verified")
            End With

            ' Temp msg box to ask if user wants to be investor or business
            Dim userType As Integer = MessageBox.Show("Do you want to register as an Investor or a Business?" & vbCrLf & vbCrLf &
                                          "Click 'Yes' for Investor" & vbCrLf &
                                          "Click 'No' for Business", "User Type Selection",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If userType = DialogResult.Yes Then
                ' Initiate a new row for an investor

                Dim newInvestor As DataRow = Me.DS.Tables("Investor").NewRow()
                Dim investorId As Integer = GetLatestID(DS, "Investor") + 1

                ' Set all the data fields, linking the user id

                newInvestor("id") = investorId
                newInvestor("userID") = newUser("id")
                newInvestor("status") = "Active"
                newInvestor("bio") = "This is your bio. Tell the community your story!"
                newInvestor("risk") = 5
                newInvestor("amountInvested") = 0
                newInvestor("profitLoss") = 0

                ' Add the new for an investor
                Me.DS.Tables("Investor").Rows.Add(newInvestor)
                InvestorTableAdapter.Update(DS)

                ' Initiate a new row for investment preferences
                Dim newInvestmentPreferences As DataRow = Me.DS.Tables("InvestmentPreferences").NewRow()

                ' Set all the data fields, linking the investor id
                newInvestmentPreferences("id") = Guid.NewGuid()
                newInvestmentPreferences("description") = "technology, healthcare... etc"
                newInvestmentPreferences("tolerance") = 0 ' optional automatic sell point (-9 to 9) -90% to 90% loss/profit. 0 is the default for no automatic sell
                newInvestmentPreferences("horizon") = 1 '1-12 months expected hold of an investment
                newInvestmentPreferences("goal") = 0

                newInvestmentPreferences("investorId") = investorId

                ' Add the new row for investment preferences
                Me.DS.Tables("InvestmentPreferences").Rows.Add(newInvestmentPreferences)
                InvestmentPreferencesTableAdapter.Update(DS)

                FormStack.AddForm(Dashboard)

            ElseIf userType = DialogResult.No Then
                ' Initiate a new business

                Dim newBusiness As DataRow = Me.DS.Tables("Business").NewRow()
            End If

            ' reset variables just in case user returns to this form in their current session
            txtName.Text = ""
            txtEmail.Text = ""
            txtPassword.Text = ""

            ReDim fullName(1)
            emailAddress = ""
            password = ""

            ' Fill all the tables with previously created data
            Me.InvestmentPreferencesTableAdapter.Fill(Me.DS.InvestmentPreferences)
            Me.InvestorTableAdapter.Fill(Me.DS.Investor)
            Me.UserTableAdapter.Fill(Me.DS.User)
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
