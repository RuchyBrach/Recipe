-- SM Excellent! See comments, no need to resubmit.
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
--+
    select Item = 'Recipe', AmountRecipes = count(r.RecipeId)
    from Recipe r 
    union select 'Meal', AmountMeals = count(m.MealId)
    from Meal m 
    union select 'Cookbook', AmountCookBooks = count(cb.CookBookId)
    from CookBook cb

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
--+
select RecipeName = case when r.DateTimeArchived is not null then concat('<span style="color:gray">', r.recipename, '</span>') else r.RecipeName end, r.RecipeStatus, DateTimePublished = isnull(convert(varchar, r.DateTimePublished, 101 ), ' '), DateTimeArchived = isnull(convert(varchar, r.DateTimeArchived, 101), ''), h.UserName, r.Calories, AmountIngredients = count(ri.IngredientId)
from Recipe r 
join  HHUser h 
on r.HHUserId = h.HHUserId
join  RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.DateTimePublished is not null or r.DateTimeArchived is not null
group by r.RecipeName, r.DateTimePublished, r.DateTimeArchived, r.RecipeStatus, h.UserName, r.Calories
order by r.DateTimeArchived 

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--+
--a
select r.RecipeName, r.Calories, NumIngredients = count(distinct ri.IngredientId), NumDirections = count(distinct d.DirectionId), r.RecipePic
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Direction d 
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.RecipePic, r.Calories

--b
select IngredientsInRecipe = concat(ri.Qty, case when mt.MeasTypeName is not null then ' ' else '' end, mt.MeasTypeName, ' ', i.IngredientName)
from Ingredient i 
join  RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
left join  MeasType mt 
on mt.MeasTypeId = ri.MeasTypeId
left join  Recipe r 
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence
--c
select d.Instruction, d.DirectionSequence
from Direction d
join  Recipe r 
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by d.DirectionSequence

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
--+
select m.MealName, h.UserName, TotalCalories = sum(distinct r.Calories), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(distinct mcr.RecipeId)
from Meal m 
join HHUser h 
on h.HHUserId = m.HHUserId 
join MealCourse mc 
on mc.MealId = m.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.MealActive = 1
group by m.MealName, h.UserName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--+
--a
select m.MealName, h.UserName, m.MealDateCreated, m.MealPic
from Meal m 
join  HHUser h 
on m.HHUserId = h.HHUserId
where m.MealName = 'Lunch'
--b
select CourseRecipe = concat(case when mcr.SideDish = 0 and c.CourseName = 'Main Course' then '<b>' else '' end, c.CourseName, ': ', 
-- SM Tip: You can use nested case here.
                            case when mcr.SideDish = 0 and c.CourseName = 'Main Course' then 'Main Dish - ' 
                            when mcr.SideDish  = 1 and c.CourseName = 'Main Course' then 'Side Dish - ' else '' end, r.RecipeName, 
                            case when mcr.SideDish = 0 and c.CourseName = 'Main Course' then '<b>' else '' end)
from Recipe r 
join  MealCourseRecipe mcr 
on r.RecipeId = mcr.RecipeId 
join  MealCourse mc 
on mc.MealCourseId = mcr.MealCourseId
join  Course c 
on c.CourseId = mc.CourseId
join  Meal m 
on m.MealId = mc.MealId
where m.MealName = 'Lunch'

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
--+
select cb.CookBookName, h.UserName, NumRecipes = count(cbr.RecipeId)
from CookBook cb 
join  HHUser h 
on h.HHUserId = cb.HHUserId 
join  CookBookRecipe cbr 
on cb.cookBookId = cbr.CookBookId
where cb.CookBookActive = 1
group by cb.cookBookId, cb.CookBookName, h.UserName
order by cb.CookBookName 

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--+
--a
select cb.CookBookName, h.UserName, cb.CookBookDateCreated, cb.Price, NumRecipes = count(cbr.RecipeId), cb.CookBookPic
from CookBook cb
join  HHUser h 
on h.HHUserId = cb.HHUserId
join  CookBookRecipe cbr 
on cb.CookBookId = cbr.CookBookId
where cb.CookBookName = 'A Taste of Home'
group by cb.CookBookId, cb.CookBookName, h.UserName, cb.CookBookDateCreated, cb.Price, cb.CookBookPic
--b
select r.RecipeName, cu.CuisineName, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct d.DirectionId), cb.CookBookPic
from CookBook cb 
join CookBookRecipe cbr 
on cb.CookBookId = cbr.CookBookId 
join Recipe r 
on r.RecipeId = cbr.RecipeId
join Cuisine cu 
on cu.CuisineId = r.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Direction d 
on r.RecipeId = d.RecipeId
where cb.CookBookName = 'A Taste of Home'
group by r.RecipeName, cu.CuisineName, cb.CookBookPic, cbr.RecipeSequence
order by cbr.RecipeSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a
--+
select distinct
    ReversedRecipeName = concat(substring(reverse(upper(r.RecipeName)), 1, 1), substring(reverse(lower(r.RecipeName)), 2, 200)),
    ReversedRecipePic = concat('Recipe_', substring(reverse(upper(replace(RecipeName, ' ', '_'))), 1, 1), substring(reverse(lower(replace(RecipeName, ' ', '_'))), 2, 200), '.jpg')
