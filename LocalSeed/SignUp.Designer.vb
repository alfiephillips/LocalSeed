<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
    Inherits System.Windows.Forms.Form
    Dim mainColor = RGB(41, 120, 82)

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.BSUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New LocalSeed.DS()
        Me.UserTableAdapter = New LocalSeed.DSTableAdapters.UserTableAdapter()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlOne = New System.Windows.Forms.Panel()
        Me.lblExistingAccount = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblCreateAccount = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.LinkLabel()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.BSInvestor = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSInvestmentPreferences = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestorTableAdapter = New LocalSeed.DSTableAdapters.InvestorTableAdapter()
        Me.InvestmentPreferencesTableAdapter = New LocalSeed.DSTableAdapters.InvestmentPreferencesTableAdapter()
        Me.BSBusiness = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusinessTableAdapter = New LocalSeed.DSTableAdapters.BusinessTableAdapter()
        Me.BSInvestment = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentTableAdapter = New LocalSeed.DSTableAdapters.InvestmentTableAdapter()
        Me.BSInvestmentListings = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentListingsTableAdapter = New LocalSeed.DSTableAdapters.InvestmentListingsTableAdapter()
        Me.BSTransactions = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionsTableAdapter = New LocalSeed.DSTableAdapters.TransactionsTableAdapter()
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOne.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestmentPreferences, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestmentListings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSUser
        '
        Me.BSUser.DataMember = "User"
        Me.BSUser.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.Size = New System.Drawing.Size(200, 100)
        Me.tableLayoutPanel.TabIndex = 1
        '
        'pnlOne
        '
        Me.pnlOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.pnlOne.Controls.Add(Me.lblExistingAccount)
        Me.pnlOne.Controls.Add(Me.btnSignUp)
        Me.pnlOne.Controls.Add(Me.btnShowPassword)
        Me.pnlOne.Controls.Add(Me.lblPassword)
        Me.pnlOne.Controls.Add(Me.lblEmail)
        Me.pnlOne.Controls.Add(Me.txtPassword)
        Me.pnlOne.Controls.Add(Me.txtEmail)
        Me.pnlOne.Controls.Add(Me.lblName)
        Me.pnlOne.Controls.Add(Me.txtName)
        Me.pnlOne.Controls.Add(Me.lblSubtitle)
        Me.pnlOne.Controls.Add(Me.lblCreateAccount)
        Me.pnlOne.Controls.Add(Me.lblTitle)
        Me.pnlOne.Controls.Add(Me.logoPictureBox)
        Me.pnlOne.Controls.Add(Me.lblLogIn)
        Me.pnlOne.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOne.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlOne.Location = New System.Drawing.Point(0, 0)
        Me.pnlOne.Name = "pnlOne"
        Me.pnlOne.Size = New System.Drawing.Size(640, 1080)
        Me.pnlOne.TabIndex = 0
        '
        'lblExistingAccount
        '
        Me.lblExistingAccount.AutoSize = True
        Me.lblExistingAccount.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistingAccount.ForeColor = System.Drawing.Color.White
        Me.lblExistingAccount.Location = New System.Drawing.Point(88, 685)
        Me.lblExistingAccount.Name = "lblExistingAccount"
        Me.lblExistingAccount.Size = New System.Drawing.Size(206, 27)
        Me.lblExistingAccount.TabIndex = 10
        Me.lblExistingAccount.Text = "Already have an account?"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(42, 615)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(370, 45)
        Me.btnSignUp.TabIndex = 9
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.ForeColor = System.Drawing.Color.White
        Me.btnShowPassword.Location = New System.Drawing.Point(327, 537)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(85, 45)
        Me.btnShowPassword.TabIndex = 8
        Me.btnShowPassword.Text = "View"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(37, 509)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(106, 25)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(37, 410)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(150, 25)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email Address"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(42, 537)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(272, 45)
        Me.txtPassword.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(42, 438)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(370, 45)
        Me.txtEmail.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(37, 308)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(42, 336)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 45)
        Me.txtName.TabIndex = 3
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(37, 255)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(177, 30)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Lets get started!"
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblCreateAccount.Location = New System.Drawing.Point(34, 210)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(298, 45)
        Me.lblCreateAccount.TabIndex = 1
        Me.lblCreateAccount.Text = "Create an account"
        '
        'lblTitle
        '
        Me.lblTitle.ActiveLinkColor = System.Drawing.Color.White
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblTitle.LinkColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(151, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 69)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.TabStop = True
        Me.lblTitle.Text = "Localseed"
        '
        'logoPictureBox
        '
        Me.logoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.logoPictureBox.BackgroundImage = CType(resources.GetObject("logoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.logoPictureBox.Image = CType(resources.GetObject("logoPictureBox.Image"), System.Drawing.Image)
        Me.logoPictureBox.Location = New System.Drawing.Point(-10, -13)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(210, 177)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 0
        Me.logoPictureBox.TabStop = False
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogIn.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.ForeColor = System.Drawing.Color.White
        Me.lblLogIn.Location = New System.Drawing.Point(289, 685)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(66, 27)
        Me.lblLogIn.TabIndex = 12
        Me.lblLogIn.Text = "Log in"
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.Image = CType(resources.GetObject("pictureBox.Image"), System.Drawing.Image)
        Me.pictureBox.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(1269, 1041)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = False
        '
        'splitContainer
        '
        Me.splitContainer.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer.IsSplitterFixed = True
        Me.splitContainer.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.splitContainer.Name = "splitContainer"
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.pnlOne)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.pictureBox)
        Me.splitContainer.Size = New System.Drawing.Size(1904, 1041)
        Me.splitContainer.SplitterDistance = 634
        Me.splitContainer.SplitterWidth = 1
        Me.splitContainer.TabIndex = 0
        '
        'BSInvestor
        '
        Me.BSInvestor.DataMember = "Investor"
        Me.BSInvestor.DataSource = Me.DS
        '
        'BSInvestmentPreferences
        '
        Me.BSInvestmentPreferences.DataMember = "InvestmentPreferences"
        Me.BSInvestmentPreferences.DataSource = Me.DS
        '
        'InvestorTableAdapter
        '
        Me.InvestorTableAdapter.ClearBeforeFill = True
        '
        'InvestmentPreferencesTableAdapter
        '
        Me.InvestmentPreferencesTableAdapter.ClearBeforeFill = True
        '
        'BSBusiness
        '
        Me.BSBusiness.DataMember = "Business"
        Me.BSBusiness.DataSource = Me.DS
        '
        'BusinessTableAdapter
        '
        Me.BusinessTableAdapter.ClearBeforeFill = True
        '
        'BSInvestment
        '
        Me.BSInvestment.DataMember = "Investment"
        Me.BSInvestment.DataSource = Me.DS
        '
        'InvestmentTableAdapter
        '
        Me.InvestmentTableAdapter.ClearBeforeFill = True
        '
        'BSInvestmentListings
        '
        Me.BSInvestmentListings.DataMember = "InvestmentListings"
        Me.BSInvestmentListings.DataSource = Me.DS
        '
        'InvestmentListingsTableAdapter
        '
        Me.InvestmentListingsTableAdapter.ClearBeforeFill = True
        '
        'BSTransactions
        '
        Me.BSTransactions.DataMember = "Transactions"
        Me.BSTransactions.DataSource = Me.DS
        '
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Name = "SignUp"
        Me.Text = "Home"
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOne.ResumeLayout(False)
        Me.pnlOne.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestmentPreferences, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestmentListings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSUser As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents UserTableAdapter As DSTableAdapters.UserTableAdapter
    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents pnlOne As Panel
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents lblTitle As LinkLabel
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents lblCreateAccount As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblExistingAccount As Label
    Friend WithEvents lblLogIn As Label
    Friend WithEvents BSInvestor As BindingSource
    Friend WithEvents BSInvestmentPreferences As BindingSource
    Friend WithEvents InvestorTableAdapter As DSTableAdapters.InvestorTableAdapter
    Friend WithEvents InvestmentPreferencesTableAdapter As DSTableAdapters.InvestmentPreferencesTableAdapter
    Friend WithEvents BSBusiness As BindingSource
    Friend WithEvents BusinessTableAdapter As DSTableAdapters.BusinessTableAdapter
    Friend WithEvents BSInvestment As BindingSource
    Friend WithEvents InvestmentTableAdapter As DSTableAdapters.InvestmentTableAdapter
    Friend WithEvents BSInvestmentListings As BindingSource
    Friend WithEvents InvestmentListingsTableAdapter As DSTableAdapters.InvestmentListingsTableAdapter
    Friend WithEvents BSTransactions As BindingSource
    Friend WithEvents TransactionsTableAdapter As DSTableAdapters.TransactionsTableAdapter
End Class
