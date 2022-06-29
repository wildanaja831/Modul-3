Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Sumatera")
            .Add("Kalimantan")
            .Add("Jawa")
            .Add("Sulawesi")
            .Add("Papua")
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = "Sumatera"
                With ListBox1.Items
                    .Clear()
                    .Add("NAD")
                    .Add("Sumatera Utara")
                    .Add("Sumatera Barat")
                    .Add("Palembang")
                    .Add("Lampung")
                    .Add("Riau")
                End With
            Case Is = "Kalimantan"
                With ListBox1.Items
                    .Clear()
                    .Add("Kalimantan Utara")
                    .Add("Kalimantan Tengah")
                    .Add("Kalimantan Selatan")
                    .Add("Kalimantan Timur")
                    .Add("Kalimantan Barat")
                End With
            Case Is = "Jawa"
                With ListBox1.Items
                    .Clear()
                    .Add("Jawa Barat")
                    .Add("Banten")
                    .Add("Djogjakarta")
                    .Add("Jawa Timur")
                    .Add("Jawa Tengah")
                    .Add("Jakarta")
                End With
            Case Is = "Sulawesi"
                With ListBox1.Items
                    .Clear()
                    .Add("Sulawesi Utara")
                    .Add("Sulawesi selatan")
                    .Add("sulawesi tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih Provinsi Terlebih Dahulu")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Maaf Pilih Provinsi Yang Ingin Dihapus")
        Else
            ListBox2.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class
