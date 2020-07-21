Public Class Results
    Dim pos As Point, page As Short = 0, del_prob(1) As Short
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        pos.X = e.X
        pos.Y = e.Y
    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left = Me.Left + e.X - pos.X
            Me.Top = Me.Top + e.Y - pos.Y
        End If
    End Sub
    Private Sub Results_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        p2_ListBox2.SelectedIndex = 0
        time_pos = 0
        m1_Progress.Value = 0
    End Sub
    Private Sub p2_ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles p2_ListBox2.SelectedIndexChanged
        If p2_ListBox2.SelectedIndex = 0 And page = 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If p1_RadioButton2.Checked Then
            Main.stage = 8
            Main.Timer1.Start()
            Main.Button1.Enabled = True
            Main.Label3.Text = "Выполнено: 0%"
            Me.Close()
        Else
            If page = 0 Then
                page = 1
                p1_Text1.Visible = False
                p1_RadioButton1.Visible = False
                p1_RadioButton2.Visible = False
                m1_Progress.Visible = True
                m1_Text1.Visible = True
                num_dat(0) = -1
                num_dat(1) = -1
                num_dat(2) = -1
                num_dat(3) = -1
                Set_Prog_Pos.Start()
                Button1.Text = "Исправить"
                Button1.Enabled = False
                Main.Label4.Text = "Статус: исправление..."
            ElseIf page = 1 Then
                Dim time_dat As DialogResult = Del_probs.ShowDialog()
                If time_dat = DialogResult.OK Then
                    del_prob(0) += 1
                    p2_Text4.Text = "Исправлено проблем: " & del_prob(0)
                    p2_ListBox1.Items.RemoveAt(p2_ListBox1.SelectedIndex)
                    p2_ListBox2.Items.Clear()
                    p2_ListBox2.Items.Add("NONE")
                    p2_ListBox2.SelectedIndex = 0
                    If del_prob(0) = del_prob(1) Then
                        Main.stage = 9
                        Main.Timer1.Start()
                        Main.Button1.Enabled = True
                        Main.Label3.Text = "Выполнено: 0%"
                        Me.Close()
                    End If
                Else
                    p2_ListBox2.SelectedIndex = 0
                End If
            End If
        End If
    End Sub
    Private Sub p2_ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles p2_ListBox1.SelectedIndexChanged
        Dim text_dat As String = Mid(p2_ListBox1.SelectedItem, 1, 2)
        p2_ListBox2.Items.Clear()
        If text_dat = "E1" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезервировать потоки ещё раз")
            p2_ListBox2.Items.Add("Зарезервировать программе текущее кол-во потоков (не всегда верно)")
            p2_ListBox2.Items.Add("Зарезервировать потоки по итогам тестирования (иногда долго)")
            p2_ListBox2.Items.Add("Зарезервировать среднее между зарезервированым и текущим (не всегда верно)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E2" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезегистрироваться в библиотеке CDO ещё раз")
            p2_ListBox2.Items.Add("Зарегистрировать программу в библиотеке CDO самостоятельно")
            p2_ListBox2.Items.Add("Зарегистрировать программу в библиотеке CDO по итогам тестирования (долго, не всегда работает)")
            p2_ListBox2.Items.Add("Исключить из регистрации в библиотеке CDO (не самое лучшее решение)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E3" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезервировать память ещё раз")
            p2_ListBox2.Items.Add("Зарезервировать программе текущий объём памяти (не всегда верно)")
            p2_ListBox2.Items.Add("Зарезервировать объём памяти по итогам тестирования (иногда долго)")
            p2_ListBox2.Items.Add("Зарезервировать среднее между зарезервированым и текущим (не всегда верно)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E4" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезегистрироваться в библиотеке CDO ещё раз")
            p2_ListBox2.Items.Add("Исключить из регистрации в библиотеке CDO (одно из лучших решений)")
            p2_ListBox2.Items.Add("Изменить параметры совместимости с библиотекой CDO (одно из лучших решений)")
            p2_ListBox2.Items.Add("Обновить данные библиотеки CDO о данной программе (не всегда работает)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E5" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить регистрацию компонентов программе ещё раз")
            p2_ListBox2.Items.Add("Самостоятельно зарегистрировать компоненты программы (долго, не всегда работает)")
            p2_ListBox2.Items.Add("Зарегистрировать компоненты программы по итогам тестирования (иногда долго)")
            p2_ListBox2.Items.Add("Обновить сведения о данной программе (редео помогает)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E6" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Ограничить кол-во перезапусков для программы")
            p2_ListBox2.Items.Add("Разрешать перезапуск при наличии свободной памяти")
            p2_ListBox2.Items.Add("Зарезервировать программе объём памяти при перезапуске (другие программы могут работать медленнее)")
            p2_ListBox2.Items.Add("Запрещать перезапуски (не всегда верно)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E7" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезервировать память ещё раз")
            p2_ListBox2.Items.Add("Зарезервировать программе текущий объём памяти (другие программы могут работать медленнее, не всегда верно)")
            p2_ListBox2.Items.Add("Зарезервировать объём памяти по итогам тестирования (иногда долго)")
            p2_ListBox2.Items.Add("Ограничить память для данной программы, когда есть риск подвисания (программа может подтормаживать, не всегда верно)")
            p2_ListBox2.SelectedIndex = 0
        ElseIf text_dat = "E8" Then
            p2_ListBox2.Items.Add("NONE")
            p2_ListBox2.Items.Add("Предоставить программе зарезервировать потоки ещё раз")
            p2_ListBox2.Items.Add("Зарезервировать программе текущее кол-во потоков (не всегда верно)")
            p2_ListBox2.Items.Add("Зарезервировать потоки по итогам тестирования (иногда долго)")
            p2_ListBox2.Items.Add("Зарезервировать программе минимальное кол-во потоков (1)")
            p2_ListBox2.SelectedIndex = 0
        End If
    End Sub
    Dim time_pos, pos_in(Main.progs.Length - 1) As Short, num_dat(3) As Short
    Private Sub Set_Prog_Pos_Tick(sender As Object, e As EventArgs) Handles Set_Prog_Pos.Tick
        If time_pos = Main.progs.Length Then
            del_prob(1) = p2_ListBox1.Items.Count
            p2_Text3.Text = "Обнаружено проблем: " & del_prob(1)
            m1_Progress.Visible = False
            m1_Text1.Visible = False
            p2_Text1.Visible = True
            p2_Text2.Visible = True
            p2_Text3.Visible = True
            p2_Text4.Visible = True
            p2_ListBox1.Visible = True
            p2_ListBox2.Visible = True
            Set_Prog_Pos.Stop()
        Else
            Dim r As New Random, r_dat As Short = -1
            r_dat = r.Next(10)
            While r_dat = num_dat(0) Or r_dat = num_dat(1) Or r_dat = num_dat(2) Or r_dat = num_dat(3)
                r_dat = r.Next(10)
            End While
            Select Case r_dat
                Case 0
                    p2_ListBox1.Items.Add("E1 --Зарезервировано неверное кол-во потоков-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 1
                    p2_ListBox1.Items.Add("E2 --Программа не зарегистрирована в библиотеке CDO-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 2
                    p2_ListBox1.Items.Add("E3 --Программа резервирует больше памяти, чем использует-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 3
                    p2_ListBox1.Items.Add("E4 --Несовместима с библиотекой CDO-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 4
                    p2_ListBox1.Items.Add("E5 --Программа имеет незарегистрированные компоненты-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 5
                    p2_ListBox1.Items.Add("E6 --Программа затормаживает компьютер из-за перезапусков-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 6
                    p2_ListBox1.Items.Add("E7 --Программа затормаживает компьютер - недостаточно памяти-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
                Case 7
                    p2_ListBox1.Items.Add("E8 --Программа не резервирует потоки (минимум - 1)-- (" & My.Computer.FileSystem.GetDirectoryInfo(Main.progs(time_pos)).Name & ")")
            End Select
            num_dat(pos_in(time_pos)) = r_dat
            pos_in(time_pos) += 1
            Dim r1 As New Random
            If pos_in(time_pos) = 3 Then
                time_pos += 1
                num_dat(0) = -1
                num_dat(1) = -1
                num_dat(2) = -1
                num_dat(3) = -1
            ElseIf r.Next(7) <> 4 Then
                time_pos += 1
                num_dat(0) = -1
                num_dat(1) = -1
                num_dat(2) = -1
                num_dat(3) = -1
            End If
            If Main.progs_num(1) = 0 Then
                If m1_Progress.Value + Main.progs_num(0) < 100 Then
                    m1_Progress.Value += Main.progs_num(0)
                Else
                    m1_Progress.Value = 100
                End If
            Else
                If Math.IEEERemainder(time_pos, Main.progs_num(0)) = 0 Then
                    If m1_Progress.Value + 1 < 100 Then
                        m1_Progress.Value += 1
                    Else
                        m1_Progress.Value = 100
                    End If
                End If
            End If
        End If
    End Sub
End Class