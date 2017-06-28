
-- drop table tblPersonalInfFormAsset
Create table tblPersonalInfFormAsset(
SLNO int identity(1,1) primary key,
OwnerType nvarchar(50),
ApplicationID nvarchar(50),
ApplicantName nvarchar(50),
FathersName nvarchar(50),
FOccupation nvarchar(50),
MothersName nvarchar(50),
Moccupation nvarchar(50),
SpouseName nvarchar(50),
SOccupation nvarchar(50),
DateOfBirth nvarchar(50),
Gender nvarchar(10),
District nvarchar(50),
Country nvarchar(50),
HaveIDCard nvarchar(50),
IDType nvarchar(50),
IDNo nvarchar(50),
Nationality nvarchar(50),
DualCitizenship nvarchar(50),
SecondCountry nvarchar(50),
HaveTin nvarchar(50),
TinNo nvarchar(50),
TelephoneRes nvarchar(50),
Mobile nvarchar(50),
Email nvarchar(50),
PresentAddress nvarchar(200),
PreAddOwnership nvarchar(50),
PreAddOccTenure nvarchar(50),
PreAddAgrPeriod nvarchar(50),
PreAddLandLord nvarchar(50),
PreAddPhoneNo nvarchar(50),
PreAddUtilityBill nvarchar(100),
PersentAddress nvarchar(200),
PerAddOwnership nvarchar(50),
PerAddOccTenure nvarchar(50),
PerAddAgrPeriod nvarchar(50),
PerAddLandLord nvarchar(50),
PerAddPhoneNo nvarchar(50),
PerAddUtilityBill nvarchar(100),
HaveInstDegree nvarchar(100),
LastAttinedDegree nvarchar(50),
PassingYear nvarchar(50),
Institution nvarchar(50),
DoYouEarn nvarchar(50),
EarningType nvarchar(50),
Organization nvarchar(50),
HaveTechnicalExp nvarchar(50),
TechnicalExpertise nvarchar(50),
InvolvedInOtherBusiness nvarchar(50),
OtherBusiness nvarchar(50)
);

GO

Insert into tblPersonalInfFormAsset(
OwnerType,ApplicationID,ApplicantName,FathersName,FOccupation,
MothersName,Moccupation,SpouseName,SOccupation,DateOfBirth,Gender,District,Country,
HaveIDCard,IDType,IDNo,Nationality,DualCitizenship,SecondCountry,
HaveTin,TinNo,TelephoneRes,Mobile,Email,
PresentAddress,PreAddOwnership,
PreAddOccTenure,PreAddAgrPeriod,PreAddLandLord,PreAddPhoneNo,PreAddUtilityBill,
PersentAddress,PerAddOwnership,
PerAddOccTenure,PerAddAgrPeriod,PerAddLandLord,PerAddPhoneNo,PerAddUtilityBill,
HaveInstDegree,LastAttinedDegree,PassingYear,Institution,
DoYouEarn,EarningType,Organization,
HaveTechnicalExp,TechnicalExpertise,
InvolvedInOtherBusiness,OtherBusiness
)
Values(
'PROPRIETOR','1520102745067001','FOZILATUN NESA','LATE - ABDUR RAHMAN MAZUMDER','SERVICE',
'LATE - AMENA BEGUM','HOUSE WIFE','ABDUL MALEK MAZUMDER','SERVICE','01/01/1964','Female','COMILLA','BANGLADESH',
'Yes; 16. If Yes, mention : ','National ID','26936246166054','BANGLADESHI','No','',
'Yes; 22. If Yes, mention your TIN No. : ','784748240883','02-9568153-54','01715244484','FNESA@HOMETEX.COM',
'HOUSE NO. 153/6 FLAT-F-5, SHANTINAGAR, DHAKA-1217','Rented, If Rented, mention the following : ',
'5','10','AZIMUL HAQUE','01865639758','32. Provide copy of Utility Bill (electricity/gas/water), not older than 3 months.',
'N.H.B-23 NEW COLONY LALMATIA','Rented, If Rented, mention the following : ',
'10','15','MD. MAHEDI HASAN','01715647372','39. Provide copy of Utility Bill (electricity/gas/water), not older than 3 months.',
'Yes; If Yes, mention: 41. Last attained degree : ','H.S.C','1980','BAGORDA HIGH SCHOOL',
'Yes; 45. If Yes, mention : ','Service','UNITED FINANCE',
'Yes; 54. If yes, mention details : ','BLOCK, BATIK, EMBROIDERY',
'Yes; 56. If yes, mention details : ','FARM HOUSE'
)

GO

Create proc spGetActualPerInfFormAsset
as
begin
	Select 
	OwnerType,ApplicationID,ApplicantName,FathersName,FOccupation,
	MothersName,Moccupation,SpouseName,SOccupation,DateOfBirth,Gender,District,Country,
	HaveIDCard,IDType,IDNo,Nationality,DualCitizenship,SecondCountry,
	HaveTin,TinNo,TelephoneRes,Mobile,Email,
	PresentAddress,PreAddOwnership,
	PreAddOccTenure,PreAddAgrPeriod,PreAddLandLord,PreAddPhoneNo,PreAddUtilityBill,
	PersentAddress,PerAddOwnership,
	PerAddOccTenure,PerAddAgrPeriod,PerAddLandLord,PerAddPhoneNo,PerAddUtilityBill,
	HaveInstDegree,LastAttinedDegree,PassingYear,Institution,
	DoYouEarn,EarningType,Organization,
	HaveTechnicalExp,TechnicalExpertise,
	InvolvedInOtherBusiness,OtherBusiness
	from tblPersonalInfFormAsset
end

GO

