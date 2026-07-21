create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @CuisineName varchar(100) = '', @All bit = 0, @IncludeBlank bit = 0)
as
begin 
	select @CuisineName = nullif(@CuisineName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select c.CuisineId, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineId
	or c.CuisineName like '%' + @CuisineName + '%'
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1
	order by c.CuisineName, c.CuisineId
end
go

/*
Declare @Name varchar(100)
select top 1 @Name = c.CuisineName from Cuisine c order by c.CuisineName
exec CuisineGet @CuisineName = @Name

exec CuisineGet @CuisineName = ''
exec CuisineGet @CuisineName = '', @All = 1
exec CuisineGet @CuisineName = null

exec CuisineGet @All = 1

declare @Id int
select top 1 @Id = c.CuisineId from Cuisine c order by c.CuisineId
exec CuisineGet @CuisineId = @Id
*/