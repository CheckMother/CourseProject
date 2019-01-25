<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGallery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGallery))
        Me.lblBooking = New System.Windows.Forms.Label
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lblGallery = New System.Windows.Forms.Label
        Me.lblRooms = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblPharmacy = New System.Windows.Forms.Label
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblContacts.Location = New System.Drawing.Point(690, 29)
        Me.lblContacts.Name = "lblContacts"
        Me.lblContacts.Size = New System.Drawing.Size(89, 27)
        Me.lblContacts.TabIndex = 13
        Me.lblContacts.Text = "Контакты"
        Me.lblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGallery
        '
        Me.lblGallery.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblGallery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGallery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblGallery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblGallery.Location = New System.Drawing.Point(549, 29)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(89, 27)
        Me.lblGallery.TabIndex = 11
        Me.lblGallery.Text = "Галерея"
        Me.lblGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRooms
        '
        Me.lblRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblRooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblRooms.Location = New System.Drawing.Point(409, 29)
        Me.lblRooms.Name = "lblRooms"
        Me.lblRooms.Size = New System.Drawing.Size(89, 27)
        Me.lblRooms.TabIndex = 10
        Me.lblRooms.Text = "Номера"
        Me.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel1.Size = New System.Drawing.Size(808, 146)
        Me.Panel1.TabIndex = 17
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Image = Global.Курсовая.My.Resources.Resources.layout_set_logo
        Me.lblMain.Location = New System.Drawing.Point(12, 20)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(101, 108)
        Me.lblMain.TabIndex = 15
        '
        'lblPharmacy
        '
        Me.lblPharmacy.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblPharmacy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPharmacy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.lblPharmacy.Location = New System.Drawing.Point(271, 29)
        Me.lblPharmacy.Name = "lblPharmacy"
        Me.lblPharmacy.Size = New System.Drawing.Size(89, 27)
        Me.lblPharmacy.TabIndex = 10
        Me.lblPharmacy.Text = "Зоомагазин"
        Me.lblPharmacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Курсовая.My.Resources.Resources._M__1376
        Me.PictureBox8.Location = New System.Drawing.Point(105, 489)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(290, 189)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 18
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Курсовая.My.Resources.Resources._M__1484
        Me.PictureBox6.Location = New System.Drawing.Point(566, 337)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Курсовая.My.Resources.Resources._M__1355
        Me.PictureBox5.Location = New System.Drawing.Point(294, 337)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Курсовая.My.Resources.Resources._M__1380
        Me.PictureBox7.Location = New System.Drawing.Point(474, 477)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(146, 205)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 18
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Курсовая.My.Resources.Resources._M__1677
        Me.PictureBox3.Location = New System.Drawing.Point(566, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Курсовая.My.Resources.Resources._M__1684
        Me.PictureBox4.Location = New System.Drawing.Point(19, 337)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Курсовая.My.Resources.Resources._M__1426
        Me.PictureBox2.Location = New System.Drawing.Point(294, 170)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Курсовая.My.Resources.Resources._M__1254
        Me.PictureBox1.Location = New System.Drawing.Point(19, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 694)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGallery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Галерея"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lblGallery As System.Windows.Forms.Label
    Friend WithEvents lblRooms As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPharmacy As System.Windows.Forms.Label
End Class
