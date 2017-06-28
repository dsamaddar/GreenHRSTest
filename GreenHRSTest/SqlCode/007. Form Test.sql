
-- drop table tblFormList
Create table tblFormList(
FormID nvarchar(50) primary key,
FormTitle nvarchar(200),
FormName nvarchar(50),
Duration int,
EntryBy nvarchar(50) default 'dsamaddar',
EntryDate datetime default getdate()
);

Insert Into tblFormList(FormID,FormTitle,FormName,Duration)
Values('FRM-00000001','Organizational Information Form','frmOrgInformationForm',3)

Insert Into tblFormList(FormID,FormTitle,FormName,Duration)
Values('FRM-00000002','Personal Information Form','frmPerInformationForm',4)

Insert Into tblFormList(FormID,FormTitle,FormName,Duration)
Values('FRM-00000003','Personal Information Form - Asset','frmPersonalInfFormAsset',4)

Insert Into tblFormList(FormID,FormTitle,FormName,Duration)
Values('FRM-00000004','Credit Facility Form - Asset','frmCreditFacilityFormAsset',4)

Select * from tblFormList
GO

Create proc spGetFormList
as
begin
	Select FormID,FormTitle from tblFormList Order By FormTitle
end

GO

Insert Into tblAppSettings(PropertyName,PropertyValue)Values('CurrentCanFormTestID','0')
Insert Into tblAppSettings(PropertyName,PropertyValue)Values('CurrentFTRollID','0')
GO

-- drop table tblCandidateFormTest
Create table tblCandidateFormTest(
CanFormTestID nvarchar(50) primary key,
CandidateID nvarchar(50) foreign key references tblCandidateBasicInfo(CandidateID),
FormID nvarchar(50) foreign key references tblFormList(FormID),
ExamRollNo nvarchar(50) UNIQUE(ExamRollNo),
StartedOn datetime,
EndedOn datetime,
Duration int,
Accuracy numeric(5,2) default 0,
IsActive bit default 1,
AssignedBy nvarchar(50),
AssignedOn datetime default getdate()
);

Select * from tblCandidateFormTest

GO

Create proc spGetFormTestScore
@CandidateID nvarchar(50)
as
begin

	Select CanFormTestID,FL.FormTitle,ExamRollNo,CFT.Duration,Accuracy,StartedOn from tblCandidateFormTest CFT INNER JOIN tblFormList FL 
	ON CFT.FormID = FL.FormID
	Where CandidateID = @CandidateID

end

-- exec spGetFormTestScore 'Can-00000001'

GO

-- exec spGetAssignedFormTestByCandidate 'Can-00000001'
alter proc spGetAssignedFormTestByCandidate
@CandidateID nvarchar(50)
as
begin
	Select CanFormTestID,FL.FormTitle from tblCandidateFormTest CFT 
	INNER JOIN tblFormList FL ON CFT.FormID = FL.FormID
	Where CFT.IsActive=1
	Order By FL.FormTitle
end

GO

Create proc spStartFTExam
@CanFormTestID nvarchar(50),
@ExamRollNo nvarchar(50)
as
begin
	
	Declare @Duration as int Set @Duration = 0
	If exists (Select * from tblCandidateFormTest Where CanFormTestID = @CanFormTestID And ExamRollNo=@ExamRollNo)
	begin
		Update tblCandidateFormTest Set StartedOn = GETDATE(),IsActive=0 Where CanFormTestID = @CanFormTestID
		Select @Duration=Duration from tblCandidateFormTest Where CanFormTestID = @CanFormTestID
	end
	
	Select @Duration as 'Duration'
end

GO

alter proc spStopFTExam
@CanFormTestID nvarchar(50),
@FormTestValueString nvarchar(4000)
as
begin
begin tran

	Declare @AvgAccuracy as numeric(5,2) Set @AvgAccuracy = 0
	
	Update tblCandidateFormTest Set EndedOn=Getdate() Where CanFormTestID=@CanFormTestID
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	exec spInsertCanFormTestValues @CanFormTestID,@FormTestValueString
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Update tblCandidateFormTestValues Set Accuracy = ( Convert(numeric(5,2), LEN(ActualValue)) - dbo.edit_distance(ActualValue,ComparedValue))/ ( Convert(numeric(5,2), case When LEN(ActualValue) = 0 Then 1 Else LEN(ActualValue) end ))*100
	Where CanFormTestID = @CanFormTestID And LEN(ActualValue) > 0
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Select @AvgAccuracy = AVG(Accuracy) from tblCandidateFormTestValues Where CanFormTestID = @CanFormTestID
	And LEN(ActualValue) > 0
	
	Update tblCandidateFormTest Set Accuracy = @AvgAccuracy Where CanFormTestID = @CanFormTestID
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Select @AvgAccuracy as 'Accuracy'

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO

-- exec spInsertCandidateFormTest 'Can-00000001','FRM-00000002','dsamaddar'
alter proc spInsertCandidateFormTest
@CandidateID nvarchar(50),
@FormID nvarchar(50),
@AssignedBy nvarchar(50)
as
begin

	Declare @CanFormTestID nvarchar(50)
	Declare @CurrentCanFormTestID numeric(18,0)
	Declare @CanFormTestIDPrefix as nvarchar(3)

	Declare @FTRollID nvarchar(50)
	Declare @CurrentFTRollID  numeric(18,0)
	Declare @FTRollIDPrefix as nvarchar(2)

	set @CanFormTestIDPrefix='FT-'
	Set @FTRollIDPrefix = 'FT'

	if exists (Select * from tblCandidateFormTest Where CandidateID=@CandidateID And FormID=@FormID And IsActive=1)
	begin
		return;
	end

begin tran
	

	select @CurrentCanFormTestID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentCanFormTestID'
	
	set @CurrentCanFormTestID=isnull(@CurrentCanFormTestID,0)+1
	Select @CanFormTestID=dbo.generateID(@CanFormTestIDPrefix,@CurrentCanFormTestID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	select @CurrentFTRollID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentFTRollID'
	set @CurrentFTRollID=isnull(@CurrentFTRollID,0)+1
	Select @FTRollID=dbo.generateID(@FTRollIDPrefix,@CurrentFTRollID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
	
	Declare @Duration int Set @Duration = 0
	SElect @Duration=Duration from tblFormList Where FormID = @FormID

	Insert into tblCandidateFormTest(CanFormTestID,CandidateID,FormID,ExamRollNo,Duration,AssignedBy)
	Values(@CanFormTestID,@CandidateID,@FormID,@FTRollID,@Duration,@AssignedBy)
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentCanFormTestID where PropertyName='CurrentCanFormTestID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentFTRollID where PropertyName='CurrentFTRollID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Declare @CanMessage as nvarchar(300) Set @CanMessage = ''
	Declare @FormName as nvarchar(100) Set @FormName = ''
	Select @FormName=FormTitle from tblFormList Where FormID = @FormID
	Set @CanMessage = 'Dear candidate you have been assigned a form input test ('+ @FormName +'). Use roll no ( ' + isnull(@FTRollID,'N\A') + ' ). You Are Requested To Follow Instructions And Take The Exam.'
		
	exec spInsertUserMessage @CandidateID,@CanMessage,'UFL-HR'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO
