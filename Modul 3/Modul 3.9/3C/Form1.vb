﻿Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Direktur")
            .Add("Manajer")
            .Add("Sekretaris")
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = (Val(TextBox2.Text) + Val(TextBox4.Text)) - (Val(TextBox5.Text) * Val(TextBox3.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Direktur" Then
            TextBox3.Text = 10000000
            TextBox4.Text = 2500000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Manajer" Then
            TextBox3.Text = 7000000
            TextBox4.Text = 2000000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Sekretaris" Then
            TextBox3.Text = 4000000
            TextBox4.Text = 1000000
            TextBox5.Text = 0.1
        End If
    End Sub
End Class
