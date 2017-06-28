Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsCanFormTest

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Dim _FormID, _CanFormTestID, _CandidateID, _ExamRollNo, _AssignedBy As String
    Dim _Duration As Integer

    Public Property FormID() As String
        Get
            Return _FormID
        End Get
        Set(ByVal value As String)
            _FormID = value
        End Set
    End Property

    Public Property CanFormTestID() As String
        Get
            Return _CanFormTestID
        End Get
        Set(ByVal value As String)
            _CanFormTestID = value
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

    Public Property ExamRollNo() As String
        Get
            Return _ExamRollNo
        End Get
        Set(ByVal value As String)
            _ExamRollNo = value
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

    Public Property Duration() As Integer
        Get
            Return _Duration
        End Get
        Set(ByVal value As Integer)
            _Duration = value
        End Set
    End Property

#Region " Insert Candidate Form Test "

    Public Function fnInsertCandidateFormTest(ByVal Form As clsCanFormTest) As Integer
        Dim sp As String = "spInsertCandidateFormTest"
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CandidateID", Form.CandidateID)
                cmd.Parameters.AddWithValue("@FormID", Form.FormID)
                cmd.Parameters.AddWithValue("@AssignedBy", Form.AssignedBy)
                cmd.ExecuteNonQuery()
                con.Close()
                Return 1
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return 0
        End Try
    End Function

#End Region

    Public Function fnGetFormTestScore(ByVal CandidateID As String) As DataSet
        Dim sp As String = "spGetFormTestScore"
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

    Public Function fnGetAssignedFormTestByCandidate(ByVal CandidateID As String) As DataSet
        Dim sp As String = "spGetAssignedFormTestByCandidate"
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

#Region " Start FT Exam "

    Public Function fnStartFTExam(ByVal Form As clsCanFormTest) As clsCanFormTest
        Dim sp As String = "spStartFTExam"
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CanFormTestID", Form.CanFormTestID)
                cmd.Parameters.AddWithValue("@ExamRollNo", Form.ExamRollNo)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    Form.Duration = dr.Item("Duration")
                End While
                con.Close()
                Return Form
            End Using
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Return Nothing
        End Try
    End Function

#End Region

#Region " Stop FT Exam "

    Public Function fnStopFTExam(ByVal CanFormTestID As String, ByVal FormTestValueString As String) As Double
        Dim sp As String = "spStopFTExam"
        Dim Accuracy As Double = 0
        Dim dr As SqlDataReader
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CanFormTestID", CanFormTestID)
                cmd.Parameters.AddWithValue("@FormTestValueString", FormTestValueString)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    Accuracy = dr.Item("Accuracy")
                End While
                con.Close()
                Return Accuracy
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
