use HeartyHearthdb
go
create or alter proc dbo.CookBookRecipeUpdate(
	@CookBookRecipeId int output,
	@CookBookId int, 
	@RecipeId int, 
	@RecipeSequence int, 
	@Message varchar (500) = '' output
	)
as
begin
	select @CookBookRecipeId = isnull(@CookBookRecipeId, 0)

	if @CookBookRecipeId = 0
	begin
		insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
		select @CookBookId, @RecipeId, @RecipeSequence

		select @CookBookRecipeId = SCOPE_IDENTITY()
	end
	
	else
	begin
		update CookBookRecipe
		set
			CookBookId = @CookBookId, 
			RecipeId = @RecipeId,
			RecipeSequence = @RecipeSequence
			where CookBookRecipeId = @CookBookRecipeId
	end
end 
go