Public Class frmPerInformationForm

    Dim IndividualData As New clsIndividual()
    Dim FormTestDate As New clsCanFormTest()

    Private Sub frmPerInformationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNatOfOccuOthers.Enabled = False
        txtMarriageAnniversary.Enabled = False
        txtNoOfEarningMem.Enabled = False
        txtOtherReasonForChUFL.Enabled = False
        StartTest(My.Settings.FTDuration)
    End Sub

    Shared PIFDuration As Integer = 0

    Protected Sub StartTest(ByVal Duration As Integer)
        PIFDuration = Duration * 60
        timerPIF.Enabled = True
    End Sub

#Region " Marital Status "

    Dim IsMaritalStatusGiven As Boolean = False

    Private Sub chkMariMarried_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMariMarried.CheckedChanged
        If chkMariMarried.Checked = True Then
            ChkMariSingle.Checked = False
            chkMariDivorced.Checked = False
            txtMarriageAnniversary.Text = ""
            txtMarriageAnniversary.Enabled = True
            IsMaritalStatusGiven = True
        Else
            IsMaritalStatusGiven = False
        End If
    End Sub

    Private Sub ChkMariSingle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMariSingle.CheckedChanged
        If ChkMariSingle.Checked = True Then
            chkMariDivorced.Checked = False
            chkMariMarried.Checked = False
            txtMarriageAnniversary.Text = ""
            txtMarriageAnniversary.Enabled = False
            IsMaritalStatusGiven = True
        Else
            IsMaritalStatusGiven = False
        End If
    End Sub

    Private Sub chkMariDivorced_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMariDivorced.CheckedChanged
        If chkMariDivorced.Checked = True Then
            ChkMariSingle.Checked = False
            chkMariMarried.Checked = False
            txtMarriageAnniversary.Text = ""
            txtMarriageAnniversary.Enabled = False
            IsMaritalStatusGiven = True
        Else
            IsMaritalStatusGiven = False
        End If
    End Sub

#End Region

#Region " Living Pattern "

    Dim IsLivingPatternGiven As Boolean = False

    Private Sub chkLivPatLivingAlone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivPatLivingAlone.CheckedChanged
        If chkLivPatLivingAlone.Checked = True Then
            chkLivPatLivingWithParents.Checked = False
            chkLivPatLivWspNoCh.Checked = False
            chkLivPatLivWspNCh.Checked = False
            IsLivingPatternGiven = True
        Else
            IsLivingPatternGiven = False
        End If
    End Sub

    Private Sub chkLivPatLivingWithParents_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivPatLivingWithParents.CheckedChanged
        If chkLivPatLivingWithParents.Checked = True Then
            chkLivPatLivingAlone.Checked = False
            chkLivPatLivWspNoCh.Checked = False
            chkLivPatLivWspNCh.Checked = False
            IsLivingPatternGiven = True
        Else
            IsLivingPatternGiven = False
        End If
    End Sub

    Private Sub chkLivPatLivWspNoCh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivPatLivWspNoCh.CheckedChanged
        If chkLivPatLivWspNoCh.Checked = True Then
            chkLivPatLivingWithParents.Checked = False
            chkLivPatLivingAlone.Checked = False
            chkLivPatLivWspNCh.Checked = False
            IsLivingPatternGiven = True
        Else
            IsLivingPatternGiven = False
        End If
    End Sub

    Private Sub chkLivPatLivWspNCh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivPatLivWspNCh.CheckedChanged
        If chkLivPatLivWspNCh.Checked = True Then
            chkLivPatLivingWithParents.Checked = False
            chkLivPatLivWspNoCh.Checked = False
            chkLivPatLivingAlone.Checked = False
            IsLivingPatternGiven = True
        Else
            IsLivingPatternGiven = False
        End If
    End Sub

#End Region

