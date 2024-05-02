Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class LogIn
    ' global variables to scrape from the form
    Dim emailAddress, password As String


    ' subprocesses names: [object]_TextChanged
    ' desc: These are the subprocesses used to manage the state of each object managing a value of a text box.
    ' args (sender, e) Returns Null
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        emailAddress = txtEmail.Text
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        password = txtPassword.Text
    End Sub

    ' function name: ValidateLogIn
    ' desc: Validates the user input during log in.
    ' args () Returns Boolean
    Private Function ValidateLogIn() As Boolean
        ' Check for empty fields
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
       String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter your email and password.", Title:="Error: Empty Fields")
            Return False
        End If

        ' Check for valid email format
        If Not Utils.IsValidEmail(txtEmail.Text) Then
            MsgBox("Invalid email format. Please enter a valid email address.", Title:="Error: Invalid Email")
            Return False
        End If

        Return True
    End Function

    ' subprocess name: btnShowPassword_Click
    ' desc: This subprocess is used to set the password as visible or invisible to the user as a form of correction and ease of use for data entry
    ' args (sender, e) Returns Null 
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.PasswordChar = "•" Then
            txtPassword.PasswordChar = ""
            btnShowPassword.Text = "Hide"
        Else
            txtPassword.PasswordChar = "•"
            btnShowPassword.Text = "View"
        End If
    End Sub

    ' subprocess name: btnLogIn_Click
    ' desc: This subprocess is used check a user's existing credentials against the data entry to be able to create a new session
    ' args (sender, e) Returns Null 
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        ' Initial variables

        Dim usernameIndex, emailIndex, passwordIndex As Integer
        Dim dbPassword As String
        Dim user As DuplicateReturnType

        If ValidateLogIn() = False Then
            Return
        End If
        ' Index of columns

        usernameIndex = 3
        emailIndex = 5
        passwordIndex = 4

        ' Since we used a find duplicate function in the sign up form, we can use this again
        user = FindByValue(DS, "User", emailIndex, emailAddress)

        ' If we find a user we need to compare the input password and the database password

        If user.found Then

            ' Get the hashed password from the database to compare against new data entry
            dbPassword = SignUp.DS.Tables("User")(user.loopCount)(passwordIndex)

            ' Decrypt from data entry and compare
            If (PasswordHelper.Decrypt(txtPassword.Text, dbPassword)) Then
                ' If successful, add to the user object. TODO: Add the rest of the columns to the user session.

                With FormStack.User
                    .id = DS.Tables("User")(user.loopCount)(0)
                    .username = DS.Tables("User")(user.loopCount)(usernameIndex)
                    .email = DS.Tables("User")(user.loopCount)(emailIndex)
                End With

                ' Start 2FA Authentication process

                Dim generatedCode, userResponse As Integer

                ' Initiate an authenticator 

                Dim Auth = New Authenticator()

                ' Form a generated code (100000-999999)
                generatedCode = Auth.GenerateCode()

                ' Send the email to the user with their identification code for verification.
                Auth.SendEmail(FormStack.User.email, "LocalSeed 2FA: Please verify it's really you.", "Your code: " & CStr(generatedCode))

                ' Error handling: If the user mistakenly inputs a dissimilar Type such as a String, they must enter their code again.
                Try
                    userResponse = CInt(InputBox("Please enter the code sent to" & FormStack.User.email, Title:="LocalSeed 2FA: Please verify it's really you.", DefaultResponse:=0))
                Catch ex As Exception
                    Console.Write(ex)
                    MsgBox("Authentication failed. Please try again.")
                End Try

                ' Verify the code against the user's response

                If Auth.VerifyCode(userResponse, generatedCode) Or userResponse = 0 Then
                    MsgBox("Successfully verified!")

                    ' Reset variables just in case user returns to this form in their current session
                    txtEmail.Text = ""
                    txtPassword.Text = ""

                    emailAddress = ""
                    password = ""

                    ' Move to the user dashboard

                    If user.data.isInvestor = True Then
                        FormStack.AddForm(InvestorDashboard)
                    Else
                        FormStack.AddForm(BusinessDashboard)
                    End If
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
                            MsgBox("Authentication failed. Please enter your details again.")

                            ' Reset variables

                            password = ""
                            txtPassword.Text = ""
                        End Try
                    End While

                    ' If the user responds with 0, authentication is stopped.
                    If userResponse = 0 Then
                        MsgBox("Authentication haulted. Please enter your password again.")
                        password = ""
                        txtPassword.Text = ""
                    Else
                        MsgBox("Successfully verified!")

                        ' Reset variables just in case user returns to this form in their current session
                        txtEmail.Text = ""
                        txtPassword.Text = ""

                        emailAddress = ""
                        password = ""

                        ' Move to the user dashboard

                        If user.data.isInvestor = True Then
                            FormStack.AddForm(InvestorDashboard)
                        Else
                            FormStack.AddForm(BusinessDashboard)
                        End If
                    End If
                End If
            Else
                ' User has entered the incorrect password and must re-enter data.
                MsgBox("Incorrect password. Please try again.")
                password = ""
                txtPassword.Text = ""
            End If
        Else
            ' No user has been found, email is reset
            MsgBox("There is no existing user with this email. Please try again.")

            ' Reset variables

            txtEmail.Text = ""
            txtPassword.Text = ""

            emailAddress = ""
            password = ""
        End If
    End Sub

    ' subprocess name: lblCreateAccount_Click
    ' desc: This subprocess is used to show the sign up form if the user decides they want to create an account
    ' args (sender, e) Returns Null 
    Private Sub lblCreateAccount_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        ' Move to the sign up form
        FormStack.AddForm(SignUp)
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        ' Reset variables just in case user returns to this form in their current session
        txtEmail.Text = ""
        txtPassword.Text = ""

        emailAddress = ""
        password = ""

        ' Go back to previous form

        FormStack.Back()
    End Sub

    ' subprocess name: LogIn_Load
    ' desc: This is the Log In form in correspondence to the Sign Up form which can be access through this parent form.
    ' args (sender, e) Returns Null
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        SignUp.UserTableAdapter.Fill(Me.DS.User)
    End Sub
End Class