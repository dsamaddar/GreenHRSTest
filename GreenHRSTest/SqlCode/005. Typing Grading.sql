
-- drop table tblTypingGrading
Create table tblTypingGrading(
SLNO int identity(1,1) primary key,
AccuracyFrom int default 0,
AccuracyTo int default 0,
WPMFrom int default 0,
WPMTo int default 0,
Grade int default 0,
EntryBy nvarchar(50),
EntryDate datetime default getdate()
);

-- Select * from tblTypingGrading

GO

Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(80,100,40,200,5,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(80,100,31,40,4,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(80,100,21,30,3,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(80,100,11,20,2,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(80,100,0,10,1,'dsamaddar')

Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(60,79,40,200,4,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(60,79,31,40,3,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(60,79,21,30,2,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(60,79,11,20,1,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(60,79,0,10,0,'dsamaddar')

Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(50,59,40,200,3,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(50,59,31,40,2,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(50,59,21,30,1,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(50,59,11,20,0,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(50,59,0,10,0,'dsamaddar')

Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(0,49,40,200,2,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(0,49,31,40,1,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(0,49,21,30,0,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(0,49,11,20,0,'dsamaddar')
Insert into tblTypingGrading(AccuracyFrom,AccuracyTo,WPMFrom,WPMTo,Grade,EntryBy)
Values(0,49,0,10,0,'dsamaddar')

GO

alter function fnGetTypingScore(@Accuracy numeric(5,2),@WPM int)
returns int
as
begin
	Declare @Grade as int Set @Grade = 0
	Select @Grade=Grade from tblTypingGrading Where (@Accuracy >= AccuracyFrom And @Accuracy <= AccuracyTo)
	And (@WPM >= WPMFrom And @WPM <= WPMTo)

	return @Grade
end

Select dbo.fnGetTypingScore(74,35)