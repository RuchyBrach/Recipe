import { useState, useEffect } from "react";
import type { ICuisine } from "./DataInterfaces";
import { fetchCuisines } from "./DataUtil";
import CuisineButton from "./CuisineButton";

interface Props {
    onCuisineSelected: (cuisineId: number) => void;
}

export default function Sidebar({ onCuisineSelected }: Props) {
    const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisineId, setSelectedCuisineId] = useState(0);

    useEffect(
        () => {
            const fetchData = async () => {
                const data = await fetchCuisines();
                setCuisineList(data);
                if (data.length > 0) {
                    handleSelectedCuisine(data[0].cuisineId);
                }
            }
            fetchData();
        },
        []
    )

    function handleSelectedCuisine(cuisineId: number) {
        setSelectedCuisineId(cuisineId);
        onCuisineSelected(cuisineId);
    }

    return (
        <>
            <h2>
                {
                    cuisineList.map(c =>
                        <CuisineButton key={c.cuisineId} cuisine={c} onSelected={handleSelectedCuisine} isSelected={c.cuisineId == selectedCuisineId} />
                    )
                }
            </h2>
        </>
    )
}