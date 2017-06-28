

Declare @TypingTestID as nvarchar(50) Set @TypingTestID = 'TT-00000034'
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
		Print 'A-'+ @ResponseWord + '-S-'+Convert(nvarchar,@Score)
		While @mCount <= @mNCount
		begin
			Select top 1 @StoryWord=StoryWord,@mSLNo=mSLNo from @StoryTbl Where Taken = 0

			Set @Distance = dbo.edit_distance(@ResponseWord,@StoryWord)

			Print 'D-'+Convert(nvarchar,@Distance)

			if @Score > @Distance
			begin
				Set @Score = @Distance
				Print 'SS-'+Convert(nvarchar,@Score)
			end

			Update @StoryTbl Set Taken = 1 Where mSLNo = @mSLNo
			Set @mCount = @mCount + 1
			Set @Distance = 0
		end

		Set @Score = (LEN(@ResponseWord) - @Score)/ (LEN(@ResponseWord))*100
		
		Update @ResponseTbl Set Taken = 1,Score = @Score Where SLNO = @SLNO
		Set @Count = @Count + 1
		Set @ResponseWord = ''
		Update @StoryTbl Set Taken =0
	end


	Declare @AvgScore as numeric(5,2) Set @AvgScore = 0
	Declare @FinalScore as numeric(5,2) Set @FinalScore = 0
	Select @AvgScore = AVG(Score) from @ResponseTbl
	Select @FinalScore = (@NCount/@mNCount) --* @AvgScore


	Select @NCount as 'Response',@mNCount as 'Story',@AvgScore as 'AVG',@FinalScore as 'FinalScore'
--	Select * from @ResponseTbl

Select Convert(numeric(5,2),(58.0/95.0))