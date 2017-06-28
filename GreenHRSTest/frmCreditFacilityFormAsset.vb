Public Class frmCreditFacilityFormAsset

    Dim CreditFacilityData As New clsCreditFacilityForm()
    Dim FormTestData As New clsCanFormTest()

    Private Sub btnTerminateExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateExam.Click
        TerminateExam()
    End Sub

    Private Sub frmCreditFacilityFormAsset_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CFAssetDuration <> 0 Then
            e.Cancel = True
            MsgBox("Exam Is Running. Can't Be Closed.")
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub frmCreditFacilityFormAsset_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtProductOther.Enabled = False
        txtDirectorsNumber.Enabled = False
        txtSpouseNumber.Enabled = False
        txtFamilyMemberNumber.Enabled = False
        txtBusinessFriendNumber.Enabled = False
        txtAmountOfSecurity.Enabled = False
        txtBankFI.Enabled = False
        chkDepositWithUFL.Enabled = False
        chkDepositWOBFI.Enabled = False
        txtLandSize.Enabled = False
        txtSqft.Enabled = False
        txtNumberofFloor.Enabled = False
        txtLocation.Enabled = False
        chkChqCoveringWOI.Enabled = False
        chkChqConveringWI.Enabled = False
        chkHypOnInvSimple.Enabled = False
        chkHypOnInvRegistered.Enabled = False
        chkHypOnMacSimple.Enabled = False
        chkHypOnMacRegistered.Enabled = False
        StartTest(My.Settings.FTDuration)
    End Sub

    Protected Sub StartTest(ByVal Duration As Integer)
        CFAssetDuration = Duration * 60
        timerCFA.Enabled = True
    End Sub

    Dim totalSeconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim time As String = ""
    Shared CFAssetDuration As Integer = 0

    Private Sub timerCFA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCFA.Tick
        Try
            CFAssetDuration = Convert.ToInt16(CFAssetDuration) - 1
            If Convert.ToInt16(CFAssetDuration) <= 0 Then
                lblTimeRemaining.Text = "TimeOut!"
                CompleteExam()
            Else
                totalSeconds = Convert.ToInt16(CFAssetDuration)
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
        timerCFA.Enabled = False
        TerminateExam()
    End Sub

    Protected Sub TerminateExam()

        Try
            Dim CreditFacility As New clsCreditFacilityForm()

            CreditFacility.ApplicationDate = txtApplicationDate.Text
            CreditFacility.ApplicationID = txtApplicationID.Text
            CreditFacility.Branch = txtBranch.Text

            If chkWorkingCapital.Checked = True Then
                CreditFacility.Purpose = chkWorkingCapital.Text
            ElseIf chkBusinessExpansion.Checked = True Then
                CreditFacility.Purpose = chkBusinessExpansion.Text
            ElseIf chkAssetProcurement.Checked = True Then
                CreditFacility.Purpose = chkAssetProcurement.Text
            ElseIf chkConsRenExt.Checked = True Then
                CreditFacility.Purpose = chkConsRenExt.Text
            Else
                CreditFacility.Purpose = ""
            End If

            If chkCreditSaleFin.Checked = True Then
                CreditFacility.Product = chkCreditSaleFin.Text
            ElseIf chkDistributorFinance.Checked = True Then
                CreditFacility.Product = chkDistributorFinance.Text
            ElseIf chkRevolvingLoan.Checked = True Then
                CreditFacility.Product = chkRevolvingLoan.Text
            ElseIf chkAgrani.Checked = True Then
                CreditFacility.Product = chkAgrani.Text
            ElseIf chkNokshi.Checked = True Then
                CreditFacility.Product = chkNokshi.Text
            ElseIf chkIclone.Checked = True Then
                CreditFacility.Product = chkIclone.Text
            ElseIf chkAffordableHL.Checked = True Then
                CreditFacility.Product = chkAffordableHL.Text
            ElseIf chkLease.Checked = True Then
                CreditFacility.Product = chkLease.Text
            ElseIf chkProductsOther.Checked = True Then
                CreditFacility.Product = txtProductOther.Text
            Else
                CreditFacility.Product = ""
            End If

            CreditFacility.Amount = txtAmount.Text
            CreditFacility.Tenure = txtMonths.Text
            CreditFacility.NameOfBusiness = txtNameOfBusiness.Text
            CreditFacility.GroupName = txtGroup.Text
            CreditFacility.MainSponsor = txtMainSponsor.Text
            CreditFacility.DesigOfMainSponsor = txtDesigOfMainSponsor.Text
            CreditFacility.ContactNumber = txtContactNumber.Text
            CreditFacility.OfficeAddress = txtOfficeAddress.Text
            CreditFacility.FactoryAddress = txtFactoryAddress.Text
            CreditFacility.ContactNumberOff = txtContactNumberOffice.Text
            CreditFacility.Email = txtEmail.Text

            If chkPersonalGuaranteeNO.Checked = True Then
                CreditFacility.PersonalGuarantee = chkPersonalGuaranteeNO.Text
            ElseIf chkPersonalGuaranteeYES.Checked = True Then
                CreditFacility.PersonalGuarantee = chkPersonalGuaranteeYES.Text
            Else
                CreditFacility.PersonalGuarantee = ""
            End If

            If chkDirectors.Checked = True Then
                CreditFacility.Directors = txtDirectorsNumber.Text
            Else
                CreditFacility.Directors = ""
            End If

            If chkSponsorsSpouse.Checked = True Then
                CreditFacility.Spouses = txtSpouseNumber.Text
            Else
                CreditFacility.Spouses = ""
            End If

            If chkFamilyMember.Checked = True Then
                CreditFacility.FamilyMember = txtFamilyMemberNumber.Text
            Else
                CreditFacility.FamilyMember = ""
            End If

            If chkBusinessFriend.Checked = True Then
                CreditFacility.BusinessFriend = txtBusinessFriendNumber.Text
            Else
                CreditFacility.BusinessFriend = ""
            End If

            If chkLienNo.Checked = True Then
                CreditFacility.LienOnCash = chkLienNo.Text
            ElseIf chkLienYes.Checked = True Then
                CreditFacility.LienOnCash = chkLienYes.Text
            Else
                CreditFacility.LienOnCash = ""
            End If

            If chkDepositWithUFL.Checked = True Then
                CreditFacility.TypeOfSecurity = chkDepositWithUFL.Text
            ElseIf chkDepositWOBFI.Checked = True Then
                CreditFacility.TypeOfSecurity = chkDepositWOBFI.Text
            Else
                CreditFacility.TypeOfSecurity = ""
            End If

            CreditFacility.SecurityAmount = txtAmountOfSecurity.Text
            CreditFacility.BankFIName = txtBankFI.Text

            If chkMortgageNo.Checked = True Then
                CreditFacility.RegisteredMortgage = chkMortgageNo.Text
            ElseIf chkMortgageYes.Checked = True Then
                CreditFacility.RegisteredMortgage = chkMortgageYes.Text
            Else
                CreditFacility.RegisteredMortgage = ""
            End If

            CreditFacility.LandSize = txtLandSize.Text
            CreditFacility.FloorSize = txtSqft.Text
            CreditFacility.NumberOfFloor = txtNumberofFloor.Text
            CreditFacility.Location = txtLocation.Text

            If chkChqCoveringNo.Checked = True Then
                CreditFacility.ChqCovering = chkChqCoveringNo.Text
            ElseIf chkChqConveringYes.Checked = True Then
                CreditFacility.ChqCovering = chkChqConveringYes.Text
            Else
                CreditFacility.ChqCovering = ""
            End If

            If chkChqConveringWI.Checked = True Then
                CreditFacility.ChqCoveringInt = chkChqConveringWI.Text
            ElseIf chkChqCoveringWOI.Checked = True Then
                CreditFacility.ChqCoveringInt = chkChqCoveringWOI.Text
            Else
                CreditFacility.ChqCoveringInt = ""
            End If

            If chkHypOnInvNo.Checked = True Then
                CreditFacility.HypoInv = chkHypOnInvNo.Text
            ElseIf chkHypOnInvYes.Checked = True Then
                CreditFacility.HypoInv = chkHypOnInvYes.Text
            Else
                CreditFacility.HypoInv = ""
            End If

            If chkHypOnInvSimple.Checked = True Then
                CreditFacility.HypoInvType = chkHypOnInvSimple.Text
            ElseIf chkHypOnInvRegistered.Checked = True Then
                CreditFacility.HypoInvType = chkHypOnInvRegistered.Text
            Else
                CreditFacility.HypoInvType = ""
            End If

            If chkHypOnMacNo.Checked = True Then
                CreditFacility.HypoMac = chkHypOnMacNo.Text
            ElseIf chkHypOnMacYes.Checked = True Then
                CreditFacility.HypoMac = chkHypOnMacYes.Text
            Else
                CreditFacility.HypoMac = ""
            End If

            If chkHypOnMacSimple.Checked = True Then
                CreditFacility.HypoMacType = chkHypOnMacSimple.Text
            ElseIf chkHypOnMacRegistered.Checked = True Then
                CreditFacility.HypoMacType = chkHypOnMacRegistered.Text
            Else
                CreditFacility.HypoMacType = ""
            End If

            Dim ActualCreditFacility As clsCreditFacilityForm = CreditFacilityData.fnGetActualCreditFacilityInfoValues()
            Dim FormTestValueString As String = GetCreditFacilityInfoString(ActualCreditFacility, CreditFacility)

            Dim Accuracy As Double = FormTestData.fnStopFTExam(My.Settings.CanFormTestID, FormTestValueString)
            btnTerminateExam.Enabled = False
            CFAssetDuration = 0
            timerCFA.Enabled = False
            MsgBox("Accuracy : " & Accuracy.ToString() & "%")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Function GetCreditFacilityInfoString(ByVal ActualCreditFacility As clsCreditFacilityForm, ByVal CreditFacility As clsCreditFacilityForm) As String
        Dim FormTestValueString As String = ""

        FormTestValueString &= ActualCreditFacility.ApplicationDate & "~" & CreditFacility.ApplicationDate & "~|"
        FormTestValueString &= ActualCreditFacility.ApplicationID & "~" & CreditFacility.ApplicationID & "~|"
        FormTestValueString &= ActualCreditFacility.Branch & "~" & CreditFacility.Branch & "~|"
        FormTestValueString &= ActualCreditFacility.Purpose & "~" & CreditFacility.Purpose & "~|"
        FormTestValueString &= ActualCreditFacility.Product & "~" & CreditFacility.Product & "~|"
        FormTestValueString &= ActualCreditFacility.Amount & "~" & CreditFacility.Amount & "~|"
        FormTestValueString &= ActualCreditFacility.Tenure & "~" & CreditFacility.Tenure & "~|"
        FormTestValueString &= ActualCreditFacility.NameOfBusiness & "~" & CreditFacility.NameOfBusiness & "~|"
        FormTestValueString &= ActualCreditFacility.GroupName & "~" & CreditFacility.GroupName & "~|"
        FormTestValueString &= ActualCreditFacility.MainSponsor & "~" & CreditFacility.MainSponsor & "~|"
        FormTestValueString &= ActualCreditFacility.DesigOfMainSponsor & "~" & CreditFacility.DesigOfMainSponsor & "~|"
        FormTestValueString &= ActualCreditFacility.ContactNumber & "~" & CreditFacility.ContactNumber & "~|"
        FormTestValueString &= ActualCreditFacility.OfficeAddress & "~" & CreditFacility.OfficeAddress & "~|"
        FormTestValueString &= ActualCreditFacility.FactoryAddress & "~" & CreditFacility.FactoryAddress & "~|"
        FormTestValueString &= ActualCreditFacility.ContactNumberOff & "~" & CreditFacility.ContactNumberOff & "~|"
        FormTestValueString &= ActualCreditFacility.Email & "~" & CreditFacility.Email & "~|"
        FormTestValueString &= ActualCreditFacility.PersonalGuarantee & "~" & CreditFacility.PersonalGuarantee & "~|"
        FormTestValueString &= ActualCreditFacility.Directors & "~" & CreditFacility.Directors & "~|"
        FormTestValueString &= ActualCreditFacility.Spouses & "~" & CreditFacility.Spouses & "~|"
        FormTestValueString &= ActualCreditFacility.FamilyMember & "~" & CreditFacility.FamilyMember & "~|"
        FormTestValueString &= ActualCreditFacility.BusinessFriend & "~" & CreditFacility.BusinessFriend & "~|"
        FormTestValueString &= ActualCreditFacility.LienOnCash & "~" & CreditFacility.LienOnCash & "~|"
        FormTestValueString &= ActualCreditFacility.TypeOfSecurity & "~" & CreditFacility.TypeOfSecurity & "~|"
        FormTestValueString &= ActualCreditFacility.SecurityAmount & "~" & CreditFacility.SecurityAmount & "~|"
        FormTestValueString &= ActualCreditFacility.BankFIName & "~" & CreditFacility.BankFIName & "~|"
        FormTestValueString &= ActualCreditFacility.LandSize & "~" & CreditFacility.LandSize & "~|"
        FormTestValueString &= ActualCreditFacility.FloorSize & "~" & CreditFacility.FloorSize & "~|"
        FormTestValueString &= ActualCreditFacility.NumberOfFloor & "~" & CreditFacility.NumberOfFloor & "~|"
        FormTestValueString &= ActualCreditFacility.Location & "~" & CreditFacility.Location & "~|"
        FormTestValueString &= ActualCreditFacility.ChqCovering & "~" & CreditFacility.ChqCovering & "~|"
        FormTestValueString &= ActualCreditFacility.ChqCoveringInt & "~" & CreditFacility.ChqCoveringInt & "~|"
        FormTestValueString &= ActualCreditFacility.HypoInv & "~" & CreditFacility.HypoInv & "~|"
        FormTestValueString &= ActualCreditFacility.HypoInvType & "~" & CreditFacility.HypoInvType & "~|"
        FormTestValueString &= ActualCreditFacility.HypoMac & "~" & CreditFacility.HypoMac & "~|"
        FormTestValueString &= ActualCreditFacility.HypoMacType & "~" & CreditFacility.HypoMacType & "~|"

        Return FormTestValueString
    End Function

