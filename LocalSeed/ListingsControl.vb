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
        Dim amountToInvest As Integer
        Dim selectedListingIndex As Integer

        amountToInvest = InputBox("Enter amount to invest")

        ' TODO: check amountToInvest against real portfolio value to not allow overdraft

        ' Create new investment

        selectedListingIndex = lBoxListings.SelectedIndex

        ' Find business and investor id to be able to create an investment

        Dim businessUserID = SignUp.DS.Tables("InvestmentListings")(selectedListingIndex - 1)(8)
        Dim business As DuplicateReturnType = FindByValue(DS, "Business", 1, businessUserID)
        Dim investor As DuplicateReturnType = FindByValue(DS, "Investor", 1, currentUser.id)

        Dim businessID As Integer = business.data(0)
        Dim investorID As Integer = investor.data(0)

        Dim newInvestment As DataRow = SignUp.DS.Tables("Investment").NewRow()

        ' Set data fields

        newInvestment("id") = Guid.NewGuid()
        newInvestment("businessID") = businessID
        newInvestment("investorID") = investorID
        newInvestment("amountInvested") = amountToInvest
        newInvestment("investmentDate") = "24/01/2024"
        newInvestment("status") = "Active"
        newInvestment("listingID") = selectedListingIndex

        ' Add a new row for investment
        SignUp.DS.Tables("Investment").Rows.Add(newInvestment)

        ' Update and refill adapters
        SignUp.InvestmentTableAdapter.Update(DS.Investment)
        SignUp.InvestmentTableAdapter.Fill(DS.Investment)

        ' Find an existing investor row and update existing balance
        Dim investorLocation As Integer = investor.loopCount

        Dim investorRow As DataRow = SignUp.DS.Tables("Investor")(investorLocation)

        If investorRow IsNot Nothing Then
            Dim currentTotalInvested As Integer = investorRow("amountInvested")
            amountInvested = currentTotalInvested + amountToInvest

            SignUp.DS.Tables("Investor")(investorLocation)(5) = amountInvested

            SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)

            SignUp.InvestorTableAdapter.Fill(SignUp.DS.Investor)
        Else
            MsgBox("Investor Record not found.")
            Return
        End If


        MsgBox("Investment made successfully!")
    End Sub
End Class
