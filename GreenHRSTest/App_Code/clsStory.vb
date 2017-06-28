Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data


Public Class clsStory

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)
    Dim _StoryID, _StoryTopic, _Story, _EntryBy As String

    Public Property StoryID() As String
        Get
            Return _StoryID
        End Get
        Set(ByVal value As String)
            _StoryID = value
        End Set
    End Property

    Public Property StoryTopic() As String
        Get
            Return _StoryTopic
        End Get
        Set(ByVal value As String)
            _StoryTopic = value
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

    Public Property EntryBy() As String
        Get
            Return _EntryBy
        End Get
        Set(ByVal value As String)
            _EntryBy = value
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

    Dim _Duration As Integer

    Public Property Duration() As Integer
        Get
            Return _Duration
        End Get
        Set(ByVal value As Integer)
            _Duration = value
        End Set
    End Property

    Public Function fnGetStoryList() As DataSet
        Dim sp As String = "spGetStoryList"
        Dim da As SqlDataAdapter = New SqlDataAdapter()
        Dim ds As DataSet = New DataSet()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
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

#Region " Insert Story "

    Public Function fnInsertStory(ByVal Story As clsStory) As Integer
        Try
            Dim cmd As SqlCommand = New SqlCommand("spInsertStory", con)
            con.Open()

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@StoryTopic", Story.StoryTopic)
            cmd.Parameters.AddWithValue("@Story", Story.Story)
            cmd.Parameters.AddWithValue("@Duration", Story.Duration)
            cmd.Parameters.AddWithValue("@EntryBy", Story.EntryBy)
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

#Region " Update Story "

    Public Function fnUpdateStory(ByVal Story As clsStory) As Integer
        Try
            Dim cmd As SqlCommand = New SqlCommand("spUpdateStory", con)
            con.Open()

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@StoryID", Story.StoryID)
            cmd.Parameters.AddWithValue("@StoryTopic", Story.StoryTopic)
            cmd.Parameters.AddWithValue("@Story", Story.Story)
            cmd.Parameters.AddWithValue("@Duration", Story.Duration)
            cmd.Parameters.AddWithValue("@EntryBy", Story.EntryBy)
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