#Region " Living In "

    Dim IsLivingInGiven As Boolean = False

    Private Sub chkLivInOwnHouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivInOwnHouse.CheckedChanged
        If chkLivInOwnHouse.Checked = True Then
            chkLivInRentedHouse.Checked = False
            txtNoOfEarningMem.Text = ""
            IsLivingInGiven = True
        Else
            IsLivingInGiven = False
        End If
    End Sub

    Private Sub chkLivInRentedHouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLivInRentedHouse.CheckedChanged
        If chkLivInRentedHouse.Checked = True Then
            chkLivInOwnHouse.Checked = False
            txtNoOfEarningMem.Text = ""
            IsLivingInGiven = True
        Else
            IsLivingInGiven = False
        End If
    End Sub

#End Region

#Region " Nature Of Occupation "

    Dim IsNatureOfOccupationGiven As Boolean = False

    Private Sub chkNatService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatService.CheckedChanged
        If chkNatService.Checked = True Then
            chkNatBusiness.Checked = False
            chkNatStudent.Checked = False
            chkNatHouseWife.Checked = False
            chkNatRetired.Checked = False
            chkNatOthers.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
        End If
    End Sub

    Private Sub chkNatBusiness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatBusiness.CheckedChanged
        If chkNatBusiness.Checked = True Then
            chkNatService.Checked = False
            chkNatStudent.Checked = False
            chkNatHouseWife.Checked = False
            chkNatRetired.Checked = False
            chkNatOthers.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
        End If
    End Sub

    Private Sub chkNatStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatStudent.CheckedChanged
        If chkNatStudent.Checked = True Then
            chkNatBusiness.Checked = False
            chkNatService.Checked = False
            chkNatHouseWife.Checked = False
            chkNatRetired.Checked = False
            chkNatOthers.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
        End If
    End Sub

    Private Sub chkNatHouseWife_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatHouseWife.CheckedChanged
        If chkNatHouseWife.Checked = True Then
            chkNatBusiness.Checked = False
            chkNatStudent.Checked = False
            chkNatService.Checked = False
            chkNatRetired.Checked = False
            chkNatOthers.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
        End If
    End Sub

    Private Sub chkNatRetired_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatRetired.CheckedChanged
        If chkNatRetired.Checked = True Then
            chkNatBusiness.Checked = False
            chkNatStudent.Checked = False
            chkNatHouseWife.Checked = False
            chkNatService.Checked = False
            chkNatOthers.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
        End If
    End Sub

    Private Sub chkNatOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNatOthers.CheckedChanged
        If chkNatOthers.Checked = True Then
            chkNatBusiness.Checked = False
            chkNatStudent.Checked = False
            chkNatHouseWife.Checked = False
            chkNatRetired.Checked = False
            chkNatService.Checked = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = True
            IsNatureOfOccupationGiven = True
        Else
            IsNatureOfOccupationGiven = False
            txtNatOfOccuOthers.Text = ""
            txtNatOfOccuOthers.Enabled = False
        End If
    End Sub

#End Region

#Region " Type Of ID "

    Dim IsTypeOfIDGiven As Boolean = False

    Private Sub chkNationalID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNationalID.CheckedChanged
        If chkNationalID.Checked = True Then
            chkPassport.Checked = False
            chkDrivingLicense.Checked = False
            chkBirthRegCert.Checked = False
            chkChairmanCert.Checked = False
            IsTypeOfIDGiven = True
        Else
            IsTypeOfIDGiven = False
        End If
    End Sub

    Private Sub chkPassport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPassport.CheckedChanged
        If chkPassport.Checked = True Then
            chkNationalID.Checked = False
            chkDrivingLicense.Checked = False
            chkBirthRegCert.Checked = False
            chkChairmanCert.Checked = False
            IsTypeOfIDGiven = True
        Else
            IsTypeOfIDGiven = False
        End If
    End Sub

    Private Sub chkDrivingLicense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDrivingLicense.CheckedChanged
        If chkDrivingLicense.Checked = True Then
            chkPassport.Checked = False
            chkNationalID.Checked = False
            chkBirthRegCert.Checked = False
            chkChairmanCert.Checked = False
            IsTypeOfIDGiven = True
        Else
            IsTypeOfIDGiven = False
        End If
    End Sub

    Private Sub chkBirthRegCert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBirthRegCert.CheckedChanged
        If chkBirthRegCert.Checked = True Then
            chkPassport.Checked = False
            chkDrivingLicense.Checked = False
            chkNationalID.Checked = False
            chkChairmanCert.Checked = False
            IsTypeOfIDGiven = True
        Else
            IsTypeOfIDGiven = False
        End If
    End Sub

    Private Sub chkChairmanCert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChairmanCert.CheckedChanged
        If chkChairmanCert.Checked = True Then
            chkPassport.Checked = False
            chkDrivingLicense.Checked = False
            chkBirthRegCert.Checked = False
            chkNationalID.Checked = False
            IsTypeOfIDGiven = True
        Else
            IsTypeOfIDGiven = False
        End If
    End Sub

