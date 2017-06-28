

Insert Into tblAppSettings(PropertyName,PropertyValue)Values('CurrentTypingTestID','0')
Insert Into tblAppSettings(PropertyName,PropertyValue)Values('CurrentTTRollID','0')

GO

-- drop table tblTypingTest
Create table tblTypingTest(
TypingTestID nvarchar(50) primary key,
CandidateID nvarchar(50) foreign key references tblCandidateBasicInfo(CandidateID),
StoryID nvarchar(50) foreign key references tblStory(StoryID),
ExamRollNo nvarchar(50) Unique(ExamRollNo),
Story nvarchar(4000),
Response nvarchar(4000),
Duration int default 0,
WPM int default 0,
Accuracy int default 0,
Grade int default 0,
StartTime datetime,
EndTime datetime,
IsActive bit default 1,
AssignedBy nvarchar(50),
AssignedOn datetime default getdate()
);

-- Select * from tblTypingTest

GO

alter proc spGetTypingTestScore
@CandidateID nvarchar(50)
as
begin
	Select TypingTestID,S.StoryTopic,ExamRollNo,TT.Duration,WPM,Accuracy,Grade,StartTime from tblTypingTest TT
	INNER JOIN tblStory S ON TT.StoryID = S.StoryID
	Where CandidateID=@CandidateID
end

-- exec spGetTypingTestScore  'Can-00000001'

GO

alter proc spGetAssignedStoryByCandidate
@CandidateID nvarchar(50)
as
begin
	Select TT.TypingTestID,S.StoryTopic 
	from tblTypingTest TT INNER JOIN tblStory S ON TT.StoryID = S.StoryID
	Where CandidateID = @CandidateID And TT.IsActive=1
	order by S.StoryTopic
end

-- exec spGetAssignedStoryByCandidate 'Can-00000001'

GO

alter proc spStartTTExam
@TypingTestID nvarchar(50),
@ExamRollNo nvarchar(50)
as
begin
	
	Declare @Story as nvarchar(4000) Set @Story = ''
	Declare @Duration as int Set @Duration = 0
	If exists (Select * from tblTypingTest Where TypingTestID = @TypingTestID And ExamRollNo=@ExamRollNo)
	begin
		Update tblTypingTest Set StartTime = GETDATE(),IsActive=0 Where TypingTestID = @TypingTestID
		Select @Story=Story,@Duration=Duration from tblTypingTest Where TypingTestID = @TypingTestID
	end
	
	Select ISNULL(@Story,'') as 'Story',@Duration as 'Duration'
end

GO

alter proc spStopTTExam
@TypingTestID nvarchar(50),
@Response nvarchar(4000)
as
begin
	Update tblTypingTest Set Response = @Response,EndTime = GETDATE() Where TypingTestID = @TypingTestID

	Update tblTypingTest Set WPM=dbo.fnGetTypingWPM(TypingTestID),Accuracy = dbo.fnGetTypingAccuracy(TypingTestID) 
	Where TypingTestID = @TypingTestID

	Update tblTypingTest Set Grade = dbo.fnGetTypingScore(Accuracy,WPM) Where TypingTestID = @TypingTestID

	Select WPM,Accuracy,Grade, 1 as Success From tblTypingTest Where TypingTestID = @TypingTestID

end



GO

Select * from tblCandidateBasicInfo
Select * from tblStory
Select * from tblTypingTest

GO

-- exec spInsertTypingTest 'Can-00000001','ST-00000003','dsamaddar'
alter proc spInsertTypingTest
@CandidateID nvarchar(50),
@StoryID nvarchar(50),
@AssignedBy nvarchar(50)
as
begin
	Declare @TypingTestID nvarchar(50)
	Declare @CurrentTypingTestID numeric(18,0)
	Declare @TypingTestIDPrefix as nvarchar(3)

	Declare @TTRollID nvarchar(50)
	Declare @CurrentTTRollID  numeric(18,0)
	Declare @TTRollIDPrefix as nvarchar(2)

	Declare @Story nvarchar(4000) Set @Story = ''
	Declare @Duration as int Set @Duration = 0

	set @TypingTestIDPrefix='TT-'
	Set @TTRollIDPrefix = 'TT'

	if exists (Select * from tblTypingTest Where CandidateID=@CandidateID And StoryID=@StoryID And IsActive=1)
	begin
		return;
	end

