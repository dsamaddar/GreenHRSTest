Imports System
Imports System.Collections
Imports System.Configuration
Imports System.Linq
Imports System.Web
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml.Linq
Imports System.IO

Public Class Common

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Public Function isLogin(ByVal UserID As String, ByVal Password As String, ByVal IP As String, ByRef UserName As String, ByRef DefaultPage As String, ByRef UniqueUserID As String, ByRef UserType As String, ByRef PermittedMenus As String) As Integer
        Dim sp As String = "prLogin"
        Dim isAut As Integer
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@UserID", UserID)
                cmd.Parameters.AddWithValue("@Password", Password)
                cmd.Parameters.AddWithValue("@IP", IP)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    isAut = dr.Item("isAuth")
                    UserName = dr.Item("username")
                    DefaultPage = dr.Item("defaultpage")
                    UniqueUserID = dr.Item("UniqueUserID")
                    UserType = dr.Item("UserType")
                    PermittedMenus = dr.Item("PermittedMenus")
                End While
                con.Close()
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
                isAut = 0
            End If
        End Try
        Return isAut
    End Function

    Public Function CandidateCount(ByVal RegistrationID As String) As Integer

        Dim cmd As New SqlCommand()
        Dim rd As SqlDataReader
        Dim rtn As Integer
        Try
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "Select count(1) from tblCandidateBasicInfo where RegistrationID='" & RegistrationID & "'"
            rd = cmd.ExecuteReader()

            rtn = 0
            While (rd.Read())
                rtn = rd.GetValue(0)
            End While
            con.Close()
            Return rtn
        Catch ex As SqlException
            If con.State = ConnectionState.Open Then
                con.Close()
                Return 0
            End If
        End Try
    End Function

    Public Function GetCandidateID(ByVal RegistrationID As String) As String

        Dim cmd As New SqlCommand()
        Dim rd As SqlDataReader
        Dim rtn As String = ""
        Try
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "Select CandidateID from tblCandidateBasicInfo where RegistrationID='" & RegistrationID & "'"
            rd = cmd.ExecuteReader()

            'rtn = 0
            While (rd.Read())
                rtn = rd.GetValue(0)
            End While
            con.Close()
            Return rtn
        Catch ex As SqlException
            If con.State = ConnectionState.Open Then
                con.Close()
                Return Nothing
            End If
        End Try
        Return ""
    End Function


    Public Function SubmitUserLogInfo(ByVal UserID As String, ByVal PassWord As String, ByVal IPAddress As String, ByVal RegistrationID As String) As Integer
        Dim cmd As New SqlCommand()
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "exec prUserLoginLogAdd '" & UserID & "','" & PassWord & "','" & IPAddress & "','" & RegistrationID & "'"
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            con.Close()

            con.Close()
            Return 1
        Catch ex As SqlException
            If con.State = ConnectionState.Open Then
                con.Close()
                Return 0
            End If
        End Try
    End Function

    Public Function GetRegistrationID(ByVal UserID As String, ByVal Password As String) As String
        Dim cmd As New SqlCommand()
        Dim rd As SqlDataReader
        Dim rtn As String = ""
        Try
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "Select RegistrationID from tblRegisterUser where UserID='" & UserID & "'and Password='" & Password & "'"
            rd = cmd.ExecuteReader()

            'rtn = 0
            While (rd.Read())
                rtn = rd.GetValue(0)
            End While
            con.Close()
            Return rtn
        Catch ex As SqlException
            If con.State = ConnectionState.Open Then
                con.Close()
                Return Nothing
            End If
        End Try
        Return rtn
    End Function

End Class