#Region " Purpose "

    Private Sub chkWorkingCapital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWorkingCapital.CheckedChanged
        If chkWorkingCapital.Checked = True Then
            chkBusinessExpansion.Checked = False
            chkAssetProcurement.Checked = False
            chkConsRenExt.Checked = False
        End If
    End Sub

    Private Sub chkBusinessExpansion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusinessExpansion.CheckedChanged
        If chkBusinessExpansion.Checked = True Then
            chkWorkingCapital.Checked = False
            chkAssetProcurement.Checked = False
            chkConsRenExt.Checked = False
        End If
    End Sub

    Private Sub chkAssetProcurement_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAssetProcurement.CheckedChanged
        If chkAssetProcurement.Checked = True Then
            chkBusinessExpansion.Checked = False
            chkWorkingCapital.Checked = False
            chkConsRenExt.Checked = False
        End If
    End Sub

    Private Sub chkConsRenExt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConsRenExt.CheckedChanged
        If chkConsRenExt.Checked = True Then
            chkBusinessExpansion.Checked = False
            chkAssetProcurement.Checked = False
            chkWorkingCapital.Checked = False
        End If
    End Sub

#End Region

#Region " Product "

    Private Sub chkCreditSaleFin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreditSaleFin.CheckedChanged
        If chkCreditSaleFin.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkDistributorFinance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDistributorFinance.CheckedChanged
        If chkDistributorFinance.Checked = True Then
            chkCreditSaleFin.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkRevolvingLoan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRevolvingLoan.CheckedChanged
        If chkRevolvingLoan.Checked = True Then
            chkDistributorFinance.Checked = False
            chkCreditSaleFin.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkAgrani_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrani.CheckedChanged
        If chkAgrani.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkCreditSaleFin.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkNokshi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNokshi.CheckedChanged
        If chkNokshi.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkCreditSaleFin.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkIclone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIclone.CheckedChanged
        If chkIclone.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkCreditSaleFin.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkAffordableHL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAffordableHL.CheckedChanged
        If chkAffordableHL.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkCreditSaleFin.Checked = False
            chkLease.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkLease_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLease.CheckedChanged
        If chkLease.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkCreditSaleFin.Checked = False
            chkProductsOther.Checked = False
            txtProductOther.Enabled = False
        End If
    End Sub

    Private Sub chkProductsOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProductsOther.CheckedChanged
        If chkProductsOther.Checked = True Then
            chkDistributorFinance.Checked = False
            chkRevolvingLoan.Checked = False
            chkAgrani.Checked = False
            chkNokshi.Checked = False
            chkIclone.Checked = False
            chkAffordableHL.Checked = False
            chkLease.Checked = False
            chkCreditSaleFin.Checked = False
            txtProductOther.Enabled = True
        Else
            txtProductOther.Enabled = False
        End If
    End Sub

