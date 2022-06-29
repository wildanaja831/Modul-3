Public Class Form1

    Dim a, b As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = (TextBox1.Text)
        b = (TextBox2.Text)
        If a > b Then
            MsgBox("Nilai A lebih besar dari B")
        ElseIf a < b Then
            MsgBox("Nilai B lebih besar dari A")
        ElseIf a = b Then
            MsgBox("Nilai A dan B Sama Besar")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
