Imports System.Data.OleDb
Imports System.Data
Public Class frmRegistration

    Private Sub cmdRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegistration.Click
        If txtPasswordCreate.Text = txtConfirmPassword.Text Then



            If txtLoginCreate.Text = "" Or txtPasswordCreate.Text = "" Or txtConfirmPassword.Text = "" Then
                MsgBox("Пожалуйста заполните все поля", MsgBoxStyle.Critical, "")
            Else
                Try
                    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\UserAccount.mdb")
                    Dim insert As String = "Insert into Account values('" & txtLoginCreate.Text & "','" & txtPasswordCreate.Text & "');"
                    Dim cmd As New OleDbCommand(insert, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Регистрация прошла успешно", MsgBoxStyle.Information, "")
                    frmLogin.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Пароли не совпадают", MsgBoxStyle.Critical, "")
        End If

    End Sub

    Private Sub frmRegistration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Show()
    End Sub

    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLoginCreate.Focus()
    End Sub
End Class