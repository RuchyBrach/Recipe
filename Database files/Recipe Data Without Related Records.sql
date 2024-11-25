use HeartyHearthdb
go 
;with x as (
    select UserName = 'David Miller', CuisineName = 'American', RecipeName = 'recipe archived > 30 days', Calories = 75, DateTimeDraft = CURRENT_TIMESTAMP - 400, DateTimePublished = null, DateTimeArchived = CURRENT_TIMESTAMP - 399
    union select UserName = 'David Miller', CuisineName = 'American', RecipeName = 'recipe status = draft', Calories = 75, DateTimeDraft = CURRENT_TIMESTAMP - 400, DateTimePublished = null, DateTimeArchived = null
    union select UserName = 'David Miller', CuisineName = 'American', RecipeName = 'recipe status = published', Calories = 75, DateTimeDraft = CURRENT_TIMESTAMP - 400, DateTimePublished = CURRENT_TIMESTAMP -300, DateTimeArchived = null



)
insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived 
from x 
join HHUser h 
on x.UserName = h.UserName
join Cuisine c 
on x.CuisineName = c.CuisineName

