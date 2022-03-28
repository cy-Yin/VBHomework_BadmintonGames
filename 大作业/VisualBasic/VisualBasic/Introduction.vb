Public Class Introduction

    Dim time As Integer = 60

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "本窗口将在" & time & "秒内关闭"
        Timer1.Enabled = True
        TextBox1.Text = "本届""希望杯""公益羽毛球赛为首次开赛，分为上下午场一共8场比赛。" & vbCrLf & "比赛共分为学生组和教职工组。" & vbCrLf & "其中学生组一共8个名额,均为单打比赛。" & vbCrLf & "教职工组一共16个名额，将抽签组成8支双打队伍进行比赛。" & vbCrLf & "比赛为淘汰赛制，每场比赛赢者进入下一轮。" & vbCrLf & """希望杯""羽毛球赛,等待着您的加入！"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time = time - 1
        Label1.Text = "本窗口将在" & time & "秒内关闭"
        If time = 0 Then
            Me.Close()
            Welcome.Show()
        End If
    End Sub
End Class