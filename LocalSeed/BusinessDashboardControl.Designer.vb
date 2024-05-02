<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bDControl
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
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lBoxCurrentListings = New System.Windows.Forms.ListBox()
        Me.lblAmountListingsData = New System.Windows.Forms.Label()
        Me.lblAmountListings = New System.Windows.Forms.Label()
        Me.btnCreateListing = New LocalSeed.RoundedButton()
        Me.btnBackListing = New System.Windows.Forms.Button()
        Me.btnNextListing = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(42, 446)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(442, 117)
        Me.lblLoading.TabIndex = 40
        Me.lblLoading.Text = "Loading..."
        Me.lblLoading.Visible = False
        '
        'lBoxCurrentListings
        '
        Me.lBoxCurrentListings.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lBoxCurrentListings.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBoxCurrentListings.ForeColor = System.Drawing.Color.White
        Me.lBoxCurrentListings.FormattingEnabled = True
        Me.lBoxCurrentListings.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lBoxCurrentListings.ItemHeight = 36
        Me.lBoxCurrentListings.Items.AddRange(New Object() {"                                              "})
        Me.lBoxCurrentListings.Location = New System.Drawing.Point(497, 446)
        Me.lBoxCurrentListings.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lBoxCurrentListings.Name = "lBoxCurrentListings"
        Me.lBoxCurrentListings.ScrollAlwaysVisible = True
        Me.lBoxCurrentListings.Size = New System.Drawing.Size(908, 652)
        Me.lBoxCurrentListings.TabIndex = 38
        '
        'lblAmountListingsData
        '
        Me.lblAmountListingsData.AutoSize = True
        Me.lblAmountListingsData.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountListingsData.ForeColor = System.Drawing.Color.White
        Me.lblAmountListingsData.Location = New System.Drawing.Point(98, 96)
        Me.lblAmountListingsData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountListingsData.Name = "lblAmountListingsData"
        Me.lblAmountListingsData.Size = New System.Drawing.Size(99, 117)
        Me.lblAmountListingsData.TabIndex = 32
        Me.lblAmountListingsData.Text = "0"
        '
        'lblAmountListings
        '
        Me.lblAmountListings.AutoSize = True
        Me.lblAmountListings.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountListings.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountListings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblAmountListings.Location = New System.Drawing.Point(113, 47)
        Me.lblAmountListings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountListings.Name = "lblAmountListings"
        Me.lblAmountListings.Size = New System.Drawing.Size(205, 29)
        Me.lblAmountListings.TabIndex = 29
        Me.lblAmountListings.Text = "Your number of listings"
        '
        'btnCreateListing
        '
        Me.btnCreateListing.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCreateListing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateListing.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateListing.ForeColor = System.Drawing.Color.White
        Me.btnCreateListing.Location = New System.Drawing.Point(118, 255)
        Me.btnCreateListing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreateListing.Name = "btnCreateListing"
        Me.btnCreateListing.Size = New System.Drawing.Size(240, 100)
        Me.btnCreateListing.TabIndex = 35
        Me.btnCreateListing.Text = "Create a new listing"
        Me.btnCreateListing.UseVisualStyleBackColor = False
        '
        'btnBackListing
        '
        Me.btnBackListing.Location = New System.Drawing.Point(1173, 1108)
        Me.btnBackListing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBackListing.Name = "btnBackListing"
        Me.btnBackListing.Size = New System.Drawing.Size(112, 35)
        Me.btnBackListing.TabIndex = 43
        Me.btnBackListing.Text = "Back"
        Me.btnBackListing.UseVisualStyleBackColor = True
        Me.btnBackListing.Visible = False
        '
        'btnNextListing
        '
        Me.btnNextListing.Location = New System.Drawing.Point(1293, 1108)
        Me.btnNextListing.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNextListing.Name = "btnNextListing"
        Me.btnNextListing.Size = New System.Drawing.Size(112, 35)
        Me.btnNextListing.TabIndex = 44
        Me.btnNextListing.Text = "Next"
        Me.btnNextListing.UseVisualStyleBackColor = True
        '
        'bDControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Controls.Add(Me.btnNextListing)
        Me.Controls.Add(Me.btnBackListing)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.lBoxCurrentListings)
        Me.Controls.Add(Me.btnCreateListing)
        Me.Controls.Add(Me.lblAmountListingsData)
        Me.Controls.Add(Me.lblAmountListings)
        Me.Name = "bDControl"
        Me.Size = New System.Drawing.Size(1714, 1431)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLoading As Label
    Friend WithEvents lBoxCurrentListings As ListBox
    Friend WithEvents btnCreateListing As RoundedButton
    Friend WithEvents lblAmountListingsData As Label
    Friend WithEvents lblAmountListings As Label
    Friend WithEvents btnBackListing As Button
    Friend WithEvents btnNextListing As Button
End Class
