use HeartyHearthdb
go
create or alter procedure dbo.RecipeDelete(@RecipeId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0

	if exists(select * from recipe r where r.RecipeId = @RecipeId and DateDiff(day, r.DateTimeArchived, CURRENT_TIMESTAMP) < 30)
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is archived for less than 30 days.'
		goto finished
	end
	if exists(select * from recipe r where r.RecipeId = @RecipeId and r.RecipeStatus = 'Published')
	begin
		select @return = 1, @Message = 'Cannot delete recipe where recipe status = Published.'
		goto finished
	end

	begin try
		begin tran

		delete MealCourseRecipe
		where RecipeId = @RecipeId

		delete CookBookRecipe
		where RecipeId = @RecipeId

		delete RecipeIngredient
		where RecipeId = @RecipeId

		delete Direction
		where RecipeId = @RecipeId

		delete Recipe
		where RecipeId = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	finished:
	return @return
end 
go


