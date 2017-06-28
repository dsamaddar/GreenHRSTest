
Insert into tblAppSettings(PropertyName,PropertyValue)Values('CurrentCanFormTestValueID','0')

GO

Select * from tblCandidateFormTestValues

GO
-- drop table tblCandidateFormTestValues
Create table tblCandidateFormTestValues(
CanFormTestValueID nvarchar(50) primary key,
CanFormTestID nvarchar(50) foreign key references tblCandidateFormTest(CanFormTestID),
ActualValue nvarchar(200),
ComparedValue nvarchar(200),
Accuracy numeric(5,2),
EntryDate datetime default getdate()
);

GO

alter proc spInsertCanFormTestValues
@CanFormTestID nvarchar(50),
@FormTestValueString nvarchar(4000)
as
begin
	
	Declare @CanFormTestValueID as nvarchar(50)
	Declare @CurrentCanFormTestValueID numeric(18,0)
	Declare @CanFormTestValueIDPrefix as nvarchar(5)
	Set @CanFormTestValueIDPrefix = 'CFTV-'

	Declare @Index as int
	Declare @CurrentCFTVData as nvarchar(4000)
	Declare @RestCFTVData as nvarchar(4000)
	Declare @RestPortion as nvarchar(4000)

	Declare @ActualValue as nvarchar(200) Set @ActualValue = ''
	Declare @ComparedValue as nvarchar(200) Set @ComparedValue = ''

begin tran

	Declare @EntryPoint As nvarchar(50) Set @EntryPoint = ''
	Select @EntryPoint = dbo.fnGetEntryPoint()
		
	select @CurrentCanFormTestValueID = cast(PropertyValue as numeric(18,0)) from tblAppSettings where  PropertyName='CurrentCanFormTestValueID'
	
	set @CurrentCanFormTestValueID=isnull(@CurrentCanFormTestValueID,0)+1
	Select @CanFormTestValueID=dbo.generateID(@CanFormTestValueIDPrefix,@CurrentCanFormTestValueID,8)		
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

	set @RestCFTVData=@FormTestValueString
	while @RestCFTVData<>''
	begin
		set @Index=CHARINDEX('|',@RestCFTVData)
		set @CurrentCFTVData=substring(@RestCFTVData,1,@Index-1)
		set @RestCFTVData=substring(@RestCFTVData,@Index+1,len(@RestCFTVData))		
		
		set @RestPortion=@CurrentCFTVData
		
		set @Index=CHARINDEX('~',@RestPortion)		
		set @ActualValue=substring(@RestPortion,1,@Index-1)
		set @RestPortion=substring(@RestPortion,@Index+1,len(@RestPortion))
		
		set @Index=CHARINDEX('~',@RestPortion)		
		set @ComparedValue=substring(@RestPortion,1,@Index-1)
		set @RestPortion=substring(@RestPortion,@Index+1,len(@RestPortion))	
		
		Insert into tblCandidateFormTestValues(CanFormTestValueID,CanFormTestID,ActualValue,ComparedValue,Accuracy)
		Values(@CanFormTestValueID,@CanFormTestID,@ActualValue,@ComparedValue,0)
		IF (@@ERROR <> 0) GOTO ERR_HANDLER

		set @CurrentCanFormTestValueID=isnull(@CurrentCanFormTestValueID,0)+1
		Select @CanFormTestValueID=dbo.generateID(@CanFormTestValueIDPrefix,@CurrentCanFormTestValueID,8)
		
		Set @ActualValue = ''
		Set @ComparedValue = ''
	end
	
	update tblAppSettings set PropertyValue=@CurrentCanFormTestValueID where PropertyName='CurrentCanFormTestValueID'
	IF (@@ERROR <> 0) GOTO ERR_HANDLER

COMMIT TRAN
RETURN 0

ERR_HANDLER:
ROLLBACK TRAN
RETURN 1
end

-- exec spInsertCanFormTestValues 'FT-00000001','Debayan Samaddar~Debayan Samaddar~|Sukumar Samaddar~Sukumar Samaddar~|Deepa Samaddar~Deepa Samaddar~|F. Mazumder~F. Mazumder~|11/22/1986~11/22/1986~|Male~Male~|129722597628~129722597628~|Natioanal ID~Natioanal ID~|2699038634813~2699038634813~|N.H.B-16, New Colony, Lalmatia~N.H.B-16, New Colony~|Vill-Kullia, Post-Amuria, Thana-Magura~Vill-Kullia, Post-Amuria, Thana-Magura~|~~|+8801730725697~01730725697~|DEBUMIST@GMAIL.COM~debumist@gmail.com~|Service~Service~|6~6~|UNITED FINANCE LIMITED~United Finance Limited~|Business~Business~|Deposit, Sonchoya, Lease-Loan, Factoring~Deposit, Sonchoya, Lease-Loan~|Camellia House, 22 Kazi Nazrul Islam Avenue, Dhaka 1000, Bangladesh~Camellia House, 22 Kazi Nazrul Islam Avenue~|+88029669006~~|+88029662596~9669006~|Career@unitedfinance.com.bd~career@unitedfinance.com.bd~|Married~Single~|04/16/2015~~|Living with parents~Living with parents~|Rented house~Rented house~|2~~|30,000 - 50,000~30,000 - 50,000~|Recommended By Family/Friend~Recommended By Family/Friend~|'
