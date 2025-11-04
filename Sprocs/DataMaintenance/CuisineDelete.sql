use HeartyHearthdb
go
create or alter proc dbo.CuisineDelete(@CuisineId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @CuisineId = isnull(@CuisineId, 0)

	delete c 
	from Cuisine c
	where c.CuisineId = @CuisineId

	return @return
end
go