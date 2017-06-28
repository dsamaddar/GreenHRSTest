Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsVoiceTest

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)
    Dim _VoiceTestID, _CandidateID, _StoryID, _ExamRollNo, _Story, _AssignedBy As String

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

    Public Property StoryID() As String
        Get
            Return _StoryID
        End Get
        Set(ByVal value As String)
            _StoryID = value
        End Set
    End Property

    Public Property ExamRollNo() As String
        Get
            Return _ExamRollNo
        End Get
        Set(ByVal value As String)
            _ExamRollNo = value
        End Set
    End Property

    Public Property Story() As String
        Get
            Return _Story
        End Get
        Set(ByVal value As String)
            _Story = value
        End Set
    End Property

    Public Property AssignedBy() As String
        Get
            Return _AssignedBy
        End Get
        Set(ByVal value As String)
            _AssignedBy = value
        End Set
    End Property

    Dim _StartTime, _EndTime, _AssignedOn As DateTime

    Public Property StartTime() As DateTime
        Get
            Return _StartTime
        End Get
        Set(ByVal value As DateTime)
            _StartTime = value
        End Set
    End Property

    Public Property EndTime() As DateTime
        Get
            Return _EndTime
        End Get
        Set(ByVal value As DateTime)
            _EndTime = value
        End Set
    End Property

    Public Property AssignedOn() As DateTime
        Get
            Return _AssignedOn
        End Get
        Set(ByVal value As DateTime)
            _AssignedOn = value
        End Set
    End Property

    Dim _IsActive As Boolean

    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property

    Public Function fnGetAssignedStoryByCandidateVT(ByVal CandidateID As String) As DataSet
        Dim sp As String = "spGetAssignedStoryByCandidateVT"
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

#Region " Insert Voice Test "

    Public Function fnInsertVoiceTest(ByVal VoiceTest As clsVoiceTest) As Integer
        Try
            Dim cmd As SqlCommand = New SqlCommand("spInsertVoiceTest", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@CandidateID", VoiceTest.CandidateID)
            cmd.Parameters.AddWithValue("@StoryID", VoiceTest.StoryID)
            cmd.Parameters.AddWithValue("@AssignedBy", VoiceTest.AssignedBy)
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

#End Region

#Region " Start VT Exam "

    Public Function fnStartVTExam(ByVal VoiceTest As clsVoiceTest) As clsVoiceTest
        Dim sp As String = "spStartVTExam"
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@VoiceTestID", VoiceTest.VoiceTestID)
                cmd.Parameters.AddWithValue("@ExamRollNo", VoiceTest.ExamRollNo)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    VoiceTest.Story = dr.Item("Story")
                End While
                con.Close()
                Return VoiceTest
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return Nothing
        End Try
    End Function

#End Region

#Region " Stop VT Exam "

    Public Function fnStopVTExam(ByVal VoiceTest As clsVoiceTest) As Integer
        Try
            Dim cmd As SqlCommand = New SqlCommand("spStopVTExam", con)
            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@VoiceTestID", VoiceTest.VoiceTestID)
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

#End Region

End Class
