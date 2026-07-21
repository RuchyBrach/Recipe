create or alter proc dbo.MeasTypeGet(
	@MeasTypeId int = 0, 
	@All int = 0, 
	@IncludeBlank int = 0,
	@Message varchar(500) = '' output)
as 
begin 
	declare @return int = 0
	
	select @MeasTypeId = isnull(@MeasTypeId, 0), @All = isnull(@All, 0)

	select m.MeasTypeId, m.MeasTypeName
	from MeasType m 
	where @MeasTypeId = m.MeasTypeId
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1
	order by m.MeasTypeName
	
	return @return
end
go

exec MeasTypeGet