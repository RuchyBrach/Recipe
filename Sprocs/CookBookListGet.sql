create or alter proc dbo.CookBookListGet(@All bit = 0, @Message varchar (500) = '' output)
as
begin
	declare @return int = 0
		select c.CookBookId, c.CookBookName, h.UserName, NumRecipes = isnull(Count(cbr.RecipeId), 0), c.Price
		from CookBook c
		left join CookBookRecipe cbr 
		on c.CookBookId = cbr.CookBookId
		left join HHUser h 
		on c.HHUserId = h.HHUserId
		where @All = 1
		group by c.CookBookId, c.CookBookName, h.UserName, c.Price
	return @return
end
go

exec CookBookListGet @All = 1

select c.CookBookName, h.UserName, NumRecipes = count(cbr.RecipeId), c.Price
from CookBook c
join CookBookRecipe cbr 
on c.CookBookId = cbr.CookBookId
join HHUser h 
on c.HHUserId = h.HHUserId
group by c.CookBookName, c.Price, h.UserName
