<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooking))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblBooking = New System.Windows.Forms.Label
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lblPharmacy = New System.Windows.Forms.Label
        Me.lblRooms = New System.Windows.Forms.Label
        Me.lblGallery = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNickname = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.mtxNumber = New System.Windows.Forms.MaskedTextBox
        Me.txtSurnname = New System.Windows.Forms.TextBox
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboPol = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkDelivery = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtView = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtBreed = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtAdditionalInf = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboRooms = New System.Windows.Forms.ComboBox
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dgvAnimal = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФамилияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИмяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтчествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НомерТелефонаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.АдресПроживанияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВидDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПородаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КличкаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПолDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВозрастDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДоставкапитомцаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДатаЗаездаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДатаВыбытияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТипНомераDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДополнительнаяИнформацияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДополнительныеуслугиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИтогоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ХозяеваипитомцыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalBDDataSet = New Курсовая.AnimalBDDataSet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.chkFeeding = New System.Windows.Forms.CheckBox
        Me.chkWash = New System.Windows.Forms.CheckBox
        Me.chkCall = New System.Windows.Forms.CheckBox
        Me.chkBathing = New System.Windows.Forms.CheckBox
        Me.chkTraining = New System.Windows.Forms.CheckBox
        Me.chkCombing = New System.Windows.Forms.CheckBox
        Me.chkDelicacies = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Хозяева_и_питомцыTableAdapter = New Курсовая.AnimalBDDataSetTableAdapters.Хозяева_и_питомцыTableAdapter
        Me.cmdReset = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ХозяеваипитомцыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1303, 146)
        Me.Panel1.TabIndex = 19
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
        Me.lblBooking.Location = New System.Drawing.Point(172, 29)
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
        Me.lblContacts.Location = New System.Drawing.Point(1145, 29)
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
        Me.lblPharmacy.Location = New System.Drawing.Point(413, 29)
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
        Me.lblRooms.Location = New System.Drawing.Point(665, 29)
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
        Me.lblGallery.Location = New System.Drawing.Point(912, 29)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(89, 27)
        Me.lblGallery.TabIndex = 11
        Me.lblGallery.Text = "Галерея"
        Me.lblGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Номер телефона"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Вид" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Кличка"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 26)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Адрес" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "проживания" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(55, 70)
        Me.txtNickname.MaxLength = 15
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(128, 20)
        Me.txtNickname.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(77, 126)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(115, 40)
        Me.txtAddress.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mtxNumber)
        Me.GroupBox4.Controls.Add(Me.txtSurnname)
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.txtPatronymic)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtName)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 172)
        Me.GroupBox4.TabIndex = 128
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Личный данные хозяина"
        '
        'mtxNumber
        '
        Me.mtxNumber.Location = New System.Drawing.Point(105, 96)
        Me.mtxNumber.Mask = "+7(999) 000-00-00"
        Me.mtxNumber.Name = "mtxNumber"
        Me.mtxNumber.Size = New System.Drawing.Size(98, 20)
        Me.mtxNumber.TabIndex = 4
        '
        'txtSurnname
        '
        Me.txtSurnname.Location = New System.Drawing.Point(68, 18)
        Me.txtSurnname.MaxLength = 15
        Me.txtSurnname.Name = "txtSurnname"
        Me.txtSurnname.Size = New System.Drawing.Size(128, 20)
        Me.txtSurnname.TabIndex = 1
        '
        'txtPatronymic
        '
        Me.txtPatronymic.Location = New System.Drawing.Point(68, 70)
        Me.txtPatronymic.MaxLength = 15
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(128, 20)
        Me.txtPatronymic.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Отчество"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(41, 44)
        Me.txtName.MaxLength = 15
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Имя"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Фамилия"
        '
        'cboPol
        '
        Me.cboPol.FormattingEnabled = True
        Me.cboPol.Items.AddRange(New Object() {"Мальчик", "Девочка"})
        Me.cboPol.Location = New System.Drawing.Point(39, 96)
        Me.cboPol.Name = "cboPol"
        Me.cboPol.Size = New System.Drawing.Size(121, 21)
        Me.cboPol.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDelivery)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboPol)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtView)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtBreed)
        Me.GroupBox1.Controls.Add(Me.txtNickname)
        Me.GroupBox1.Location = New System.Drawing.Point(221, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 172)
        Me.GroupBox1.TabIndex = 130
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Данные о питомце"
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(9, 148)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(172, 17)
        Me.chkDelivery.TabIndex = 131
        Me.chkDelivery.Text = "Доставка питомца - 800 руб."
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Возраст"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Пол"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Порода"
        '
        'txtView
        '
        Me.txtView.Location = New System.Drawing.Point(38, 18)
        Me.txtView.MaxLength = 15
        Me.txtView.Name = "txtView"
        Me.txtView.Size = New System.Drawing.Size(128, 20)
        Me.txtView.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(61, 122)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(128, 20)
        Me.txtAge.TabIndex = 10
        '
        'txtBreed
        '
        Me.txtBreed.Location = New System.Drawing.Point(57, 44)
        Me.txtBreed.MaxLength = 15
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(128, 20)
        Me.txtBreed.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAdditionalInf)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cboRooms)
        Me.GroupBox2.Controls.Add(Me.dtpDeparture)
        Me.GroupBox2.Controls.Add(Me.dtpArrival)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 110)
        Me.GroupBox2.TabIndex = 131
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Общие данные"
        '
        'txtAdditionalInf
        '
        Me.txtAdditionalInf.Location = New System.Drawing.Point(198, 32)
        Me.txtAdditionalInf.MaxLength = 60
        Me.txtAdditionalInf.Multiline = True
        Me.txtAdditionalInf.Name = "txtAdditionalInf"
        Me.txtAdditionalInf.Size = New System.Drawing.Size(209, 72)
        Me.txtAdditionalInf.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(203, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Дополнительная информация" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboRooms
        '
        Me.cboRooms.FormattingEnabled = True
        Me.cboRooms.Items.AddRange(New Object() {"Стандарт", "VIP"})
        Me.cboRooms.Location = New System.Drawing.Point(57, 78)
        Me.cboRooms.Name = "cboRooms"
        Me.cboRooms.Size = New System.Drawing.Size(128, 21)
        Me.cboRooms.TabIndex = 13
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(64, 47)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(128, 20)
        Me.dtpDeparture.TabIndex = 12
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(55, 18)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(128, 20)
        Me.dtpArrival.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 26)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Тип" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "номера" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Дата" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "выбытия"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 26)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Дата " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "заезда"
        '
        'dgvAnimal
        '
        Me.dgvAnimal.AutoGenerateColumns = False
        Me.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnimal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФамилияDataGridViewTextBoxColumn, Me.ИмяDataGridViewTextBoxColumn, Me.ОтчествоDataGridViewTextBoxColumn, Me.НомерТелефонаDataGridViewTextBoxColumn, Me.АдресПроживанияDataGridViewTextBoxColumn, Me.ВидDataGridViewTextBoxColumn, Me.ПородаDataGridViewTextBoxColumn, Me.КличкаDataGridViewTextBoxColumn, Me.ПолDataGridViewTextBoxColumn, Me.ВозрастDataGridViewTextBoxColumn, Me.ДоставкапитомцаDataGridViewTextBoxColumn, Me.ДатаЗаездаDataGridViewTextBoxColumn, Me.ДатаВыбытияDataGridViewTextBoxColumn, Me.ТипНомераDataGridViewTextBoxColumn, Me.ДополнительнаяИнформацияDataGridViewTextBoxColumn, Me.ДополнительныеуслугиDataGridViewTextBoxColumn, Me.ИтогоDataGridViewTextBoxColumn})
        Me.dgvAnimal.DataSource = Me.ХозяеваипитомцыBindingSource
        Me.dgvAnimal.Location = New System.Drawing.Point(6, 16)
        Me.dgvAnimal.Name = "dgvAnimal"
        Me.dgvAnimal.Size = New System.Drawing.Size(479, 194)
        Me.dgvAnimal.TabIndex = 132
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        '
        'ФамилияDataGridViewTextBoxColumn
        '
        Me.ФамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия"
        Me.ФамилияDataGridViewTextBoxColumn.Name = "ФамилияDataGridViewTextBoxColumn"
        '
        'ИмяDataGridViewTextBoxColumn
        '
        Me.ИмяDataGridViewTextBoxColumn.DataPropertyName = "Имя"
        Me.ИмяDataGridViewTextBoxColumn.HeaderText = "Имя"
        Me.ИмяDataGridViewTextBoxColumn.Name = "ИмяDataGridViewTextBoxColumn"
        '
        'ОтчествоDataGridViewTextBoxColumn
        '
        Me.ОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество"
        Me.ОтчествоDataGridViewTextBoxColumn.HeaderText = "Отчество"
        Me.ОтчествоDataGridViewTextBoxColumn.Name = "ОтчествоDataGridViewTextBoxColumn"
        '
        'НомерТелефонаDataGridViewTextBoxColumn
        '
        Me.НомерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона"
        Me.НомерТелефонаDataGridViewTextBoxColumn.Name = "НомерТелефонаDataGridViewTextBoxColumn"
        '
        'АдресПроживанияDataGridViewTextBoxColumn
        '
        Me.АдресПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес проживания"
        Me.АдресПроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес проживания"
        Me.АдресПроживанияDataGridViewTextBoxColumn.Name = "АдресПроживанияDataGridViewTextBoxColumn"
        '
        'ВидDataGridViewTextBoxColumn
        '
        Me.ВидDataGridViewTextBoxColumn.DataPropertyName = "Вид"
        Me.ВидDataGridViewTextBoxColumn.HeaderText = "Вид"
        Me.ВидDataGridViewTextBoxColumn.Name = "ВидDataGridViewTextBoxColumn"
        '
        'ПородаDataGridViewTextBoxColumn
        '
        Me.ПородаDataGridViewTextBoxColumn.DataPropertyName = "Порода"
        Me.ПородаDataGridViewTextBoxColumn.HeaderText = "Порода"
        Me.ПородаDataGridViewTextBoxColumn.Name = "ПородаDataGridViewTextBoxColumn"
        '
        'КличкаDataGridViewTextBoxColumn
        '
        Me.КличкаDataGridViewTextBoxColumn.DataPropertyName = "Кличка"
        Me.КличкаDataGridViewTextBoxColumn.HeaderText = "Кличка"
        Me.КличкаDataGridViewTextBoxColumn.Name = "КличкаDataGridViewTextBoxColumn"
        '
        'ПолDataGridViewTextBoxColumn
        '
        Me.ПолDataGridViewTextBoxColumn.DataPropertyName = "Пол"
        Me.ПолDataGridViewTextBoxColumn.HeaderText = "Пол"
        Me.ПолDataGridViewTextBoxColumn.Name = "ПолDataGridViewTextBoxColumn"
        '
        'ВозрастDataGridViewTextBoxColumn
        '
        Me.ВозрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст"
        Me.ВозрастDataGridViewTextBoxColumn.HeaderText = "Возраст"
        Me.ВозрастDataGridViewTextBoxColumn.Name = "ВозрастDataGridViewTextBoxColumn"
        '
        'ДоставкапитомцаDataGridViewTextBoxColumn
        '
        Me.ДоставкапитомцаDataGridViewTextBoxColumn.DataPropertyName = "Доставка_питомца"
        Me.ДоставкапитомцаDataGridViewTextBoxColumn.HeaderText = "Доставка_питомца"
        Me.ДоставкапитомцаDataGridViewTextBoxColumn.Name = "ДоставкапитомцаDataGridViewTextBoxColumn"
        '
        'ДатаЗаездаDataGridViewTextBoxColumn
        '
        Me.ДатаЗаездаDataGridViewTextBoxColumn.DataPropertyName = "Дата заезда"
        Me.ДатаЗаездаDataGridViewTextBoxColumn.HeaderText = "Дата заезда"
        Me.ДатаЗаездаDataGridViewTextBoxColumn.Name = "ДатаЗаездаDataGridViewTextBoxColumn"
        '
        'ДатаВыбытияDataGridViewTextBoxColumn
        '
        Me.ДатаВыбытияDataGridViewTextBoxColumn.DataPropertyName = "Дата выбытия"
        Me.ДатаВыбытияDataGridViewTextBoxColumn.HeaderText = "Дата выбытия"
        Me.ДатаВыбытияDataGridViewTextBoxColumn.Name = "ДатаВыбытияDataGridViewTextBoxColumn"
        '
        'ТипНомераDataGridViewTextBoxColumn
        '
        Me.ТипНомераDataGridViewTextBoxColumn.DataPropertyName = "Тип номера"
        Me.ТипНомераDataGridViewTextBoxColumn.HeaderText = "Тип номера"
        Me.ТипНомераDataGridViewTextBoxColumn.Name = "ТипНомераDataGridViewTextBoxColumn"
        '
        'ДополнительнаяИнформацияDataGridViewTextBoxColumn
        '
        Me.ДополнительнаяИнформацияDataGridViewTextBoxColumn.DataPropertyName = "Дополнительная информация"
        Me.ДополнительнаяИнформацияDataGridViewTextBoxColumn.HeaderText = "Дополнительная информация"
        Me.ДополнительнаяИнформацияDataGridViewTextBoxColumn.Name = "ДополнительнаяИнформацияDataGridViewTextBoxColumn"
        '
        'ДополнительныеуслугиDataGridViewTextBoxColumn
        '
        Me.ДополнительныеуслугиDataGridViewTextBoxColumn.DataPropertyName = "Дополнительные_услуги"
        Me.ДополнительныеуслугиDataGridViewTextBoxColumn.HeaderText = "Дополнительные_услуги"
        Me.ДополнительныеуслугиDataGridViewTextBoxColumn.Name = "ДополнительныеуслугиDataGridViewTextBoxColumn"
        '
        'ИтогоDataGridViewTextBoxColumn
        '
        Me.ИтогоDataGridViewTextBoxColumn.DataPropertyName = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.HeaderText = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.Name = "ИтогоDataGridViewTextBoxColumn"
        '
        'ХозяеваипитомцыBindingSource
        '
        Me.ХозяеваипитомцыBindingSource.DataMember = "Хозяева_и_питомцы"
        Me.ХозяеваипитомцыBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'AnimalBDDataSet
        '
        Me.AnimalBDDataSet.DataSetName = "AnimalBDDataSet"
        Me.AnimalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAdd)
        Me.GroupBox3.Controls.Add(Me.cmdDelete)
        Me.GroupBox3.Controls.Add(Me.cmdSave)
        Me.GroupBox3.Controls.Add(Me.dgvAnimal)
        Me.GroupBox3.Location = New System.Drawing.Point(800, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 245)
        Me.GroupBox3.TabIndex = 133
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Информация о заселенных питомцах и их хозяевах"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(148, 216)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 135
        Me.cmdAdd.Text = "Добавить"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(311, 216)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 134
        Me.cmdDelete.Text = "Удалить"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(229, 216)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 133
        Me.cmdSave.Text = "Сохранить"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(1192, 407)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 134
        Me.cmdSearch.Text = "Поиск"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(806, 409)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(380, 20)
        Me.txtSearch.TabIndex = 135
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(60, 64)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 136
        Me.cmdCalculate.Text = "Рассчитать"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(83, 35)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 137
        '
        'chkFeeding
        '
        Me.chkFeeding.AutoSize = True
        Me.chkFeeding.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkFeeding.Location = New System.Drawing.Point(6, 20)
        Me.chkFeeding.Name = "chkFeeding"
        Me.chkFeeding.Size = New System.Drawing.Size(156, 17)
        Me.chkFeeding.TabIndex = 138
        Me.chkFeeding.Text = "Доп.кормление - 100 руб."
        Me.chkFeeding.UseVisualStyleBackColor = True
        '
        'chkWash
        '
        Me.chkWash.AutoSize = True
        Me.chkWash.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkWash.Location = New System.Drawing.Point(196, 42)
        Me.chkWash.Name = "chkWash"
        Me.chkWash.Size = New System.Drawing.Size(130, 17)
        Me.chkWash.TabIndex = 143
        Me.chkWash.Text = "Мытье глаз - 50 руб."
        Me.chkWash.UseVisualStyleBackColor = True
        '
        'chkCall
        '
        Me.chkCall.AutoSize = True
        Me.chkCall.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkCall.Location = New System.Drawing.Point(196, 19)
        Me.chkCall.Name = "chkCall"
        Me.chkCall.Size = New System.Drawing.Size(161, 17)
        Me.chkCall.TabIndex = 144
        Me.chkCall.Text = "Вызов вет.врача - 500 руб."
        Me.chkCall.UseVisualStyleBackColor = True
        '
        'chkBathing
        '
        Me.chkBathing.AutoSize = True
        Me.chkBathing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkBathing.Location = New System.Drawing.Point(6, 111)
        Me.chkBathing.Name = "chkBathing"
        Me.chkBathing.Size = New System.Drawing.Size(112, 17)
        Me.chkBathing.TabIndex = 145
        Me.chkBathing.Text = "Купание - 50 руб."
        Me.chkBathing.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkTraining.Location = New System.Drawing.Point(6, 88)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(145, 17)
        Me.chkTraining.TabIndex = 142
        Me.chkTraining.Text = "Дрессировка - 600 руб."
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkCombing
        '
        Me.chkCombing.AutoSize = True
        Me.chkCombing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkCombing.Location = New System.Drawing.Point(6, 65)
        Me.chkCombing.Name = "chkCombing"
        Me.chkCombing.Size = New System.Drawing.Size(184, 17)
        Me.chkCombing.TabIndex = 139
        Me.chkCombing.Text = "Расчесывание шерсти - 50 руб."
        Me.chkCombing.UseVisualStyleBackColor = True
        '
        'chkDelicacies
        '
        Me.chkDelicacies.AutoSize = True
        Me.chkDelicacies.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkDelicacies.Location = New System.Drawing.Point(6, 43)
        Me.chkDelicacies.Name = "chkDelicacies"
        Me.chkDelicacies.Size = New System.Drawing.Size(149, 17)
        Me.chkDelicacies.TabIndex = 140
        Me.chkDelicacies.Text = "Доп.лакомства - 50 руб."
        Me.chkDelicacies.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkBathing)
        Me.GroupBox5.Controls.Add(Me.chkWash)
        Me.GroupBox5.Controls.Add(Me.chkTraining)
        Me.GroupBox5.Controls.Add(Me.chkCall)
        Me.GroupBox5.Controls.Add(Me.chkCombing)
        Me.GroupBox5.Controls.Add(Me.chkFeeding)
        Me.GroupBox5.Controls.Add(Me.chkDelicacies)
        Me.GroupBox5.Location = New System.Drawing.Point(428, 153)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(366, 137)
        Me.GroupBox5.TabIndex = 146
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Дополнительные услуги"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdCalculate)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.txtTotal)
        Me.GroupBox6.Location = New System.Drawing.Point(474, 303)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox6.TabIndex = 147
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "К расчёту"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "Итого"
        '
        'Хозяева_и_питомцыTableAdapter
        '
        Me.Хозяева_и_питомцыTableAdapter.ClearBeforeFill = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(725, 407)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 148
        Me.cmdReset.Text = "Сбросить"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 445)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Заселение"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ХозяеваипитомцыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lblPharmacy As System.Windows.Forms.Label
    Friend WithEvents lblRooms As System.Windows.Forms.Label
    Friend WithEvents lblGallery As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNickname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurnname As System.Windows.Forms.TextBox
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboPol As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtxNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtView As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBreed As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboRooms As System.Windows.Forms.ComboBox
    Friend WithEvents txtAdditionalInf As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dgvAnimal As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents chkFeeding As System.Windows.Forms.CheckBox
    Friend WithEvents chkWash As System.Windows.Forms.CheckBox
    Friend WithEvents chkCall As System.Windows.Forms.CheckBox
    Friend WithEvents chkBathing As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraining As System.Windows.Forms.CheckBox
    Friend WithEvents chkCombing As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelicacies As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents AnimalBDDataSet As Курсовая.AnimalBDDataSet
    Friend WithEvents ХозяеваипитомцыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Хозяева_и_питомцыTableAdapter As Курсовая.AnimalBDDataSetTableAdapters.Хозяева_и_питомцыTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФамилияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИмяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтчествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НомерТелефонаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents АдресПроживанияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВидDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПородаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КличкаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПолDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВозрастDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДоставкапитомцаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаЗаездаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДатаВыбытияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТипНомераDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДополнительнаяИнформацияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДополнительныеуслугиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИтогоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdReset As System.Windows.Forms.Button
End Class
