use HeartyHearthdb
go
create or alter proc dbo.DirectionGet(
	@Direction int = 0,
	@RecipeId int, 
	@All bit = 0, 
	@Message varchar(500) = '' output
	)
as
begin

	declare @return int = 0
	select @RecipeId = isnull(@RecipeId, 0), @All = isnull(@All, 0), @Direction = isnull(@Direction, 0)

	select d.DirectionId, r.RecipeId,  d.DirectionSequence, d.Instruction
	from Direction d
	join Recipe r 
	on r.RecipeId = d.RecipeId
	where @RecipeId = r.RecipeId
	or @All = 1
	order by d.DirectionSequence
	return @return
end

exec RecipeDirectionGet @RecipeId = 15