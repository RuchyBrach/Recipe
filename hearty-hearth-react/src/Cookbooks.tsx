import type { ICookbook } from "./DataInterfaces"
import { useEffect, useState } from "react"
import { fetchCookbooks } from "./DataUtil";
import "./assets/css/custom.css";
import { useNavigate } from "react-router-dom";


export default function Meals() {
    const [cookbookList, setCookbookList] = useState<ICookbook[]>([]);
    const [selectedCookbookId, setSelectedCookbookId] = useState(0);
    const navigate = useNavigate();

    useEffect(() => {
        async function getCookbooks() {
            const data = await fetchCookbooks();
            setCookbookList(data);
        }
        getCookbooks()
    }, [])

    const handleCookbookSelected = (cookbook: ICookbook) => {
        setSelectedCookbookId(cookbook.cookBookId);
    }

    const handleOutsideClick = () => {
        setSelectedCookbookId(0);
    }

    const handleViewRecipes = () => {
        const cookbook = cookbookList.find(c => c.cookBookId === selectedCookbookId);
        navigate("/cookbook/recipe")
    }

    return (
        <div className="cookbook-library">
            {selectedCookbookId === 0 ? (
                <div className="row d-flex justify-content-center p-5">
                    {cookbookList.map(c => (
                        <div className="col-3" key={c.cookBookId}>
                            <img
                                src={`/images/cookbooks/${c.cookBookName.replaceAll(" ", "").toLowerCase()}.png`}
                                alt={`picture of ${c.cookBookName}`}
                                className="img-fluid cookbook-cover"
                                onClick={() => handleCookbookSelected(c)} />
                        </div>)
                    )}
                </div>
            ) : (
                <div className="cookbook-selected" onClick={handleOutsideClick}>
                    <img src={`/images/cookbooks/${cookbookList.find(c => c.cookBookId === selectedCookbookId)?.cookBookName.replaceAll(" ", "").toLowerCase()}.png`}
                        alt="selected cookbook"
                        className="selected-cookbook"
                        onClick={(e) => e.stopPropagation()}
                    />
                    <button className="btn btn-outline-dark mt-3" onClick={(e) => e.stopPropagation()}>click to see recipes</button>
                </div>
            )
            }
        </div>
    )
}
