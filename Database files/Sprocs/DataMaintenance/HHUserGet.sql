create or alter procedure dbo.HHUserGet(@HHUserId int = 0, @LastName varchar(40) = '', @All bit = 0, @IncludeBlank bit = 0)
as
begin 
	select @LastName = nullif(@LastName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select h.HHUserId, h.FirstName, h.LastName, h.UserName
	from HHUser h 
	where h.HHUserId = @HHUserId
	or h.LastName like '%' + @LastName + '%'
	or @All = 1
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by h.LastName
end
go

/*
Declare @Name varchar(40)
select top 1 @Name = h.LastName from HHUser h order by h.LastName, h.FirstName
exec HHUserGet @LastName = @Name

exec HHUserGet @LastName = ''
exec HHUserGet @LastName = '', @All = 1
exec HHUserGet @LastName = null

exec HHUserGet @All = 1

declare @Id int
select top 1 @Id = h.HHUserId from HHUser h order by h.HHUserId
exec HHUserGet @HHUserId = @Id
*/

