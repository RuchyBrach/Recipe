use HeartyHearthdb
go
create or alter proc dbo.IngredientDelete(@IngredientId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @IngredientId = isnull(@IngredientId, 0)

	delete i
	from Ingredient i 
	where i.IngredientId = @IngredientId

	return @return
end
go