create or alter proc dbo.MeasTypeUpdate(@MeasTypeId int output, @MeasTypeName varchar(100), @Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @MeasTypeId = isnull(@MeasTypeId, 0)
	if @MeasTypeId = 0
	begin
		insert MeasType(MeasTypeName)
		select @MeasTypeName
		select @MeasTypeId = SCOPE_IDENTITY()
	end
	else
	begin 
	update MeasType
	set 
		MeasTypeName = @MeasTypeName
	where MeasTypeId = @MeasTypeId
	end

	return @return
end
go