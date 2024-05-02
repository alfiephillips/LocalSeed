<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvestorDashboardControl
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
        Me.lBoxCurrentInvestments = New System.Windows.Forms.ListBox()
        Me.btnNextTransaction = New System.Windows.Forms.Button()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.btnBackTransaction = New System.Windows.Forms.Button()
        Me.btnRemoveInvestment = New System.Windows.Forms.Button()
        Me.btnTopUp = New LocalSeed.RoundedButton()
        Me.btnWithdraw = New LocalSeed.RoundedButton()
        Me.btnSelect = New LocalSeed.RoundedButton()
        Me.lblFundsValue = New System.Windows.Forms.Label()
        Me.lblFunds = New System.Windows.Forms.Label()
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
        Me.lblPortfolioPercentageChangeValue.Size = New System.Drawing.Size(65, 78)
        Me.lblPortfolioPercentageChangeValue.TabIndex = 17
        Me.lblPortfolioPercentageChangeValue.Text = "0"
        '
        'lblPortfolioProfitLossValue
        '
        Me.lblPortfolioProfitLossValue.AutoSize = True
        Me.lblPortfolioProfitLossValue.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortfolioProfitLossValue.ForeColor = System.Drawing.Color.White
        Me.lblPortfolioProfitLossValue.Location = New System.Drawing.Point(811, 62)
        Me.lblPortfolioProfitLossValue.Name = "lblPortfolioProfitLossValue"
        Me.lblPortfolioProfitLossValue.Size = New System.Drawing.Size(65, 78)
        Me.lblPortfolioProfitLossValue.TabIndex = 18
        Me.lblPortfolioProfitLossValue.Text = "0"
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
        'lBoxCurrentInvestments
        '
        Me.lBoxCurrentInvestments.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lBoxCurrentInvestments.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoxCurrentInvestments.ForeColor = System.Drawing.Color.White
        Me.lBoxCurrentInvestments.FormattingEnabled = True
        Me.lBoxCurrentInvestments.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lBoxCurrentInvestments.ItemHeight = 23
        Me.lBoxCurrentInvestments.Items.AddRange(New Object() {"                                              "})
        Me.lBoxCurrentInvestments.Location = New System.Drawing.Point(306, 289)
        Me.lBoxCurrentInvestments.Name = "lBoxCurrentInvestments"
        Me.lBoxCurrentInvestments.ScrollAlwaysVisible = True
        Me.lBoxCurrentInvestments.Size = New System.Drawing.Size(607, 418)
        Me.lBoxCurrentInvestments.TabIndex = 22
        '
        'btnNextTransaction
        '
        Me.btnNextTransaction.Location = New System.Drawing.Point(804, 714)
        Me.btnNextTransaction.Name = "btnNextTransaction"
        Me.btnNextTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnNextTransaction.TabIndex = 23
        Me.btnNextTransaction.Text = "Next"
        Me.btnNextTransaction.UseVisualStyleBackColor = True
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(3, 289)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(291, 78)
        Me.lblLoading.TabIndex = 24
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.Visible = False
        '
        'btnBackTransaction
        '
        Me.btnBackTransaction.Location = New System.Drawing.Point(723, 714)
        Me.btnBackTransaction.Name = "btnBackTransaction"
        Me.btnBackTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnBackTransaction.TabIndex = 25
        Me.btnBackTransaction.Text = "Back"
        Me.btnBackTransaction.UseVisualStyleBackColor = True
        Me.btnBackTransaction.Visible = False
        '
        'btnRemoveInvestment
        '
        Me.btnRemoveInvestment.Location = New System.Drawing.Point(642, 714)
        Me.btnRemoveInvestment.Name = "btnRemoveInvestment"
        Me.btnRemoveInvestment.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveInvestment.TabIndex = 26
        Me.btnRemoveInvestment.Text = "Remove"
        Me.btnRemoveInvestment.UseVisualStyleBackColor = True
        '
        'btnTopUp
        '
        Me.btnTopUp.BackColor = System.Drawing.Color.White
        Me.btnTopUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopUp.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTopUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnTopUp.Location = New System.Drawing.Point(824, 165)
        Me.btnTopUp.Name = "btnTopUp"
        Me.btnTopUp.Size = New System.Drawing.Size(160, 65)
        Me.btnTopUp.TabIndex = 21
        Me.btnTopUp.Text = "Top Up"
        Me.btnTopUp.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(102, Byte), Integer))
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
        'lblFundsValue
        '
        Me.lblFundsValue.AutoSize = True
        Me.lblFundsValue.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFundsValue.ForeColor = System.Drawing.Color.White
        Me.lblFundsValue.Location = New System.Drawing.Point(3, 822)
        Me.lblFundsValue.Name = "lblFundsValue"
        Me.lblFundsValue.Size = New System.Drawing.Size(242, 78)
        Me.lblFundsValue.TabIndex = 27
        Me.lblFundsValue.Text = "$10,232"
        '
        'lblFunds
        '
        Me.lblFunds.AutoSize = True
        Me.lblFunds.BackColor = System.Drawing.Color.Transparent
        Me.lblFunds.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFunds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblFunds.Location = New System.Drawing.Point(13, 796)
        Me.lblFunds.Name = "lblFunds"
        Me.lblFunds.Size = New System.Drawing.Size(40, 18)
        Me.lblFunds.TabIndex = 28
        Me.lblFunds.Text = "Funds"
        '
        'InvestorDashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Controls.Add(Me.lblFunds)
        Me.Controls.Add(Me.lblFundsValue)
        Me.Controls.Add(Me.btnRemoveInvestment)
        Me.Controls.Add(Me.btnBackTransaction)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.btnNextTransaction)
        Me.Controls.Add(Me.lBoxCurrentInvestments)
        Me.Controls.Add(Me.btnTopUp)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblPortfolioProfitLossValue)
        Me.Controls.Add(Me.lblPortfolioPercentageChangeValue)
        Me.Controls.Add(Me.lblPortfolioValueData)
        Me.Controls.Add(Me.lblPortfolioPercentageChange)
        Me.Controls.Add(Me.lblPortfolioProfitLoss)
        Me.Controls.Add(Me.lblPortfolioValue)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "InvestorDashboardControl"
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
    Friend WithEvents lBoxCurrentInvestments As ListBox
    Friend WithEvents btnNextTransaction As Button
    Friend WithEvents lblLoading As Label
    Friend WithEvents btnBackTransaction As Button
    Friend WithEvents btnRemoveInvestment As Button
    Friend WithEvents lblFundsValue As Label
    Friend WithEvents lblFunds As Label
End Class
