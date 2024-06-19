-- SM Excellent! See comments, no need to resubmit.
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
--+

delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc 
on mc.MealCourseId = mcr.MealCourseId
join Meal m 
on m.MealId = mc.MealId 
join Recipe r 
on r.RecipeId = mcr.RecipeId
join HHUser h 
on h.HHUserId = r.HHUserId
or h.HHUserId = m.HHUserId
where h.UserName = 'Joseph Brown'

delete mc 
from MealCourse mc 
join Meal m 
on m.MealId = mc.MealId
join HHUser h 
on h.HHUserId = m.HHUserId
where h.UserName = 'Joseph Brown' 

delete m 
from Meal m 
join HHUser h 
on h.HHUserId = m.HHUserId
where h.UserName = 'Joseph Brown'

delete cbr 
from CookBookRecipe cbr 
join Recipe r 
on r.RecipeId = cbr.RecipeId 
join CookBook cb 
on cb.CookBookId = cbr.CookBookId 
join HHUser h 
on h.HHUserId = r.HHUserId 
and h.HHUserId = cb.HHUserId
where h.UserName = 'Joseph Brown'

delete cb 
from CookBook cb 
join HHUser h 
on cb.HHUserId = h.HHUserId
where h.UserName = 'Joseph Brown'

delete d 
from Direction d 
join Recipe r 
on r.RecipeId = d.RecipeId 
join HHUser h 
on h.HHUserId = r.HHUserId
where h.UserName = 'Joseph Brown'

delete ri
from Recipeingredient ri 
join Recipe r 
on r.RecipeId = ri.RecipeId
join HHUser h 
on H.HHUserId = r.HHUserId
where h.UserName = 'Joseph Brown'

delete r 
from Recipe r 
join HHUser h 
on r.HHUserId = h.HHUserId
where h.UserName = 'Joseph Brown'

delete h 
from HHUser h
where h.UserName = 'Joseph Brown'
--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
--+
insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select r.HHUserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.Calories, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived
from Recipe r 
where r.RecipeName = 'Cheese Bread'

;with x as(
	select i.IngredientId, mt.MeasTypeId, ri.IngredientSequence, ri.Qty 
	from RecipeIngredient ri
	join Ingredient i 
	on i.IngredientId = ri.IngredientId
	join MeasType mt 
	on mt.MeasTypeId = ri.MeasTypeId
	join Recipe r 
	on r.RecipeId = ri.RecipeId
	where r.RecipeName = 'Cheese Bread'
)
insert RecipeIngredient(IngredientId, MeasTypeId, RecipeId, IngredientSequence, Qty)
select x.IngredientId, x.MeasTypeId, r.RecipeId, x.IngredientSequence, x.Qty
from x 
cross join Recipe r
-- SM Tip: Use concat(recipename from CTE, - clone)
where r.RecipeName = 'Cheese Bread - clone'

;with x as(
	select d.DirectionSequence, d.Instruction
	from Direction  d
	join Recipe r 
	on r.RecipeId = d.RecipeId
	where r.RecipeName = 'Cheese Bread'
)
insert Direction(RecipeId, DirectionSequence, Instruction)
select r.RecipeId, x.DirectionSequence, x.Instruction
from x 
cross join Recipe r 
-- SM Tip: Use recipe returned from CTE and use where recipename = concat()
where r.RecipeName = 'Cheese Bread - clone'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
--+
;with x as(
	select h.UserName, h.HHUseriD, NumRecipes = count(r.RecipeId) *1.33
	from Recipe r 
	join HHUser h 
	on h.HHUserId = r.HHUserId
	where h.UserName = 'Sarah Baker'
	group by h.UserName, h.HHUserId
)
insert CookBook(HHUserId, CookBookName, Price, CookBookDateCreated, CookBookActive)
select x.HHUserId, concat('Recipes by ', h.FirstName, ' ', h.LastName), x.NumRecipes, getdate(), 1
from x 
join HHUser h 
on h.UserName = x.UserName 
and h.HHUserId = x.HHUserId

;with x as(
	select cb.CookBookId, cb.CookBookName, r.RecipeId, r.RecipeName
	from CookBook cb 
	join HHUser h 
	on h.HHuserId = cb.HHUserId
	join Recipe r 
	on h.HHUserId = r.HHUserId
	where h.UserName = 'Sarah Baker'
	and cb.CookBookName = 'Recipes by Sarah Baker'
)
insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
select x.CookBookId, x.RecipeId, ROW_NUMBER() over (order by x.RecipeName)
from x 

/*
4) Sometimes the calorie count of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
--+
update r 
set calories = case 
	when mt.MeasTypeName = 'Cup' then r.Calories - (5 * ri.Qty) 
	when mt.MeasTypeName = 'Tsp' then r.Calories - (1 * ri.Qty) end
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join MeasType mt 
on mt.MeasTypeId = ri.MeasTypeId
join Ingredient i 
on i.IngredientId = ri.IngredientId
where i.IngredientName = 'Sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;with x as(
	select AvgInDraft = avg(datediff(hour, r.DateTimeDraft, r.DateTimePublished))
	from Recipe r
)
select h.FirstName, 
h.LastName,
Email = concat(substring(h.FirstName, 1, 1), h.LastName, '@heartyHearth.com'),
Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateTimeDraft, CURRENT_TIMESTAMP), ' hours.
		That is ', datediff(hour, r.DateTimeDraft, CURRENT_TIMESTAMP) - x.AvgInDraft, ' hours more than the average ', x.AvgInDraft, ' hours all other recipes took to be published.')
from HHUser h 
join Recipe r 
on r.HHUserId = h.HHUserId 
cross join x 
where  r.RecipeStatus = 'Draft'
and x.AvgInDraft < datediff(hour, r.DateTimeDraft, CURRENT_TIMESTAMP)

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
--+
;with x as(
	select NumBooks = count(cb.CookBookId), AvgPrice = cast(avg(cb.Price) as decimal(10,2)), TotalPriceDiscounted = cast(sum(cb.Price) * .75 as decimal(10,2))
	from CookBook cb 
)
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', x.NumBooks, ' books for sale, average price is ', x.AvgPrice, '. You can order them all and recieve a 25% discount, for a total of ', x.TotalPriceDiscounted, '.
Click <a href = "www.heartyhearth.com/order/', NEWID(), '">here</a> to order.')
from x 