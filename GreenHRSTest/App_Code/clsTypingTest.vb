Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsTypingTest

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)
    Dim _TypingTestID, _CandidateID, _StoryID, _ExamRollNo, _Story, _Response, _AssignedBy As String

    Public Property TypingTestID() As String
        Get
            Return _TypingTestID
        End Get
        Set(ByVal value As String)
            _TypingTestID = value
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

    Public Property Response() As String
        Get
            Return _Response
        End Get
        Set(ByVal value As String)
            _Response = value
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

    Dim _WPM, _Accuracy, _Grade, _Duration As Integer

    Public Property WPM() As Integer
        Get
            Return _WPM
        End Get
        Set(ByVal value As Integer)
            _WPM = value
        End Set
    End Property

    Public Property Accuracy() As Integer
        Get
            Return _Accuracy
        End Get
        Set(ByVal value As Integer)
            _Accuracy = value
        End Set
    End Property

    Public Property Grade() As Integer
        Get
            Return _Grade
        End Get
        Set(ByVal value As Integer)
            _Grade = value
        End Set
    End Property

    Public Property Duration() As Integer
        Get
            Return _Duration
        End Get
        Set(ByVal value As Integer)
            _Duration = value
        End Set
    End Property

    Dim _IsActive, _Success As Boolean

    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property

    Public Property Success() As Boolean
        Get
            Return _Success
        End Get
        Set(ByVal value As Boolean)
            _Success = value
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

#Region " Insert Typing Test "

    Public Function fnInsertTypingTest(ByVal TypingTest As clsTypingTest) As Integer
        Dim sp As String = "spInsertTypingTest"
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CandidateID", TypingTest.CandidateID)
                cmd.Parameters.AddWithValue("@StoryID", TypingTest.StoryID)
                cmd.Parameters.AddWithValue("@AssignedBy", TypingTest.AssignedBy)
                cmd.ExecuteNonQuery()
                con.Close()
                Return 0
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return 1
        End Try
    End Function

#End Region

    Public Function fnGetTypingTestScore(ByVal CandidateID As String) As DataSet
        Dim sp As String = "spGetTypingTestScore"
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

    Public Function fnGetAssignedStoryByCandidate(ByVal CandidateID As String) As DataSet
        Dim sp As String = "spGetAssignedStoryByCandidate"
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

#Region " Start TT Exam "

    Public Function fnStartTTExam(ByVal TypingTest As clsTypingTest) As clsTypingTest
        Dim sp As String = "spStartTTExam"
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@TypingTestID", TypingTest.TypingTestID)
                cmd.Parameters.AddWithValue("@ExamRollNo", TypingTest.ExamRollNo)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    TypingTest.Story = dr.Item("Story")
                    TypingTest.Duration = dr.Item("Duration")
                End While
                con.Close()
                Return TypingTest
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return Nothing
        End Try
    End Function

#End Region

#Region " Start TT Exam "

    Public Function fnStopTTExam(ByVal TypingTest As clsTypingTest) As clsTypingTest
        Dim sp As String = "spStopTTExam"
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@TypingTestID", TypingTest.TypingTestID)
                cmd.Parameters.AddWithValue("@Response", TypingTest.Response)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    TypingTest.WPM = dr.Item("WPM")
                    TypingTest.Accuracy = dr.Item("Accuracy")
                    TypingTest.Grade = dr.Item("Grade")
                    TypingTest.Success = dr.Item("Success")
                End While
                con.Close()
                Return TypingTest
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return Nothing
        End Try
    End Function

#End Region

End Class
