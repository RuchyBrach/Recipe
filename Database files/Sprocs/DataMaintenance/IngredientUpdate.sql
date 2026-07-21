create or alter proc dbo.IngredientUpdate(@IngredientId int output, @IngredientName varchar(200), @Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @IngredientId = isnull(@IngredientId, 0)
	if @IngredientId = 0
	begin
		insert Ingredient(IngredientName)
		select @IngredientName
		select @IngredientId = SCOPE_IDENTITY()
	end
	else
	begin 
	update Ingredient
	set 
		IngredientName = @IngredientName
	where IngredientId = @IngredientId
	end

	return @return
end
go