#End Region

#Region " Personal Guarantee "

    Private Sub chkPersonalGuaranteeNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonalGuaranteeNO.CheckedChanged
        If chkPersonalGuaranteeNO.Checked = True Then
            chkPersonalGuaranteeYES.Checked = False
            txtDirectorsNumber.Text = ""
            txtDirectorsNumber.Enabled = False
            txtSpouseNumber.Text = ""
            txtSpouseNumber.Enabled = False
            txtFamilyMemberNumber.Text = ""
            txtFamilyMemberNumber.Enabled = False
            txtBusinessFriendNumber.Text = ""
            txtBusinessFriendNumber.Enabled = False
            chkDirectors.Checked = False
            chkSponsorsSpouse.Checked = False
            chkFamilyMember.Checked = False
            chkBusinessFriend.Checked = False
        End If
    End Sub

    Private Sub chkPersonalGuaranteeYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPersonalGuaranteeYES.CheckedChanged
        If chkPersonalGuaranteeYES.Checked = True Then
            chkPersonalGuaranteeNO.Checked = False
        End If
    End Sub

    Private Sub chkDirectors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDirectors.CheckedChanged
        If chkDirectors.Checked = True Then
            txtDirectorsNumber.Enabled = True
            chkPersonalGuaranteeNO.Checked = False
            chkPersonalGuaranteeYES.Checked = True
        Else
            txtDirectorsNumber.Text = ""
            txtDirectorsNumber.Enabled = False
        End If
    End Sub

    Private Sub chkSponsorsSpouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSponsorsSpouse.CheckedChanged
        If chkSponsorsSpouse.Checked = True Then
            txtSpouseNumber.Enabled = True
            chkPersonalGuaranteeNO.Checked = False
            chkPersonalGuaranteeYES.Checked = True
        Else
            txtSpouseNumber.Text = ""
            txtSpouseNumber.Enabled = False
        End If
    End Sub

    Private Sub chkFamilyMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamilyMember.CheckedChanged
        If chkFamilyMember.Checked = True Then
            txtFamilyMemberNumber.Enabled = True
            chkPersonalGuaranteeNO.Checked = False
            chkPersonalGuaranteeYES.Checked = True
        Else
            txtFamilyMemberNumber.Text = ""
            txtFamilyMemberNumber.Enabled = False
        End If
    End Sub

    Private Sub chkBusinessFriend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusinessFriend.CheckedChanged
        If chkBusinessFriend.Checked = True Then
            txtBusinessFriendNumber.Enabled = True
            chkPersonalGuaranteeNO.Checked = False
            chkPersonalGuaranteeYES.Checked = True
        Else
            txtBusinessFriendNumber.Text = ""
            txtBusinessFriendNumber.Enabled = False
        End If
    End Sub

