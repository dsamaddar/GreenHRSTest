Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class clsOrganization

    Dim con As SqlConnection = New SqlConnection(My.Settings.DBCON)

    Dim _LegalStatus, _NameOfTheCompany, _IndustrySector, _FemaleOwnership, _DateOfIncorporation, _eTin, _
     _NatureOfBusiness, _MajorProduct, _BusinessAddress, _RegisteredAddress, _Phone, _Mobile, _Fax, _Email, _
     _NameOfComOne, _NatureOfBusinessOne, _NameOfComTwo, _NatureOfBusinessTwo, _NameOfComThree, _NatureOfBusinessThree, _
     _NameOfBankOne, _BranchLocOne, _NameOfBankTwo, _BranchLocTwo, _ReasonForChoosing As String

    Public Property LegalStatus() As String
        Get
            Return _LegalStatus
        End Get
        Set(ByVal value As String)
            _LegalStatus = value
        End Set
    End Property

    Public Property NameOfTheCompany() As String
        Get
            Return _NameOfTheCompany
        End Get
        Set(ByVal value As String)
            _NameOfTheCompany = value
        End Set
    End Property

    Public Property IndustrySector() As String
        Get
            Return _IndustrySector
        End Get
        Set(ByVal value As String)
            _IndustrySector = value
        End Set
    End Property

    Public Property FemaleOwnership() As String
        Get
            Return _FemaleOwnership
        End Get
        Set(ByVal value As String)
            _FemaleOwnership = value
        End Set
    End Property

    Public Property DateOfIncorporation() As String
        Get
            Return _DateOfIncorporation
        End Get
        Set(ByVal value As String)
            _DateOfIncorporation = value
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

    Public Property NatureOfBusiness() As String
        Get
            Return _NatureOfBusiness
        End Get
        Set(ByVal value As String)
            _NatureOfBusiness = value
        End Set
    End Property

    Public Property MajorProduct() As String
        Get
            Return _MajorProduct
        End Get
        Set(ByVal value As String)
            _MajorProduct = value
        End Set
    End Property

    Public Property BusinessAddress() As String
        Get
            Return _BusinessAddress
        End Get
        Set(ByVal value As String)
            _BusinessAddress = value
        End Set
    End Property

    Public Property RegisteredAddress() As String
        Get
            Return _RegisteredAddress
        End Get
        Set(ByVal value As String)
            _RegisteredAddress = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _Phone
        End Get
        Set(ByVal value As String)
            _Phone = value
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

    Public Property Fax() As String
        Get
            Return _Fax
        End Get
        Set(ByVal value As String)
            _Fax = value
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

    Public Property NameOfComOne() As String
        Get
            Return _NameOfComOne
        End Get
        Set(ByVal value As String)
            _NameOfComOne = value
        End Set
    End Property

    Public Property NatureOfBusinessOne() As String
        Get
            Return _NatureOfBusinessOne
        End Get
        Set(ByVal value As String)
            _NatureOfBusinessOne = value
        End Set
    End Property

    Public Property NameOfComTwo() As String
        Get
            Return _NameOfComTwo
        End Get
        Set(ByVal value As String)
            _NameOfComTwo = value
        End Set
    End Property

    Public Property NatureOfBusinessTwo() As String
        Get
            Return _NatureOfBusinessTwo
        End Get
        Set(ByVal value As String)
            _NatureOfBusinessTwo = value
        End Set
    End Property

    Public Property NameOfComThree() As String
        Get
            Return _NameOfComThree
        End Get
        Set(ByVal value As String)
            _NameOfComThree = value
        End Set
    End Property

    Public Property NatureOfBusinessThree() As String
        Get
            Return _NatureOfBusinessThree
        End Get
        Set(ByVal value As String)
            _NatureOfBusinessThree = value
        End Set
    End Property

    Public Property NameOfBankOne() As String
        Get
            Return _NameOfBankOne
        End Get
        Set(ByVal value As String)
            _NameOfBankOne = value
        End Set
    End Property

    Public Property BranchLocOne() As String
        Get
            Return _BranchLocOne
        End Get
        Set(ByVal value As String)
            _BranchLocOne = value
        End Set
    End Property

    Public Property NameOfBankTwo() As String
        Get
            Return _NameOfBankTwo
        End Get
        Set(ByVal value As String)
            _NameOfBankTwo = value
        End Set
    End Property

    Public Property BranchLocTwo() As String
        Get
            Return _BranchLocTwo
        End Get
        Set(ByVal value As String)
            _BranchLocTwo = value
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


#Region " Get Acutal Org Info Values "

    Public Function fnGetAcutalOrgInfoValues() As clsOrganization
        Dim sp As String = "spGetAcutalOrgInfoValues"
        Dim dr As SqlDataReader
        Dim org As New clsOrganization()
        Try
            con.Open()
            Using cmd = New SqlCommand(sp, con)
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader()
                While dr.Read()
                    org.LegalStatus = dr.Item("LegalStatus")
                    org.NameOfTheCompany = dr.Item("NameOfTheCompany")
                    org.IndustrySector = dr.Item("IndustrySector")
                    org.FemaleOwnership = dr.Item("FemaleOwnership")
                    org.DateOfIncorporation = dr.Item("DateOfIncorporation")
                    org.eTin = dr.Item("eTin")
                    org.NatureOfBusiness = dr.Item("NatureOfBusiness")
                    org.MajorProduct = dr.Item("MajorProduct")
                    org.BusinessAddress = dr.Item("BusinessAddress")
                    org.RegisteredAddress = dr.Item("RegisteredAddress")
                    org.Phone = dr.Item("Phone")
                    org.Mobile = dr.Item("Mobile")
                    org.Fax = dr.Item("Fax")
                    org.Email = dr.Item("Email")
                    org.NameOfComOne = dr.Item("NameOfComOne")
                    org.NatureOfBusinessOne = dr.Item("NatureOfBusinessOne")
                    org.NameOfComTwo = dr.Item("NameOfComTwo")
                    org.NatureOfBusinessTwo = dr.Item("NatureOfBusinessTwo")
                    org.NameOfComThree = dr.Item("NameOfComThree")
                    org.NatureOfBusinessThree = dr.Item("NatureOfBusinessThree")
                    org.NameOfBankOne = dr.Item("NameOfBankOne")
                    org.BranchLocOne = dr.Item("BranchLocOne")
                    org.NameOfBankTwo = dr.Item("NameOfBankTwo")
                    org.BranchLocTwo = dr.Item("BranchLocTwo")
                    org.ReasonForChoosing = dr.Item("ReasonForChoosing")
                End While
                con.Close()
                Return org
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
