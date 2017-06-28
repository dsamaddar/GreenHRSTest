Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsCreditFacilityForm

    Dim _SLNO As Integer
    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Public Property SLNO() As Integer
        Get
            Return _SLNO
        End Get
        Set(ByVal value As Integer)
            _SLNO = value
        End Set
    End Property

    Dim _ApplicationDate, _ApplicationID, _Branch, _Purpose, _Product, _Amount, _Tenure, _NameOfBusiness, _GroupName, _MainSponsor, _
    _DesigOfMainSponsor, _ContactNumber, _OfficeAddress, _FactoryAddress, _ContactNumberOff, _Email, _PersonalGuarantee, _Directors, _
    _Spouses, _FamilyMember, _BusinessFriend, _LienOnCash, _TypeOfSecurity, _SecurityAmount, _BankFIName, _
    _RegisteredMortgage, _LandSize, _FloorSize, _NumberOfFloor, _Location, _ChqCovering, _ChqCoveringInt, _
    _HypoInv, _HypoInvType, _HypoMac, _HypoMacType As String

    Public Property ApplicationDate() As String
        Get
            Return _ApplicationDate
        End Get
        Set(ByVal value As String)
            _ApplicationDate = value
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

    Public Property Branch() As String
        Get
            Return _Branch
        End Get
        Set(ByVal value As String)
            _Branch = value
        End Set
    End Property

    Public Property Purpose() As String
        Get
            Return _Purpose
        End Get
        Set(ByVal value As String)
            _Purpose = value
        End Set
    End Property

    Public Property Product() As String
        Get
            Return _Product
        End Get
        Set(ByVal value As String)
            _Product = value
        End Set
    End Property

    Public Property Amount() As String
        Get
            Return _Amount
        End Get
        Set(ByVal value As String)
            _Amount = value
        End Set
    End Property

    Public Property Tenure() As String
        Get
            Return _Tenure
        End Get
        Set(ByVal value As String)
            _Tenure = value
        End Set
    End Property

    Public Property NameOfBusiness() As String
        Get
            Return _NameOfBusiness
        End Get
        Set(ByVal value As String)
            _NameOfBusiness = value
        End Set
    End Property

    Public Property GroupName() As String
        Get
            Return _GroupName
        End Get
        Set(ByVal value As String)
            _GroupName = value
        End Set
    End Property

    Public Property MainSponsor() As String
        Get
            Return _MainSponsor
        End Get
        Set(ByVal value As String)
            _MainSponsor = value
        End Set
    End Property

    Public Property DesigOfMainSponsor() As String
        Get
            Return _DesigOfMainSponsor
        End Get
        Set(ByVal value As String)
            _DesigOfMainSponsor = value
        End Set
    End Property

    Public Property ContactNumber() As String
        Get
            Return _ContactNumber
        End Get
        Set(ByVal value As String)
            _ContactNumber = value
        End Set
    End Property

    Public Property OfficeAddress() As String
        Get
            Return _OfficeAddress
        End Get
        Set(ByVal value As String)
            _OfficeAddress = value
        End Set
    End Property

    Public Property FactoryAddress() As String
        Get
            Return _FactoryAddress
        End Get
        Set(ByVal value As String)
            _FactoryAddress = value
        End Set
    End Property

    Public Property ContactNumberOff() As String
        Get
            Return _ContactNumberOff
        End Get
        Set(ByVal value As String)
            _ContactNumberOff = value
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

    Public Property PersonalGuarantee() As String
        Get
            Return _PersonalGuarantee
        End Get
        Set(ByVal value As String)
            _PersonalGuarantee = value
        End Set
    End Property

    Public Property Directors() As String
        Get
            Return _Directors
        End Get
        Set(ByVal value As String)
            _Directors = value
        End Set
    End Property

    Public Property Spouses() As String
        Get
            Return _Spouses
        End Get
        Set(ByVal value As String)
            _Spouses = value
        End Set
    End Property

    Public Property FamilyMember() As String
        Get
            Return _FamilyMember
        End Get
        Set(ByVal value As String)
            _FamilyMember = value
        End Set
    End Property

    Public Property BusinessFriend() As String
        Get
            Return _BusinessFriend
        End Get
        Set(ByVal value As String)
            _BusinessFriend = value
        End Set
    End Property

    Public Property LienOnCash() As String
        Get
            Return _LienOnCash
        End Get
        Set(ByVal value As String)
            _LienOnCash = value
        End Set
    End Property

    Public Property TypeOfSecurity() As String
        Get
            Return _TypeOfSecurity
        End Get
        Set(ByVal value As String)
            _TypeOfSecurity = value
        End Set
    End Property

    Public Property SecurityAmount() As String
        Get
            Return _SecurityAmount
        End Get
        Set(ByVal value As String)
            _SecurityAmount = value
        End Set
    End Property

    Public Property BankFIName() As String
        Get
            Return _BankFIName
        End Get
        Set(ByVal value As String)
            _BankFIName = value
        End Set
    End Property

    Public Property RegisteredMortgage() As String
        Get
            Return _RegisteredMortgage
        End Get
        Set(ByVal value As String)
            _RegisteredMortgage = value
        End Set
    End Property

    Public Property LandSize() As String
        Get
            Return _LandSize
        End Get
        Set(ByVal value As String)
            _LandSize = value
        End Set
    End Property

    Public Property FloorSize() As String
        Get
            Return _FloorSize
        End Get
        Set(ByVal value As String)
            _FloorSize = value
        End Set
    End Property

    Public Property NumberOfFloor() As String
        Get
            Return _NumberOfFloor
        End Get
        Set(ByVal value As String)
            _NumberOfFloor = value
        End Set
    End Property

    Public Property Location() As String
        Get
            Return _Location
        End Get
        Set(ByVal value As String)
            _Location = value
        End Set
    End Property

    Public Property ChqCovering() As String
        Get
            Return _ChqCovering
        End Get
        Set(ByVal value As String)
            _ChqCovering = value
        End Set
    End Property

    Public Property ChqCoveringInt() As String
        Get
            Return _ChqCoveringInt
        End Get
        Set(ByVal value As String)
            _ChqCoveringInt = value
        End Set
    End Property

    Public Property HypoInv() As String
        Get
            Return _HypoInv
        End Get
        Set(ByVal value As String)
            _HypoInv = value
        End Set
    End Property

    Public Property HypoInvType() As String
        Get
            Return _HypoInvType
        End Get
        Set(ByVal value As String)
            _HypoInvType = value
        End Set
    End Property

    Public Property HypoMac() As String
        Get
            Return _HypoMac
        End Get
        Set(ByVal value As String)
            _HypoMac = value
        End Set
    End Property

    Public Property HypoMacType() As String
        Get
            Return _HypoMacType
        End Get
        Set(ByVal value As String)
            _HypoMacType = value
        End Set
    End Property


