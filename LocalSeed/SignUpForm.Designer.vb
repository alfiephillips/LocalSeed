<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpForm
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

    Private Function CreateRoundedTextBox(ByVal x As Integer, ByVal y As Integer) As Panel
        ' Create the panel that will serve as the background
        Dim pnlRounded As New Panel With {
        .Location = New Point(x, y),
        .Size = New Size(200, 30),
        .BackColor = Me.BackColor ' Set the background color to match the form's background
    }

        ' Create the TextBox
        Dim txtBox As New TextBox With {
        .BorderStyle = BorderStyle.None,
        .Location = New Point(5, 5), ' Position inside the panel
        .Width = pnlRounded.Width - 10
    }

        ' Add the TextBox to the panel
        pnlRounded.Controls.Add(txtBox)

        ' Set the panel's border to appear rounded
        pnlRounded.Region = New Region(New Rectangle(2, 2, pnlRounded.Width - 4, pnlRounded.Height - 4))
        pnlRounded.Paint += Sub(sender As Object, e As PaintEventArgs)
                                ' Draw a border around the panel
                                e.Graphics.DrawRectangle(New Pen(Color.Gray), New Rectangle(1, 1, pnlRounded.Width - 3, pnlRounded.Height - 3))
                            End Sub

        Return pnlRounded
    End Function

    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form properties
        Me.Size = New Size(800, 450)
        Me.Text = "Sign Up"
        Me.BackColor = Color.White

        ' Create left panel
        Dim pnlLeft As New Panel With {
            .Size = New Size(Me.Width \ 2, Me.Height),
            .Location = New Point(0, 0),
            .BackColor = Color.Black
        }

        ' Create right panel
        Dim pnlRight As New Panel With {
            .Size = New Size(Me.Width \ 2, Me.Height),
            .Location = New Point(Me.Width \ 2, 0),
            .BackColor = Color.White
        }

        ' Company name and logo
        Dim lblCompanyName As New Label With {
            .Text = "LOCALSEED",
            .ForeColor = Color.Green,
            .Font = New Font("Arial", 18, FontStyle.Bold),
            .Location = New Point(20, 20),
            .AutoSize = True
        }

        pnlLeft.Controls.Add(lblCompanyName)

        ' Create account label
        Dim lblCreateAccount As New Label With {
            .Text = "Create an account",
            .ForeColor = Color.Green,
            .Font = New Font("Arial", 16, FontStyle.Bold),
            .Location = New Point(20, 70),
            .AutoSize = True
        }

        pnlLeft.Controls.Add(lblCreateAccount)

        ' Text boxes
        Dim txtName As New TextBox With {
            .Size = New Size(200, 30),
            .Location = New Point(20, 120)
        }
        Dim txtEmail As New TextBox With {
            .Size = New Size(200, 30),
            .Location = New Point(20, 160)
        }
        Dim txtPassword As New TextBox With {
            .Size = New Size(200, 30),
            .Location = New Point(20, 200)
        }

        ' Add text boxes to left panel
        pnlLeft.Controls.Add(txtName)
        pnlLeft.Controls.Add(txtEmail)
        pnlLeft.Controls.Add(txtPassword)

        ' Sign up button
        Dim btnSignUp As New Button With {
            .Text = "Sign Up",
            .Size = New Size(200, 40),
            .Location = New Point(20, 240),
            .BackColor = Color.Green,
            .FlatStyle = FlatStyle.Flat
        }
        pnlLeft.Controls.Add(btnSignUp)

        ' Login link
        Dim lnkLogin As New LinkLabel With {
            .Text = "Already have an account? Log in",
            .ForeColor = Color.White,
            .Location = New Point(20, 290),
            .AutoSize = True
        }
        pnlLeft.Controls.Add(lnkLogin)

        ' Adding panels to form
        Me.Controls.Add(pnlLeft)
        Me.Controls.Add(pnlRight)
    End Sub

    Public Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
    End Sub

End Class
