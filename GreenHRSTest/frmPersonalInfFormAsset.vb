Public Class frmPersonalInfFormAsset

    Dim PerInfFormData As New clsPerInfFormAsset()
    Dim FormTestData As New clsCanFormTest()

#Region " Owner "

    Private Sub chkOwnerProprietor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerProprietor.CheckedChanged
        If chkOwnerProprietor.Checked = True Then
            chkOwnerDirector.Checked = False
            chkOwnerPartner.Checked = False
            chkOwnerShareholder.Checked = False
            chkOwnerGurarantor.Checked = False
            chkOwnerApplicant.Checked = False
        Else
            chkOwnerProprietor.Checked = False
        End If
    End Sub

    Private Sub chkOwnerDirector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerDirector.CheckedChanged
        If chkOwnerDirector.Checked = True Then
            chkOwnerProprietor.Checked = False
            chkOwnerPartner.Checked = False
            chkOwnerShareholder.Checked = False
            chkOwnerGurarantor.Checked = False
            chkOwnerApplicant.Checked = False
        Else
            chkOwnerDirector.Checked = False
        End If
    End Sub

    Private Sub chkOwnerPartner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerPartner.CheckedChanged
        If chkOwnerPartner.Checked = True Then
            chkOwnerProprietor.Checked = False
            chkOwnerDirector.Checked = False
            chkOwnerShareholder.Checked = False
            chkOwnerGurarantor.Checked = False
            chkOwnerApplicant.Checked = False
        Else
            chkOwnerPartner.Checked = False
        End If
    End Sub

    Private Sub chkOwnerShareholder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerShareholder.CheckedChanged
        If chkOwnerShareholder.Checked = True Then
            chkOwnerProprietor.Checked = False
            chkOwnerDirector.Checked = False
            chkOwnerPartner.Checked = False
            chkOwnerGurarantor.Checked = False
            chkOwnerApplicant.Checked = False
        Else
            chkOwnerShareholder.Checked = False
        End If
    End Sub

    Private Sub chkOwnerGurarantor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerGurarantor.CheckedChanged
        If chkOwnerGurarantor.Checked = True Then
            chkOwnerProprietor.Checked = False
            chkOwnerDirector.Checked = False
            chkOwnerPartner.Checked = False
            chkOwnerShareholder.Checked = False
            chkOwnerApplicant.Checked = False
        Else
            chkOwnerGurarantor.Checked = False
        End If
    End Sub

    Private Sub chkOwnerApplicant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOwnerApplicant.CheckedChanged
        If chkOwnerApplicant.Checked = True Then
            chkOwnerProprietor.Checked = False
            chkOwnerDirector.Checked = False
            chkOwnerPartner.Checked = False
            chkOwnerGurarantor.Checked = False
            chkOwnerShareholder.Checked = False
        Else
            chkOwnerApplicant.Checked = False
        End If
    End Sub

#End Region

#Region " Gender "

    Private Sub chkGenderMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenderMale.CheckedChanged
        If chkGenderMale.Checked = True Then
            chkGenderFemale.Checked = False
        Else
            chkGenderMale.Checked = False
        End If
    End Sub

    Private Sub chkGenderFemale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenderFemale.CheckedChanged
        If chkGenderFemale.Checked = True Then
            chkGenderMale.Checked = False
        Else
            chkGenderFemale.Checked = False
        End If
    End Sub

#End Region

