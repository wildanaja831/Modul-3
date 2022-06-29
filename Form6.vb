Public Class Form6

    Dim s1, s2, s3, s4, s5 As String
    Dim gol As String
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Islam")
            .Add("Kristen")
            .Add("Hindu")
            .Add("Budha")
            .Add("Konghuchu")
        End With
    End Sub
    Sub goldar()
        If RadioButton1.Checked = True Then
            gol = "A"
        ElseIf RadioButton2.Checked = True Then
            gol = "o"
        ElseIf RadioButton3.Checked = True Then
            gol = "B"
        ElseIf RadioButton4.Checked = True Then
            gol = "AB"
        End If
    End Sub
    Sub syarat()
        If CheckBox1.Checked = True Then
            s1 = CheckBox1.Text & ":" & "ADA"
        Else
            s1 = CheckBox1.Text & ":" & "Belum"

        End If
        If CheckBox2.Checked = True Then
            s2 = CheckBox2.Text & ":" & "ADA"
        Else
            s2 = CheckBox2.Text & ":" & "Belum"

        End If
        If CheckBox3.Checked = True Then
            s3 = CheckBox3.Text & ":" & "ADA"
        Else
            s3 = CheckBox3.Text & ":" & "Belum"

        End If
        If CheckBox4.Checked = True Then
            s4 = CheckBox4.Text & ":" & "ADA"
        Else
            s4 = CheckBox4.Text & ":" & "Belum"

        End If
        If CheckBox5.Checked = True Then
            s5 = CheckBox5.Text & ":" & "ADA"
        Else
            s5 = CheckBox5.Text & ":" & "Belum"

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call goldar()
        Call syarat()
        MsgBox("NISN :" & TextBox1.Text & vbCrLf & "Nama :" & TextBox2.Text & vbCrLf & "Alamat :" & TextBox3.Text & vbCrLf & "Tanggal Lahir :" & DateTimePicker1.Value & "Agama :" & ComboBox1.Text & vbCrLf & "Golongan Darah :" & gol & vbCrLf & "Persyaratan :" & vbCrLf & s1 & vbCrLf & s2 & vbCrLf & s3 & vbCrLf & s4 & vbCrLf & s5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        form7.show()
    End Sub
End Class