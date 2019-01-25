Public Class frmPharmacy

    Private Sub frmPharmacy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmPharmacy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BuyDataSet.BuyFeed". При необходимости она может быть перемещена или удалена.
        Me.BuyFeedTableAdapter.Fill(Me.BuyDataSet.BuyFeed)
        BuyFeedBindingSource.AddNew()
        cboCompany.Enabled = False
        cboViewFeed.Enabled = False
        txtAmount.ReadOnly = True
    End Sub
    Private Sub lblBooking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBooking.Click
        frmBooking.Show()
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

    Private Sub lblRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRooms.Click
        frmRooms.Show()
        Me.Hide()
    End Sub

    Private Sub lblPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPharmacy.Click
        frmPharmacy_Load(Nothing, Nothing)
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
    

    ' 1 Вкладка

    'Изменяет combobox в отличие от того какое животное выберите
    Private Sub cboAnimal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAnimal.SelectedIndexChanged
        If (cboAnimal.Text = "Кошка") Then
            cboViewFeed.Enabled = True
            txtAmount.Clear()
            cboCompany.Text = ""
            cboViewFeed.Text = ""
            txtTotalFeed.Clear()
            With cboCompany
                .Items.Clear()
                .Items.Clear()
                .Items.Clear()
            End With
            With cboCompany
                .Items.Add("Pro Plan")
                .Items.Add("Royal Canin")
                .Items.Add("Wellkiss")
            End With
        End If
        If (cboAnimal.Text = "Собака") Then
            cboViewFeed.Enabled = True
            txtAmount.Clear()
            cboCompany.Text = ""
            cboViewFeed.Text = ""
            txtTotalFeed.Clear()
            With cboCompany
                .Items.Clear()
                .Items.Clear()
                .Items.Clear()
            End With
            With cboCompany
                .Items.Add("Abba")
                .Items.Add("Royal Canin")
                .Items.Add("Grandin")
            End With
        End If
    End Sub

    Private Sub tpFeed_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpFeed.Enter
        If tabZooShop.SelectedTab Is tpFeed Then
            With Me
                .Width = 752
                .Height = 377
            End With
        End If
    End Sub

    Private Sub cmdBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuy.Click
        Try
            BuyFeedBindingSource.EndEdit()
            BuyFeedTableAdapter.Update(BuyDataSet.BuyFeed)
            MsgBox("Успешная покупка", MsgBoxStyle.Information, "")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BuyFeedBindingSource.AddNew()
    End Sub

    Private Sub cmdBuyFeed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuyFeed.Click
        If tabZooShop.SelectedTab Is tpFeed Then
            With Me
                .Width = 752
                .Height = 579
            End With

        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        BuyFeedBindingSource.AddNew()
    End Sub

    Private Sub cmdHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHide.Click
        If tabZooShop.SelectedTab Is tpFeed Then
            With Me
                .Width = 752
                .Height = 377
            End With
        End If
    End Sub

    Private Sub cboViewFeed_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboViewFeed.SelectedIndexChanged

        If (cboViewFeed.Text = "Сухой") Then
            cboCompany.Enabled = True
            txtAmount.Clear()
            cboCompany.Text = ""
            txtTotalFeed.Clear()
        End If
        If (cboViewFeed.Text = "Влажный") Then
            cboCompany.Enabled = True
            txtAmount.Clear()
            cboCompany.Text = ""
            txtTotalFeed.Clear()
        End If
        If (cboViewFeed.Text = "") Then
            cboCompany.Enabled = False
            txtAmount.ReadOnly = True
            txtTotalFeed.ReadOnly = True
        End If
    End Sub
    'Расчет к оплате за корм
    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        Dim ProPlan, RoyalCanin, Grandin, Wellkiss, Abba, TotalFeed As Double
        If (cboAnimal.Text = "Кошка") Then
            If (cboViewFeed.Text = "Сухой") Then
                If (cboCompany.Text = "Pro Plan") Then
                    ProPlan = 0.84
                End If
                If (cboCompany.Text = "Wellkiss") Then
                    Wellkiss = 0.36
                End If
                If (cboCompany.Text = "Royal Canin") Then
                    RoyalCanin = 0.82
                End If
            End If
            If (cboViewFeed.Text = "Влажный") Then
                If (cboCompany.Text = "Pro Plan") Then
                    ProPlan = 0.83
                End If
                If (cboCompany.Text = "Wellkiss") Then
                    Wellkiss = 0.7
                End If
                If (cboCompany.Text = "Royal Canin") Then
                    RoyalCanin = 0.81
                End If
            End If
        End If
        If (cboAnimal.Text = "Собака") Then
            If (cboViewFeed.Text = "Сухой") Then
                If (cboCompany.Text = "Grandin") Then
                    ProPlan = 0.42
                End If
                If (cboCompany.Text = "Abba") Then
                    Wellkiss = 0.29
                End If
                If (cboCompany.Text = "Royal Canin") Then
                    RoyalCanin = 0.43
                End If
            End If
            If (cboViewFeed.Text = "Влажный") Then
                If (cboCompany.Text = "Grandin") Then
                    ProPlan = 0.64
                End If
                If (cboCompany.Text = "Abba") Then
                    Wellkiss = 0.77
                End If
                If (cboCompany.Text = "Royal Canin") Then
                    RoyalCanin = 0.52
                End If
            End If
        End If

        TotalFeed = ProPlan + RoyalCanin + Grandin + Wellkiss + Abba
        txtTotalFeed.Text = TotalFeed * Val(txtAmount.Text)

    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged
        If (cboCompany.Text = "") Then
            txtAmount.ReadOnly = False
        Else
            txtAmount.ReadOnly = False
        End If
    End Sub
End Class