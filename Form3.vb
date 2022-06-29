Public Class Form3

    Sub hitung()
        Label3.Text = ListBox2.Items.Count & "Item"
    End Sub
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi Goreng Bom atom")
            .Add("Nasi Goreng Pedas Gila")
            .Add("Kangkung")
            .Add("Telor Dadar")
        End With
        hitung()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih Makanan Yang ingin anda pesan")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Pilih Makan yang ingin anda Hapus")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItems)
            ListBox2.Items.Remove(ListBox2.SelectedItems)
            hitung()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
        tambah()
        hitung()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()

    End Sub
End Class