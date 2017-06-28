Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports System.Net

Public Class frmVoiceTest

    Shared VoiceName As String = ""
    Dim VoiceTestData As New clsVoiceTest()

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" _
(ByVal lpstrCommand As String, ByVal lpstrReturnString As String, _
ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        Try
            VoiceName = "Voice_" & DateTime.Now.ToString("ddMMyyHHmmss") & ".wav"

            mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
            mciSendString("record recsound", "", 0, 0)
            btnSave.Enabled = True
            Timer = 0
            timerVoice.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub GetStoryListByCandidate(ByVal CandidateID As String)
        Try
            comboStory.DataSource = VoiceTestData.fnGetAssignedStoryByCandidateVT(CandidateID).Tables(0)
            comboStory.DisplayMember = "StoryTopic"
            comboStory.ValueMember = "VoiceTestID"
            comboStory.Text = "----- Select A Story -----"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim VoiceData As New clsVoiceCapture()

    Protected Sub GetVoiceByCandidate(ByVal CandidateID As String)
        grdVoiceList.DataSource = VoiceData.fnGetVoiceByCandidate(CandidateID)
        grdVoiceList.DataMember = "Table"
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Try
            If VoiceName = "" Then
                MsgBox("No Voice Recorded Currently.")
                Exit Sub
            End If

            Dim Storage As String = My.Settings.AttachmentsShow & VoiceName
            Dim C As Computer = New Computer()
            C.Audio.Play(Storage, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim Storage As String = My.Settings.LocalVoicePath & "\" & VoiceName
            mciSendString("save recsound " & Storage, "", 0, 0)
            mciSendString("close recsound ", "", 0, 0)
            Dim C As Computer = New Computer()
            C.Audio.Stop()
            timerVoice.Enabled = False

            Dim fs As System.IO.Stream = File.OpenRead(Storage)
            Dim br As New System.IO.BinaryReader(fs)
            Dim bytes As Byte() = br.ReadBytes(CType(fs.Length, Integer))
            UploadFile(VoiceName, bytes)

            Dim Voice As New clsVoiceCapture()
            Voice.VoiceFile = VoiceName
            Voice.VoiceTestID = comboStory.SelectedValue
            Voice.CandidateID = My.Settings.UniqueUserID
            Dim Check As Integer = Voice.fnInsertVoiceCapture(Voice)

            If Check = 1 Then
                GetVoiceByCandidate(My.Settings.UniqueUserID)
                GetStoryListByCandidate(My.Settings.CandidateID)
                txtRollNo.Text = ""
                txtStory.Text = ""
                grpStorySelection.Enabled = True
                MsgBox("Voice Saved.")
            End If

            btnSave.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub UploadFile(ByVal FileName As String, ByVal filebyte As Byte())
        Try
            Dim webClient As WebClient = New WebClient()
            Dim FileSavePath As String = My.Settings.LocalVoicePath & "\" & FileName
            webClient.UploadFile("http://192.168.1.132/HRMAttachments/Upload.aspx", FileSavePath)
            webClient.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmVoiceTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetVoiceByCandidate(My.Settings.UniqueUserID)
        btnSave.Enabled = False
        timerVoice.Enabled = False
        txtStory.Enabled = False
        grpCaptureVoice.Enabled = False
        GetStoryListByCandidate(My.Settings.CandidateID)
    End Sub

    Shared Timer As Integer = 0

    Private Sub timerVoice_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerVoice.Tick
        Timer += 1
        lblTimer.Text = "Recorded Time : " & Timer.ToString() & " s"
    End Sub

    Private Sub btnStartTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartTest.Click

        Dim VoiceTest As New clsVoiceTest()

        VoiceTest.ExamRollNo = txtRollNo.Text
        VoiceTest.VoiceTestID = comboStory.SelectedValue

        VoiceTest = VoiceTestData.fnStartVTExam(VoiceTest)


        If VoiceTest.Story = "" Then
            MsgBox("Input Correct Roll No.")
            Exit Sub
        Else
            txtStory.Text = VoiceTest.Story
            txtStory.Enabled = True
            grpCaptureVoice.Enabled = True
            grpStorySelection.Enabled = False
        End If

    End Sub
End Class