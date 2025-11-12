use HeartyHearthdb
go
create or alter proc dbo.DirectionDelete(
	@DirectionId int = 0,
	@Message varchar (500) = '' output
)
as 
begin
	declare @return int = 0
	select @DirectionId = isnull(@DirectionId, 0)

	delete d
	from Direction d
	where d.DirectionId = @DirectionId

	return @return
end
go