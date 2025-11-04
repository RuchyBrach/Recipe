create or alter proc dbo.CourseDelete(@CourseId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @CourseId = isnull(@CourseId, 0)

	delete c 
	from Course c
	where c.CourseId = @CourseId

	return @return
end
go

--exec CourseDelete @CourseId = 18