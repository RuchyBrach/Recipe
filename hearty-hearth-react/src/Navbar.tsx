import { NavLink } from "react-router-dom";
import UserPanel from "./UserPanel";
import { getUserStore } from "@RuchyBrach/reactutils";

export default function Navbar() {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);

    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-light bg-light">
                <div className="container-fluid d-flex justify-content-between">
                    <div className="d-flex flex-grow-1">
                        <NavLink className="navbar-brand f-" to="/">
                            <img src="/images/BrandLogo.png" alt="" width="120" className="d-inline-block pe-3" />
                            HEARTY HEARTH
                        </NavLink>
                        <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                            <span className="navbar-toggler-icon"></span>
                        </button>
                        {isLoggedIn ?
                            <div className="collapse navbar-collapse" id="navbarNav">
                                <ul className="navbar-nav">
                                    <li className="nav-item">
                                        <NavLink to="/recipes" className="nav-link">Recipes</NavLink>
                                    </li>
                                    <li className="nav-item">
                                        <NavLink to="/meals" className="nav-link">Meals</NavLink>
                                    </li>
                                    <li className="nav-item dropdown">
                                        <button className="nav-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">Cookbooks</button>
                                        <ul className="dropdown-menu">
                                            <li>
                                                <NavLink to="/cookbooks" className="dropdown-item">Library</NavLink>
                                            </li>
                                            <li>
                                                <NavLink to="/cookbookedit" className="dropdown-item">New Cookbook</NavLink>
                                            </li>
                                            <li>
                                                <NavLink to="/auto-create" className="dropdown-item">Auto-Create</NavLink>
                                            </li>
                                        </ul>
                                    </li>

                                </ul>
                            </div> : null}
                    </div>
                    <div>
                        <UserPanel />
                    </div>

                </div>
            </nav>
        </>
    )
}