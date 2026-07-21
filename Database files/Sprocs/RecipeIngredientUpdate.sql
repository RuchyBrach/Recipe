use HeartyHearthdb
go
create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int output,
	@IngredientId int, 
	@MeasTypeId int, 
	@RecipeId int, 
	@IngredientSequence int,
	@Qty int, 
	@Message varchar (500) = '' output
	)
as
begin
	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(IngredientId, MeasTypeId, RecipeId, IngredientSequence, Qty)
		select @IngredientId, @MeasTypeId, @RecipeId, @IngredientSequence, @Qty

		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	
	else
	begin 
		update RecipeIngredient
		set
			IngredientId = @IngredientId,
			MeasTypeId = @MeasTypeId,
			RecipeId = @RecipeId,
			IngredientSequence = @IngredientSequence,
			Qty = @Qty
			where RecipeIngredientId = @RecipeIngredientId
	end
end 
go