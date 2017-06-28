Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Public Class clsVoiceCapture

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Dim _VoiceID, _VoiceTestID, _CandidateID, _VoiceFile As String

    Public Property VoiceID() As String
        Get
            Return _VoiceID
        End Get
        Set(ByVal value As String)
            _VoiceID = value
        End Set
    End Property

    Public Property VoiceTestID() As String
        Get
            Return _VoiceTestID
        End Get
        Set(ByVal value As String)
            _VoiceTestID = value
        End Set
    End Property

    Public Property CandidateID() As String
        Get
            Return _CandidateID
        End Get
        Set(ByVal value As String)
            _CandidateID = value
        End Set
    End Property

    Public Property VoiceFile() As String
        Get
            Return _VoiceFile
        End Get
        Set(ByVal value As String)
            _VoiceFile = value
        End Set
    End Property

    Dim _EntryDate As DateTime

    Public Property EntryDate() As DateTime
        Get
            Return _EntryDate
        End Get
        Set(ByVal value As DateTime)
            _EntryDate = value
        End Set
    End Property

    Public Function fnInsertVoiceCapture(ByVal Voice As clsVoiceCapture) As Integer
        Try
            Dim cmd As SqlCommand = New SqlCommand("spInsertVoiceCapture", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CandidateID", Voice.CandidateID)
            cmd.Parameters.AddWithValue("@VoiceTestID", Voice.VoiceTestID)
            cmd.Parameters.AddWithValue("@VoiceFile", Voice.VoiceFile)
            cmd.ExecuteNonQuery()
            con.Close()
            Return 1
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return 0
        End Try
    End Function

    Public Function fnGetVoiceByCandidate(ByVal CandidateID As String) As DataSet

        Dim sp As String = "spGetVoiceByCandidate"
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim ds As DataSet = New DataSet()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CandidateID", CandidateID)
                da.SelectCommand = cmd
                da.Fill(ds)
                con.Close()
                Return ds
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return Nothing
        End Try
    End Function

End Class
