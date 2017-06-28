Imports Microsoft.VisualBasic.Devices
Imports System.IO
Imports System.Net

Public Class frmHomePage

    Dim UserMSGData As New clsUserMessageDataAccess()

    Private Sub frmHomePage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim UniqueUserID = My.Settings.UniqueUserID
            Dim UserID = My.Settings.LoginUserID

            If UniqueUserID <> "" Then
                GetUserMessage(UniqueUserID)
                GetUserMsgFeedback(UserID)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub GetUserMessage(ByVal UniqueUserID As String)
        grdCandidatesMsg.DataSource = UserMSGData.fnShowMessageByUser(UniqueUserID)
        grdCandidatesMsg.DataMember = "Table"
    End Sub

    Protected Sub GetUserMsgFeedback(ByVal UserID As String)
        grdQueryFeedback.DataSource = UserMSGData.fnShowMegFeedback(UserID)
        grdQueryFeedback.DataMember = "Table"
    End Sub

End Class