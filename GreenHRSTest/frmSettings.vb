Imports System.IO

Public Class frmSettings

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GetDrives()
            comboDrives.SelectedItem = My.MySettings.Default.LocalVoicePath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub GetDrives()
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()

        Dim d As DriveInfo
        For Each d In allDrives
            comboDrives.Items.Add(d.Name)
        Next
    End Sub

    Private Sub btnSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDefault.Click
        Try
            My.Settings.LocalVoicePath = comboDrives.SelectedItem
            My.Settings.Save()

            My.Settings.LocalVoicePath = comboDrives.SelectedValue
            MsgBox("Settings Done.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class