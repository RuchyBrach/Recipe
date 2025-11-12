use HeartyHearthdb 
go
create or alter proc dbo.RecipeStatusUpdate(
@RecipeId int output,
@DateTimeDraft datetime2 output,
@DateTimePublished datetime2 output,
@DateTimeArchived datetime2 output,
@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
		select @DateTimePublished = nullif(@DateTimePublished, ''), @DateTimeArchived = nullif(@DateTimeArchived, '')
		update Recipe
		set
			DateTimeDraft = @DateTimeDraft, 
			DateTimePublished = @DateTimePublished, 
			DateTimeArchived = @DateTimeArchived
			where RecipeId = @RecipeId
	return @return
end
go

select * from recipe r where r.RecipeId = 55
