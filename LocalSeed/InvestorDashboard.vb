Imports System.Linq.Expressions

Public Class InvestorDashboard
    Dim defaultHeadingText As String = "Welcome to your "
    Dim currentSelectedForm As String = "Dashboard"
    Dim currentUser As CurrentUser = FormStack.User

    ' function name: getCurrentFormText
    ' desc: This function is an automated process to get the currently selected form and provide the correct heading text for the dashboard
    ' args () Returns String
    Function getCurrentFormText() As String
        Return defaultHeadingText & currentSelectedForm & ", " & currentUser.username
    End Function

    ' subprocess name: Dashboard_Load
    ' desc: This subprocess is used to initiate handlers for all the controls to manage the state of the 'visible' property
    ' args (sender, e) Returns Null 
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Attach the VisibleChanged event handler to controls
        AddHandler dControl.VisibleChanged, AddressOf Controls_VisibleChanged
        AddHandler lControl.VisibleChanged, AddressOf Controls_VisibleChanged

        UpdateUI()

        lControl.Visible = False
        dControl.Visible = True
    End Sub

    ' subprocess name: Controls_VisibleChanged
    ' desc: This subprocess is used to update the user interface when visibility is changed
    ' args (sender, e) Returns Null 
    Private Sub Controls_VisibleChanged(sender As Object, e As EventArgs)
        If CType(sender, Control).Visible Then
            UpdateUI()
        End If
    End Sub

    ' subprocess name: UpdateUI
    ' desc: This subprocess is used to get the username in the session and get the currently selected option in the navigation bar
    ' args () Returns Null 
    Private Sub UpdateUI()
        ' Update the UI elements based on the current state
        lblUsername.Text = currentUser.username
        lblSelectedNavigation.Text = getCurrentFormText()
    End Sub

    ' Event handlers for menu clicks

    Private Sub lblMenuDashboard_Click(sender As Object, e As EventArgs) Handles lblMenuDashboard.Click
        If currentSelectedForm <> "Dashboard" Then
            currentSelectedForm = "Dashboard"
            lblMenuDashboard.ForeColor = Color.FromArgb(41, 120, 82)
            lblMenuListings.ForeColor = Color.White

            dControl.ReloadData()

            lControl.Visible = False
            dControl.Visible = True
        End If
    End Sub

    Private Sub lblMenuListings_Click(sender As Object, e As EventArgs) Handles lblMenuListings.Click
        currentSelectedForm = "Listings"
        lblMenuDashboard.ForeColor = Color.White
        lblMenuListings.ForeColor = Color.FromArgb(41, 120, 82)

        lControl.Visible = True
        dControl.Visible = False
    End Sub


    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        FormStack.Back()
    End Sub
End Class
