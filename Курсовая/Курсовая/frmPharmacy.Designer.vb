<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPharmacy))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.lblBooking = New System.Windows.Forms.Label
        Me.lblContacts = New System.Windows.Forms.Label
        Me.lblPharmacy = New System.Windows.Forms.Label
        Me.lblRooms = New System.Windows.Forms.Label
        Me.lblGallery = New System.Windows.Forms.Label
        Me.tabZooShop = New System.Windows.Forms.TabControl
        Me.tpFeed = New System.Windows.Forms.TabPage
        Me.cmdHide = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdBuyFeed = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotalFeed = New System.Windows.Forms.TextBox
        Me.BuyFeedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyDataSet = New Курсовая.BuyDataSet
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdBuy = New System.Windows.Forms.Button
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.cboAnimal = New System.Windows.Forms.ComboBox
        Me.cboViewFeed = New System.Windows.Forms.ComboBox
        Me.cboCompany = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КакойКормDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.БрендDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ДляКакогоЖивотногоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.МассаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИтогоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuyFeedTableAdapter = New Курсовая.BuyDataSetTableAdapters.BuyFeedTableAdapter
        Me.cmdCalculate = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.tabZooShop.SuspendLayout()
        Me.tpFeed.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BuyFeedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(746, 146)
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
        Me.lblContacts.Location = New System.Drawing.Point(637, 29)
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
        Me.lblPharmacy.Location = New System.Drawing.Point(254, 29)
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
        Me.lblRooms.Location = New System.Drawing.Point(377, 29)
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
        Me.lblGallery.Location = New System.Drawing.Point(504, 29)
        Me.lblGallery.Name = "lblGallery"
        Me.lblGallery.Size = New System.Drawing.Size(89, 27)
        Me.lblGallery.TabIndex = 11
        Me.lblGallery.Text = "Галерея"
        Me.lblGallery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabZooShop
        '
        Me.tabZooShop.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabZooShop.Controls.Add(Me.tpFeed)
        Me.tabZooShop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabZooShop.Location = New System.Drawing.Point(0, 146)
        Me.tabZooShop.Name = "tabZooShop"
        Me.tabZooShop.SelectedIndex = 0
        Me.tabZooShop.Size = New System.Drawing.Size(746, 405)
        Me.tabZooShop.TabIndex = 19
        '
        'tpFeed
        '
        Me.tpFeed.Controls.Add(Me.cmdHide)
        Me.tpFeed.Controls.Add(Me.cmdAdd)
        Me.tpFeed.Controls.Add(Me.cmdBuyFeed)
        Me.tpFeed.Controls.Add(Me.GroupBox3)
        Me.tpFeed.Controls.Add(Me.GroupBox2)
        Me.tpFeed.Controls.Add(Me.GroupBox1)
        Me.tpFeed.Controls.Add(Me.GroupBox5)
        Me.tpFeed.Location = New System.Drawing.Point(4, 25)
        Me.tpFeed.Name = "tpFeed"
        Me.tpFeed.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFeed.Size = New System.Drawing.Size(738, 376)
        Me.tpFeed.TabIndex = 0
        Me.tpFeed.Text = "Корм"
        Me.tpFeed.UseVisualStyleBackColor = True
        '
        'cmdHide
        '
        Me.cmdHide.Location = New System.Drawing.Point(460, 246)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(129, 23)
        Me.cmdHide.TabIndex = 15
        Me.cmdHide.Text = "Скрыть покупки"
        Me.cmdHide.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(460, 206)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(129, 34)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "Добавить новую пустую строку в базу"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdBuyFeed
        '
        Me.cmdBuyFeed.Location = New System.Drawing.Point(281, 143)
        Me.cmdBuyFeed.Name = "cmdBuyFeed"
        Me.cmdBuyFeed.Size = New System.Drawing.Size(114, 23)
        Me.cmdBuyFeed.TabIndex = 11
        Me.cmdBuyFeed.Text = "Показать покупки"
        Me.cmdBuyFeed.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(522, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Цены для собак (Руб. за 1 грамм)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 104)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Сухой: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Royal Canin - 0,43" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grandin - 0,42" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abba - 0,29" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Влажный:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abba - 0,77" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "Grandin - 0,64" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Royal Canin - 0,52"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Цены для кошек (Руб. за 1 грамм)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 104)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Сухой: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pro Plan - 0,84" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Royal Canin - 0,82 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wellkiss - 0,36" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Влажный:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pro Pla" & _
            "n - 0,83" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Royal Canin - 0,81 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wellkiss - 0,70"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCalculate)
        Me.GroupBox1.Controls.Add(Me.txtTotalFeed)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmdBuy)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.cboAnimal)
        Me.GroupBox1.Controls.Add(Me.cboViewFeed)
        Me.GroupBox1.Controls.Add(Me.cboCompany)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 162)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Покупка"
        '
        'txtTotalFeed
        '
        Me.txtTotalFeed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyFeedBindingSource, "Итого", True))
        Me.txtTotalFeed.Location = New System.Drawing.Point(49, 133)
        Me.txtTotalFeed.Name = "txtTotalFeed"
        Me.txtTotalFeed.ReadOnly = True
        Me.txtTotalFeed.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFeed.TabIndex = 10
        '
        'BuyFeedBindingSource
        '
        Me.BuyFeedBindingSource.DataMember = "BuyFeed"
        Me.BuyFeedBindingSource.DataSource = Me.BuyDataSet
        '
        'BuyDataSet
        '
        Me.BuyDataSet.DataSetName = "BuyDataSet"
        Me.BuyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Итого"
        '
        'cmdBuy
        '
        Me.cmdBuy.Location = New System.Drawing.Point(155, 131)
        Me.cmdBuy.Name = "cmdBuy"
        Me.cmdBuy.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuy.TabIndex = 3
        Me.cmdBuy.Text = "Купить"
        Me.cmdBuy.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyFeedBindingSource, "Масса", True))
        Me.txtAmount.Location = New System.Drawing.Point(78, 95)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(98, 20)
        Me.txtAmount.TabIndex = 8
        '
        'cboAnimal
        '
        Me.cboAnimal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyFeedBindingSource, "Для какого животного", True))
        Me.cboAnimal.FormattingEnabled = True
        Me.cboAnimal.Items.AddRange(New Object() {"Собака", "Кошка"})
        Me.cboAnimal.Location = New System.Drawing.Point(135, 12)
        Me.cboAnimal.Name = "cboAnimal"
        Me.cboAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cboAnimal.TabIndex = 0
        '
        'cboViewFeed
        '
        Me.cboViewFeed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyFeedBindingSource, "Какой корм", True))
        Me.cboViewFeed.FormattingEnabled = True
        Me.cboViewFeed.Items.AddRange(New Object() {"Сухой", "Влажный"})
        Me.cboViewFeed.Location = New System.Drawing.Point(79, 39)
        Me.cboViewFeed.Name = "cboViewFeed"
        Me.cboViewFeed.Size = New System.Drawing.Size(121, 21)
        Me.cboViewFeed.TabIndex = 1
        '
        'cboCompany
        '
        Me.cboCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyFeedBindingSource, "Бренд", True))
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(85, 66)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(171, 21)
        Me.cboCompany.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Для какого животного"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Масса" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(в граммах)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Какой корм"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Бренд корма"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 187)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 181)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Данные о покупках"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.КакойКормDataGridViewTextBoxColumn, Me.БрендDataGridViewTextBoxColumn, Me.ДляКакогоЖивотногоDataGridViewTextBoxColumn, Me.МассаDataGridViewTextBoxColumn, Me.ИтогоDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BuyFeedBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(431, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        '
        'КакойКормDataGridViewTextBoxColumn
        '
        Me.КакойКормDataGridViewTextBoxColumn.DataPropertyName = "Какой корм"
        Me.КакойКормDataGridViewTextBoxColumn.HeaderText = "Какой корм"
        Me.КакойКормDataGridViewTextBoxColumn.Name = "КакойКормDataGridViewTextBoxColumn"
        '
        'БрендDataGridViewTextBoxColumn
        '
        Me.БрендDataGridViewTextBoxColumn.DataPropertyName = "Бренд"
        Me.БрендDataGridViewTextBoxColumn.HeaderText = "Бренд"
        Me.БрендDataGridViewTextBoxColumn.Name = "БрендDataGridViewTextBoxColumn"
        '
        'ДляКакогоЖивотногоDataGridViewTextBoxColumn
        '
        Me.ДляКакогоЖивотногоDataGridViewTextBoxColumn.DataPropertyName = "Для какого животного"
        Me.ДляКакогоЖивотногоDataGridViewTextBoxColumn.HeaderText = "Для какого животного"
        Me.ДляКакогоЖивотногоDataGridViewTextBoxColumn.Name = "ДляКакогоЖивотногоDataGridViewTextBoxColumn"
        '
        'МассаDataGridViewTextBoxColumn
        '
        Me.МассаDataGridViewTextBoxColumn.DataPropertyName = "Масса"
        Me.МассаDataGridViewTextBoxColumn.HeaderText = "Масса"
        Me.МассаDataGridViewTextBoxColumn.Name = "МассаDataGridViewTextBoxColumn"
        '
        'ИтогоDataGridViewTextBoxColumn
        '
        Me.ИтогоDataGridViewTextBoxColumn.DataPropertyName = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.HeaderText = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.Name = "ИтогоDataGridViewTextBoxColumn"
        '
        'BuyFeedTableAdapter
        '
        Me.BuyFeedTableAdapter.ClearBeforeFill = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(181, 93)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 11
        Me.cmdCalculate.Text = "Рассчитать"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'frmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 551)
        Me.Controls.Add(Me.tabZooShop)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPharmacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ветаптека"
        Me.Panel1.ResumeLayout(False)
        Me.tabZooShop.ResumeLayout(False)
        Me.tpFeed.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BuyFeedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents lblContacts As System.Windows.Forms.Label
    Friend WithEvents lblPharmacy As System.Windows.Forms.Label
    Friend WithEvents lblRooms As System.Windows.Forms.Label
    Friend WithEvents lblGallery As System.Windows.Forms.Label
    Friend WithEvents tabZooShop As System.Windows.Forms.TabControl
    Friend WithEvents tpFeed As System.Windows.Forms.TabPage
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cboViewFeed As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBuy As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFeed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdBuyFeed As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BuyDataSet As Курсовая.BuyDataSet
    Friend WithEvents BuyFeedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuyFeedTableAdapter As Курсовая.BuyDataSetTableAdapters.BuyFeedTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КакойКормDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents БрендDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ДляКакогоЖивотногоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents МассаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИтогоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdHide As System.Windows.Forms.Button
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
End Class
