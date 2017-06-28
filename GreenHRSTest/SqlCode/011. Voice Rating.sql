
-- drop table tblVoiceRater
Create table tblVoiceRater(
SLNO int identity(1,1) primary key,
EmployeeID nvarchar(50) unique(EmployeeID) foreign key references tblEmployeeInfo(EmployeeID) ,
EntryBy nvarchar(50),
EntryDate datetime default getdate()
);

GO

Create proc spInserVoiceRater
@EmployeeID nvarchar(50),
@EntryBy nvarchar(50)
as
begin
	Insert into tblVoiceRater(EmployeeID,EntryBy)
	Values(@EmployeeID,@EntryBy)
end

GO

exec spInserVoiceRater 'EMP-00000006','dsamaddar'
exec spInserVoiceRater 'EMP-00000024','dsamaddar'
exec spInserVoiceRater 'EMP-00000037','dsamaddar'

GO

Create proc spDelVoiceRater
@EmployeeID nvarchar(50)
as
begin
	Delete from tblVoiceRater Where EmployeeID = @EmployeeID
end

GO

alter proc spGetVoiceRaterList
as
begin
	Select VR.SLNO,VR.EmployeeID,UPPER(EI.EmployeeName) as 'EmployeeName' 
	from tblVoiceRater VR INNER JOIN tblEmployeeInfo EI 
	ON VR.EmployeeID = EI.EmployeeID
end

-- exec spGetVoiceRaterList

GO


GO

Insert into tblAppSettings(PropertyName,PropertyValue)Values('CurrentVoiceRatingID',0)

-- drop table tblVoiceRating
Create table tblVoiceRating(
VoiceRatingID nvarchar(50) primary key,
VoiceID nvarchar(50) foreign key references tblVoiceCapture(VoiceID),
EmployeeID nvarchar(50) foreign key references tblEmployeeInfo(EmployeeID),
IsRatingDone bit default 0,
Rating int default 0,
RatingDate datetime,
EntryDate datetime default getdate()
);

GO

Create function fnGetAvgVoiceRating(@VoiceID nvarchar(50))
returns numeric(5,2)
as
begin
	Declare @Rating as numeric(5,2) Set @Rating = 0
	Select @Rating = AVG(Rating) from tblVoiceRating Where VoiceID = @VoiceID

	return @Rating;
end

GO

Create proc spInsertMultipleVoiceRating
@VoiceID nvarchar(50)
as
begin

	Declare @RaterTbl table(
	EmployeeID nvarchar(50),
	Taken bit default 0
	);

begin tran

	Insert into @RaterTbl(EmployeeID)
	Select EmployeeID from tblVoiceRater

	Declare @EmployeeID as nvarchar(50) Set @EmployeeID = ''
	Declare @NCount as int Set @NCount = 0
	Declare @Count as int Set @Count = 1

	Select @NCount = Count(*) from @RaterTbl

	While @Count <= @NCount
	begin
		Select top 1 @EmployeeID=EmployeeID from @RaterTbl Where Taken = 0

		exec spInsertVoiceRating @VoiceID,@EmployeeID
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		Update @RaterTbl Set Taken=1 Where EmployeeID = @EmployeeID
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		Set @EmployeeID = ''
		Set @Count = @Count + 1
	end

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO

Create proc spInsertVoiceRating
@VoiceID nvarchar(50),
@EmployeeID nvarchar(50)
as
begin

	Declare @VoiceRatingID as nvarchar(50)
	Declare @CurrentVoiceRatingID numeric(18,0)
	Declare @VoiceRatingIDPrefix as nvarchar(3)
	
	set @VoiceRatingIDPrefix='VR-'

begin tran

	select @CurrentVoiceRatingID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentVoiceRatingID'
			
	set @CurrentVoiceRatingID=isnull(@CurrentVoiceRatingID,0)+1
	Select @VoiceRatingID=dbo.generateID(@VoiceRatingIDPrefix,@CurrentVoiceRatingID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Insert into tblVoiceRating(VoiceRatingID,VoiceID,EmployeeID)
	Values(@VoiceRatingID,@VoiceID,@EmployeeID)

	update tblAppSettings set PropertyValue=@CurrentVoiceRatingID where PropertyName='CurrentVoiceRatingID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

GO

Select * from tblVoiceRating

GO

alter proc spGetVoiceListToRate
@EmployeeID nvarchar(50)
as
begin
	Select VR.VoiceRatingID,CB.CandidateName,VC.VoiceFile from tblVoiceRating VR INNER JOIN tblVoiceCapture VC ON VR.VoiceID = VC.VoiceID
	INNER JOIN tblCandidateBasicInfo CB ON VC.CandidateID = CB.CandidateID
	Where VR.EmployeeID = @EmployeeID And VR.IsRatingDone = 0
end

-- exec spGetVoiceListToRate 'EMP-00000006'

GO

alter proc spRateVoice
@VoiceRatingID nvarchar(50),
@Rating int
as
begin
	Update tblVoiceRating Set Rating = @Rating,IsRatingDone=1,RatingDate=Getdate() Where VoiceRatingID = @VoiceRatingID
end

GO

-- drop table tblVoiceGrading
Create table tblVoiceGrading(
SLNO int identity(1,1) primary key,
Grading int unique(Grading),
Explanation nvarchar(50)
);

GO

alter proc spInsertVoiceGrading
@Grading int,
@Explanation nvarchar(50)
as
begin
	Insert into tblVoiceGrading(Grading,Explanation)
	Values(@Grading,@Explanation)
end

GO

alter proc spUpdateVoiceGrading
@SLNO int,
@Grading int,
@Explanation nvarchar(50)
as
begin
	Update tblVoiceGrading Set Grading = @Grading , Explanation = @Explanation
	Where SLNO=@SLNO
end

GO

Create proc spGetVoiceGradingList
as
begin
	Select Convert(nvarchar, Grading) + '-' + Explanation as 'Grade',Grading from tblVoiceGrading
	order by Grade
end

GO

Create proc spGetVoiceGradingAll
as
begin
	Select SLNO,Grading,Explanation from tblVoiceGrading
end

GO

Select * from tblVoiceCapture
Select * from tblVoiceRating

GO

alter proc spGetPendingVoiceRating
as
begin
	Select VC.VoiceID,VC.CandidateID,CB.CandidateName,VC.VoiceFile,VC.Rating,dbo.fnGetPendingVoiceRater(VC.VoiceID) as 'PendingAt' 
	from tblVoiceCapture VC INNER JOIN tblCandidateBasicInfo CB ON VC.CandidateID = CB.CandidateID
	Where dbo.fnGetPendingVoiceRater(VoiceID) <> ''
end

-- exec spGetPendingVoiceRating

GO

alter function fnGetPendingVoiceRater(@VoiceID nvarchar(50))
returns nvarchar(500)
as
begin
	Declare @PendingListRater as nvarchar(500) Set @PendingListRater = ''
	Select @PendingListRater= @PendingListRater + EI.EmployeeName+' | ' from tblVoiceRating VR 
	INNER JOIN tblEmployeeInfo EI ON VR.EmployeeID = EI.EmployeeID
	Where VoiceID=@VoiceID And VR.IsRatingDone=0
	
	return ISNULL(@PendingListRater,'')
end

select dbo.fnGetPendingVoiceRater('V-00000030')

