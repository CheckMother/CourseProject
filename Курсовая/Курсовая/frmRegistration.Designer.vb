<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.txtPasswordCreate = New System.Windows.Forms.TextBox
        Me.txtLoginCreate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdRegistration = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtPasswordCreate
        '
        Me.txtPasswordCreate.Location = New System.Drawing.Point(129, 32)
        Me.txtPasswordCreate.Name = "txtPasswordCreate"
        Me.txtPasswordCreate.Size = New System.Drawing.Size(113, 20)
        Me.txtPasswordCreate.TabIndex = 2
        '
        'txtLoginCreate
        '
        Me.txtLoginCreate.Location = New System.Drawing.Point(129, 9)
        Me.txtLoginCreate.Name = "txtLoginCreate"
        Me.txtLoginCreate.Size = New System.Drawing.Size(113, 20)
        Me.txtLoginCreate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Пароль"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Логин"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(129, 58)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(113, 20)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Подтвердите пароль"
        '
        'cmdRegistration
        '
        Me.cmdRegistration.Location = New System.Drawing.Point(12, 84)
        Me.cmdRegistration.Name = "cmdRegistration"
        Me.cmdRegistration.Size = New System.Drawing.Size(127, 23)
        Me.cmdRegistration.TabIndex = 4
        Me.cmdRegistration.Text = "Зарегистрироваться"
        Me.cmdRegistration.UseVisualStyleBackColor = True
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 119)
        Me.Controls.Add(Me.cmdRegistration)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPasswordCreate)
        Me.Controls.Add(Me.txtLoginCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Регистрация"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPasswordCreate As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginCreate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdRegistration As System.Windows.Forms.Button
End Class
