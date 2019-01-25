Imports System.Data
Imports System.Data.OleDb
Public Class frmBookkeeping

    Dim result As DialogResult
    Private Sub frmBookkeeping_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub

    Private Sub frmBookkeeping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingBDDataSet.Прибыль". При необходимости она может быть перемещена или удалена.
        Me.ПрибыльTableAdapter.Fill(Me.BookkeepingBDDataSet.Прибыль)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingBDDataSet.Электричество". При необходимости она может быть перемещена или удалена.
        Me.ЭлектричествоTableAdapter.Fill(Me.BookkeepingBDDataSet.Электричество)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingBDDataSet.Вода". При необходимости она может быть перемещена или удалена.
        Me.ВодаTableAdapter.Fill(Me.BookkeepingBDDataSet.Вода)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingBDDataSet.Газ". При необходимости она может быть перемещена или удалена.
        Me.ГазTableAdapter.Fill(Me.BookkeepingBDDataSet.Газ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BookkeepingBDDataSet.ЗП". При необходимости она может быть перемещена или удалена.
        Me.ЗПTableAdapter.Fill(Me.BookkeepingBDDataSet.ЗП)
        With dgvWage
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        With dgvGas
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        With dgvWater
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        With dgvElec
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
        With dgvProfit
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    'Увеличение вкладок при нажатии
    Private Sub tpCommunal_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpCommunal.Enter
        If tabBookkeeping.SelectedTab Is tpCommunal Then
            Me.Width = 618
            Me.Height = 359
        End If
    End Sub

    Private Sub tpWage_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpWage.Enter
        If tabBookkeeping.SelectedTab Is tpWage Then
            Me.Width = 1106
            Me.Height = 434
        End If
    End Sub

    Private Sub tpProfit_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpProfit.Enter
        If tabBookkeeping.SelectedTab Is tpProfit Then
            Me.Width = 574
            Me.Height = 322
        End If
    End Sub


    'Код, относящийся к 1 вкладке


    'Занесение данных в базу о зарплате персонала
    Private Sub cmdBringWage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBringWage.Click
        Try
            ЗПBindingSource.EndEdit()
            ЗПTableAdapter.Update(BookkeepingBDDataSet.ЗП)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Добавление новой строчки
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ЗПBindingSource.AddNew()
    End Sub
    'Удалить запись из базы
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ЗПBindingSource.RemoveCurrent()
            ЗПTableAdapter.Update(BookkeepingBDDataSet.ЗП)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub
    'Поиск по базе
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If txtSearch.Text = "" Then
                Exit Sub
            Else
                Dim cantFine As String = txtSearch.Text
                ЗПBindingSource.Filter = "(Convert(Код, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Фамилия LIKE '" & txtSearch.Text & "') OR (Имя LIKE '" & txtSearch.Text & "')" & _
                "OR (Отчество LIKE '" & txtSearch.Text & "') OR (Профессия LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Оклад, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Зарплата, 'System.String') LIKE '" & txtSearch.Text & "')"

                'Если что-то, искомое выше, нашлось в базе данных, тогда вывести информацию об этом в DataGridView

                If ЗПBindingSource.Count <> 0 Then
                    With dgvWage
                        .DataSource = ЗПBindingSource
                    End With

                    'Иначе выдать сообщение об отсутсвии

                Else
                    MsgBox("Элемент " & cantFine & " не найден", MsgBoxStyle.Information, "Поиск")
                    ЗПBindingSource.Filter = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Сбросить настройки поиска
    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Try
            txtSearch.Clear()
            ЗПBindingSource.Filter = Nothing

            With dgvWage
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = ЗПBindingSource
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdСalculateWage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdСalculateWage.Click
        'Расчет зарплаты и премии
        Dim pr As Integer
        txtWage.Text = Val(txtSalary.Text) / Val(txtWorkDay.Text) * Val(txtWasteDay.Text)
        pr = txtWage.Text * 0.13
        txtWage.Text = txtWage.Text - pr
        txtPremium.Text = Val(txtSalary.Text) * 0.2
    End Sub

    Private Sub cmdCalculateTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateTotal.Click
        'К расчету
        txtTotal.Text = Val(txtPremium.Text) + Val(txtWage.Text) + Val(txtSurcharges.Text)
    End Sub
    'Код, относящийся к 2 вкладке


    'Газ

    Private Sub cmdCalculateGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateGas.Click
        txtCostsGas.Text = Val(txtConsumedGas.Text) * Val(txtRateGas.Text)
    End Sub
    Private Sub cmdAddG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddGas.Click
        ГазBindingSource.AddNew()
    End Sub

    Private Sub cmdDeleteGas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteGas.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ГазBindingSource.RemoveCurrent()
            ГазTableAdapter.Update(BookkeepingBDDataSet.Газ)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub

    'Вода

    Private Sub cmdCalculateWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateWater.Click
        txtCostsWater.Text = Val(txtConsumedWater.Text) * Val(txtRateWater.Text)
    End Sub
    Private Sub cmdAddWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddWater.Click
        ВодаBindingSource.AddNew()
    End Sub

    Private Sub cmdDeleteWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteWater.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ВодаBindingSource.RemoveCurrent()
            ВодаTableAdapter.Update(BookkeepingBDDataSet.Вода)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub

    Private Sub cmdBringWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBringWater.Click
        Try
            ВодаBindingSource.EndEdit()
            ВодаTableAdapter.Update(BookkeepingBDDataSet.Вода)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Электричество
    Private Sub cmdCalculateElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateElec.Click
        txtCostsElec.Text = Val(txtConsumedElec.Text) * Val(txtRateElec.Text)
    End Sub

    Private Sub cmdDeleteElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteElec.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ЭлектричествоBindingSource.RemoveCurrent()
            ЭлектричествоTableAdapter.Update(BookkeepingBDDataSet.Электричество)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub

    Private Sub cmdBringElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBringElec.Click
        Try
            ЭлектричествоBindingSource.EndEdit()
            ЭлектричествоTableAdapter.Update(BookkeepingBDDataSet.Электричество)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdAddElec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddElec.Click
        ЭлектричествоBindingSource.AddNew()
    End Sub

    'Код, относящийся к 3 вкладке



    Private Sub cmdCalculateProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculateProfit.Click
        txtProfit.Text = Val(txtRevenue.Text) - Val(txtCosts.Text)
    End Sub


    Private Sub cmdAddProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddProfit.Click
        ПрибыльBindingSource.AddNew()
    End Sub

    Private Sub cmdBringProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBringProfit.Click
        Try
            ПрибыльBindingSource.EndEdit()
            ПрибыльTableAdapter.Update(BookkeepingBDDataSet.Прибыль)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdDeleteProfit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteProfit.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ПрибыльBindingSource.RemoveCurrent()
            ПрибыльTableAdapter.Update(BookkeepingBDDataSet.Прибыль)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "Ошибка")
        Exit Sub
    End Sub

    

    
    
    
End Class