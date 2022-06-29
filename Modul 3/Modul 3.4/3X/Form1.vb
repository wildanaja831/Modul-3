Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Maaf makanan tidak boleh kosong")
        Else
            If ListBox1.Items.Contains(TextBox1.Text) Then
                MsgBox("Maaf makanan yang anda masukan sudah ada")
            Else
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Maaf pilih dahulu makanan yang anda hapus")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class