#End Region

#Region " Lien On Cash "

    Private Sub chkLienNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLienNo.CheckedChanged
        If chkLienNo.Checked = True Then
            chkLienYes.Checked = False
            txtAmountOfSecurity.Enabled = False
            txtBankFI.Enabled = False
            chkDepositWithUFL.Enabled = False
            chkDepositWOBFI.Enabled = False
            txtAmountOfSecurity.Text = ""
            txtBankFI.Text = ""
        End If
    End Sub

    Private Sub chkLienYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLienYes.CheckedChanged
        If chkLienYes.Checked = True Then
            chkLienNo.Checked = False
            txtAmountOfSecurity.Text = ""
            txtBankFI.Text = ""
            txtAmountOfSecurity.Enabled = True
            txtBankFI.Enabled = True
            chkDepositWithUFL.Enabled = True
            chkDepositWOBFI.Enabled = True
        Else
            txtAmountOfSecurity.Enabled = False
            txtBankFI.Enabled = False
            chkDepositWithUFL.Enabled = False
            chkDepositWOBFI.Enabled = False
            chkDepositWithUFL.Checked = False
            chkDepositWOBFI.Checked = False
        End If
    End Sub

    Private Sub chkDepositWithUFL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDepositWithUFL.CheckedChanged
        If chkDepositWithUFL.Checked = True Then
            chkDepositWOBFI.Checked = False
        End If
    End Sub

    Private Sub chkDepositWOBFI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDepositWOBFI.CheckedChanged
        If chkDepositWOBFI.Checked = True Then
            chkDepositWithUFL.Checked = False
        End If
    End Sub

