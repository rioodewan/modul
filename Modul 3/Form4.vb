Public Class Form4
    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Maaf Makanan Tidak Boleh Kosong")
        Else
            If ListBox1.Items.Contains(TextBox1.Text) Then
                MsgBox("Maaf Makanan Yang Anda Masukan Sudah Ada")
            Else
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Maaf Pilih Dahulu Makanan Yang Anda Hapus")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class