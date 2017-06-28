Public Class frmOrgInformationForm

    Dim OrgData As New clsOrganization()
    Dim FormTestData As New clsCanFormTest()

    Private Sub frmOrgInformationForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtLegalStatusOthers.Enabled = False
        txtOtherReasonForChUFL.Enabled = False
        StartTest(My.Settings.FTDuration)
    End Sub

#Region " Legal Status "

    Dim IsLegalStatusGiven As Boolean = False

    Private Sub chkPartnershipFirmNota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPartnershipFirmNota.CheckedChanged
        If chkPartnershipFirmNota.Checked = True Then
            chkPrivateLtdCom.Checked = False
            chkAssociation.Checked = False
            chkPartnershipFirmReg.Checked = False
            chkPublicLtdCom.Checked = False
            chkOtherLegalStatus.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = False
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

    Private Sub chkPrivateLtdCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrivateLtdCom.CheckedChanged
        If chkPrivateLtdCom.Checked = True Then
            chkPartnershipFirmNota.Checked = False
            chkAssociation.Checked = False
            chkPartnershipFirmReg.Checked = False
            chkPublicLtdCom.Checked = False
            chkOtherLegalStatus.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = False
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

    Private Sub chkAssociation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssociation.CheckedChanged
        If chkAssociation.Checked = True Then
            chkPrivateLtdCom.Checked = False
            chkPartnershipFirmNota.Checked = False
            chkPartnershipFirmReg.Checked = False
            chkPublicLtdCom.Checked = False
            chkOtherLegalStatus.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = False
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

    Private Sub chkPartnershipFirmReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPartnershipFirmReg.CheckedChanged
        If chkPartnershipFirmReg.Checked = True Then
            chkPrivateLtdCom.Checked = False
            chkAssociation.Checked = False
            chkPartnershipFirmNota.Checked = False
            chkPublicLtdCom.Checked = False
            chkOtherLegalStatus.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = False
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

    Private Sub chkPublicLtdCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPublicLtdCom.CheckedChanged
        If chkPublicLtdCom.Checked = True Then
            chkPrivateLtdCom.Checked = False
            chkAssociation.Checked = False
            chkPartnershipFirmReg.Checked = False
            chkPartnershipFirmNota.Checked = False
            chkOtherLegalStatus.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = False
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

    Private Sub chkOtherLegalStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtherLegalStatus.CheckedChanged
        If chkOtherLegalStatus.Checked = True Then
            chkPrivateLtdCom.Checked = False
            chkAssociation.Checked = False
            chkPartnershipFirmReg.Checked = False
            chkPublicLtdCom.Checked = False
            chkPartnershipFirmNota.Checked = False
            txtLegalStatusOthers.Text = ""
            txtLegalStatusOthers.Enabled = True
            IsLegalStatusGiven = True
        Else
            IsLegalStatusGiven = False
        End If
    End Sub

#End Region

#Region " Industry Sector "

    Dim IsIndustrySectorGiven As Boolean = False

    Private Sub chkManufacturing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkManufacturing.CheckedChanged
        If chkManufacturing.Checked = True Then
            chkService.Checked = False
            chkTrade.Checked = False
            IsIndustrySectorGiven = True
        Else
            IsIndustrySectorGiven = False
        End If
    End Sub

    Private Sub chkService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkService.CheckedChanged
        If chkService.Checked = True Then
            chkManufacturing.Checked = False
            chkTrade.Checked = False
            IsIndustrySectorGiven = True
        Else
            IsIndustrySectorGiven = False
        End If
    End Sub

    Private Sub chkTrade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrade.CheckedChanged
        If chkTrade.Checked = True Then
            chkService.Checked = False
            chkManufacturing.Checked = False
            IsIndustrySectorGiven = True
        Else
            IsIndustrySectorGiven = False
        End If
    End Sub

#End Region

