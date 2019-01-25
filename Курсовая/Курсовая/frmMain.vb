Public Class frmMain
    Public access As Boolean = False
    Public auth As Boolean = False

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Прозрачный фон лейблов
        lblRooms.BackColor = Color.Transparent
        lblMain.BackColor = Color.Transparent
        lblGallery.BackColor = Color.Transparent
        lblBooking.BackColor = Color.Transparent
        lblContacts.BackColor = Color.Transparent
        lblPharmacy.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        MenuStrip1.BackColor = Color.Transparent
        lblBookkeeping.BackColor = Color.Transparent

        'Скрываем лейблы предусмотренные для админа
        lblBookkeeping.Visible = False

    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain_Load(Nothing, Nothing)
    End Sub
    Private Sub lblBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBooking.Click
        frmBooking.Show()
        Me.Hide()
    End Sub
    Private Sub lblBookkeeping_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeeping.Click
        frmBookkeeping.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAccount.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub lblRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRooms.Click
        frmRooms.Show()
        Me.Hide()
    End Sub

    Private Sub lblGallery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGallery.Click
        frmGallery.Show()
        Me.Hide()
    End Sub

    Private Sub lblContacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContacts.Click
        frmContacts.Show()
        Me.Hide()
    End Sub

    Private Sub lblPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPharmacy.Click
        frmPharmacy.Show()
        Me.Hide()
    End Sub


    'Код относящийся к лейблам при наведении и при убирании мышки с него
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

    Private Sub lblBookkeeping_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeeping.MouseEnter
        msEnter(lblBookkeeping)
    End Sub

    Private Sub lblBookkeeping_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBookkeeping.MouseLeave
        msLeave(lblBookkeeping)
    End Sub

    Private Sub tsmiAccountAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAccountAll.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class
