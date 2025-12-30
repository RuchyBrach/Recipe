create or alter proc dbo.CourseGet(@CourseId int = 0, @All bit = 0, @IncludeBlank bit = 0)
as 
begin
	declare @return int = 0
	select @IncludeBlank = isnull(@IncludeBlank, 0)
	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	order by c.CourseSequence
	return @return
end 
go