#Region " Reason for choosing United Finance "

    Dim IsReasonForChoosingUFLGiven As Boolean = False

    Private Sub chkDirectSales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDirectSales.CheckedChanged
        If chkDirectSales.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkConvenientLocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConvenientLocation.CheckedChanged
        If chkConvenientLocation.Checked = True Then
            chkDirectSales.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkRecByFam.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkAdvertising_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdvertising.CheckedChanged
        If chkAdvertising.Checked = True Then
            chkConvenientLocation.Checked = False
            chkDirectSales.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkRecByFam.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkDissatisfactionWithOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDissatisfactionWithOthers.CheckedChanged
        If chkDissatisfactionWithOthers.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDirectSales.Checked = False
            chkRecByFam.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkRecByFam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRecByFam.CheckedChanged
        If chkRecByFam.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkDirectSales.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkIntRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIntRate.CheckedChanged
        If chkIntRate.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkRecByFam.Checked = False
            chkDirectSales.Checked = False
            chkReasonService.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkReasonService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReasonService.CheckedChanged
        If chkReasonService.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkRecByFam.Checked = False
            chkIntRate.Checked = False
            chkDirectSales.Checked = False
            chkReasonForChoosingOthers.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
        End If
    End Sub

    Private Sub chkReasonForChoosingOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReasonForChoosingOthers.CheckedChanged
        If chkReasonForChoosingOthers.Checked = True Then
            chkConvenientLocation.Checked = False
            chkAdvertising.Checked = False
            chkDissatisfactionWithOthers.Checked = False
            chkRecByFam.Checked = False
            chkIntRate.Checked = False
            chkReasonService.Checked = False
            chkDirectSales.Checked = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = True
            IsReasonForChoosingUFLGiven = True
        Else
            IsReasonForChoosingUFLGiven = False
            txtOtherReasonForChUFL.Text = ""
            txtOtherReasonForChUFL.Enabled = False
        End If
    End Sub

#End Region

#Region " Female Proprioetor "

    Dim IsOwnershipGiven As Boolean = False

    Private Sub chkOwnershipYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnershipYes.CheckedChanged
        If chkOwnershipYes.Checked = True Then
            chkOwnershipNo.Checked = False
            IsOwnershipGiven = True
        Else
            IsOwnershipGiven = False
        End If
    End Sub

    Private Sub chkOwnershipNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnershipNo.CheckedChanged
        If chkOwnershipNo.Checked = True Then
            chkOwnershipYes.Checked = False
            IsOwnershipGiven = True
        Else
            IsOwnershipGiven = False
        End If
    End Sub

