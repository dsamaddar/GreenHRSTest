
select * from tblPersonalInfo

GO
-- drop table tblPersonalInfo
Create table tblPersonalInfo(
SLNO int identity(1,1) primary key,
IndName nvarchar(50) default '',
FathersName nvarchar(50) default '',
MothersName nvarchar(50) default '',
SpouseName nvarchar(50) default '',
DateOfBirth nvarchar(20) default '',
Gender nvarchar(10) default '',
eTin nvarchar(50) default '',
TypeOfID nvarchar(50) default '',
IDNo nvarchar(50) default '',
PresentAddress nvarchar(200) default '',
PermanentAddress nvarchar(200) default '',
Telephone nvarchar(50) default '',
Mobile nvarchar(50) default '',
Email nvarchar(50) default '',
NatureOfOccupation nvarchar(50) default '',
NatOfOccForYears nvarchar(50) default '',
OrgName nvarchar(50) default '',
BusinessActivity nvarchar(50) default '',
BusinessActDetails nvarchar(50) default '',
WorkAddress nvarchar(200) default '',
WorkTelephone nvarchar(50) default '',
WorkFax nvarchar(50) default '',
WorkEmail nvarchar(50) default '',
MaritalStatus nvarchar(50) default '',
MarriageAnniversary nvarchar(50) default '',
LivingPattern nvarchar(50) default '',
LivingIn nvarchar(50) default '',
NumEarningMem nvarchar(50) default '',
GrossFamilyIncome nvarchar(50) default '',
ReasonForChoosing nvarchar(50) default ''
);

Insert Into tblPersonalInfo(IndName,
FathersName,MothersName,SpouseName,DateOfBirth,Gender,eTin,TypeOfID,IDNo,
PresentAddress,PermanentAddress,Telephone,Mobile,Email,
NatureOfOccupation,NatOfOccForYears,OrgName,BusinessActivity,BusinessActDetails,
WorkAddress,WorkTelephone,WorkFax,WorkEmail,
MaritalStatus,MarriageAnniversary,LivingPattern,LivingIn,NumEarningMem,GrossFamilyIncome,ReasonForChoosing)
Values('Debayan Samaddar','Sukumar Samaddar','Deepa Samaddar','F. Mazumder','11/22/1986','Male','129722597628','Natioanal ID','2699038634813',
'N.H.B-16, New Colony, Lalmatia','Vill-Kullia, Post-Amuria, Thana-Magura','+88029669006','+8801730725697','DEBUMIST@GMAIL.COM',
'Service','6','UNITED FINANCE LIMITED','Business','Deposit, Sonchoya, Lease-Loan, Factoring',
'Camellia House, 22 Kazi Nazrul Islam Avenue, Dhaka 1000, Bangladesh','+88029669006','+88029662596','Career@unitedfinance.com.bd',
'Married','04/16/2015','Living with parents','Rented house','2','30,000 - 50,000','Recommended By Family/Friend'
)

GO

Create proc spGetAcutalPerInfoValues
as
begin
	Select IndName,
	FathersName,MothersName,SpouseName,DateOfBirth,Gender,eTin,TypeOfID,IDNo,
	PresentAddress,PermanentAddress,Telephone,Mobile,Email,
	NatureOfOccupation,NatOfOccForYears,OrgName,BusinessActivity,BusinessActDetails,
	WorkAddress,WorkTelephone,WorkFax,WorkEmail,
	MaritalStatus,MarriageAnniversary,LivingPattern,LivingIn,NumEarningMem,GrossFamilyIncome,ReasonForChoosing
	from tblPersonalInfo
end