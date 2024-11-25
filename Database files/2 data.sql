-- SM Excellent! See comment.
use HeartyHearthdb 
go 

delete MealCourseRecipe
delete MealCourse
delete Course 
delete Meal 
delete CookBookRecipe 
delete CookBook 
delete Direction 
delete RecipeIngredient
delete MeasType 
delete Ingredient 
delete Recipe 
delete Cuisine 
delete HHUser 
go

insert HHUser(FirstName, LastName, UserName)
select 'David', 'Miller', 'David Miller'
union select 'Joseph', 'Brown', 'Joseph Brown'
union select 'Sarah', 'Baker', 'Sarah Baker'

insert Cuisine(CuisineName)
select 'American'
union select 'French' 
union select 'English'

;with x as(
    select UserName = 'David Miller', CuisineName = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 50, DateTimeDraft = CURRENT_TIMESTAMP - 10, DateTimePublished = null, DateTimeArchived = null
    union select 'David Miller', 'French', 'Apple Yogurt Smoothie', 75, CURRENT_TIMESTAMP - 10, CURRENT_TIMESTAMP - 8, null
    union select 'Sarah Baker', 'English', 'Cheese Bread', 100, CURRENT_TIMESTAMP -11, CURRENT_TIMESTAMP - 10, CURRENT_TIMESTAMP - 1
    union select 'Sarah Baker', 'American', 'Butter Muffins', 150, CURRENT_TIMESTAMP - 150, null, CURRENT_TIMESTAMP - 120
)
insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived
from x 
join HHUser h
on h.UserName = x.UserName
join Cuisine c 
on c.CuisineName = x.CuisineName

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Egg'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apple'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice'
union select 'Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Garlic (Crushed)'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'

insert MeasType(MeasTypeName)
select 'Cup'
union select 'tsp'
union select 'tbsp'
union select 'Club'
union select 'Oz'
union select 'Clove'
union select 'Pinch of'
union select 'Stick'
union select 'Cube'

-- SM Tip: join to recipe join to ingredient and then left join to measurement. That's the only one that needs left join.
;with x as(
    select IngredientName = 'Sugar', MeasTypeName = 'Cup', RecipeName = 'Chocolate Chip Cookies', IngredientSequence = 1, Qty = 1
    union select 'Oil', 'Cup', 'Chocolate Chip Cookies', 2, .5
    union select 'Egg', null, 'Chocolate Chip Cookies', 3, 3
    union select 'Flour', 'Cup', 'Chocolate Chip Cookies', 4, 2
    union select 'Vanilla Sugar', 'tsp', 'Chocolate Chip Cookies', 5, 1
    union select 'Baking Powder', 'tsp', 'Chocolate Chip Cookies', 6, 2
    union select 'Baking Soda', 'tsp', 'Chocolate Chip Cookies', 7, .5
    union select 'Chocolate Chips', 'Cup', 'Chocolate Chip Cookies', 8, 1
    union select 'Granny Smith Apple', null, 'Apple Yogurt Smoothie', 1, 3
    union select 'Vanilla Yogurt', 'Cup', 'Apple Yogurt Smoothie', 2, 2
    union select 'Sugar', 'tsp', 'Apple Yogurt Smoothie', 3, 2
    union select 'Orange Juice', 'Cup', 'Apple Yogurt Smoothie', 4, .5
    union select 'Honey', 'tbsp', 'Apple Yogurt Smoothie', 5, 2
    union select 'Ice', 'Cube', 'Apple Yogurt Smoothie', 6, 5.5
    union select 'Bread', 'Club', 'Cheese Bread', 1, 1
    union select 'Butter', 'Oz', 'Cheese Bread', 2, 4
    union select 'Shredded Cheese', 'Oz', 'Cheese Bread', 3, 8
    union select 'Garlic (Crushed)', 'Clove', 'Cheese Bread', 4, 2
    union select 'Black Pepper', 'tsp', 'Cheese Bread', 5, .25
    union select 'Salt', 'Pinch of', 'Cheese Bread', 6, 1
    union select 'Butter', 'Stick', 'Butter Muffins', 1, 1
    union select 'Sugar', 'Cup', 'Butter Muffins', 2, 3
    union select 'Vanilla Pudding', 'tbsp', 'Butter Muffins', 3, 2
    union select 'Egg', null, 'Butter Muffins', 4, 4
    union select 'Whipped Cream Cheese', 'Oz', 'Butter Muffins', 5, 8
    union select 'Sour Cream Cheese', 'Oz', 'Butter Muffins', 6, 8
    union select 'Flour', 'Cup', 'Butter Muffins', 7, 1
    union select 'Baking Powder', 'tsp', 'Butter Muffins', 8, 2
)
insert RecipeIngredient(IngredientId, MeasTypeId, RecipeId, IngredientSequence, Qty)
select i.IngredientId, mt.MeasTypeId, r.RecipeId, x.IngredientSequence, x.Qty 
from x 
join Ingredient i 
on i.IngredientName = x.IngredientName
left join MeasType mt
on mt.MeasTypeName = x.MeasTypeName
left join Recipe r 
on r.RecipeName = x.RecipeName 

