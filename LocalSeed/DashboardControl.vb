Public Class DashboardControl
    Dim currentUser As CurrentUser = FormStack.User
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)
        SignUp.UserTableAdapter.Update(SignUp.DS.User)

        SignUp.UserTableAdapter.Fill(SignUp.DS.User)
        SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)

        ' Error handling in case query fails to find an existing row
        ' TODO: Refresh the page and create an error instance
        Try
            Dim query As DuplicateReturnType = FindByValue(DS, "Investor", 1, currentUser.id)

            ' Change existing values
            lblPortfolioValueData.Text = query.data.amountInvested
            lblPortfolioProfitLossValue.Text = query.data.profitLoss

            ' If the amount invested is 0, we cannot provide a perentage otherwise this will produce a ZeroDivisionError
            If query.data.amountInvested = 0 Then
                lblPortfolioPercentageChangeValue.Text = 0
            Else
                ' Calculate the percentage change using the original amount and the profit or loss
                lblPortfolioPercentageChangeValue.Text = (((query.data.amountInvested + query.data.profitLoss) - query.data.amountInvested) / query.data.amountInvested) * 100
            End If

        Catch ex As Exception
            ' Error exception
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Me.Visible = False
        ' Show Listings form

    End Sub

    Public Sub ReloadData()
        Try
            ' Refresh data adapters and UI
            SignUp.UserTableAdapter.Fill(SignUp.DS.User)
            SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)

            ' Retrieve updated information for the user
            Dim query As DuplicateReturnType = FindByValue(SignUp.DS, "Investor", 1, currentUser.id)
            lblPortfolioValueData.Text = query.data.amountInvested
            lblPortfolioProfitLossValue.Text = query.data.profitLoss

            ' Calculate and update percentage change
            UpdatePercentageChange(query.data.amountInvested, query.data.profitLoss)
        Catch ex As Exception
            ' Log or handle the error
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub UpdatePercentageChange(amountInvested As Integer, profitLoss As Integer)
        If amountInvested = 0 Then
            lblPortfolioPercentageChangeValue.Text = "0%"
        Else
            Dim percentageChange As Double = ((amountInvested + profitLoss - amountInvested) / amountInvested) * 100
            lblPortfolioPercentageChangeValue.Text = percentageChange.ToString("N2") & "%"
        End If
    End Sub
End Class
