;with x as(
	select 'Breakfast Bash' As MealName, 
	'A hearty morning spread packed with energizing favorites to kick off your day.' as MealDesc
	union select 'Lunch', 
	'A satisfying midday meal designed to refuel and keep you going strong.'
	union select 'Midnight Snack',
	'A light, quick bite for those late-night cravings.'
)
update m
set m.MealDesc = x.MealDesc
from Meal m 
join x on m.MealName = x.MealName
go

;with x as(
	select 'Chocolate Chip Cookies' as RecipeName,
	1 as Vegan
	union select 'Butter Muffins', 
	1
)
update r
set r.Vegan = x.Vegan
from recipe r
join x on r.RecipeName = x.RecipeName
go

;with x as(
	select 'A Taste of Home' as CookBookName,
	2 as CookBookSkill
	union select 'Behind the Kitchen Doors',
	3
)
update c 
set c.CookBookSkill = x.CookBookSkill
from CookBook c 
join x on c.CookBookName = x.CookBookName
go