#Region " Identity Card "

    Private Sub chkIDNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIDNo.CheckedChanged
        If chkIDNo.Checked = True Then
            chkIDYes.Checked = False
            chkIDNationalID.Checked = False
            chkIDMotorDrivingLicense.Checked = False
            chkIDPassport.Checked = False
            chkIDNationalID.Enabled = False
            chkIDMotorDrivingLicense.Enabled = False
            chkIDPassport.Enabled = False
            txtIDNo.Enabled = False
            txtIDNo.Text = ""
        End If
    End Sub

    Private Sub chkIDYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIDYes.CheckedChanged
        If chkIDYes.Checked = True Then
            chkIDNo.Checked = False
            txtIDNo.Enabled = True
            chkIDNationalID.Enabled = True
            chkIDMotorDrivingLicense.Enabled = True
            chkIDPassport.Enabled = True
        Else
            chkIDNationalID.Enabled = False
            chkIDMotorDrivingLicense.Enabled = False
            chkIDPassport.Enabled = False
            txtIDNo.Text = ""
            txtIDNo.Enabled = False
        End If
    End Sub

    Private Sub chkIDNationalID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIDNationalID.CheckedChanged
        If chkIDNationalID.Checked = True Then
            chkIDNo.Checked = False
            chkIDYes.Checked = True
            chkIDMotorDrivingLicense.Checked = False
            chkIDPassport.Checked = False
        End If
    End Sub

    Private Sub chkIDPassport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIDPassport.CheckedChanged
        If chkIDPassport.Checked = True Then
            chkIDNo.Checked = False
            chkIDNationalID.Checked = False
            chkIDMotorDrivingLicense.Checked = False
            chkIDYes.Checked = True
        End If
    End Sub

    Private Sub chkIDMotorDrivingLicense_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIDMotorDrivingLicense.CheckedChanged
        If chkIDMotorDrivingLicense.Checked = True Then
            chkIDNo.Checked = False
            chkIDYes.Checked = True
            chkIDNationalID.Checked = False
            chkIDPassport.Checked = False
        End If
    End Sub

#End Region

#Region " Dual Citizenship "

    Private Sub chkDualCitNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDualCitNo.CheckedChanged
        If chkDualCitNo.Checked = True Then
            chkDualCitYes.Checked = False
            txtDualCitCountry.Text = ""
            txtDualCitCountry.Enabled = False
        End If
    End Sub

    Private Sub chkDualCitYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDualCitYes.CheckedChanged
        If chkDualCitYes.Checked = True Then
            chkDualCitNo.Checked = False
            txtDualCitCountry.Enabled = True
        Else
            txtDualCitCountry.Text = ""
            txtDualCitCountry.Enabled = False
        End If
    End Sub

#End Region

#Region " TIN Certificate "

    Private Sub chkTinCertNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTinCertNo.CheckedChanged
        If chkTinCertNo.Checked = True Then
            chkTinCertYes.Checked = False
            txtTINNo.Text = ""
            txtTINNo.Enabled = False
        End If
    End Sub

    Private Sub chkTinCertYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTinCertYes.CheckedChanged
        If chkTinCertYes.Checked = True Then
            chkTinCertNo.Checked = False
            txtTINNo.Enabled = True
        Else
            txtTINNo.Text = ""
            txtTINNo.Enabled = False
        End If
    End Sub

#End Region

#Region " Present Address Mention "

    Private Sub chkPrOwned_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrOwned.CheckedChanged
        If chkPrOwned.Checked = True Then
            chkPrRented.Checked = False
            txtPrOccuTenure.Text = ""
            txtPrAgreementPeriod.Text = ""
            txtPrNameOfLandLord.Text = ""
            txtPrLandLordPhone.Text = ""
            txtPrOccuTenure.Enabled = False
            txtPrAgreementPeriod.Enabled = False
            txtPrNameOfLandLord.Enabled = False
            txtPrLandLordPhone.Enabled = False
        End If
    End Sub

    Private Sub chkPrRented_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrRented.CheckedChanged
        If chkPrRented.Checked = True Then
            chkPrOwned.Checked = False
            txtPrOccuTenure.Enabled = True
            txtPrAgreementPeriod.Enabled = True
            txtPrNameOfLandLord.Enabled = True
            txtPrLandLordPhone.Enabled = True
        Else
            txtPrOccuTenure.Text = ""
            txtPrAgreementPeriod.Text = ""
            txtPrNameOfLandLord.Text = ""
            txtPrLandLordPhone.Text = ""
            txtPrOccuTenure.Enabled = False
            txtPrAgreementPeriod.Enabled = False
            txtPrNameOfLandLord.Enabled = False
            txtPrLandLordPhone.Enabled = False
        End If
    End Sub

#End Region

