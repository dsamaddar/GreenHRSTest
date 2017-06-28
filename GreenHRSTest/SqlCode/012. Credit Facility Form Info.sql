
-- drop table tblCreditFacilityFormInfo
Create table tblCreditFacilityFormInfo(
SLNO int identity(1,1) primary key,
ApplicationDate nvarchar(50),
ApplicationID nvarchar(50),
Branch nvarchar(50),
Purpose nvarchar(50),
Product nvarchar(50),
Amount nvarchar(50),
Tenure nvarchar(10),
NameOfBusiness nvarchar(50),
GroupName nvarchar(50),
MainSponsor nvarchar(50),
DesigOfMainSponsor nvarchar(50),
ContactNumber nvarchar(50),
OfficeAddress nvarchar(100),
FactoryAddress nvarchar(100),
ContactNumberOff nvarchar(50),
Email nvarchar(50),
PersonalGuarantee nvarchar(200),
Directors nvarchar(5),
Spouses nvarchar(5),
FamilyMember nvarchar(5),
BusinessFriend nvarchar(5),
LienOnCash nvarchar(50),
TypeOfSecurity nvarchar(50),
SecurityAmount nvarchar(50),
BankFIName nvarchar(50),
RegisteredMortgage nvarchar(50),
LandSize nvarchar(50),
FloorSize nvarchar(50),
NumberOfFloor nvarchar(50),
Location nvarchar(50),
ChqCovering nvarchar(50),
ChqCoveringInt nvarchar(50),
HypoInv nvarchar(50),
HypoInvType nvarchar(50),
HypoMac nvarchar(50),
HypoMacType nvarchar(50)
);

GO

Insert into tblCreditFacilityFormInfo(
ApplicationDate,ApplicationID,Branch,Purpose,Product,Amount,Tenure,NameOfBusiness,GroupName,MainSponsor,
DesigOfMainSponsor,ContactNumber,OfficeAddress,FactoryAddress,
ContactNumberOff,Email,PersonalGuarantee,
Directors,Spouses,FamilyMember,BusinessFriend,LienOnCash,TypeOfSecurity,SecurityAmount,BankFIName,
RegisteredMortgage,LandSize,FloorSize,NumberOfFloor,Location,
ChqCovering,ChqCoveringInt,
HypoInv,HypoInvType,
HypoMac,HypoMacType
)
Values(
'11/29/2015','20150331006','FARMGATE','Working Capital','Nokshi','8,00,000','12','LIRIC FASHION','N\A','FOZILATUN NESA',
'PROPRIETOR','017152444867','HOUSE NO - 15316, FLAT - F-5, SHANTINAGAR, DHAKA-1217','HOUSE NO - 14, KUSUMBAGH, SABUGBAGH, DHAKA-1214',
'02-9340031','HR@LIRIC.COM.BD','Yes; If Yes, provide following information and fill up personal profile for each guarantor :',
'','2','','5','Yes; If Yes, provide following information : ','Deposit with other Bank/FI','100,000','BRAC BANK',
'Yes; If Yes, provide following information : ','123','7200','3','N.H.B-23, NEW COLONY, LALMATIA',
'Yes; If Yes, 38. If Yes, mention : ','With interest',
'Yes; 40. If Yes, mention:','Registered',
'Yes; 40. If Yes, mention:','Simple'
)

GO

Create proc spGetActualCreditFacilityInfoValues
as
begin
	Select ApplicationDate,ApplicationID,Branch,Purpose,Product,Amount,Tenure,NameOfBusiness,GroupName,MainSponsor,
	DesigOfMainSponsor,ContactNumber,OfficeAddress,FactoryAddress,
	ContactNumberOff,Email,PersonalGuarantee,
	Directors,Spouses,FamilyMember,BusinessFriend,LienOnCash,TypeOfSecurity,SecurityAmount,BankFIName,
	RegisteredMortgage,LandSize,FloorSize,NumberOfFloor,Location,
	ChqCovering,ChqCoveringInt,
	HypoInv,HypoInvType,
	HypoMac,HypoMacType
	from tblCreditFacilityFormInfo
end