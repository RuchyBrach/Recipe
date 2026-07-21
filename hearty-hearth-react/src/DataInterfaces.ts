export interface ICuisine {
    cuisineId: number;
    cuisineName: string;
}

export interface IRecipe {
    recipeId: number;
    hhUserId: number;
    cuisineId: number;
    recipeName: string;
    calories: number;
    dateTimeDraft: string;
    dateTimePublished: string | null;
    dateTimeArchived: string | null;
    recipeStatus: string;
    recipePic: string;
    vegan: boolean;
    userName: string;
    numIngredients: number;
    cookBookName: string;
}