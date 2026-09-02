import { useState } from 'react'
import Sidebar from './Sidebar';
import MainScreen from './MainScreen';

export default function Recipes() {
    const [selectedCuisineId, setSelecteCuisineId] = useState(0);
    const [cuisineClickCount, setCuisineClickCount] = useState(0);

    const handleCuisineSelected = (cuisineId: number) => {
        setSelecteCuisineId(cuisineId);
        setCuisineClickCount(c => c + 1);
    };

    return (
        <div>
            <div className="row  d-flex justify-content-center">
                <div className="col">
                    <img src="/images/headers/RecipeHeader.png" alt="picture of meal header" className="img-fluid p-0 w-auto mt-2" />
                </div>
            </div>
            <div className="row">
                <div className="col-3 col-lg-2 border border-light">
                    <Sidebar onCuisineSelected={handleCuisineSelected} />
                </div>
                <div className="col-9 col-lg-10">
                    <MainScreen cuisineId={selectedCuisineId} cuisineClickCount={cuisineClickCount} />
                </div>
            </div>
        </div>
    )
}
