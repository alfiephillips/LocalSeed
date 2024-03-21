<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.lBoxListings = New System.Windows.Forms.ListBox()
        Me.btnSelect = New LocalSeed.RoundedButton()
        Me.btnLoad = New LocalSeed.RoundedButton()
        Me.BSListings = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New LocalSeed.DS()
        Me.InvestmentListingsTableAdapter = New LocalSeed.DSTableAdapters.InvestmentListingsTableAdapter()
        Me.BSBusiness = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusinessTableAdapter = New LocalSeed.DSTableAdapters.BusinessTableAdapter()
        Me.BSInvestment = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestmentTableAdapter = New LocalSeed.DSTableAdapters.InvestmentTableAdapter()
        Me.BSInvestor = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestorTableAdapter = New LocalSeed.DSTableAdapters.InvestorTableAdapter()
        CType(Me.BSListings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lBoxListings
        '
        Me.lBoxListings.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lBoxListings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lBoxListings.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoxListings.ForeColor = System.Drawing.Color.White
        Me.lBoxListings.FormattingEnabled = True
        Me.lBoxListings.ItemHeight = 30
        Me.lBoxListings.Items.AddRange(New Object() {"Company Name"})
        Me.lBoxListings.Location = New System.Drawing.Point(83, 29)
        Me.lBoxListings.Name = "lBoxListings"
        Me.lBoxListings.Size = New System.Drawing.Size(441, 482)
        Me.lBoxListings.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(423, 38)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 47)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(423, 91)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(96, 47)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'BSListings
        '
        Me.BSListings.DataMember = "InvestmentListings"
        Me.BSListings.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvestmentListingsTableAdapter
        '
        Me.InvestmentListingsTableAdapter.ClearBeforeFill = True
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
        'BSInvestor
        '
        Me.BSInvestor.DataMember = "Investor"
        Me.BSInvestor.DataSource = Me.DS
        '
        'InvestorTableAdapter
        '
        Me.InvestorTableAdapter.ClearBeforeFill = True
        '
        'lControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lBoxListings)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "lControl"
        Me.Size = New System.Drawing.Size(1143, 925)
        CType(Me.BSListings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lBoxListings As ListBox
    Friend WithEvents BSListings As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents InvestmentListingsTableAdapter As DSTableAdapters.InvestmentListingsTableAdapter
    Friend WithEvents BSBusiness As BindingSource
    Friend WithEvents BusinessTableAdapter As DSTableAdapters.BusinessTableAdapter
    Friend WithEvents BSInvestment As BindingSource
    Friend WithEvents InvestmentTableAdapter As DSTableAdapters.InvestmentTableAdapter
    Friend WithEvents BSInvestor As BindingSource
    Friend WithEvents InvestorTableAdapter As DSTableAdapters.InvestorTableAdapter
    Friend WithEvents btnSelect As RoundedButton
    Friend WithEvents btnLoad As RoundedButton
End Class
