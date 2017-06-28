
Insert into tblAppSettings(PropertyName,PropertyValue)Values('CurrentVoiceTestID','0')
Insert into tblAppSettings(PropertyName,PropertyValue)Values('CurrentVTRollID','0')


GO

Create table tblVoiceTest(
VoiceTestID nvarchar(50) primary key,
CandidateID nvarchar(50) foreign key references tblCandidateBasicInfo(CandidateID),
StoryID nvarchar(50) foreign key references tblStory(StoryID),
ExamRollNo nvarchar(50) Unique(ExamRollNo),
Story nvarchar(4000),
StartTime datetime,
EndTime datetime,
IsActive bit default 1,
AssignedBy nvarchar(50),
AssignedOn datetime default getdate()
);

Select * from tblVoiceTest

GO

Create proc spInsertVoiceTest
@CandidateID nvarchar(50),
@StoryID nvarchar(50),
@AssignedBy nvarchar(50)
as
begin
	Declare @VoiceTestID nvarchar(50)
	Declare @CurrentVoiceTestID numeric(18,0)
	Declare @VoiceTestIDPrefix as nvarchar(3)

	Declare @VTRollID nvarchar(50)
	Declare @CurrentVTRollID  numeric(18,0)
	Declare @VTRollIDPrefix as nvarchar(2)

	Declare @Story nvarchar(4000) Set @Story = ''
	Declare @Duration as int Set @Duration = 0

	set @VoiceTestIDPrefix='VT-'
	Set @VTRollIDPrefix = 'VT'

	if exists (Select * from tblVoiceTest Where CandidateID=@CandidateID And StoryID=@StoryID And IsActive=1)
	begin
		return;
	end

begin tran

	select @CurrentVoiceTestID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentVoiceTestID'
	
	set @CurrentVoiceTestID=isnull(@CurrentVoiceTestID,0)+1
	Select @VoiceTestID=dbo.generateID(@VoiceTestIDPrefix,@CurrentVoiceTestID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	select @CurrentVTRollID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentVTRollID'
	set @CurrentVTRollID=isnull(@CurrentVTRollID,0)+1
	Select @VTRollID=dbo.generateID(@VTRollIDPrefix,@CurrentVTRollID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
	
	Select @Story=REPLACE(Story,'’',''''),@Duration=Duration from tblStory Where StoryID = @StoryID

	Insert Into tblVoiceTest(VoiceTestID,CandidateID,StoryID,ExamRollNo,Story,AssignedBy)
	Values(@VoiceTestID,@CandidateID,@StoryID,@VTRollID,@Story,@AssignedBy)
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentVoiceTestID where PropertyName='CurrentVoiceTestID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentVTRollID where PropertyName='CurrentVTRollID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Declare @CanMessage as nvarchar(300) Set @CanMessage = ''
	Set @CanMessage = 'Dear candidate you have been assigned a Voice test. Use roll no ( ' + isnull(@VTRollID,'N\A') + ' ). You Are Requested To Follow Instructions And Take The Exam.'
		
	exec spInsertUserMessage @CandidateID,@CanMessage,'UFL-HR'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO

Create proc spStartVTExam
@VoiceTestID nvarchar(50),
@ExamRollNo nvarchar(50)
as
begin
	
	Declare @Story as nvarchar(4000) Set @Story = ''
	Declare @Duration as int Set @Duration = 0
	If exists (Select * from tblVoiceTest Where VoiceTestID = @VoiceTestID And ExamRollNo=@ExamRollNo)
	begin
		Update tblVoiceTest Set StartTime = GETDATE(),IsActive=0 Where VoiceTestID = @VoiceTestID
		Select @Story=Story from tblVoiceTest Where VoiceTestID = @VoiceTestID
	end
	
	Select ISNULL(@Story,'') as 'Story'
end

GO

Create proc spStopVTExam
@VoiceTestID nvarchar(50)
as
begin
	Update tblVoiceTest Set EndTime = GETDATE() Where VoiceTestID = @VoiceTestID
end

GO

Create proc spGetAssignedStoryByCandidateVT
@CandidateID nvarchar(50)
as
begin
	Select VT.VoiceTestID,S.StoryTopic 
	from tblVoiceTest VT INNER JOIN tblStory S ON VT.StoryID = S.StoryID
	Where CandidateID = @CandidateID And VT.IsActive=1
	order by S.StoryTopic
end


GO

Insert into tblAppSettings(PropertyName,PropertyValue)Values('CurrentVoiceID','0')

GO

-- drop table tblVoiceCapture
Create table tblVoiceCapture(
VoiceID nvarchar(50) primary key,
VoiceTestID nvarchar(50) foreign key references tblVoiceTest(VoiceTestID),
CandidateID nvarchar(50) foreign key references tblCandidateBasicInfo(CandidateID),
VoiceFile nvarchar(50),
Rating AS dbo.fnGetAvgVoiceRating(VoiceID),
EntryDate datetime default getdate()
);

GO

Select * from tblVoiceCapture

GO

alter proc spGetVoiceByCandidate
@CandidateID nvarchar(50)
as
begin
	Select VoiceID,VoiceFile,Rating,EntryDate from tblVoiceCapture Where CandidateID = @CandidateID
	order by EntryDate desc
end

GO

alter proc spInsertVoiceCapture
@CandidateID nvarchar(50),
@VoiceTestID nvarchar(50),
@VoiceFile nvarchar(50)
as
begin

	Declare @VoiceID as nvarchar(50)
	Declare @CurrentVoiceID numeric(18,0)
	Declare @VoiceIDPrefix as nvarchar(2)

	set @VoiceIDPrefix='V-'

begin tran
	
	select @CurrentVoiceID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentEmpJDID'
	
	set @CurrentVoiceID=isnull(@CurrentVoiceID,0)+1
	Select @VoiceID=dbo.generateID(@VoiceIDPrefix,@CurrentVoiceID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
		
	Insert into tblVoiceCapture(VoiceID,VoiceTestID,CandidateID,VoiceFile)
	Values(@VoiceID,@VoiceTestID,@CandidateID,@VoiceFile)
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
	
	update tblAppSettings set PropertyValue=@CurrentVoiceID where PropertyName='CurrentEmpJDID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	exec spInsertMultipleVoiceRating @VoiceID
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end