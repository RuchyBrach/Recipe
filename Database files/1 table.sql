-- SM Excellent! 100%
use HeartyHearthdb
go 
drop table if exists MealCourseRecipe
drop table if exists MealCourse 
drop table if exists Course 
drop table if exists Meal 
drop table if exists CookBookRecipe 
drop table if exists CookBook
drop table if exists Direction
drop table if exists RecipeIngredient
drop table if exists MeasType 
drop table if exists Ingredient 
drop table if exists Recipe 
drop table if exists Cuisine 
drop table if exists HHUser
go
create table dbo.HHUser(
    HHUserId int not null identity primary key, 
    FirstName varchar(40) not null constraint ck_HHUser_FirstName_cannot_be_blank check(FirstName <> ''), 
    LastName varchar (40) not null constraint ck_HHUser_Lastname_cannot_be_blank check(LastName <> ''), 
    UserName varchar (100) not null
        constraint u_HHUser_UserName unique
        constraint ck_HHUser_UserName_cannot_be_blank check(UserName <> '')
)
go 

create table dbo.Cuisine(
    CuisineId int not null identity primary key, 
    CuisineName varchar(100) not null 
        constraint u_Cuisine_CuisineName unique 
        constraint ck_Cuisine_CuisineName_cannot_be_blank check (CuisineName > '')
)
go 

create table dbo.Recipe(
    RecipeId int not null identity primary key, 
    HHUserId int not null constraint f_HHUSer_Recipe foreign key references HHUser(HHUserId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId), 
    RecipeName varchar (200) not null 
        constraint u_Recipe_RecipeName unique 
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''), 
    Calories int not null constraint ck_Recipe_Calories_cannot_be_less_than_0 check(Calories >= 0), 
    DateTimeDraft datetime2 not null default getdate() constraint ck_Recipe_DateTimeDraft_cannot_be_greater_current_datetime check(DateTimeDraft <= current_timestamp), 
    DateTimePublished datetime2 constraint ck_Recipe_DateTimePublished_cannot_be_greater_current_datetime check(DateTimePublished <= current_timestamp),     
    DateTimeArchived datetime2 constraint ck_Recipe_DateTimeArchived_cannot_be_greater_current_datetime check(DateTimeArchived <= current_timestamp),
    RecipeStatus as case 
                        when DateTimePublished is null and DateTimeArchived is null then 'Draft'
                        when DateTimePublished is not null and DateTimeArchived is null then 'Published'
                        when DateTimeArchived is not null then 'Archived' 
                    end persisted,
    RecipePic as concat ('Recipe_', replace(RecipeName, ' ', '_'), '.jpg') persisted, 
    constraint ck_DateTimePublished_must_be_between_DateTimeDraft_and_DateTimeArchived check(DateTimePublished between DateTimeDraft and DateTimeArchived), 
    constraint ck_DateTimeArchived_must_be_between_DateTimeDraft_and_Current_timestamp check(DateTimeArchived between DateTimeDraft and current_timestamp), 


)
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key, 
    IngredientName varchar(75) not null 
        constraint u_Ingredient_IngredientName unique 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> ''), 
    IngredientPic as concat ('Ingredient_', replace(IngredientName, ' ', '_'), '.jpg') persisted
)
go 

create table dbo.MeasType(
    MeasTypeId int not null identity primary key, 
    MeasTypeName varchar(50) not null 
        constraint u_MeasType_MeasTypeName unique
        constraint ck_MeasType_MeasTypeName_cannot_be_blank check(MeasTypeName <> '')
)
go 

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key, 
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId), 
    MeasTypeId int constraint f_MeasType_RecipeIngredient foreign key references MeasType(MeasTypeId),  
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId), 
    IngredientSequence int not null constraint ck_RecipeIngredient_IngredientSequence_must_be_greater_than_0 check(IngredientSequence > 0), 
	Qty decimal (10,1) not null constraint ck_RecipeIngredient_Qty_must_be_greater_than_0 check(Qty > 0), 
    constraint u_RecipeIngredient_IngredientId_RecipeId unique(IngredientId, RecipeId), 
    constraint u_RecipeIngredient_RecipeId_IngredientSequence unique(RecipeId, IngredientSequence)
)
go 

create table dbo.Direction(
    DirectionId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_Direction foreign key references Recipe(RecipeId), 
    DirectionSequence int not null constraint ck_Direction_DirectionSequence_must_be_greater_than_0 check(DirectionSequence > 0), 
    Instruction varchar(300) not null constraint ck_Direction_Instruction_cannot_be_blank check(Instruction <> ''), 
    constraint u_Direction_RecipeId_DirectionSequence unique(RecipeId, DirectionSequence)
)
go 

create table dbo.CookBook(
    CookBookId int not null identity primary key, 
    HHUserId int not null constraint f_HHUser_CookBook foreign key references HHUser(HHUserId), 
    CookBookName varchar(150) not null 
        constraint u_CookBook_CookBookName unique 
        constraint ck_CookBook_CookBookName_cannot_be_blank check(CookBookName <> ''), 
    Price Decimal (10,2) not null constraint ck_CookBook_Price_must_be_greater_than_0 check(Price > 0), 
    CookBookDateCreated date not null default getdate() constraint ck_CookBood_CookBookDateCreated_cannot_be_greater_than_current_date check(CookBookDateCreated <= getdate()), 
	CookBookActive bit not null default 1, 
    CookBookPic as concat('CookBook_', replace(CookBookName, ' ', '_'), '.jpg') persisted
	
)
go 

create table dbo.CookBookRecipe(
    CookBookRecipeId int not null identity primary key, 
    CookBookId int not null constraint f_CookBook_CookBookRecipe foreign key references CookBook(CookBookId), 
    RecipeId int not null constraint f_Recipe_CookBookRecipe foreign key references Recipe(RecipeId), 
    RecipeSequence int not null constraint ck_CookBookRecipe_RecipeSequence_must_be_greater_than_0 check(RecipeSequence > 0), 
    constraint u_CookBookRecipe_RecipeId_CookBookId unique(RecipeId, CookBookId), 
    constraint u_CookBookRecipe_CookBookId_RecipeSequence unique(CookBookId, RecipeSequence)
)
go 

create table dbo.Meal(
    MealId int not null identity primary key, 
    HHUserId int not null constraint f_HHUser_Meal foreign key references HHUser(HHUserId), 
    MealName varchar(25) not null 
        constraint u_Meal_MealName unique 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> ''), 
    MealDateCreated date not null default getdate() constraint ck_Meal_MealDateCreated_cannot_be_greater_than_current_date check(MealDateCreated <= getdate()), 
    MealActive bit not null default 1, 
    MealPic as concat('Meal_', replace(MealName, ' ', '_'), '.jpg') persisted 
)
go 

create table dbo.Course(
    CourseId int not null identity primary key, 
    CourseName varchar(30) not null 
        constraint u_Course_CourseName unique 
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> ''), 
    CourseSequence int not null 
        constraint u_Course_CourseSequence unique 
        constraint ck_Course_CourseSequence_must_be_greater_than_0 check(CourseSequence > 0)
)
go 

create table dbo.MealCourse(
    MealCourseId int not null identity primary key, 
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId), 
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseID), 
    constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)
go 

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key, 
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId), 
    RecipeId int not null constraint f_MealCourseRecipe_Recipe foreign key references Recipe(Recipeid), 
    SideDish bit not null,
constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)
go  
