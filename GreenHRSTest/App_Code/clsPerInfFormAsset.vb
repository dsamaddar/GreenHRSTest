Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsPerInfFormAsset

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Dim _OwnerType, _ApplicationID, _ApplicantName, _FathersName, _FOccupation, _MothersName, _Moccupation, _SpouseName, _SOccupation, _DateOfBirth, _Gender, _District, _Country, _
    _HaveIDCard, _IDType, _IDNo, _Nationality, _DualCitizenship, _SecondCountry, _
    _HaveTin, _TinNo, _TelephoneRes, _Mobile, _Email, _
    _PresentAddress, _PreAddOwnership, _
    _PreAddOccTenure, _PreAddAgrPeriod, _PreAddLandLord, _PreAddPhoneNo, _PreAddUtilityBill, _
    _PersentAddress, _PerAddOwnership, _
    _PerAddOccTenure, _PerAddAgrPeriod, _PerAddLandLord, _PerAddPhoneNo, _PerAddUtilityBill, _
    _HaveInstDegree, _LastAttinedDegree, _PassingYear, _Institution, _
    _DoYouEarn, _EarningType, _Organization, _
    _HaveTechnicalExp, _TechnicalExpertise, _
    _InvolvedInOtherBusiness, _OtherBusiness As String

#Region " Properties "

    Public Property OwnerType() As String
        Get
            Return _OwnerType
        End Get
        Set(ByVal value As String)
            _OwnerType = value
        End Set
    End Property

    Public Property ApplicationID() As String
        Get
            Return _ApplicationID
        End Get
        Set(ByVal value As String)
            _ApplicationID = value
        End Set
    End Property

    Public Property ApplicantName() As String
        Get
            Return _ApplicantName
        End Get
        Set(ByVal value As String)
            _ApplicantName = value
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

    Public Property FOccupation() As String
        Get
            Return _FOccupation
        End Get
        Set(ByVal value As String)
            _FOccupation = value
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

    Public Property Moccupation() As String
        Get
            Return _Moccupation
        End Get
        Set(ByVal value As String)
            _Moccupation = value
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

    Public Property SOccupation() As String
        Get
            Return _SOccupation
        End Get
        Set(ByVal value As String)
            _SOccupation = value
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

    Public Property District() As String
        Get
            Return _District
        End Get
        Set(ByVal value As String)
            _District = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return _Country
        End Get
        Set(ByVal value As String)
            _Country = value
        End Set
    End Property

    Public Property HaveIDCard() As String
        Get
            Return _HaveIDCard
        End Get
        Set(ByVal value As String)
            _HaveIDCard = value
        End Set
    End Property

    Public Property IDType() As String
        Get
            Return _IDType
        End Get
        Set(ByVal value As String)
            _IDType = value
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

    Public Property Nationality() As String
        Get
            Return _Nationality
        End Get
        Set(ByVal value As String)
            _Nationality = value
        End Set
    End Property

    Public Property DualCitizenship() As String
        Get
            Return _DualCitizenship
        End Get
        Set(ByVal value As String)
            _DualCitizenship = value
        End Set
    End Property

    Public Property SecondCountry() As String
        Get
            Return _SecondCountry
        End Get
        Set(ByVal value As String)
            _SecondCountry = value
        End Set
    End Property

    Public Property HaveTin() As String
        Get
            Return _HaveTin
        End Get
        Set(ByVal value As String)
            _HaveTin = value
        End Set
    End Property

    Public Property TinNo() As String
        Get
            Return _TinNo
        End Get
        Set(ByVal value As String)
            _TinNo = value
        End Set
    End Property

    Public Property TelephoneRes() As String
        Get
            Return _TelephoneRes
        End Get
        Set(ByVal value As String)
            _TelephoneRes = value
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

    Public Property PresentAddress() As String
        Get
            Return _PresentAddress
        End Get
        Set(ByVal value As String)
            _PresentAddress = value
        End Set
    End Property

    Public Property PreAddOwnership() As String
        Get
            Return _PreAddOwnership
        End Get
        Set(ByVal value As String)
            _PreAddOwnership = value
        End Set
    End Property

    Public Property PreAddOccTenure() As String
        Get
            Return _PreAddOccTenure
        End Get
        Set(ByVal value As String)
            _PreAddOccTenure = value
        End Set
    End Property

    Public Property PreAddAgrPeriod() As String
        Get
            Return _PreAddAgrPeriod
        End Get
        Set(ByVal value As String)
            _PreAddAgrPeriod = value
        End Set
    End Property

    Public Property PreAddLandLord() As String
        Get
            Return _PreAddLandLord
        End Get
        Set(ByVal value As String)
            _PreAddLandLord = value
        End Set
    End Property

    Public Property PreAddPhoneNo() As String
        Get
            Return _PreAddPhoneNo
        End Get
        Set(ByVal value As String)
            _PreAddPhoneNo = value
        End Set
    End Property

    Public Property PreAddUtilityBill() As String
        Get
            Return _PreAddUtilityBill
        End Get
        Set(ByVal value As String)
            _PreAddUtilityBill = value
        End Set
    End Property

    Public Property PersentAddress() As String
        Get
            Return _PersentAddress
        End Get
        Set(ByVal value As String)
            _PersentAddress = value
        End Set
    End Property

    Public Property PerAddOwnership() As String
        Get
            Return _PerAddOwnership
        End Get
        Set(ByVal value As String)
            _PerAddOwnership = value
        End Set
    End Property

    Public Property PerAddOccTenure() As String
        Get
            Return _PerAddOccTenure
        End Get
        Set(ByVal value As String)
            _PerAddOccTenure = value
        End Set
    End Property

    Public Property PerAddAgrPeriod() As String
        Get
            Return _PerAddAgrPeriod
        End Get
        Set(ByVal value As String)
            _PerAddAgrPeriod = value
        End Set
    End Property

    Public Property PerAddLandLord() As String
        Get
            Return _PerAddLandLord
        End Get
        Set(ByVal value As String)
            _PerAddLandLord = value
        End Set
    End Property

    Public Property PerAddPhoneNo() As String
        Get
            Return _PerAddPhoneNo
        End Get
        Set(ByVal value As String)
            _PerAddPhoneNo = value
        End Set
    End Property

    Public Property PerAddUtilityBill() As String
        Get
            Return _PerAddUtilityBill
        End Get
        Set(ByVal value As String)
            _PerAddUtilityBill = value
        End Set
    End Property

    Public Property HaveInstDegree() As String
        Get
            Return _HaveInstDegree
        End Get
        Set(ByVal value As String)
            _HaveInstDegree = value
        End Set
    End Property

    Public Property LastAttinedDegree() As String
        Get
            Return _LastAttinedDegree
        End Get
        Set(ByVal value As String)
            _LastAttinedDegree = value
        End Set
    End Property

    Public Property PassingYear() As String
        Get
            Return _PassingYear
        End Get
        Set(ByVal value As String)
            _PassingYear = value
        End Set
    End Property

    Public Property Institution() As String
        Get
            Return _Institution
        End Get
        Set(ByVal value As String)
            _Institution = value
        End Set
    End Property

    Public Property DoYouEarn() As String
        Get
            Return _DoYouEarn
        End Get
        Set(ByVal value As String)
            _DoYouEarn = value
        End Set
    End Property

    Public Property EarningType() As String
        Get
            Return _EarningType
        End Get
        Set(ByVal value As String)
            _EarningType = value
        End Set
    End Property

    Public Property Organization() As String
        Get
            Return _Organization
        End Get
        Set(ByVal value As String)
            _Organization = value
        End Set
    End Property

    Public Property HaveTechnicalExp() As String
        Get
            Return _HaveTechnicalExp
        End Get
        Set(ByVal value As String)
            _HaveTechnicalExp = value
        End Set
    End Property

    Public Property TechnicalExpertise() As String
        Get
            Return _TechnicalExpertise
        End Get
        Set(ByVal value As String)
            _TechnicalExpertise = value
        End Set
    End Property

    Public Property InvolvedInOtherBusiness() As String
        Get
            Return _InvolvedInOtherBusiness
        End Get
        Set(ByVal value As String)
            _InvolvedInOtherBusiness = value
        End Set
    End Property

    Public Property OtherBusiness() As String
        Get
            Return _OtherBusiness
        End Get
        Set(ByVal value As String)
            _OtherBusiness = value
        End Set
    End Property

