export interface ICuisine {
    cuisineId: number;
    cuisineName: string;
}

export interface IHHUser {
    hhUserId: number;
    userName: string;
}

export interface IRecipe {
    recipeId: number;
    hhUserId: number;
    cuisineId: number;
    recipeName: string;
    calories: number;
    // dateTimeDraft: string ;
    // dateTimePublished: string | null;
    // dateTimeArchived: string | null;
    recipeStatus: string;
    recipePic: string;
    vegan: boolean;
    userName: string;
    numIngredients: number;
    cookBookName: string;
    errorMessage: string;
}

export interface IRecipeDashboard {
    dashboardType: string;
    dashboardCount: number;
}

export interface IMeal {
    mealId: number;
    mealName: string;
    numCalories: number;
    numCourses: number;
    numRecipes: number;
    mealDesc: string
}

export interface ICookbook {
    cookBookId: number;
    cookBookName: string;
    userName: string;
    numRecipes: number;
    price: number;
    cookBookDateCreated: string;
}