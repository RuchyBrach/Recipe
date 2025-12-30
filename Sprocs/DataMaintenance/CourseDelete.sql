use HeartyHearthdb
go
create or alter proc dbo.CourseDelete(@CourseId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @CourseId = isnull(@CourseId, 0)

	delete mcr 
	from MealCourseRecipe mcr
	join MealCourse mc
	on mcr.MealCourseId = mc.MealCourseId
	where mc.CourseId = @CourseId

	delete mc 
	from MealCourse mc
	where mc.CourseId = @CourseId

	delete c 
	from Course c
	where c.CourseId = @CourseId

	return @return
end
go

--exec CourseDelete @CourseId = 18