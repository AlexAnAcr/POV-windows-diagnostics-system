Public Class Main
    Public progs() As String, progs_num(1) As Integer, stage As Short
    Dim num As Short
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stage = 0 Then
            If num <= progs.Length * 2 Then
                Label4.Text = "Статус: подготовка..."
                Label3.Text = "Выполнено: --"
                num += 1
            Else
                num = 0
                stage = 1
            End If
        ElseIf stage = 1 Then
            If num <= progs.Length * 4 Then
                Label4.Text = "Статус: сбор данных..."
                If progs_num(1) = 0 Then
                    If Math.IEEERemainder(num, 4) = 0 Then
                        If Progress11.Value + progs_num(0) < 100 Then
                            Progress11.Value += progs_num(0)
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                Else
                    If Math.IEEERemainder(num, progs_num(0) * 4) = 0 Then
                        If Progress11.Value + 1 < 100 Then
                            Progress11.Value += 1
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                End If
                num += 1
                Label3.Text = "Выполнено: " & Progress11.Value & "%"
            Else
                Progress11.Value = 0
                num = 0
                stage = 2
            End If
        ElseIf stage = 2 Then
            If num <= progs.Length * 36 Then
                Label4.Text = "Статус: работает..."
                If progs_num(1) = 0 Then
                    If Math.IEEERemainder(num, 18) = 0 Then
                        If Progress11.Value + progs_num(0) < 100 Then
                            Progress11.Value += progs_num(0)
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                Else
                    If Math.IEEERemainder(num, progs_num(0) * 18) = 0 Then
                        If Progress11.Value + 1 < 100 Then
                            Progress11.Value += 1
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                End If
                num += 1
                Label3.Text = "Выполнено: " & Progress11.Value & "%"
            Else
                Progress11.Value = 0
                num = 0
                stage = 3
            End If
        ElseIf stage = 3 Then
            If num <= progs.Length * 8 Then
                Label4.Text = "Статус: сбор данных об ошибках..."
                If progs_num(1) = 0 Then
                    If Math.IEEERemainder(num, 8) = 0 Then
                        If Progress11.Value + progs_num(0) < 100 Then
                            Progress11.Value += progs_num(0)
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                Else
                    If Math.IEEERemainder(num, progs_num(0) * 8) = 0 Then
                        If Progress11.Value + 1 < 100 Then
                            Progress11.Value += 1
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                End If
                num += 1
                Label3.Text = "Выполнено: " & Progress11.Value & "%"
            Else
                Progress11.Value = 0
                num = 0
                stage = 4
            End If
        ElseIf stage = 4 Then
            If num <= progs.Length * 4 Then
                Label4.Text = "Статус: обработка данных об ошибках..."
                If progs_num(1) = 0 Then
                    If Math.IEEERemainder(num, 4) = 0 Then
                        If Progress11.Value + progs_num(0) < 100 Then
                            Progress11.Value += progs_num(0)
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                Else
                    If Math.IEEERemainder(num, progs_num(0) * 4) = 0 Then
                        If Progress11.Value + 1 < 100 Then
                            Progress11.Value += 1
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                End If
                num += 1
                Label3.Text = "Выполнено: " & Progress11.Value & "%"
            Else
                Progress11.Value = 0
                num = 0
                stage = 5
            End If
        ElseIf stage = 5 Then
            If num <= progs.Length * 4 Then
                Label5.Text = "Стадия: 1.5/2"
                Label4.Text = "Статус: подготовка ко 2 стадии..."
                If progs_num(1) = 0 Then
                    If Math.IEEERemainder(num, 4) = 0 Then
                        If Progress11.Value + progs_num(0) < 100 Then
                            Progress11.Value += progs_num(0)
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                Else
                    If Math.IEEERemainder(num, progs_num(0) * 4) = 0 Then
                        If Progress11.Value + 1 < 100 Then
                            Progress11.Value += 1
                        Else
                            Progress11.Value = 100
                        End If
                    End If
                End If
                num += 1
                Label3.Text = "Выполнено: " & Progress11.Value & "%"
            Else
                Progress11.Value = 0
                num = 0
                stage = 7
            End If
        ElseIf stage = 7 Then
			Dim r As New Random
			If r.Next(50) = 49 Then
				Label1.Text = "Неполадок не найдено."
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: завершено..."
				Progress11.Value = 100
				Timer1.Stop()
				Me.Close()
			Else
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: настройка..."
				Label3.Text = "Выполнено: --"
				Label1.Text = "Идёт исправление ошибок..."
				Timer1.Stop()
				Button1.Enabled = False
				Results.Show()
				My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
			End If
		ElseIf stage = 8 Then
			If num <= progs.Length * 144 Then
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: работает..."
				If progs_num(1) = 0 Then
					If Math.IEEERemainder(num, 144) = 0 Then
						If Progress11.Value + progs_num(0) < 100 Then
							Progress11.Value += progs_num(0)
						Else
							Progress11.Value = 100
						End If
					End If
				Else
					If Math.IEEERemainder(num, progs_num(0) * 144) = 0 Then
						If Progress11.Value + 1 < 100 Then
							Progress11.Value += 1
						Else
							Progress11.Value = 100
						End If
					End If
				End If
				num += 1
				Label3.Text = "Выполнено: " & Progress11.Value & "%"
			Else
				Label1.Text = "Неполадки исправлены."
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: завершено..."
				Progress11.Value = 100
				Timer1.Stop()
				My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
				MsgBox("Сканирование и исправление ошибок успешно завершены!", MsgBoxStyle.OkOnly, "Сообщение")
				Me.Close()
			End If
		ElseIf stage = 9 Then
			If num <= progs.Length * 4 Then
				Label1.Text = "Ошибки исправлены."
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: создание отчёта..."
				If progs_num(1) = 0 Then
					If Math.IEEERemainder(num, 4) = 0 Then
						If Progress11.Value + progs_num(0) < 100 Then
							Progress11.Value += progs_num(0)
						Else
							Progress11.Value = 100
						End If
					End If
				Else
					If Math.IEEERemainder(num, progs_num(0) * 4) = 0 Then
						If Progress11.Value + 1 < 100 Then
							Progress11.Value += 1
						Else
							Progress11.Value = 100
						End If
					End If
				End If
				num += 1
				Label3.Text = "Выполнено: " & Progress11.Value & "%"
			Else
				Label1.Text = "Готово!"
				Label5.Text = "Стадия: 2/2"
				Label4.Text = "Статус: завершено..."
				Progress11.Value = 100
				Timer1.Stop()
				My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
				MsgBox("Сканирование и исправление ошибок успешно завершены!", MsgBoxStyle.OkOnly, "Сообщение")
				Me.Close()
			End If
		ElseIf stage = 6 Then
			If num <= progs.Length * 8 Then
				Label5.Text = "Стадия: --"
				Label4.Text = "Статус: удаление данных сканирования..."
				If progs_num(1) = 0 Then
					If Math.IEEERemainder(num, 8) = 0 Then
						If Progress11.Value + progs_num(0) < 100 Then
							Progress11.Value += progs_num(0)
						Else
							Progress11.Value = 100
						End If
					End If
				Else
					If Math.IEEERemainder(num, progs_num(0) * 8) = 0 Then
						If Progress11.Value + 1 < 100 Then
							Progress11.Value += 1
						Else
							Progress11.Value = 100
						End If
					End If
				End If
				num += 1
				Label3.Text = "Выполнено: " & Progress11.Value & "%"
			Else
				Progress11.Value = 100
				Timer1.Stop()
				My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
				MsgBox("Сканирование и исправление ошибок отменены!", MsgBoxStyle.OkOnly, "Сообщение")
				Me.Close()
			End If
		End If
	End Sub
	Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
		progs = IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "*", IO.SearchOption.TopDirectoryOnly)
		Progress11.Value = 0
		stage = 0
		num = 0
		If progs.Length < 100 Then
			progs_num(0) = Math.Round(100 / progs.Length)
			progs_num(1) = 0
		Else
			progs_num(0) = Math.Round(progs.Length / 100)
			progs_num(1) = 1
		End If
		Timer1.Start()
		My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Help_1.Show()
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		My.Computer.Audio.Play(My.Resources.JScWin8_1, AudioPlayMode.Background)
		Dim result As MsgBoxResult = MsgBox("Вы уверены, что хотите прервать данное сканирование?" & Chr(10) & "Такое сканирование производится всего 1 раз в год. Оно помогает исправлять проблемы несовместимости и неполадки работы программ. Сканирования такого типа могут решать проблемы от лёгкого подвисания до серьёзных сбоев." & Chr(10) & "--Мы не рекомендуем вам отменять данное сканирование.--", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Отмена сканирования")
		If result = MsgBoxResult.Yes Then
			Button1.Enabled = False
			Progress11.Value = 0
			Label3.Text = "Выполнено: 0%"
			stage = 6
		End If
	End Sub
	Protected Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim cp As CreateParams = MyBase.CreateParams
			Const CS_DBLCLKS As Int32 = &H8
			Const CS_NOCLOSE As Int32 = &H200
			cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
			Return cp
		End Get
    End Property
End Class
