import { useForm, type FieldValues } from "react-hook-form"
import { type ICuisine, type IHHUser, type IRecipe } from "./DataInterfaces"
import { blankRecipe, deleteRecipe, fetchCuisines, fetchUsers, postRecipe } from "./DataUtil";
import { useEffect, useState } from "react";
import { getUserStore } from "@RuchyBrach/reactutils";

interface Props {
    recipe: IRecipe;
}

export function RecipeEdit({ recipe }: Props) {
    const { register, handleSubmit, reset } = useForm({ defaultValues: recipe });
    const [users, setUsers] = useState<IHHUser[]>([]);
    const [cuisines, setCuisines] = useState<ICuisine[]>([]);
    const [errormsg, setErrorMsg] = useState("");
    const [currentRecipe, setCurrentRecipe] = useState(blankRecipe);
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const roleRank = useUserStore(state => state.roleRank);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchUsers();
            setUsers(data);
            reset(recipe);
        }
        fetchdata();
    }, []);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisines();
            setCuisines(data);
            reset(recipe);
        }
        fetchdata();
    }, []);

    useEffect(() => {
        setCurrentRecipe(recipe);
        reset(recipe);
    }, [recipe, reset]);

    const submitForm = async (data: FieldValues) => {
        const r = await postRecipe(data);
        setErrorMsg(r.errorMessage);
        setCurrentRecipe(r);
        reset(r);
    }

    const onDelete = async () => {
        try {
            const r = await deleteRecipe(currentRecipe.recipeId);
            setErrorMsg(r.errorMessage);
            if (r.errorMessage == "") {
                reset(blankRecipe);
            }
        }
        catch (error: unknown) {
            if (error instanceof Error) {
                setErrorMsg(error.message);
            }
            else {
                setErrorMsg("An unknown error occurred.");
            }
        }
    }

    return (
        <div className="bg-light mt-4 p-4">
            <div className="row">
                <div className="col-12">
                    <h2 id="msg">{errormsg}</h2>
                </div>
            </div>
            <div className="row">
                <div className="col-12">
                    <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                        <input type="hidden" id="recipeId" {...register("recipeId")} />

                        <div className="mb-3">
                            <label htmlFor="hhUserId" className="form-label">User Name:</label>
                            <select id="hhUserId" {...register("hhUserId")} className="form-select" required>
                                {users.map(u => <option key={u.hhUserId} value={u.hhUserId}>{u.userName}</option>)}
                            </select>
                        </div>
                        <div className="mb-3">
                            <label htmlFor="cuisineId" className="form-label">Cuisine:</label>
                            <select id="cuisineId" {...register("cuisineId")} className="form-select" required>
                                {cuisines.map(c => <option key={c.cuisineId} value={c.cuisineId}>{c.cuisineName}</option>)}
                            </select>
                        </div>
                        <div className="mb-3">
                            <label htmlFor="recipeName" className="form-label">Recipe Name:</label>
                            <input type="text" id="recipeName" {...register("recipeName")} className="form-control" required />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="calories" className="form-label">Calories:</label>
                            <input type="number" id="calories" {...register("calories")} className="form-control" required />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="recipeStatus" className="form-label">Recipe Status:</label>
                            <input type="string" id="recipeStatus" {...register("recipeStatus")} className="form-control" readOnly required />
                        </div>
                        <div className="d-flex justify-content-between">
                            <div>
                                <button type="submit" className="btn btn-success mx-2">Submit</button>
                                {roleRank >= 3 ? <button type="button" onClick={onDelete} id="btnDelete" className="btn btn-danger">Delete</button> : null}
                            </div>
                            <button type="button" id="btnClone" className="btn btn-outline-dark">Clone</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}