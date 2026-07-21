create or alter procedure dbo.RecipeGetByCuisine(
@CuisineId int
)
as
begin 
	select r.HHUserId, r.CuisineId, r.RecipeId, r.RecipeName, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipeStatus, h.UserName,  r.Calories, NumIngredients = count(ri.RecipeId), r.RecipePic, r.Vegan
	from Recipe r 
	join HHUser h 
	on r.HHUserId = h.HHUserId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where r.CuisineId = @CuisineId
	group by r.RecipeName, r.RecipeStatus, h.UserName, r.Calories, r.RecipeId, r.HHUserId, r.CuisineId, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipePic, r.Vegan
	order by r.RecipeName, r.Calories, r.DateTimeDraft
end
go