#End Region

#Region " Gender "

    Dim IsGenderGiven As Boolean = False

    Private Sub chkGenMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenMale.CheckedChanged
        If chkGenMale.Checked = True Then
            chkGenFemale.Checked = False
            IsGenderGiven = True
        Else
            IsGenderGiven = False
        End If
    End Sub

    Private Sub chkGenFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenFemale.CheckedChanged
        If chkGenFemale.Checked = True Then
            chkGenMale.Checked = False
            IsGenderGiven = True
        Else
            IsGenderGiven = False
        End If
    End Sub

#End Region

#Region " Business Acitivity Of The Organization "

    Dim IsBusActivityOfTheOrgGiven As Boolean = False

    Private Sub chkBusActService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusActService.CheckedChanged
        If chkBusActService.Checked = True Then
            chkBusActBusiness.Checked = False
            chkBusActStudent.Checked = False
            IsBusActivityOfTheOrgGiven = True
        Else
            IsBusActivityOfTheOrgGiven = False
        End If
    End Sub

    Private Sub chkBusActBusiness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusActBusiness.CheckedChanged
        If chkBusActBusiness.Checked = True Then
            chkBusActService.Checked = False
            chkBusActStudent.Checked = False
            IsBusActivityOfTheOrgGiven = True
        Else
            IsBusActivityOfTheOrgGiven = False
        End If
    End Sub

    Private Sub chkBusActStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusActStudent.CheckedChanged
        If chkBusActStudent.Checked = True Then
            chkBusActBusiness.Checked = False
            chkBusActService.Checked = False
            IsBusActivityOfTheOrgGiven = True
        Else
            IsBusActivityOfTheOrgGiven = False
        End If
    End Sub

#End Region

