use HeartyHearthdb
go
create or alter proc dbo.CookBookAutoCreate(@HHUserId varchar (100), @CookBookId int = null output, @Message varchar (500) = '' output)
as
begin 
	declare @return int = 0
	declare @price decimal(10,2)
	if not exists(select 1 from Recipe r where r.HHuserId = @HHUserId)
	begin 
		select @return = 1, @Message = 'Cannot create cookbook because user has 0 recipes.'
		goto finished
	end
	select @price = count(r.RecipeId) * 1.33
	from Recipe r 
	where r.HHUserId = @HHUserId

	insert CookBook(HHUserId, CookBookName, Price, CookBookDateCreated, CookBookActive)
	select @HHUserId, concat('Recipes by ',h.UserName), @price, GetDate(), 0 
	from HHUser h
	where h.HHUserId = @HHUserId

	select @CookBookId = SCOPE_IDENTITY()

	;with x as(
		select r.RecipeId,
		seq = row_number() over (order by r.RecipeName)
		from Recipe r 
		where r.HHuserId = @HHUserId
	)
	insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
	select @CookBookId, x.RecipeId, x.seq
	from x
	finished:
	return @return
	
end 
go

exec CookBookAutoCreate @HHUserId = 2

exec sp_helpconstraint 'CookBook';

