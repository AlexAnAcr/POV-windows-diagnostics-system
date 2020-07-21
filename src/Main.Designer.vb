<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Progress11 = New JProgTestWin8_1.Progress1()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.Location = New System.Drawing.Point(148, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(346, 21)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Идёт сканирование программ..."
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label2.Location = New System.Drawing.Point(148, 33)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(346, 107)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Данный тип сканирования проводится автоматически 1 раз в год. Это необходимо для " &
	"выявления и исправления неполадок работы и совместимости установленных программ." &
	""
		'
		'Timer1
		'
		Me.Timer1.Interval = 1000
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 205)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(124, 15)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Выполнено: --"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label4.Location = New System.Drawing.Point(12, 192)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(175, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Статус: подготовка..."
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(350, 194)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(144, 23)
		Me.Button1.TabIndex = 7
		Me.Button1.Text = "Отменить"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label5.Location = New System.Drawing.Point(12, 179)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(95, 13)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Стадия: 1/2"
		'
		'Button2
		'
		Me.Button2.Image = Global.JProgTestWin8_1.My.Resources.Resources._484478
		Me.Button2.Location = New System.Drawing.Point(451, 98)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(43, 42)
		Me.Button2.TabIndex = 9
		Me.Button2.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Progress11
		'
		Me.Progress11.Location = New System.Drawing.Point(12, 146)
		Me.Progress11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Progress11.Name = "Progress11"
		Me.Progress11.Size = New System.Drawing.Size(481, 30)
		Me.Progress11.TabIndex = 3
		Me.Progress11.Value = CType(0US, UShort)
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.ClientSize = New System.Drawing.Size(506, 229)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Progress11)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Windows 8"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Progress11 As Progress1
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
