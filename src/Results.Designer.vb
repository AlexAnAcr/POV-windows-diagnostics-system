<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Results))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p1_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.p1_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.p1_Text1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.p2_Text1 = New System.Windows.Forms.Label()
        Me.p2_ListBox1 = New System.Windows.Forms.ListBox()
        Me.p2_ListBox2 = New System.Windows.Forms.ListBox()
        Me.p2_Text2 = New System.Windows.Forms.Label()
        Me.Set_Prog_Pos = New System.Windows.Forms.Timer(Me.components)
        Me.m1_Text1 = New System.Windows.Forms.Label()
        Me.m1_Progress = New JProgTestWin8_1.Progress1()
        Me.p2_Text3 = New System.Windows.Forms.Label()
        Me.p2_Text4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 30)
        Me.Label1.TabIndex = 0
        '
        'p1_RadioButton2
        '
        Me.p1_RadioButton2.Location = New System.Drawing.Point(47, 197)
        Me.p1_RadioButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.p1_RadioButton2.Name = "p1_RadioButton2"
        Me.p1_RadioButton2.Size = New System.Drawing.Size(365, 49)
        Me.p1_RadioButton2.TabIndex = 1
        Me.p1_RadioButton2.Text = "Автоматическое исправление (рекомендовано ""новичкам"", работает намного медленнее " &
    "Пользовательского исправления)"
        Me.p1_RadioButton2.UseVisualStyleBackColor = True
        '
        'p1_RadioButton1
        '
        Me.p1_RadioButton1.Checked = True
        Me.p1_RadioButton1.Location = New System.Drawing.Point(47, 171)
        Me.p1_RadioButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.p1_RadioButton1.Name = "p1_RadioButton1"
        Me.p1_RadioButton1.Size = New System.Drawing.Size(263, 20)
        Me.p1_RadioButton1.TabIndex = 2
        Me.p1_RadioButton1.TabStop = True
        Me.p1_RadioButton1.Text = "Пользовательское исправление"
        Me.p1_RadioButton1.UseVisualStyleBackColor = True
        '
        'p1_Text1
        '
        Me.p1_Text1.Location = New System.Drawing.Point(12, 73)
        Me.p1_Text1.Name = "p1_Text1"
        Me.p1_Text1.Size = New System.Drawing.Size(472, 42)
        Me.p1_Text1.TabIndex = 3
        Me.p1_Text1.Text = "На вашем компьютере были найдены неполадки." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Выберите один из предложенных режимо" &
    "в решения найденых проблем."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(360, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Далее"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'p2_Text1
        '
        Me.p2_Text1.AutoSize = True
        Me.p2_Text1.Location = New System.Drawing.Point(15, 49)
        Me.p2_Text1.Name = "p2_Text1"
        Me.p2_Text1.Size = New System.Drawing.Size(79, 13)
        Me.p2_Text1.TabIndex = 6
        Me.p2_Text1.Text = "Проблема:"
        Me.p2_Text1.Visible = False
        '
        'p2_ListBox1
        '
        Me.p2_ListBox1.FormattingEnabled = True
        Me.p2_ListBox1.HorizontalScrollbar = True
        Me.p2_ListBox1.Location = New System.Drawing.Point(12, 70)
        Me.p2_ListBox1.Name = "p2_ListBox1"
        Me.p2_ListBox1.Size = New System.Drawing.Size(326, 277)
        Me.p2_ListBox1.TabIndex = 7
        Me.p2_ListBox1.Visible = False
        '
        'p2_ListBox2
        '
        Me.p2_ListBox2.FormattingEnabled = True
        Me.p2_ListBox2.HorizontalScrollbar = True
        Me.p2_ListBox2.Items.AddRange(New Object() {"NONE"})
        Me.p2_ListBox2.Location = New System.Drawing.Point(345, 70)
        Me.p2_ListBox2.Name = "p2_ListBox2"
        Me.p2_ListBox2.Size = New System.Drawing.Size(138, 277)
        Me.p2_ListBox2.TabIndex = 8
        Me.p2_ListBox2.Visible = False
        '
        'p2_Text2
        '
        Me.p2_Text2.Location = New System.Drawing.Point(344, 39)
        Me.p2_Text2.Name = "p2_Text2"
        Me.p2_Text2.Size = New System.Drawing.Size(126, 28)
        Me.p2_Text2.TabIndex = 9
        Me.p2_Text2.Text = "Метод устранения:"
        Me.p2_Text2.Visible = False
        '
        'Set_Prog_Pos
        '
        '
        'm1_Text1
        '
        Me.m1_Text1.AutoSize = True
        Me.m1_Text1.Location = New System.Drawing.Point(12, 301)
        Me.m1_Text1.Name = "m1_Text1"
        Me.m1_Text1.Size = New System.Drawing.Size(191, 13)
        Me.m1_Text1.TabIndex = 11
        Me.m1_Text1.Text = "Загрузка списка ошибок:"
        Me.m1_Text1.Visible = False
        '
        'm1_Progress
        '
        Me.m1_Progress.Location = New System.Drawing.Point(12, 317)
        Me.m1_Progress.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.m1_Progress.Name = "m1_Progress"
        Me.m1_Progress.Size = New System.Drawing.Size(470, 30)
        Me.m1_Progress.TabIndex = 10
        Me.m1_Progress.Value = CType(0US, UShort)
        Me.m1_Progress.Visible = False
        '
        'p2_Text3
        '
        Me.p2_Text3.AutoSize = True
        Me.p2_Text3.Location = New System.Drawing.Point(12, 357)
        Me.p2_Text3.Name = "p2_Text3"
        Me.p2_Text3.Size = New System.Drawing.Size(159, 13)
        Me.p2_Text3.TabIndex = 12
        Me.p2_Text3.Text = "Обнаружено проблем:"
        Me.p2_Text3.Visible = False
        '
        'p2_Text4
        '
        Me.p2_Text4.AutoSize = True
        Me.p2_Text4.Location = New System.Drawing.Point(12, 370)
        Me.p2_Text4.Name = "p2_Text4"
        Me.p2_Text4.Size = New System.Drawing.Size(175, 13)
        Me.p2_Text4.TabIndex = 13
        Me.p2_Text4.Text = "Исправлено проблем: 0"
        Me.p2_Text4.Visible = False
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(496, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.p2_Text4)
        Me.Controls.Add(Me.p2_Text3)
        Me.Controls.Add(Me.m1_Text1)
        Me.Controls.Add(Me.m1_Progress)
        Me.Controls.Add(Me.p2_Text2)
        Me.Controls.Add(Me.p2_ListBox2)
        Me.Controls.Add(Me.p2_ListBox1)
        Me.Controls.Add(Me.p2_Text1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.p1_Text1)
        Me.Controls.Add(Me.p1_RadioButton1)
        Me.Controls.Add(Me.p1_RadioButton2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents p1_RadioButton2 As RadioButton
    Friend WithEvents p1_RadioButton1 As RadioButton
    Friend WithEvents p1_Text1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents p2_Text1 As Label
    Friend WithEvents p2_ListBox1 As ListBox
    Friend WithEvents p2_ListBox2 As ListBox
    Friend WithEvents p2_Text2 As Label
    Friend WithEvents Set_Prog_Pos As Timer
    Friend WithEvents m1_Progress As Progress1
    Friend WithEvents m1_Text1 As Label
    Friend WithEvents p2_Text3 As Label
    Friend WithEvents p2_Text4 As Label
End Class
