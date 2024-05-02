Public Class lControl
    ' global variables to find the user session and get current amount invested to user for selecting listings
    Dim currentUser As CurrentUser = FormStack.User
    Dim amountInvested As Integer = 0

    ' subprocess name: ListingsControl_Load
    ' desc: This subprocess is used to fill all the neccessary tables so we can efficiently manage investments when viewing the listings control
    ' args (sender, e) Returns Null 
    Private Sub ListingsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial data

        SignUp.InvestmentListingsTableAdapter.Fill(SignUp.DS.InvestmentListings)
        SignUp.BusinessTableAdapter.Fill(SignUp.DS.Business)
        SignUp.InvestmentTableAdapter.Fill(SignUp.DS.Investment)
        SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)

        txtInfo.Text = "These are your suggested listings. Please choose an investment opportunity:" & vbCrLf & vbCrLf &
            ""

    End Sub

    ' subprocess name: btnLoad_Click
    ' desc: This subprocess is used to load the current listings available to the users. This will eventually be filtered to user specific preferences
    ' args (sender, e) Returns Null 
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim loopCount, rowCount As Integer

        ' Change load button visibility
        btnLoad.Visible = False

        rowCount = SignUp.DS.Tables("InvestmentListings").Rows.Count() - 1

        ' Show available listings to user

        For loopCount = 0 To rowCount
            Dim businessName As String = SignUp.DS.Tables("InvestmentListings")(loopCount)(1)
            lBoxListings.Items.Add(CStr(loopCount + 1) & ". " & businessName)
        Next loopCount

    End Sub

    ' subprocess name: btnSelect_Click
    ' desc: This subprocess is used to initiate the investment process and form a data entry for the amount to invest into the selected company
    ' args (sender, e) Returns Null 
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim amountToInvest, selectedListingIndex As Integer

        amountToInvest = InputBox("Enter amount to invest")


        Dim investorLocation As Integer = FindByValue(SignUp.DS, "Investor", 1, currentUser.id).loopCount
        Dim investorFunds As Double = SignUp.DS.Tables("Investor")(investorLocation)(7)

            If amountToInvest > investorFunds Or amountToInvest <= 0 Then
                MsgBox("You do not have enough funds to make this investment or your investment is negative.")
                Return
            End If

            ' Create new investment

            selectedListingIndex = lBoxListings.SelectedIndex

        ' Find business and investor id to be able to create an investment

        Dim businessUserID = SignUp.DS.Tables("InvestmentListings")(selectedListingIndex - 1)(8)
        Dim business As DuplicateReturnType = FindByValue(SignUp.DS, "Business", 1, businessUserID)
        Dim investor As DuplicateReturnType = FindByValue(SignUp.DS, "Investor", 1, currentUser.id)

        Dim businessID As Integer = business.data(0)
        Dim investorID As Integer = investor.data(0)

        Dim newInvestment As DataRow = SignUp.DS.Tables("Investment").NewRow()
        Dim newTransaction As DataRow = SignUp.DS.Tables("Transactions").NewRow()

        ' Find current value of the listing

        Dim listing = FindByValue(SignUp.DS, "InvestmentListings", 0, selectedListingIndex - 1)
        Dim currentListingValue As Double = listing.data.currentValue

        ' Set data fields

        newInvestment("id") = Guid.NewGuid()
        newInvestment("businessID") = businessID
        newInvestment("investorID") = investorID
        newInvestment("amountInvested") = amountToInvest
        newInvestment("investmentDate") = CStr(Date.Now())
        newInvestment("status") = "Active"
        newInvestment("listingId") = selectedListingIndex - 1
        newInvestment("profitLoss") = 0
        newInvestment("newTotal") = amountToInvest
        newInvestment("listingCurrentValue") = currentListingValue


        newTransaction("investmentID") = newInvestment("id")
        newTransaction("amount") = newInvestment("amountInvested")
        newTransaction("tax") = 0
        newTransaction("status") = "Active"
        newTransaction("method") = "Manual"
        newTransaction("externalFees") = 0
        newTransaction("currency") = "GBP"
        newTransaction("location") = currentUser.nationality

        ' Add a new row for investment
        SignUp.DS.Tables("Investment").Rows.Add(newInvestment)

        ' Update and refill adapters
        SignUp.InvestmentTableAdapter.Update(SignUp.DS.Investment)
        SignUp.InvestmentTableAdapter.Fill(SignUp.DS.Investment)

        ' Add a new row for transaction

        SignUp.DS.Tables("Transactions").Rows.Add(newTransaction)

        ' Update and refill adapters

        SignUp.TransactionsTableAdapter.Update(SignUp.DS.Transactions)
        SignUp.TransactionsTableAdapter.Fill(SignUp.DS.Transactions)

        Dim investorRow As DataRow = SignUp.DS.Tables("Investor")(investorLocation)

        If investorRow IsNot Nothing Then
            SignUp.DS.Tables("Investor")(investorLocation)(7) = investorFunds - amountToInvest
            Dim currentTotalInvested As Integer = investorRow("amountInvested")

            amountInvested = currentTotalInvested + amountToInvest

            SignUp.DS.Tables("Investor")(investorLocation)(5) = amountInvested

            SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)

            ' After updating the points
            SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)


        Else
            MsgBox("Investor Record not found.")
            Return
        End If


        MsgBox("Investment made successfully!")
    End Sub

    Public Sub ReloadData()
        ' Refill the tables with the latest data
        SignUp.InvestmentListingsTableAdapter.Fill(SignUp.DS.InvestmentListings)
        SignUp.BusinessTableAdapter.Fill(SignUp.DS.Business)
        SignUp.InvestmentTableAdapter.Fill(SignUp.DS.Investment)
        SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)

        ' Update UI components based on the new data
        UpdateListings()
    End Sub

    Private Sub UpdateListings()
        lBoxListings.Items.Clear()
        Dim rowCount As Integer = SignUp.DS.Tables("InvestmentListings").Rows.Count - 1
        For loopCount As Integer = 0 To rowCount
            Dim businessName As String = SignUp.DS.Tables("InvestmentListings")(loopCount)(1).ToString()
            lBoxListings.Items.Add((loopCount + 1).ToString() & ". " & businessName)
        Next
    End Sub


End Class
