
Insert Into tblAppSettings(PropertyName,PropertyValue)Values('CurrentStoryID','0')

GO

-- drop table tblStory
Create table tblStory(
StoryID nvarchar(50) primary key,
StoryTopic nvarchar(200),
Story nvarchar(4000),
Duration int default 0,
EntryBy nvarchar(50),
EntryDate datetime default Getdate()
);

GO

-- exec spGetStoryList

alter proc spGetStoryList
as
begin
	Select StoryID,StoryTopic,Story,Duration from tblStory
	order by StoryTopic 
end

GO

Create proc spGetStoryByID
@StoryID nvarchar(50)
as
begin
	Select StoryTopic,Story from tblStory Where StoryID=@StoryID
end

GO

alter proc spInsertStory
@StoryTopic nvarchar(200),
@Story nvarchar(4000),
@Duration int,
@EntryBy nvarchar(50)
as
begin

	Declare @StoryID nvarchar(50)
	Declare @CurrentStoryID numeric(18,0)
	Declare @StoryIDPrefix as nvarchar(3)

	set @StoryIDPrefix='ST-'

begin tran

	select @CurrentStoryID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentStoryID'
	
	set @CurrentStoryID=isnull(@CurrentStoryID,0)+1
	Select @StoryID=dbo.generateID(@StoryIDPrefix,@CurrentStoryID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	Insert into tblStory(StoryID,StoryTopic,Story,Duration,EntryBy)Values(@StoryID,@StoryTopic,@Story,@Duration,@EntryBy)
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	update tblAppSettings set PropertyValue=@CurrentStoryID where PropertyName='CurrentStoryID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

exec spInsertStory 'Zimbabwe choose to field after winning toss in 2nd ODI against Bangladesh',

'Zimbabwe have won the toss and chosen to field in the second ODI against Bangladesh.The teams for both sides have made one change each. Imrul Kayes replaces Shakib Al Hasan while Zimbabwe’s Regis Chakabva is in for Richmond Mutumbami, who was injured in the previous match.

The squads 

Bangladesh Tamim Iqbal, Imrul Kayes, Liton Das, Mahmudullah, Mushfiqur Rahim, Sabbir Rahman, Nasir Hossain, Mashrafe Mortaza (C), Arafat Sunny, Al-Amin Hossain, Mustafizur Rahman.

Zimbabwe CJ Chibhabha, RW Chakabva, CR Ervine, SC Williams, E Chigumbura (C), Sikandar Raza, MN Waller, LM  Jongwe, AG Cremer, T Panyangara, T Muzarabani.',2, 'dsamaddar'

GO

Select * from tblStory

GO

exec spInsertStory 'Freedom to speak, freedom to offend',

'Many people believe that 2013 was one of the greatest years in the history of Bangladesh. In February that year,
 people spontaneously came together to voice their demands for proper justice of war criminals, making it very 
 clear that at least on this issue there is room for neither compromise nor leniency. Of course the consensus 
 was not 100%, but it was heartening to see that a significant portion of our youth were invested in these issues 
 and would step out in the streets to demand for justice.

Ironically, it was also in 2013 that the seeds of a terrible darkness were first sowed with the murder of freethinking writer Rajib Haider. Soon after his brutal murder, everyone began to focus on the content of his blogs and how he rejected religion. Somehow, his personal opinions began to be associated with the general beliefs of all those who demanded trial for war criminals, doing severe damage to popular support for the movement.',2,'dsamaddar'

GO

Create proc spUpdateStory
@StoryID nvarchar(50),
@StoryTopic nvarchar(200),
@Story nvarchar(4000),
@Duration int,
@EntryBy nvarchar(50)
as
begin

begin tran

	Update tblStory Set StoryTopic = @StoryTopic, Story= @Story,Duration=@Duration
	Where StoryID = @StoryID

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end