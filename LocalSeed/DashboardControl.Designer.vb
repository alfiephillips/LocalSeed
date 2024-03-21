<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblPortfolioValue = New System.Windows.Forms.Label()
        Me.lblPortfolioProfitLoss = New System.Windows.Forms.Label()
        Me.lblPortfolioPercentageChange = New System.Windows.Forms.Label()
        Me.lblPortfolioValueData = New System.Windows.Forms.Label()
        Me.lblPortfolioPercentageChangeValue = New System.Windows.Forms.Label()
        Me.lblPortfolioProfitLossValue = New System.Windows.Forms.Label()
        Me.BSUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New LocalSeed.DS()
        Me.BSInvestor = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestorTableAdapter = New LocalSeed.DSTableAdapters.InvestorTableAdapter()
        Me.UserTableAdapter = New LocalSeed.DSTableAdapters.UserTableAdapter()
        Me.btnSelect = New LocalSeed.RoundedButton()
        Me.btnWithdraw = New LocalSeed.RoundedButton()
        Me.btnTopUp = New LocalSeed.RoundedButton()
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPortfolioValue
        '
        Me.lblPortfolioValue.AutoSize = True
        Me.lblPortfolioValue.BackColor = System.Drawing.Color.Transparent
        Me.lblPortfolioValue.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPortfolioValue.Location = New System.Drawing.Point(50, 30)
        Me.lblPortfolioValue.Name = "lblPortfolioValue"
        Me.lblPortfolioValue.Size = New System.Drawing.Size(88, 18)
        Me.lblPortfolioValue.TabIndex = 13
        Me.lblPortfolioValue.Text = "Portfolio Value"
        '
        'lblPortfolioProfitLoss
        '
        Me.lblPortfolioProfitLoss.AutoSize = True
        Me.lblPortfolioProfitLoss.BackColor = System.Drawing.Color.Transparent
        Me.lblPortfolioProfitLoss.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioProfitLoss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPortfolioProfitLoss.Location = New System.Drawing.Point(821, 30)
        Me.lblPortfolioProfitLoss.Name = "lblPortfolioProfitLoss"
        Me.lblPortfolioProfitLoss.Size = New System.Drawing.Size(92, 18)
        Me.lblPortfolioProfitLoss.TabIndex = 14
        Me.lblPortfolioProfitLoss.Text = "Profit/Loss (+/-)"
        '
        'lblPortfolioPercentageChange
        '
        Me.lblPortfolioPercentageChange.AutoSize = True
        Me.lblPortfolioPercentageChange.BackColor = System.Drawing.Color.Transparent
        Me.lblPortfolioPercentageChange.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioPercentageChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblPortfolioPercentageChange.Location = New System.Drawing.Point(445, 30)
        Me.lblPortfolioPercentageChange.Name = "lblPortfolioPercentageChange"
        Me.lblPortfolioPercentageChange.Size = New System.Drawing.Size(112, 18)
        Me.lblPortfolioPercentageChange.TabIndex = 15
        Me.lblPortfolioPercentageChange.Text = "Percentage Change"
        '
        'lblPortfolioValueData
        '
        Me.lblPortfolioValueData.AutoSize = True
        Me.lblPortfolioValueData.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioValueData.ForeColor = System.Drawing.Color.White
        Me.lblPortfolioValueData.Location = New System.Drawing.Point(40, 62)
        Me.lblPortfolioValueData.Name = "lblPortfolioValueData"
        Me.lblPortfolioValueData.Size = New System.Drawing.Size(291, 78)
        Me.lblPortfolioValueData.TabIndex = 16
        Me.lblPortfolioValueData.Text = "$5,122.50"
        '
        'lblPortfolioPercentageChangeValue
        '
        Me.lblPortfolioPercentageChangeValue.AutoSize = True
        Me.lblPortfolioPercentageChangeValue.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioPercentageChangeValue.ForeColor = System.Drawing.Color.White
        Me.lblPortfolioPercentageChangeValue.Location = New System.Drawing.Point(435, 62)
        Me.lblPortfolioPercentageChangeValue.Name = "lblPortfolioPercentageChangeValue"
        Me.lblPortfolioPercentageChangeValue.Size = New System.Drawing.Size(225, 78)
        Me.lblPortfolioPercentageChangeValue.TabIndex = 17
        Me.lblPortfolioPercentageChangeValue.Text = "+5.76%"
        '
        'lblPortfolioProfitLossValue
        '
        Me.lblPortfolioProfitLossValue.AutoSize = True
        Me.lblPortfolioProfitLossValue.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioProfitLossValue.ForeColor = System.Drawing.Color.White
        Me.lblPortfolioProfitLossValue.Location = New System.Drawing.Point(811, 62)
        Me.lblPortfolioProfitLossValue.Name = "lblPortfolioProfitLossValue"
        Me.lblPortfolioProfitLossValue.Size = New System.Drawing.Size(274, 78)
        Me.lblPortfolioProfitLossValue.TabIndex = 18
        Me.lblPortfolioProfitLossValue.Text = "+295.056"
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
        'BSInvestor
        '
        Me.BSInvestor.DataMember = "Investor"
        Me.BSInvestor.DataSource = Me.DS
        '
        'InvestorTableAdapter
        '
        Me.InvestorTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(53, 165)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(160, 65)
        Me.btnSelect.TabIndex = 19
        Me.btnSelect.Text = "Add new investment"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWithdraw.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.White
        Me.btnWithdraw.Location = New System.Drawing.Point(448, 165)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(160, 65)
        Me.btnWithdraw.TabIndex = 20
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnTopUp
        '
        Me.btnTopUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopUp.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopUp.ForeColor = System.Drawing.Color.White
        Me.btnTopUp.Location = New System.Drawing.Point(824, 165)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(160, 65)
        Me.btnTopUp.TabIndex = 21
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblPortfolioProfitLossValue)
        Me.Controls.Add(Me.lblPortfolioPercentageChangeValue)
        Me.Controls.Add(Me.lblPortfolioValueData)
        Me.Controls.Add(Me.lblPortfolioPercentageChange)
        Me.Controls.Add(Me.lblPortfolioProfitLoss)
        Me.Controls.Add(Me.lblPortfolioValue)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(1143, 930)
        CType(Me.BSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvestor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPortfolioValue As Label
    Friend WithEvents lblPortfolioProfitLoss As Label
    Friend WithEvents lblPortfolioPercentageChange As Label
    Friend WithEvents lblPortfolioValueData As Label
    Friend WithEvents lblPortfolioPercentageChangeValue As Label
    Friend WithEvents lblPortfolioProfitLossValue As Label
    Friend WithEvents BSUser As BindingSource
    Friend WithEvents BSInvestor As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents InvestorTableAdapter As DSTableAdapters.InvestorTableAdapter
    Friend WithEvents UserTableAdapter As DSTableAdapters.UserTableAdapter
    Friend WithEvents btnSelect As RoundedButton
    Friend WithEvents btnWithdraw As RoundedButton
    Friend WithEvents btnTopUp As RoundedButton
End Class
