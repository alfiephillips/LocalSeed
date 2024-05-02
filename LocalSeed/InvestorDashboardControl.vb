Imports System.Threading

Public Class InvestorDashboardControl
    Dim currentUser As CurrentUser = FormStack.User
    Dim investorId As Integer

    Private investments As New List(Of String())
    Private currentIndex As Integer = 0
    Private portfolioTotal, portfolioProfitLoss, portfolioPercentageChange As Double

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)
        SignUp.UserTableAdapter.Update(SignUp.DS.User)
        SignUp.InvestmentListingsTableAdapter.Update(SignUp.DS.InvestmentListings)

        SignUp.UserTableAdapter.Fill(SignUp.DS.User)
        SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)
        SignUp.InvestmentListingsTableAdapter.Update(SignUp.DS.InvestmentListings)

        ' Error handling in case query fails to find an existing row
        ' TODO: Refresh the page and create an error instance
        Try
            Dim query As DuplicateReturnType = FindByValue(DS, "Investor", 1, currentUser.id)

            ' Change existing values

            'portfolioTotal += CDbl(query.data.amountInvested)
            'portfolioProfitLoss += CDbl(query.data.pr)

            portfolioTotal = CDbl(query.data.amountInvested)
            lblPortfolioValueData.Text = query.data.amountInvested
            lblFundsValue.Text = query.data.funds

            ' Set investor id to use

            investorId = query.data.id

            ' If the amount invested is 0, we cannot provide a percentage otherwise this will produce a ZeroDivisionError
            If query.data.amountInvested = 0 Then
                lblPortfolioPercentageChangeValue.Text = 0
            Else
                ' Calculate the percentage change using the original amount and the profit or loss
                lblPortfolioPercentageChangeValue.Text = (((query.data.amountInvested + query.data.profitLoss) - query.data.amountInvested) / query.data.amountInvested) * 100
            End If

            LoadCurrentInvestments()
            DisplayCurrentInvestment()

        Catch ex As Exception
            ' Error exception
            Console.Write(ex.Message)
        End Try
    End Sub

    ' func name: CalculateProfitLoss
    ' desc: Calculates the profit loss for a listing
    ' args: (listingId, amountInvested) Returns Double
    Private Function CalculateProfitLoss(ByVal listingId As Integer, ByVal amountInvested As Double)
        Dim listing As DuplicateReturnType = FindByValue(SignUp.DS, "InvestmentListings", 0, listingId)
        Dim currentValue, profitLoss, valueWhenBought As Double
        Dim ratio As Double

        ' Get current value of stock
        currentValue = CDbl(listing.data.currentValue)

        Dim existingInvestment As DuplicateReturnType = FindByValue(SignUp.DS, "Investment", 6, listingId)
        Dim loopCount As Integer = existingInvestment.loopCount

        ' Find the value when bought
        valueWhenBought = SignUp.DS.Tables("Investment")(loopCount)("listingCurrentValue")

        ' Get the ratio between the now value and the previous value
        ratio = (currentValue - valueWhenBought) / valueWhenBought

        ' Multiply by the ratio
        profitLoss = Math.Round((amountInvested * ratio), 2)

        Return profitLoss

    End Function

    ' subprocedure name: LoadCurrentInvestments
    ' desc: Load all the investments the investor is tied into
    ' args () Returns Null
    Private Sub LoadCurrentInvestments()
        investments.Clear()
        currentIndex = 0
        Dim investmentRowCount As Integer = SignUp.DS.Tables("Investment").Rows.Count - 1
        Dim transactionRowCount As Integer = SignUp.DS.Tables("Transactions").Rows.Count - 1
        Dim businessRowCount As Integer = SignUp.DS.Tables("Business").Rows.Count - 1
        Dim businessId, investmentId, businessName, amountInvested, investmentDate, status, listingID As String

        ' Iterate and add to the investments list 
        For loopCount As Integer = 0 To investmentRowCount
            Dim investmentRow As DataRow = SignUp.DS.Tables("Investment").Rows(loopCount)

            If investmentRow(2) = investorId Then
                businessID = investmentRow(1).ToString()
                amountInvested = investmentRow(3).ToString()
                investmentDate = investmentRow(4).ToString()
                status = investmentRow(5).ToString()
                listingID = investmentRow(6).ToString()

                Dim profitLoss As Double = CalculateProfitLoss(CInt(listingID), CDbl(amountInvested))
                portfolioProfitLoss += profitLoss
                portfolioTotal += profitLoss

                investmentId = investmentRow(0).ToString()

                businessName = FindByValue(DS, "Business", 0, businessID).data.businessName

                investments.Add(New String() {listingID, amountInvested, status, investmentDate, businessName, investmentId})
            End If
        Next

        ' Change values of financial data
        lblPortfolioValueData.Text = "£" & CStr(portfolioTotal)
        lblPortfolioProfitLossValue.Text = "£" & CStr(portfolioProfitLoss)
    End Sub

    Public Sub ReloadData()
        Try
            ' Refresh data adapters and UI
            SignUp.UserTableAdapter.Fill(SignUp.DS.User)
            SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)
            SignUp.InvestmentTableAdapter.Fill(SignUp.DS.Investment)

            currentIndex = 0
            LoadCurrentInvestments()
            DisplayCurrentInvestment()

            ' Retrieve updated information for the user
            Dim query As DuplicateReturnType = FindByValue(SignUp.DS, "Investor", 1, currentUser.id)
            lblPortfolioValueData.Text = query.data.amountInvested
            lblPortfolioProfitLossValue.Text = query.data.profitLoss
            lblFundsValue.Text = query.data.funds

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

    Private Sub DisplayCurrentInvestment()
        lBoxCurrentInvestments.Items.Clear()

        lblLoading.Visible = True

        ' Ensure both navigation buttons are initially visible
        btnNextTransaction.Visible = True
        btnBackTransaction.Visible = True

        If investments.Count() = 1 Then
            btnBackTransaction.Visible = False
            btnNextTransaction.Visible = False
        End If

        ' Handle visibility of buttons based on the current index
        If currentIndex = 0 Then
            ' Hide Back button if it's the first item
            btnBackTransaction.Visible = False
        ElseIf currentIndex = investments.Count - 1 Then
            ' Hide Next button if it's the last item
            btnNextTransaction.Visible = False
        End If

        ' Display investment details if the index is within range
        If currentIndex < investments.Count Then
            Dim investmentDetails = investments(currentIndex)
            lBoxCurrentInvestments.Items.Add("Index: " & currentIndex.ToString())
            lBoxCurrentInvestments.Items.Add("Business Name: " & investmentDetails(4))
            lBoxCurrentInvestments.Items.Add("Listing Ref: " & investmentDetails(0)) ' Ensure index matches the details expected
            lBoxCurrentInvestments.Items.Add("Amount Invested: £" & investmentDetails(1))
            lBoxCurrentInvestments.Items.Add("Status: " & investmentDetails(2))
            lBoxCurrentInvestments.Items.Add("Investment Date: " & investmentDetails(3))
        Else
            ' Handle any out-of-range error
            MsgBox("Error: No investment data available for the current selection. Please contact an administrator.")
        End If

        lblLoading.Visible = False
    End Sub

    ' Events for moving between investments

    Private Sub btnNextTransaction_Click(sender As Object, e As EventArgs) Handles btnNextTransaction.Click
        If investments.Count > 0 Or currentIndex + 1 <= investments.Count Then
            currentIndex += 1

            lBoxCurrentInvestments.Items.Clear()
            DisplayCurrentInvestment()
        Else
            MessageBox.Show("No investments are loaded.")
        End If
    End Sub

    Private Sub btnBackTransaction_Click(sender As Object, e As EventArgs) Handles btnBackTransaction.Click
        currentIndex -= 1

        lBoxCurrentInvestments.Items.Clear()
        DisplayCurrentInvestment()
    End Sub

    ' subprocedure name: btnRemoveInvestment_Click
    ' desc: Remove an investmenmt and retain funds
    ' args () Returns Null
    Private Sub btnRemoveInvestment_Click(sender As Object, e As EventArgs) Handles btnRemoveInvestment.Click
        Dim investmentLocation, investorLocation As Integer
        Dim investmentDetails As Array
        Dim investmentRow, investorRow As DataRow

        If investments.Count = 0 Then
            MsgBox("There are no investments to remove!")
            Return
        End If

        investmentDetails = investments(currentIndex)

        investmentLocation = FindByValue(SignUp.DS, "Investment", 0, investmentDetails(5)).loopCount
        investorLocation = FindByValue(SignUp.DS, "Investor", 0, investorId).loopCount

        investmentRow = SignUp.DS.Tables("Investment")(investmentLocation)
        investorRow = SignUp.DS.Tables("Investor")(investorLocation)

        If investmentRow IsNot Nothing Then
            Dim currentStatus = investmentRow(5)

            If currentStatus = "Active" Then
                SignUp.DS.Tables("Investment")(investmentLocation)(5) = "Inactive"

                Dim amountInvested, profitLoss, funds, portfolioValue As Double

                amountInvested = investmentRow(3)
                profitLoss = investmentRow(7)
                funds = investorRow(7)
                portfolioValue = investorRow(5)

                ' amount invested
                SignUp.DS.Tables("Investor")(investorLocation)(5) = portfolioValue - (amountInvested + profitLoss)

                ' total funds
                SignUp.DS.Tables("Investor")(investorLocation)(7) = funds + (amountInvested + profitLoss)


                SignUp.InvestmentTableAdapter.Update(SignUp.DS.Investment)
                SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)

                ' After updating the points
                SignUp.InvestmentTableAdapter.Fill(SignUp.DS.Investment)
                SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)

                ReloadData()
            Else
                MsgBox("This investment has already been terminated.")
                Return
            End If
        End If
    End Sub
End Class
