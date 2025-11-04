

create or alter proc dbo.RecipeListGet(
	@All bit = 0,
	@IncludeBlank bit = 0
)
as 
begin 
	select r.RecipeId, r.RecipeName, r.RecipeStatus, h.UserName, r.Calories, 'Num Ingredients' = count(ri.RecipeId)
	from Recipe r
	join HHUser h
	on h.HHUserId = r.HHuserId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where @All = 1
	group by r.RecipeName, r.RecipeStatus, h.UserName, r.Calories, r.RecipeId
	union select 0, '', '', '', 0, 0
	where @IncludeBlank = 1
	order by r.RecipeStatus desc
end
go 
exec RecipelistGet @All = 1, @IncludeBlank = 1