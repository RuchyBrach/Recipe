import type { ICuisine } from "./DataInterfaces"

interface Props {
    cuisine: ICuisine;
    isSelected: boolean;
    onSelected: (cuisineId: number) => void
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {
    return (
        <>
            <div onClick={() => onSelected(cuisine.cuisineId)} className={`btn ${isSelected ? "bg-secondary" : ""}`}>
                <figure className="figure">
                    <img src={`/images/cuisines/${cuisine.cuisineName.toLowerCase()}.png`} className="figure-img img-fluid rounded" alt="..." />
                    <figcaption className="figure-caption text-center">{cuisine.cuisineName}</figcaption>
                </figure>
            </div>
        </>
    )
}