alter table Recipe add Vegan bit not null default 0
go
alter table Meal add MealDesc varchar(500) not null default ''
go
alter table CookBook add CookBookSkill int not null default 1, 
CookBookSkillDesc as 
case CookBookSkill
when 1 then 'Beginner'
when 2 then 'Intermediate'
when 3 then 'Advanced'
end persisted
go


