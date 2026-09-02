import { getUserStore, useSessionTimeout } from "@RuchyBrach/reactutils"
import { Link } from "react-router-dom"

export default function UserPanel() {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);
    const username = useUserStore(state => state.userName);
    const rolename = useUserStore(state => state.roleName);
    const logout = useUserStore(state => state.logout);

    useSessionTimeout({
        apiurl: apiurl,
        timeout: 1000 * 60 * 10,
        pathtologin: "/login",
    });

    return (
        <>
            {isLoggedIn ?
                (<><span>{username}</span> <button onClick={() => logout(username)}>Logout</button></>)
                :
                (<Link to="/login">Login</Link>)
            }
        </>
    )
}