#Region " Get Actual Credit Facility Info Values "

    Public Function fnGetActualCreditFacilityInfoValues() As clsCreditFacilityForm
        Dim sp As String = "spGetActualCreditFacilityInfoValues"
        Dim dr As SqlDataReader
        Dim CreditFacility As New clsCreditFacilityForm()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader()
                While dr.Read()
                    CreditFacility.ApplicationDate = dr.Item("ApplicationDate")
                    CreditFacility.ApplicationID = dr.Item("ApplicationID")
                    CreditFacility.Branch = dr.Item("Branch")
                    CreditFacility.Purpose = dr.Item("Purpose")
                    CreditFacility.Product = dr.Item("Product")
                    CreditFacility.Amount = dr.Item("Amount")
                    CreditFacility.Tenure = dr.Item("Tenure")
                    CreditFacility.NameOfBusiness = dr.Item("NameOfBusiness")
                    CreditFacility.GroupName = dr.Item("GroupName")
                    CreditFacility.MainSponsor = dr.Item("MainSponsor")
                    CreditFacility.DesigOfMainSponsor = dr.Item("DesigOfMainSponsor")
                    CreditFacility.ContactNumber = dr.Item("ContactNumber")
                    CreditFacility.OfficeAddress = dr.Item("OfficeAddress")
                    CreditFacility.FactoryAddress = dr.Item("FactoryAddress")
                    CreditFacility.ContactNumberOff = dr.Item("ContactNumberOff")
                    CreditFacility.Email = dr.Item("Email")
                    CreditFacility.PersonalGuarantee = dr.Item("PersonalGuarantee")
                    CreditFacility.Directors = dr.Item("Directors")
                    CreditFacility.Spouses = dr.Item("Spouses")
                    CreditFacility.FamilyMember = dr.Item("FamilyMember")
                    CreditFacility.BusinessFriend = dr.Item("BusinessFriend")
                    CreditFacility.LienOnCash = dr.Item("LienOnCash")
                    CreditFacility.TypeOfSecurity = dr.Item("TypeOfSecurity")
                    CreditFacility.SecurityAmount = dr.Item("SecurityAmount")
                    CreditFacility.BankFIName = dr.Item("BankFIName")
                    CreditFacility.RegisteredMortgage = dr.Item("RegisteredMortgage")
                    CreditFacility.LandSize = dr.Item("LandSize")
                    CreditFacility.FloorSize = dr.Item("FloorSize")
                    CreditFacility.NumberOfFloor = dr.Item("NumberOfFloor")
                    CreditFacility.Location = dr.Item("Location")
                    CreditFacility.ChqCovering = dr.Item("ChqCovering")
                    CreditFacility.ChqCoveringInt = dr.Item("ChqCoveringInt")
                    CreditFacility.HypoInv = dr.Item("HypoInv")
                    CreditFacility.HypoInvType = dr.Item("HypoInvType")
                    CreditFacility.HypoMac = dr.Item("HypoMac")
                    CreditFacility.HypoMacType = dr.Item("HypoMacType")
                End While
                con.Close()
                Return CreditFacility
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
