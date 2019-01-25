Imports System.Data
Imports System.Data.OleDb
Public Class frmBooking
    Dim result As DialogResult

    Private Sub frmBooking_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub
   

    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Хозяева_и_питомцы". При необходимости она может быть перемещена или удалена.
        Me.Хозяева_и_питомцыTableAdapter.Fill(Me.AnimalBDDataSet.Хозяева_и_питомцы)
        With dgvAnimal
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = ХозяеваипитомцыBindingSource
        End With
        If txtAdditionalInf.Text = "" Then
            txtAdditionalInf.Text = "Привычки, предпочитаемый корм, любимые лакомства или еда"
            txtAdditionalInf.ForeColor = Color.Gray
        Else
            txtAdditionalInf.ForeColor = Color.Black
        End If
    End Sub

    'Подсказка
    Private Sub txtAdditionalInf_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdditionalInf.Enter
        If txtAdditionalInf.Text = "Привычки, предпочитаемый корм, любимые лакомства или еда" Then
            txtAdditionalInf.Text = ""
            txtAdditionalInf.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAdditionalInf_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdditionalInf.Leave
        If txtAdditionalInf.Text = "" Then
            txtAdditionalInf.Text = "Привычки, предпочитаемый корм, любимые лакомства или еда"
            txtAdditionalInf.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub lblBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBooking.Click
        frmBooking_Load(Nothing, Nothing)
    End Sub
    Private Sub lblGallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGallery.Click
        frmGallery.Show()
        Me.Hide()
    End Sub

    Private Sub lblContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContacts.Click
        frmContacts.Show()
        Me.Hide()
    End Sub

    Private Sub lblRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRooms.Click
        frmRooms.Show()
        Me.Hide()
    End Sub

    Private Sub lblPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPharmacy.Click
        frmPharmacy.Show()
        Me.Hide()
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub lblRooms_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRooms.MouseEnter
        msEnter(lblRooms)
    End Sub

    Private Sub lblRooms_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRooms.MouseLeave
        msLeave(lblRooms)
    End Sub

    Private Sub lblGallery_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGallery.MouseEnter
        msEnter(lblGallery)
    End Sub

    Private Sub lblGallery_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGallery.MouseLeave
        msLeave(lblGallery)
    End Sub

    Private Sub lblContacts_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblContacts.MouseEnter
        msEnter(lblContacts)
    End Sub

    Private Sub lblContacts_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblContacts.MouseLeave
        msLeave(lblContacts)
    End Sub

    Private Sub lblPharmacy_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPharmacy.MouseEnter
        msEnter(lblPharmacy)
    End Sub

    Private Sub lblPharmacy_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPharmacy.MouseLeave
        msLeave(lblPharmacy)
    End Sub

    Private Sub lblBooking_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBooking.MouseEnter
        msEnter(lblBooking)
    End Sub

    Private Sub lblBooking_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBooking.MouseLeave
        msLeave(lblBooking)
    End Sub


    'Расчет за обслуживание
    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        Dim Period, Rooms As Integer
        Dim Feeding, Delicacies, Combing, Training, Bathing, Calll, Wash, Delivery As Integer
        Period = Val(dtpDeparture.Text) - Val(dtpArrival.Text)
        If (cboRooms.Text = "VIP") Then
            Rooms = 600
        End If
        If (cboRooms.Text = "Стандарт") Then
            Rooms = 300
        End If
        If (chkFeeding.Checked = True) Then
            Feeding = 100
        Else
            Feeding = 0
        End If
        If (chkDelicacies.Checked = True) Then
            Delicacies = 50
        Else
            Delicacies = 0
        End If
        If (chkCombing.Checked = True) Then
            Combing = 50
        Else
            Combing = 0
        End If
        If (chkTraining.Checked = True) Then
            Training = 600
        Else
            Training = 0
        End If
        If (chkBathing.Checked = True) Then
            Bathing = 50
        Else
            Bathing = 0
        End If
        If (chkCall.Checked = True) Then
            Calll = 500
        Else
            Calll = 0
        End If
        If (chkWash.Checked = True) Then
            Wash = 50
        Else
            Wash = 0
        End If
        If (chkDelivery.Checked = True) Then
            Delivery = 800
        Else
            Delivery = 0
        End If
        txtTotal.Text = (Rooms * Period) + Feeding + Delicacies + Combing + Training + Bathing + Calll + Wash + Delivery
    End Sub
    'Cохранение в информации в бд
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        mdlBooking.Booking_BD()
        Dim connection As New OleDb.OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=AnimalBD.mdb")
        connection.Open()
        'создание объекта и передача ему SQL-командымии
        Dim command As New System.Data.OleDb.OleDbCommand("Select [Фамилия],[Имя],[Отчество],[Номер телефона],[Адрес проживания],[Вид], [Порода],[Кличка],[Пол],[Возраст],[Доставка_питомца],[Дата заезда],[Дата выбытия],[Тип номера],[Дополнительная информация],[Дополнительные_услуги],[Итого] From [Хозяева_и_питомцы]", connection)
        'Выполнение SQL-команды
        Dim datareader As OleDb.OleDbDataReader = command.ExecuteReader
        Dim datatable As New DataTable
        'Заполняем шапку таблицы
        datatable.Columns.Add(datareader.GetName(0))
        datatable.Columns.Add(datareader.GetName(1))
        datatable.Columns.Add(datareader.GetName(2))
        datatable.Columns.Add(datareader.GetName(3))
        datatable.Columns.Add(datareader.GetName(4))
        datatable.Columns.Add(datareader.GetName(5))
        datatable.Columns.Add(datareader.GetName(6))
        datatable.Columns.Add(datareader.GetName(7))
        datatable.Columns.Add(datareader.GetName(8))
        datatable.Columns.Add(datareader.GetName(9))
        datatable.Columns.Add(datareader.GetName(10))
        datatable.Columns.Add(datareader.GetName(11))
        datatable.Columns.Add(datareader.GetName(12))
        datatable.Columns.Add(datareader.GetName(13))
        datatable.Columns.Add(datareader.GetName(14))
        datatable.Columns.Add(datareader.GetName(15))
        datatable.Columns.Add(datareader.GetName(16))

        While datareader.Read() = True
            'Заполняем ячейки таблицы
            datatable.Rows.Add(New String() {datareader.GetValue(0), datareader.GetValue(1), datareader.GetValue(2), datareader.GetValue(3), datareader.GetValue(4), datareader.GetValue(5), datareader.GetValue(6), datareader.GetValue(7), datareader.GetValue(8), datareader.GetValue(9), datareader.GetValue(10), datareader.GetValue(11), datareader.GetValue(12), datareader.GetValue(13), datareader.GetValue(14), datareader.GetValue(15), datareader.GetValue(16)})
        End While
        datareader.Close() : connection.Close()
        dgvAnimal.DataSource = datatable
    End Sub
    'Очистка вссех полей и добавление новой строки в бд
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        txtName.Clear()
        txtSurnname.Clear()
        txtPatronymic.Clear()
        mtxNumber.Clear()
        txtAddress.Clear()
        txtView.Clear()
        txtBreed.Clear()
        txtNickname.Clear()
        cboPol.Text = ""
        txtAge.Clear()
        cboRooms.Text = ""
        txtAdditionalInf.Clear()
        txtTotal.Clear()
        chkFeeding.Checked = False
        chkBathing.Checked = False
        chkCall.Checked = False
        chkCombing.Checked = False
        chkDelicacies.Checked = False
        chkDelivery.Checked = False
        chkTraining.Checked = False
        chkWash.Checked = False

        ХозяеваипитомцыBindingSource.AddNew()
    End Sub
    'Удалить поле в бд
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        On Error GoTo ErrExite
        result = MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            ХозяеваипитомцыBindingSource.RemoveCurrent()
            Хозяева_и_питомцыTableAdapter.Update(AnimalBDDataSet.Хозяева_и_питомцы)
            Exit Sub
        Else
            Exit Sub
        End If
