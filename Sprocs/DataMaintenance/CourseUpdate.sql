create or alter proc dbo.CourseUpdate(@CourseId int output, @CourseName varchar(100), @CourseSequence int, @Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @CourseId = isnull(@CourseId, 0)
	if @CourseId = 0
	begin
		insert Course(CourseName, CourseSequence)
		select @CourseName, @CourseSequence
		select @CourseId = SCOPE_IDENTITY()
	end
	else
	begin 
	update Course
	set 
		CourseName = @CourseName,
		CourseSequence = @CourseSequence
	where CourseId = @CourseId
	end

	return @return
end
go