#End Region

#Region " Registered Mortgage "

    Private Sub chkMortgageNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMortgageNo.CheckedChanged
        If chkMortgageNo.Checked = True Then
            chkMortgageYes.Checked = False
            txtLandSize.Enabled = False
            txtSqft.Enabled = False
            txtNumberofFloor.Enabled = False
            txtLocation.Enabled = False
            txtLandSize.Text = ""
            txtSqft.Text = ""
            txtNumberofFloor.Text = ""
            txtLocation.Text = ""
        End If
    End Sub

    Private Sub chkMortgageYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMortgageYes.CheckedChanged
        If chkMortgageYes.Checked = True Then
            chkMortgageNo.Checked = False
            txtLandSize.Enabled = True
            txtSqft.Enabled = True
            txtNumberofFloor.Enabled = True
            txtLocation.Enabled = True
        Else
            txtLandSize.Enabled = False
            txtSqft.Enabled = False
            txtNumberofFloor.Enabled = False
            txtLocation.Enabled = False
            txtLandSize.Text = ""
            txtSqft.Text = ""
            txtNumberofFloor.Text = ""
            txtLocation.Text = ""
        End If
    End Sub

#End Region

#Region " Facility Amount "

    Private Sub chkChqCoveringNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChqCoveringNo.CheckedChanged
        If chkChqCoveringNo.Checked = True Then
            chkChqConveringYes.Checked = False
            chkChqConveringWI.Checked = False
            chkChqCoveringWOI.Checked = False
            chkChqCoveringWOI.Enabled = False
            chkChqConveringWI.Enabled = False
        End If
    End Sub

    Private Sub chkChqConveringYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChqConveringYes.CheckedChanged
        If chkChqConveringYes.Checked = True Then
            chkChqCoveringNo.Checked = False
            chkChqCoveringWOI.Enabled = True
            chkChqConveringWI.Enabled = True
        Else
            chkChqConveringWI.Checked = False
            chkChqCoveringWOI.Checked = False
            chkChqConveringWI.Enabled = False
            chkChqCoveringWOI.Enabled = False
        End If
    End Sub

    Private Sub chkChqConveringWI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChqConveringWI.CheckedChanged
        If chkChqConveringWI.Checked = True Then
            chkChqCoveringWOI.Checked = False
            chkChqConveringYes.Checked = True
            chkChqCoveringNo.Checked = False
        End If
    End Sub

    Private Sub chkChqCoveringWOI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChqCoveringWOI.CheckedChanged
        If chkChqCoveringWOI.Checked = True Then
            chkChqConveringWI.Checked = False
            chkChqConveringYes.Checked = True
            chkChqCoveringNo.Checked = False
        End If
    End Sub

