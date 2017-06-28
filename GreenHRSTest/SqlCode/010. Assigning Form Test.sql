
-- exec spInsertCandidateFormTest 'Can-00000001','FRM-00000001','dsamaddar'
-- exec spInsertCandidateFormTest 'Can-00000001','FRM-00000002','dsamaddar'
-- exec spInsertCandidateFormTest 'Can-00000001','FRM-00000003','dsamaddar'
-- exec spInsertCandidateFormTest 'Can-00000001','FRM-00000004','dsamaddar'
-- exec spInsertTypingTest 'Can-00000001','ST-00000003','dsamaddar'

Select * from tblTypingTest
Select * from tblCandidateFormTest