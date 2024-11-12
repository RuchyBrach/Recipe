declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
left join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
left join Ingredient i 
on ri.IngredientId = i.IngredientId
left join Direction d
on r.RecipeId = d.RecipeId
where i.IngredientId is null 
and d.DirectionId  is null
order by r.RecipeId

select * from Recipe r where r.RecipeId = @recipeid

exec RecipeDelete @recipeId = @recipeId

select * from Recipe r where r.RecipeId = @recipeid