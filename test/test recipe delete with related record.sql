declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
join Direction d
on r.RecipeId = d.RecipeId
order by r.RecipeId

select * from Recipe r where r.RecipeId = @recipeid

exec RecipeDelete @recipeId = @recipeId

select * from Recipe r where r.RecipeId = @recipeid