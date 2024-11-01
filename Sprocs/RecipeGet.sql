create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(200) = '', @All bit = 0)
as
begin 
	select @RecipeName = nullif(@RecipeName, '')
	select r.HHUserId, r.CuisineId, r.RecipeId, r.RecipeName, r.Calories, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipeStatus, r.RecipePic
	from Recipe r 
	where r.RecipeId = @RecipeId
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1
	order by r.RecipeName, r.Calories, r.DateTimeDraft
end
go

/*
Declare @Name varchar(200)
select top 1 @Name = r.RecipeName from Recipe r order by r.RecipeName
exec RecipeGet @RecipeName = @Name

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = '', @All = 1
exec RecipeGet @RecipeName = null

exec RecipeGet @All = 1

declare @Id int
select top 1 @Id = r.RecipeId from Recipe r order by r.RecipeId
exec RecipeGet @RecipeId = @Id
*/