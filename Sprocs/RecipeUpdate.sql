create or alter proc dbo.RecipeUpdate(
@RecipeId int output,
@HHUserId int ,
@CuisineId int ,
@RecipeName varchar (200),
@Calories int ,
@DateTimeDraft datetime2 output,
@DateTimePublished datetime2 output,
@DateTimeArchived datetime2 output,
@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	select @RecipeId = isnull(@RecipeId, 0), @DateTimeDraft = isnull(@DateTimeDraft, CURRENT_TIMESTAMP)
	

	if @RecipeId = 0 
	begin
		insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
		select @HHUserId, @CuisineId, @RecipeName, @Calories, @DateTimeDraft, @DateTimePublished, @DateTimeArchived
		
		select @RecipeId = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateTimeDraft = @DateTimeDraft, 
			DateTimePublished = @DateTimePublished, 
			DateTimeArchived = @DateTimeArchived
			where RecipeId = @RecipeId
	end

	return @return
end
go


