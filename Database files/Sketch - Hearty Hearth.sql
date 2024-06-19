-- SM Excellent! See comments. I think you can start creating the DB. Good luck!!!
/*
HHUser:
Id pk
FirstName varchar(40)
LastName varchar(40) 
UserName varchar(100) unique

Cuisine:
Id pk
CuisineName varchar(100) not null unique

Recipe:
Id pk
HHUserId int (fk User)
CuisineId int (fk Cuisine)
RecipeName varchar(200) unique
Calories int
DateTimeDraft datetime constraint cannot be > current datetime
DateTimePublished datetime constraint cannot be > current datetime
DateTimeArchived datetime constraint cannot be > current datetime
RecipeStatus as 
    case when DateTimePublished and DateTimeArchived is null then 'Draft'
         when DateTimePublished is not null and DateTimeArchived is null then 'Active'
         when DateTimeArchived is not null then 'Archived'
RecipePic as concat ('Recipe_', RecipeName, '.jpeg')         
constraint ck DateTimePublished > DateTimeDraft
constraint ck DateTime Archived > DateTimeDraft
constraint ck DateTimeArchived > DateTimePublished 

Ingredient:
Id pk
IngredientName varchar(75) unique
IngredientPic as concat ('Ingredient_', IngredientName, '.jpeg')       

MeasType:
Id pk
MeasTypeName varchar(50) unique 

IngredientRecipe:
Id pk
IngredientId int (fk Ingredient)
MeasTypeId int (fk MeasType)
RecipeId int (fk Recipe)
IngredientSequence int
Qty int
unique IngredientId and RecipeId
unique RecipeId and IngredientSequenceId

Direction:
Id pk
RecipeId int (fk Recipe)
DirectionSequence int
Instruction varchar (300)
unique RecipeId and DirectionSequence

CookBook:
Id pk
HHUserId int (fk User)
CookBookName varchar(150) unique
Price decimal (10,2)
CookBookDateCreated date constraint cannot be > getdate()
-- SM The date can never be null. This should be a normal column and because there are only 2 values use bit column and column name should be question sounding so it should make sense a true/false answer.
CookBookActive bit 
CookBookPic as concat ('CookBook_', CookBookName, '.jpeg')       

CookBookRecipe:
Id pk
CookBookId int (fk CookBook)
RecipeId int (fk Recipe)
RecipeSequence int 
unique RecipeId and CookBookId
unique RecipeId and RecipeSequence

Meal:
Id pk
HHUserId int (fk User)
MealName varchar(25) unique
MealDateCreated date constraint cannot be > getdate()
-- SM See my comment on cookbook.
MealActive bit
MealPic as concat ('Meal_', MealName, '.jpeg')       

Course:
Id pk
CourseName varchar(30) unique
CourseSequence int unique

MealCourse:
Id pk
MealId int (fk Meal)
CourseId int (fk Course)
unique MealId & CourseId

MealCourseRecipe:
Id pk
MealCourseId int (fk MealCourse)
RecipeId int (fk Recipe)
SideDish bit

*/

