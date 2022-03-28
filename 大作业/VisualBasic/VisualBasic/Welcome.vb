Public Class Welcome

    Dim x As Integer 'timer1控制器
    Dim boolString As String

    '参赛方登录/注册
    Public Names(0) As String
    Public StudentNames(7) As String
    Public TeacherNames(15) As String
    Public number(0) As String
    Public Passwords(0) As String
    Public Teacherages(15) As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = "未登录"
        Button2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        x = x + 1
        Select Case (x Mod 3)
            Case 0
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
            Case 1
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
            Case 2
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
        End Select

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ifexit As Integer
        ifexit = Val(MsgBox("确定要退出吗？", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "退出"))
        If ifexit = 1 Then
            End
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click '登录
        boolString = LCase(InputBox("请问您是赛事的承办方吗？若是请输入""y""，否则请输入""n""", "登录/注册"))
        If boolString = "y" Then
            SignInForOrganizer.Show()
            Me.Hide()
        Else
            If boolString = "n" Then
                SIgnInForST.Show()
                Me.Hide()
                Button2.Enabled = True
                报名ToolStripMenuItem.Enabled = True
            Else
                MsgBox("您的输入有误，请重新输入", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "错误")
            End If
        End If
    End Sub

    Private Sub 赛事介绍ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 赛事介绍ToolStripMenuItem.Click
        Introduction.Show()
        Me.Hide()
    End Sub

    Private Sub 退出EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出EToolStripMenuItem.Click
        Dim ifexit As Integer
        ifexit = Val(MsgBox("确定要退出吗？", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "退出"))
        If ifexit = 1 Then
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click '报名
        EnterForGame.Show()
        Me.Hide()
    End Sub

    Private Sub 报名ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 报名ToolStripMenuItem.Click
        EnterForGame.Show()
        Me.Hide()
    End Sub
End Class
