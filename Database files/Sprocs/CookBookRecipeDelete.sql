use HeartyHearthdb
go
create or alter proc dbo.CookBookRecipeDelete(
	@CookBookRecipeId int = 0,
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0
	select @CookBookRecipeId = isnull(@CookBookRecipeId, 0)

	delete cbr
	from CookBookRecipe cbr 
	where cbr.CookBookRecipeId = @CookBookRecipeId

	return @return
end
go