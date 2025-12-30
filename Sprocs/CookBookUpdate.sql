create or alter proc dbo.CookBookUpdate(
@CookBookId int output, 
@HHUserId int, 
@CookBookName varchar(200), 
@Price decimal, 
@CookBookDateCreated datetime2 output, 
@CookBookActive bit,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @CookBookId = isnull(@CookBookId, 0), @CookBookDateCreated = isnull(@CookBookDateCreated, CURRENT_TIMESTAMP), @CookBookActive = isnull(@CookBookActive, 0)

	if @CookBookId = 0 
	begin
		insert CookBook(HHUserId, CookBookName, Price, CookBookDateCreated, CookBookActive)
		select @HHUserId, @CookBookName, @Price, @CookBookDateCreated, @CookBookActive
		
		select @CookBookId = SCOPE_IDENTITY()
	end
	else
	begin
		update CookBook
		set
		HHUserId = @HHUserId, 
		CookBookName = @CookBookName, 
		Price = @Price, 
		CookBookDateCreated = @CookBookDateCreated, 
		CookBookActive = @CookBookActive
		where CookBookId = @CookBookId
	end
	return @return
end
go

--exec CookBookUpdate
