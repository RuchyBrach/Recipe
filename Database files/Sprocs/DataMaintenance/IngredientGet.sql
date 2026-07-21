create or alter proc dbo.IngredientGet(
	@IngredientId int = 0,
	@IngredientName varchar (200) = '',
	@All bit = 0, 
	@Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @IngredientId = isnull(@IngredientId, 0), @All = isnull(@All, 0), @IngredientName = nullif(@IngredientName, '')

	select i.IngredientId, i.IngredientName
	from Ingredient i 
	where i.IngredientId = @IngredientId
	or i.IngredientName like '%' + @IngredientName + '%'
	or @All = 1
	order by i.IngredientName
	return @return
end
go
exec IngredientGet