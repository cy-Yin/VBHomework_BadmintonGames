Public Class SIgnInForST

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RegisterForST.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim bool As Integer = 0
        If TextBox1.Text <> "" Then
            For i = 0 To UBound(Welcome.Names) - 1
                If TextBox1.Text = Welcome.Names(i) And TextBox2.Text = Welcome.number(i) And TextBox3.Text = Welcome.Passwords(i) Then
                    MsgBox("登录成功!", MsgBoxStyle.OkOnly, "登录")
                    Welcome.Label1.Text = TextBox1.Text & "，欢迎您！"
                    Welcome.Button1.Enabled = False
                    Me.Hide()
                    Welcome.Show()
                    bool = 1
                End If
            Next
        End If

        If bool = 0 Then
            MsgBox("登录失败，请重新尝试或者先进行注册", MsgBoxStyle.OkOnly, "登录")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Focus()
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()
        Welcome.Show()
    End Sub
End Class