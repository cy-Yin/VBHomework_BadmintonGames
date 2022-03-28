Public Class STinformation

    '参赛人员信息,其中已经录入部分
    Public StudentNamesATgame() As String = {"Egan", "Trevor", "Kerry", "Elga", "Alina", "Eddie", "", ""}
    Public TeacherNamesATgame() As String = {"Merlin", "Edan", "Willette", "Effie", "Pansy", "Myrtle", "Sherard", "Spencer", "Dorian", "Brittany", "Sarah", "Egil", "", "", "", ""}
    Public TeacherAgesATgame() As Integer = {43, 36, 54, 61, 35, 67, 64, 36, 45, 41, 63, 46, 0, 0, 0, 0}

    Private Sub STinformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True

        TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf

        Dim i As Integer
        For i = 0 To 11
            TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
        Next

        For i = 0 To 5
            ListBox1.Items.Add(StudentNamesATgame(i))
        Next

        Button10.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Text = "参赛学生信息"

            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            ListBox1.Visible = True

            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Text = "参赛教职工信息"

            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            ListBox1.Visible = False

            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If TextBox1.Text = ListBox1.Items(i) Then
                ListBox1.SelectedItem = ListBox1.Items(i)
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text <> "" Then
            If ListBox1.Items.Count < 8 Then
                ListBox1.Items.Add(TextBox2.Text)

                Dim i As Integer
                For i = 0 To UBound(StudentNamesATgame)
                    If StudentNamesATgame(i) = "" Then
                        Exit For
                    End If
                Next
                StudentNamesATgame(i) = TextBox2.Text
            Else
                MsgBox("参赛学生人数超出，请重新录入", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "人数超出")
                TextBox2.Text = ""
                TextBox2.Focus()
            End If
        Else
            MsgBox("请先输入", MsgBoxStyle.OkOnly, "提示")
        End If
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If TextBox3.Text = ListBox1.Items(i) Then
                Exit For
            End If
        Next
        If i <= ListBox1.Items.Count - 1 Then
            ListBox1.Items.RemoveAt(i)
            StudentNamesATgame(i) = ""
        End If
        
        Dim j As Integer
        For j = i To UBound(StudentNamesATgame) - 1
            StudentNamesATgame(j) = StudentNamesATgame(j + 1)
        Next
        StudentNamesATgame(UBound(StudentNamesATgame)) = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox1.SelectedIndex <> -1 Then
            StudentNamesATgame(ListBox1.SelectedIndex) = ""
            Dim j As Integer
            For j = ListBox1.SelectedIndex To UBound(StudentNamesATgame) - 1
                StudentNamesATgame(j) = StudentNamesATgame(j + 1)
            Next
            StudentNamesATgame(UBound(StudentNamesATgame)) = ""
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Else
            MsgBox("请先选中", MsgBoxStyle.OkOnly, "提示")
        End If
        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If StudentNamesATgame(7) <> "" And TeacherNamesATgame(15) <> "" And TeacherAgesATgame(15) <> 0 Then
            Me.Hide()
            Arrangement.Show()
        Else
            MsgBox("请完成信息录入", MsgBoxStyle.OkOnly, "提醒")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer
        Dim a As Integer
        For a = 0 To UBound(TeacherAgesATgame)
            If TeacherAgesATgame(a) = 0 Then
                Exit For
            End If
        Next
        If IsNumeric(TextBox4.Text) Then
            TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
            For i = 0 To a - 1
                If Val(TextBox4.Text) = TeacherAgesATgame(i) Then
                    TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
                End If
            Next
        Else
            MsgBox("输入格式有误，请重新输入", MsgBoxStyle.OkOnly, "错误")
            TextBox4.Text = ""
            TextBox4.Focus()
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As Integer
        Dim a As Integer
        For a = 0 To UBound(TeacherAgesATgame)
            If TeacherNamesATgame(a) = "" Then
                Exit For
            End If
        Next
        TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
        For i = 0 To a - 1
            If TextBox5.Text = TeacherNamesATgame(i) Then
                TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
            End If
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim a As Integer
        If TextBox6.Text <> "" Then
            If TeacherNamesATgame(15) = "" Then
                For a = 0 To UBound(TeacherAgesATgame)
                    If TeacherNamesATgame(a) = "" Then
                        Exit For
                    End If
                Next
                TeacherNamesATgame(a) = TextBox6.Text

                TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
                Dim i As Integer
                For i = 0 To a
                    TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
                Next
            Else
                MsgBox("参赛教职工人数超出", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "人数超出")
                TextBox6.Text = ""
                TextBox6.Focus()
                Button10.Enabled = True
            End If
        End If
        
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If TeacherAgesATgame(15) = 0 Then
            Dim b As Integer
            For b = 0 To UBound(TeacherAgesATgame)
                If TeacherAgesATgame(b) = 0 Then
                    Exit For
                End If
            Next

            Dim temp As String
            temp = InputBox("请输入剩下未录入的参赛者的年龄" & vbCrLf & "中间用英文逗号"",""隔开", "输入年龄")
            Dim A() As String
            A = Split(temp, ",")
            Dim temp1(UBound(A)) As Integer

            Dim a1 As Integer
            For a1 = 0 To UBound(A)
                If IsNumeric(A(a1)) Then
                    temp1(a1) = Val(A(a1))
                End If
            Next

            Dim i As Integer
            Dim j As Integer = 0
            For i = b To UBound(TeacherAgesATgame)
                If j <= UBound(temp1) Then
                    TeacherAgesATgame(i) = temp1(j)
                    j = j + 1
                End If
            Next

            Dim a2 As Integer
            For a2 = 0 To UBound(TeacherAgesATgame)
                If TeacherNamesATgame(a2) = "" Then
                    Exit For
                End If
            Next

            TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
            For i = 0 To a2 - 1
                TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
            Next
        Else
            Button11.Enabled = False
        End If
       
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim a As Integer
        For a = 0 To UBound(TeacherAgesATgame)
            If TeacherNamesATgame(a) = "" Then
                Exit For
            End If
        Next

        Dim i As Integer
        For i = 0 To a - 1
            If TextBox7.Text = TeacherNamesATgame(i) Then
                Exit For
            End If
        Next

        TeacherAgesATgame(i) = 0
        TeacherNamesATgame(i) = ""

        Dim j As Integer
        For j = i To UBound(TeacherNamesATgame) - 1
            TeacherAgesATgame(j) = TeacherAgesATgame(j + 1)
            TeacherNamesATgame(j) = TeacherNamesATgame(j + 1)
        Next
        TeacherAgesATgame(15) = 0
        TeacherNamesATgame(15) = ""

        Dim a1 As Integer
        For a1 = 0 To UBound(TeacherAgesATgame)
            If TeacherNamesATgame(a1) = "" Then
                Exit For
            End If
        Next
        TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
        For i = 0 To a1 - 1
            TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
        Next
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim i, j As Integer
        Dim index As Integer
        Dim t1 As Integer
        Dim t2 As String
        For i = 0 To UBound(TeacherAgesATgame)
            index = i
            For j = i + 1 To UBound(TeacherAgesATgame)
                If TeacherAgesATgame(index) > TeacherAgesATgame(j) Then
                    index = j
                End If
            Next
            t1 = TeacherAgesATgame(i)
            TeacherAgesATgame(i) = TeacherAgesATgame(index)
            TeacherAgesATgame(index) = t1
            t2 = TeacherNamesATgame(i)
            TeacherNamesATgame(i) = TeacherNamesATgame(index)
            TeacherNamesATgame(index) = t2
        Next

        TextBox8.Text = Space(10) & "姓名" & Space(10) & "年龄" & vbCrLf
        For i = 0 To UBound(TeacherAgesATgame)
            TextBox8.Text &= vbCrLf & Space(10) & TeacherNamesATgame(i) & Space(15 - Len(TeacherNamesATgame(i))) & TeacherAgesATgame(i)
        Next
    End Sub
End Class