Module mdlStyle
    Public Function msEnter(ByVal lbl As Label) As Boolean
        lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Underline)
        lbl.ForeColor = Color.White
    End Function
    Public Function msLeave(ByVal lbl As Label) As Boolean
        lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Regular)
        lbl.ForeColor = Color.Gainsboro
    End Function
End Module
