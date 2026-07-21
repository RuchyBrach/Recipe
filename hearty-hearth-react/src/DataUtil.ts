import type { ICuisine, IRecipe } from "./DataInterfaces";

const baseurl = "https://recipewebrb.azurewebsites.net/api/"

async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchCuisines() {
    return await fetchData<ICuisine[]>("cuisine");
}

export async function fetchRecipes(cuisineId: number) {
    return await fetchData<IRecipe[]>(`recipe/getbycuisine/${cuisineId}`);
}