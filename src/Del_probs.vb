Public Class Del_probs
    Dim pos As Point, error_verouate As Short = 0, mode As Short = 0
    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        pos.X = e.X
        pos.Y = e.Y
    End Sub
    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left = Me.Left + e.X - pos.X
            Me.Top = Me.Top + e.Y - pos.Y
        End If
    End Sub
    Private Sub Del_probs_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Progress11.Value = 0
        Button1.Enabled = True
        error_verouate = 0
        mode = 0
        Label1.Text = "Исправление:"
        Dim text_dat As String = Mid(Results.p2_ListBox1.SelectedItem, 1, 2), r As New Random
        If text_dat = "E1" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 7
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 4
                Timer1.Interval = r.Next(10, 60) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 1
                Timer1.Interval = r.Next(5, 7) * 100
            End If
        ElseIf text_dat = "E2" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 7
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 6
                Timer1.Interval = r.Next(10, 60) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 4
                Timer1.Interval = r.Next(5, 7) * 100
            End If
        ElseIf text_dat = "E3" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 7
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 5
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 8
                Timer1.Interval = r.Next(8, 24) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 7) * 100
            End If
        ElseIf text_dat = "E4" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 7
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 2
                Timer1.Interval = r.Next(8, 24) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 1
                Timer1.Interval = r.Next(8, 14) * 100
            End If
        ElseIf text_dat = "E5" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 4
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 0
                Timer1.Interval = r.Next(10, 60) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 6
                Timer1.Interval = r.Next(8, 24) * 100
            End If
        ElseIf text_dat = "E6" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 4
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 6
                Timer1.Interval = r.Next(8, 24) * 100
            End If
        ElseIf text_dat = "E7" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 8
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 0
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 6
                Timer1.Interval = r.Next(10, 60) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 4
                Timer1.Interval = r.Next(8, 24) * 100
            End If
        ElseIf text_dat = "E8" Then
            If Results.p2_ListBox2.SelectedIndex = 1 Then
                error_verouate = 8
                Timer1.Interval = r.Next(5, 18) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 2 Then
                error_verouate = 1
                Timer1.Interval = r.Next(5, 7) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 3 Then
                error_verouate = 1
                Timer1.Interval = r.Next(10, 60) * 100
            ElseIf Results.p2_ListBox2.SelectedIndex = 4 Then
                error_verouate = 0
                Timer1.Interval = r.Next(8, 24) * 100
            End If
        End If
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mode = 0 Then
            If Progress11.Value = 99 Then
                Timer1.Stop()
                My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                If error_verouate = 8 Then
                    Dim r As New Random
                    If r.Next(10) = 5 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 7 Then
                    Dim r As New Random
                    If r.Next(20) = 10 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 6 Then
                    Dim r As New Random
                    If r.Next(30) = 15 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 5 Then
                    Dim r As New Random
                    If r.Next(40) = 20 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 4 Then
                    Dim r As New Random
                    If r.Next(50) = 25 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 3 Then
                    Dim r As New Random
                    If r.Next(60) = 30 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 2 Then
                    Dim r As New Random
                    If r.Next(70) = 35 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                ElseIf error_verouate = 1 Then
                    Dim r As New Random
                    If r.Next(80) = 40 Then
                        Timer1.Stop()
                        My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                        MsgBox("Во время исправления неполадки произошла ошибка. Попробуйте другой метод исправления.",, "Ошибка")
                        Me.DialogResult = DialogResult.Cancel
                        Me.Close()
                    End If
                End If
                Progress11.Value += 1
            End If
        Else
            If Progress11.Value = 99 Then
                My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
                Timer1.Stop()
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
            Else
                Progress11.Value += 1
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Progress11.Value = 0
        mode = 1
        Timer1.Interval = 500
        Label1.Text = "Отмена..."
        Button1.Enabled = False
    End Sub
End Class
