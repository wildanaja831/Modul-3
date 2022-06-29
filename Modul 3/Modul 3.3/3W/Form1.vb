Public Class Form1

    Sub hitung()
        Label3.Text = ListBox2.Items.Count & " item"
    End Sub
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi Goreng Pig")
            .Add("Bebek rebus tiren")
            .Add("cumi cumi kamu sayangku")
            .Add("Krecek item")
        End With
        hitung()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih makanan yang ingin anda pean")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            hitung()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Pilih makanan yang ingin anda pesan")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            hitung()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        tambah()
        hitung()
    End Sub
End Class
