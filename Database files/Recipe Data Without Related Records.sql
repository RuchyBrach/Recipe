use HeartyHearthdb
go 
;with x as (
    select UserName = 'David Miller', CuisineName = 'American', RecipeName = 'New Recipe', Calories = 75, DateTimeDraft = CURRENT_TIMESTAMP - 7, DateTimePublished = null, DateTimeArchived = null

)
insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived 
from x 
join HHUser h 
on x.UserName = h.UserName
join Cuisine c 
on x.CuisineName = c.CuisineName