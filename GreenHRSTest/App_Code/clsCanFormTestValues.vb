Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsCanFormTestValues

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)
    Dim _CanFormTestValueID, _CanFormTestID, _ActualValue, _ComparedValue As String

    Public Property CanFormTestValueID() As String
        Get
            Return _CanFormTestValueID
        End Get
        Set(ByVal value As String)
            _CanFormTestValueID = value
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

    Public Property ActualValue() As String
        Get
            Return _ActualValue
        End Get
        Set(ByVal value As String)
            _ActualValue = value
        End Set
    End Property

    Public Property ComparedValue() As String
        Get
            Return _ComparedValue
        End Get
        Set(ByVal value As String)
            _ComparedValue = value
        End Set
    End Property

    Dim _Accuracy As Double

    Public Property Accuracy() As Double
        Get
            Return _Accuracy
        End Get
        Set(ByVal value As Double)
            _Accuracy = value
        End Set
    End Property

End Class
