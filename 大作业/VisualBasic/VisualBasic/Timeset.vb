Public Class Timeset

    Dim day As Integer
    Dim month As Integer
    Dim StartDate As Date = Now()
    Dim EndDate As Date
    
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label5.Text = TrackBar1.Value + 1
    End Sub

    Private Sub Timeset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = TrackBar1.Value + 1
        Label1.Text &= Format(Now, "Long Date")
        Button3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TrackBar1.Enabled = True
        Select Case ComboBox2.SelectedIndex
            Case 0, 2, 4, 7, 8, 10, 11
                TrackBar1.Maximum = 30
            Case 1
                TrackBar1.Maximum = 27
            Case 3, 5, 8, 10
                TrackBar1.Maximum = 29
        End Select
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TrackBar1.Value = 0
        ComboBox2.SelectedIndex = -1
        TrackBar1.Enabled = False
        Button1.Enabled = False
        Button3.Enabled = False
        Label6.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        month = ComboBox2.SelectedIndex + 1
        day = TrackBar1.Value + 1
        EndDate = CDate("2022-" & CStr(month) & "-" & CStr(day))

        Dim daydif As Integer
        daydif = DateDiff("d", StartDate, EndDate)
        If daydif >= 0 Then
            Label6.Text = "距离比赛还有" & daydif & "天"
            Button3.Enabled = True
        Else
            MsgBox("设置错误，请重新设置时间", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "设置错误")
            TrackBar1.Value = 0
            ComboBox2.SelectedIndex = -1
            TrackBar1.Enabled = False
            Button1.Enabled = False
            Label6.Text = ""
        End If
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        STinformation.Show()
    End Sub
End Class