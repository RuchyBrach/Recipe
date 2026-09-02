import { getUserStore } from "@RuchyBrach/reactutils";
import type { IRecipe } from "./DataInterfaces"

interface Props {
    recipe: IRecipe
    onRecipeSelectedForEdit: (recipe: IRecipe) => void;
}

export default function RecipeCard({ recipe, onRecipeSelectedForEdit }: Props) {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);

    return (
        <>
            <div className="card h-100">
                <img src={`/images/recipes/${recipe.recipePic.toLowerCase()}`} className="card-img-top" alt="..." />
                <div className="card-body d-flex flex-column">
                    <h5 className="card-title">{recipe.recipeName}</h5>
                    <p className="card-text"></p>
                    {isLoggedIn ? <button onClick={() => { onRecipeSelectedForEdit(recipe) }} className="btn btn-outline-dark mt-auto">Edit Recipe</button> : null}
                </div>
            </div>
        </>
    )
}