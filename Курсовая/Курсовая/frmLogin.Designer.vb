<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.chkShow = New System.Windows.Forms.CheckBox
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.llbRegistration = New System.Windows.Forms.LinkLabel
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTimer = New System.Windows.Forms.Label
        Me.tmrLogin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(209, 91)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkShow.Size = New System.Drawing.Size(114, 17)
        Me.chkShow.TabIndex = 25
        Me.chkShow.Text = "Показать пароль"
        Me.chkShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(276, 114)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(75, 23)
        Me.cmdLogin.TabIndex = 23
        Me.cmdLogin.Text = "Войти"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'llbRegistration
        '
        Me.llbRegistration.AutoSize = True
        Me.llbRegistration.Location = New System.Drawing.Point(146, 119)
        Me.llbRegistration.Name = "llbRegistration"
        Me.llbRegistration.Size = New System.Drawing.Size(113, 13)
        Me.llbRegistration.TabIndex = 24
        Me.llbRegistration.TabStop = True
        Me.llbRegistration.Text = "Зарегистрироваться"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(209, 65)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(132, 20)
        Me.txtPassword.TabIndex = 22
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(209, 12)
        Me.txtLogin.MaxLength = 10
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(132, 20)
        Me.txtLogin.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Пароль"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Логин"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Курсовая.My.Resources.Resources.Account
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(277, 41)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 13)
        Me.lblTimer.TabIndex = 27
        '
        'tmrLogin
        '
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 150)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.llbRegistration)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Авторизация"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkShow As System.Windows.Forms.CheckBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents llbRegistration As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents tmrLogin As System.Windows.Forms.Timer
End Class
