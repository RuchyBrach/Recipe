create or alter proc dbo.CuisineUpdate(@CuisineId int output, @CuisineName varchar(100), @Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @CuisineId = isnull(@CuisineId, 0)
	if @CuisineId = 0
	begin
		insert Cuisine(CuisineName)
		select @CuisineName
		select @CuisineId = SCOPE_IDENTITY()
	end
	else
	begin 
	update Cuisine
	set 
		CuisineName = @CuisineName
	where CuisineId = @CuisineId
	end

	return @return
end
go