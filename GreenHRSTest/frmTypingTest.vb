Public Class frmTypingTest

    Dim TypingTestData As New clsTypingTest()
    Dim totalSeconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim time As String = ""

    Private Sub btnStartTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartTest.Click
        Try
            If comboStory.Items.Count = 0 Or comboStory.SelectedIndex = -1 Then
                MsgBox("Select A Story First.")
                Exit Sub
            End If

            Dim TypingTest As New clsTypingTest()

            TypingTest.ExamRollNo = txtRollNo.Text
            TypingTest.TypingTestID = comboStory.SelectedValue

            TypingTest = TypingTestData.fnStartTTExam(TypingTest)

            If TypingTest.Story = "" Then
                MsgBox("Input Correct Roll No.")
                Exit Sub
            Else
                txtStory.Text = TypingTest.Story
                StartTest(TypingTest.Duration)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Shared TypingTimer As Integer = 0

    Protected Sub StartTest(ByVal Duration As Integer)
        TypingTimer = Duration * 60
        timerTyping.Enabled = True
        grpStorySelection.Enabled = False
    End Sub

    Private Sub frmTypingTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetStoryListByCandidate(My.Settings.CandidateID)
        lblTimeRemaining.Text = "0"
    End Sub

    Protected Sub GetStoryListByCandidate(ByVal CandidateID As String)
        Try
            comboStory.DataSource = TypingTestData.fnGetAssignedStoryByCandidate(CandidateID).Tables(0)
            comboStory.DisplayMember = "StoryTopic"
            comboStory.ValueMember = "TypingTestID"
            comboStory.Text = "----- Select A Story -----"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub timerTyping_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTyping.Tick
        Try
            TypingTimer = Convert.ToInt16(TypingTimer) - 1
            If Convert.ToInt16(TypingTimer) <= 0 Then
                lblTimeRemaining.Text = "TimeOut!"
                CompleteExam()
            Else
                totalSeconds = Convert.ToInt16(TypingTimer)
                seconds = totalSeconds Mod 60
                minutes = Math.Floor(totalSeconds / 60)
                time = minutes.ToString() + ":" + seconds.ToString()
                lblTimeRemaining.Text = time
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub CompleteExam()
        Dim TypingTest As New clsTypingTest()
        TypingTest.TypingTestID = comboStory.SelectedValue
        TypingTest.Response = txtResponse.Text
        TypingTest = TypingTestData.fnStopTTExam(TypingTest)

        If TypingTest.Success = True Then
            StopExam()
            MsgBox("Exam Completed" & vbCrLf & vbCrLf & "WPM : " & TypingTest.WPM & vbCrLf & "Accuracy : " & TypingTest.Accuracy & vbCrLf & "Grade : " & TypingTest.Grade)
        Else
            MsgBox("Error Occured.")
        End If
    End Sub

    Protected Sub StopExam()
        timerTyping.Enabled = False
        GetStoryListByCandidate(My.Settings.CandidateID)
        txtRollNo.Text = ""
        grpStorySelection.Enabled = True
        txtResponse.Text = ""
        txtStory.Text = ""
    End Sub

    Private Sub frmTypingTest_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If TypingTimer <> 0 Then
            e.Cancel = True
            MsgBox("Exam Is Running. Can't Be Closed.")
        Else
            e.Cancel = False
        End If
    End Sub

End Class