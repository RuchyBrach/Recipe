--cookbookget
create or alter proc dbo.CookBookGet(
@CookBookId int = 0,
@All bit = 0,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
		
	select c.CookBookId, c.CookBookName, h.UserName, c.HHUserId, NumRecipes = Count(cbr.RecipeId), c.Price, c.CookBookDateCreated, c.CookBookActive, c.CookBookSkill, c.CookBookSkillDesc
	from CookBook c
	join HHUser h 
	on c.HHUserId = h.HHUserId
	left join CookBookRecipe cbr
	on c.CookBookId = cbr.CookBookId
	where c.CookBookId = @CookBookId 
	or @All = 1
	group by c.CookBookId, c.CookBookName, h.UserName, c.HHUserId, c.Price, c.CookBookDateCreated, c.CookBookActive, c.CookBookSkill, c.CookBookSkillDesc
	return @return
end
go
exec CookBookGet @All = 1
select * from cookbook