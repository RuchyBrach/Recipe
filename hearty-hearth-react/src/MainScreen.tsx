import { useEffect, useState } from "react";
import type { IRecipe } from "./DataInterfaces";
import { blankRecipe, fetchRecipesByCuisineId } from "./DataUtil";
import RecipeCard from "./RecipeCard";
import { RecipeEdit } from "./RecipeEdit";
import { getUserStore } from "@RuchyBrach/reactutils";

interface Props {
    cuisineId: number
    cuisineClickCount: number
}

export default function MainScreen({ cuisineId, cuisineClickCount }: Props) {
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);
    const [isLoading, setIsLoading] = useState(false);
    const [recipeForEdit, setRecipeForEdit] = useState(blankRecipe);
    const [isRecipeEdit, setIsRecipeEdit] = useState(false);
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);

    useEffect(
        () => {
            if (cuisineId > 0) {
                setIsLoading(true);
                const fetchData = async () => {
                    const data = await fetchRecipesByCuisineId(cuisineId);
                    setRecipeList(data);
                    setIsRecipeEdit(false);
                    setIsLoading(false);
                }
                fetchData()
            }
        },
        [cuisineId, cuisineClickCount]
    )

    const handleRecipeSelectedForEdit = (recipe: IRecipe) => {
        setRecipeForEdit(recipe);
        setIsRecipeEdit(true);
    }

    return (
        <>
            <div className="row">
                <div className={isLoading ? "placeholder-glow" : ""}>
                    <h2 className={`mt-2 bg-light w-100 ${isLoading ? "placeholder" : ""}`}>
                        {recipeList.length} Recipes
                    </h2>
                </div>
            </div>
            <div className="row">
                <div className="col-3">
                    {isLoggedIn ? <button onClick={() => handleRecipeSelectedForEdit(blankRecipe)} className="btn btn-outline-dark m-2">New Recipe</button> : null}
                </div>
            </div>
            <div className="row">
                {isRecipeEdit ? <RecipeEdit recipe={recipeForEdit} /> :
                    recipeList.map(r =>
                        <div key={r.recipeId} className="col-md-6 col-lg-3 mb-2">
                            <RecipeCard recipe={r} onRecipeSelectedForEdit={handleRecipeSelectedForEdit} />
                        </div>
                    )
                }
            </div>

        </>
    )
}