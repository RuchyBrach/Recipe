create or alter proc dbo.MealListGet(@All bit = 0)
as
begin 
	select m.MealName, h.UserName, 'Num Calories' = isnull(sum(r.Calories), 0), 'Num Courses' = count(distinct mc.CourseId), 'Num Recipes' = count(mcr.RecipeId)
	from Meal m 
	left join HHUser h 
	on m.HHUserId = h.HHUserId
	left join MealCourse mc
	on m.MealId = mc.MealId
	left join MealCourseRecipe mcr 
	on mc.MealCourseId = mcr.MealCourseId
	left join Recipe r 
	on mcr.RecipeId = r.RecipeId
	group by m.MealName, h.UserName
	order by m.MealName
end
go

exec MealListGet @All = 1

select * from Meal m 