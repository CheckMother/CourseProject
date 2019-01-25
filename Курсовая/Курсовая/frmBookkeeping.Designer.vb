<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookkeeping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookkeeping))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblMain = New System.Windows.Forms.Label
        Me.tabBookkeeping = New System.Windows.Forms.TabControl
        Me.tpWage = New System.Windows.Forms.TabPage
        Me.cmdReset = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtSurnname = New System.Windows.Forms.TextBox
        Me.txtPatronymic = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboProfession = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtWasteDay = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtWorkDay = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdBringWage = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.dgvWage = New System.Windows.Forms.DataGridView
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtSurcharges = New System.Windows.Forms.TextBox
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtPremium = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtWage = New System.Windows.Forms.TextBox
        Me.cmdСalculateWage = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.cmdCalculateTotal = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tpCommunal = New System.Windows.Forms.TabPage
        Me.tabCommunal = New System.Windows.Forms.TabControl
        Me.tpGas = New System.Windows.Forms.TabPage
        Me.cmdAddGas = New System.Windows.Forms.Button
        Me.cmdDeleteGas = New System.Windows.Forms.Button
        Me.cmdCalculateGas = New System.Windows.Forms.Button
        Me.cmdBringGas = New System.Windows.Forms.Button
        Me.dgvGas = New System.Windows.Forms.DataGridView
        Me.txtConsumedGas = New System.Windows.Forms.TextBox
        Me.txtRateGas = New System.Windows.Forms.TextBox
        Me.txtCostsGas = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.tpWater = New System.Windows.Forms.TabPage
        Me.cmdAddWater = New System.Windows.Forms.Button
        Me.txtConsumedWater = New System.Windows.Forms.TextBox
        Me.txtRateWater = New System.Windows.Forms.TextBox
        Me.txtCostsWater = New System.Windows.Forms.TextBox
        Me.cmdDeleteWater = New System.Windows.Forms.Button
        Me.cmdCalculateWater = New System.Windows.Forms.Button
        Me.cmdBringWater = New System.Windows.Forms.Button
        Me.dgvWater = New System.Windows.Forms.DataGridView
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.tpElec = New System.Windows.Forms.TabPage
        Me.cmdAddElec = New System.Windows.Forms.Button
        Me.cmdDeleteElec = New System.Windows.Forms.Button
        Me.cmdCalculateElec = New System.Windows.Forms.Button
        Me.cmdBringElec = New System.Windows.Forms.Button
        Me.dgvElec = New System.Windows.Forms.DataGridView
        Me.txtCostsElec = New System.Windows.Forms.TextBox
        Me.txtRateElec = New System.Windows.Forms.TextBox
        Me.txtConsumedElec = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.tpProfit = New System.Windows.Forms.TabPage
        Me.cmdAddProfit = New System.Windows.Forms.Button
        Me.cmdDeleteProfit = New System.Windows.Forms.Button
        Me.cmdCalculateProfit = New System.Windows.Forms.Button
        Me.cmdBringProfit = New System.Windows.Forms.Button
        Me.dgvProfit = New System.Windows.Forms.DataGridView
        Me.txtProfit = New System.Windows.Forms.TextBox
        Me.txtCosts = New System.Windows.Forms.TextBox
        Me.txtRevenue = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BookkeepingBDDataSet = New Курсовая.BookkeepingBDDataSet
        Me.ЗПBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗПTableAdapter = New Курсовая.BookkeepingBDDataSetTableAdapters.ЗПTableAdapter
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ФамилияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИмяDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОтчествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрофессияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НадбавкиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПремияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ОкладDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЗарплатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ИтогоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ГазBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ГазTableAdapter = New Курсовая.BookkeepingBDDataSetTableAdapters.ГазTableAdapter
        Me.КодDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВодаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ВодаTableAdapter = New Курсовая.BookkeepingBDDataSetTableAdapters.ВодаTableAdapter
        Me.КодDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЭлектричествоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЭлектричествоTableAdapter = New Курсовая.BookkeepingBDDataSetTableAdapters.ЭлектричествоTableAdapter
        Me.КодDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПотребленоDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ТарифDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрибыльBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПрибыльTableAdapter = New Курсовая.BookkeepingBDDataSetTableAdapters.ПрибыльTableAdapter
        Me.КодDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ВыручкаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.РасходыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ПрибыльDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.tabBookkeeping.SuspendLayout()
        Me.tpWage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgvWage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.tpCommunal.SuspendLayout()
        Me.tabCommunal.SuspendLayout()
        Me.tpGas.SuspendLayout()
        CType(Me.dgvGas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpWater.SuspendLayout()
        CType(Me.dgvWater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpElec.SuspendLayout()
        CType(Me.dgvElec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpProfit.SuspendLayout()
        CType(Me.dgvProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookkeepingBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗПBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрибыльBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 121)
        Me.Panel1.TabIndex = 10
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.lblMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMain.Image = Global.Курсовая.My.Resources.Resources.layout_set_logo
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(101, 108)
        Me.lblMain.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.lblMain, "Перейти на главную")
        '
        'tabBookkeeping
        '
        Me.tabBookkeeping.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabBookkeeping.Controls.Add(Me.tpWage)
        Me.tabBookkeeping.Controls.Add(Me.tpCommunal)
        Me.tabBookkeeping.Controls.Add(Me.tpProfit)
        Me.tabBookkeeping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabBookkeeping.Location = New System.Drawing.Point(0, 121)
        Me.tabBookkeeping.Name = "tabBookkeeping"
        Me.tabBookkeeping.SelectedIndex = 0
        Me.tabBookkeeping.Size = New System.Drawing.Size(1104, 275)
        Me.tabBookkeeping.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabBookkeeping.TabIndex = 23
        '
        'tpWage
        '
        Me.tpWage.Controls.Add(Me.cmdReset)
        Me.tpWage.Controls.Add(Me.txtSearch)
        Me.tpWage.Controls.Add(Me.cmdSearch)
        Me.tpWage.Controls.Add(Me.GroupBox4)
        Me.tpWage.Controls.Add(Me.GroupBox6)
        Me.tpWage.Controls.Add(Me.GroupBox8)
        Me.tpWage.Controls.Add(Me.GroupBox10)
        Me.tpWage.Location = New System.Drawing.Point(4, 25)
        Me.tpWage.Name = "tpWage"
        Me.tpWage.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWage.Size = New System.Drawing.Size(1096, 246)
        Me.tpWage.TabIndex = 0
        Me.tpWage.Text = "Зарплата"
        Me.tpWage.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(562, 213)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 23)
        Me.cmdReset.TabIndex = 138
        Me.cmdReset.Text = "Сбросить"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(639, 215)
        Me.txtSearch.MaxLength = 20
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(366, 20)
        Me.txtSearch.TabIndex = 133
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(1011, 213)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 132
        Me.cmdSearch.Text = "Поиск"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSurnname)
        Me.GroupBox4.Controls.Add(Me.txtPatronymic)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtName)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 101)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Личный данные"
        '
        'txtSurnname
        '
        Me.txtSurnname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Фамилия", True))
        Me.txtSurnname.Location = New System.Drawing.Point(68, 18)
        Me.txtSurnname.MaxLength = 15
        Me.txtSurnname.Name = "txtSurnname"
        Me.txtSurnname.Size = New System.Drawing.Size(128, 20)
        Me.txtSurnname.TabIndex = 1
        '
        'txtPatronymic
        '
        Me.txtPatronymic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Отчество", True))
        Me.txtPatronymic.Location = New System.Drawing.Point(68, 70)
        Me.txtPatronymic.MaxLength = 15
        Me.txtPatronymic.Name = "txtPatronymic"
        Me.txtPatronymic.Size = New System.Drawing.Size(128, 20)
        Me.txtPatronymic.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Отчество"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Имя", True))
        Me.txtName.Location = New System.Drawing.Point(41, 44)
        Me.txtName.MaxLength = 15
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(128, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Имя"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Фамилия"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.cboProfession)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txtWasteDay)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txtWorkDay)
        Me.GroupBox6.Location = New System.Drawing.Point(226, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(218, 101)
        Me.GroupBox6.TabIndex = 129
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Профессиональные данные"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Количество отработанных дней"
        '
        'cboProfession
        '
        Me.cboProfession.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Профессия", True))
        Me.cboProfession.FormattingEnabled = True
        Me.cboProfession.Items.AddRange(New Object() {"Кипер", "Администратор", "Бухгалтер"})
        Me.cboProfession.Location = New System.Drawing.Point(77, 18)
        Me.cboProfession.Name = "cboProfession"
        Me.cboProfession.Size = New System.Drawing.Size(133, 21)
        Me.cboProfession.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Количество рабочих дней"
        '
        'txtWasteDay
        '
        Me.txtWasteDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Количество отработанных дней", True))
        Me.txtWasteDay.Location = New System.Drawing.Point(179, 71)
        Me.txtWasteDay.MaxLength = 2
        Me.txtWasteDay.Name = "txtWasteDay"
        Me.txtWasteDay.Size = New System.Drawing.Size(26, 20)
        Me.txtWasteDay.TabIndex = 8
        Me.txtWasteDay.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Профессия"
        '
        'txtWorkDay
        '
        Me.txtWorkDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Количество рабочих дней", True))
        Me.txtWorkDay.Location = New System.Drawing.Point(147, 45)
        Me.txtWorkDay.MaxLength = 2
        Me.txtWorkDay.Name = "txtWorkDay"
        Me.txtWorkDay.Size = New System.Drawing.Size(26, 20)
        Me.txtWorkDay.TabIndex = 7
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdAdd)
        Me.GroupBox8.Controls.Add(Me.cmdBringWage)
        Me.GroupBox8.Controls.Add(Me.cmdDelete)
        Me.GroupBox8.Controls.Add(Me.dgvWage)
        Me.GroupBox8.Location = New System.Drawing.Point(561, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(525, 188)
        Me.GroupBox8.TabIndex = 131
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Информация по зарплате персонала"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(159, 155)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 131
        Me.cmdAdd.Text = "Добавить"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdBringWage
        '
        Me.cmdBringWage.Location = New System.Drawing.Point(240, 155)
        Me.cmdBringWage.Name = "cmdBringWage"
        Me.cmdBringWage.Size = New System.Drawing.Size(77, 23)
        Me.cmdBringWage.TabIndex = 122
        Me.cmdBringWage.Text = "Сохранить"
        Me.cmdBringWage.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(323, 155)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(77, 23)
        Me.cmdDelete.TabIndex = 122
        Me.cmdDelete.Text = "Удалить"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'dgvWage
        '
        Me.dgvWage.AutoGenerateColumns = False
        Me.dgvWage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.ФамилияDataGridViewTextBoxColumn, Me.ИмяDataGridViewTextBoxColumn, Me.ОтчествоDataGridViewTextBoxColumn, Me.ПрофессияDataGridViewTextBoxColumn, Me.КоличествоРабочихДнейDataGridViewTextBoxColumn, Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn, Me.НадбавкиDataGridViewTextBoxColumn, Me.ПремияDataGridViewTextBoxColumn, Me.ОкладDataGridViewTextBoxColumn, Me.ЗарплатаDataGridViewTextBoxColumn, Me.ИтогоDataGridViewTextBoxColumn})
        Me.dgvWage.DataSource = Me.ЗПBindingSource
        Me.dgvWage.Location = New System.Drawing.Point(6, 18)
        Me.dgvWage.Name = "dgvWage"
        Me.dgvWage.Size = New System.Drawing.Size(513, 131)
        Me.dgvWage.TabIndex = 130
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox7)
        Me.GroupBox10.Controls.Add(Me.GroupBox5)
        Me.GroupBox10.Controls.Add(Me.GroupBox9)
        Me.GroupBox10.Location = New System.Drawing.Point(11, 110)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(544, 136)
        Me.GroupBox10.TabIndex = 137
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Финансовые данные"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.txtSurcharges)
        Me.GroupBox7.Controls.Add(Me.txtSalary)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(169, 109)
        Me.GroupBox7.TabIndex = 128
        Me.GroupBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Оклад"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 120
        Me.Label26.Text = "Надбавки"
        '
        'txtSurcharges
        '
        Me.txtSurcharges.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Надбавки", True))
        Me.txtSurcharges.Location = New System.Drawing.Point(69, 68)
        Me.txtSurcharges.MaxLength = 7
        Me.txtSurcharges.Name = "txtSurcharges"
        Me.txtSurcharges.Size = New System.Drawing.Size(57, 20)
        Me.txtSurcharges.TabIndex = 5
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Оклад", True))
        Me.txtSalary.Location = New System.Drawing.Point(51, 31)
        Me.txtSalary.MaxLength = 7
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(62, 20)
        Me.txtSalary.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPremium)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtWage)
        Me.GroupBox5.Controls.Add(Me.cmdСalculateWage)
        Me.GroupBox5.Location = New System.Drawing.Point(184, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(166, 109)
        Me.GroupBox5.TabIndex = 128
        Me.GroupBox5.TabStop = False
        '
        'txtPremium
        '
        Me.txtPremium.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Премия", True))
        Me.txtPremium.Location = New System.Drawing.Point(60, 21)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.ReadOnly = True
        Me.txtPremium.Size = New System.Drawing.Size(57, 20)
        Me.txtPremium.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Премия"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Зарплата"
        '
        'txtWage
        '
        Me.txtWage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Зарплата", True))
        Me.txtWage.Location = New System.Drawing.Point(67, 48)
        Me.txtWage.MaxLength = 7
        Me.txtWage.Name = "txtWage"
        Me.txtWage.ReadOnly = True
        Me.txtWage.Size = New System.Drawing.Size(64, 20)
        Me.txtWage.TabIndex = 10
        '
        'cmdСalculateWage
        '
        Me.cmdСalculateWage.Location = New System.Drawing.Point(27, 77)
        Me.cmdСalculateWage.Name = "cmdСalculateWage"
        Me.cmdСalculateWage.Size = New System.Drawing.Size(115, 21)
        Me.cmdСalculateWage.TabIndex = 108
        Me.cmdСalculateWage.Text = "Рассчитать"
        Me.cmdСalculateWage.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cmdCalculateTotal)
        Me.GroupBox9.Controls.Add(Me.txtTotal)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Location = New System.Drawing.Point(356, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(177, 109)
        Me.GroupBox9.TabIndex = 136
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "К расчёту"
        '
        'cmdCalculateTotal
        '
        Me.cmdCalculateTotal.Location = New System.Drawing.Point(32, 77)
        Me.cmdCalculateTotal.Name = "cmdCalculateTotal"
        Me.cmdCalculateTotal.Size = New System.Drawing.Size(115, 21)
        Me.cmdCalculateTotal.TabIndex = 136
        Me.cmdCalculateTotal.Text = "Рассчитать"
        Me.cmdCalculateTotal.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗПBindingSource, "Итого", True))
        Me.txtTotal.Location = New System.Drawing.Point(49, 44)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(80, 20)
        Me.txtTotal.TabIndex = 134
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Итого"
        '
        'tpCommunal
        '
        Me.tpCommunal.Controls.Add(Me.tabCommunal)
        Me.tpCommunal.Location = New System.Drawing.Point(4, 25)
        Me.tpCommunal.Name = "tpCommunal"
        Me.tpCommunal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCommunal.Size = New System.Drawing.Size(1096, 246)
        Me.tpCommunal.TabIndex = 1
        Me.tpCommunal.Text = "Комм. услуги"
        Me.tpCommunal.UseVisualStyleBackColor = True
        '
        'tabCommunal
        '
        Me.tabCommunal.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabCommunal.Controls.Add(Me.tpGas)
        Me.tabCommunal.Controls.Add(Me.tpWater)
        Me.tabCommunal.Controls.Add(Me.tpElec)
        Me.tabCommunal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCommunal.Location = New System.Drawing.Point(3, 3)
        Me.tabCommunal.Name = "tabCommunal"
        Me.tabCommunal.SelectedIndex = 0
        Me.tabCommunal.Size = New System.Drawing.Size(1090, 240)
        Me.tabCommunal.TabIndex = 0
        '
        'tpGas
        '
        Me.tpGas.Controls.Add(Me.cmdAddGas)
        Me.tpGas.Controls.Add(Me.cmdDeleteGas)
        Me.tpGas.Controls.Add(Me.cmdCalculateGas)
        Me.tpGas.Controls.Add(Me.cmdBringGas)
        Me.tpGas.Controls.Add(Me.dgvGas)
        Me.tpGas.Controls.Add(Me.txtConsumedGas)
        Me.tpGas.Controls.Add(Me.txtRateGas)
        Me.tpGas.Controls.Add(Me.txtCostsGas)
        Me.tpGas.Controls.Add(Me.Label14)
        Me.tpGas.Controls.Add(Me.Label15)
        Me.tpGas.Controls.Add(Me.Label16)
        Me.tpGas.Location = New System.Drawing.Point(4, 25)
        Me.tpGas.Name = "tpGas"
        Me.tpGas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGas.Size = New System.Drawing.Size(1082, 211)
        Me.tpGas.TabIndex = 0
        Me.tpGas.Text = "Газ"
        Me.tpGas.UseVisualStyleBackColor = True
        '
        'cmdAddGas
        '
        Me.cmdAddGas.Location = New System.Drawing.Point(109, 112)
        Me.cmdAddGas.Name = "cmdAddGas"
        Me.cmdAddGas.Size = New System.Drawing.Size(84, 23)
        Me.cmdAddGas.TabIndex = 33
        Me.cmdAddGas.Text = "Добавить"
        Me.cmdAddGas.UseVisualStyleBackColor = True
        '
        'cmdDeleteGas
        '
        Me.cmdDeleteGas.Location = New System.Drawing.Point(108, 82)
        Me.cmdDeleteGas.Name = "cmdDeleteGas"
        Me.cmdDeleteGas.Size = New System.Drawing.Size(85, 23)
        Me.cmdDeleteGas.TabIndex = 32
        Me.cmdDeleteGas.Text = "Удалить"
        Me.cmdDeleteGas.UseVisualStyleBackColor = True
        '
        'cmdCalculateGas
        '
        Me.cmdCalculateGas.Location = New System.Drawing.Point(9, 82)
        Me.cmdCalculateGas.Name = "cmdCalculateGas"
        Me.cmdCalculateGas.Size = New System.Drawing.Size(93, 23)
        Me.cmdCalculateGas.TabIndex = 31
        Me.cmdCalculateGas.Text = "Рассчитать"
        Me.cmdCalculateGas.UseVisualStyleBackColor = True
        '
        'cmdBringGas
        '
        Me.cmdBringGas.Location = New System.Drawing.Point(9, 111)
        Me.cmdBringGas.Name = "cmdBringGas"
        Me.cmdBringGas.Size = New System.Drawing.Size(93, 23)
        Me.cmdBringGas.TabIndex = 30
        Me.cmdBringGas.Text = "Сохранить"
        Me.cmdBringGas.UseVisualStyleBackColor = True
        '
        'dgvGas
        '
        Me.dgvGas.AutoGenerateColumns = False
        Me.dgvGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn1, Me.ПотребленоDataGridViewTextBoxColumn, Me.ТарифDataGridViewTextBoxColumn, Me.РасходDataGridViewTextBoxColumn})
        Me.dgvGas.DataSource = Me.ГазBindingSource
        Me.dgvGas.Location = New System.Drawing.Point(199, 10)
        Me.dgvGas.Name = "dgvGas"
        Me.dgvGas.Size = New System.Drawing.Size(380, 124)
        Me.dgvGas.TabIndex = 29
        '
        'txtConsumedGas
        '
        Me.txtConsumedGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Потреблено", True))
        Me.txtConsumedGas.Location = New System.Drawing.Point(80, 10)
        Me.txtConsumedGas.MaxLength = 5
        Me.txtConsumedGas.Name = "txtConsumedGas"
        Me.txtConsumedGas.Size = New System.Drawing.Size(113, 20)
        Me.txtConsumedGas.TabIndex = 28
        '
        'txtRateGas
        '
        Me.txtRateGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Тариф", True))
        Me.txtRateGas.Location = New System.Drawing.Point(80, 33)
        Me.txtRateGas.MaxLength = 3
        Me.txtRateGas.Name = "txtRateGas"
        Me.txtRateGas.Size = New System.Drawing.Size(113, 20)
        Me.txtRateGas.TabIndex = 27
        '
        'txtCostsGas
        '
        Me.txtCostsGas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ГазBindingSource, "Расход", True))
        Me.txtCostsGas.Location = New System.Drawing.Point(80, 56)
        Me.txtCostsGas.Name = "txtCostsGas"
        Me.txtCostsGas.ReadOnly = True
        Me.txtCostsGas.Size = New System.Drawing.Size(113, 20)
        Me.txtCostsGas.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Расходы"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Тариф"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Потреблено"
        '
        'tpWater
        '
        Me.tpWater.Controls.Add(Me.cmdAddWater)
        Me.tpWater.Controls.Add(Me.txtConsumedWater)
        Me.tpWater.Controls.Add(Me.txtRateWater)
        Me.tpWater.Controls.Add(Me.txtCostsWater)
        Me.tpWater.Controls.Add(Me.cmdDeleteWater)
        Me.tpWater.Controls.Add(Me.cmdCalculateWater)
        Me.tpWater.Controls.Add(Me.cmdBringWater)
        Me.tpWater.Controls.Add(Me.dgvWater)
        Me.tpWater.Controls.Add(Me.Label11)
        Me.tpWater.Controls.Add(Me.Label12)
        Me.tpWater.Controls.Add(Me.Label13)
        Me.tpWater.Location = New System.Drawing.Point(4, 25)
        Me.tpWater.Name = "tpWater"
        Me.tpWater.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWater.Size = New System.Drawing.Size(1082, 211)
        Me.tpWater.TabIndex = 1
        Me.tpWater.Text = "Вода"
        Me.tpWater.UseVisualStyleBackColor = True
        '
        'cmdAddWater
        '
        Me.cmdAddWater.Location = New System.Drawing.Point(108, 111)
        Me.cmdAddWater.Name = "cmdAddWater"
        Me.cmdAddWater.Size = New System.Drawing.Size(84, 23)
        Me.cmdAddWater.TabIndex = 46
        Me.cmdAddWater.Text = "Добавить"
        Me.cmdAddWater.UseVisualStyleBackColor = True
        '
        'txtConsumedWater
        '
        Me.txtConsumedWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Потреблено", True))
        Me.txtConsumedWater.Location = New System.Drawing.Point(80, 10)
        Me.txtConsumedWater.MaxLength = 5
        Me.txtConsumedWater.Name = "txtConsumedWater"
        Me.txtConsumedWater.Size = New System.Drawing.Size(113, 20)
        Me.txtConsumedWater.TabIndex = 45
        '
        'txtRateWater
        '
        Me.txtRateWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Тариф", True))
        Me.txtRateWater.Location = New System.Drawing.Point(80, 33)
        Me.txtRateWater.MaxLength = 3
        Me.txtRateWater.Name = "txtRateWater"
        Me.txtRateWater.Size = New System.Drawing.Size(113, 20)
        Me.txtRateWater.TabIndex = 44
        '
        'txtCostsWater
        '
        Me.txtCostsWater.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ВодаBindingSource, "Расход", True))
        Me.txtCostsWater.Location = New System.Drawing.Point(80, 56)
        Me.txtCostsWater.Name = "txtCostsWater"
        Me.txtCostsWater.ReadOnly = True
        Me.txtCostsWater.Size = New System.Drawing.Size(113, 20)
        Me.txtCostsWater.TabIndex = 43
        '
        'cmdDeleteWater
        '
        Me.cmdDeleteWater.Location = New System.Drawing.Point(108, 82)
        Me.cmdDeleteWater.Name = "cmdDeleteWater"
        Me.cmdDeleteWater.Size = New System.Drawing.Size(85, 23)
        Me.cmdDeleteWater.TabIndex = 42
        Me.cmdDeleteWater.Text = "Удалить"
        Me.cmdDeleteWater.UseVisualStyleBackColor = True
        '
        'cmdCalculateWater
        '
        Me.cmdCalculateWater.Location = New System.Drawing.Point(9, 82)
        Me.cmdCalculateWater.Name = "cmdCalculateWater"
        Me.cmdCalculateWater.Size = New System.Drawing.Size(93, 23)
        Me.cmdCalculateWater.TabIndex = 41
        Me.cmdCalculateWater.Text = "Рассчитать"
        Me.cmdCalculateWater.UseVisualStyleBackColor = True
        '
        'cmdBringWater
        '
        Me.cmdBringWater.Location = New System.Drawing.Point(9, 111)
        Me.cmdBringWater.Name = "cmdBringWater"
        Me.cmdBringWater.Size = New System.Drawing.Size(93, 23)
        Me.cmdBringWater.TabIndex = 40
        Me.cmdBringWater.Text = "Сохранить"
        Me.cmdBringWater.UseVisualStyleBackColor = True
        '
        'dgvWater
        '
        Me.dgvWater.AutoGenerateColumns = False
        Me.dgvWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWater.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn2, Me.ПотребленоDataGridViewTextBoxColumn1, Me.ТарифDataGridViewTextBoxColumn1, Me.РасходDataGridViewTextBoxColumn1})
        Me.dgvWater.DataSource = Me.ВодаBindingSource
        Me.dgvWater.Location = New System.Drawing.Point(199, 10)
        Me.dgvWater.Name = "dgvWater"
        Me.dgvWater.Size = New System.Drawing.Size(380, 124)
        Me.dgvWater.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Расходы"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Тариф"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Потреблено"
        '
        'tpElec
        '
        Me.tpElec.Controls.Add(Me.cmdAddElec)
        Me.tpElec.Controls.Add(Me.cmdDeleteElec)
        Me.tpElec.Controls.Add(Me.cmdCalculateElec)
        Me.tpElec.Controls.Add(Me.cmdBringElec)
        Me.tpElec.Controls.Add(Me.dgvElec)
        Me.tpElec.Controls.Add(Me.txtCostsElec)
        Me.tpElec.Controls.Add(Me.txtRateElec)
        Me.tpElec.Controls.Add(Me.txtConsumedElec)
        Me.tpElec.Controls.Add(Me.Label22)
        Me.tpElec.Controls.Add(Me.Label23)
        Me.tpElec.Controls.Add(Me.Label24)
        Me.tpElec.Location = New System.Drawing.Point(4, 25)
        Me.tpElec.Name = "tpElec"
        Me.tpElec.Size = New System.Drawing.Size(1082, 211)
        Me.tpElec.TabIndex = 2
        Me.tpElec.Text = "Электричество"
        Me.tpElec.UseVisualStyleBackColor = True
        '
        'cmdAddElec
        '
        Me.cmdAddElec.Location = New System.Drawing.Point(108, 111)
        Me.cmdAddElec.Name = "cmdAddElec"
        Me.cmdAddElec.Size = New System.Drawing.Size(84, 23)
        Me.cmdAddElec.TabIndex = 47
        Me.cmdAddElec.Text = "Добавить"
        Me.cmdAddElec.UseVisualStyleBackColor = True
        '
        'cmdDeleteElec
        '
        Me.cmdDeleteElec.Location = New System.Drawing.Point(108, 82)
        Me.cmdDeleteElec.Name = "cmdDeleteElec"
        Me.cmdDeleteElec.Size = New System.Drawing.Size(85, 23)
        Me.cmdDeleteElec.TabIndex = 46
        Me.cmdDeleteElec.Text = "Удалить"
        Me.cmdDeleteElec.UseVisualStyleBackColor = True
        '
        'cmdCalculateElec
        '
        Me.cmdCalculateElec.Location = New System.Drawing.Point(9, 82)
        Me.cmdCalculateElec.Name = "cmdCalculateElec"
        Me.cmdCalculateElec.Size = New System.Drawing.Size(93, 23)
        Me.cmdCalculateElec.TabIndex = 45
        Me.cmdCalculateElec.Text = "Рассчитать"
        Me.cmdCalculateElec.UseVisualStyleBackColor = True
        '
        'cmdBringElec
        '
        Me.cmdBringElec.Location = New System.Drawing.Point(9, 111)
        Me.cmdBringElec.Name = "cmdBringElec"
        Me.cmdBringElec.Size = New System.Drawing.Size(93, 23)
        Me.cmdBringElec.TabIndex = 44
        Me.cmdBringElec.Text = "Сохранить"
        Me.cmdBringElec.UseVisualStyleBackColor = True
        '
        'dgvElec
        '
        Me.dgvElec.AutoGenerateColumns = False
        Me.dgvElec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn3, Me.ПотребленоDataGridViewTextBoxColumn2, Me.ТарифDataGridViewTextBoxColumn2, Me.РасходDataGridViewTextBoxColumn2})
        Me.dgvElec.DataSource = Me.ЭлектричествоBindingSource
        Me.dgvElec.Location = New System.Drawing.Point(199, 10)
        Me.dgvElec.Name = "dgvElec"
        Me.dgvElec.Size = New System.Drawing.Size(380, 124)
        Me.dgvElec.TabIndex = 43
        '
        'txtCostsElec
        '
        Me.txtCostsElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Расход", True))
        Me.txtCostsElec.Location = New System.Drawing.Point(80, 56)
        Me.txtCostsElec.Name = "txtCostsElec"
        Me.txtCostsElec.ReadOnly = True
        Me.txtCostsElec.Size = New System.Drawing.Size(113, 20)
        Me.txtCostsElec.TabIndex = 11
        '
        'txtRateElec
        '
        Me.txtRateElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Тариф", True))
        Me.txtRateElec.Location = New System.Drawing.Point(80, 33)
        Me.txtRateElec.MaxLength = 3
        Me.txtRateElec.Name = "txtRateElec"
        Me.txtRateElec.Size = New System.Drawing.Size(113, 20)
        Me.txtRateElec.TabIndex = 10
        '
        'txtConsumedElec
        '
        Me.txtConsumedElec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЭлектричествоBindingSource, "Потреблено", True))
        Me.txtConsumedElec.Location = New System.Drawing.Point(80, 10)
        Me.txtConsumedElec.MaxLength = 5
        Me.txtConsumedElec.Name = "txtConsumedElec"
        Me.txtConsumedElec.Size = New System.Drawing.Size(113, 20)
        Me.txtConsumedElec.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Расходы"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Тариф"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Потреблено"
        '
        'tpProfit
        '
        Me.tpProfit.Controls.Add(Me.cmdAddProfit)
        Me.tpProfit.Controls.Add(Me.cmdDeleteProfit)
        Me.tpProfit.Controls.Add(Me.cmdCalculateProfit)
        Me.tpProfit.Controls.Add(Me.cmdBringProfit)
        Me.tpProfit.Controls.Add(Me.dgvProfit)
        Me.tpProfit.Controls.Add(Me.txtProfit)
        Me.tpProfit.Controls.Add(Me.txtCosts)
        Me.tpProfit.Controls.Add(Me.txtRevenue)
        Me.tpProfit.Controls.Add(Me.Label17)
        Me.tpProfit.Controls.Add(Me.Label18)
        Me.tpProfit.Controls.Add(Me.Label19)
        Me.tpProfit.Location = New System.Drawing.Point(4, 25)
        Me.tpProfit.Name = "tpProfit"
        Me.tpProfit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProfit.Size = New System.Drawing.Size(1096, 246)
        Me.tpProfit.TabIndex = 2
        Me.tpProfit.Text = "Прибыль"
        Me.tpProfit.UseVisualStyleBackColor = True
        '
        'cmdAddProfit
        '
        Me.cmdAddProfit.Location = New System.Drawing.Point(90, 117)
        Me.cmdAddProfit.Name = "cmdAddProfit"
        Me.cmdAddProfit.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddProfit.TabIndex = 50
        Me.cmdAddProfit.Text = "Добавить"
        Me.cmdAddProfit.UseVisualStyleBackColor = True
        '
        'cmdDeleteProfit
        '
        Me.cmdDeleteProfit.Location = New System.Drawing.Point(90, 88)
        Me.cmdDeleteProfit.Name = "cmdDeleteProfit"
        Me.cmdDeleteProfit.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteProfit.TabIndex = 49
        Me.cmdDeleteProfit.Text = "Удалить"
        Me.cmdDeleteProfit.UseVisualStyleBackColor = True
        '
        'cmdCalculateProfit
        '
        Me.cmdCalculateProfit.Location = New System.Drawing.Point(11, 88)
        Me.cmdCalculateProfit.Name = "cmdCalculateProfit"
        Me.cmdCalculateProfit.Size = New System.Drawing.Size(73, 23)
        Me.cmdCalculateProfit.TabIndex = 48
        Me.cmdCalculateProfit.Text = "Рассчитать"
        Me.cmdCalculateProfit.UseVisualStyleBackColor = True
        '
        'cmdBringProfit
        '
        Me.cmdBringProfit.Location = New System.Drawing.Point(11, 117)
        Me.cmdBringProfit.Name = "cmdBringProfit"
        Me.cmdBringProfit.Size = New System.Drawing.Size(73, 23)
        Me.cmdBringProfit.TabIndex = 47
        Me.cmdBringProfit.Text = "Сохранить"
        Me.cmdBringProfit.UseVisualStyleBackColor = True
        '
        'dgvProfit
        '
        Me.dgvProfit.AutoGenerateColumns = False
        Me.dgvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn4, Me.ВыручкаDataGridViewTextBoxColumn, Me.РасходыDataGridViewTextBoxColumn, Me.ПрибыльDataGridViewTextBoxColumn})
        Me.dgvProfit.DataSource = Me.ПрибыльBindingSource
        Me.dgvProfit.Location = New System.Drawing.Point(171, 10)
        Me.dgvProfit.Name = "dgvProfit"
        Me.dgvProfit.Size = New System.Drawing.Size(380, 124)
        Me.dgvProfit.TabIndex = 17
        '
        'txtProfit
        '
        Me.txtProfit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрибыльBindingSource, "Прибыль", True))
        Me.txtProfit.Location = New System.Drawing.Point(65, 62)
        Me.txtProfit.MaxLength = 8
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.ReadOnly = True
        Me.txtProfit.Size = New System.Drawing.Size(100, 20)
        Me.txtProfit.TabIndex = 16
        '
        'txtCosts
        '
        Me.txtCosts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрибыльBindingSource, "Расходы", True))
        Me.txtCosts.Location = New System.Drawing.Point(65, 35)
        Me.txtCosts.MaxLength = 8
        Me.txtCosts.Name = "txtCosts"
        Me.txtCosts.Size = New System.Drawing.Size(100, 20)
        Me.txtCosts.TabIndex = 14
        '
        'txtRevenue
        '
        Me.txtRevenue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ПрибыльBindingSource, "Выручка", True))
        Me.txtRevenue.Location = New System.Drawing.Point(65, 10)
        Me.txtRevenue.MaxLength = 8
        Me.txtRevenue.Name = "txtRevenue"
        Me.txtRevenue.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenue.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Прибыль"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Расходы"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Выручка"
        '
        'BookkeepingBDDataSet
        '
        Me.BookkeepingBDDataSet.DataSetName = "BookkeepingBDDataSet"
        Me.BookkeepingBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗПBindingSource
        '
        Me.ЗПBindingSource.DataMember = "ЗП"
        Me.ЗПBindingSource.DataSource = Me.BookkeepingBDDataSet
        '
        'ЗПTableAdapter
        '
        Me.ЗПTableAdapter.ClearBeforeFill = True
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
        'ПрофессияDataGridViewTextBoxColumn
        '
        Me.ПрофессияDataGridViewTextBoxColumn.DataPropertyName = "Профессия"
        Me.ПрофессияDataGridViewTextBoxColumn.HeaderText = "Профессия"
        Me.ПрофессияDataGridViewTextBoxColumn.Name = "ПрофессияDataGridViewTextBoxColumn"
        '
        'КоличествоРабочихДнейDataGridViewTextBoxColumn
        '
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество рабочих дней"
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.HeaderText = "Количество рабочих дней"
        Me.КоличествоРабочихДнейDataGridViewTextBoxColumn.Name = "КоличествоРабочихДнейDataGridViewTextBoxColumn"
        '
        'КоличествоОтработанныхДнейDataGridViewTextBoxColumn
        '
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество отработанных дней"
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.HeaderText = "Количество отработанных дней"
        Me.КоличествоОтработанныхДнейDataGridViewTextBoxColumn.Name = "КоличествоОтработанныхДнейDataGridViewTextBoxColumn"
        '
        'НадбавкиDataGridViewTextBoxColumn
        '
        Me.НадбавкиDataGridViewTextBoxColumn.DataPropertyName = "Надбавки"
        Me.НадбавкиDataGridViewTextBoxColumn.HeaderText = "Надбавки"
        Me.НадбавкиDataGridViewTextBoxColumn.Name = "НадбавкиDataGridViewTextBoxColumn"
        '
        'ПремияDataGridViewTextBoxColumn
        '
        Me.ПремияDataGridViewTextBoxColumn.DataPropertyName = "Премия"
        Me.ПремияDataGridViewTextBoxColumn.HeaderText = "Премия"
        Me.ПремияDataGridViewTextBoxColumn.Name = "ПремияDataGridViewTextBoxColumn"
        '
        'ОкладDataGridViewTextBoxColumn
        '
        Me.ОкладDataGridViewTextBoxColumn.DataPropertyName = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.HeaderText = "Оклад"
        Me.ОкладDataGridViewTextBoxColumn.Name = "ОкладDataGridViewTextBoxColumn"
        '
        'ЗарплатаDataGridViewTextBoxColumn
        '
        Me.ЗарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата"
        Me.ЗарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата"
        Me.ЗарплатаDataGridViewTextBoxColumn.Name = "ЗарплатаDataGridViewTextBoxColumn"
        '
        'ИтогоDataGridViewTextBoxColumn
        '
        Me.ИтогоDataGridViewTextBoxColumn.DataPropertyName = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.HeaderText = "Итого"
        Me.ИтогоDataGridViewTextBoxColumn.Name = "ИтогоDataGridViewTextBoxColumn"
        '
        'ГазBindingSource
        '
        Me.ГазBindingSource.DataMember = "Газ"
        Me.ГазBindingSource.DataSource = Me.BookkeepingBDDataSet
        '
        'ГазTableAdapter
        '
        Me.ГазTableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn1
        '
        Me.КодDataGridViewTextBoxColumn1.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn1.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn1.Name = "КодDataGridViewTextBoxColumn1"
        '
        'ПотребленоDataGridViewTextBoxColumn
        '
        Me.ПотребленоDataGridViewTextBoxColumn.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn.Name = "ПотребленоDataGridViewTextBoxColumn"
        '
        'ТарифDataGridViewTextBoxColumn
        '
        Me.ТарифDataGridViewTextBoxColumn.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn.Name = "ТарифDataGridViewTextBoxColumn"
        '
        'РасходDataGridViewTextBoxColumn
        '
        Me.РасходDataGridViewTextBoxColumn.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn.Name = "РасходDataGridViewTextBoxColumn"
        '
        'ВодаBindingSource
        '
        Me.ВодаBindingSource.DataMember = "Вода"
        Me.ВодаBindingSource.DataSource = Me.BookkeepingBDDataSet
        '
        'ВодаTableAdapter
        '
        Me.ВодаTableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn2
        '
        Me.КодDataGridViewTextBoxColumn2.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn2.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn2.Name = "КодDataGridViewTextBoxColumn2"
        '
        'ПотребленоDataGridViewTextBoxColumn1
        '
        Me.ПотребленоDataGridViewTextBoxColumn1.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn1.Name = "ПотребленоDataGridViewTextBoxColumn1"
        '
        'ТарифDataGridViewTextBoxColumn1
        '
        Me.ТарифDataGridViewTextBoxColumn1.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn1.Name = "ТарифDataGridViewTextBoxColumn1"
        '
        'РасходDataGridViewTextBoxColumn1
        '
        Me.РасходDataGridViewTextBoxColumn1.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn1.Name = "РасходDataGridViewTextBoxColumn1"
        '
        'ЭлектричествоBindingSource
        '
        Me.ЭлектричествоBindingSource.DataMember = "Электричество"
        Me.ЭлектричествоBindingSource.DataSource = Me.BookkeepingBDDataSet
        '
        'ЭлектричествоTableAdapter
        '
        Me.ЭлектричествоTableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn3
        '
        Me.КодDataGridViewTextBoxColumn3.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn3.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn3.Name = "КодDataGridViewTextBoxColumn3"
        '
        'ПотребленоDataGridViewTextBoxColumn2
        '
        Me.ПотребленоDataGridViewTextBoxColumn2.DataPropertyName = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.HeaderText = "Потреблено"
        Me.ПотребленоDataGridViewTextBoxColumn2.Name = "ПотребленоDataGridViewTextBoxColumn2"
        '
        'ТарифDataGridViewTextBoxColumn2
        '
        Me.ТарифDataGridViewTextBoxColumn2.DataPropertyName = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.HeaderText = "Тариф"
        Me.ТарифDataGridViewTextBoxColumn2.Name = "ТарифDataGridViewTextBoxColumn2"
        '
        'РасходDataGridViewTextBoxColumn2
        '
        Me.РасходDataGridViewTextBoxColumn2.DataPropertyName = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.HeaderText = "Расход"
        Me.РасходDataGridViewTextBoxColumn2.Name = "РасходDataGridViewTextBoxColumn2"
        '
        'ПрибыльBindingSource
        '
        Me.ПрибыльBindingSource.DataMember = "Прибыль"
        Me.ПрибыльBindingSource.DataSource = Me.BookkeepingBDDataSet
        '
        'ПрибыльTableAdapter
        '
        Me.ПрибыльTableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn4
        '
        Me.КодDataGridViewTextBoxColumn4.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn4.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn4.Name = "КодDataGridViewTextBoxColumn4"
        '
        'ВыручкаDataGridViewTextBoxColumn
        '
        Me.ВыручкаDataGridViewTextBoxColumn.DataPropertyName = "Выручка"
        Me.ВыручкаDataGridViewTextBoxColumn.HeaderText = "Выручка"
        Me.ВыручкаDataGridViewTextBoxColumn.Name = "ВыручкаDataGridViewTextBoxColumn"
        '
        'РасходыDataGridViewTextBoxColumn
        '
        Me.РасходыDataGridViewTextBoxColumn.DataPropertyName = "Расходы"
        Me.РасходыDataGridViewTextBoxColumn.HeaderText = "Расходы"
        Me.РасходыDataGridViewTextBoxColumn.Name = "РасходыDataGridViewTextBoxColumn"
        '
        'ПрибыльDataGridViewTextBoxColumn
        '
        Me.ПрибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль"
        Me.ПрибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль"
        Me.ПрибыльDataGridViewTextBoxColumn.Name = "ПрибыльDataGridViewTextBoxColumn"
        '
        'frmBookkeeping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 396)
        Me.Controls.Add(Me.tabBookkeeping)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBookkeeping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Бухгалтерия"
        Me.Panel1.ResumeLayout(False)
        Me.tabBookkeeping.ResumeLayout(False)
        Me.tpWage.ResumeLayout(False)
        Me.tpWage.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgvWage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tpCommunal.ResumeLayout(False)
        Me.tabCommunal.ResumeLayout(False)
        Me.tpGas.ResumeLayout(False)
        Me.tpGas.PerformLayout()
        CType(Me.dgvGas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpWater.ResumeLayout(False)
        Me.tpWater.PerformLayout()
        CType(Me.dgvWater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpElec.ResumeLayout(False)
        Me.tpElec.PerformLayout()
        CType(Me.dgvElec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpProfit.ResumeLayout(False)
        Me.tpProfit.PerformLayout()
        CType(Me.dgvProfit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookkeepingBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗПBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ГазBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВодаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЭлектричествоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрибыльBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents tabBookkeeping As System.Windows.Forms.TabControl
    Friend WithEvents tpWage As System.Windows.Forms.TabPage
    Friend WithEvents cboProfession As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBringWage As System.Windows.Forms.Button
    Friend WithEvents txtWage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtWasteDay As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkDay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPatronymic As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSurnname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdСalculateWage As System.Windows.Forms.Button
    Friend WithEvents tpCommunal As System.Windows.Forms.TabPage
    Friend WithEvents tpProfit As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvWage As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtSurcharges As System.Windows.Forms.TextBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents tabCommunal As System.Windows.Forms.TabControl
    Friend WithEvents tpGas As System.Windows.Forms.TabPage
    Friend WithEvents tpWater As System.Windows.Forms.TabPage
    Friend WithEvents tpElec As System.Windows.Forms.TabPage
    Friend WithEvents dgvGas As System.Windows.Forms.DataGridView
    Friend WithEvents txtConsumedGas As System.Windows.Forms.TextBox
    Friend WithEvents txtRateGas As System.Windows.Forms.TextBox
    Friend WithEvents txtCostsGas As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteGas As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateGas As System.Windows.Forms.Button
    Friend WithEvents cmdBringGas As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteWater As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateWater As System.Windows.Forms.Button
    Friend WithEvents cmdBringWater As System.Windows.Forms.Button
    Friend WithEvents dgvWater As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtConsumedWater As System.Windows.Forms.TextBox
    Friend WithEvents txtRateWater As System.Windows.Forms.TextBox
    Friend WithEvents txtCostsWater As System.Windows.Forms.TextBox
    Friend WithEvents txtCostsElec As System.Windows.Forms.TextBox
    Friend WithEvents txtRateElec As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumedElec As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteElec As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateElec As System.Windows.Forms.Button
    Friend WithEvents cmdBringElec As System.Windows.Forms.Button
    Friend WithEvents dgvElec As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDeleteProfit As System.Windows.Forms.Button
    Friend WithEvents cmdCalculateProfit As System.Windows.Forms.Button
    Friend WithEvents cmdBringProfit As System.Windows.Forms.Button
    Friend WithEvents dgvProfit As System.Windows.Forms.DataGridView
    Friend WithEvents txtProfit As System.Windows.Forms.TextBox
    Friend WithEvents txtCosts As System.Windows.Forms.TextBox
    Friend WithEvents txtRevenue As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdAddGas As System.Windows.Forms.Button
    Friend WithEvents cmdAddWater As System.Windows.Forms.Button
    Friend WithEvents cmdAddElec As System.Windows.Forms.Button
    Friend WithEvents cmdAddProfit As System.Windows.Forms.Button
    Friend WithEvents txtPremium As System.Windows.Forms.TextBox
    Friend WithEvents BookkeepingBDDataSet As Курсовая.BookkeepingBDDataSet
    Friend WithEvents ЗПBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗПTableAdapter As Курсовая.BookkeepingBDDataSetTableAdapters.ЗПTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ФамилияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИмяDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОтчествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрофессияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоРабочихДнейDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоОтработанныхДнейDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НадбавкиDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПремияDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ОкладDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЗарплатаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ИтогоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГазBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ГазTableAdapter As Курсовая.BookkeepingBDDataSetTableAdapters.ГазTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВодаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ВодаTableAdapter As Курсовая.BookkeepingBDDataSetTableAdapters.ВодаTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЭлектричествоBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЭлектричествоTableAdapter As Курсовая.BookkeepingBDDataSetTableAdapters.ЭлектричествоTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПотребленоDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ТарифDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрибыльBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПрибыльTableAdapter As Курсовая.BookkeepingBDDataSetTableAdapters.ПрибыльTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ВыручкаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents РасходыDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ПрибыльDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
