create or alter proc dbo.CookBookRecipeGet(
@CookBookRecipeId int = 0,
@CookBookId int,
@All bit = 0, 
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @CookBookId = isnull(@CookBookId, 0), @All = isnull(@All, 0), @CookBookRecipeId = isnull(@CookBookRecipeId, 0)
	
	select cr.CookBookRecipeId, c.CookBookId, cr.RecipeId, cr.RecipeSequence
	from CookBookRecipe cr
	join CookBook c
	on cr.CookBookId = c.CookBookId
	where cr.CookBookRecipeId = @CookBookRecipeId
	or c.CookBookId = @CookBookId
	or @All = 1
	order by cr.RecipeSequence

	return @return
end
go

--exec CookBookRecipeGet