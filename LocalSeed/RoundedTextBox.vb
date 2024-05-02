Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedTextBox
    Inherits Control

    Private _backgroundColor As Color = Color.Green
    Private _textColor As Color = Color.White

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Smooth out the edges of the drawn graphics
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Create a path that consists of a rounded rectangle
        Dim path As New GraphicsPath()
        Dim radius As Integer = 20 ' Radius for the corners
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(Width - radius - 1, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(Width - radius - 1, Height - radius - 1, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, Height - radius - 1, radius, radius), 90, 90)
        path.CloseFigure()

        ' Fill the rounded rectangle with a green background
        e.Graphics.FillPath(New SolidBrush(_backgroundColor), path)

        ' Set up text formatting
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center

        ' Draw the text
        e.Graphics.DrawString(Text, Font, New SolidBrush(_textColor), New RectangleF(0, 0, Width, Height), format)
    End Sub

    ' Optional: Add properties to customize the background and text color
    Public Property BackgroundColor As Color
        Get
            Return _backgroundColor
        End Get
        Set(value As Color)
            _backgroundColor = value
            Invalidate() ' Cause the control to be redrawn
        End Set
    End Property

    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Invalidate() ' Cause the control to be redrawn
        End Set
    End Property
End Class
