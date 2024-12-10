create or alter function dbo.MealCal(@MealId int)
returns int
as
begin 
	declare @value int = 0
	select @value = sum(r.Calories)
	from Meal m 
	left join MealCourse mc 
	on m.MealId = mc.MealId
	left join MealCourseRecipe mcr 
	on mc.MealCourseId = mcr.MealCourseId
	left join Recipe r 
	on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId
	group by m.MealName
	return @value
end
go
select MealCal = dbo.MealCal(m.MealId), m.*
from Meal m
