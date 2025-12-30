use HeartyHearthdb
go
create or alter proc dbo.CuisineDelete(@CuisineId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @CuisineId = isnull(@CuisineId, 0)

	delete mcr 
	from MealCourseRecipe mcr
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	where r.CuisineId = @CuisineId

	delete cbr
	from CookBookRecipe cbr
	join Recipe r
	on cbr.RecipeId = r.RecipeId
	where r.CuisineId = @CuisineId

	delete d
	from Direction d 
	join Recipe r 
	on d.RecipeId = r.RecipeId
	where r.CuisineId = @CuisineId

	delete ri 
	from RecipeIngredient ri
	join Recipe r
	on ri.RecipeId = r.RecipeId
	where r.CuisineId = @CuisineId

	delete r
	from Recipe r
	where r.CuisineId = @CuisineId

	delete c 
	from Cuisine c
	where c.CuisineId = @CuisineId

	return @return
end
go