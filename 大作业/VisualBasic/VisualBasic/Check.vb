Public Class Check


    Sub MySub()
        If CheckBox1.Checked = True Then
            If CheckBox2.Checked = False Then
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        TextBox1.Text = Arrangement.Studentarranged(0) & Space(4) & Arrangement.Studentarranged(1)
                        TextBox2.Text = ""
                    Case 1
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(0) & "-" & Arrangement.Teacherarranged(1) & vbCrLf & Arrangement.Teacherarranged(2) & "-" & Arrangement.Teacherarranged(3)
                    Case 2
                        TextBox1.Text = Arrangement.Studentarranged(2) & Space(4) & Arrangement.Studentarranged(3)
                        TextBox2.Text = ""
                    Case 3
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(4) & "-" & Arrangement.Teacherarranged(5) & vbCrLf & Arrangement.Teacherarranged(6) & "-" & Arrangement.Teacherarranged(7)
                End Select
            ElseIf CheckBox2.Checked = True Then
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        TextBox1.Text = Arrangement.Studentarranged(0) & Space(4) & Arrangement.Studentarranged(1) & vbCrLf & vbCrLf & Arrangement.Studentarranged(4) & Space(4) & Arrangement.Studentarranged(5)
                        TextBox2.Text = ""
                    Case 1
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(0) & "-" & Arrangement.Teacherarranged(1) & vbCrLf & Arrangement.Teacherarranged(2) & "-" & Arrangement.Teacherarranged(3) & vbCrLf & vbCrLf & Arrangement.Teacherarranged(8) & "-" & Arrangement.Teacherarranged(9) & vbCrLf & Arrangement.Teacherarranged(10) & "-" & Arrangement.Teacherarranged(11)
                    Case 2
                        TextBox1.Text = Arrangement.Studentarranged(2) & Space(4) & Arrangement.Studentarranged(3) & vbCrLf & vbCrLf & Arrangement.Studentarranged(6) & Space(4) & Arrangement.Studentarranged(7)
                        TextBox2.Text = ""
                    Case 3
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(4) & "-" & Arrangement.Teacherarranged(5) & vbCrLf & Arrangement.Teacherarranged(6) & "-" & Arrangement.Teacherarranged(7) & vbCrLf & vbCrLf & Arrangement.Teacherarranged(12) & "-" & Arrangement.Teacherarranged(13) & vbCrLf & Arrangement.Teacherarranged(14) & "-" & Arrangement.Teacherarranged(15)
                End Select
            End If
        ElseIf CheckBox1.Checked = False Then
            If CheckBox2.Checked = False Then
                TextBox1.Text = ""
                TextBox2.Text = ""
            ElseIf CheckBox2.Checked = True Then
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        TextBox1.Text = Arrangement.Studentarranged(4) & Space(4) & Arrangement.Studentarranged(5)
                        TextBox2.Text = ""
                    Case 1
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(8) & "-" & Arrangement.Teacherarranged(9) & vbCrLf & Arrangement.Teacherarranged(10) & "-" & Arrangement.Teacherarranged(11)
                    Case 2
                        TextBox1.Text = Arrangement.Studentarranged(6) & Space(4) & Arrangement.Studentarranged(7)
                        TextBox2.Text = ""
                    Case 3
                        TextBox1.Text = ""
                        TextBox2.Text = Arrangement.Teacherarranged(12) & "-" & Arrangement.Teacherarranged(13) & vbCrLf & Arrangement.Teacherarranged(14) & "-" & Arrangement.Teacherarranged(15)
                End Select
            End If
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("信息发布成功！",MsgBoxStyle.OkOnly,"成功")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        MySub()
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        MySub()
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        MySub()
    End Sub

End Class