#Region " Gross Family Income "

    Dim IsGrossFamilyIncGiven As Boolean = False

    Private Sub chkFamIncLess10K_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamIncLess10K.CheckedChanged
        If chkFamIncLess10K.Checked = True Then
            chkFamInc10Kto30K.Checked = False
            chkFamInc30Kto50K.Checked = False
            chkFamInc50Kto90K.Checked = False
            chkFamInc90Kto150K.Checked = False
            chkFamInc150KtoAbove.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
        End If
    End Sub

    Private Sub chkFamInc10Kto30K_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamInc10Kto30K.CheckedChanged
        If chkFamInc10Kto30K.Checked = True Then
            chkFamIncLess10K.Checked = False
            chkFamInc30Kto50K.Checked = False
            chkFamInc50Kto90K.Checked = False
            chkFamInc90Kto150K.Checked = False
            chkFamInc150KtoAbove.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
        End If
    End Sub

    Private Sub chkFamInc30Kto50K_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamInc30Kto50K.CheckedChanged
        If chkFamInc30Kto50K.Checked = True Then
            chkFamInc10Kto30K.Checked = False
            chkFamIncLess10K.Checked = False
            chkFamInc50Kto90K.Checked = False
            chkFamInc90Kto150K.Checked = False
            chkFamInc150KtoAbove.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
        End If
    End Sub

    Private Sub chkFamInc50Kto90K_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamInc50Kto90K.CheckedChanged
        If chkFamInc50Kto90K.Checked = True Then
            chkFamInc10Kto30K.Checked = False
            chkFamInc30Kto50K.Checked = False
            chkFamIncLess10K.Checked = False
            chkFamInc90Kto150K.Checked = False
            chkFamInc150KtoAbove.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
        End If
    End Sub

    Private Sub chkFamInc90Kto150K_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamInc90Kto150K.CheckedChanged
        If chkFamInc90Kto150K.Checked = True Then
            chkFamInc10Kto30K.Checked = False
            chkFamInc30Kto50K.Checked = False
            chkFamInc50Kto90K.Checked = False
            chkFamIncLess10K.Checked = False
            chkFamInc150KtoAbove.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
        End If
    End Sub

    Private Sub chkFamInc150KtoAbove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFamInc150KtoAbove.CheckedChanged
        If chkFamInc150KtoAbove.Checked = True Then
            chkFamInc10Kto30K.Checked = False
            chkFamInc30Kto50K.Checked = False
            chkFamInc50Kto90K.Checked = False
            chkFamInc90Kto150K.Checked = False
            chkFamIncLess10K.Checked = False
            IsGrossFamilyIncGiven = True
        Else
            IsGrossFamilyIncGiven = False
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

    Private Sub btnTerminateExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateExam.Click
        TerminateExam()
    End Sub

    Protected Sub TerminateExam()
        Try
            Dim Person As New clsIndividual()

            Person.IndName = txtName.Text
            Person.FathersName = txtFathersName.Text
            Person.MothersName = txtMothersName.Text
            Person.SpouseName = txtSpouseName.Text
            Person.DateOfBirth = txtDateOfBirth.Text

            'Gender Information
            If chkGenMale.Checked = True Then
                Person.Gender = "Male"
            ElseIf chkGenFemale.Checked = True Then
                Person.Gender = "Female"
            Else
                Person.Gender = ""
            End If
            'Gender Information

            Person.eTin = txtEtin.Text

            'Type Of ID
            If chkNationalID.Checked = True Then
                Person.TypeOfID = "Natioanal ID"
            ElseIf chkPassport.Checked = True Then
                Person.TypeOfID = "Passport"
            ElseIf chkDrivingLicense.Checked = True Then
                Person.TypeOfID = "Motor Driving License"
            ElseIf chkBirthRegCert.Checked = True Then
                Person.TypeOfID = "Birth Registration Certificate"
            ElseIf chkChairmanCert.Checked = True Then
                Person.TypeOfID = "Chairman Certificate"
            Else
                Person.TypeOfID = ""
            End If
            'Type Of ID

            Person.IDNo = txtIDNo.Text
            Person.PresentAddress = txtPresentAddress.Text
            Person.PermanentAddress = txtPermanentAddress.Text
            Person.Telephone = txtTelephoneRes.Text
            Person.Mobile = txtMobilePhone.Text
            Person.Email = txtEmail.Text

            'Nature Of Business
            If chkNatService.Checked = True Then
                Person.NatureOfOccupation = "Service"
            ElseIf chkNatBusiness.Checked = True Then
                Person.NatureOfOccupation = "Business"
            ElseIf chkNatStudent.Checked = True Then
                Person.NatureOfOccupation = "Student"
            ElseIf chkNatHouseWife.Checked = True Then
                Person.NatureOfOccupation = "House Wife"
            ElseIf chkNatRetired.Checked = True Then
                Person.NatureOfOccupation = "Retired"
            ElseIf chkNatOthers.Checked = True Then
                Person.NatureOfOccupation = txtNatOfOccuOthers.Text
            Else
                Person.NatureOfOccupation = ""
            End If
            'Nature Of Business

            Person.NatOfOccForYears = txtNatOfOccForYears.Text
            Person.OrgName = txtOrgName.Text

            'Business Activity
            If chkBusActService.Checked = True Then
                Person.BusinessActivity = "Service"
            ElseIf chkBusActBusiness.Checked = True Then
                Person.BusinessActivity = "Business"
            ElseIf chkBusActStudent.Checked = True Then
                Person.BusinessActivity = "Student"
            Else
                Person.BusinessActivity = ""
            End If
            'Business Activity

            Person.BusinessActDetails = txtBusinessActDetails.Text
            Person.WorkAddress = txtWorkAddress.Text
            Person.WorkTelephone = txtWorkTelephone.Text
            Person.WorkFax = txtWorkFax.Text
            Person.WorkEmail = txtWorkEmail.Text

            'Marital Status
            If ChkMariSingle.Checked = True Then
                Person.MaritalStatus = "Single"
                Person.MarriageAnniversary = ""
            ElseIf chkMariMarried.Checked = True Then
                Person.MaritalStatus = "Married"
                Person.MarriageAnniversary = txtMarriageAnniversary.Text
            ElseIf chkMariDivorced.Checked = True Then
                Person.MaritalStatus = "Divorced"
                Person.MarriageAnniversary = ""
            Else
                Person.MaritalStatus = ""
                Person.MarriageAnniversary = ""
            End If
            'Marital Status

            'Living Pattern
            If chkLivPatLivingAlone.Checked = True Then
                Person.LivingPattern = "Living along"
            ElseIf chkLivPatLivingWithParents.Checked = True Then
                Person.LivingPattern = "Living with parents"
            ElseIf chkLivPatLivWspNoCh.Checked = True Then
                Person.LivingPattern = "Living with spouse, no children"
            ElseIf chkLivPatLivWspNCh.Checked = True Then
                Person.LivingPattern = "Living with spouse and children"
            Else
                Person.LivingPattern = ""
            End If
            'Living Pattern

            'Living In
            If chkLivInOwnHouse.Checked = True Then
                Person.LivingIn = "Own house"
            ElseIf chkLivInRentedHouse.Checked = True Then
                Person.LivingIn = "Rented house"
            Else
                Person.LivingIn = ""
            End If
            'Living In

            Person.NumEarningMem = txtNoOfEarningMem.Text

            'Gross Family Income
            If chkFamIncLess10K.Checked = True Then
                Person.GrossFamilyIncome = "Less than 10,000"
            ElseIf chkFamInc10Kto30K.Checked = True Then
                Person.GrossFamilyIncome = "10,000 - 30,000"
            ElseIf chkFamInc30Kto50K.Checked = True Then
                Person.GrossFamilyIncome = "30,000 - 50,000"
            ElseIf chkFamInc50Kto90K.Checked = True Then
                Person.GrossFamilyIncome = "50,000 - 90,000"
            ElseIf chkFamInc90Kto150K.Checked = True Then
                Person.GrossFamilyIncome = "90,000 - 150,000"
            ElseIf chkFamInc150KtoAbove.Checked = True Then
                Person.GrossFamilyIncome = "150,000 - above"
            Else
                Person.GrossFamilyIncome = ""
            End If
            'Gross Family Income

            'Reason For Choosing UFL
            If chkDirectSales.Checked = True Then
                Person.ReasonForChoosing = "Direct Sales"
            ElseIf chkConvenientLocation.Checked = True Then
                Person.ReasonForChoosing = "Convenient Location"
            ElseIf chkAdvertising.Checked = True Then
                Person.ReasonForChoosing = "Advertising"
            ElseIf chkDissatisfactionWithOthers.Checked = True Then
                Person.ReasonForChoosing = "Dissatisfaction With Others"
            ElseIf chkRecByFam.Checked = True Then
                Person.ReasonForChoosing = "Recommended By Family/Friend"
            ElseIf chkIntRate.Checked = True Then
                Person.ReasonForChoosing = "Interest Rate"
            ElseIf chkReasonService.Checked = True Then
                Person.ReasonForChoosing = "Service"
            ElseIf chkReasonForChoosingOthers.Checked = True Then
                Person.ReasonForChoosing = txtOtherReasonForChUFL.Text
            Else
                Person.ReasonForChoosing = ""
            End If
            'Reason For Choosing UFL

            Dim ActualPerson As clsIndividual = IndividualData.fnGetAcutalPerInfoValues()
            Dim FormTestValueString As String = GetPerInfoString(ActualPerson, Person)

            Dim Accuracy As Double = FormTestDate.fnStopFTExam(My.Settings.CanFormTestID, FormTestValueString)
            PIFDuration = 0
            btnTerminateExam.Enabled = False
            timerPIF.Enabled = False
            MsgBox("Accuracy : " & Accuracy.ToString() & "%")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Function GetPerInfoString(ByVal ActualPerson As clsIndividual, ByVal Person As clsIndividual) As String
        Dim FormTestValueString As String = ""

        FormTestValueString &= ActualPerson.IndName & "~" & Person.IndName & "~|"
        FormTestValueString &= ActualPerson.FathersName & "~" & Person.FathersName & "~|"
        FormTestValueString &= ActualPerson.MothersName & "~" & Person.MothersName & "~|"
        FormTestValueString &= ActualPerson.SpouseName & "~" & Person.SpouseName & "~|"
        FormTestValueString &= ActualPerson.DateOfBirth & "~" & Person.DateOfBirth & "~|"
        FormTestValueString &= ActualPerson.Gender & "~" & Person.Gender & "~|"
        FormTestValueString &= ActualPerson.eTin & "~" & Person.eTin & "~|"
        FormTestValueString &= ActualPerson.TypeOfID & "~" & Person.TypeOfID & "~|"
        FormTestValueString &= ActualPerson.IDNo & "~" & Person.IDNo & "~|"
        FormTestValueString &= ActualPerson.PresentAddress & "~" & Person.PresentAddress & "~|"
        FormTestValueString &= ActualPerson.PermanentAddress & "~" & Person.PermanentAddress & "~|"
        FormTestValueString &= ActualPerson.Telephone & "~" & Person.Telephone & "~|"
        FormTestValueString &= ActualPerson.Mobile & "~" & Person.Mobile & "~|"
        FormTestValueString &= ActualPerson.Email & "~" & Person.Email & "~|"
        FormTestValueString &= ActualPerson.NatureOfOccupation & "~" & Person.NatureOfOccupation & "~|"
        FormTestValueString &= ActualPerson.NatOfOccForYears & "~" & Person.NatOfOccForYears & "~|"
        FormTestValueString &= ActualPerson.OrgName & "~" & Person.OrgName & "~|"
        FormTestValueString &= ActualPerson.BusinessActivity & "~" & Person.BusinessActivity & "~|"
        FormTestValueString &= ActualPerson.BusinessActDetails & "~" & Person.BusinessActDetails & "~|"
        FormTestValueString &= ActualPerson.WorkAddress & "~" & Person.WorkAddress & "~|"
        FormTestValueString &= ActualPerson.WorkTelephone & "~" & Person.WorkTelephone & "~|"
        FormTestValueString &= ActualPerson.WorkFax & "~" & Person.WorkFax & "~|"
        FormTestValueString &= ActualPerson.WorkEmail & "~" & Person.WorkEmail & "~|"
        FormTestValueString &= ActualPerson.MaritalStatus & "~" & Person.MaritalStatus & "~|"
        FormTestValueString &= ActualPerson.MarriageAnniversary & "~" & Person.MarriageAnniversary & "~|"
        FormTestValueString &= ActualPerson.LivingPattern & "~" & Person.LivingPattern & "~|"
        FormTestValueString &= ActualPerson.LivingIn & "~" & Person.LivingIn & "~|"
        FormTestValueString &= ActualPerson.NumEarningMem & "~" & Person.NumEarningMem & "~|"
        FormTestValueString &= ActualPerson.GrossFamilyIncome & "~" & Person.GrossFamilyIncome & "~|"
        FormTestValueString &= ActualPerson.ReasonForChoosing & "~" & Person.ReasonForChoosing & "~|"

        Return FormTestValueString
    End Function

    Dim totalSeconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim time As String = ""

    Private Sub timerPIF_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPIF.Tick
        Try
            PIFDuration = Convert.ToInt16(PIFDuration) - 1
            If Convert.ToInt16(PIFDuration) <= 0 Then
                lblTimeRemaining.Text = "TimeOut!"
                CompleteExam()
            Else
                totalSeconds = Convert.ToInt16(PIFDuration)
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
        timerPIF.Enabled = False
        TerminateExam()
    End Sub

    Private Sub frmPerInformationForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If PIFDuration <> 0 Then
            e.Cancel = True
            MsgBox("Exam Is Running. Can't Be Closed.")
        Else
            e.Cancel = False
        End If
    End Sub

End Class