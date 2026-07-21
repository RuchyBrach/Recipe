--recipeget
create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@RecipeName varchar(200) = '', 
@All bit = 0, 
@IncludeBlank bit = 0)
as
begin 
	select @RecipeName = nullif(@RecipeName, '')
	select r.HHUserId, r.CuisineId, r.RecipeId, r.RecipeName, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipeStatus, h.UserName,  r.Calories, 'NumIngredients' = count(ri.RecipeId), r.RecipePic, r.Vegan
	from Recipe r 
	left join HHUser h 
	on r.HHUserId = h.HHUserId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @RecipeId
	or r.RecipeName like '%' + @RecipeName + '%'
	or @All = 1
	group by r.RecipeName, r.RecipeStatus, h.UserName, r.Calories, r.RecipeId, r.HHUserId, r.CuisineId, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, r.RecipePic, r.Vegan
	union select 0, 0, 0, '', '', '', '', '', '', 0, 0, '', 0
	where @IncludeBlank = 1
	order by r.RecipeName, r.Calories, r.DateTimeDraft
end
go

--cookbookget
create or alter proc dbo.CookBookGet(
@CookBookId int = 0,
@All bit = 0,
@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
		
	select c.CookBookId, c.CookBookName, h.UserName, c.HHUserId, 'NumRecipes' = Count(cbr.RecipeId), c.Price, c.CookBookDateCreated, c.CookBookActive, c.CookBookSkill, c.CookBookSkillDesc
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

--meallistget
create or alter proc dbo.MealGet(@All bit = 0)
as
begin 
	select m.MealName, h.UserName, 'NumCalories' = isnull(sum(r.Calories), 0), 'NumCourses' = count(distinct mc.CourseId), 'NumRecipes' = count(mcr.RecipeId), m.MealDesc
	from Meal m 
	left join HHUser h 
	on m.HHUserId = h.HHUserId
	left join MealCourse mc
	on m.MealId = mc.MealId
	left join MealCourseRecipe mcr 
	on mc.MealCourseId = mcr.MealCourseId
	left join Recipe r 
	on mcr.RecipeId = r.RecipeId
	group by m.MealName, h.UserName, m.MealDesc
	order by m.MealName
end
go
