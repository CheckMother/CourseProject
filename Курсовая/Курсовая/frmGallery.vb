Public Class frmGallery
    'Увеличение или уменьшение фотографий при нажатии
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If (PictureBox1.Height = 134 And PictureBox1.Width = 213) Then
            PictureBox1.BringToFront()
            PictureBox1.Left = PictureBox1.Left + 130
            PictureBox1.Top = PictureBox1.Top + 100
            PictureBox1.Height = 320
            PictureBox1.Width = 450
        Else
            PictureBox1.SendToBack()
            PictureBox1.Left = PictureBox1.Left - 130
            PictureBox1.Top = PictureBox1.Top - 100
            PictureBox1.Height = 134
            PictureBox1.Width = 213
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If (PictureBox2.Height = 134 And PictureBox2.Width = 213) Then
            PictureBox2.BringToFront()
            PictureBox2.Left = PictureBox2.Left - 100
            PictureBox2.Top = PictureBox2.Top + 75
            PictureBox2.Height = 320
            PictureBox2.Width = 450
        Else
            PictureBox2.SendToBack()
            PictureBox2.Left = PictureBox2.Left + 100
            PictureBox2.Top = PictureBox2.Top - 75
            PictureBox2.Height = 134
            PictureBox2.Width = 213
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If (PictureBox3.Height = 134 And PictureBox3.Width = 213) Then
            PictureBox3.BringToFront()
            PictureBox3.Left = PictureBox3.Left - 360
            PictureBox3.Top = PictureBox3.Top + 100
            PictureBox3.Height = 320
            PictureBox3.Width = 450
        Else
            PictureBox3.SendToBack()
            PictureBox3.Left = PictureBox3.Left + 360
            PictureBox3.Top = PictureBox3.Top - 100
            PictureBox3.Height = 134
            PictureBox3.Width = 213
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If (PictureBox4.Height = 134 And PictureBox4.Width = 213) Then
            PictureBox4.BringToFront()
            PictureBox4.Left = PictureBox4.Left + 150
            PictureBox4.Top = PictureBox4.Top - 50
            PictureBox4.Height = 300
            PictureBox4.Width = 450
        Else
            PictureBox4.SendToBack()
            PictureBox4.Left = PictureBox4.Left - 150
            PictureBox4.Top = PictureBox4.Top + 50
            PictureBox4.Height = 134
            PictureBox4.Width = 213
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If (PictureBox5.Height = 134 And PictureBox5.Width = 213) Then
            PictureBox5.BringToFront()
            PictureBox5.Left = PictureBox5.Left - 120
            PictureBox5.Top = PictureBox5.Top - 35
            PictureBox5.Height = 320
            PictureBox5.Width = 450
        Else
            PictureBox5.SendToBack()
            PictureBox5.Left = PictureBox5.Left + 120
            PictureBox5.Top = PictureBox5.Top + 35
            PictureBox5.Height = 134
            PictureBox5.Width = 213
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If (PictureBox6.Height = 134 And PictureBox6.Width = 213) Then
            PictureBox6.BringToFront()
            PictureBox6.Left = PictureBox6.Left - 360
            PictureBox6.Top = PictureBox6.Top - 50
            PictureBox6.Height = 300
            PictureBox6.Width = 450
        Else
            PictureBox6.SendToBack()
            PictureBox6.Left = PictureBox6.Left + 360
            PictureBox6.Top = PictureBox6.Top + 50
            PictureBox6.Height = 134
            PictureBox6.Width = 213
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If (PictureBox8.Height = 189 And PictureBox8.Width = 290) Then
            PictureBox8.BringToFront()
            PictureBox8.Left = PictureBox8.Left + 85
            PictureBox8.Top = PictureBox8.Top - 170
            PictureBox8.Height = 300
            PictureBox8.Width = 450
        Else
            PictureBox8.SendToBack()
            PictureBox8.Left = PictureBox8.Left - 85
            PictureBox8.Top = PictureBox8.Top + 170
            PictureBox8.Height = 189
            PictureBox8.Width = 290
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If (PictureBox7.Height = 205 And PictureBox7.Width = 146) Then
            PictureBox7.BringToFront()
            PictureBox7.Left = PictureBox7.Left - 220
            PictureBox7.Top = PictureBox7.Top - 230
            PictureBox7.Height = 400
            PictureBox7.Width = 290
        Else
            PictureBox7.SendToBack()
            PictureBox7.Left = PictureBox7.Left + 220
            PictureBox7.Top = PictureBox7.Top + 230
            PictureBox7.Height = 205
            PictureBox7.Width = 146
        End If
    End Sub
    Private Sub frmGallery_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub
    Private Sub lblGallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGallery.Click
        frmGallery_Load(Nothing, Nothing)
    End Sub
    Private Sub frmGallery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    Private Sub lblBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBooking.Click
        frmBooking.Show()
        Me.Hide()
    End Sub
    'Код, отвечающий за шапку(Стиль)

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

End Class