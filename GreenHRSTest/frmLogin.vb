
Imports System.IO

Public Class frmLogin

    Dim Common As New Common()

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim UserID As String
        Dim Password As String
        Dim UserName As String
        Dim isLogin As Integer
        Dim DefaultPage As String
        Dim count As Integer
        Dim CandidateID As String
        Dim UniqueUserID As String = ""
        Dim UserType As String = ""
        Dim PermittedMenus As String = ""
        Dim strHostName As String = ""
        Dim strIPAddress As String = ""
        Dim ApplicationId As String = ""

        UserID = txtUserID.Text
        Password = txtPassword.Text

        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

        UserName = ""
        DefaultPage = ""

        If Trim(txtUserID.Text) = "" Or Trim(txtPassword.Text) = "" Then
            MsgBox("User ID & Password Correctly")
            Exit Sub
        End If

        isLogin = Common.isLogin(UserID, Password, strIPAddress, UserName, DefaultPage, UniqueUserID, UserType, PermittedMenus)
        If isLogin = 1 Then

            My.Settings.UserName = UserName
            My.Settings.UniqueUserID = UniqueUserID
            My.Settings.UserType = UserType

            If UserType = "Registered" Or UserType = "Candidate" Then
                Dim RegistrationID As String = Common.GetRegistrationID(UserID, Password)
                My.Settings.CandidateID = RegistrationID
                count = Common.CandidateCount(RegistrationID)

                If count <> 0 Then
                    CandidateID = Common.GetCandidateID(RegistrationID)
                    My.Settings.CandidateID = CandidateID
                Else
                    My.Settings.CandidateID = ""
                End If

                Dim Check As Integer = Common.SubmitUserLogInfo(UserID, Password, strIPAddress, RegistrationID)
                If Check = 0 Then

                End If

                Dim Master As New MDITest()
                Master.Show()

                Me.Visible = False
            Else
                MsgBox("Unauthorized User.")
            End If
        Else
            txtPassword.Text = ""
            txtUserID.Text = ""
            MsgBox("User ID or Password Incorrect.")
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnLogin.Focus()
        My.Settings.CanFormTestID = ""
        My.Settings.FTDuration = 0
        My.Settings.LoginUserID = ""
        My.Settings.CandidateID = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

End Class
