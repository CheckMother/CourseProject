Public Class frmContacts

    Private Sub lblBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBooking.Click
        frmBooking.Show()
        Me.Hide()
    End Sub

    Private Sub lblPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPharmacy.Click
        frmPharmacy.Show()
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
        frmContacts_Load(Nothing, Nothing)
    End Sub

    Private Sub lblMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmContacts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Show()
    End Sub

    Private Sub frmContacts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

End Class