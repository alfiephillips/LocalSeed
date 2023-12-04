<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Me.components = New System.ComponentModel.Container()
        Me.BSUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New LocalSeed.DS()
        Me.UserTableAdapter = New LocalSeed.DSTableAdapters.UserTableAdapter()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblNoAccount = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.LinkLabel()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblCreateAccount = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
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
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.panel1.Controls.Add(Me.lblNoAccount)
        Me.panel1.Controls.Add(Me.btnLogIn)
        Me.panel1.Controls.Add(Me.btnShowPassword)
        Me.panel1.Controls.Add(Me.lblPassword)
        Me.panel1.Controls.Add(Me.lblEmail)
        Me.panel1.Controls.Add(Me.txtPassword)
        Me.panel1.Controls.Add(Me.txtEmail)
        Me.panel1.Controls.Add(Me.lblSubtitle)
        Me.panel1.Controls.Add(Me.lblSignIn)
        Me.panel1.Controls.Add(Me.lblTitle)
        Me.panel1.Controls.Add(Me.logoPictureBox)
        Me.panel1.Controls.Add(Me.lblCreateAccount)
        Me.panel1.Font = New System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(640, 1080)
        Me.panel1.TabIndex = 0
        '
        'lblNoAccount
        '
        Me.lblNoAccount.AutoSize = True
        Me.lblNoAccount.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoAccount.ForeColor = System.Drawing.Color.White
        Me.lblNoAccount.Location = New System.Drawing.Point(37, 598)
        Me.lblNoAccount.Name = "lblNoAccount"
        Me.lblNoAccount.Size = New System.Drawing.Size(190, 27)
        Me.lblNoAccount.TabIndex = 10
        Me.lblNoAccount.Text = "Don't have an account?"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(42, 516)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(370, 45)
        Me.btnLogIn.TabIndex = 9
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.ForeColor = System.Drawing.Color.White
        Me.btnShowPassword.Location = New System.Drawing.Point(327, 438)
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
        Me.lblPassword.Location = New System.Drawing.Point(37, 410)
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
        Me.lblEmail.Location = New System.Drawing.Point(37, 314)
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
        Me.txtPassword.Location = New System.Drawing.Point(42, 438)
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
        Me.txtEmail.Location = New System.Drawing.Point(42, 342)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(370, 45)
        Me.txtEmail.TabIndex = 4
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.White
        Me.lblSubtitle.Location = New System.Drawing.Point(37, 255)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(253, 30)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Enter your details below"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblSignIn.Location = New System.Drawing.Point(34, 210)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(123, 45)
        Me.lblSignIn.TabIndex = 1
        Me.lblSignIn.Text = "Sign In"
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
        Me.logoPictureBox.Location = New System.Drawing.Point(-10, -13)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.logoPictureBox.Size = New System.Drawing.Size(210, 177)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 0
        Me.logoPictureBox.TabStop = False
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.AutoSize = True
        Me.lblCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCreateAccount.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.ForeColor = System.Drawing.Color.White
        Me.lblCreateAccount.Location = New System.Drawing.Point(233, 598)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(176, 27)
        Me.lblCreateAccount.TabIndex = 12
        Me.lblCreateAccount.Text = "Create an account"
        '
        'pictureBox
        '
        Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(1285, 1061)
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
        Me.splitContainer.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.pictureBox)
        Me.splitContainer.Size = New System.Drawing.Size(1920, 1061)
        Me.splitContainer.SplitterDistance = 634
        Me.splitContainer.SplitterWidth = 1
        Me.splitContainer.TabIndex = 0
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Name = "LogIn"
        Me.Text = "Home"
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BSUser As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents UserTableAdapter As DSTableAdapters.UserTableAdapter
    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents panel1 As Panel
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents splitContainer As SplitContainer
    Friend WithEvents lblTitle As LinkLabel
    Friend WithEvents logoPictureBox As PictureBox
    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblNoAccount As Label
    Friend WithEvents lblCreateAccount As Label
End Class