#Region " Permanent Address Mention "

    Private Sub chkPerAddOwned_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPerAddOwned.CheckedChanged
        If chkPerAddOwned.Checked = True Then
            chkPerAddRented.Checked = False
            txtPerOccupancy.Text = ""
            txtPerAgrPeriod.Text = ""
            txtPerNameOfLandLord.Text = ""
            txtPerPhone.Text = ""
        End If
    End Sub

    Private Sub chkPerAddRented_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPerAddRented.CheckedChanged
        If chkPerAddRented.Checked = True Then
            chkPerAddOwned.Checked = False
        End If
    End Sub

#End Region

#Region " Institutional Degree "

    Private Sub chkInstDegNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstDegNo.CheckedChanged
        If chkInstDegNo.Checked = True Then
            chkInstDegYes.Checked = False
            txtLastAttainedDegree.Text = ""
            txtPassingYear.Text = ""
            txtInstitution.Text = ""
            txtLastAttainedDegree.Enabled = False
            txtPassingYear.Enabled = False
            txtInstitution.Enabled = False
        End If
    End Sub

    Private Sub chkInstDegYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstDegYes.CheckedChanged
        If chkInstDegYes.Checked = True Then
            chkInstDegNo.Checked = False
            txtLastAttainedDegree.Enabled = True
            txtPassingYear.Enabled = True
            txtInstitution.Enabled = True
        Else
            txtLastAttainedDegree.Text = ""
            txtPassingYear.Text = ""
            txtInstitution.Text = ""
            txtLastAttainedDegree.Enabled = False
            txtPassingYear.Enabled = False
            txtInstitution.Enabled = False
        End If
    End Sub

#End Region

#Region " Earn "

    Private Sub chkEarnNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarnNo.CheckedChanged
        If chkEarnNo.Checked = True Then
            chkEarnYes.Checked = False
            chkEarnBusiness.Checked = False
            chkEarnService.Checked = False
            chkEarnOther.Checked = False
            txtEarnOther.Text = ""
            txtOrganization.Text = ""
            txtEarnOther.Enabled = False
        End If
    End Sub

    Private Sub chkEarnYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarnYes.CheckedChanged
        If chkEarnYes.Checked = True Then
            chkEarnNo.Checked = False
            chkEarnService.Checked = False
            chkEarnOther.Checked = False
            txtEarnOther.Enabled = False
        End If
    End Sub

    Private Sub chkEarnBusiness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarnBusiness.CheckedChanged
        If chkEarnBusiness.Checked = True Then
            chkEarnService.Checked = False
            chkEarnOther.Checked = False
            txtEarnOther.Enabled = False
            chkEarnNo.Checked = False
        End If
    End Sub

    Private Sub chkEarnService_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarnService.CheckedChanged
        If chkEarnService.Checked = True Then
            chkEarnBusiness.Checked = False
            chkEarnOther.Checked = False
            txtEarnOther.Enabled = False
            chkEarnNo.Checked = False
        End If
    End Sub

    Private Sub chkEarnOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEarnOther.CheckedChanged
        If chkEarnOther.Checked = True Then
            chkEarnBusiness.Checked = False
            chkEarnService.Checked = False
            txtEarnOther.Enabled = True
            chkEarnNo.Checked = False
        Else
            txtEarnOther.Enabled = False
        End If
    End Sub

#End Region

    Private Sub frmPersonalInfFormAsset_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If PIFAssetDuration <> 0 Then
            e.Cancel = True
            MsgBox("Exam Is Running. Can't Be Closed.")
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub frmPersonalInfFormAsset_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtEarnOther.Enabled = False
        txtTechExpert.Enabled = False
        txtInlvInOtherBusiness.Enabled = False
        txtDualCitCountry.Enabled = False
        txtTINNo.Enabled = False
        txtPrOccuTenure.Enabled = False
        txtPrAgreementPeriod.Enabled = False
        txtPrNameOfLandLord.Enabled = False
        txtPrLandLordPhone.Enabled = False
        txtLastAttainedDegree.Enabled = False
        txtPassingYear.Enabled = False
        txtInstitution.Enabled = False
        txtIDNo.Enabled = False
        chkIDNationalID.Enabled = False
        chkIDMotorDrivingLicense.Enabled = False
        chkIDPassport.Enabled = False
        StartTest(My.Settings.FTDuration)
    End Sub

    Protected Sub StartTest(ByVal Duration As Integer)
        PIFAssetDuration = Duration * 60
        timerPIFAsset.Enabled = True
    End Sub