#End Region

    Private Sub btnTerminateExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateExam.Click
        TerminateExam()
    End Sub

    Protected Sub TerminateExam()
        Try
            Dim Organization As New clsOrganization()

            'Legal Status
            If chkPartnershipFirmNota.Checked = True Then
                Organization.LegalStatus = chkPartnershipFirmNota.Text
            ElseIf chkPrivateLtdCom.Checked = True Then
                Organization.LegalStatus = chkPrivateLtdCom.Text
            ElseIf chkAssociation.Checked = True Then
                Organization.LegalStatus = chkAssociation.Text
            ElseIf chkPartnershipFirmReg.Checked = True Then
                Organization.LegalStatus = chkPartnershipFirmReg.Text
            ElseIf chkPublicLtdCom.Checked = True Then
                Organization.LegalStatus = chkPublicLtdCom.Text
            ElseIf chkOtherLegalStatus.Checked = True Then
                Organization.LegalStatus = txtLegalStatusOthers.Text
            Else
                Organization.LegalStatus = ""
            End If
            'Legal Status

            Organization.NameOfTheCompany = txtNameOfCompany.Text

            'Industry Sector
            If chkManufacturing.Checked = True Then
                Organization.IndustrySector = chkManufacturing.Text
            ElseIf chkService.Checked = True Then
                Organization.IndustrySector = chkService.Text
            ElseIf chkTrade.Checked = True Then
                Organization.IndustrySector = chkTrade.Text
            Else
                Organization.IndustrySector = ""
            End If
            'Industry Sector

            'Female Ownership
            If chkOwnershipYes.Checked = True Then
                Organization.FemaleOwnership = chkOwnershipYes.Text
            ElseIf chkOwnershipNo.Checked = True Then
                Organization.FemaleOwnership = chkOwnershipNo.Text
            Else
                Organization.FemaleOwnership = ""
            End If
            'Female Ownership

            Organization.DateOfIncorporation = txtDateOfIncorporation.Text
            Organization.eTin = txtEtin.Text
            Organization.NatureOfBusiness = txtNatureOfBusiness.Text
            Organization.MajorProduct = txtMajorProducts.Text
            Organization.BusinessAddress = txtBusinessAddress.Text
            Organization.RegisteredAddress = txtRegisteredAddress.Text
            Organization.Phone = txtPhone.Text
            Organization.Mobile = txtMobile.Text
            Organization.Fax = txtFax.Text
            Organization.Email = txtEmail.Text
            Organization.NameOfComOne = txtNameOfComOne.Text
            Organization.NameOfComTwo = txtNameOfComTwo.Text
            Organization.NameOfComThree = txtNameOfComThree.Text
            Organization.NatureOfBusinessOne = txtNatureOfBusOne.Text
            Organization.NatureOfBusinessTwo = txtNatureOfBusTwo.Text
            Organization.NatureOfBusinessThree = txtNatureOfBusThree.Text
            Organization.NameOfBankOne = txtNameOfTheBankOne.Text
            Organization.NameOfBankTwo = txtNameOfTheBankTwo.Text
            Organization.BranchLocOne = txtBranchLocOne.Text
            Organization.BranchLocTwo = txtBranchLocTwo.Text

            'Reason for choosing UFL
            If chkDirectSales.Checked = True Then
                Organization.ReasonForChoosing = chkDirectSales.Text
            ElseIf chkConvenientLocation.Checked = True Then
                Organization.ReasonForChoosing = chkConvenientLocation.Text
            ElseIf chkAdvertising.Checked = True Then
                Organization.ReasonForChoosing = chkAdvertising.Text
            ElseIf chkDissatisfactionWithOthers.Checked = True Then
                Organization.ReasonForChoosing = chkDissatisfactionWithOthers.Text
            ElseIf chkRecByFam.Checked = True Then
                Organization.ReasonForChoosing = chkRecByFam.Text
            ElseIf chkIntRate.Checked = True Then
                Organization.ReasonForChoosing = chkIntRate.Text
            ElseIf chkReasonService.Checked = True Then
                Organization.ReasonForChoosing = chkReasonService.Text
            ElseIf chkReasonForChoosingOthers.Checked = True Then
                Organization.ReasonForChoosing = txtOtherReasonForChUFL.Text
            Else
                Organization.ReasonForChoosing = ""
            End If
            'Reason for choosing UFL

            Dim ActualOrg As clsOrganization = OrgData.fnGetAcutalOrgInfoValues()
            Dim FormTestValueString As String = GetOrgInfoString(ActualOrg, Organization)

            Dim Accuracy As Double = FormTestData.fnStopFTExam(My.Settings.CanFormTestID, FormTestValueString)
            btnTerminateExam.Enabled = False
            OIFDuration = 0
            timerOIF.Enabled = False
            MsgBox("Accuracy : " & Accuracy.ToString() & "%")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Function GetOrgInfoString(ByVal ActualOrg As clsOrganization, ByVal Organization As clsOrganization) As String
        Dim FormTestValueString As String = ""

        FormTestValueString &= ActualOrg.LegalStatus & "~" & Organization.LegalStatus & "~|"
        FormTestValueString &= ActualOrg.NameOfTheCompany & "~" & Organization.NameOfTheCompany & "~|"
        FormTestValueString &= ActualOrg.IndustrySector & "~" & Organization.IndustrySector & "~|"
        FormTestValueString &= ActualOrg.FemaleOwnership & "~" & Organization.FemaleOwnership & "~|"
        FormTestValueString &= ActualOrg.DateOfIncorporation & "~" & Organization.DateOfIncorporation & "~|"
        FormTestValueString &= ActualOrg.eTin & "~" & Organization.eTin & "~|"
        FormTestValueString &= ActualOrg.NatureOfBusiness & "~" & Organization.NatureOfBusiness & "~|"
        FormTestValueString &= ActualOrg.MajorProduct & "~" & Organization.MajorProduct & "~|"
        FormTestValueString &= ActualOrg.BusinessAddress & "~" & Organization.BusinessAddress & "~|"
        FormTestValueString &= ActualOrg.RegisteredAddress & "~" & Organization.RegisteredAddress & "~|"
        FormTestValueString &= ActualOrg.Phone & "~" & Organization.Phone & "~|"
        FormTestValueString &= ActualOrg.Mobile & "~" & Organization.Mobile & "~|"
        FormTestValueString &= ActualOrg.Fax & "~" & Organization.Fax & "~|"
        FormTestValueString &= ActualOrg.Email & "~" & Organization.Email & "~|"
        FormTestValueString &= ActualOrg.NameOfComOne & "~" & Organization.NameOfComOne & "~|"
        FormTestValueString &= ActualOrg.NatureOfBusinessOne & "~" & Organization.NatureOfBusinessOne & "~|"
        FormTestValueString &= ActualOrg.NameOfComTwo & "~" & Organization.NameOfComTwo & "~|"
        FormTestValueString &= ActualOrg.NatureOfBusinessTwo & "~" & Organization.NatureOfBusinessTwo & "~|"
        FormTestValueString &= ActualOrg.NameOfComThree & "~" & Organization.NameOfComThree & "~|"
        FormTestValueString &= ActualOrg.NatureOfBusinessThree & "~" & Organization.NatureOfBusinessThree & "~|"
        FormTestValueString &= ActualOrg.NameOfBankOne & "~" & Organization.NameOfBankOne & "~|"
        FormTestValueString &= ActualOrg.BranchLocOne & "~" & Organization.BranchLocOne & "~|"
        FormTestValueString &= ActualOrg.NameOfBankTwo & "~" & Organization.NameOfBankTwo & "~|"
        FormTestValueString &= ActualOrg.BranchLocTwo & "~" & Organization.BranchLocTwo & "~|"
        FormTestValueString &= ActualOrg.ReasonForChoosing & "~" & Organization.ReasonForChoosing & "~|"

        Return FormTestValueString
    End Function

    Shared OIFDuration As Integer = 0

    Protected Sub StartTest(ByVal Duration As Integer)
        OIFDuration = Duration * 60
        timerOIF.Enabled = True
    End Sub

    Private Sub frmOrgInformationForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If OIFDuration <> 0 Then
            e.Cancel = True
            MsgBox("Exam Is Running. Can't Be Closed.")
        Else
            e.Cancel = False
        End If
    End Sub

    Dim totalSeconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim time As String = ""

    Private Sub timerOIF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerOIF.Tick
        Try
            OIFDuration = Convert.ToInt16(OIFDuration) - 1
            If Convert.ToInt16(OIFDuration) <= 0 Then
                lblTimeRemaining.Text = "TimeOut!"
                CompleteExam()
            Else
                totalSeconds = Convert.ToInt16(OIFDuration)
                seconds = totalSeconds Mod 60
                minutes = Math.Floor(totalSeconds / 60)
                time = minutes.ToString() + ":" + seconds.ToString()
                lblTimeRemaining.Text = time
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub CompleteExam()
        timerOIF.Enabled = False
        TerminateExam()
    End Sub

End Class