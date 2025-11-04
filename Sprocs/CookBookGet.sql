create or alter proc dbo.CookBookGet(
@CookBookId int = 0,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
		
	select c.CookBookId, c.CookBookName, c.HHUserId, c.Price, c.CookBookDateCreated, c.CookBookActive
	from CookBook c
	where c.CookBookId = @CookBookId 

	return @return
end
go

--exec CookBookGet