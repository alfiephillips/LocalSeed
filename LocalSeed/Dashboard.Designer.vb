<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.hLineOne = New System.Windows.Forms.Label()
        Me.hLineTwo = New System.Windows.Forms.Label()
        Me.hLine3 = New System.Windows.Forms.Label()
        Me.vLineOne = New System.Windows.Forms.Label()
        Me.hLine4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblPreferences = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.lblMenuDashboard = New System.Windows.Forms.Label()
        Me.lblMenuPortfolio = New System.Windows.Forms.Label()
        Me.lblMenuTransactions = New System.Windows.Forms.Label()
        Me.lblMenuListings = New System.Windows.Forms.Label()
        Me.lblMenuNotifications = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSupportHelp = New System.Windows.Forms.Label()
        Me.pBoxProfilePicture = New System.Windows.Forms.PictureBox()
        Me.lblSelectedNavigation = New System.Windows.Forms.Label()
        Me.DashboardControl1 = New LocalSeed.DashboardControl()
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(72, 12)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(167, 45)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Loading..."
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 1041)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'hLineOne
        '
        Me.hLineOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLineOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineOne.Location = New System.Drawing.Point(9, 200)
        Me.hLineOne.Name = "hLineOne"
        Me.hLineOne.Size = New System.Drawing.Size(280, 2)
        Me.hLineOne.TabIndex = 4
        '
        'hLineTwo
        '
        Me.hLineTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLineTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineTwo.Location = New System.Drawing.Point(9, 700)
        Me.hLineTwo.Name = "hLineTwo"
        Me.hLineTwo.Size = New System.Drawing.Size(280, 2)
        Me.hLineTwo.TabIndex = 5
        '
        'hLine3
        '
        Me.hLine3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLine3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine3.Location = New System.Drawing.Point(9, 900)
        Me.hLine3.Name = "hLine3"
        Me.hLine3.Size = New System.Drawing.Size(280, 2)
        Me.hLine3.TabIndex = 6
        '
        'vLineOne
        '
        Me.vLineOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.vLineOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLineOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.vLineOne.Location = New System.Drawing.Point(287, 0)
        Me.vLineOne.Name = "vLineOne"
        Me.vLineOne.Size = New System.Drawing.Size(2, 1080)
        Me.vLineOne.TabIndex = 7
        '
        'hLine4
        '
        Me.hLine4.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLine4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine4.Location = New System.Drawing.Point(290, 150)
        Me.hLine4.Name = "hLine4"
        Me.hLine4.Size = New System.Drawing.Size(1630, 2)
        Me.hLine4.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1433, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 930)
        Me.Label1.TabIndex = 9
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(12, 178)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(38, 18)
        Me.lblMenu.TabIndex = 10
        Me.lblMenu.Text = "Menu"
        '
        'lblPreferences
        '
        Me.lblPreferences.AutoSize = True
        Me.lblPreferences.BackColor = System.Drawing.Color.Transparent
        Me.lblPreferences.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferences.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPreferences.Location = New System.Drawing.Point(12, 671)
        Me.lblPreferences.Name = "lblPreferences"
        Me.lblPreferences.Size = New System.Drawing.Size(70, 18)
        Me.lblPreferences.TabIndex = 13
        Me.lblPreferences.Text = "Preferences"
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.BackColor = System.Drawing.Color.Transparent
        Me.lblSupport.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblSupport.Location = New System.Drawing.Point(15, 866)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(51, 18)
        Me.lblSupport.TabIndex = 14
        Me.lblSupport.Text = "Support"
        '
        'lblMenuDashboard
        '
        Me.lblMenuDashboard.AutoSize = True
        Me.lblMenuDashboard.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblMenuDashboard.Location = New System.Drawing.Point(75, 220)
        Me.lblMenuDashboard.Name = "lblMenuDashboard"
        Me.lblMenuDashboard.Size = New System.Drawing.Size(118, 30)
        Me.lblMenuDashboard.TabIndex = 15
        Me.lblMenuDashboard.Text = "Dashboard"
        '
        'lblMenuPortfolio
        '
        Me.lblMenuPortfolio.AutoSize = True
        Me.lblMenuPortfolio.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuPortfolio.ForeColor = System.Drawing.Color.White
        Me.lblMenuPortfolio.Location = New System.Drawing.Point(75, 320)
        Me.lblMenuPortfolio.Name = "lblMenuPortfolio"
        Me.lblMenuPortfolio.Size = New System.Drawing.Size(99, 30)
        Me.lblMenuPortfolio.TabIndex = 16
        Me.lblMenuPortfolio.Text = "Portfolio"
        '
        'lblMenuTransactions
        '
        Me.lblMenuTransactions.AutoSize = True
        Me.lblMenuTransactions.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuTransactions.ForeColor = System.Drawing.Color.White
        Me.lblMenuTransactions.Location = New System.Drawing.Point(75, 420)
        Me.lblMenuTransactions.Name = "lblMenuTransactions"
        Me.lblMenuTransactions.Size = New System.Drawing.Size(139, 30)
        Me.lblMenuTransactions.TabIndex = 17
        Me.lblMenuTransactions.Text = "Transactions"
        '
        'lblMenuListings
        '
        Me.lblMenuListings.AutoSize = True
        Me.lblMenuListings.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuListings.ForeColor = System.Drawing.Color.White
        Me.lblMenuListings.Location = New System.Drawing.Point(75, 520)
        Me.lblMenuListings.Name = "lblMenuListings"
        Me.lblMenuListings.Size = New System.Drawing.Size(88, 30)
        Me.lblMenuListings.TabIndex = 18
        Me.lblMenuListings.Text = "Listings"
        '
        'lblMenuNotifications
        '
        Me.lblMenuNotifications.AutoSize = True
        Me.lblMenuNotifications.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuNotifications.ForeColor = System.Drawing.Color.White
        Me.lblMenuNotifications.Location = New System.Drawing.Point(75, 620)
        Me.lblMenuNotifications.Name = "lblMenuNotifications"
        Me.lblMenuNotifications.Size = New System.Drawing.Size(140, 30)
        Me.lblMenuNotifications.TabIndex = 19
        Me.lblMenuNotifications.Text = "Notifications"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(75, 720)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "My Profile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(75, 820)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 30)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Settings"
        '
        'lblSupportHelp
        '
        Me.lblSupportHelp.AutoSize = True
        Me.lblSupportHelp.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupportHelp.ForeColor = System.Drawing.Color.White
        Me.lblSupportHelp.Location = New System.Drawing.Point(75, 960)
        Me.lblSupportHelp.Name = "lblSupportHelp"
        Me.lblSupportHelp.Size = New System.Drawing.Size(187, 30)
        Me.lblSupportHelp.TabIndex = 22
        Me.lblSupportHelp.Text = "Help and Support"
        '
        'pBoxProfilePicture
        '
        Me.pBoxProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.pBoxProfilePicture.ErrorImage = CType(resources.GetObject("pBoxProfilePicture.ErrorImage"), System.Drawing.Image)
        Me.pBoxProfilePicture.Image = CType(resources.GetObject("pBoxProfilePicture.Image"), System.Drawing.Image)
        Me.pBoxProfilePicture.InitialImage = CType(resources.GetObject("pBoxProfilePicture.InitialImage"), System.Drawing.Image)
        Me.pBoxProfilePicture.Location = New System.Drawing.Point(12, 12)
        Me.pBoxProfilePicture.Name = "pBoxProfilePicture"
        Me.pBoxProfilePicture.Size = New System.Drawing.Size(54, 50)
        Me.pBoxProfilePicture.TabIndex = 0
        Me.pBoxProfilePicture.TabStop = False
        '
        'lblSelectedNavigation
        '
        Me.lblSelectedNavigation.AutoSize = True
        Me.lblSelectedNavigation.Font = New System.Drawing.Font("Gill Sans MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedNavigation.ForeColor = System.Drawing.Color.White
        Me.lblSelectedNavigation.Location = New System.Drawing.Point(332, 28)
        Me.lblSelectedNavigation.Name = "lblSelectedNavigation"
        Me.lblSelectedNavigation.Size = New System.Drawing.Size(698, 67)
        Me.lblSelectedNavigation.TabIndex = 24
        Me.lblSelectedNavigation.Text = "Welcome to your dashboard, "
        '
        'DashboardControl1
        '
        Me.DashboardControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.DashboardControl1.Location = New System.Drawing.Point(290, 155)
        Me.DashboardControl1.Name = "DashboardControl1"
        Me.DashboardControl1.Size = New System.Drawing.Size(1143, 925)
        Me.DashboardControl1.TabIndex = 23
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.lblSelectedNavigation)
        Me.Controls.Add(Me.DashboardControl1)
        Me.Controls.Add(Me.lblSupportHelp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMenuNotifications)
        Me.Controls.Add(Me.lblMenuListings)
        Me.Controls.Add(Me.lblMenuTransactions)
        Me.Controls.Add(Me.lblMenuPortfolio)
        Me.Controls.Add(Me.lblMenuDashboard)
        Me.Controls.Add(Me.lblSupport)
        Me.Controls.Add(Me.lblPreferences)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hLine4)
        Me.Controls.Add(Me.vLineOne)
        Me.Controls.Add(Me.hLine3)
        Me.Controls.Add(Me.hLineTwo)
        Me.Controls.Add(Me.hLineOne)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pBoxProfilePicture)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pBoxProfilePicture As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents hLineOne As Label
    Friend WithEvents hLineTwo As Label
    Friend WithEvents hLine3 As Label
    Friend WithEvents vLineOne As Label
    Friend WithEvents hLine4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblPreferences As Label
    Friend WithEvents lblSupport As Label
    Friend WithEvents lblMenuDashboard As Label
    Friend WithEvents lblMenuPortfolio As Label
    Friend WithEvents lblMenuTransactions As Label
    Friend WithEvents lblMenuListings As Label
    Friend WithEvents lblMenuNotifications As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSupportHelp As Label
    Friend WithEvents DashboardControl1 As DashboardControl
    Friend WithEvents lblSelectedNavigation As Label
End Class
