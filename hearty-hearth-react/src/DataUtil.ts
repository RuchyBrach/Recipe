import type { FieldValues } from "react-hook-form";
import type { ICookbook, ICuisine, IHHUser, IMeal, IRecipe, IRecipeDashboard } from "./DataInterfaces";
import { createAPI, getUserStore } from "@RuchyBrach/reactutils";

let baseurl = import.meta.env.VITE_API_URL;
function api() {
    const sessionkey = getUserStore(baseurl).getState().sessionKey;
    return createAPI(baseurl, sessionkey);
}

export async function fetchUsers() {
    return await api().fetchData<IHHUser[]>("Recipe/users");
}

export async function fetchCuisines() {
    return await api().fetchData<ICuisine[]>("Recipe/cuisines");
}

export async function fetchRecipesByCuisineId(cuisineId: number) {
    return await api().fetchData<IRecipe[]>(`recipe/getbycuisine/${cuisineId}`);
}

export async function postRecipe(form: FieldValues) {
    return await api().postData<IRecipe>("Recipe", form);
}

export async function deleteRecipe(recipeId: number) {
    return await api().deleteData<IRecipe>(`Recipe?id=${recipeId}`);
}

export async function fetchRecipeDashboard() {
    return await api().fetchData<IRecipeDashboard[]>("App");
}

export async function fetchMeals() {
    return await api().fetchData<IMeal[]>("Meal")
}

export async function fetchCookbooks() {
    return await api().fetchData<ICookbook[]>("/Cookbook")
}

export const blankRecipe: IRecipe = {
    recipeId: 0,
    hhUserId: 0,
    cuisineId: 0,
    recipeName: "",
    calories: 0,
    // dateTimeDraft: null,
    // dateTimePublished: null,
    // dateTimeArchived: null,
    recipeStatus: "",
    recipePic: "",
    vegan: false,
    userName: "",
    numIngredients: 0,
    cookBookName: "",
    errorMessage: ""
}