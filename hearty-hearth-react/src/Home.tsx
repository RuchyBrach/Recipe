import { useEffect, useState } from "react";
import { fetchRecipeDashboard } from "./DataUtil";
import type { IRecipeDashboard } from "./DataInterfaces";
import DashboardCard from "./DashboardCard";
import { useNavigate } from "react-router-dom";

export default function Home() {
    const [recipeDashboardList, setRecipeDashboardList] = useState<IRecipeDashboard[]>([]);
    const navigate = useNavigate();

    useEffect(() => {
        async function getRecipeDashboard() {
            const data = await fetchRecipeDashboard();
            setRecipeDashboardList(data);
        }
        getRecipeDashboard();
    }, [])


    function handleDashboardItemSelected(dashboardItem: IRecipeDashboard) {
        navigate(`/${dashboardItem.dashboardType.toLowerCase()}s`);
    }
    return (
        <div>
            <img src="/images/Home.png" alt="picture of home" className="img-fluid p-0 w-auto" />
            <div className="row d-flex justify-content-center">
                <div className="col-10 m-4">
                    <p className="text-center">
                        Welcome to Hearty Hearth! A place where food, creativity, and inspiration come together. Discover delicious
                        recipes, create your own, and save your favorites all in one place. Build personalized cookbooks, organize
                        recipes by your favorite cuisines. Whether you're looking for something new to try, creating a recipe of your
                        own, or putting together the perfect cookbook, Hearty Hearth makes it easy to turn your favorite dishes into
                        something truly yours.
                    </p>
                </div>
                <div className="col-6 mb-5">
                    <div className="row align-items-center">
                        <div className="col-2 col-lg-1">
                            <img src="/images/dashboard/RecipeIcon.png" alt="picture of recipe icon" className="img-fluid d-inline-block pe-1" />
                        </div>
                        <div className="col-auto">Discover delicious recipes and find inspiration for your next meal.</div>
                    </div>
                    <div className="row align-items-center">
                        <div className="col-2 col-lg-1">
                            <img src="/images/dashboard/CreateIcon.png" alt="picture of create icon" className="img-fluid d-inline-block pe-1" />
                        </div>
                        <div className="col-auto">Create your own recipes and make them uniquely yours.</div>
                    </div>
                    <div className="row align-items-center">
                        <div className="col-2 col-lg-1">
                            <img src="/images/dashboard/CookbookIcon.png" alt="picture of cookbook icon" className="img-fluid d-inline-block pe-1" />
                        </div>
                        <div className="col-auto">Build personalized cookbooks and organize your favorite recipes.</div>
                    </div>
                    <div className="row align-items-center">
                        <div className="col-2 col-lg-1">
                            <img src="/images/dashboard/CuisineIcon.png" alt="picture of cuisine icon" className="img-fluid d-inline-block pe-1" />
                        </div>
                        <div className="col-auto">Explore different cuisines and discover new flavors.</div>
                    </div>
                </div>
                <div className="row d-flex justify-content-center g-2 mb-5">
                    {recipeDashboardList.map(d =>
                        <div key={d.dashboardType} className="col-9 col-md-4 d-flex justify-content-center">
                            <DashboardCard dashboardItem={d} onDashboardItemSelected={handleDashboardItemSelected} />
                        </div>
                    )}
                </div>
            </div >
        </div>
    )
}
