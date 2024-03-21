Imports System.Net
Imports System.Net.Mail

Public Class Authenticator
    ' This class is for two-factor authentication of a user to ensure they are using their correct email

    ' Set initial constants for email setup

    Private Const EmailSmtpServer As String = "smtp.office365.com"
    Private Const EmailUsername As String = "localseed@outlook.com"
    Private Const EmailPassword As String = "Outlook270813!"
    Private Const EmailFromAddress As String = "localseed@outlook.com"
    Private Const EmailPort As Integer = 587

    ' function name: GenerateCode
    ' desc: This function returns a random number 100000 - 999999
    ' args () Returns Integer
    Public Function GenerateCode() As String
        Dim rnd As New Random()
        Return rnd.Next(100000, 999999).ToString()
    End Function

    ' subprocess name: SendEmail
    ' desc: This subprocess sends an email to the user with a generated code for them to enter into the system to be verified
    ' args (toAddress, subject, body) Returns Null
    Public Sub SendEmail(toAddress As String, subject As String, body As String)
        ' Initiate a SMTP client and provide configuration

        Using smtpClient As New SmtpClient(EmailSmtpServer)
            smtpClient.UseDefaultCredentials = False
            smtpClient.Credentials = New NetworkCredential(EmailUsername, EmailPassword)
            smtpClient.Port = EmailPort
            smtpClient.EnableSsl = True

            ' Initiate a new mail message and provide heading and body to follow

            Using mailMessage As New MailMessage(EmailFromAddress, toAddress)
                mailMessage.Subject = subject
                mailMessage.Body = body
                smtpClient.Send(mailMessage)
            End Using
        End Using
    End Sub

    ' function name: VerifyCode
    ' desc: This function verifies a user's data entry against the correct verification code
    ' args (userInput, correctCode) Returns Boolean
    Public Function VerifyCode(userInput As String, correctCode As String) As Boolean
        Return userInput = correctCode
    End Function
End Class
