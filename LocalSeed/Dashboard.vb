Public Class Dashboard
    Dim defaultHeadingText As String = "Welcome to your "
    Dim currentSelectedForm As String = "Dashboard"
    Dim currentUser As CurrentUser = FormStack.User

    Function getCurrentFormText()
        Return defaultHeadingText & currentSelectedForm & ", " & currentUser.email
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStack.AddForm(Me)

        lblUsername.Text = currentUser.username
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    Private Sub lblMenuPortfolio_Click(sender As Object, e As EventArgs) Handles lblMenuPortfolio.Click
        currentSelectedForm = "Portfolio"
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    Private Sub lblMenuTransactions_Click(sender As Object, e As EventArgs) Handles lblMenuTransactions.Click
        currentSelectedForm = "Transactions"
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    Private Sub lblMenuListings_Click(sender As Object, e As EventArgs) Handles lblMenuListings.Click
        currentSelectedForm = "Listings"
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    Private Sub lblMenuNotifications_Click(sender As Object, e As EventArgs) Handles lblMenuNotifications.Click
        currentSelectedForm = "Notifications"
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    Private Sub lblMenuDashboard_Click(sender As Object, e As EventArgs) Handles lblMenuDashboard.Click
        If currentSelectedForm <> "Dashboard" Then
            currentSelectedForm = "Dashboard"
            lblSelectedNavigation.Text = getCurrentFormText()
        End If
    End Sub
End Class