#Region " Technical Expertise "

    Private Sub chkTechExpertNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTechExpertNo.CheckedChanged
        If chkTechExpertNo.Checked = True Then
            chkTechExpertYes.Checked = False
            txtTechExpert.Text = ""
            txtTechExpert.Enabled = False
        End If
    End Sub

    Private Sub chkTechExpertYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTechExpertYes.CheckedChanged
        If chkTechExpertYes.Checked = True Then
            chkTechExpertNo.Checked = False
            txtTechExpert.Enabled = True
        End If
    End Sub

#End Region

#Region " Other Business Involvement "

    Private Sub chkOtherBusInlvNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtherBusInlvNo.CheckedChanged
        If chkOtherBusInlvNo.Checked = True Then
            chkOtherBusInlvYes.Checked = False
            txtInlvInOtherBusiness.Text = ""
            txtInlvInOtherBusiness.Enabled = False
        End If
    End Sub

    Private Sub chkOtherBusInlvYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOtherBusInlvYes.CheckedChanged
        If chkOtherBusInlvYes.Checked = True Then
            chkOtherBusInlvNo.Checked = False
            txtInlvInOtherBusiness.Enabled = True
        End If
    End Sub

#End Region

    Private Sub btnTerminateExam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateExam.Click
        TerminateExam()
    End Sub

    Dim totalSeconds As Integer = 0
    Dim seconds As Integer = 0
    Dim minutes As Integer = 0
    Dim time As String = ""
    Shared PIFAssetDuration As Integer = 0

    Private Sub timerPIFAsset_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerPIFAsset.Tick
        Try
            PIFAssetDuration = Convert.ToInt16(PIFAssetDuration) - 1
            If Convert.ToInt16(PIFAssetDuration) <= 0 Then
                lblTimeRemaining.Text = "TimeOut!"
                CompleteExam()
            Else
                totalSeconds = Convert.ToInt16(PIFAssetDuration)
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
        timerPIFAsset.Enabled = False
        TerminateExam()
    End Sub

    Protected Sub TerminateExam()
        Try
            Dim PerFormAsset As New clsPerInfFormAsset()

            If chkOwnerProprietor.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerProprietor.Text
            ElseIf chkOwnerDirector.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerDirector.Text
            ElseIf chkOwnerPartner.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerPartner.Text
            ElseIf chkOwnerShareholder.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerShareholder.Text
            ElseIf chkOwnerGurarantor.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerGurarantor.Text
            ElseIf chkOwnerApplicant.Checked = True Then
                PerFormAsset.OwnerType = chkOwnerApplicant.Text
            Else
                PerFormAsset.OwnerType = ""
            End If

            PerFormAsset.ApplicationID = txtApplicationID.Text
            PerFormAsset.ApplicantName = txtName.Text
            PerFormAsset.FathersName = txtFathersName.Text
            PerFormAsset.FOccupation = txtFProfession.Text
            PerFormAsset.MothersName = txtMothersName.Text
            PerFormAsset.Moccupation = txtMProfession.Text
            PerFormAsset.SpouseName = txtSpouseName.Text
            PerFormAsset.SOccupation = txtSProfession.Text
            PerFormAsset.DateOfBirth = txtDateOfBirth.Text

            If chkGenderMale.Checked = True Then
                PerFormAsset.Gender = chkGenderMale.Text
            ElseIf chkGenderFemale.Checked = True Then
                PerFormAsset.Gender = chkGenderFemale.Text
            Else
                PerFormAsset.Gender = ""
            End If

            PerFormAsset.District = txtDistrict.Text
            PerFormAsset.Country = txtCountry.Text

            If chkIDNo.Checked = True Then
                PerFormAsset.HaveIDCard = chkIDNo.Text
            ElseIf chkIDYes.Checked = True Then
                PerFormAsset.HaveIDCard = chkIDYes.Text
            Else
                PerFormAsset.HaveIDCard = ""
            End If

            If chkIDNationalID.Checked = True Then
                PerFormAsset.IDType = chkIDNationalID.Text
            ElseIf chkIDPassport.Checked = True Then
                PerFormAsset.IDType = chkIDPassport.Text
            ElseIf chkIDMotorDrivingLicense.Checked = True Then
                PerFormAsset.IDType = chkIDMotorDrivingLicense.Text
            Else
                PerFormAsset.IDType = ""
            End If

            PerFormAsset.IDNo = txtIDNo.Text
            PerFormAsset.Nationality = txtNationality.Text

            If chkDualCitNo.Checked = True Then
                PerFormAsset.DualCitizenship = chkDualCitNo.Text
            ElseIf chkDualCitYes.Checked = True Then
                PerFormAsset.DualCitizenship = chkDualCitYes.Text
            Else
                PerFormAsset.DualCitizenship = ""
            End If

            PerFormAsset.SecondCountry = txtDualCitCountry.Text

            If chkTinCertNo.Checked = True Then
                PerFormAsset.HaveTin = chkTinCertNo.Text
            ElseIf chkTinCertYes.Checked = True Then
                PerFormAsset.HaveTin = chkTinCertYes.Text
            Else
                PerFormAsset.HaveTin = ""
            End If

            PerFormAsset.TinNo = txtTINNo.Text
            PerFormAsset.TelephoneRes = txtTelephoneRes.Text
            PerFormAsset.Mobile = txtMobile.Text
            PerFormAsset.Email = txtEmail.Text

            PerFormAsset.PresentAddress = txtPresentAddress.Text

            If chkPrOwned.Checked = True Then
                PerFormAsset.PreAddOwnership = chkPrOwned.Text
            ElseIf chkPrRented.Checked = True Then
                PerFormAsset.PreAddOwnership = chkPrRented.Text
            Else
                PerFormAsset.PreAddOwnership = ""
            End If


            PerFormAsset.PreAddOccTenure = txtPrOccuTenure.Text
            PerFormAsset.PreAddAgrPeriod = txtPrAgreementPeriod.Text
            PerFormAsset.PreAddLandLord = txtPrNameOfLandLord.Text
            PerFormAsset.PreAddPhoneNo = txtPrLandLordPhone.Text

            If chkPrUtilityBill.Checked = True Then
                PerFormAsset.PreAddUtilityBill = chkPrUtilityBill.Text
            Else
                PerFormAsset.PreAddUtilityBill = ""
            End If

            PerFormAsset.PersentAddress = txtPermanentAddress.Text

            If chkPerAddOwned.Checked = True Then
                PerFormAsset.PerAddOwnership = chkPerAddOwned.Text
            ElseIf chkPerAddRented.Checked = True Then
                PerFormAsset.PerAddOwnership = chkPerAddRented.Text
            Else
                PerFormAsset.PerAddOwnership = ""
            End If

            PerFormAsset.PerAddOccTenure = txtPerOccupancy.Text
            PerFormAsset.PerAddAgrPeriod = txtPerAgrPeriod.Text
            PerFormAsset.PerAddLandLord = txtPerNameOfLandLord.Text
            PerFormAsset.PerAddPhoneNo = txtPerPhone.Text

            If chkPerUtilityBill.Checked = True Then
                PerFormAsset.PerAddUtilityBill = chkPerUtilityBill.Text
            Else
                PerFormAsset.PerAddUtilityBill = ""
            End If

            If chkInstDegNo.Checked = True Then
                PerFormAsset.HaveInstDegree = chkInstDegNo.Text
            ElseIf chkInstDegYes.Checked = True Then
                PerFormAsset.HaveInstDegree = chkInstDegYes.Text
            Else
                PerFormAsset.HaveInstDegree = ""
            End If

            PerFormAsset.LastAttinedDegree = txtLastAttainedDegree.Text
            PerFormAsset.PassingYear = txtPassingYear.Text
            PerFormAsset.Institution = txtInstitution.Text

            If chkEarnNo.Checked = True Then
                PerFormAsset.DoYouEarn = chkEarnNo.Text
            ElseIf chkEarnYes.Checked = True Then
                PerFormAsset.DoYouEarn = chkEarnYes.Text
            Else
                PerFormAsset.DoYouEarn = ""
            End If

            If chkEarnBusiness.Checked = True Then
                PerFormAsset.EarningType = chkEarnBusiness.Text
            ElseIf chkEarnService.Checked = True Then
                PerFormAsset.EarningType = chkEarnService.Text
            ElseIf chkEarnOther.Checked = True Then
                PerFormAsset.EarningType = txtEarnOther.Text
            Else
                PerFormAsset.EarningType = ""
            End If

            PerFormAsset.Organization = txtOrganization.Text

            If chkTechExpertNo.Checked = True Then
                PerFormAsset.HaveTechnicalExp = chkTechExpertNo.Text
            ElseIf chkTechExpertYes.Checked = True Then
                PerFormAsset.HaveTechnicalExp = chkTechExpertYes.Text
            Else
                PerFormAsset.HaveTechnicalExp = ""
            End If

            PerFormAsset.TechnicalExpertise = txtTechExpert.Text

            If chkOtherBusInlvNo.Checked = True Then
                PerFormAsset.InvolvedInOtherBusiness = chkOtherBusInlvNo.Text
            ElseIf chkOtherBusInlvYes.Checked = True Then
                PerFormAsset.InvolvedInOtherBusiness = chkOtherBusInlvYes.Text
            Else
                PerFormAsset.InvolvedInOtherBusiness = ""
            End If

            PerFormAsset.OtherBusiness = txtInlvInOtherBusiness.Text

            Dim ActualPerInfFormAsset As clsPerInfFormAsset = PerInfFormData.fnGetActualPerInfFormAsset()
            Dim FormTestValueString As String = GetPerInfFormAssetString(ActualPerInfFormAsset, PerFormAsset)

            Dim Accuracy As Double = FormTestData.fnStopFTExam(My.Settings.CanFormTestID, FormTestValueString)
            btnTerminateExam.Enabled = False
            PIFAssetDuration = 0
            timerPIFAsset.Enabled = False
            MsgBox("Accuracy : " & Accuracy.ToString() & "%")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Function GetPerInfFormAssetString(ByVal ActualPerFormAsset As clsPerInfFormAsset, ByVal PerFormAsset As clsPerInfFormAsset) As String
        Dim FormTestValueString As String = ""

        FormTestValueString &= ActualPerFormAsset.OwnerType & "~" & PerFormAsset.OwnerType & "~|"
        FormTestValueString &= ActualPerFormAsset.ApplicationID & "~" & PerFormAsset.ApplicationID & "~|"
        FormTestValueString &= ActualPerFormAsset.ApplicantName & "~" & PerFormAsset.ApplicantName & "~|"
        FormTestValueString &= ActualPerFormAsset.FathersName & "~" & PerFormAsset.FathersName & "~|"
        FormTestValueString &= ActualPerFormAsset.FOccupation & "~" & PerFormAsset.FOccupation & "~|"
        FormTestValueString &= ActualPerFormAsset.MothersName & "~" & PerFormAsset.MothersName & "~|"
        FormTestValueString &= ActualPerFormAsset.Moccupation & "~" & PerFormAsset.Moccupation & "~|"
        FormTestValueString &= ActualPerFormAsset.SpouseName & "~" & PerFormAsset.SpouseName & "~|"
        FormTestValueString &= ActualPerFormAsset.SOccupation & "~" & PerFormAsset.SOccupation & "~|"
        FormTestValueString &= ActualPerFormAsset.DateOfBirth & "~" & PerFormAsset.DateOfBirth & "~|"
        FormTestValueString &= ActualPerFormAsset.Gender & "~" & PerFormAsset.Gender & "~|"
        FormTestValueString &= ActualPerFormAsset.District & "~" & PerFormAsset.District & "~|"
        FormTestValueString &= ActualPerFormAsset.Country & "~" & PerFormAsset.Country & "~|"
        FormTestValueString &= ActualPerFormAsset.HaveIDCard & "~" & PerFormAsset.HaveIDCard & "~|"
        FormTestValueString &= ActualPerFormAsset.IDType & "~" & PerFormAsset.IDType & "~|"
        FormTestValueString &= ActualPerFormAsset.IDNo & "~" & PerFormAsset.IDNo & "~|"
        FormTestValueString &= ActualPerFormAsset.Nationality & "~" & PerFormAsset.Nationality & "~|"
        FormTestValueString &= ActualPerFormAsset.DualCitizenship & "~" & PerFormAsset.DualCitizenship & "~|"
        FormTestValueString &= ActualPerFormAsset.SecondCountry & "~" & PerFormAsset.SecondCountry & "~|"
        FormTestValueString &= ActualPerFormAsset.HaveTin & "~" & PerFormAsset.HaveTin & "~|"
        FormTestValueString &= ActualPerFormAsset.TinNo & "~" & PerFormAsset.TinNo & "~|"
        FormTestValueString &= ActualPerFormAsset.TelephoneRes & "~" & PerFormAsset.TelephoneRes & "~|"
        FormTestValueString &= ActualPerFormAsset.Mobile & "~" & PerFormAsset.Mobile & "~|"
        FormTestValueString &= ActualPerFormAsset.Email & "~" & PerFormAsset.Email & "~|"
        FormTestValueString &= ActualPerFormAsset.PresentAddress & "~" & PerFormAsset.PresentAddress & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddOwnership & "~" & PerFormAsset.PreAddOwnership & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddOccTenure & "~" & PerFormAsset.PreAddOccTenure & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddAgrPeriod & "~" & PerFormAsset.PreAddAgrPeriod & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddLandLord & "~" & PerFormAsset.PreAddLandLord & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddPhoneNo & "~" & PerFormAsset.PreAddPhoneNo & "~|"
        FormTestValueString &= ActualPerFormAsset.PreAddUtilityBill & "~" & PerFormAsset.PreAddUtilityBill & "~|"
        FormTestValueString &= ActualPerFormAsset.PersentAddress & "~" & PerFormAsset.PersentAddress & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddOwnership & "~" & PerFormAsset.PerAddOwnership & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddOccTenure & "~" & PerFormAsset.PerAddOccTenure & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddAgrPeriod & "~" & PerFormAsset.PerAddAgrPeriod & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddLandLord & "~" & PerFormAsset.PerAddLandLord & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddPhoneNo & "~" & PerFormAsset.PerAddPhoneNo & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddUtilityBill & "~" & PerFormAsset.PerAddUtilityBill & "~|"
        FormTestValueString &= ActualPerFormAsset.PerAddUtilityBill & "~" & PerFormAsset.PerAddUtilityBill & "~|"
        FormTestValueString &= ActualPerFormAsset.HaveInstDegree & "~" & PerFormAsset.HaveInstDegree & "~|"
        FormTestValueString &= ActualPerFormAsset.LastAttinedDegree & "~" & PerFormAsset.LastAttinedDegree & "~|"
        FormTestValueString &= ActualPerFormAsset.PassingYear & "~" & PerFormAsset.PassingYear & "~|"
        FormTestValueString &= ActualPerFormAsset.Institution & "~" & PerFormAsset.Institution & "~|"
        FormTestValueString &= ActualPerFormAsset.DoYouEarn & "~" & PerFormAsset.DoYouEarn & "~|"
        FormTestValueString &= ActualPerFormAsset.EarningType & "~" & PerFormAsset.EarningType & "~|"
        FormTestValueString &= ActualPerFormAsset.Organization & "~" & PerFormAsset.Organization & "~|"
        FormTestValueString &= ActualPerFormAsset.HaveTechnicalExp & "~" & PerFormAsset.HaveTechnicalExp & "~|"
        FormTestValueString &= ActualPerFormAsset.TechnicalExpertise & "~" & PerFormAsset.TechnicalExpertise & "~|"
        FormTestValueString &= ActualPerFormAsset.InvolvedInOtherBusiness & "~" & PerFormAsset.InvolvedInOtherBusiness & "~|"
        FormTestValueString &= ActualPerFormAsset.OtherBusiness & "~" & PerFormAsset.OtherBusiness & "~|"
        Return FormTestValueString
    End Function

End Class