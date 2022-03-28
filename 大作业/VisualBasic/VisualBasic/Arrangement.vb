Public Class Arrangement

    Public Teacherarranged(15) As String
    Public Teacheragesarranged(15) As Integer
    Public Studentarranged(7) As String

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        MsgBox("抽签规则如下：" & vbCrLf & "学生组随机抽签" & vbCrLf & "教职工组按年龄分配," & vbCrLf & "年龄最小的与年龄最大的一组，依此类推", MsgBoxStyle.OkOnly, "抽签规则")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Check.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Width = 750
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click '抽签
        Dim i As Integer
        For i = 0 To 14 Step 2
            Teacherarranged(i) = STinformation.TeacherNamesATgame(i / 2)
            Teacheragesarranged(i) = STinformation.TeacherAgesATgame(i / 2)
        Next
        For i = 1 To 15 Step 2
            Teacherarranged(i) = STinformation.TeacherNamesATgame(15 - (i - 1) / 2)
            Teacheragesarranged(i) = STinformation.TeacherAgesATgame(15 - (i - 1) / 2)
        Next

        Dim num As Integer
        Dim a As Integer
        Dim bool(8) As Integer
        Dim a1 As Integer
        Do While num <> 8
            Randomize()
            a = Int(Rnd() * 8)
            If bool(a) = 0 Then
                bool(a) = 1
                num = num + 1
                For a1 = 0 To UBound(Studentarranged)
                    If Studentarranged(a1) = "" Then
                        Exit For
                    End If
                Next
                Studentarranged(a1) = STinformation.StudentNamesATgame(a)
            End If
        Loop

        TextBox1.Text = ""
        Dim j As Integer
        For j = 0 To 7
            TextBox1.Text &= Studentarranged(j) & vbCrLf
        Next

        TextBox2.Text = Space(5) & "姓名" & Space(6) & "年龄" & vbCrLf
        For j = 0 To 15
            TextBox2.Text &= vbCrLf & Space(5) & Teacherarranged(j) & Space(11 - Len(Teacherarranged(j))) & Teacheragesarranged(j)
        Next

        Button2.Enabled = False
    End Sub

    Private Sub Arrangement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        Dim j As Integer
        Dim index As Integer
        Dim t1 As Integer
        Dim t2 As String
        For i = 0 To UBound(STinformation.TeacherAgesATgame)
            index = i
            For j = i + 1 To UBound(STinformation.TeacherAgesATgame)
                If STinformation.TeacherAgesATgame(index) > STinformation.TeacherAgesATgame(j) Then
                    index = j
                End If
            Next
            t1 = STinformation.TeacherAgesATgame(i)
            STinformation.TeacherAgesATgame(i) = STinformation.TeacherAgesATgame(index)
            STinformation.TeacherAgesATgame(index) = t1
            t2 = STinformation.TeacherNamesATgame(i)
            STinformation.TeacherNamesATgame(i) = STinformation.TeacherNamesATgame(index)
            STinformation.TeacherNamesATgame(index) = t2
        Next

        For i = 0 To UBound(STinformation.StudentNamesATgame)
            TextBox1.Text &= STinformation.StudentNamesATgame(i) & vbCrLf
        Next

        TextBox2.Text = Space(5) & "姓名" & Space(6) & "年龄" & vbCrLf
        For i = 0 To UBound(STinformation.TeacherNamesATgame)
            TextBox2.Text &= vbCrLf & Space(5) & STinformation.TeacherNamesATgame(i) & Space(11 - Len(STinformation.TeacherNamesATgame(i))) & STinformation.TeacherAgesATgame(i)
        Next

    End Sub
End Class