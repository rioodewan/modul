Public Class Form6
    Dim s1, s2, s3, s4, s5 As String
    Dim gol As String
    Private Sub Form1_Load(ByVal sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("ISLAM")
            .Add("KRISTEN")
            .Add("HINDU")
            .Add("BUDHA")
            .Add("KONGHUCU")

        End With

    End Sub

    Sub goldar()
        If RadioButton1.Checked = True Then
            gol = "A"
        ElseIf RadioButton2.Checked = True Then
            gol = "O"
        ElseIf RadioButton3.Checked = True Then
            gol = "B"
        ElseIf RadioButton4.Checked = True Then
            gol = "AB"
        End If
    End Sub

    Sub syarat()
        If CheckBox1.Checked = True Then
            s1 = CheckBox1.Text & " : " & "ADA"
        ElseIf CheckBox1.Checked = False Then
            s1 = CheckBox1.Text & " : " & "BELUM"
        End If
        If CheckBox2.Checked = True Then
            s2 = CheckBox2.Text & " : " & "ADA"
        ElseIf CheckBox2.Checked = False Then
            s2 = CheckBox2.Text & " : " & "BELUM"
        End If
        If CheckBox3.Checked = True Then
            s3 = CheckBox3.Text & " : " & "ADA"
        ElseIf CheckBox3.Checked = False Then
            s3 = CheckBox3.Text & " : " & "BELUM"
        End If
        If CheckBox4.Checked = True Then
            s4 = CheckBox4.Text & " : " & "ADA"
        ElseIf CheckBox4.Checked = False Then
            s4 = CheckBox4.Text & " : " & "BELUM"
        End If
        If CheckBox5.Checked = True Then
            s5 = CheckBox5.Text & " : " & "ADA"
        ElseIf CheckBox5.Checked = False Then
            s5 = CheckBox5.Text & " : " & "BELUM"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles Button1.Click
        Call goldar()
        Call syarat()

        MsgBox("NISN : " & TextBox1.Text & vbCrLf & "Nama Lengkap : " & TextBox2.Text & vbCrLf & "Alamat : " & TextBox3.Text & vbCrLf & "Tanggal Lahir : " & DateTimePicker1.Value & vbCrLf & "Agama : " & ComboBox1.Text & vbCrLf & "Golongan Darah : " & gol & vbCrLf & "Prasyarat : " & vbCrLf & s1 & vbCrLf & s2 & vbCrLf & s3 & vbCrLf & s4 & vbCrLf & s5)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form7.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form11.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class