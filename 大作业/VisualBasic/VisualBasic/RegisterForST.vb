Public Class RegisterForST

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox1.Text <> "" And TextBox3.Text <> "" Then
            Welcome.Names(UBound(Welcome.Names)) = TextBox1.Text
            Welcome.number(UBound(Welcome.number)) = TextBox2.Text
            Welcome.Passwords(UBound(Welcome.Passwords)) = TextBox3.Text
            ReDim Preserve Welcome.Names(UBound(Welcome.Names) + 1)
            ReDim Preserve Welcome.number(UBound(Welcome.number) + 1)
            ReDim Preserve Welcome.Passwords(UBound(Welcome.Passwords) + 1)

            SIgnInForST.Show()
            Me.Close()
        Else
            MsgBox("输入有误，请重新输入！", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "错误")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Focus()
        End If
    End Sub
End Class