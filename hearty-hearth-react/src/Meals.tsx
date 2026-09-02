import type { IMeal } from "./DataInterfaces"
import { useEffect, useState } from "react"
import { fetchMeals } from "./DataUtil";


export default function Meals() {
    const [mealList, setMealList] = useState<IMeal[]>([]);
    useEffect(() => {
        async function getMeals() {
            const data = await fetchMeals();
            setMealList(data);
        }
        getMeals()
    }, [])

    return (
        <div>
            <img src="/images/headers/MealHeader.png" alt="picture of meal header" className="img-fluid p-0 w-auto mt-2" />

            <div className="col-8">
                <table className="table table-bordered table-sm table-responsive table-hover">
                    <thead>
                        <tr>
                            <th>Meal</th>
                            <th>Total Calories</th>
                            <th>Courses</th>
                            <th>Recipes in Meal</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                    <tbody>
                        {mealList.map(m => (
                            <tr key={m.mealId}>
                                <td>{m.mealName}</td>
                                <td>{m.numCalories}</td>
                                <td>{m.numCourses}</td>
                                <td>{m.numRecipes}</td>
                                <td>{m.mealDesc}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        </div>
    )
}
