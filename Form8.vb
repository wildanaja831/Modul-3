Public Class Form8

  
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Sumatera")
            .Add("Kalimantan")
            .Add("Jawa")
            .Add("Sulawesi")
            .Add("Papua")
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = "Sumatera"
                With ListBox1.Items
                    .Clear()
                    .Add("NAD")
                    .Add("Sumatera Utara")
                    .Add("Sumatera Barat")
                    .Add("palembang")
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
                    .Add("Kalimantan barat")
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
                    .Add("Sulawesi Tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih Provinsi Terlebih Dahulu")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Maaf Pilih provinsi yang ingin Anda hapus")
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form9.Show()
    End Sub
End Class