Public Class SignInForOrganizer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox2.Text) Then
            If TextBox1.Text = "Admin" And TextBox2.Text = "12345678" Then
                Timeset.Show()
                Me.Hide()
            Else
                MsgBox("用户名或密码错误，请重新输入", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "用户名或密码错误")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            End If
        Else
            MsgBox("请输入正确的格式", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            TextBox2.Text = ""
            TextBox2.Focus()
        End If
    End Sub
End Class