Imports System.Data.OleDb
Imports System.Data
Public Class frmLogin
    Dim k As Integer = 0
    Private Sub cmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String = ""
        Dim old As Point = Me.Location
        If txtLogin.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Пожалуйста заполните все поля", MsgBoxStyle.Exclamation, "")
            k += 1
        Else
            uname = txtLogin.Text
            pword = txtPassword.Text
            Dim querry As String = "Select password From Account where login= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UserAccount.mdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Такого аккаунта не существует", MsgBoxStyle.Critical, "")
            End Try


            If pword = pass Then
                frmMain.auth = True
                If txtLogin.Text = "admin" And txtPassword.Text = "admin" Then
                    mdlLogin.access = True
                    frmMain.tsmiAccountAll.Text = "Администратор"
                    old.X = 602
                    old.Y = 45
                    frmMain.MenuStrip1.Location = New Point(old.X, old.Y)

                Else
                    mdlLogin.access = False
                    frmMain.tsmiAccountAll.Text = txtLogin.Text
                    old.X = 610
                    old.Y = 45
                    frmMain.MenuStrip1.Location = New Point(old.X, old.Y)
                End If
                frmMain.Show()
                Me.Close()
            Else
                MsgBox("Неверный пароль или логин", MsgBoxStyle.Critical, "")
                k += 1
                txtLogin.Clear()
                txtPassword.Clear()
                txtLogin.Focus() 
            End If
            
            login(frmMain.lblRooms, frmMain.lblGallery, frmMain.lblPharmacy, frmMain.lblContacts, frmMain.lblBooking, frmMain.Label2, frmMain.Label1, frmMain.lblBookkeeping)
        End If
        If (k >= 3) Then
            MsgBox("Вы ввели неправильно 3 раза логин или пароль, пожалуйста, попробуйте позднее ", MsgBoxStyle.Critical, "")
            lblTimer.Text = "10"
            tmrLogin.Enabled = True
            txtLogin.ReadOnly = True
            cmdLogin.Enabled = False
            txtPassword.ReadOnly = True
        End If
    End Sub

    Private Sub llbRegistration_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbRegistration.LinkClicked
        frmRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub txtLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
        txtLogin.Focus()
    End Sub

    Private Sub chkShow_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLogin.Focus()
    End Sub

    Private Sub tmrLogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogin.Tick
        lblTimer.Text = Val(lblTimer.Text) - 1
        If lblTimer.Text = "0" Then
            tmrLogin.Stop()
            txtLogin.ReadOnly = False
            txtPassword.ReadOnly = False
            tmrLogin.Enabled = False
            lblTimer.Text = ""
            cmdLogin.Enabled = True
            k = 0
        End If
    End Sub
End Class