use HeartyHearthdb
go
--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on RecipeStatusUpdate to approle
grant execute on RecipeGet to approle
grant execute on CuisineGet to approle
grant execute on HHUserGet to approle
grant execute on RecipeListGet to approle
grant execute on CourseGet to approle
grant execute on RecipeDirectionUpdate to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on CookBookRecipeUpdate to approle
grant execute on RecipeDirectionGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on MeasTypeDelete to approle
grant execute on CuisineDelete to approle
grant execute on HHUserDelete to approle
grant execute on IngredientDelete to approle
grant execute on CourseDelete to approle
grant execute on MeasTypeUpdate to approle
grant execute on IngredientUpdate to approle
grant execute on CuisingUpdate to approle
grant execute on HHUserUpdate to approle
grant execute on CourseUpdate to approle
grant execute on CuisineUpdate to approle
grant execute on RecipeDirectionDelete to approle
grant execute on RecipeIngredientDelete to approle
grant execute on CookBookRecipeDelete to approle
grant execute on IngredientGet to approle
grant execute on MeasTypeGet to approle
grant execute on RecipeClone to approle
grant execute on DirectionUpdate to approle
grant execute on DirectionGet to approle
grant execute on CookBookListGet to approle
grant execute on CookBookAutoCreate to approle
grant execute on RecipeUpdate to approle
grant execute on DirectionDelete to approle
grant execute on CookBookUpdate to approle
grant execute on CookBookRecipeGet to approle
grant execute on CookBookGet to approle
grant execute on CookBookDelete to approle
grant execute on RecipeDesc to approle
grant execute on MealCal to approle
grant execute on MealListGet to approle
grant execute on RecipeDelete to approle
grant execute on RecipeDashboardGet to approle
