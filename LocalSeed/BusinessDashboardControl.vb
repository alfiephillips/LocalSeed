Public Class bDControl
    ' Global variables
    Dim currentUser As CurrentUser = FormStack.User
    Dim businessId As Integer

    Private listings As New List(Of String())
    Private currentIndex, listingCount As Integer

    Private Sub bDControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        SignUp.BusinessTableAdapter.Update(SignUp.DS.Business)
        SignUp.UserTableAdapter.Update(SignUp.DS.User)
        SignUp.InvestmentListingsTableAdapter.Update(SignUp.DS.InvestmentListings)
        SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)

        SignUp.BusinessTableAdapter.Fill(SignUp.DS.Business)
        SignUp.UserTableAdapter.Fill(SignUp.DS.User)
        SignUp.InvestmentListingsTableAdapter.Fill(SignUp.DS.InvestmentListings)
        SignUp.InvestorTableAdapter.Update(SignUp.DS.Investor)

        LoadCurrentListings()
        DisplayCurrentListings()
    End Sub

    ' subprocess name: LoadCurrentListings
    ' desc: Load all the listings the business has created
    ' args () Returns Null
    Sub LoadCurrentListings()
        ' Initial variables
        Dim count, listingRowCount, investorRowCount As Integer
        Dim listingId, title, description, type, location, minimumInvestment, horizon, status, dateCreated, currentValue

        ' Find existing business
        Dim businessQuery As DuplicateReturnType = FindByValue(SignUp.DS, "Business", 1, currentUser.id)
        businessId = businessQuery.data.id

        ' Get row count
        listingRowCount = SignUp.DS.Tables("InvestmentListings").Rows().Count() - 1
        investorRowCount = SignUp.DS.Tables("Investor").Rows().Count() - 1

        ' Error checking
        Try
            ' Find how many listings the business currently has
            For count = 0 To listingRowCount
                Dim row As DataRow = SignUp.DS.Tables("InvestmentListings")(count)

                If row("userId") = currentUser.id Then
                    listingCount += 1


                End If
            Next count

            lblAmountListingsData.Text = CStr(listingCount)


        Catch ex As Exception
            Console.Write(ex)
            MsgBox("Error: Please contact an admin.")
        End Try

        If listingCount <= 0 Then
            MsgBox("You currently have no listings!")
            Return
        End If

        listings.Clear()
        currentIndex = 0

        ' Add all the listings to display

        For loopCount As Integer = 0 To listingRowCount
            Dim listingRow As DataRow = SignUp.DS.Tables("InvestmentListings").Rows(loopCount)

            If listingRow(8) = currentUser.id Then
                listingId = listingRow(0)
                title = listingRow(1)
                description = listingRow(2)
                type = listingRow(3)
                location = listingRow(4)
                minimumInvestment = listingRow(5)
                horizon = listingRow(6)
                status = listingRow(7)
                dateCreated = listingRow(9)
                currentValue = listingRow(11)

                listings.Add(New String() {listingId, title, description, type, location, minimumInvestment, horizon, status, dateCreated, currentValue})
            End If
        Next loopCount

    End Sub

    ' Events for going forward and back a listing

    Private Sub btnNextListing_Click(sender As Object, e As EventArgs) Handles btnNextListing.Click
        currentIndex += 1

        lBoxCurrentListings.Items.Clear()
        DisplayCurrentListings()
    End Sub

    Private Sub btnBackListing_Click(sender As Object, e As EventArgs) Handles btnBackListing.Click
        currentIndex -= 1

        lBoxCurrentListings.Items.Clear()
        DisplayCurrentListings()
    End Sub

    ' subprocess name: btnCreateListing_Click
    ' desc: Create a new listing for a business
    ' args () Returns Null
    Private Sub btnCreateListing_Click(sender As Object, e As EventArgs) Handles btnCreateListing.Click
        'Initial variables

        Dim title, description, type, location As String
        Dim newId, minInvestment, horizon, listingValue As Integer

        ' Get values for creating listing

        title = InputBox("Name your investment opportunity")
        description = InputBox("Describe your new listing")
        type = InputBox("What type of listing is it?")
        location = InputBox("Where is it located?")

        minInvestment = CInt(InputBox("What is the minimum amount that can be invested?"))
        horizon = CInt(InputBox("Put a number 1-10 for its risk"))

        If horizon < 1 Or horizon > 10 Then
            MsgBox("Please start again. Invalid value for horizon.")
            Return
        End If

        listingValue = CDbl(InputBox("What is its initial public offering?"))

        newId = GetLatestID(SignUp.DS, "InvestmentListings")

        Dim newListing As DataRow = SignUp.DS.Tables("InvestmentListings").NewRow()

        ' Set data fields

        newListing("id") = newId
        newListing("title") = title
        newListing("description") = description
        newListing("type") = type
        newListing("location") = location
        newListing("minInvestment") = minInvestment
        newListing("horizon") = horizon
        newListing("status") = "Active"
        newListing("userId") = currentUser.id
        newListing("dateCreated") = Date.Now()
        newListing("currentValue") = listingValue
        newListing("startingValue") = listingValue

        ' Add a new row for the listing
        SignUp.DS.Tables("InvestmentListings").Rows.Add(newListing)

        ' Update and refill adapters
        SignUp.InvestmentListingsTableAdapter.Update(SignUp.DS.InvestmentListings)
        SignUp.InvestmentListingsTableAdapter.Update(SignUp.DS.InvestmentListings)

        MsgBox("Listing created successfully!")

        currentIndex = 0

        LoadCurrentListings()
        DisplayCurrentListings()


    End Sub

    ' subprocess name: DisplayCurrentListings
    ' desc: Dislay all the business' listings
    ' args () Returns Null
    Sub DisplayCurrentListings()
        If currentIndex < 0 Then
            Return
        End If

        lBoxCurrentListings.Items.Clear()

        lblLoading.Visible = True

        ' Ensure both navigation buttons are initially visible
        btnNextListing.Visible = True
        btnBackListing.Visible = True

        ' Handle visibility of buttons based on the current index
        If currentIndex = 0 Then
            ' Hide Back button if it's the first item
            btnBackListing.Visible = False
        ElseIf currentIndex = listings.Count - 1 Then
            ' Hide Next button if it's the last item
            btnNextListing.Visible = False
        End If

        If currentIndex < listings.Count Then
            Dim listingDetails = listings(currentIndex)
            lBoxCurrentListings.Items.Add("Index: " & currentIndex.ToString())
            lBoxCurrentListings.Items.Add("Listing ID: " & listingDetails(0))
            lBoxCurrentListings.Items.Add("Title: " & listingDetails(1))
            lBoxCurrentListings.Items.Add("Description: " & listingDetails(2))
            lBoxCurrentListings.Items.Add("Type: " & listingDetails(3))
            lBoxCurrentListings.Items.Add("Location: " & listingDetails(4))
            lBoxCurrentListings.Items.Add("Minimum Investment: " & listingDetails(5))
            lBoxCurrentListings.Items.Add("Horizon: " & listingDetails(6))
            lBoxCurrentListings.Items.Add("Status: " & listingDetails(7))
            lBoxCurrentListings.Items.Add("Current Value: £" & listingDetails(9))
            lBoxCurrentListings.Items.Add("Date Created: " & listingDetails(8))

        Else
            ' Handle any out-of-range error
            MsgBox("Error: No investment data available for the current selection. Please contact an administrator.")
        End If

        lblLoading.Visible = False
    End Sub
End Class