#End Region

#Region " Hypothecation On Inventory "

    Private Sub chkHypOnInvNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnInvNo.CheckedChanged
        If chkHypOnInvNo.Checked = True Then
            chkHypOnInvYes.Checked = False
            chkHypOnInvSimple.Checked = False
            chkHypOnInvRegistered.Checked = False
            chkHypOnInvSimple.Enabled = False
            chkHypOnInvRegistered.Enabled = False
        End If
    End Sub

    Private Sub chkHypOnInvYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnInvYes.CheckedChanged
        If chkHypOnInvYes.Checked = True Then
            chkHypOnInvNo.Checked = False
            chkHypOnInvSimple.Enabled = True
            chkHypOnInvRegistered.Enabled = True
        Else
            chkHypOnInvSimple.Checked = False
            chkHypOnInvRegistered.Checked = False
            chkHypOnInvSimple.Enabled = False
            chkHypOnInvRegistered.Enabled = False
        End If
    End Sub

    Private Sub chkHypOnInvSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnInvSimple.CheckedChanged
        If chkHypOnInvSimple.Checked = True Then
            chkHypOnInvRegistered.Checked = False
        End If
    End Sub

    Private Sub chkHypOnInvRegistered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnInvRegistered.CheckedChanged
        If chkHypOnInvRegistered.Checked = True Then
            chkHypOnInvSimple.Checked = False
        End If
    End Sub

