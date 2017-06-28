

Create table tblOrganizationalInfo(
SLNO int identity(1,1) primary key,
LegalStatus nvarchar(100),
NameOfTheCompany nvarchar(100),
IndustrySector nvarchar(100),
FemaleOwnership nvarchar(100),
DateOfIncorporation nvarchar(100),
eTin nvarchar(100),
NatureOfBusiness nvarchar(100),
MajorProduct nvarchar(100),
BusinessAddress nvarchar(200),
RegisteredAddress nvarchar(200),
Phone nvarchar(100),
Mobile nvarchar(100),
Fax nvarchar(100),
Email nvarchar(100),
NameOfComOne nvarchar(100),
NatureOfBusinessOne nvarchar(100),
NameOfComTwo nvarchar(100),
NatureOfBusinessTwo nvarchar(100),
NameOfComThree nvarchar(100),
NatureOfBusinessThree nvarchar(100),
NameOfBankOne nvarchar(100),
BranchLocOne nvarchar(100),
NameOfBankTwo nvarchar(100),
BranchLocTwo nvarchar(100),
ReasonForChoosing nvarchar(100)
);

GO

Insert into tblOrganizationalInfo(LegalStatus,NameOfTheCompany,IndustrySector,FemaleOwnership,DateOfIncorporation,eTin,
NatureOfBusiness,
MajorProduct,
BusinessAddress,
RegisteredAddress,
Phone,Mobile,Fax,Email,
NameOfComOne,NatureOfBusinessOne,
NameOfComTwo,NatureOfBusinessTwo,
NameOfComThree,NatureOfBusinessThree,
NameOfBankOne,BranchLocOne,
NameOfBankTwo,BranchLocTwo,
ReasonForChoosing)
Values('Private Limited Company','Aftab Group','Manufacturing','Yes','12/22/1994','129722597628',
'AFTAB GROUP is one of the leading enterprises',
'Banking sector, Textile, Food, Readymade garments, Agriculture, Compressed natural gas, Real Estate',
'Uttara Bank Bhaban (4th & 5th Floor)90, Motijheel C/A, Dhaka-1000',
'41-44, 75th Street, Elmhurst, Zip Code-11373, New York, U.S.A.',
'+8807161874','+8801730725697','+8807166227','aftab_g@aitlbd.net',
'FROZEN FOODS LIMITED','Frozen Foods Limited has been designed for collection, processing and packaging of frozen shrimp',
'AFTAB GLOBAL TEXTILE MILLS LIMITED','Currently having 37,000 spindles running in full swing',
'AFTAB CNG LIMITED','Aftab CNG Ltd is already been a trusted name in the era of CNG conversion and refueling',
'Dhaka Bank','Panthapath',
'Uttara Bank','Gulshan',
'Direct Sales of United Finance'
)

GO

Create proc spGetAcutalOrgInfoValues
as
begin

	Select 
	LegalStatus,NameOfTheCompany,IndustrySector,FemaleOwnership,DateOfIncorporation,eTin,NatureOfBusiness,
	MajorProduct,BusinessAddress,RegisteredAddress,Phone,Mobile,Fax,Email,NameOfComOne,NatureOfBusinessOne,
	NameOfComTwo,NatureOfBusinessTwo,NameOfComThree,NatureOfBusinessThree,NameOfBankOne,BranchLocOne,
	NameOfBankTwo,BranchLocTwo,ReasonForChoosing

	From tblOrganizationalInfo
	
end