#End Region

#Region " Get Actual Personal Information Form Asset "

    Public Function fnGetActualPerInfFormAsset() As clsPerInfFormAsset
        Dim sp As String = "spGetActualPerInfFormAsset"
        Dim dr As SqlDataReader
        Dim PerInfForm As New clsPerInfFormAsset()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader()
                While dr.Read()
                    PerInfForm.OwnerType = dr.Item("OwnerType")
                    PerInfForm.ApplicationID = dr.Item("ApplicationID")
                    PerInfForm.ApplicantName = dr.Item("ApplicantName")
                    PerInfForm.FathersName = dr.Item("FathersName")
                    PerInfForm.FOccupation = dr.Item("FOccupation")
                    PerInfForm.MothersName = dr.Item("MothersName")
                    PerInfForm.Moccupation = dr.Item("Moccupation")
                    PerInfForm.SpouseName = dr.Item("SpouseName")
                    PerInfForm.SOccupation = dr.Item("SOccupation")
                    PerInfForm.DateOfBirth = dr.Item("DateOfBirth")
                    PerInfForm.Gender = dr.Item("Gender")
                    PerInfForm.District = dr.Item("District")
                    PerInfForm.Country = dr.Item("Country")
                    PerInfForm.HaveIDCard = dr.Item("HaveIDCard")
                    PerInfForm.IDType = dr.Item("IDType")
                    PerInfForm.IDNo = dr.Item("IDNo")
                    PerInfForm.Nationality = dr.Item("Nationality")
                    PerInfForm.DualCitizenship = dr.Item("DualCitizenship")
                    PerInfForm.SecondCountry = dr.Item("SecondCountry")
                    PerInfForm.HaveTin = dr.Item("HaveTin")
                    PerInfForm.TinNo = dr.Item("TinNo")
                    PerInfForm.TelephoneRes = dr.Item("TelephoneRes")
                    PerInfForm.Mobile = dr.Item("Mobile")
                    PerInfForm.Email = dr.Item("Email")
                    PerInfForm.PresentAddress = dr.Item("PresentAddress")
                    PerInfForm.PreAddOwnership = dr.Item("PreAddOwnership")
                    PerInfForm.PreAddOccTenure = dr.Item("PreAddOccTenure")
                    PerInfForm.PreAddAgrPeriod = dr.Item("PreAddAgrPeriod")
                    PerInfForm.PreAddLandLord = dr.Item("PreAddLandLord")
                    PerInfForm.PreAddPhoneNo = dr.Item("PreAddPhoneNo")
                    PerInfForm.PreAddUtilityBill = dr.Item("PreAddUtilityBill")
                    PerInfForm.PersentAddress = dr.Item("PersentAddress")
                    PerInfForm.PerAddOwnership = dr.Item("PerAddOwnership")
                    PerInfForm.PerAddOccTenure = dr.Item("PerAddOccTenure")
                    PerInfForm.PerAddAgrPeriod = dr.Item("PerAddAgrPeriod")
                    PerInfForm.PerAddLandLord = dr.Item("PerAddLandLord")
                    PerInfForm.PerAddPhoneNo = dr.Item("PerAddPhoneNo")
                    PerInfForm.PerAddUtilityBill = dr.Item("PerAddUtilityBill")
                    PerInfForm.HaveInstDegree = dr.Item("HaveInstDegree")
                    PerInfForm.LastAttinedDegree = dr.Item("LastAttinedDegree")
                    PerInfForm.PassingYear = dr.Item("PassingYear")
                    PerInfForm.Institution = dr.Item("Institution")
                    PerInfForm.DoYouEarn = dr.Item("DoYouEarn")
                    PerInfForm.EarningType = dr.Item("EarningType")
                    PerInfForm.Organization = dr.Item("Organization")
                    PerInfForm.HaveTechnicalExp = dr.Item("HaveTechnicalExp")
                    PerInfForm.TechnicalExpertise = dr.Item("TechnicalExpertise")
                    PerInfForm.InvolvedInOtherBusiness = dr.Item("InvolvedInOtherBusiness")
                    PerInfForm.OtherBusiness = dr.Item("OtherBusiness")
                End While
                con.Close()
                Return PerInfForm
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
