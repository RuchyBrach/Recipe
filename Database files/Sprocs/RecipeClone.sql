use HeartyHearthdb
go 
create or alter proc dbo.RecipeClone(@RecipeId int = null output, @BaseRecipeId int, @Message varchar (500) = '' output)
as 
begin
	insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
	select r.HHUserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.Calories, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived
	from Recipe r
	where r.RecipeId = @BaseRecipeId

	select @RecipeId = SCOPE_IDENTITY()

	insert RecipeIngredient(IngredientId, MeasTypeId, RecipeId, IngredientSequence, Qty)
	select ri.IngredientId, ri.MeasTypeId, @RecipeId, ri.IngredientSequence, ri.Qty
	from RecipeIngredient ri
	where ri.RecipeId = @BaseRecipeId

	insert Direction(RecipeId, DirectionSequence, Instruction)
	select @RecipeId, d.DirectionSequence, d.Instruction
	from Direction d 
	where d.RecipeId = @BaseRecipeId

	return @RecipeId 
end
go