from Recipe r 
join CookBookRecipe cbr 
on r.RecipeId = cbr.RecipeId

--b
--+
;with x as(
    select LastStep = max(d.DirectionSequence), d.RecipeId
    from Direction d 
    group by d.RecipeId
) 
select d.Instruction
from x 
join  Direction d 
on d.RecipeId = x.RecipeId
where d.DirectionSequence = x.LastStep
/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a
--+
select h.UserName, RecipeStatus = isnull(r.RecipeStatus, ' '), NumRecipes = count(r.RecipeId)
from HHUser h 
left join  Recipe r 
on h.HHUserId = r.HHUserId
group by h.UserName, r.RecipeStatus
--b
--+
select h.UserName, NumRecipesPerUser = count(r.RecipeId), AvgDaysToPublish = isnull(avg(Datediff(day, r.DateTimeDraft, r.DateTimePublished)), 0)
from HHUser h 
left join Recipe r 
on h.HHuseriD = r.HHuserId
group by h.HHUserId, h.UserName
--c
--
select 
    h.UserName, 
    TotalMeals = count(m.MealId), 
    NumActiveMeals = sum(case when m.MealActive = 1 then 1 else 0 end),
    NumInactiveMeals = sum(case when m.MealActive = 0 then 1 else 0 end)
from HHUser h 
left join Meal m 
on h.HHUserId = m.HHUserId
group by h.UserName

--d
select 
    h.UserName, 
    TotalCookBooks = count(cb.CookBookId), 
    NumActiveCookBooks = sum(case when cb.CookBookActive = 1 then 1 else 0 end), 
    NumInactiveCookBooks = sum(case when cb.CookBookActive = 0 then 1 else 0 end)
from HHUser h 
left join CookBook cb 
on h.HHUserId = cb.HHUserId
group by h.UserName

--e
--+
select r.RecipeName, DaysToArchive = Datediff(day, r.DateTimeDraft, r.DateTimeArchived)
from Recipe r 
where r.DateTimePublished is null and r.DateTimeArchived is not null
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
--+
--a
select ItemType = 'Recipe', Count = count(r.RecipeId)
from HHuser h 
join  Recipe r 
on h.HHUserId = r.HHUserId
where h.UserName = 'David Miller'
union select 'Meal', count(m.MealId)
from HHuser h 
join  Meal m 
on h.HHUserId = m.HHUserId
where h.UserName = 'David Miller'
union select 'CookBook', count(cb.CookBookId)
from HHuser h 
join  CookBook cb 
on h.HHUserId = cb.HHUserId
where h.UserName = 'David Miller'
--b
-- SM Tip: Instead of doing and, you can use isnull()
select h.UserName, r.RecipeName, r.RecipeStatus, 
DiffHour = datediff(hour, case when r.DateTimePublished is not null and r.DateTimeArchived is not null then r.DateTimePublished else r.DateTimeDraft end, case when r.DateTimePublished is not null and r.DateTimeArchived is not null then r.DateTimeArchived else r.DateTimePublished end
)
from HHuser h   
join  Recipe r 
on h.HHUserId = r.HHUserId
where h.UserName = 'David Miller'
and r.RecipeStatus <> 'Draft'

--c
;with x as(
    select h.UserName, cu.CuisineName
    from Cuisine cu 
    join  Recipe r 
    on cu.CuisineId = r.CuisineId
    join  HHuser h 
    on r.HHUserId = h.HHUserId
    where h.UserName = 'David Miller'
)
select cu.CuisineName, NumRecipes = count(x.CuisineName)
from Cuisine cu 
left join x 
on x.CuisineName = cu.CuisineName
group by cu.CuisineName 