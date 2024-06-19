-- SM Excellent! See comments, fix and resubmit. The spec and sketch should be in different files.
/*
We have a very popular recipe website. As it grows we get more problems. It's very hard to manage the
whole site. We need help. 
We have recipes, meals and cookBooks. We could show a recipe on one page and that recipe might be part of
a meal or also a cookbook and then we have the recipe duplicated on multiple pages. That's mainly the 
source of our problems. When you fix things in one place and you don't fix it in a different place then
you have 2 different recipes.(You have to fix it in many other places.)
Recipes: The recipe has cuisine type. The recipe has ingredients which has a measurement type and amount.
The ingredients are put into a specific order (the author of the recipe knows what sequence to put it in). 
We need to record the sequence of ingredients in the recipe.
Cuisine: We have master list of cuisine. 
Directions: Directions have steps and they are in a specific order.Steps have a number and then the instructions.
Recipe status: First a recipe is a draft - which is not shown on the website (staff is working on it). 
Then they publish it and people can view it on the website. After a While it goes into archive. 
We need to know when it became a draft, when it was published and when it went into archive - (date and time). 
The purpose of that is to see how long a recipe was published for before it went into archive and how long did a staff member work on it.
Archived not deleted. Sometimes we do delete things but that can be done as a maintenance task. The regular staff 
should be able to move things from draft to published to archived. 
Meal: The meal has a name, then they make courses in the meal. There are different course types. Each course could have multiple recipes in it. 
The courses have a sequence in the meal. 
Everything in the system has a name that's unique. You can't have two ingredients with the same name. 
The name of an ingredient, recipe, meal and book are unique. 
A meal can't have two of same course type. If you have two appetizers it should be as two recipes in the course type. Then you could sequence them.
CookBook: A cookbook has a name, a price and recipes. We don't put the meal into the cookbook.
We have a cookbook and a cookbook has recipes and the recipes have a sequence how they're presented in the cookbook.
Each picture belongs to a certain type (ing./recipe/meal/book). 
Picture name format: Name of the Type, Name of the Ingredient(there are no spaces). ex.Recipe_Family_Pizza.jpg (they're all jpegs).
User: the staff has a firstname, lastname and a username. 
Anything that was created in the system, we'll have to know who the user is. Recipe, meal and book is created by a user. 
*/ 

