<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContacts))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblBooking = New System.Windows.Forms.Label
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lblPharmacy = New System.Windows.Forms.Label
        Me.lblRooms = New System.Windows.Forms.Label
        Me.lblGallery = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Controls.Add(Me.lblBooking)
        Me.Panel1.Controls.Add(Me.lblContacts)
        Me.Panel1.Controls.Add(Me.lblPharmacy)
        Me.Panel1.Controls.Add(Me.lblRooms)
        Me.Panel1.Controls.Add(Me.lblGallery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 146)
        Me.Panel1.TabIndex = 18
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Image = Global.Курсовая.My.Resources.Resources.layout_set_logo
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(101, 108)
        Me.lblMain.TabIndex = 15
        '
        'lblBooking
        '
        Me.lblBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblBooking.Location = New System.Drawing.Point(131, 29)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(98, 27)
        Me.lblBooking.TabIndex = 14
        Me.lblBooking.Text = "Заселить"
        Me.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContacts
        '
        Me.lblContacts.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblContacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblContacts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblContacts.Location = New System.Drawing.Point(707, 29)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(89, 27)
        Me.lblContacts.TabIndex = 13
        Me.lblContacts.Text = "Контакты"
        Me.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPharmacy
        '
        Me.lblPharmacy.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblPharmacy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPharmacy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblPharmacy.Location = New System.Drawing.Point(279, 29)
        Me.lblPharmacy.Name = "lblPharmacy"
        Me.lblPharmacy.Size = New System.Drawing.Size(89, 27)
        Me.lblPharmacy.TabIndex = 10
        Me.lblPharmacy.Text = "Зоомагазин"
        Me.lblPharmacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRooms
        '
        Me.lblRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblRooms.Location = New System.Drawing.Point(424, 29)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(89, 27)
        Me.lblRooms.TabIndex = 10
        Me.lblRooms.Text = "Номера"
        Me.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGallery
        '
        Me.lblGallery.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblGallery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGallery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblGallery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblGallery.Location = New System.Drawing.Point(563, 29)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(89, 27)
        Me.lblGallery.TabIndex = 11
        Me.lblGallery.Text = "Галерея"
        Me.lblGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Image = Global.Курсовая.My.Resources.Resources.phone
        Me.Label1.Location = New System.Drawing.Point(24, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 27)
        Me.Label1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Image = Global.Курсовая.My.Resources.Resources.message
        Me.Label2.Location = New System.Drawing.Point(24, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 27)
        Me.Label2.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Image = Global.Курсовая.My.Resources.Resources.home
        Me.Label3.Location = New System.Drawing.Point(24, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 27)
        Me.Label3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "8 (918) 975-78-88"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Г.Новокубанск ул.Пушкина д.5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "vlad.bandurko.97@mail.ru"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Image = Global.Курсовая.My.Resources.Resources.vk
        Me.Label7.Location = New System.Drawing.Point(413, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 27)
        Me.Label7.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(253, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "vk.com/saltandsalt"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 315)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Контакты"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lblPharmacy As System.Windows.Forms.Label
    Friend WithEvents lblRooms As System.Windows.Forms.Label
    Friend WithEvents lblGallery As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