;with x as(
    select RecipeName = 'Chocolate Chip Cookies', DirectionSequence = 1, Instruction = 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'mix well'
    union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes.'
    )
insert Direction(RecipeId, DirectionSequence, Instruction)
select RecipeId, DirectionSequence, Instruction
from x 
join Recipe r 
on r.RecipeName = x.RecipeName

;with x as(
    select UserName = 'David Miller', CookBookName = 'Treats For Two', Price = 30.00, CookBookDateCreated = '02/02/2022', CookBookActive = 1
    union select 'Sarah Baker', 'A Taste of Home', 29.99, '03/03/2023', 1 
    union select 'Sarah Baker', 'Behind the Kitchen Doors', 45.99, '04/04/2013', 0
)
insert CookBook(HHUserId, CookBookName, Price, CookBookDateCreated, CookBookActive)
select HHUserId, CookBookName, Price, CookBookDateCreated, CookBookActive
from x 
join HHUser h 
on h.UserName = x.UserName

;with x as(
    select CookBookName = 'Treats For Two', RecipeName = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select 'Treats For Two', 'Apple Yogurt Smoothie', 2
    union select 'Treats For Two', 'Cheese Bread', 3
    union select 'Treats For Two', 'Butter Muffins', 4
    union select 'A Taste of Home', 'Apple Yogurt Smoothie', 1 
    union select 'A Taste of Home', 'Butter Muffins', 2
    union select 'Behind the Kitchen Doors', 'Cheese Bread', 1 
    union select 'Behind the Kitchen Doors', 'Chocolate Chip Cookies', 2
)
insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
select CookBookId, RecipeId, RecipeSequence
from x 
join CookBook c 
on c.CookBookName = x.CookBookName
join Recipe r 
on r.RecipeName = x.RecipeName

;with x as(
    select UserName = 'Joseph Brown', MealName = 'Breakfast Bash', MealDateCreated = '02/02/2022', MealActive = 1
    union select 'David Miller', 'Lunch', '03/03/2023', 1 
    union select 'David Miller', 'Midnight Snack', '04/04/2023', 0
)
insert Meal(HHUserId, MealName, MealDateCreated, MealActive)
select HHUserId, MealName, MealDateCreated, MealActive 
from x 
join HHUser h 
on x.UserName = h.UserName

insert Course(CourseName, CourseSequence)
select 'Main Course', 2
union select 'Appetizer', 1
union select 'Dessert', 3

;with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Main Course'
    union select 'Breakfast Bash', 'Appetizer'
    union select 'Lunch', 'Main Course'
    union select 'Lunch', 'Appetizer'
    union select 'Midnight snack', 'Dessert'
)
insert MealCourse(MealId, CourseId)
select MealId, CourseId
from x 
join Meal m 
on m.MealName = x.MealName 
join Course c 
on c.CourseName = x.CourseName


;with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Main Course', RecipeName = 'Cheese Bread', SideDish = 0
    union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 1
    union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Lunch', 'Main Course', 'Cheese Bread', 0
    union select 'Lunch', 'Appetizer', 'Apple Yogurt Smoothie', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, SideDish)
select MealCourseId, RecipeId, SideDish
from x 
join Meal m 
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
join MealCourse mc 
on c.CourseId = mc.CourseId 
and m.MealId = mc.MealId
join Recipe r 
on r.RecipeName = x.RecipeName

select * from HHUser 
select * from Cuisine 
select * from Recipe 
select * from Ingredient 
select * from MeasType 
select * from RecipeIngredient
select * from Direction 
select * from CookBook 
select * from CookBookRecipe 
select * from Meal 
select * from Course 
select * from MealCourse 
select * from MealCourseRecipe