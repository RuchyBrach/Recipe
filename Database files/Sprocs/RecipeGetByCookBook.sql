create or alter procedure dbo.RecipeGetByCookBook(
@CookBookName varchar (200)
)
as
begin 
	select @CookBookName = nullif(@CookBookName, '')
	select r.HHUserId, r.CuisineId, r.RecipeId, r.RecipeName, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipeStatus, h.UserName,  r.Calories, NumIngredients = count(ri.RecipeId), r.RecipePic, r.Vegan, cb.CookBookName
	from Recipe r 
	join HHUser h 
	on r.HHUserId = h.HHUserId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	join CookBookRecipe cbr
	on r.RecipeId = cbr.RecipeId
	join CookBook cb
	on cbr.CookBookId = cb.CookBookId
	where cb.CookBookName = @CookBookName
	group by r.RecipeName, r.RecipeStatus, h.UserName, r.Calories, r.RecipeId, r.HHUserId, r.CuisineId, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipePic, r.Vegan, cb.CookBookName
	order by r.RecipeName, r.Calories, r.DateTimeDraft
end
go
