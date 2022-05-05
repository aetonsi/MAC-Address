Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim mystr As String = ""
        Dim mychr As String
        For i = 1 To TextBox1.TextLength
            mychr = Mid(TextBox1.Text, i, 1)
            If IsNumeric(mychr) = True Or ((Asc(mychr) >= 65 And Asc(mychr) <= 70) Or (Asc(mychr) >= 97 And Asc(mychr) <= 102)) Then
                mystr += mychr
            Else
                mystr += ":"
            End If
        Next i
        TextBox1.Text = mystr
        Clipboard.SetText(mystr)
    End Sub
End Class
