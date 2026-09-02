import { createBrowserRouter } from "react-router-dom";
import Recipes from "./Recipes";
import Meals from "./Meals";
import Cookbooks from "./Cookbooks";
import App from "./App";
import Home from "./Home";
import ProtectedRoute from "./ProtectedRoute";
import Login from "./Login";
import CookbookEdit from "./CookbookEdit";
import AutoCreate from "./AutoCreate";
import CookbookRecipes from "./CookbookRecipes";

const router = createBrowserRouter([
    {
        path: "/", element: <App />, children: [
            { index: true, element: <ProtectedRoute element={<Home />} requiredrole={0} /> },
            { path: "login", element: <Login frompath={location.pathname} /> },
            { path: "recipes", element: <ProtectedRoute element={<Recipes />} requiredrole={0} /> },
            { path: "meals", element: <ProtectedRoute element={<Meals />} requiredrole={2} /> },
            { path: "cookbooks", element: <ProtectedRoute element={<Cookbooks />} requiredrole={0} /> },
            { path: "cookbookedit", element: <ProtectedRoute element={<CookbookEdit />} requiredrole={0} /> },
            { path: "auto-create", element: <ProtectedRoute element={<AutoCreate />} requiredrole={0} /> },
            { path: "cookbook/recipelist", element: <ProtectedRoute element={<CookbookRecipes />} requiredrole={0} /> },
        ]
    },
]);
export default router;
