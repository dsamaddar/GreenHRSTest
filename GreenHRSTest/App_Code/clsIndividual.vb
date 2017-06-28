Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsIndividual

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Dim _IndName, _FathersName, _MothersName, _SpouseName, _DateOfBirth, _Gender, _eTin, _TypeOfID, _IDNo, _PresentAddress, _PermanentAddress, _
    _Telephone, _Mobile, _Email, _NatureOfOccupation, _NatOfOccForYears, _OrgName, _BusinessActivity, _BusinessActDetails, _WorkAddress, _
    _WorkTelephone, _WorkFax, _WorkEmail, _MaritalStatus, _MarriageAnniversary, _LivingPattern, _LivingIn, _NumEarningMem, _
    _GrossFamilyIncome, _ReasonForChoosing As String

    Public Property IndName() As String
        Get
            Return _IndName
        End Get
        Set(ByVal value As String)
            _IndName = value
        End Set
    End Property

    Public Property FathersName() As String
        Get
            Return _FathersName
        End Get
        Set(ByVal value As String)
            _FathersName = value
        End Set
    End Property

    Public Property MothersName() As String
        Get
            Return _MothersName
        End Get
        Set(ByVal value As String)
            _MothersName = value
        End Set
    End Property

    Public Property SpouseName() As String
        Get
            Return _SpouseName
        End Get
        Set(ByVal value As String)
            _SpouseName = value
        End Set
    End Property

    Public Property DateOfBirth() As String
        Get
            Return _DateOfBirth
        End Get
        Set(ByVal value As String)
            _DateOfBirth = value
        End Set
    End Property

    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    Public Property eTin() As String
        Get
            Return _eTin
        End Get
        Set(ByVal value As String)
            _eTin = value
        End Set
    End Property

    Public Property TypeOfID() As String
        Get
            Return _TypeOfID
        End Get
        Set(ByVal value As String)
            _TypeOfID = value
        End Set
    End Property

    Public Property IDNo() As String
        Get
            Return _IDNo
        End Get
        Set(ByVal value As String)
            _IDNo = value
        End Set
    End Property

    Public Property PresentAddress() As String
        Get
            Return _PresentAddress
        End Get
        Set(ByVal value As String)
            _PresentAddress = value
        End Set
    End Property

    Public Property PermanentAddress() As String
        Get
            Return _PermanentAddress
        End Get
        Set(ByVal value As String)
            _PermanentAddress = value
        End Set
    End Property

    Property Telephone() As String
        Get
            Return _Telephone
        End Get
        Set(ByVal value As String)
            _Telephone = value
        End Set
    End Property

    Public Property Mobile() As String
        Get
            Return _Mobile
        End Get
        Set(ByVal value As String)
            _Mobile = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Public Property NatureOfOccupation() As String
        Get
            Return _NatureOfOccupation
        End Get
        Set(ByVal value As String)
            _NatureOfOccupation = value
        End Set
    End Property

    Public Property NatOfOccForYears() As String
        Get
            Return _NatOfOccForYears
        End Get
        Set(ByVal value As String)
            _NatOfOccForYears = value
        End Set
    End Property

    Public Property OrgName() As String
        Get
            Return _OrgName
        End Get
        Set(ByVal value As String)
            _OrgName = value
        End Set
    End Property

    Public Property BusinessActivity() As String
        Get
            Return _BusinessActivity
        End Get
        Set(ByVal value As String)
            _BusinessActivity = value
        End Set
    End Property

    Public Property BusinessActDetails() As String
        Get
            Return _BusinessActDetails
        End Get
        Set(ByVal value As String)
            _BusinessActDetails = value
        End Set
    End Property

    Public Property WorkAddress() As String
        Get
            Return _WorkAddress
        End Get
        Set(ByVal value As String)
            _WorkAddress = value
        End Set
    End Property

    Public Property WorkTelephone() As String
        Get
            Return _WorkTelephone
        End Get
        Set(ByVal value As String)
            _WorkTelephone = value
        End Set
    End Property

    Public Property WorkFax() As String
        Get
            Return _WorkFax
        End Get
        Set(ByVal value As String)
            _WorkFax = value
        End Set
    End Property

    Public Property WorkEmail() As String
        Get
            Return _WorkEmail
        End Get
        Set(ByVal value As String)
            _WorkEmail = value
        End Set
    End Property

    Public Property MaritalStatus() As String
        Get
            Return _MaritalStatus
        End Get
        Set(ByVal value As String)
            _MaritalStatus = value
        End Set
    End Property

    Public Property MarriageAnniversary() As String
        Get
            Return _MarriageAnniversary
        End Get
        Set(ByVal value As String)
            _MarriageAnniversary = value
        End Set
    End Property

    Public Property LivingPattern() As String
        Get
            Return _LivingPattern
        End Get
        Set(ByVal value As String)
            _LivingPattern = value
        End Set
    End Property

    Public Property LivingIn() As String
        Get
            Return _LivingIn
        End Get
        Set(ByVal value As String)
            _LivingIn = value
        End Set
    End Property

    Public Property NumEarningMem() As String
        Get
            Return _NumEarningMem
        End Get
        Set(ByVal value As String)
            _NumEarningMem = value
        End Set
    End Property

    Public Property GrossFamilyIncome() As String
        Get
            Return _GrossFamilyIncome
        End Get
        Set(ByVal value As String)
            _GrossFamilyIncome = value
        End Set
    End Property

    Public Property ReasonForChoosing() As String
        Get
            Return _ReasonForChoosing
        End Get
        Set(ByVal value As String)
            _ReasonForChoosing = value
        End Set
    End Property