ErrExite:
        MsgBox("Поле пусто, ничего нельзя удалить", MsgBoxStyle.Critical, "")
        Exit Sub
    End Sub
    'Поиск по бд
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If txtSearch.Text = "" Then
                Exit Sub
            Else
                Dim cantFine As String = txtSearch.Text
                ХозяеваипитомцыBindingSource.Filter = "(Convert(Код, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Фамилия LIKE '" & txtSearch.Text & "') OR (Имя LIKE '" & txtSearch.Text & "')" & _
                "OR (Отчество LIKE '" & txtSearch.Text & "') OR (Вид LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Возраст, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Convert(Итого, 'System.String') LIKE '" & txtSearch.Text & "')" & _
                "OR (Кличка LIKE '" & txtSearch.Text & "')" & _
                "OR (Порода LIKE '" & txtSearch.Text & "')"


                'Если что-то, искомое выше, нашлось в базе данных, тогда вывести информацию об этом в DataGridView

                If ХозяеваипитомцыBindingSource.Count <> 0 Then
                    With dgvAnimal
                        .DataSource = ХозяеваипитомцыBindingSource
                    End With

                    'Иначе выдать сообщение об отсутсвии

                Else
                    MsgBox("Элемент " & cantFine & " не найден", MsgBoxStyle.Information, "Поиск")
                    ХозяеваипитомцыBindingSource.Filter = Nothing
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
            ХозяеваипитомцыBindingSource.Filter = Nothing

            With dgvAnimal
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = ХозяеваипитомцыBindingSource
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class