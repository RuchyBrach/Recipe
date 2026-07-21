create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int, 
	@All bit = 0, 
	@Message varchar(500) = '' output)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	select r.RecipeId, ri.RecipeIngredientId, i.IngredientId, m.MeasTypeId, ri.IngredientSequence, ri.Qty
	from RecipeIngredient ri
	join recipe r 
	on r.RecipeId = ri.RecipeId
	left join Ingredient i
	on i.IngredientId = ri.IngredientId
	left join MeasType m 
	on ri.MeasTypeId = m.MeasTypeId
	where @RecipeId = ri.RecipeId
	or @All = 1
	order by ri.IngredientSequence
	return @return
end
go

select * from recipe r

exec RecipeIngredientGet @RecipeId = 16