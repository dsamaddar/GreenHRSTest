Public Class frmFormTest

    Dim FormTestData As New clsCanFormTest()

    Private Sub btnStartFormTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartFormTest.Click
        Try
            If comboFormList.Items.Count = 0 Or comboFormList.SelectedIndex = -1 Then
                MsgBox("Select A Form First.")
                Exit Sub
            End If

            If Trim(txtExamRollNo.Text) = "" Then
                MsgBox("Input Exam Roll No.")
                Exit Sub
            End If

            Dim FormTest As New clsCanFormTest()

            FormTest.ExamRollNo = txtExamRollNo.Text
            FormTest.CanFormTestID = comboFormList.SelectedValue

            FormTest = FormTestData.fnStartFTExam(FormTest)

            If FormTest.Duration = 0 Then
                MsgBox("Input Correct Roll No.")
                Exit Sub
            Else
                My.Settings.FTDuration = FormTest.Duration
                My.Settings.CanFormTestID = comboFormList.SelectedValue

                If comboFormList.Text = "Organizational Information Form" Then
                    Dim OIF As New frmOrgInformationForm()
                    OIF.MdiParent = Me.MdiParent
                    OIF.Show()
                ElseIf comboFormList.Text = "Personal Information Form" Then
                    Dim PIF As New frmPerInformationForm()
                    PIF.MdiParent = Me.MdiParent
                    PIF.Show()
                ElseIf comboFormList.Text = "Personal Information Form - Asset" Then
                    Dim PIFA As New frmPersonalInfFormAsset()
                    PIFA.MdiParent = Me.MdiParent
                    PIFA.Show()
                ElseIf comboFormList.Text = "Credit Facility Form - Asset" Then
                    Dim CF As New frmCreditFacilityFormAsset()
                    CF.MdiParent = Me.MdiParent
                    CF.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Dispose()
    End Sub

    Protected Sub GetFormListByCandidate(ByVal CandidateID As String)
        Try
            comboFormList.DataSource = FormTestData.fnGetAssignedFormTestByCandidate(CandidateID).Tables(0)
            comboFormList.DisplayMember = "FormTitle"
            comboFormList.ValueMember = "CanFormTestID"
            comboFormList.Text = "----- Select A Form -----"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFormTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetFormListByCandidate(My.Settings.CandidateID)
    End Sub

End Class