#Region " Get Acutal Personal Info Values "

    Public Function fnGetAcutalPerInfoValues() As clsIndividual
        Dim sp As String = "spGetAcutalPerInfoValues"
        Dim dr As SqlDataReader
        Dim Person As New clsIndividual()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader()
                While dr.Read()
                    Person.IndName = dr.Item("IndName")
                    Person.FathersName = dr.Item("FathersName")
                    Person.MothersName = dr.Item("MothersName")
                    Person.SpouseName = dr.Item("SpouseName")
                    Person.DateOfBirth = dr.Item("DateOfBirth")
                    Person.Gender = dr.Item("Gender")
                    Person.eTin = dr.Item("eTin")
                    Person.TypeOfID = dr.Item("TypeOfID")
                    Person.IDNo = dr.Item("IDNo")
                    Person.PresentAddress = dr.Item("PresentAddress")
                    Person.PermanentAddress = dr.Item("PermanentAddress")
                    Person.Telephone = dr.Item("Telephone")
                    Person.Mobile = dr.Item("Mobile")
                    Person.Email = dr.Item("Email")
                    Person.NatureOfOccupation = dr.Item("NatureOfOccupation")
                    Person.NatOfOccForYears = dr.Item("NatOfOccForYears")
                    Person.OrgName = dr.Item("OrgName")
                    Person.BusinessActivity = dr.Item("BusinessActivity")
                    Person.BusinessActDetails = dr.Item("BusinessActDetails")
                    Person.WorkAddress = dr.Item("WorkAddress")
                    Person.WorkTelephone = dr.Item("WorkTelephone")
                    Person.WorkFax = dr.Item("WorkFax")
                    Person.WorkEmail = dr.Item("WorkEmail")
                    Person.MaritalStatus = dr.Item("MaritalStatus")
                    Person.MarriageAnniversary = dr.Item("MarriageAnniversary")
                    Person.LivingPattern = dr.Item("LivingPattern")
                    Person.LivingIn = dr.Item("LivingIn")
                    Person.NumEarningMem = dr.Item("NumEarningMem")
                    Person.GrossFamilyIncome = dr.Item("GrossFamilyIncome")
                    Person.ReasonForChoosing = dr.Item("ReasonForChoosing")
                End While
                con.Close()
                Return Person
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
