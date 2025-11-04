use HeartyHearthdb
go
create or alter proc dbo.DirectionUpdate(
	@DirectionId int output, 
	@RecipeId int, 
	@Instruction varchar (500), 
	@DirectionSequence int, 
	@Message varchar (500) = '' output
	)
as
begin
	select @DirectionId = isnull(@DirectionId, 0)

	if @DirectionId = 0
	begin
		insert Direction(RecipeId, DirectionSequence, Instruction)
		select @RecipeId, @DirectionSequence, @Instruction

		select @DirectionId = SCOPE_IDENTITY()
	end

	else
	begin
		update Direction
		set
		RecipeId = @RecipeId,
		DirectionSequence = @DirectionSequence,
		Instruction = @Instruction
		where DirectionId = @DirectionId
	end
end 
go

