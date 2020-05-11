Public Class Form7
    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Top = PictureBox1.Top - 10
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Left = PictureBox1.Left - 10
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Left = PictureBox1.Left + 10
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Top = PictureBox1.Top + 10
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class