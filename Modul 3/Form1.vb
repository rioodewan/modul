Public Class Form1
    Dim a, b As Integer

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai A Terbesar")
        ElseIf b > a Then
            MsgBox("Nilai B Terbesar")
        Else
            MsgBox("Nilai A & B Sama")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
