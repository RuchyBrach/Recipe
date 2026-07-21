use HeartyHearthdb
go
create or alter proc dbo.MeasTypeDelete(@MeasTypeId int, @Message varchar(500) = '' output)
as 
begin
	declare @return int = 0
	select @MeasTypeId = isnull(@MeasTypeId, 0)

	Delete ri
	from RecipeIngredient ri
	where ri.MeasTypeId = @MeasTypeId

	delete mt
	from MeasType mt
	where mt.MeasTypeId = @MeasTypeId

	return @return
end
go