<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.BSUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New LocalSeed.DS()
        Me.UserTableAdapter = New LocalSeed.DSTableAdapters.UserTableAdapter()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.LinkLabel()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblCreateAccount = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel1.Controls.Add(Me.btnShowPassword)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.lblEmail)
        Me.panel1.Controls.Add(Me.txtPassword)
        Me.panel1.Controls.Add(Me.txtEmail)
        Me.panel1.Controls.Add(Me.lblName)
        Me.panel1.Controls.Add(Me.txtName)
        Me.panel1.Controls.Add(Me.lblSubtitle)
        Me.panel1.Controls.Add(Me.lblCreateAccount)
        Me.panel1.Controls.Add(Me.lblTitle)
        Me.panel1.Controls.Add(Me.logoPictureBox)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(640, 1080)
        Me.panel1.TabIndex = 0
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
        Me.splitContainer.Panel1.Controls.Add(Me.panel1)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.pictureBox)
        Me.splitContainer.Size = New System.Drawing.Size(1904, 1041)
        Me.splitContainer.SplitterDistance = 634
        Me.splitContainer.SplitterWidth = 1
        Me.splitContainer.TabIndex = 0
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
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(42, 336)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(482, 44)
        Me.txtName.TabIndex = 3
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
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(42, 438)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(482, 44)
        Me.txtEmail.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(42, 537)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(482, 44)
        Me.txtPassword.TabIndex = 5
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 509)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'btnShowPassword
        '
        Me.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnShowPassword.ForeColor = System.Drawing.Color.White
        Me.btnShowPassword.Location = New System.Drawing.Point(412, 587)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(112, 27)
        Me.btnShowPassword.TabIndex = 8
        Me.btnShowPassword.Text = "View Password"
        Me.btnShowPassword.UseVisualStyleBackColor = False
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Name = "index"
        Me.Text = "Home"
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCreateAccount As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnShowPassword As Button
End Class