begin tran

	select @CurrentTypingTestID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentTypingTestID'
	
	set @CurrentTypingTestID=isnull(@CurrentTypingTestID,0)+1
	Select @TypingTestID=dbo.generateID(@TypingTestIDPrefix,@CurrentTypingTestID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	select @CurrentTTRollID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentTTRollID'
	set @CurrentTTRollID=isnull(@CurrentTTRollID,0)+1
	Select @TTRollID=dbo.generateID(@TTRollIDPrefix,@CurrentTTRollID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER
	
	Select @Story=REPLACE(Story,'’',''''),@Duration=Duration from tblStory Where StoryID = @StoryID

	Insert Into tblTypingTest(TypingTestID,CandidateID,StoryID,ExamRollNo,Story,Response,Duration,AssignedBy)
	Values(@TypingTestID,@CandidateID,@StoryID,@TTRollID,@Story,'',@Duration,@AssignedBy)
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentTypingTestID where PropertyName='CurrentTypingTestID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentTTRollID where PropertyName='CurrentTTRollID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Declare @CanMessage as nvarchar(300) Set @CanMessage = ''
	Set @CanMessage = 'Dear candidate you have been assigned a typing test. Use roll no ( ' + isnull(@TTRollID,'N\A') + ' ). You Are Requested To Follow Instructions And Take The Exam.'
		
	exec spInsertUserMessage @CandidateID,@CanMessage,'UFL-HR'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO

alter function fnGetTypingWPM(@TypingTestID nvarchar(50))
returns int
as
begin
	
	Declare @WPM as int Set @WPM = 0
	Declare @Duration as int Set @Duration = 0
	Declare @Response as nvarchar(4000) Set @Response = 0
	Select @Response=Response,@Duration=Duration from tblTypingTest Where TypingTestID=@TypingTestID

	Select @WPM = Count(Value) from dbo.Split(' ',@Response)

	return (@WPM/@Duration)
end

-- Select dbo.fnGetTypingWPM('TT-00000034')

GO

alter function fnGetTypingAccuracy(@TypingTestID nvarchar(50))
returns numeric(5,2)
as
begin
	
	Declare @Story as nvarchar(4000) Set @Story = ''
	Declare @Response as nvarchar(4000) Set @Response = ''
	Declare @Count as int Set @Count = 1
	Declare @NCount as int Set @NCount = 0
	Declare @mCount as int Set @mCount = 1
	Declare @mNCount as int Set @mNCount = 0

	Declare @StoryTbl table(
	mSLNo int identity(1,1),
	StoryWord nvarchar(200),
	Taken bit default 0
	);

	Declare @ResponseTbl table(
	SLNO int identity(1,1),
	ResponseWord nvarchar(200),
	Score numeric(5,2) default 0,
	Taken bit default 0
	);

	Select @Story=REPLACE(Story,'''','’'),@Response=REPLACE(Response,'''','’') from tblTypingTest Where TypingTestID=@TypingTestID

	Set @Story = RTRIM( LTRIM( REPLACE(REPLACE(@Story, CHAR(13), ' '), CHAR(10), ' ')))
	Set @Response = RTRIM( LTRIM( REPLACE(REPLACE(@Response, CHAR(13), ' '), CHAR(10), ' ')))

	Insert into @StoryTbl(StoryWord) Select Value from dbo.Split(' ', @Story) Where Value <> ' '
	Insert into @ResponseTbl(ResponseWord) Select Value from dbo.Split(' ',@Response) Where Value <> ' '

	Select @NCount = Count(*) from @ResponseTbl
	Select @mNCount = Count(*) from @StoryTbl

	Declare @SLNO as int Set @SLNO = 0
	Declare @mSLNo as int Set @mSLNo = 0
	Declare @ResponseWord as nvarchar(200) Set @ResponseWord = ''
	Declare @StoryWord as nvarchar(200) Set @StoryWord = ''
	Declare @Score as numeric(5,2) Set @Score = 0
	Declare @Distance as int Set @Distance = 0

	While @Count <= @NCount
	begin

		Select top 1 @ResponseWord=ResponseWord,@SLNO=SLNO from @ResponseTbl Where Taken = 0
		Set @mCount = 1
		Set @Score = LEN(@ResponseWord)
		While @mCount <= @mNCount
		begin
			Select top 1 @StoryWord=StoryWord,@mSLNo=mSLNo from @StoryTbl Where Taken = 0

			Set @Distance = dbo.edit_distance(@ResponseWord,@StoryWord)

			if @Score > @Distance
				Set @Score = @Distance

			Update @StoryTbl Set Taken = 1 Where mSLNo = @mSLNo
			Set @mCount = @mCount + 1
			Set @Distance = 0
		end

		Set @Score = (LEN(@StoryWord) - @Score)/ (LEN(@StoryWord))*100
		
		Update @ResponseTbl Set Taken = 1,Score = @Score Where SLNO = @SLNO
		Set @Count = @Count + 1

		Update @StoryTbl Set Taken =0
	end

	Declare @N as numeric(5,2) Set @N = @NCount
	Declare @M as numeric(5,2) Set @M = @mNCount
	Declare @AvgScore as numeric(5,2) Set @AvgScore = 0
	Declare @FinalScore as numeric(5,2) Set @FinalScore = 0
	Select @AvgScore = AVG(Score) from @ResponseTbl
	Set @FinalScore = (@N/@M)* @AvgScore

	return @FinalScore;
end

-- Select dbo.fnGetTypingAccuracy('TT-00000034')

-- Declare @TypingTestID as nvarchar(50) Set @TypingTestID = 'TT-00000034'

GO


















GO

/* Matching Algorithm*/

Select dbo.edit_distance('Debayan','monir')

GO

CREATE FUNCTION dbo.edit_distance(
  @s1 nvarchar(3999),
  @s2 nvarchar(3999))
RETURNS int
AS
BEGIN
  DECLARE @s1_len int, @s2_len int
  DECLARE @i int, @j int, @s1_char nchar, @c int, @c_temp int
  DECLARE @cv0 varbinary(8000), @cv1 varbinary(8000)
  SELECT
    @s1_len = LEN(@s1),
    @s2_len = LEN(@s2),
    @cv1 = 0x0000,
    @j = 1, @i = 1, @c = 0
 
  WHILE @j <= @s2_len
    SELECT @cv1 = @cv1 + CAST(@j AS binary(2)), @j = @j + 1
  WHILE @i <= @s1_len
 
  BEGIN
    SELECT
      @s1_char = SUBSTRING(@s1, @i, 1),
      @c = @i,
      @cv0 = CAST(@i AS binary(2)),
      @j = 1
 
    WHILE @j <= @s2_len
    BEGIN
      SET @c = @c + 1
      SET @c_temp = CAST(SUBSTRING(@cv1, @j+@j-1, 2) AS int) +
        CASE WHEN @s1_char = SUBSTRING(@s2, @j, 1) THEN 0 ELSE 1 END
      IF @c > @c_temp SET @c = @c_temp
      SET @c_temp = CAST(SUBSTRING(@cv1, @j+@j+1, 2) AS int)+1
      IF @c > @c_temp SET @c = @c_temp
      SELECT @cv0 = @cv0 + CAST(@c AS binary(2)), @j = @j + 1
    END
    SELECT
      @cv1 = @cv0,
      @i = @i + 1
  END
 
  RETURN @c
END