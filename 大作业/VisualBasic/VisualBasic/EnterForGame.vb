Public Class EnterForGame

    Sub JOININ1(ByRef a As String, ByRef b As Integer)
        Dim i As Integer
        For i = 0 To b
            If Welcome.StudentNames(i) = "" Then
                Exit For
            End If
        Next

        Welcome.StudentNames(i) = a
    End Sub

    Sub JOININ2(ByRef a As String, ByRef b As Integer)
        Dim i As Integer
        For i = 0 To b
            If Welcome.TeacherNames(i) = "" Then
                Exit For
            End If
        Next

        Welcome.TeacherNames(i) = a
    End Sub


    Sub JOININages(ByRef a As Integer, ByRef b As Integer)
        Dim i As Integer
        For i = 0 To b
            If Welcome.Teacherages(i) = 0 Then
                Exit For
            End If
        Next
        Welcome.Teacherages(i) = a
    End Sub

    Private Sub 报名_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label3.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            JOININ1(SIgnInForST.TextBox1.Text, UBound(Welcome.StudentNames))
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            Label1.Visible = True
        ElseIf RadioButton2.Checked = True Then
            If IsNumeric(TextBox1.Text) Then
                JOININ2(SIgnInForST.TextBox1.Text, UBound(Welcome.TeacherNames))
                JOININages(Val(TextBox1.Text), UBound(Welcome.Teacherages))
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                TextBox1.ReadOnly = True
                Label1.Visible = True
            Else
                MsgBox("请在年龄一栏输入数字", MsgBoxStyle.OkOnly, "error")
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label3.Visible = True
        TextBox1.Visible = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label3.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = ""
    End Sub
End Class