Public Class Form9
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Direktur")
            .Add("Manajer")
            .Add("Sekertaris")
        End With
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.Text = (Val(TextBox3.Text) + Val(TextBox4.Text)) - (Val(TextBox5.Text) * Val(TextBox3.Text))
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Direktur" Then
            TextBox3.Text = 10000000
            TextBox4.Text = 2500000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Manajer" Then
            TextBox3.Text = 7000000
            TextBox4.Text = 2000000
            TextBox5.Text = 0.1
        ElseIf ComboBox1.Text = "Sekertaris" Then
            TextBox3.Text = 4000000
            TextBox4.Text = 1000000
            TextBox5.Text = 0.1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class