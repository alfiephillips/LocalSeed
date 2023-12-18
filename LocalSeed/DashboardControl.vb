Public Class DashboardControl
    Dim currentUser As CurrentUser = FormStack.User
    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UserTableAdapter.Fill(Me.DS.User)
        Me.InvestorTableAdapter.Fill(Me.DS.Investor)

        Try
            Dim query As DuplicateReturnType = FindByValue(DS, "Investor", 1, currentUser.id)
            MsgBox(query.data.amountInvested)

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
