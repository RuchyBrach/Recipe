create or alter proc dbo.HHUserUpdate(
	@HHUserId int output, 
	@FirstName varchar(50),
	@LastName varchar(50),
	@UserName varchar(100),
	@Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	select @HHUserId = isnull(@HHUserId, 0)
	if @HHUserId = 0
	begin
		insert HHUser(FirstName, LastName, UserName)
		select @FirstName, @LastName, @UserName
		select @HHUserId = SCOPE_IDENTITY()
	end
	else
	begin 
	update HHUser
	set 
		FirstName = @FirstName,
		LastName = @LastName,
		UserName = @UserName
	where HHUserId = @HHUserId
	end

	return @return
end
go