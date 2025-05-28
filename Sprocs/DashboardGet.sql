create or alter proc dbo.RecipeDashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select DashboardType = 'Recipe', DashboardCount = count(*)
	from Recipe r
	union select DashboardType = 'Meal', DashboardCount = count(*)
	from Meal m
	union select DashboardType = 'Cookbook', DashboardCount = count(*)
	from CookBook c 
	return @return
end
go 
exec RecipeDashboardGet