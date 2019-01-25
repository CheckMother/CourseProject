<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRooms))
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lblGallery = New System.Windows.Forms.Label
        Me.lblRooms = New System.Windows.Forms.Label
        Me.lblBooking = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPharmacy = New System.Windows.Forms.Label
        Me.lblMain = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblContacts
        '
        Me.lblContacts.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblContacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblContacts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblContacts.Location = New System.Drawing.Point(726, 29)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(89, 27)
        Me.lblContacts.TabIndex = 6
        Me.lblContacts.Text = "Контакты"
        Me.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGallery
        '
        Me.lblGallery.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblGallery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGallery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblGallery.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblGallery.Location = New System.Drawing.Point(573, 29)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(89, 27)
        Me.lblGallery.TabIndex = 4
        Me.lblGallery.Text = "Галерея"
        Me.lblGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRooms
        '
        Me.lblRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRooms.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblRooms.Location = New System.Drawing.Point(428, 29)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(89, 27)
        Me.lblRooms.TabIndex = 3
        Me.lblRooms.Text = "Номера"
        Me.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBooking
        '
        Me.lblBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblBooking.Location = New System.Drawing.Point(128, 29)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(98, 27)
        Me.lblBooking.TabIndex = 6
        Me.lblBooking.Text = "Заселить"
        Me.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPharmacy)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Controls.Add(Me.lblRooms)
        Me.Panel1.Controls.Add(Me.lblGallery)
        Me.Panel1.Controls.Add(Me.lblContacts)
        Me.Panel1.Controls.Add(Me.lblBooking)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 146)
        Me.Panel1.TabIndex = 9
        '
        'lblPharmacy
        '
        Me.lblPharmacy.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblPharmacy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPharmacy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblPharmacy.Location = New System.Drawing.Point(273, 29)
        Me.lblPharmacy.Name = "lblPharmacy"
        Me.lblPharmacy.Size = New System.Drawing.Size(89, 27)
        Me.lblPharmacy.TabIndex = 11
        Me.lblPharmacy.Text = "Зоомагазин"
        Me.lblPharmacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Image = Global.Курсовая.My.Resources.Resources.layout_set_logo
        Me.lblMain.Location = New System.Drawing.Point(12, 19)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(101, 108)
        Me.lblMain.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(350, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 42)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Наши номера"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Курсовая.My.Resources.Resources.VIP
        Me.PictureBox2.Location = New System.Drawing.Point(520, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(269, 186)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Курсовая.My.Resources.Resources.Standard
        Me.PictureBox1.Location = New System.Drawing.Point(48, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(107, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 42)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Стандарт"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(601, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "VIP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 148)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Комфортабельный номер для Вашего питомца. В номере есть: стеллаж с двумя полками," & _
            " каждая с подушечкой, когтеточка, поильник, туалет" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Стоимость  - 300 руб./дн" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Объем - 1,5 м3"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(517, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 148)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'frmRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 556)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Номера"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lblGallery As System.Windows.Forms.Label
    Friend WithEvents lblRooms As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPharmacy As System.Windows.Forms.Label
End Class
