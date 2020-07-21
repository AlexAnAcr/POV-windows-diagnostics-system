Public Class Progress1
    Dim number As UShort = 0
    Private Sub load_element() Handles MyBase.Load
        Dim image As New Bitmap(100, 30, Imaging.PixelFormat.Format32bppArgb)
        Dim gr As Graphics = Graphics.FromImage(image)
        gr.FillRectangle(Brushes.LightSteelBlue, 0, 0, 100, 30)
        PictureBox1.Image = image
    End Sub
    Public Property Value As UShort
        Get
            Return number
        End Get
        Set(ByVal value As UShort)
            If value <= 100 Then
                number = value
                Dim image As New Bitmap(100, 30, Imaging.PixelFormat.Format32bppArgb)
                Dim gr As Graphics = Graphics.FromImage(image)
                gr.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                gr.FillRectangle(Brushes.LightSteelBlue, 0, 0, 100, 30)
                Dim br As New SolidBrush(Color.SteelBlue)
                gr.FillRectangle(br, 0, 0, CInt(number), 30)
                PictureBox1.Image = image
            End If
        End Set
    End Property
End Class
