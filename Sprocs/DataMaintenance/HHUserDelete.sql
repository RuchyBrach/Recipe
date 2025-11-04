use HeartyHearthdb
go
create or alter proc dbo.HHUserDelete(@HHUserId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @HHUserId = isnull(@HHUserId, 0)
	begin try
		begin tran

		delete mcr 
		from MealCourseRecipe mcr
		join MealCourse mc
		on mc.MealCourseId = mcr.MealCourseId
		join Meal m 
		on m.MealId = mc.MealId
		join Recipe r
		on r.RecipeId = mcr.RecipeId
		where m.HHUserId = @HHUserId
		or r.HHUserId = @HHUserId
		
		delete mc 
		from MealCourse mc 
		join Meal m 
		on m.MealId = mc.MealId
		where m.HHUserId = @HHUserId

		delete m 
		from Meal m 
		where m.HHUserId = @HHUserId

		delete cbr
		from CookBookRecipe cbr
		join CookBook c
		on c.CookBookId = cbr.CookBookId
		join Recipe r
		on r.RecipeId = cbr.RecipeId
		where c.HHUserId = @HHUserId 
		or r.HHUserId = @HHUserId

		delete c 
		from CookBook c
		where c.HHUserId = @HHUserId

		delete d
		from Direction d 
		join Recipe r
		on r.RecipeId = d.RecipeId
		where r.HHUserId = @HHUserId

		delete ri 
		from RecipeIngredient ri
		join Recipe r 
		on r.RecipeId = ri.RecipeId
		where r.HHUserId = @HHUserId

		delete r 
		from Recipe r
		where r.HHUserId = @HHUserId

		delete h
		from HHUser h
		where h.HHUserId = @HHUserId
		
		commit
	end try
	begin catch
		select @return = 1
		rollback;
		throw
	end catch

	return @return
end
go