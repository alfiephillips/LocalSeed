<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusinessDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusinessDashboard))
        Me.vLineOne = New System.Windows.Forms.Label()
        Me.hLine4 = New System.Windows.Forms.Label()
        Me.lblSelectedNavigation = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.lblSupportDescription = New System.Windows.Forms.Label()
        Me.lblSettingsDescription = New System.Windows.Forms.Label()
        Me.lblSupportHelp = New System.Windows.Forms.Label()
        Me.lblPreferencesSettings = New System.Windows.Forms.Label()
        Me.lblDashboardDescription = New System.Windows.Forms.Label()
        Me.lblMenuDashboard = New System.Windows.Forms.Label()
        Me.lblSupport = New System.Windows.Forms.Label()
        Me.lblPreferences = New System.Windows.Forms.Label()
        Me.hLine3 = New System.Windows.Forms.Label()
        Me.hLineTwo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pBoxProfilePicture = New System.Windows.Forms.PictureBox()
        Me.bDControl = New LocalSeed.bDControl()
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vLineOne
        '
        Me.vLineOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.vLineOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLineOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.vLineOne.Location = New System.Drawing.Point(287, 0)
        Me.vLineOne.Name = "vLineOne"
        Me.vLineOne.Size = New System.Drawing.Size(2, 1080)
        Me.vLineOne.TabIndex = 8
        '
        'hLine4
        '
        Me.hLine4.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLine4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine4.Location = New System.Drawing.Point(290, 150)
        Me.hLine4.Name = "hLine4"
        Me.hLine4.Size = New System.Drawing.Size(1630, 1)
        Me.hLine4.TabIndex = 9
        '
        'lblSelectedNavigation
        '
        Me.lblSelectedNavigation.AutoSize = True
        Me.lblSelectedNavigation.Font = New System.Drawing.Font("Gill Sans MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedNavigation.ForeColor = System.Drawing.Color.White
        Me.lblSelectedNavigation.Location = New System.Drawing.Point(311, 29)
        Me.lblSelectedNavigation.Name = "lblSelectedNavigation"
        Me.lblSelectedNavigation.Size = New System.Drawing.Size(698, 67)
        Me.lblSelectedNavigation.TabIndex = 25
        Me.lblSelectedNavigation.Text = "Welcome to your dashboard, "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(82, 19)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(167, 45)
        Me.lblUsername.TabIndex = 27
        Me.lblUsername.Text = "Loading..."
        '
        'btnGoBack
        '
        Me.btnGoBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBack.Location = New System.Drawing.Point(148, 95)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(102, 35)
        Me.btnGoBack.TabIndex = 28
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'lblSupportDescription
        '
        Me.lblSupportDescription.AutoSize = True
        Me.lblSupportDescription.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupportDescription.ForeColor = System.Drawing.Color.White
        Me.lblSupportDescription.Location = New System.Drawing.Point(1, 929)
        Me.lblSupportDescription.Name = "lblSupportDescription"
        Me.lblSupportDescription.Size = New System.Drawing.Size(278, 42)
        Me.lblSupportDescription.TabIndex = 45
        Me.lblSupportDescription.Text = "Here's some support to help correctly start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your listings."
        '
        'lblSettingsDescription
        '
        Me.lblSettingsDescription.AutoSize = True
        Me.lblSettingsDescription.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsDescription.ForeColor = System.Drawing.Color.White
        Me.lblSettingsDescription.Location = New System.Drawing.Point(7, 712)
        Me.lblSettingsDescription.Name = "lblSettingsDescription"
        Me.lblSettingsDescription.Size = New System.Drawing.Size(264, 42)
        Me.lblSettingsDescription.TabIndex = 44
        Me.lblSettingsDescription.Text = "Contact an admin to change your settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " for you." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSupportHelp
        '
        Me.lblSupportHelp.AutoSize = True
        Me.lblSupportHelp.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupportHelp.ForeColor = System.Drawing.Color.White
        Me.lblSupportHelp.Location = New System.Drawing.Point(14, 876)
        Me.lblSupportHelp.Name = "lblSupportHelp"
        Me.lblSupportHelp.Size = New System.Drawing.Size(187, 30)
        Me.lblSupportHelp.TabIndex = 41
        Me.lblSupportHelp.Text = "Help and Support"
        '
        'lblPreferencesSettings
        '
        Me.lblPreferencesSettings.AutoSize = True
        Me.lblPreferencesSettings.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferencesSettings.ForeColor = System.Drawing.Color.White
        Me.lblPreferencesSettings.Location = New System.Drawing.Point(14, 676)
        Me.lblPreferencesSettings.Name = "lblPreferencesSettings"
        Me.lblPreferencesSettings.Size = New System.Drawing.Size(94, 30)
        Me.lblPreferencesSettings.TabIndex = 40
        Me.lblPreferencesSettings.Text = "Settings"
        '
        'lblDashboardDescription
        '
        Me.lblDashboardDescription.AutoSize = True
        Me.lblDashboardDescription.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardDescription.ForeColor = System.Drawing.Color.White
        Me.lblDashboardDescription.Location = New System.Drawing.Point(16, 207)
        Me.lblDashboardDescription.Name = "lblDashboardDescription"
        Me.lblDashboardDescription.Size = New System.Drawing.Size(217, 21)
        Me.lblDashboardDescription.TabIndex = 37
        Me.lblDashboardDescription.Text = "Overview of your current listings." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMenuDashboard
        '
        Me.lblMenuDashboard.AutoSize = True
        Me.lblMenuDashboard.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblMenuDashboard.Location = New System.Drawing.Point(14, 170)
        Me.lblMenuDashboard.Name = "lblMenuDashboard"
        Me.lblMenuDashboard.Size = New System.Drawing.Size(118, 30)
        Me.lblMenuDashboard.TabIndex = 36
        Me.lblMenuDashboard.Text = "Dashboard"
        '
        'lblSupport
        '
        Me.lblSupport.AutoSize = True
        Me.lblSupport.BackColor = System.Drawing.Color.Transparent
        Me.lblSupport.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblSupport.Location = New System.Drawing.Point(17, 823)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(51, 18)
        Me.lblSupport.TabIndex = 35
        Me.lblSupport.Text = "Support"
        '
        'lblPreferences
        '
        Me.lblPreferences.AutoSize = True
        Me.lblPreferences.BackColor = System.Drawing.Color.Transparent
        Me.lblPreferences.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreferences.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPreferences.Location = New System.Drawing.Point(13, 628)
        Me.lblPreferences.Name = "lblPreferences"
        Me.lblPreferences.Size = New System.Drawing.Size(70, 18)
        Me.lblPreferences.TabIndex = 34
        Me.lblPreferences.Text = "Preferences"
        '
        'hLine3
        '
        Me.hLine3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLine3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLine3.Location = New System.Drawing.Point(11, 857)
        Me.hLine3.Name = "hLine3"
        Me.hLine3.Size = New System.Drawing.Size(280, 1)
        Me.hLine3.TabIndex = 33
        '
        'hLineTwo
        '
        Me.hLineTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hLineTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.hLineTwo.Location = New System.Drawing.Point(11, 657)
        Me.hLineTwo.Name = "hLineTwo"
        Me.hLineTwo.Size = New System.Drawing.Size(280, 1)
        Me.hLineTwo.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1433, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 930)
        Me.Label1.TabIndex = 46
        '
        'pBoxProfilePicture
        '
        Me.pBoxProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.pBoxProfilePicture.ErrorImage = CType(resources.GetObject("pBoxProfilePicture.ErrorImage"), System.Drawing.Image)
        Me.pBoxProfilePicture.Image = CType(resources.GetObject("pBoxProfilePicture.Image"), System.Drawing.Image)
        Me.pBoxProfilePicture.InitialImage = CType(resources.GetObject("pBoxProfilePicture.InitialImage"), System.Drawing.Image)
        Me.pBoxProfilePicture.Location = New System.Drawing.Point(10, 19)
        Me.pBoxProfilePicture.Name = "pBoxProfilePicture"
        Me.pBoxProfilePicture.Size = New System.Drawing.Size(54, 51)
        Me.pBoxProfilePicture.TabIndex = 26
        Me.pBoxProfilePicture.TabStop = False
        '
        'bDControl
        '
        Me.bDControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.bDControl.Location = New System.Drawing.Point(291, 153)
        Me.bDControl.Margin = New System.Windows.Forms.Padding(1)
        Me.bDControl.Name = "bDControl"
        Me.bDControl.Size = New System.Drawing.Size(1143, 930)
        Me.bDControl.TabIndex = 47
        '
        'BusinessDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1444, 881)
        Me.Controls.Add(Me.bDControl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSupportDescription)
        Me.Controls.Add(Me.lblSettingsDescription)
        Me.Controls.Add(Me.lblSupportHelp)
        Me.Controls.Add(Me.lblPreferencesSettings)
        Me.Controls.Add(Me.lblDashboardDescription)
        Me.Controls.Add(Me.lblMenuDashboard)
        Me.Controls.Add(Me.lblSupport)
        Me.Controls.Add(Me.lblPreferences)
        Me.Controls.Add(Me.hLine3)
        Me.Controls.Add(Me.hLineTwo)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pBoxProfilePicture)
        Me.Controls.Add(Me.lblSelectedNavigation)
        Me.Controls.Add(Me.hLine4)
        Me.Controls.Add(Me.vLineOne)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "BusinessDashboard"
        Me.Text = "Dashboard"
        CType(Me.pBoxProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vLineOne As Label
    Friend WithEvents hLine4 As Label
    Friend WithEvents lblSelectedNavigation As Label
    Friend WithEvents pBoxProfilePicture As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnGoBack As Button
    Friend WithEvents lblSupportDescription As Label
    Friend WithEvents lblSettingsDescription As Label
    Friend WithEvents lblSupportHelp As Label
    Friend WithEvents lblPreferencesSettings As Label
    Friend WithEvents lblDashboardDescription As Label
    Friend WithEvents lblMenuDashboard As Label
    Friend WithEvents lblSupport As Label
    Friend WithEvents lblPreferences As Label
    Friend WithEvents hLine3 As Label
    Friend WithEvents hLineTwo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bDControl As bDControl
End Class
