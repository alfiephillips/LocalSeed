Public Class DashboardControl
    Dim currentUser As CurrentUser = FormStack.User
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignUp.UserTableAdapter.Fill(Me.DS.User)
        SignUp.InvestorTableAdapter.Fill(Me.DS.Investor)

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
End Class
