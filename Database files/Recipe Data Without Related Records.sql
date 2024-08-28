use HeartyHearthdb 
go

Drop table if exists JustRecipe
go 
create table dbo.JustRecipe(
    RecipeId int not null identity primary key, 
    RecipeName varchar (200) not null 
        constraint u_JustRecipe_RecipeName unique 
        constraint ck_JustRecipe_RecipeName_cannot_be_blank check(RecipeName <> ''), 
    Calories int not null constraint ck_JustRecipe_Calories_cannot_be_less_than_0 check(Calories >= 0), 
    DateTimeDraft datetime2 not null default getdate() constraint ck_JustRecipe_DateTimeDraft_cannot_be_greater_current_datetime check(DateTimeDraft <= current_timestamp), 
    DateTimePublished datetime2 constraint ck_JustRecipe_DateTimePublished_cannot_be_greater_current_datetime check(DateTimePublished <= current_timestamp),     
    DateTimeArchived datetime2 constraint ck_JustRecipe_DateTimeArchived_cannot_be_greater_current_datetime check(DateTimeArchived <= current_timestamp),
    RecipeStatus as case 
                        when DateTimePublished is null and DateTimeArchived is null then 'Draft'
                        when DateTimePublished is not null and DateTimeArchived is null then 'Published'
                        when DateTimeArchived is not null then 'Archived' 
                    end persisted,
    RecipePic as concat ('Recipe_', replace(RecipeName, ' ', '_'), '.jpg') persisted, 
    constraint ck_JustRecipe_DateTimePublished_must_be_between_DateTimeDraft_and_DateTimeArchived check(DateTimePublished between DateTimeDraft and DateTimeArchived), 
    constraint ck_JustRecipe_DateTimeArchived_must_be_between_DateTimeDraft_and_Current_timestamp check(DateTimeArchived between DateTimeDraft and current_timestamp), 
)
go

Delete JustRecipe

insert JustRecipe(RecipeName, Calories, DateTimeDraft, DateTimePublished, DateTimeArchived)
select 'Chocolate Chip Cookies', 50, CURRENT_TIMESTAMP - 10, null, null
union select 'Apple Yogurt Smoothie', 75, CURRENT_TIMESTAMP - 10, CURRENT_TIMESTAMP - 8, null
union select 'Cheese Bread', 100, CURRENT_TIMESTAMP -11, CURRENT_TIMESTAMP - 10, CURRENT_TIMESTAMP - 1
union select 'Butter Muffins', 150, CURRENT_TIMESTAMP - 15, null, CURRENT_TIMESTAMP - 12

