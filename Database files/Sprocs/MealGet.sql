create or alter proc dbo.MealGet(@All bit = 0)
as
begin 
	select m.MealName, h.UserName, NumCalories = isnull(sum(r.Calories), 0), NumCourses = count(distinct mc.CourseId), NumRecipes = count(mcr.RecipeId), m.MealDesc
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

exec MealGet @All = 1

select * from Meal m 