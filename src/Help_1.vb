Public Class Help_1
    Private Sub Help_1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Left = MousePosition.X - 10
        Me.Top = MousePosition.Y - 10
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MousePosition.X < Me.Left Or MousePosition.Y < Me.Top Or MousePosition.X > Me.Left + Me.Width Or MousePosition.Y > Me.Top + Me.Height Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub
End Class