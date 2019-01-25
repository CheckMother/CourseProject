Imports System.Data.OleDb
Module mdlBooking
    Public Function Booking_BD()
        Dim Family, Name, Patronymic As String
        Dim Number As String
        Dim Address As String
        Dim View As String
        Dim Breed As String
        Dim Nickname As String
        Dim Pol As String
        Dim Age As String
        Dim Delivery = "", E As String
        Dim Arrival As String
        Dim Departure As String
        Dim Rooms As String
        Dim AdditionalInf As String
        Dim Services As String
        Dim Total As String
        Dim Feeding = "", Delicacies = "", Combing = "", Training = "", Bathing = "", Calll = "", Wash = "", S As String
        Family = frmBooking.txtSurnname.Text
        Name = frmBooking.txtName.Text
        Patronymic = frmBooking.txtPatronymic.Text
        Number = frmBooking.mtxNumber.Text
        Address = frmBooking.txtAddress.Text
        View = frmBooking.txtView.Text
        Breed = frmBooking.txtBreed.Text
        Nickname = frmBooking.txtNickname.Text
        Pol = frmBooking.cboPol.Text
        Age = frmBooking.txtAge.Text
        Arrival = frmBooking.dtpArrival.Text
        Departure = frmBooking.dtpDeparture.Text
        Rooms = frmBooking.cboRooms.Text
        AdditionalInf = frmBooking.txtAdditionalInf.Text
        Total = frmBooking.txtTotal.Text


        If (frmBooking.chkFeeding.Checked = True) Then
            Feeding = "Доп.кормление; "
        End If
        If (frmBooking.chkDelicacies.Checked = True) Then
            Delicacies = "Доп.лакомства; "
        End If
        If (frmBooking.chkCombing.Checked = True) Then
            Combing = "Расчесывание шерсти; "
        End If
        If (frmBooking.chkTraining.Checked = True) Then
            Training = "Дрессировка; "
        End If
        If (frmBooking.chkBathing.Checked = True) Then
            Bathing = "Купание; "
        End If
        If (frmBooking.chkCall.Checked = True) Then
            Calll = "Вызов вет.врача; "
        End If
        If (frmBooking.chkWash.Checked = True) Then
            Wash = "Мытье глаз; "
        End If
        Services = Feeding + Delicacies + Combing + Training + Bathing + Calll + Wash
        If (frmBooking.chkDelivery.Checked = True) Then
            Delivery = "Да"
        End If

        Dim SozdOb As String
        Dim Connection = New OleDbConnection("Provider=Microsoft." & "Jet.OLEDB.4.0;Data Source=AnimalBD.mdb")
        Connection.Open()
        SozdOb = "insert into [Хозяева_и_питомцы](" & " [Фамилия],[Имя],[Отчество],[Номер телефона],[Адрес проживания],[Вид], [Порода],[Кличка],[Пол],[Возраст],[Доставка_питомца],[Дата заезда],[Дата выбытия],[Тип номера],[Дополнительная информация],[Дополнительные_услуги],[Итого]) values ('" & Family & "','" & Name & "','" & Patronymic & "','" & Number & "','" & Address & "','" & View & "', '" & Breed & "', '" & Nickname & "', '" & Pol & "', '" & Age & "', '" & Delivery & "', '" & Arrival & "', '" & Departure & "', '" & Rooms & "', '" & AdditionalInf & "', '" & Services & "', '" & Total & "')"
        Dim command = New OleDbCommand(SozdOb)
        command.Connection = Connection
        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Данные занесены в базу", "Запись добавлена")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Connection.Close()
    End Function
End Module
