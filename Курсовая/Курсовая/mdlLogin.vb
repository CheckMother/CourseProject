Module mdlLogin
    Public access As Boolean = False
    Public auth As Boolean = False
    Public Function login(ByVal lb1 As Label, ByVal lb2 As Label, ByVal lb4 As Label, ByVal lb5 As Label, ByVal lb6 As Label, ByVal lb7 As Label, ByVal lb8 As Label, ByVal lb9 As Label) As Boolean
        If access = False Then
            lb1.Visible = True
            lb2.Visible = True
            lb4.Visible = True
            lb5.Visible = True
            lb6.Visible = True
            lb7.Visible = True
            lb8.Visible = True
            lb9.Hide()

        Else
            lb1.Visible = True
            lb2.Visible = True
            lb4.Visible = True
            lb5.Visible = True
            lb6.Visible = True
            lb7.Visible = True
            lb8.Visible = True
            lb9.Visible = True
        End If

    End Function
End Module
