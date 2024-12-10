create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(350)
as 
begin
	declare @value varchar(350)
	;with x as(
		select NumDirections = count(d.DirectionId), d.RecipeId
		from Direction d 
		group by d.RecipeId
	)
	select @value = concat(r.RecipeName, ' (', c.CuisineName, ') has ', isnull(count(ri.RecipeIngredientId), 0), ' ingredients and ',  isnull(x.NumDirections, 0), ' steps.')
	from Recipe r
	left join x
	on r.RecipeId = x.RecipeId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	left join Cuisine c 
	on c.CuisineId = r.CuisineId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, c.CuisineName, x.NumDirections
	order by r.RecipeName
	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.RecipeId), r.*
from recipe r