#End Region

#Region " Hypothecation On Machinery "

    Private Sub chkHypOnMacNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnMacNo.CheckedChanged
        If chkHypOnMacNo.Checked = True Then
            chkHypOnMacYes.Checked = False
            chkHypOnMacSimple.Checked = False
            chkHypOnMacRegistered.Checked = False
            chkHypOnMacSimple.Enabled = False
            chkHypOnMacRegistered.Enabled = False
        End If
    End Sub

    Private Sub chkHypOnMacYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnMacYes.CheckedChanged
        If chkHypOnMacYes.Checked = True Then
            chkHypOnMacNo.Checked = False
            chkHypOnMacSimple.Enabled = True
            chkHypOnMacRegistered.Enabled = True
        End If
    End Sub

    Private Sub chkHypOnMacSimple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnMacSimple.CheckedChanged
        If chkHypOnMacSimple.Checked = True Then
            chkHypOnMacRegistered.Checked = False
            chkHypOnMacNo.Checked = False
            chkHypOnMacYes.Checked = True
        End If
    End Sub

    Private Sub chkHypOnMacRegistered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHypOnMacRegistered.CheckedChanged
        If chkHypOnMacRegistered.Checked = True Then
            chkHypOnMacSimple.Checked = False
            chkHypOnMacNo.Checked = False
            chkHypOnMacYes.Checked = True
        End If
    End Sub

#End Region

  
End Class