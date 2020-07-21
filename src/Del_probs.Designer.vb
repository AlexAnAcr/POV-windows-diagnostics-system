<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Del_probs
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Del_probs))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Progress11 = New JProgTestWin8_1.Progress1()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 46)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(103, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Исправление:"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(255, 109)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(107, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Отмена"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		Me.Timer1.Interval = 500
		'
		'Label2
		'
		Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(380, 30)
		Me.Label2.TabIndex = 3
		'
		'Progress11
		'
		Me.Progress11.Location = New System.Drawing.Point(13, 62)
		Me.Progress11.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.Progress11.Name = "Progress11"
		Me.Progress11.Size = New System.Drawing.Size(348, 33)
		Me.Progress11.TabIndex = 1
		Me.Progress11.Value = CType(0US, UShort)
		'
		'Del_probs
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.ClientSize = New System.Drawing.Size(374, 144)
		Me.ControlBox = False
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Progress11)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Del_probs"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Progress11 As Progress1
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
