import { getUserStore } from "@RuchyBrach/reactutils";
import type { IRecipeDashboard } from "./DataInterfaces";

interface Props {
    dashboardItem: IRecipeDashboard;
    onDashboardItemSelected: (dashboardItem: IRecipeDashboard) => void;
}
export default function DashboardCard({ dashboardItem, onDashboardItemSelected }: Props) {
    const apiurl = import.meta.env.VITE_API_URL;
    const useUserStore = getUserStore(apiurl);
    const isLoggedIn = useUserStore(state => state.isLoggedIn);

    const dashboardItemType = dashboardItem.dashboardType;
    return (
        <div className="card h-100 w-75">
            <img src={`/images/dashboard/${dashboardItemType}.png`} className="card-img-top" alt={`picture of ${dashboardItemType}`} />
            <div className="card-body d-flex flex-column">
                {/* <h5 className="card-title">Recipes</h5> */}
                {/* <p className="card-text"></p> */}
                {isLoggedIn ? <button onClick={() => { onDashboardItemSelected(dashboardItem) }} className="btn btn-outline-dark mt-auto">{`Click to see ${dashboardItem.dashboardCount} ${dashboardItemType}${dashboardItem.dashboardCount > 1 ? "s" : ""}`}</button> : null}
            </div>
        </div>
    )
}
