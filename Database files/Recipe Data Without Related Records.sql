
;with x as(
    select UserName = 'Sarah Baker', CuisineName = 'English', RecipeName = 'New Recipe', Calories = 10, DateTimeDraft = CURRENT_TIMESTAMP, DateTimePublished = null, DateTimeArchived = null 
)
insert recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived
from x 
join HHUser h 
on h.UserName = x.UserName 
join Cuisine c 
on c.CuisineName = x.CuisineName

select * from Recipe r